using System;
using System.Collections.Generic;
using System.Text;
using MacroScope;
using System.Data;
using MyApplication;
using Microsoft.Pex.Framework;
using MockDBMSCE.SqlCeServer;
using System.Diagnostics;

namespace MockDBMS.SqlCeServer
{
    public class MockSqlCeCommand : IDisposable
    {
        //SqlDataReader
        public MockSqlCeConnection connection;
        private string commandText;
        private MockSqlCeParameterCollection parameters;

        int numAffectedRecords;

        public MockSqlCeParameterCollection Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }


        public string CommandText
        {
            get { return commandText; }
            set { commandText = value; }
        }
        public QueryParts parsedQuery;

        public MockSqlCeCommand(string q, MockSqlCeConnection myConnection)
        {
            this.commandText = q;
            this.connection = myConnection;
            parameters = new MockSqlCeParameterCollection(this);
        }

        public MockSqlCeCommand(MockSqlCeConnection myConnection)
        {
            this.connection = myConnection;
            parameters = new MockSqlCeParameterCollection(this);
        }


        public MockSqlCeDataReader ExecuteReader()
        {
            parsedQuery = parseQuery(commandText);
            //tempQueryParser(query);
            List<object[]> records = null;
            List<object[]> selectedRecords = new List<object[]>();
            if (parsedQuery.Type == QueryStatementType.SELECT)
            {
                if (parsedQuery.TableNames.Count == 1)
                {
                    MockDBMS.Table table = connection.Dbms.GetTableByName(parsedQuery.TableNames[0]);
                    records = table.getRecordsWith(parsedQuery.whereCondition, new List<object[]>());
                    if (parsedQuery.joinCondition != null)
                    {
                        List<object[]> joinRecords = table.getRecordsWith(parsedQuery.joinCondition, new List<object[]>());
                        records = table.PerformOperationOnRecords(records, joinRecords, "AND");
                    }

                    selectedRecords = SelectColumnsFrom(records, parsedQuery, table);
                }
                else
                {
                    Dictionary<string, Table> tables = new Dictionary<string, Table>();
                    foreach (string tableName in parsedQuery.TableNames)
                    {
                        MockDBMS.Table table = connection.Dbms.GetTableByName(tableName);
                        tables.Add(tableName, table);
                    }
                    Dictionary<string, List<object[]>> recordsFromDifferentTables = new Dictionary<string, List<object[]>>();
                    recordsFromDifferentTables = getRecordsFrommDifferentTablesWith(parsedQuery.whereCondition, tables);
                    if (parsedQuery.joinCondition != null)
                    {
                        Dictionary<string, List<object[]>> joinRecords = getRecordsFrommDifferentTablesWith(parsedQuery.joinCondition, tables);
                        recordsFromDifferentTables = PerformOperationOnRecords(recordsFromDifferentTables, joinRecords, "AND");//table.PerformOperationOnRecords(records, joinRecords, "AND");
                    }

                    selectedRecords = SelectColumnsFromMultipleTables(recordsFromDifferentTables, parsedQuery, tables);
                    if (parsedQuery.Distinct)
                        selectedRecords = SelectDistinct(selectedRecords);
                }
                //records = table.getRecordsWith(parsedQuery.whereConditionLHS, parsedQuery.whereConditionop, parsedQuery.whereConditionop);
            }
            else if (parsedQuery.Type == QueryStatementType.DELETE)
            {
                if (parsedQuery.TableNames.Count == 1)
                {
                    MockDBMS.Table table = connection.Dbms.GetTableByName(parsedQuery.TableNames[0]);
                    records = table.getRecordsWith(parsedQuery.whereCondition, new List<object[]>());
                    if (records.Count != 0)
                    {
                        numAffectedRecords = records.Count;
                        table.DeleteRecords(records);
                    }
                }
                else
                {
                    throw new NotImplementedException("Not Implemented for deletion from multiple tables");
                }
            }

            else if (parsedQuery.Type == QueryStatementType.INSERT)
            {
                if (parsedQuery.TableNames.Count == 1)
                {
                    MockDBMS.Table table = connection.Dbms.GetTableByName(parsedQuery.TableNames[0]);
                    

                    //PexAssume.IsTrue(table != null);
                    object[] record = new object[table.numColumns];
                    IEnumerator<string> keys = parsedQuery.ColumnNameValueMap.Keys.GetEnumerator();
                    while (keys.MoveNext())
                    {
                        string key = keys.Current;
                        key = key.Trim('[', ']');
                        if(key.Contains("["))
                            key = key.Substring(1, key.Length-2);
                        record[table.ColumnIndices[key]] = parsedQuery.ColumnNameValueMap[key];
                    }
                    table.InsertRecord(record);
                    numAffectedRecords = 1;
                }
                else
                {
                    throw new NotImplementedException("Not Implemented for deletion from multiple tables");
                }
            }
            else if (parsedQuery.Type == QueryStatementType.UPDATE)
            {
                if (parsedQuery.TableNames.Count == 1)
                {
                    MockDBMS.Table table = connection.Dbms.GetTableByName(parsedQuery.TableNames[0]);
                    records = table.getRecordsWith(parsedQuery.whereCondition, new List<object[]>());
                    foreach (object[] record in records)
                    {
                        IEnumerator<string> keys = parsedQuery.ColumnNameValueMap.Keys.GetEnumerator();
                        while (keys.MoveNext())
                        {
                            string key = keys.Current;
                            key = key.Trim('[', ']');
                            if (key.Contains("["))
                            {
                                key = key.Substring(1, key.Length - 2);
                            }
                            Console.WriteLine("key = " +key);
                            record[table.ColumnIndices[key]] = parsedQuery.ColumnNameValueMap[keys.Current];
                        }

                    }
                    return new MockSqlCeDataReader(records);
                }
                else
                {
                    throw new NotImplementedException("Not Implemented for deletion from multiple tables");
                }
            }


            return new MockSqlCeDataReader(selectedRecords);
        }

