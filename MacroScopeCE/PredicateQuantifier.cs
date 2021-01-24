using System;

namespace MacroScope
{
    /// <summary>
    /// SQL predicate quantifiers: ALL and ANY.
    /// </summary>
    /// <remarks>
    /// Quantifier SOME is parsed, but treated as a synonym of ALL.
    /// </remarks>
    public sealed class PredicateQuantifier : INode
    {
        #region Fields

        private readonly string m_value;

        #endregion

        #region Well-known quantifiers

        private static readonly PredicateQuantifier m_all = new PredicateQuantifier("ALL");

        private static readonly PredicateQuantifier m_any = new PredicateQuantifier("ANY");

        #endregion

        #region Constructor

        private PredicateQuantifier(string v)
        {
            if (v == null)
            {
                throw new ArgumentNullException("v");
            }

            m_value = v;
        }

        #endregion

        #region Properties

        public static PredicateQuantifier All
        {
            get { return PredicateQuantifier.m_all; }
        }

        public static PredicateQuantifier Any
        {
            get { return PredicateQuantifier.m_any; }
        }

        public string Value
        {
            get { return m_value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return this;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.Perform(this);
        }

        #endregion
    }
}
