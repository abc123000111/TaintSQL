using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents (the name of) a relational database object.
    /// </summary>
    public sealed class DbObject : INode, IComparable 
    {
        #region Fields

        private readonly Identifier m_identifier;

        private DbObject m_next;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs an instance from a single identifier.
        /// </summary>
        public DbObject(Identifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            m_identifier = identifier;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The object identifier (never null).
        /// </summary>
        /// <remarks>
        /// Just the first segment - doesn't include potential next parts.
        /// </remarks>
        public Identifier Identifier
        {
            get { return m_identifier; }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        public DbObject Next
        {
            get
            {
                return m_next;
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            DbObject dbObject = new DbObject((Identifier)(m_identifier.Clone()));

            if (m_next != null)
            {
                dbObject.Add((DbObject)(m_next.Clone()));
            }

            return dbObject;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_identifier.Traverse(visitor);
            visitor.PerformAfter(this);

            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }
        }

        #endregion

        #region Build methods

        public void Add(DbObject tail)
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

        #region Value semantics

        public override bool Equals(object obj)
        {
            DbObject other = obj as DbObject;
            if (other == null)
            {
                return false;
            }

            string left = Identifier.Canonicalize(Identifier.ID);
            string right = Identifier.Canonicalize(other.Identifier.ID);

            if (!left.Equals(right))
            {
                return false;
            }

            if (m_next != null)
            {
                DbObject tail = other.Next;
                if (tail == null)
                {
                    return false;
                }
                else
                {
                    return m_next.Equals(tail);
                }
            }
            else
            {
                return !other.HasNext;
            }
        }

        public override int GetHashCode()
        {
            string left = Identifier.Canonicalize(m_identifier.ID);
            int hash = left.GetHashCode();
            if (m_next != null)
            {
                hash ^= m_next.GetHashCode();
            }

            return hash;
        }

        public int CompareTo(object obj)
        {
            DbObject other = obj as DbObject;
            if (other == null)
            {
                throw new ArgumentException("Object is not a DbObject.", "obj");
            }

            string left = Identifier.Canonicalize(Identifier.ID);
            string right = Identifier.Canonicalize(other.Identifier.ID);

            int cmp = left.CompareTo(right);
            if (cmp != 0)
            {
                return cmp;
            }

            if (m_next != null)
            {
                DbObject tail = other.Next;
                if (tail == null)
                {
                    return 1;
                }
                else
                {
                    return m_next.CompareTo(tail);
                }
            }
            else
            {
                return other.HasNext ? -1 : 0;
            }
        }

        #endregion
    }
}
