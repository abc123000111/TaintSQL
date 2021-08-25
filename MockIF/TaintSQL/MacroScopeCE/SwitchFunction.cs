using System;
using System.Collections.Generic;

namespace MacroScope
{
    /// <summary>
    /// MS Access <c>Switch(condition_1, value_1, ... condition_n, value_n)</c>.
    /// </summary>
    public sealed class SwitchFunction : IExpression
    {
        #region Fields

        private CaseAlternative m_alternatives;

        #endregion

        #region Properties

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
            SwitchFunction switchFunction = new SwitchFunction();

            if (m_alternatives != null)
            {
                switchFunction.Alternatives = (CaseAlternative)(m_alternatives.Clone());
            }

            return switchFunction;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);

            if (m_alternatives == null)
            {
                throw new InvalidOperationException("Swich function has no arguments.");
            }

            m_alternatives.Traverse(visitor);

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