        private List<object[]> SelectDistinct(List<object[]> selectedRecords)
        {
            List<object[]> distinctRecords = new List<object[]>();

            foreach (object[] o in selectedRecords)
            {
                bool isDistinct = true;
                foreach (object[] d in distinctRecords)
                {
                    for (int i = 0; i < o.Length; i++)
                    {
                        if (o[i].Equals(d[i]))
                            isDistinct = false;
                        else
                        {
                            isDistinct = true;
                            break;
                        }
                    }
                    if (!isDistinct)
                        break;
                }
                if (isDistinct)
                    distinctRecords.Add(o);
            }
            return distinctRecords;
        }

        private List<object[]> SelectColumnsFromMultipleTables(Dictionary<string, List<object[]>> records, QueryParts parsedQuery, Dictionary<string, Table> tables)
        {
            List<object[]> selectedRecords = new List<object[]>();
            List<string> columnsToBeSelected = new List<string>();
            List<string> columnTableNames = new List<string>();

            if (parsedQuery.IsSelectAll)
            {
                foreach (string tableName in tables.Keys)
                {
                    Table table = tables[tableName];
                    IEnumerator<string> columnEnumerator = table.ColumnNameType.Keys.GetEnumerator();
                    while (columnEnumerator.MoveNext())
                    {
                        columnsToBeSelected.Add(columnEnumerator.Current);
                    }
                }
            }
            else
            {
                columnsToBeSelected = parsedQuery.selectedColumns;
                columnTableNames = parsedQuery.selectedColumnFrom;
            }
            int columnIndex = 0;
            foreach (string column in columnsToBeSelected)
            {
                object[] selectedRecord = new object[columnsToBeSelected.Count];
                columnIndex = columnsToBeSelected.IndexOf(column);
                string tableName = columnTableNames[columnIndex];
                Table table = tables[tableName];
                Console.WriteLine("table " + tableName);
                List<object[]> recordsInTable = records[tableName];
                int rowIndex = 0;
                if (recordsInTable == null)
                    continue;
                foreach (object[] record in recordsInTable)
                {
                    if (selectedRecords.Count > rowIndex)
                        selectedRecord = selectedRecords[rowIndex];
                    else
                    {
                        selectedRecord = new object[columnsToBeSelected.Count];
                        selectedRecords.Add(selectedRecord);
                    }
                    if (selectedRecord == null)
                        selectedRecord = new object[columnsToBeSelected.Count];
                    selectedRecord[columnIndex] = record[table.ColumnIndices[column]];
                    selectedRecords[rowIndex++] = selectedRecord;

                }
            }
            return selectedRecords;
        }


