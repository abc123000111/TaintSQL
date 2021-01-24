using System;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents a GROUP BY clause of a SQL SELECT statement.
    /// </summary>
    public sealed class GroupByClause : INode
    {
        #region Fields

        private bool m_all = false;

        private ExpressionItem m_expression;

        private IExpression m_having;

        #endregion

        #region Properties

        public bool All
        {
            get { return m_all; }
            set { m_all = value; }
        }

        public ExpressionItem Expression
        {
            get { return m_expression; }
            set { m_expression = value; }
        }

        public IExpression Having
        {
            get { return m_having; }
            set { m_having = value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            GroupByClause groupByClause = new GroupByClause();
            groupByClause.All = m_all;

            if (m_expression != null)
            {
                groupByClause.Expression = (ExpressionItem)(m_expression.Clone());
            }

            if (m_having != null)
            {
                groupByClause.Having = (IExpression)(m_having.Clone());
            }

            return groupByClause;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);

            if (m_expression == null)
            {
                throw new InvalidOperationException("GROUP BY must have expression.");
            }

            m_expression.Traverse(visitor);

            visitor.PerformOnHaving(this);
            if (m_having != null)
            {
                m_having.Traverse(visitor);
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
