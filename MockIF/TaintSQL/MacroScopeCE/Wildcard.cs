using System;

namespace MacroScope
{
    /// <summary>
    /// Represents '*' used as a wildcard argument.
    /// </summary>
    /// <remarks>
    /// Instances of this class have no state, allowing only one instance
    /// to be used by the whole package.
    /// </remarks>
    public sealed class Wildcard : INode
    {
        #region Well-known value

        private static readonly Wildcard m_value = new Wildcard();

        #endregion

        #region Constructor

        private Wildcard()
        {
        }

        #endregion

        #region Properties

        public static Wildcard Value
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
