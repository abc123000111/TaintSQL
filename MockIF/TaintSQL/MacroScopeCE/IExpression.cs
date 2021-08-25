using System;

namespace MacroScope
{
    /// <summary>
    /// An SQL expression, which may or may not need parentheses when stringified.
    /// </summary>
    public interface IExpression : INode
    {
        #region Properties

        bool IsComposed { get; }

        #endregion
    }
}
