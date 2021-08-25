using System;

namespace MacroScope
{
    /// <summary>
    /// SQL DELETE statement.
    /// </summary>
    public sealed class DeleteStatement : IStatement
    {
        #region Fields

        private DbObject m_table;

        private IExpression m_where;

        #endregion

        #region Properties

        public DbObject Table
        {
            get { return m_table; }
            set { m_table = value; }
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
            DeleteStatement deleteStatement = new DeleteStatement();

            if (m_table != null)
            {
                deleteStatement.Table = (DbObject)(m_table.Clone());
            }

            if (m_where != null)
            {
                deleteStatement.Where = (IExpression)(m_where.Clone());
            }

            return deleteStatement;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            if (m_table == null)
            {
                throw new InvalidOperationException("DELETE must have target table.");
            }

            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                trailor.queryParts.Type = QueryStatementType.DELETE;
                trailor.queryParts.ParsingState = ParsingState.TABLE;
            }

            visitor.PerformBefore(this);
            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                if (trailor.queryParts.ParsingState == ParsingState.TABLE)
                {
                    trailor.queryParts.ParsingState = ParsingState.WHERE;
                    trailor.queryParts.TableNames.Add(m_table.Identifier.ID);
                }
            }
            m_table.Traverse(visitor);

            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                if (trailor.queryParts.ParsingState == ParsingState.WHERE)
                    trailor.queryParts.ParsingState = ParsingState.WHERECOND;
            }
            visitor.PerformOnWhere(this);
            if (m_where != null)
            {
                m_where.Traverse(visitor);
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
