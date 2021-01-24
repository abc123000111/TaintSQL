using System;

namespace MacroScope
{
    /// <summary>
    /// An item of the SQL tree.
    /// </summary>
    public interface INode
    {
        #region Basics

        /// <summary>
        /// Generally deep clone, except for objects with no state
        /// (or private constructors), which return themselves.
        /// </summary>
        /// <returns>
        /// A copy of this node (never null).
        /// </returns>
        INode Clone();

        void Traverse(IVisitor visitor);

        #endregion
    }
}
