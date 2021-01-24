using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MacroScope
{
    /// <summary>
    /// Represents a datetime literal.
    /// </summary>
    /// <remarks>
    /// Times represented by instances of this class are in (whole) seconds.
    /// </remarks>
    public sealed class LiteralDateTime : INode
    {
        #region Fields

        private static readonly string T = "T";

        private readonly string m_bareLiteral;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance from a string literal.
        /// </summary>
        /// <param name="literal">
        /// The datetime, either in a subset of
        /// ISO 8601 format - either <c>yyyy-MM-ddTHH:mm:ss</c>
        /// or <c>yyyy-MM-dd HH:mm:ss</c> - or in a format accepted by MS Access,
        /// that is <c>#yyyy-MM-dd HH:mm:ss#</c>.
        /// </param>
        public LiteralDateTime(string literal)
        {
            if (literal == null)
            {
                throw new ArgumentNullException("quotedLiteral");
            }

            if (literal.Length < 18)
            {
                string message = string.Format("Literal datetime {0} too short.",
                    literal);
                throw new ArgumentException(message);
            }

            if (literal[0] == '#')
            {
                if (literal[literal.Length - 1] != '#')
                {
                    string message = string.Format("Literal date {0} is not quoted.",
                        literal);
                    throw new ArgumentException(message);
                }

                m_bareLiteral = literal.Substring(1, literal.Length - 2);
            }
            else
            {
                m_bareLiteral = Regex.Replace(literal, T, " ",
                    RegexOptions.IgnoreCase);
            }
        }

        public LiteralDateTime(DateTime dateTime)
        {
            m_bareLiteral = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        #endregion

        #region Properties

        public string MAccessLiteral
        {
            get
            {
                return string.Format("#{0}#", m_bareLiteral);
            }
        }

        public string Iso8601Literal
        {
            get
            {
                return Regex.Replace(m_bareLiteral, " ", T);
            }
        }

        public DateTime DateTime
        {
            get
            {
                return DateTime.ParseExact(m_bareLiteral,
                    "yyyy-MM-dd HH:mm:ss",
                    null);
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new LiteralDateTime(m_bareLiteral);
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
