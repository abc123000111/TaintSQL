using System;
using System.Collections.Generic;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents the '?' parameter placeholder.
    /// </summary>
    /// <remarks>
    /// Instances of this class have no state, allowing only one instance
    /// to be used by the whole package.
    /// </remarks>
    public sealed class Placeholder : INode
    {
        #region Well-known value

        private static readonly Placeholder m_value = new Placeholder();

        #endregion

        #region Constructor

        private Placeholder()
        {
        }

        #endregion

        #region Properties

        public static Placeholder Value
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
