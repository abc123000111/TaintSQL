using System;

namespace MacroScope
{
    /// <summary>
    /// SQL UPDATE statement.
    /// </summary>
    public sealed class UpdateStatement : IStatement
    {
        #region Fields

        private DbObject m_table;

        private Assignment m_assignments;

        private IExpression m_where;

        #endregion

        #region Properties

        public DbObject Table
        {
            get { return m_table; }
            set { m_table = value; }
        }

        public Assignment Assignments
        {
            get { return m_assignments; }
            set { m_assignments = value; }
        }

        public IExpression Where
        {
            get { return m_where; }
            set { m_where = value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            UpdateStatement updateStatement = new UpdateStatement();

            if (m_table != null)
            {
                updateStatement.Table = (DbObject)(m_table.Clone());
            }

            if (m_assignments != null)
            {
                updateStatement.Assignments = (Assignment)(m_assignments.Clone());
            }

            if (m_where != null)
            {
                updateStatement.Where = (IExpression)(m_where.Clone());
            }

            return updateStatement;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            if (m_table == null)
            {
                throw new InvalidOperationException("UPDATE must have target table.");
            }

            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                trailor.queryParts.Type = QueryStatementType.UPDATE;
                trailor.queryParts.ParsingState = ParsingState.TABLE;
            }

            visitor.PerformBefore(this);
            m_table.Traverse(visitor);
            
            if (visitor is MSqlServerTailor)
            {  
                /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                trailor.queryParts.TableNames.Add(m_table.Identifier.ID);
                trailor.queryParts.ParsingState = ParsingState.ASSIGN;
            }


            if (m_assignments == null)
            {
                throw new InvalidOperationException("UPDATE must have at least one assignment.");
            }
            
            if (visitor is MSqlServerTailor)
            {
                /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                //trailor.queryParts.TableNames.Add(m_table.Identifier.ID);
                string name = m_assignments.Name.Identifier.ID;
                object right = ((Expression)m_assignments.Value).Right;
                object value = null;
                if (right is StringValue)
                {
                    value = ((StringValue)right).Value;
                }
                else if (right is DbObject)
                {
                    value = ((DbObject)right).Identifier.ID;
                }
                else if (right is IntegerValue)
                {
                    value = ((IntegerValue)right).Value;
                }
                else
                {
                    throw new Exception("Not Expecting Type " + right.GetType().ToString());
                }
                
                name = name.Trim('[', ']');
                trailor.queryParts.ColumnNameValueMap.Add(name, value);

                Assignment nextAssignment = m_assignments.Next;
                while (nextAssignment != null)
                {
                    name = nextAssignment.Name.Identifier.ID;
                    right = ((Expression)nextAssignment.Value).Right;
                    if (right is StringValue)
                    {
                        value = ((StringValue)right).Value;
                    }
                    else if (right is DbObject)
                    {
                        value = ((DbObject)right).Identifier.ID;
                    }
                    else if (right is IntegerValue)
                    {
                        value = ((IntegerValue)right).Value;
                    }
                    else
                    {
                        throw new Exception("Not Expecting Type " + right.GetType().ToString());
                    }
                    nextAssignment = nextAssignment.Next;
                    name = name.Trim('[',']');
                    trailor.queryParts.ColumnNameValueMap.Add(name, value);
                }


                trailor.queryParts.ParsingState = ParsingState.WHERE;
            }


            visitor.PerformOnAssignments(this);
            m_assignments.Traverse(visitor);

            visitor.PerformOnWhere(this);
            if (m_where != null)
            {
                m_where.Traverse(visitor);
            }
            if (visitor is MSqlServerTailor)
            {
                /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                trailor.queryParts.whereCondition = (Expression) m_where;
                trailor.queryParts.ParsingState = ParsingState.DONE;
            }


            visitor.PerformAfter(this);
        }

        #endregion
    }
}
