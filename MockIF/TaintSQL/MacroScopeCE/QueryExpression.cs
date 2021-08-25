using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents a query expression
    /// (i.e. <c>SELECT count(*) FROM t WHERE id IS NOT NULL</c>)
    /// of a SQL SELECT statement.
    /// </summary>
    /// <remarks>
    /// A query expression is a <see cref="SelectStatement">SELECT statement</see>
    /// but not necessarily vice versa - one select statement can consist
    /// of multiple query expressions.
    /// </remarks>
    public sealed class QueryExpression : INode
    {
        #region Fields

        private bool m_distinct = false;

        private bool m_all = false;

        private int? m_top;

        private AliasedItem m_selectItems;

        private AliasedItem m_from;

        private IExpression m_where;

        private GroupByClause m_groupBy;

        private OrderExpression m_orderBy;

        private QueryExpression m_next;

        #endregion

        #region Accessors

        public int? Top
        {
            get
            {
                return m_top;
            }

            set
            {
                m_top = value;
            }
        }

        public bool Distinct
        {
            get
            {
                return m_distinct;
            }

            set
            {
                m_distinct = value;
            }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        /// <summary>
        /// Set if the union with the previous query expression is
        /// UNION ALL.
        /// </summary>
        public bool All
        {
            get
            {
                return m_all;
            }

            set
            {
                m_all = value;
            }
        }

        public AliasedItem SelectItems
        {
            get
            {
                return m_selectItems;
            }

            set
            {
                m_selectItems = value;
            }
        }

        public AliasedItem From
        {
            get { return m_from; }
            set { m_from = value; }
        }

        public IExpression Where
        {
            get { return m_where; }
            set { m_where = value; }
        }

        public GroupByClause GroupBy
        {
            get { return m_groupBy; }
            set { m_groupBy = value; }
        }

        public OrderExpression OrderBy
        {
            get { return m_orderBy; }
            set { m_orderBy = value; }
        }

        #endregion

        #region Build methods

        public void Add(QueryExpression tail)
        {
            if (tail == null)
            {
                throw new ArgumentNullException("tail");
            }

            if (m_next == null)
            {
                m_next = tail;
            }
            else
            {
                m_next.Add(tail);
            }
        }

        internal void SetOrderBy(OrderExpression orderBy)
        {
            if (m_next == null)
            {
                m_orderBy = orderBy;
            }
            else
            {
                m_next.SetOrderBy(orderBy);
            }
        }

        internal OrderExpression GetOrderBy()
        {
            if (m_next == null)
            {
                return m_orderBy;
            }
            else
            {
                return m_next.GetOrderBy();
            }
        }

        internal IList<QueryExpression> GetUnion()
        {
            IList<QueryExpression> union;
            if (m_next == null)
            {
                union = new List<QueryExpression>();
            }
            else
            {
                union = m_next.GetUnion();
            }

            union.Insert(0, this);
            return union;
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            QueryExpression queryExpression = new QueryExpression();

            queryExpression.Distinct = m_distinct;
            queryExpression.All = m_all;
            queryExpression.Top = m_top;

            if (m_selectItems != null)
            {
                queryExpression.SelectItems = (AliasedItem)(m_selectItems.Clone());
            }

            if (m_from != null)
            {
                queryExpression.From = (AliasedItem)(m_from.Clone());
            }

            if (m_where != null)
            {
                queryExpression.Where = (IExpression)(m_where.Clone());
            }

            if (m_groupBy != null)
            {
                queryExpression.GroupBy = (GroupByClause)(m_groupBy.Clone());
            }

            if (m_orderBy != null)
            {
                queryExpression.OrderBy = (OrderExpression)(m_orderBy.Clone());
            }

            if (m_next != null)
            {
                queryExpression.Add((QueryExpression)(m_next.Clone()));
            }

            return queryExpression;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            if (m_selectItems == null)
            {
                throw new InvalidOperationException(
                    "Fully-constructed query expression must have select items.");
            }
            //Aliased item on WildCard
            m_selectItems.Traverse(visitor);

            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/

                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                if (trailor.queryParts.ParsingState == ParsingState.COLUMNS)
                {
                    /*On encountering FROM*/
                    trailor.queryParts.ParsingState = ParsingState.TABLE;
                }

            }
            visitor.PerformOnFrom(this);
            if (m_from != null)
            {
                m_from.Traverse(visitor);
            }

            visitor.PerformOnWhere(this);
            if (m_where != null)
            {
                Console.WriteLine("WHERE");
                if (visitor is MSqlServerTailor)
                {  /*Added by Kunal*/

                    MSqlServerTailor trailor = visitor as MSqlServerTailor;
                    trailor.queryParts.ParsingState = ParsingState.WHERECOND;
                }
                m_where.Traverse(visitor);
            }

            visitor.PerformOnGroupBy(this);
            if (m_groupBy != null)
            {
                m_groupBy.Traverse(visitor);
            }

            visitor.PerformOnOrderBy(this);
            if (m_orderBy != null)
            {
                m_orderBy.Traverse(visitor);
            }

            visitor.PerformAfter(this);

            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }
        }

        #endregion
    }
}
