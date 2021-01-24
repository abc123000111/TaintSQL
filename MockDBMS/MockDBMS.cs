using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using MacroScope;
using Microsoft.Pex.Framework;
using System.Text.RegularExpressions;
using Microsoft.Pex.Framework.Suppression;

namespace MockDBMS
{
    public enum DataTypes { STRING, INT, CHAR };
    public class DBMS
    {
        #region IMPORTANT: Accessing tables in DBMS (MG)
        public List<Table> tables;

        // MG: This function is not referenced
        public void AddTable(Table table)
        {
            tables.Add(table);
        }
        
        // MG: MOST IMPORTANT function, returns the reference to the table stored in the DBMS
        public Table GetTableByName(string name)
        {
            foreach (Table t in tables)
            {
                if (t.name.Equals(name))
                    return t;
            }
            return null;
        }
        #endregion

        #region Initialize DBMS schema (MG)
        [PexIgnore("ignore")]
        private void readSchemaFromFile()
        {
            tables = new List<Table>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\schema.txt");
            Table table = null;
            foreach (string line in lines)
            {
                if (line.Contains("CREATE TABLE"))
                {
                    int i = line.IndexOf("CREATE TABLE");
                    int j = line.IndexOf("(");
                    string tableName = line.Substring(i + 12, j - i - 12).Trim();
                    table = new Table(tableName);
                    tables.Add(table);
                    continue;
                }
                DataTypes type = DataTypes.INT;
                int index = -1;
                if (line.Contains("varchar"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("varchar");
                }
                if (line.Contains("VARCHAR"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("VARCHAR");
                }
                if (line.Contains("int"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("int");
                }
                if (line.Contains("INT"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("INT");
                }
                if (line.Contains("enum"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("enum");
                }
                if (line.Contains("ENUM"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("ENUM");
                }
                if (line.Contains("bigint"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("bigint");
                }
                if (line.Contains("BIGINT"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("BIGINT");
                }
                if (line.Contains("TINYINT"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("TINYINT");
                }
                if (line.Contains("tinyint"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("tinyint");
                }
                if (index == -1)
                    continue;
                string cname = line.Substring(0, index).Trim();
                table.AddColumn(cname, type);
                table.AddColumn(cname + "_TAINT", DataTypes.STRING);
            }
        }


        /// <summary>
        /// MG: Currently schema is hard-coded
        /// </summary>
        private void initializeDBMSFromSchema()
        {
            readSchemaFromFile();
            /* tables = new List<Table>(); 
            Table t = new Table("persons");
            t.AddColumn("firstname", DataTypes.STRING);
            t.AddColumn("lastname", DataTypes.STRING);
            t.AddColumn("age", DataTypes.INT);
            tables.Add(t);

            Table t2 = new Table("Users");
            t2.AddColumn("MID", DataTypes.INT);
            t2.AddColumn("Role", DataTypes.STRING);
            t2.AddPrimaryKey("MID");
            tables.Add(t2); */
            //tables = new List<Table>(); Table t = new Table("persons");
            //    t.AddColumn("firstname", DataTypes.STRING);
            //    t.AddColumn("lastname", DataTypes.STRING);
            //    t.AddColumn("age", DataTypes.INT);
            //    tables.Add(t);
        }

        /// <summary>
        /// MG: This method initializes the database schema and call Pex to generate records
        /// </summary>
        [PexMethod()]
        public void CreateDatabaseState()
        {
            //MockDBMS dbms = new MockDBMS();
            initializeDBMSFromSchema();
             //Test Code

            //FillTestRecords();
            //GenerateRandomReccords(1);
            LetPexChooseRecords();
        }

        /// <summary>
        /// MG: Use Pex to populate the tables in DBMS
        /// </summary>
        private void LetPexChooseRecords()
        {
            foreach (Table table in tables)
            {
                //var chooser = PexChoose.FromCall(this);
                int numRecords = PexChoose.Value<int>("Num Records");
                //PexAssume.IsTrue(numRecords >= 0 && numRecords <= 2);
                for (int i = 0; i < numRecords; i++)
                {
                    Dictionary<string, DataTypes> nameType = table.ColumnNameType;
                    Dictionary<string, DataTypes>.KeyCollection keys = nameType.Keys;
                    object[] record = new object[keys.Count];
                    IEnumerator<string> columnEnum = keys.GetEnumerator();

                    int j = 0;
                    while (columnEnum.MoveNext())
                    {
                        String column = columnEnum.Current;
                        DataTypes type = nameType[column];

                        if (type == DataTypes.INT)
                        {
                            int value = PexChoose.Value<int>("Table: " + table.name + " Column " + column + " Record " + i);
                            PexAssume.IsNotNull(value);
                            record[j++] = value;
                            columnEnum.MoveNext();
                            string tag = PexChoose.Value<string>("tag");
                            PexAssume.IsNotNull(value);
                            record[j++] = tag;
                            //record[j++] = "00000000";
                        }
                        else if (type == DataTypes.STRING)
                        {
                            string value = PexChoose.Value<string>("column " + column + " Record " + i);
                            PexAssume.IsNotNull(value);
                            PexAssume.IsTrue(value != "");
                            record[j++] = value;
                            columnEnum.MoveNext();
                            string tag = PexChoose.Value<string>("tag");
                            PexAssume.IsNotNull(value);
                            record[j++] = tag;
                            //record[j++] = "00000000";
                        }
                    }
                    table.InsertRecord(record);
                }
            }
        }
        #endregion

        #region Not referenced functions (MG)
        // MG: This function is not referenced
        private void GenerateRandomReccords(int numRecords)
        {
            //DateTime start = DateTime.Now;
            foreach (Table table in tables)
            {
                for (int i = 0; i < numRecords; i++)
                {
                    /*DateTime now = DateTime.Now;
                    TimeSpan duration = start - now;
                    if (duration.Minutes >= 2)
                        break;*/
                    Dictionary<string, DataTypes> nameType = table.ColumnNameType;
                    Dictionary<string, DataTypes>.KeyCollection keys = nameType.Keys;
                    object[] record = new object[keys.Count];
                    IEnumerator<string> columnEnum = keys.GetEnumerator();

                    int j = 0;
                    while (columnEnum.MoveNext())
                    {
                        String column = columnEnum.Current;
                        DataTypes type = nameType[column];

                        if (type == DataTypes.INT)
                        {
                            Random r = new Random((int)DateTime.Now.Ticks);
                            int value = r.Next(1, 10);
                            record[j++] = value;
                            columnEnum.MoveNext();
                            record[j++] = "00000000";
                        }
                        else if (type == DataTypes.STRING)
                        {
                            string value = RandomString(5, true);
                            record[j++] = value;
                            columnEnum.MoveNext();
                            record[j++] = "00000000";
                        }
                    }
                    table.InsertRecord(record);
                }
            }
        }

        // MG: This function is only used in GenerateRandomReccords(), which is currently not referenced
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random((int)DateTime.Now.Ticks);
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // MG: This function is not referenced
        private void FillTestRecords()
        {
            /*
            tables = new List<Table>();
            Table t = new Table("persons");
            t.AddColumn("firstname", DataTypes.STRING);
            t.AddColumn("lastname", DataTypes.STRING);
            t.AddColumn("x", DataTypes.INT);
            tables.Add(t);
            Table t2 = new Table("salary");
            t2.AddColumn("firstname", DataTypes.STRING);
            t2.AddColumn("lastname", DataTypes.STRING);
            t2.AddColumn("salary", DataTypes.INT);
            t2.AddColumn("x", DataTypes.INT);
            tables.Add(t2);*/

            tables = new List<Table>();
            Table t = new Table("SignsSyms");
            t.AddColumn("SignSymID", DataTypes.INT);
            t.AddColumn("SignSymText", DataTypes.STRING);
             
            object[] record = new object[2];
            record[0] = (object)1;
            record[1] = "a";
            t.InsertRecord(record);
            
            record = new object[2];
            record[0] = (object)2;
            record[1] = "b";
            t.InsertRecord(record);

            record = new object[2];
            record[0] = (object)3;
            record[1] = "c";
            t.InsertRecord(record);
            tables.Add(t);

            t = new Table("ChiefComplaintToSignsSyms");
            t.AddColumn("CCID", DataTypes.INT);
            t.AddColumn("SignSymID", DataTypes.INT);

            record = new object[2];
            record[0] = (object)0;
            record[1] = (object)1;
            t.InsertRecord(record);

            record = new object[2];
            record[0] = (object)1;
            record[1] = (object)2;
            t.InsertRecord(record);

            record = new object[2];
            record[0] = (object)2;
            record[1] = (object)3;
            t.InsertRecord(record);

            record = new object[2];
            record[0] = (object)3;
            record[1] = (object)4;
            t.InsertRecord(record);

            tables.Add(t);
        }
        #endregion

        // MG: 污点标记，16进制字符串
        public static Dictionary<string, string> taintTags = new Dictionary<string, string>();

        private static char[] constant = {'1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static string GenerateRandomNumber(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(9);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(9)]);
            }
            return newRandom.ToString();
        }

        public static string processData(object x, string tag, string query, bool flag)
        {
            string pwd = GenerateRandomNumber(8);
            while(query.Contains(pwd) || taintTags.ContainsKey(pwd))
            {
                pwd = GenerateRandomNumber(8);
            }
            taintTags.Add(pwd, tag);
            if (flag == false)
            {
                if ((x is System.String) == false)
                {
                    //Console.WriteLine(x + pwd);
                    return x + pwd;
                }
                else
                {
                    return "\"" + x + pwd + "\"";
                }
            }
            else
            {
                if ((x is System.String) == false)
                {
                    //Console.WriteLine(x + pwd);
                    return x + pwd;
                }
                else
                {
                    return "'" + x + pwd + "'";
                }
            }
        }

        /*public static string processStringData(string x, string name, int flag)
        {
            if (flag == 0) //insert
            {
                if (taintTags.ContainsKey(name) == false)
                {
                    return "\"" + x + "00000000\"";
                }
                else
                {
                    return "\"" + x + taintTags[name] + "\"";
                }
            }
            else //others
            {
                if (taintTags.ContainsKey(name) == false)
                {
                    return "'" + x + "00000000'";
                }
                else
                {
                    return "'" + x + taintTags[name] + "'";
                }
            }
        }

        public static string processDecimalData(Decimal x, string name)
        {
            if (taintTags.ContainsKey(name) == false)
            {
                return x + "00000000";
            }
            else
            {
                return x + taintTags[name];
            }
        }*/

    }   // End class DBMS

    public class Table
    {
        #region Member variables (MG)
        public string name;

        // MG: Map conlumn name to datatype: STRING, INT, or CHAR
        Dictionary<string, DataTypes> columnNameType; // name -> type

        // MG: Map column name to the index of the column
        Dictionary<string, int> columnIndices;

        // MG: List of records (list of object type) 
        List<object[]> records; // List of records in the table

        // MG: Primary Keys
        List<String> pKeys = new List<string>();

        // MG: Foreign Keys
        public string[] foreignKeys;

        public int numColumns = 0;
        #endregion

        #region Accessor for columnNameType, columnNameIndicies, and records (MG)
        public Dictionary<string, int> ColumnIndices
        {
            get { return columnIndices; }
            set { columnIndices = value; }
        }

        public Dictionary<string, DataTypes> ColumnNameType
        {
            get { return columnNameType; }
            set { columnNameType = value; }
        }

        public List<object[]> Records
        {
            get { return records; }
            set { records = value; }
        }
        #endregion

        #region Constructor for class Table
        public Table(string tableName)
        {
            name = tableName;
            columnNameType = new Dictionary<string, DataTypes>();
            columnIndices = new Dictionary<string, int>();
            records = new List<object[]>();
        }
        #endregion

        public void AddPrimaryKey(string column)
        {
            pKeys.Add(column);
        }

        //public Column SelectColumn(string name) { } //Column contains objects of each column
        public void AddColumn(string name, DataTypes type)
        {
            columnNameType.Add(name, type);
            columnIndices.Add(name, numColumns++);
        }

        public void InsertRecord(object[] record)
        {
            records.Add(record);
        }
        public void DeleteRecords(List<object[]> recds)
        {
            foreach (object[] r in recds)
            {
                if (!this.records.Contains(r))
                    throw new Exception("Record + " + r.ToString() + " not in the table");
                records.Remove(r);
            }
        }

        public void UpdateRecord(int recordID, object[] record)
        {
        }

        // MG: Need to investigate what is this
        public List<object[]> getRecordsWith(Expression condition, List<object[]> recds)
        {
            string left = null;
            string right = null;
            string op;
            List<object[]> resultSet = new List<object[]>();
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
                List<object[]> rec = getRecordsWith(rhs, recds);
                resultSet = PerformOperationOnRecords(records, rec, op);
                return resultSet;
                
            }
            PexAssert.IsNotNull(lhs);
            PexAssert.IsNotNull(rhs);

            List<object[]> lhsRecords;
            List<object[]> rhsRecords;
            
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

                left = ((DbObject)lhs.Right).Identifier.ID;
                if (rhs.Right is IntegerValue)
                {
                    right = ((IntegerValue)rhs.Right).Value.ToString();
                }
                else if (rhs.Right is DbObject)
                {
                    right = ((DbObject)rhs.Right).Identifier.ID;
                }
                else if (rhs.Right is StringValue)
                {
                    right = ((StringValue)rhs.Right).Value;
                }
               //has to be an integerValue
                resultSet = SelectRecords(left, right, op, recds);
            }
            else if (op.Equals("AND") || op.Equals("OR"))
            {
                PexAssert.IsNotNull(lhs.Operator);
                lhsRecords = getRecordsWith(lhs, recds);
                PexAssert.IsNotNull(rhs.Operator);
                rhsRecords = getRecordsWith(rhs, recds);
                resultSet = PerformOperationOnRecords(lhsRecords, rhsRecords, op);
            }
            else if (op.Equals("LIKE"))
            {
                PexAssert.IsNull(lhs.Operator);
                PexAssert.IsNull(rhs.Operator);
                right = ((StringValue)rhs.Right).Value.ToString();
                left = ((DbObject)lhs.Right).Identifier.ID;
                resultSet = SelectRecords(left, right, op, recds);
            }

            return resultSet;
        }

        // MG: Need to investigate what is this
        public List<object[]> PerformOperationOnRecords(List<object[]> lhsRecords, List<object[]> rhsRecords, string op)
        {
            List<object[]> selectedRecords = new List<object[]>();
            if (op.Equals("NOT"))
            {
                foreach (object[] record in lhsRecords)
                {
                    if (!rhsRecords.Contains(record))
                        selectedRecords.Add(record);
                }
            }
            else if (op.Equals("AND"))
            {
                foreach (object[] record in lhsRecords)
                {
                    if (rhsRecords.Contains(record))
                        selectedRecords.Add(record);
                }
            }
            else if (op.Equals("OR"))
            {
                foreach (object[] record in lhsRecords)
                {
                    selectedRecords.Add(record);
                }
                foreach (object[] record in rhsRecords)
                {
                    if (!selectedRecords.Contains(record))
                        selectedRecords.Add(record);
                }
            }
            else
                throw new NotImplementedException("Operator + " + op + " Not Implemented");
            return selectedRecords;
        }

        /*To be implemented for 
         * Operators: LIKE, IS NULL, IS NOT NULL
         */
        public List<object[]> SelectRecords(string left, string right, string op, List<object[]> recds)
        {
            left = left.Trim('[', ']');
            if (left.Contains("["))
            {
                left = left.Substring(1, left.Length - 2);
            }

            List<object[]> resultSet = new List<object[]>();
            if (op.Equals("=") || op.Equals("!="))
            {
                foreach (object[] record in records)
                {
                    object obj = record[columnIndices[left]];
                    DataTypes type = ColumnNameType[left];
                    if (type == DataTypes.STRING)
                    {
                        right = right.Trim('\"', '[', ']', '\'');
                        string tag = "00000000";
                        string value = right;
                        if (right.Length > 8)
                        {
                            string pwd = right.Substring(right.Length - 8);
                            
                            if (DBMS.taintTags.ContainsKey(pwd))
                            {
                                tag = DBMS.taintTags[pwd];
                                value = right.Substring(0, right.Length - 8);
                            }
                        }
                        if (op.Equals("="))
                        {
                            if (obj.Equals(value))
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                }
                                resultSet.Add(record);
                            }
                                
                        }
                        else
                        {
                            if (!obj.Equals(value))
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                }
                                resultSet.Add(record);
                            }
                                
                        }
                    }
                    else if (type == DataTypes.INT)
                    {
                        right = right.Trim('\"', '[', ']', '\'');
                        int i= right.IndexOf("[");
                        int j= right.IndexOf("]");
                        int l = j-i-1;

                        if(i!=-1 && j!=-1)
                            right = right.Substring(i+1, l);

                        string tag = "00000000";
                        string value = right;
                        if (right.Length > 8)
                        {
                            string pwd = right.Substring(right.Length - 8);
                            Console.WriteLine("pwd: " + pwd);
                            if (DBMS.taintTags.ContainsKey(pwd))
                            {
                                tag = DBMS.taintTags[pwd];
                                value = right.Substring(0, right.Length - 8);
                                Console.WriteLine("tag: " + tag);
                            }
                        }

                        Int64 number = ToInt64(value, 10);
                        if (op.Equals("="))
                        {
                            string typeooo = obj.GetType().ToString();
                            
                            if (obj is System.Decimal)
                            {
                                Int64 num = Decimal.ToInt64((Decimal)obj);
                               /* Decimal n = (Decimal)obj;
                                if(n.ToString() == number)
                                    resultSet.Add(record);
                                * */
                                if (num == number)
                                {
                                    for (int k = 1; k < numColumns; k += 2)
                                    {
                                        record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                        Console.WriteLine("content:"+record[k-1]);
                                        Console.WriteLine("tag:"+record[k]);
                                    }
                                    resultSet.Add(record);
                                }
                                    
                            }
                            else if ((int)obj == number)
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                    Console.WriteLine(record[k]);
                                }
                                resultSet.Add(record);
                            }
                        }
                        else
                        {
                            if ((int)obj != number)
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                    Console.WriteLine(record[k]);
                                }
                                resultSet.Add(record);
                            }
                        }
                    }
                }
            }
            else if (op.Equals("<") || op.Equals("<=") || op.Equals(">") || op.Equals(">=")) 
            {
                foreach (object[] record in records)
                {
                    Console.WriteLine(left);
                    object obj = record[columnIndices[left]];
                    DataTypes type = ColumnNameType[left];
                    if (type == DataTypes.INT)
                    {
                        //right = right.Trim('\"', '[', ']');
                        //Int64 number = System.Convert.ToInt64(right, 10);
                        string tag = "00000000";
                        string value = right;
                        if (right.Length > 8)
                        {
                            string pwd = right.Substring(right.Length - 8);
                            if (DBMS.taintTags.ContainsKey(pwd))
                            {
                                tag = DBMS.taintTags[pwd];
                                value = right.Substring(0, right.Length - 8);
                            }
                        }
                        Int64 number = ToInt64(value, 10);
                        if (op.Equals("<"))
                        {
                            if ((int)obj < number)
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                }
                                resultSet.Add(record);
                            }
                        }
                        else if (op.Equals("<="))
                        {
                            if ((int)obj <= number)
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                }
                                resultSet.Add(record);
                            }
                        }
                        else if (op.Equals(">"))
                        {
                            if ((int)obj > number)
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                }
                                resultSet.Add(record);
                            }
                        }
                        else if (op.Equals(">="))
                        {
                            if ((int)obj >= number)
                            {
                                for (int k = 1; k < numColumns; k += 2)
                                {
                                    record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                                }
                                resultSet.Add(record);
                            }
                        }
                        else
                        {
                            throw new Exception("Unexpected Symbol " + op);
                        }

                    }
                    else
                        throw new Exception("Expected a Integer but got " + type);
                }
            }
            else if (op.Equals("LIKE"))
            {
                foreach (object[] record in records)
                {
                    object obj = record[columnIndices[left]];
                    right = right.Trim('\"', '[', ']', '\'');
                    string tag = "00000000";
                    string value = right;
                    if (right.Length > 8)
                    {
                        string pwd = right.Substring(right.Length - 8);
                        if (DBMS.taintTags.ContainsKey(pwd))
                        {
                            tag = DBMS.taintTags[pwd];
                            value = right.Substring(0, right.Length - 8);
                        }
                    }
                    Match m = Regex.Match((string)obj, value);
                    if (m.Success)
                    {
                        for (int k = 1; k < numColumns; k += 2)
                        {
                            record[k] = record[k] + "$" + tag + "$" + record[columnIndices[left + "_TAINT"]];
                        }
                        resultSet.Add(record);
                    }
                }
            }

            else { throw new NotImplementedException("Not Implemented for Operator: " + op); }
            return resultSet;
        }

        //Syste,.Convert.ToInt64 is extern so pex cannot instrument
        private static Int64 ToInt64(string right, int p)
        {
            Int64 number = 0;
            for (int i = 0; i < right.Length; i++)
            {
                string digit = right.Substring(right.Length - i-1, 1);
                
                if (digit.Equals("1"))
                {
                    int n=1;
                    for (int j = 0; j < i; j++) 
                        n = n * 10;
                    number = number + n * 1;
                }
                else if (digit.Equals("2"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 2;
                }
                else if (digit.Equals("3"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 3;
                }
                else if (digit.Equals("4"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 4;
                }
                else if (digit.Equals("5"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 5;
                }
                else if (digit.Equals("6"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 6;
                }
                else if (digit.Equals("7"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 7;
                }
                else if (digit.Equals("8"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 8;
                }
                else if (digit.Equals("9"))
                {
                    int n = 1;
                    for (int j = 0; j < i; j++)
                        n = n * 10;
                    number = number + n * 9;
                }
            }
            return number;
        }
        

        // MG: Not referenced
        public List<object[]> getRecordsWith(Expression condition)
        {
            string left = null;
            string right = null;
            string op;
            List<object[]> resultSet = new List<object[]>();

            if (condition.Operator == null)
            {
                throw new Exception("operator cannot be null");
            }
            op = condition.Operator.Value;
            Expression lhs = (Expression)condition.Left;
            Expression rhs = (Expression)condition.Right;
            if (lhs.Operator == null)
            {
                left = ((DbObject)lhs.Right).Identifier.ID;
            }
            if (rhs.Operator == null)
            {
                right = ((DbObject)rhs.Right).Identifier.ID;
            }

            if (op == "=")
            {
                foreach (object[] record in records)
                {
                    object obj = record[columnIndices[left]];
                    DataTypes type = ColumnNameType[left];
                    if (type == DataTypes.STRING)
                    {
                        char[] trinchars = new char[4];
                        trinchars[0] = '\"';
                        trinchars[1] = '[';
                        trinchars[2] = ']';
                        trinchars[3] = '\'';
                        right = right.Trim(trinchars[0], trinchars[1], trinchars[2], trinchars[3]);
                        if (obj.Equals(right))
                            resultSet.Add(record);
                    }
                }
            }
            return resultSet;
        }
    }   // End class Table
}   // End Namespace MockDBMS
        
            


