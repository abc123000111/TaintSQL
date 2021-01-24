using System;
using System.Collections.Generic;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents a column assignment in SQL UPDATE command.
    /// </summary>
    public sealed class Assignment : INode
    {
        #region Fields

        private readonly DbObject m_name;

        private readonly INode m_value;

        private Assignment m_next;

        

        #endregion

        #region Constructor

        public Assignment(DbObject name, INode val)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            if (val == null)
            {
                throw new ArgumentNullException("val");
            }

            m_name = name;
            m_value = val;
        }

        #endregion

        #region Properties

        public DbObject Name
        {
            get { return m_name; }
        }

        public INode Value
        {
            get { return m_value; }
        }

        public Assignment Next
        {
            get { return m_next; }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        #endregion

        #region Build methods

        public void Add(Assignment tail)
        {
            if (tail == null)
            {
                throw new ArgumentNullException("tail");
            }

            if (m_next == null)
            {
                m_next = tail;
            }
            else
            {
                m_next.Add(tail);
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            Assignment assignment = new Assignment(
                (DbObject)(m_name.Clone()),
                m_value.Clone());

            if (m_next != null)
            {
                assignment.Add((Assignment)(m_next.Clone()));
            }

            return assignment;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_name.Traverse(visitor);
            visitor.PerformOnAssignment(this);
            m_value.Traverse(visitor);
            visitor.PerformAfter(this);

            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }
        }

        #endregion
    }
}
