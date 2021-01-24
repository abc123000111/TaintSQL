using System;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Right argument of <see cref="ExpressionOperator.Between"/>.
    /// </summary>
    public sealed class Range : INode
    {
        #region Fields

        private readonly IExpression m_from;

        private readonly IExpression m_to;

        #endregion

        #region Constructor

        public Range(IExpression from, IExpression to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            m_from = from;
            m_to = to;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Lower bound (never null).
        /// </summary>
        public IExpression From
        {
            get { return m_from; }
        }

        /// <summary>
        /// Upper bound (never null).
        /// </summary>
        public IExpression To
        {
            get { return m_to; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new Range((IExpression)(m_from.Clone()),
                (IExpression)(m_to.Clone()));
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_from.Traverse(visitor);
            visitor.PerformOnAnd(this);
            m_to.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion
    }
}
