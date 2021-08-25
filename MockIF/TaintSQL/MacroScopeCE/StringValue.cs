using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace MacroScope
{
    /// <summary>
    /// Represents an SQL string literal.
    /// </summary>
    public sealed class StringValue : INode
    {
        #region Fields

        private string m_value;

        private char m_quoteType;

        #endregion

        #region Constructor

        public StringValue(string v)
        {
            if (v == null)
            {
                throw new ArgumentNullException("v");
            }

            m_value = v;
            m_quoteType = '\'';
        }

        #endregion

        #region Properties

        public string Value
        {
            get { return m_value; }
        }

        public char QuoteType
        {
            get
            {
                return m_quoteType;
            }

            set
            {
                char q = char.ToLower(value);
                if ((q == '\'') || (q == '\"') || (q == 'n'))
                {
                    m_quoteType = q;
                }
                else
                {
                    string message = string.Format("Invalid quote type {0}.", value);
                    throw new ArgumentException(message);
                }
            }
        }

        public string QuotedValue
        {
            get
            {
                StringBuilder quoted = new StringBuilder();

                char q = m_quoteType;
                if (q == 'n')
                {
                    quoted.Append('N');
                    q = '\'';
                }

                string quote = q.ToString();
                string quotequote = string.Format("{0}{1}", q, q);
                string p = Regex.Replace(m_value, quote, quotequote);

                quoted.Append(q);
                quoted.Append(p);
                quoted.Append(q);

                return quoted.ToString();
            }
        }

        #endregion

        #region Build methods

        public void Append(StringValue tail)
        {
            if (tail == null)
            {
                throw new ArgumentNullException("tail");
            }

            if (tail.QuoteType == 'n')
            {
                m_quoteType = 'n';
            }

            m_value += tail.Value;
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new StringValue(m_value);
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
