using System;
using System.Collections.Generic;

namespace MacroScope
{
    /// <summary>
    /// SQL SELECT statement.
    /// </summary>
    public sealed class InsertStatement : IStatement
    {
        #region Fields

        private DbObject m_table;

        private AliasedItem m_columnNames;

        private ExpressionItem m_columnValues;

        List<string> cNames = new List<string>();

        #endregion

        #region Properties

        public DbObject Table
        {
            get { return m_table; }
            set { m_table = value; }
        }

        public AliasedItem ColumnNames
        {
            get { return m_columnNames; }
            set { m_columnNames = value; }
        }

        public ExpressionItem ColumnValues
        {
            get { return m_columnValues; }
            set { m_columnValues = value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            InsertStatement insertStatement = new InsertStatement();

            if (m_table != null)
            {
                insertStatement.Table = (DbObject)(m_table.Clone());
            }

            if (m_columnNames != null)
            {
                insertStatement.ColumnNames = (AliasedItem)(m_columnNames.Clone());
            }

            if (m_columnValues != null)
            {
                insertStatement.ColumnValues = (ExpressionItem)(m_columnValues.Clone());
            }

            return insertStatement;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            if (m_table == null)
            {
                throw new InvalidOperationException("INSERT must have target table.");
            }
            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                trailor.queryParts.Type = QueryStatementType.INSERT;
                trailor.queryParts.ParsingState = ParsingState.TABLE;
            }

            visitor.PerformBefore(this);
            m_table.Traverse(visitor);

            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                string name = m_table.Identifier.ID;
                name = name.Trim('[', ']');
                Console.WriteLine("Adding Table " + name);
                trailor.queryParts.TableNames.Add(name);
                trailor.queryParts.ParsingState = ParsingState.COLUMNS;
            }

            visitor.PerformOnNames(this);
            if (m_columnNames != null)
            {
 
                m_columnNames.Traverse(visitor);
                if (visitor is MSqlServerTailor)
                {  /*Added by Kunal*/
                    MSqlServerTailor trailor = visitor as MSqlServerTailor;
                    string columnName = ((DbObject)m_columnNames.Item).Identifier.ID;
                    cNames.Add(columnName);
                    AliasedItem nextColumn = m_columnNames.Next;
                    while(nextColumn != null)
                    {
                        columnName = ((DbObject)nextColumn.Item).Identifier.ID;
                        cNames.Add(columnName);
                        nextColumn = nextColumn.Next;
                    } 
                    trailor.queryParts.ParsingState = ParsingState.COLUMNVALUES;
                }
                
            }

            if (m_columnValues == null)
            {
                throw new InvalidOperationException("INSERT must have column values.");
            }

            visitor.PerformOnValues(this);
            m_columnValues.Traverse(visitor);
            if (visitor is MSqlServerTailor)
            {
                /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                object right = ((Expression)m_columnValues.Expression).Right;
                object value;
                int index = 0;
                if (right is IntegerValue)
                {
                    value = ((IntegerValue)right).Value;
                }
                else if (right is DbObject)
                {
                    value = ((DbObject)right).Identifier.ID;
                }
                else if (right is StringValue)
                {
                    value = ((StringValue)right).Value;
                }
                else
                {
                    throw new Exception("Unexpected Type: " + right.GetType().ToString());
                }
                string name = cNames[index++];
                name = name.Trim('[', ']');
                trailor.queryParts.ColumnNameValueMap.Add(name, value);
                
                ExpressionItem nextValue = m_columnValues.Next;
                while (nextValue != null)
                {
                    right = ((Expression)nextValue.Expression).Right;
                    if (right is IntegerValue)
                    {
                        value = ((IntegerValue)right).Value;
                    }
                    else if (right is DbObject)
                    {
                        value = ((DbObject)right).Identifier.ID;
                    }
                    name = cNames[index++];
                    name = name.Trim('[', ']');
                    trailor.queryParts.ColumnNameValueMap.Add(name, value);
                    nextValue = nextValue.Next;
                }
                trailor.queryParts.ParsingState = ParsingState.DONE;
            }


            visitor.PerformAfter(this);
        }

        #endregion
    }
}
