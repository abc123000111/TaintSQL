using System;

namespace MacroScope
{
    /// <summary>
    /// Represents a parenthesized expression.
    /// </summary>
    public sealed class BracketedExpression : IExpression
    {
        #region Fields

        private readonly INode m_term;

        private bool m_spaced;

        #endregion

        #region Constructor

        public BracketedExpression(INode term)
        {
            if (term == null)
            {
                throw new ArgumentNullException("term");
            }

            m_term = term;
            m_spaced = false;
        }

        #endregion

        #region Properties

        public INode Term
        {
            get { return m_term; }
        }

        public bool Spaced
        {
            get { return m_spaced; }
            set { m_spaced = value; }
        }

        public bool IsComposed
        {
            get { return true; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            BracketedExpression bracketedExpression =
                new BracketedExpression(m_term.Clone());
            bracketedExpression.Spaced = m_spaced;
            return bracketedExpression;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_term.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion
    }
}
