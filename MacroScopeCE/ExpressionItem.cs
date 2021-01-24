using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents SQL expressions in a list.
    /// </summary>
    public sealed class ExpressionItem : IExpression
    {
        #region Fields

        private readonly INode m_expression;

        private ExpressionItem m_next;

        #endregion

        #region Constructor

        public ExpressionItem(INode expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            m_expression = expression;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The inner expression (never null).
        /// </summary>
        public INode Expression
        {
            get { return m_expression; }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        public ExpressionItem Next
        {
            get { return m_next; }
            set { m_next = value; }
        }

        public bool IsComposed
        {
            get
            {
                return false;
            }
        }

        #endregion

        #region Build methods

        public void Add(ExpressionItem tail)
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
            ExpressionItem expressionItem = new ExpressionItem(m_expression.Clone());

            if (m_next != null)
            {
                expressionItem.Add((ExpressionItem)(m_next.Clone()));
            }

            return expressionItem;
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
