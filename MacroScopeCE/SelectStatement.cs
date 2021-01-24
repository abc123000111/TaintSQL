using System;
using System.Collections.Generic;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// SQL SELECT statement.
    /// </summary>
    public sealed class SelectStatement : IStatement
    {
        #region Fields

        private readonly QueryExpression m_queryExpression;

        #endregion

        #region Constructor

        public SelectStatement(QueryExpression queryExpression)
        {
            if (queryExpression == null)
            {
                throw new ArgumentNullException("queryExpression");
            }

            m_queryExpression = queryExpression;
        }

        #endregion

        #region Accessors

        /// <summary>
        /// The single SELECT clause of this statement.
        /// </summary>
        /// <remarks>
        /// Throws when called on a statement with multiple SELECT clauses.
        /// </remarks>
        public QueryExpression SingleQueryExpression
        {
            get
            {
                if (m_queryExpression.HasNext)
                {
                    throw new InvalidOperationException("Query has more than 1 SELECT caluse.");
                }

                return m_queryExpression;
            }
        }

        public OrderExpression OrderBy
        {
            get
            {
                return m_queryExpression.GetOrderBy();
            }

            set
            {
                m_queryExpression.SetOrderBy(value);
            }
        }

        public IList<QueryExpression> GetQueryExpressions()
        {
            return m_queryExpression.GetUnion();
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new SelectStatement((QueryExpression)(m_queryExpression.Clone()));
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/
                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                trailor.queryParts.Type = QueryStatementType.SELECT;
                trailor.queryParts.ParsingState = ParsingState.COLUMNS;
                if(m_queryExpression.Distinct)
                    trailor.queryParts.Distinct = true;
                else
                    trailor.queryParts.Distinct = false;
            }

            visitor.PerformBefore(this);
            m_queryExpression.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion
    }
}
