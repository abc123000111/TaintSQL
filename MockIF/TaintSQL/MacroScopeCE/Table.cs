using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents a table (possibly a derived table), with optional alias and join.
    /// </summary>
    public sealed class Table : INode
    {
        #region Fields

        private readonly INode m_source;

        private Join m_join;

        private IExpression m_joinCondition;

        private Identifier m_alias;

        private Table m_next;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a table object.
        /// </summary>
        /// <param name="source">
        /// Table source - normally just a column name
        /// (i.e. an instance of <see cref="DbObject"/>), but can also be
        /// a group of joined tables, or a <see cref="QueryExpression"/>.
        /// </param>
        public Table(INode source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            m_source = source;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The table source (never null).
        /// </summary>
        public INode Source
        {
            get { return m_source; }
        }

        public Join JoinType
        {
            get
            {
                return m_join;
            }

            set
            {
                m_join = value;
            }
        }

        public IExpression JoinCondition
        {
            get
            {
                return m_joinCondition;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_joinCondition = value;
            }
        }

        public Identifier Alias
        {
            get
            {
                return m_alias;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid alias.");
                }

                m_alias = value;
            }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        public Table Next
        {
            get
            {
                return m_next;
            }

            set
            {
                m_next = value;
            }
        }

        #endregion

        #region Build methods

        public void Add(Table tail)
        {
            if (tail == null)
            {
                throw new ArgumentNullException("tail");
            }

            if ((tail.JoinType != Join.Cross) &&
                (tail.JoinCondition == null))
            {
                throw new InvalidOperationException("Cannot join a table without join condition.");
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
            Table table = new Table(m_source.Clone());

            if (m_join != null)
            {
                table.JoinType = (Join)(m_join.Clone());
            }

            if (m_joinCondition != null)
            {
                table.JoinCondition = (IExpression)(m_joinCondition.Clone());
            }

            if (m_alias != null)
            {
                table.Alias = (Identifier)(m_alias.Clone());
            }

            if (m_next != null)
            {
                table.Add((Table)(m_next.Clone()));
            }

            return table;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);

            if (m_join != null)
            {
                m_join.Traverse(visitor);
            }

            visitor.PerformOnSource(this);

            Debug.Assert(m_source != null);
            if (visitor is MSqlServerTailor)
            {  /*Added by Kunal*/

                MSqlServerTailor trailor = visitor as MSqlServerTailor;
                if (trailor.queryParts.ParsingState == ParsingState.TABLE)
                {
                    //trailor.queryParts.ParsingState = ParsingState.WHERE;
                    trailor.queryParts.TableNames.Add(((DbObject)m_source).Identifier.ID);
                }

            }
            m_source.Traverse(visitor);

            visitor.PerformOnAlias(this);
            if (m_alias != null)
            {
                m_alias.Traverse(visitor);
            }

            visitor.PerformBeforeCondition(this);

            if (m_joinCondition != null)
            {
                if (visitor is MSqlServerTailor)
                {  /*Added by Kunal*/
                    MSqlServerTailor trailor = visitor as MSqlServerTailor;
                    trailor.queryParts.joinCondition = (Expression) m_joinCondition;
                }
                m_joinCondition.Traverse(visitor);

            }

            visitor.PerformAfterCondition(this);
            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
