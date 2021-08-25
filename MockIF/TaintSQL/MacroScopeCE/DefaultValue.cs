using System;
using System.Collections.Generic;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents the SQL DEFAULT (as used in SQL INSERT).
    /// </summary>
    /// <remarks>
    /// Instances of this class have no state, allowing only one instance
    /// to be used by the whole package.
    /// </remarks>
    public sealed class DefaultValue : INode
    {
        #region Well-known value

        private static readonly DefaultValue m_value = new DefaultValue();

        #endregion

        #region Constructor

        private DefaultValue()
        {
        }

        #endregion

        #region Properties

        public static DefaultValue Value
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
