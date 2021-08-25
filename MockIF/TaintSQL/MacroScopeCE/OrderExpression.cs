using System;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Encapsulates an expression (normally a column) in ORDER BY clause,
    /// together with the sort direction.
    /// </summary>
    public sealed class OrderExpression : INode
    {
        #region Fields

        private readonly IExpression m_expression;

        private bool m_asc;

        private OrderExpression m_next;

        #endregion

        #region Constructor

        public OrderExpression(IExpression expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            m_expression = expression;
            m_asc = true;
        }

        #endregion

        #region Properties

        public IExpression Expression
        {
            get { return m_expression; }
        }

        public bool Asc
        {
            get { return m_asc; }
            set { m_asc = value; }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        #endregion

        #region Build methods

        public void Add(OrderExpression tail)
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

        #endregion

        #region INode Members

        public INode Clone()
        {
            OrderExpression orderExpression = new OrderExpression(
                (IExpression)(m_expression.Clone()));
            orderExpression.Asc = m_asc;

            if (m_next != null)
            {
                orderExpression.Add((OrderExpression)(m_next.Clone()));
            }

            return orderExpression;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_expression.Traverse(visitor);
            visitor.PerformAfter(this);

            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }
        }

        #endregion
    }
}
