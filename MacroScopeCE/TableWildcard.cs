using System;
using System.Collections.Generic;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents the SQL specification of all columns in a table
    /// (i.e. <c>tablename.*</c>).
    /// </summary>
    public sealed class TableWildcard : INode
    {
        #region Fields

        private readonly DbObject m_dbObject;

        #endregion

        #region Constructor

        public TableWildcard(DbObject dbObject)
        {
            if (dbObject == null)
            {
                throw new ArgumentNullException("dbObject");
            }

            m_dbObject = dbObject;
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new TableWildcard((DbObject)(m_dbObject.Clone()));
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_dbObject.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion
    }
}