        private Dictionary<string, List<object[]>> getRecordsFrommDifferentTablesWith(Expression condition, Dictionary<string, Table> tables)
        {
            //throw new NotImplementedException();
            Dictionary<string, List<object[]>> records = new Dictionary<string, List<object[]>>();
            foreach (string tableName in tables.Keys)
            {
                records.Add(tableName, tables[tableName].Records);
            }

            Dictionary<string, List<object[]>> resultSet = new Dictionary<string, List<object[]>>();
            string left = null;
            string right = null;
            string op;

            if (condition.Operator == null)
            {
                throw new Exception("operator cannot be null");
            }
            op = condition.Operator.Value;

            Expression lhs;
            Expression rhs;
            if (condition.Left is PatternExpression)
            {
                lhs = (Expression)((PatternExpression)condition.Left).Expression;
                //rhs = (Expression)((PatternExpression)condition.Right).Expression;
            }
            else
            {
                lhs = (Expression)condition.Left;
                //rhs = (Expression)condition.Right;
            }
            if (condition.Right is PatternExpression)
            {
                //lhs = (Expression)((PatternExpression)condition.Left).Expression;
                rhs = (Expression)((PatternExpression)condition.Right).Expression;
            }
            else
            {
                //lhs = (Expression)condition.Left;
                rhs = (Expression)condition.Right;
            }


            if (op.Equals("NOT"))
            {
                PexAssert.IsNull(lhs);
                PexAssert.IsNotNull(rhs);
                PexAssert.IsNotNull(rhs.Operator);
                Dictionary<string, List<object[]>> rec = getRecordsFrommDifferentTablesWith(rhs, tables);
                resultSet = PerformOperationOnRecords(records, rec, op);
                return resultSet;

            }
            PexAssert.IsNotNull(lhs);
            PexAssert.IsNotNull(rhs);

            Dictionary<string, List<object[]>> lhsRecords;
            Dictionary<string, List<object[]>> rhsRecords;

            if (op.Equals("=") || op.Equals("<") || op.Equals("<=")
                || op.Equals(">") || op.Equals(">=") || op.Equals("!="))
            {
                bool isNegative = false;
                PexAssert.IsNull(lhs.Operator);
                PexAssert.IsTrue(rhs.Operator == null || rhs.Operator.Value == "-");
                if (rhs.Operator != null && rhs.Operator.Value == "-")
                    isNegative = true;

                if (lhs.Right is IntegerValue && rhs.Right is IntegerValue)
                {
                    if (!isNegative)
                    {
                        if (((IntegerValue)lhs.Right).Value == ((IntegerValue)rhs.Right).Value)
                        {
                            resultSet = records;
                            return resultSet;
                        }
                    }
                    else
                    {
                        if (((IntegerValue)lhs.Right).Value == -((IntegerValue)rhs.Right).Value)
                        {
                            resultSet = records;
                            return resultSet;
                        }
                    }
                }
                else if (lhs.Right is StringValue && rhs.Right is StringValue)
                {
                    if (((StringValue)lhs.Right).Value == ((StringValue)rhs.Right).Value)
                    {
                        resultSet = records;
                        return resultSet;
                    }
                }

                DbObject rightPart = (DbObject)lhs.Right;
                string leftTableName, leftColumnName;
                string rightTableName, rightColumnName;

                leftTableName = ((DbObject)lhs.Right).Identifier.ID;
                leftColumnName = ((DbObject)lhs.Right).Next.Identifier.ID;

                if (rhs.Right is IntegerValue)
                {
                    right = ((IntegerValue)rhs.Right).Value.ToString();
                }
                else if (rhs.Right is StringValue)
                {
                    right = ((StringValue)rhs.Right).Value;
                }

                else if (rhs.Right is DbObject)
                {
                    Dictionary<string, List<object[]>> rec = new Dictionary<string, List<object[]>>();
                    foreach (string t in tables.Keys)
                        rec.Add(t, tables[t].Records);
                    return SelectRecordsFromDifferentTables((DbObject)lhs.Right, (DbObject)rhs.Right, null, op, rec, tables);
                }

                Console.WriteLine("leftTableName " + leftTableName);
                leftTableName = leftTableName.Trim('[', ']');
                if (leftTableName.Contains("[") && leftTableName.Contains("]"))
                {
                    leftTableName = leftTableName.Substring(1, leftTableName.Length - 2);
                }

                Console.WriteLine("leftTableName " + leftTableName);
                Table table = tables[leftTableName];
                List<object[]> tableResultSet = table.SelectRecords(leftColumnName, right, op, new List<object[]>());
                resultSet.Add(table.name, tableResultSet);
                foreach (string t in tables.Keys)
                {
                    if (t != table.name)
                        resultSet.Add(t, null);
                }

            }
            else if (op.Equals("AND") || op.Equals("OR"))
            {
                PexAssert.IsNotNull(lhs.Operator);
                lhsRecords = getRecordsFrommDifferentTablesWith(lhs, tables);
                PexAssert.IsNotNull(rhs.Operator);
                rhsRecords = getRecordsFrommDifferentTablesWith(rhs, tables);
                resultSet = PerformOperationOnRecords(lhsRecords, rhsRecords, op);
            }
            else if (op.Equals("LIKE"))
            {
                /*
                PexAssert.IsNull(lhs.Operator);
                PexAssert.IsNull(rhs.Operator);
                right = ((StringValue)rhs.Right).Value.ToString();
                left = ((DbObject)lhs.Right).Identifier.ID;
                resultSet = SelectRecords(left, right, op, recds);
            
                 */
            }

            return resultSet;


        }


