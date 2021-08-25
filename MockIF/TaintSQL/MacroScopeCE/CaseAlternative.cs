using System;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Branch of a <see cref="CaseExpression">CASE expression</see> or
    /// MS Access <see cref="SwitchFunction">Switch function</see>.
    /// </summary>
    public sealed class CaseAlternative : INode
    {
        #region Fields

        private IExpression m_when;

        private readonly IExpression m_then;

        private CaseAlternative m_next;

        #endregion

        #region Constructor

        public CaseAlternative(IExpression when, IExpression then)
        {
            if (when == null)
            {
                throw new ArgumentNullException("when");
            }

            if (then == null)
            {
                throw new ArgumentNullException("then");
            }

            m_when = when;
            m_then = then;
        }

        #endregion

        #region Properties

        public IExpression When
        {
            get
            {
                return m_when;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_when = value;
            }
        }

        public IExpression Then
        {
            get { return m_then; }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        public CaseAlternative Next
        {
            get { return m_next; }
            set { m_next = value; }
        }

        #endregion

        #region Build methods

        public void Add(CaseAlternative tail)
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
            CaseAlternative caseAlternative = new CaseAlternative(
                (IExpression)(m_when.Clone()),
                (IExpression)(m_then.Clone()));

            if (m_next != null)
            {
                caseAlternative.Add((CaseAlternative)(m_next.Clone()));
            }

            return caseAlternative;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_when.Traverse(visitor);
            visitor.PerformOnThen(this);
            m_then.Traverse(visitor);
            visitor.PerformAfter(this);

            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }
        }

        #endregion
    }
}
