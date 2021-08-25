using System;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Right argument of <see cref="ExpressionOperator.Like"/>
    /// and <see cref="ExpressionOperator.NotLike"/>.
    /// </summary>
    public sealed class PatternExpression : IExpression
    {
        #region Fields

        private readonly IExpression m_expression;

        private IExpression m_escape;

        #endregion

        #region Constructor

        public PatternExpression(IExpression expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            m_expression = expression;
        }

        #endregion

        #region Properties

        public bool IsComposed
        {
            get
            {
                return false; // no open paren after LIKE
            }
        }

        /// <summary>
        /// Inner expression (never null).
        /// </summary>
        public IExpression Expression
        {
            get { return m_expression; }
        }

        public IExpression Escape
        {
            get { return m_escape; }
            set { m_escape = value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            PatternExpression patternExpression = new PatternExpression(
                (IExpression)(m_expression.Clone()));

            if (m_escape != null)
            {
                patternExpression.Escape = (IExpression)(m_escape.Clone());
            }

            return patternExpression;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_expression.Traverse(visitor);

            visitor.PerformOnEscape(this);
            if (m_escape != null)
            {
                m_escape.Traverse(visitor);
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
