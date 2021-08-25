using System;

namespace MacroScope
{
    /// <summary>
    /// Represents the SQL NULL.
    /// </summary>
    /// <remarks>
    /// Instances of this class have no state, allowing only one instance
    /// to be used by the whole package.
    /// </remarks>
    public sealed class NullValue : INode
    {
        #region Well-known value

        private static readonly NullValue m_value = new NullValue();

        #endregion

        #region Constructor

        private NullValue()
        {
        }

        #endregion

        #region Properties

        public static NullValue Value
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
