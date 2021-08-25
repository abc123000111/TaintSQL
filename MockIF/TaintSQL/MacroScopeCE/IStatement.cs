using System;

namespace MacroScope
{
    /// <summary>
    /// Common interface for SQL statements.
    /// </summary>
    /// <remarks>
    /// Currently empty, but could contain stringification,
    /// parameter access etc.
    /// </remarks>
    public interface IStatement : INode
    {
    }
}
