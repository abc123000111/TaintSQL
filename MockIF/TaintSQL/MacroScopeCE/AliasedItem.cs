using System;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// SQL expression item (i.e. table column) with an optional alias.
    /// </summary>
    public sealed class AliasedItem : INode
    {
        #region Fields

        private INode m_item;

        private Identifier m_alias;

        private AliasedItem m_next;

        #endregion

        #region Constructor

        public AliasedItem(INode item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            m_item = item;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Item specification (never null).
        /// </summary>
        public INode Item
        {
            get
            {
                return m_item;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_item = value;
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

        public AliasedItem Next
        {
            get { return m_next; }
            set { m_next = value; }
        }

        #endregion

        #region Build methods

        public void Add(AliasedItem tail)
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
            AliasedItem aliasedItem = new AliasedItem(m_item.Clone());

            if (m_alias != null)
            {
                aliasedItem.Alias = (Identifier)(m_alias.Clone());
            }

            if (m_next != null)
            {
                aliasedItem.Add((AliasedItem)(m_next.Clone()));
            }

            return aliasedItem;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            
            //Wildcard
            if (m_item is Wildcard)
            {
                if (visitor is MSqlServerTailor)
                {  /*Added by Kunal*/
                    MSqlServerTailor trailor = visitor as MSqlServerTailor;
                    if (trailor.queryParts.ParsingState == ParsingState.COLUMNS)
                    {
                        trailor.queryParts.IsSelectAll = true;
                        //Add all columns
                    }
                }
            }
            m_item.Traverse(visitor);
            

            visitor.PerformOnAlias(this);
            if (m_alias != null)
            {
                m_alias.Traverse(visitor);
            }

            visitor.PerformAfter(this);

            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }
        }

        #endregion
    }
}