        /*To be implemented for 
         * Operators: LIKE, IS NULL, IS NOT NULL
         */
        private Dictionary<string, List<object[]>> SelectRecordsFromDifferentTables(
            DbObject left, DbObject right, string rightString, string op, Dictionary<string, List<object[]>> records, Dictionary<string, Table> tables)
        {
            string leftTable = null, leftColumn;
            string rightTable = null, rightColumn;

            if (left.HasNext)
            {
                leftTable = left.Identifier.ID;
                leftColumn = left.Next.Identifier.ID;
            }
            else
                leftColumn = left.Identifier.ID;

            if (right.HasNext)
            {
                rightTable = right.Identifier.ID;
                rightColumn = right.Next.Identifier.ID;
            }
            else
                rightColumn = right.Identifier.ID;


            leftColumn = leftColumn.Trim('[', ']');
            if (leftColumn.Contains("["))
            {
                leftColumn = leftColumn.Substring(1, leftColumn.Length - 2);
            }
            rightColumn = rightColumn.Trim('[', ']');
            if (rightColumn.Contains("["))
            {
                rightColumn = rightColumn.Substring(1, rightColumn.Length - 2);
            }

            Console.WriteLine("left = " + leftTable + " right = " + rightTable);
            if (leftTable.Contains("["))
            {
                leftTable = leftTable.Substring(1, leftTable.Length - 2);
            }
            rightColumn = rightColumn.Trim('[', ']');
            if (rightTable != null && rightTable.Contains("["))
            {
                rightTable = rightTable.Substring(1, rightTable.Length - 2);
            }


            Dictionary<string, List<object[]>> resultSet = new Dictionary<string, List<object[]>>();

            List<object[]> leftResultSet = new List<object[]>();
            List<object[]> rightResultSet = new List<object[]>();

            PexAssert.IsTrue(leftTable != null && rightTable != null);
            Console.WriteLine("left = " + leftTable + " right = " + rightTable);
            if (op.Equals("=") || op.Equals("!=") || op.Equals("<") || op.Equals("<=") || op.Equals(">") || op.Equals(">="))
            {
                List<object[]> leftRecords = records[leftTable];
                List<object[]> rightRecords = records[rightTable];

                foreach (object[] leftRecord in leftRecords)
                {
                    object leftObj = leftRecord[tables[leftTable].ColumnIndices[leftColumn]];
                    DataTypes leftType = tables[leftTable].ColumnNameType[leftColumn];

                    foreach (object[] rightRecord in rightRecords)
                    {
                        object rightObj = rightRecord[tables[rightTable].ColumnIndices[rightColumn]];
                        DataTypes rightType = tables[rightTable].ColumnNameType[rightColumn];
                        PexAssert.IsTrue(leftType == rightType);

                        if (leftType == DataTypes.STRING)
                        {
                            if (op.Equals("="))
                            {
                                if (leftObj.Equals(rightObj))
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }
                            }
                            else if (op.Equals("!="))
                            {
                                if (!leftObj.Equals(rightObj))
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }
                            }
                        }
                        else if (leftType == DataTypes.INT)
                        {
                            //Int64 number = System.Convert.ToInt64(right, 10);
                            if (op.Equals("="))
                            {
                                if (leftObj is System.Decimal)
                                {
                                    Int64 leftNumber = Decimal.ToInt64((Decimal)leftObj);
                                    Int64 rightNumber = Decimal.ToInt64((Decimal)rightObj);

                                    if (leftNumber == rightNumber)
                                    {
                                        leftResultSet.Add(leftRecord);
                                        rightResultSet.Add(rightRecord);
                                    }
                                }
                                else if ((int)leftObj == (int)rightObj)
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }

                            }
                            else if (op.Equals("!="))
                            {
                                if (leftObj is System.Decimal)
                                {
                                    Int64 leftNumber = Decimal.ToInt64((Decimal)leftObj);
                                    Int64 rightNumber = Decimal.ToInt64((Decimal)rightObj);

                                    if (leftNumber != rightNumber)
                                    {
                                        leftResultSet.Add(leftRecord);
                                        rightResultSet.Add(rightRecord);
                                    }
                                }
                                else if ((int)leftObj != (int)rightObj)
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }
                            }
                            else if (op.Equals("<"))
                            {
                                if (leftObj is System.Decimal)
                                {
                                    Int64 leftNumber = Decimal.ToInt64((Decimal)leftObj);
                                    Int64 rightNumber = Decimal.ToInt64((Decimal)rightObj);

                                    if (leftNumber < rightNumber)
                                    {
                                        leftResultSet.Add(leftRecord);
                                        rightResultSet.Add(rightRecord);
                                    }
                                }
                                else if ((int)leftObj < (int)rightObj)
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }
                            }
                            else if (op.Equals("<="))
                            {
                                if (leftObj is System.Decimal)
                                {
                                    Int64 leftNumber = Decimal.ToInt64((Decimal)leftObj);
                                    Int64 rightNumber = Decimal.ToInt64((Decimal)rightObj);

                                    if (leftNumber <= rightNumber)
                                    {
                                        leftResultSet.Add(leftRecord);
                                        rightResultSet.Add(rightRecord);
                                    }
                                }
                                else if ((int)leftObj <= (int)rightObj)
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }
                            }
                            else if (op.Equals(">"))
                            {
                                if (leftObj is System.Decimal)
                                {
                                    Int64 leftNumber = Decimal.ToInt64((Decimal)leftObj);
                                    Int64 rightNumber = Decimal.ToInt64((Decimal)rightObj);

                                    if (leftNumber > rightNumber)
                                    {
                                        leftResultSet.Add(leftRecord);
                                        rightResultSet.Add(rightRecord);
                                    }
                                }
                                else if ((int)leftObj > (int)rightObj)
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }
                            }
                            else if (op.Equals(">="))
                            {
                                if (leftObj is System.Decimal)
                                {
                                    Int64 leftNumber = Decimal.ToInt64((Decimal)leftObj);
                                    Int64 rightNumber = Decimal.ToInt64((Decimal)rightObj);

                                    if (leftNumber >= rightNumber)
                                    {
                                        leftResultSet.Add(leftRecord);
                                        rightResultSet.Add(rightRecord);
                                    }
                                }
                                else if ((int)leftObj >= (int)rightObj)
                                {
                                    leftResultSet.Add(leftRecord);
                                    rightResultSet.Add(rightRecord);
                                }
                            }
                        }
                    }
                }
            }
            else { throw new NotImplementedException("Not Implemented for Operator: " + op); }

            resultSet.Add(leftTable, leftResultSet);
            resultSet.Add(rightTable, rightResultSet);
            return resultSet;
        }



        private Dictionary<string, List<object[]>> PerformOperationOnRecords(Dictionary<string, List<object[]>> lhsRecords, Dictionary<string, List<object[]>> rhsRecords, string op)
        {

            List<object[]> lhsRecordsInTable;
            List<object[]> rhsRecordsInTable;

            Dictionary<string, List<object[]>> selectedRecords = new Dictionary<string, List<object[]>>();

            if (op.Equals("NOT"))
            {
                foreach (string tableName in lhsRecords.Keys)
                {
                    lhsRecordsInTable = lhsRecords[tableName];
                    rhsRecordsInTable = rhsRecords[tableName];
                    List<object[]> selectedRecordsInTable = new List<object[]>();

                    foreach (object[] record in lhsRecordsInTable)
                    {
                        if (!rhsRecordsInTable.Contains(record))
                        {
                            selectedRecordsInTable.Add(record);
                        }
                    }
                    selectedRecords.Add(tableName, selectedRecordsInTable);
                }
            }
            else if (op.Equals("AND"))
            {
                foreach (string tableName in lhsRecords.Keys)
                    selectedRecords.Add(tableName, null);
                foreach (string tableName in rhsRecords.Keys)
                    if (!selectedRecords.ContainsKey(tableName))
                        selectedRecords.Add(tableName, null);


                foreach (string tableName in lhsRecords.Keys)
                {
                    lhsRecordsInTable = lhsRecords[tableName];
                    rhsRecordsInTable = rhsRecords[tableName];
                    List<object[]> selectedRecordsInTable = new List<object[]>();

                    if (lhsRecordsInTable == null || rhsRecordsInTable == null)
                        continue;

                    foreach (object[] record in lhsRecordsInTable)
                    {
                        if (rhsRecordsInTable.Contains(record))
                        {
                            selectedRecordsInTable.Add(record);
                            bool flagToBeAdded = true;
                            List<string> tabls = new List<string>();
                            foreach (string t in lhsRecords.Keys)
                                tabls.Add(t);
                            foreach (string t in rhsRecords.Keys)
                            {
                                if (!tabls.Contains(t))
                                    tabls.Add(t);
                            }


                            foreach (string t in tabls)
                            {
                                if (!t.Equals(tableName))
                                {
                                    if (lhsRecords.ContainsKey(t) && lhsRecords[t] != null && (!rhsRecords.ContainsKey(t) || (rhsRecords.ContainsKey(t) && rhsRecords[t] == null)))
                                    {
                                        int i = lhsRecordsInTable.IndexOf(record);
                                        List<object[]> r = lhsRecords[t];
                                        object[] recToBeAdded = r[i];
                                        if (selectedRecords[t] == null)
                                        {
                                            selectedRecords[t] = new List<object[]>();
                                            selectedRecords[t].Add(recToBeAdded);
                                        }
                                        else
                                            selectedRecords[t].Add(recToBeAdded);
                                    }
                                    else if (rhsRecords.ContainsKey(t) && rhsRecords[t] != null && (!lhsRecords.ContainsKey(t) || (lhsRecords.ContainsKey(t) && lhsRecords[t] == null)))
                                    {
                                        int i = rhsRecordsInTable.IndexOf(record);
                                        List<object[]> r = rhsRecords[t];
                                        object[] recToBeAdded = r[i];
                                        if (selectedRecords[t] == null)
                                        {
                                            selectedRecords[t] = new List<object[]>();
                                            selectedRecords[t].Add(recToBeAdded);
                                        }
                                        else
                                            selectedRecords[t].Add(recToBeAdded);
                                    }
                                    else if (rhsRecords[t] != null && lhsRecords[t] != null)
                                    {
                                        int i = lhsRecordsInTable.IndexOf(record);

                                        List<object[]> rl = lhsRecords[t];
                                        object[] recToBeAddedl = rl[i];
                                        List<object[]> rr = lhsRecords[t];
                                        object[] recToBeAddedr = rr[i];
                                        if (recToBeAddedl.Equals(recToBeAddedr))
                                        {
                                            if (selectedRecords[t] == null)
                                            {
                                                selectedRecords[t] = new List<object[]>();
                                                selectedRecords[t].Add(recToBeAddedr);
                                            }
                                            else
                                                selectedRecords[t].Add(recToBeAddedr);
                                        }
                                        else
                                            flagToBeAdded = true;
                                    }
                                }
                            }
                            if (flagToBeAdded)
                            {
                                if (selectedRecords[tableName] == null)
                                {
                                    selectedRecords[tableName] = new List<object[]>();
                                    selectedRecords[tableName].Add(record);
                                }
                                else
                                    selectedRecords[tableName].Add(record);
                            }
                        }
                    }
                    return selectedRecords;
                }
            }
            else if (op.Equals("OR"))
            {
                foreach (string tableName in lhsRecords.Keys)
                {
                    lhsRecordsInTable = lhsRecords[tableName];
                    rhsRecordsInTable = rhsRecords[tableName];
                    List<object[]> selectedRecordsInTable = new List<object[]>();

                    foreach (object[] record in lhsRecordsInTable)
                    {
                        selectedRecordsInTable.Add(record);
                    }
                    foreach (object[] record in rhsRecordsInTable)
                    {
                        if (!selectedRecordsInTable.Contains(record))
                            selectedRecordsInTable.Add(record);
                    }
                    selectedRecords.Add(tableName, selectedRecordsInTable);
                }
            }
            else
                throw new NotImplementedException("Operator + " + op + " Not Implemented");
            return selectedRecords;

        }

        public List<string> selectedColumns = new List<string>();

        private List<object[]> SelectColumnsFrom(List<object[]> records, QueryParts parsedQuery, MockDBMS.Table table)
        {
            //DataSet
            List<object[]> selectedRecords = new List<object[]>();
            List<string> columnsToBeSelected = new List<string>();
            if (parsedQuery.IsSelectAll)
            {
                IEnumerator<string> columnEnumerator = table.ColumnNameType.Keys.GetEnumerator();
                while (columnEnumerator.MoveNext())
                {
                    columnsToBeSelected.Add(columnEnumerator.Current);
                }
            }
            else
                columnsToBeSelected = parsedQuery.selectedColumns;
            foreach (object[] record in records)
            {
                object[] selectedRecord = new object[columnsToBeSelected.Count];
                int index = 0;
                foreach (string column in columnsToBeSelected)
                {
                    selectedRecord[index++] = record[table.ColumnIndices[column]];
                }
                selectedRecords.Add(selectedRecord);
            }
            selectedColumns = columnsToBeSelected;
            return selectedRecords;
        }

        /*
                private void tempQueryParser(string query)
                {
                    QueryParts parsedQuery = new QueryParts();
                    char[] c = new char[1];
                    c[0] = ' ';
                    string[] parts = query.Split(c);
                    ParsingState state = ParsingState.TYPE;
                    foreach (string part in parts)
                    {
                        if (part.Equals("SELECT"))
                        {
                            state = ParsingState.COLUMNS;
                            parsedQuery.Type = QueryStatementType.SELECT;
                        }
                        else if (part.Equals("WHERE"))
                        {
                            state = ParsingState.WHERECOND;
                        }
                        else if (part.Equals("FROM"))
                        {
                            state = ParsingState.TABLE;
                        }
                        else
                        {
                            if (state == ParsingState.COLUMNS)
                            {
                                parsedQuery.columns.Add(part);
                                state = ParsingState.FROM;
                            }
                            else if (state == ParsingState.TABLE)
                            {
                                parsedQuery.TableName = part;
                                state = ParsingState.WHERE;
                            }
                            else if (state == ParsingState.WHERECOND)
                            {
                                parsedQuery.whereConditionLHS = part;
                                state = ParsingState.WHEREOP;
                            }
                            else if (state == ParsingState.WHEREOP)
                            {
                                parsedQuery.whereConditionop = part;
                                state = ParsingState.WHERERHS;
                            }
                            else if (state == ParsingState.WHERERHS)
                            {
                                parsedQuery.whereConditionRHS = part;
                                state = ParsingState.DONE;
                            }
                    
                        }

                    }
                }
                */
        private static QueryParts parseQuery(string query)
        {
            IStatement st = Factory.CreateStatement(query);
            IVisitor tailor = Factory.CreateTailor(Factory.MSQLProvider);
            st.Traverse(tailor);
            QueryParts parsed = ((MSqlServerTailor)tailor).queryParts;
            return parsed;
            //tailor.
        }


        public object ExecuteScalar()
        {
            List<object[]> resultSet = ExecuteReader().records;
            
            if (parsedQuery.Type == QueryStatementType.INSERT)
                numAffectedRecords = 1;
            else if(parsedQuery.Type != QueryStatementType.DELETE)
                numAffectedRecords = resultSet.Count;
            if (parsedQuery.IsFucntionCall == false)
            {
                if (resultSet.Count == 0)
                    return null;
                return resultSet[0][0];
            }
            if (parsedQuery.FunctionType == Function.COUNT)
            {
                int count = 0;
                foreach (object[] record in resultSet)
                {
                    bool flag = false;
                    foreach (object field in record)
                    {
                        if (record == null)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                        count++;
                }
                return count;
            }
            else if (parsedQuery.FunctionType == Function.SUM)
            {
                int sum = 0;
                foreach (object[] record in resultSet)
                {
                    PexAssert.IsTrue(record.Length == 1);
                    sum = sum + (Int32)record[0];
                   
                }
                return sum;
            }
            else if (parsedQuery.FunctionType == Function.MIN)
            {
                throw new NotImplementedException();
            }
            else if (parsedQuery.FunctionType == Function.MAX)
            {
                throw new NotImplementedException();
            }
            else if (parsedQuery.FunctionType == Function.AVG)
            {
                throw new NotImplementedException();
            }
            else if (parsedQuery.FunctionType == Function.FIRST)
            {
                return resultSet[0][0];
            }
            else if (parsedQuery.FunctionType == Function.LAST)
            {
                return resultSet[resultSet.Count - 1][0];
            }
            else
                throw new NotImplementedException("Unknown Function " + parsedQuery.FunctionType);
            return null;
        }

        public int ExecuteNonQuery()
        {
            //throw new NotImplementedException();
            ExecuteScalar();
            PexObserve.Value<MockDBMS.DBMS>("dbms", connection.Dbms);
            return numAffectedRecords;
        }

        #region IDisposable Members

        public void Dispose()
        {
            
            //throw new NotImplementedException();
        }

        #endregion

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}