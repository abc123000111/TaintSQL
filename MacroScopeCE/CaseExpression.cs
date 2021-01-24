using System;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// SQL CASE WHEN ... THEN ... END
    /// </summary>
    public sealed class CaseExpression : IExpression
    {
        #region Fields

        private IExpression m_case;

        private IExpression m_else;

        private CaseAlternative m_alternatives;

        #endregion

        #region Properties

        public IExpression Case
        {
            get { return m_case; }
            set { m_case = value; }
        }

        public IExpression Else
        {
            get { return m_else; }
            set { m_else = value; }
        }

        public CaseAlternative Alternatives
        {
            get { return m_alternatives; }
            set { m_alternatives = value; }
        }

        public bool IsComposed
        {
            get { return false; }
        }

        #endregion

        #region Build methods

        public void Add(CaseAlternative tail)
        {
            if (tail == null)
            {
                throw new ArgumentNullException("tail");
            }

            if (m_alternatives == null)
            {
                m_alternatives = tail;
            }
            else
            {
                m_alternatives.Add(tail);
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            CaseExpression caseExpression = new CaseExpression();

            if (m_case != null)
            {
                caseExpression.Case = (IExpression)(m_case.Clone());
            }

            if (m_else != null)
            {
                caseExpression.Else = (IExpression)(m_else.Clone());
            }

            if (m_alternatives != null)
            {
                caseExpression.Alternatives = (CaseAlternative)(m_alternatives.Clone());
            }

            return caseExpression;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            if (m_case != null)
            {
                m_case.Traverse(visitor);
            }

            visitor.PerformOnWhen(this);

            if (m_alternatives == null)
            {
                throw new InvalidOperationException("CASE expression has no alternatives.");
            }

            m_alternatives.Traverse(visitor);

            visitor.PerformOnElse(this);
            if (m_else != null)
            {
                m_else.Traverse(visitor);
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
