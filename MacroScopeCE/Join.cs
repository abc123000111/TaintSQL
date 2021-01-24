using System;
using System.Collections.Generic;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// SQL join types.
    /// </summary>
    public sealed class Join : INode
    {
        #region Fields

        private readonly string m_type;

        #endregion

        #region Well-known joins

        private static readonly Join m_cross = new Join("CROSS");

        private static readonly Join m_inner = new Join("INNER");

        private static readonly Join m_left = new Join("LEFT");

        private static readonly Join m_right = new Join("RIGHT");

        private static readonly Join m_full = new Join("FULL");

        #endregion

        #region Constructor

        private Join(string type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            m_type = type;
        }

        #endregion

        #region Properties

        public static Join Cross
        {
            get { return Join.m_cross; }
        }

        public static Join Inner
        {
            get { return m_inner; }
        }

        public static Join Left
        {
            get { return m_left; }
        }

        public static Join Right
        {
            get { return m_right; }
        }

        public static Join Full
        {
            get { return Join.m_full; }
        }

        public string Type
        {
            get { return m_type; }
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
