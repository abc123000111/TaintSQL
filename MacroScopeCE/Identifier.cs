using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MacroScope
{
    /// <summary>
    /// A simple name, optionally quoted.
    /// </summary>
    public sealed class Identifier : INode
    {
        #region Constants

        private const char NOQUOTE = '0';

        private static readonly Dictionary<string, int> m_reservedWords;

        #endregion

        #region Fields

        private string m_identifier;

        #endregion

        #region Constructors

        static Identifier()
        {
	    // SQL 92
            string[] reserved = { "ABSOLUTE", "ACTION", "ADD", "ALL",
        		"ALLOCATE", "ALTER", "AND", "ANY", "ARE", "AS", "ASC",
		        "ASSERTION", "AT", "AUTHORIZATION", "AVG", "BEGIN",
        		"BETWEEN", "BIT", "BIT_LENGTH", "BOTH", "BY", "CASCADE",
        		"CASCADED", "CASE", "CAST", "CATALOG", "CHAR",
		        "CHARACTER", "CHAR_LENGTH", "CHARACTER_LENGTH", "CHECK",
        		"CLOSE", "COALESCE", "COLLATE", "COLLATION", "COLUMN",
		        "COMMIT", "CONNECT", "CONNECTION", "CONSTRAINT",
        		"CONSTRAINTS", "CONTINUE", "CONVERT", "CORRESPONDING",
		        "COUNT", "CREATE", "CROSS", "CURRENT", "CURRENT_DATE",
        		"CURRENT_TIME", "CURRENT_TIMESTAMP", "CURRENT_USER",
		        "CURSOR", "DATE", "DAY", "DEALLOCATE", "DEC", "DECIMAL",
        		"DECLARE", "DEFAULT", "DEFERRABLE", "DEFERRED", "DELETE",
		        "DESC", "DESCRIBE", "DESCRIPTOR", "DIAGNOSTICS",
        		"DISCONNECT", "DISTINCT", "DOMAIN", "DOUBLE", "DROP",
		        "ELSE", "END", "END-EXEC", "ESCAPE", "EXCEPT", "EXCEPTION",
        		"EXEC", "EXECUTE", "EXISTS", "EXTERNAL", "EXTRACT", "FALSE",
		        "FETCH", "FIRST", "FLOAT", "FOR", "FOREIGN", "FOUND", "FROM",
        		"FULL", "GET", "GLOBAL", "GO", "GOTO", "GRANT", "GROUP",
		        "HAVING", "HOUR", "IDENTITY", "IMMEDIATE", "IN", "INDICATOR",
        		"INITIALLY", "INNER", "INPUT", "INSENSITIVE", "INSERT",
		        "INT", "INTEGER", "INTERSECT", "INTERVAL", "INTO", "IS",
        		"ISOLATION", "JOIN", "KEY", "LANGUAGE", "LAST", "LEADING",
		        "LEFT", "LEVEL", "LIKE", "LOCAL", "LOWER", "MATCH", "MAX",
        		"MIN", "MINUTE", "MODULE", "MONTH", "NAMES", "NATIONAL",
		        "NATURAL", "NCHAR", "NEXT", "NO", "NOT", "NULL", "NULLIF",
        		"NUMERIC", "OCTET_LENGTH", "OF", "ON", "ONLY", "OPEN",
		        "OPTION", "OR", "ORDER", "OUTER", "OUTPUT", "OVERLAPS", "PAD",
        		"PARTIAL", "POSITION", "PRECISION", "PREPARE", "PRESERVE",
		        "PRIMARY", "PRIOR", "PRIVILEGES", "PROCEDURE", "PUBLIC",
        		"READ", "REAL", "REFERENCES", "RELATIVE", "RESTRICT",
		        "REVOKE", "RIGHT", "ROLLBACK", "ROWS", "SCHEMA", "SCROLL",
        		"SECOND", "SECTION", "SELECT", "SESSION", "SESSION_USER",
		        "SET", "SIZE", "SMALLINT", "SOME", "SPACE", "SQL", "SQLCODE",
        		"SQLERROR", "SQLSTATE", "SUBSTRING", "SUM", "SYSTEM_USER",
		        "TABLE", "TEMPORARY", "THEN", "TIME", "TIMESTAMP",
        		"TIMEZONE_HOUR", "TIMEZONE_MINUTE", "TO", "TRAILING",
		        "TRANSACTION", "TRANSLATE", "TRANSLATION", "TRIM", "TRUE",
        		"UNION", "UNIQUE", "UNKNOWN", "UPDATE", "UPPER", "USAGE",
		        "USER", "USING", "VALUE", "VALUES", "VARCHAR", "VARYING",
        		"VIEW", "WHEN", "WHENEVER", "WHERE", "WITH", "WORK", "WRITE",
		        "YEAR", "ZONE" };

            m_reservedWords = new Dictionary<string, int>();
            for (int i = 0; i < reserved.Length; ++i)
            {
                m_reservedWords.Add(reserved[i], 1);
            }
        }

        public Identifier(string identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.Equals(""))
            {
                throw new ArgumentException("Empty identifier.", "identifier");
            }

            m_identifier = identifier;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The name, as currently quoted (never null).
        /// </summary>
        public string ID
        {
            get { return m_identifier; }
        }

        #endregion

        #region Quoting

        public void NormalizeQuotes(char openQuote)
        {
            char closeQuote = GetCloseQuote(openQuote);
            if (closeQuote == NOQUOTE)
            {
                string message = string.Format("Invalid opening quote '{0}'.",
                    openQuote);
                throw new ArgumentException(message, "openQuote");
            }

            string unquoted = Unquote(m_identifier);
            Match match = Regex.Match(unquoted, "^[a-z][a-z0-9_]*$",
                RegexOptions.IgnoreCase);
            if (match.Success &&
                !m_reservedWords.ContainsKey(unquoted.ToUpper()))
            {
                m_identifier = unquoted;
            }
            else
            {
                if (openQuote != m_identifier[0])
                {
                    string pattern = string.Format("{0}", closeQuote);
                    string replacement = string.Format("{0}{0}", closeQuote);
                    string inner = Regex.Replace(unquoted, pattern, replacement);
                    m_identifier = string.Format("{0}{1}{2}", openQuote, inner, closeQuote);
                }
            }
        }

        #endregion

        #region Value semantics

        public override string ToString()
        {
            return m_identifier;
        }

        public static string Canonicalize(string identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            return Unquote(identifier.ToLower());
        }

        static char GetCloseQuote(char openQuote)
        {
            switch (openQuote)
            {
                case '[':
                    return ']';

                case '"':
                case '`':
                    return openQuote;

                default:
                    return NOQUOTE;
            }
        }

        public static string Unquote(string identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            int l = identifier.Length;
            if (l < 2)
            {
                return identifier;
            }

            char openQuote = identifier[0];
            char closeQuote = GetCloseQuote(openQuote);
            if (closeQuote == NOQUOTE)
            {
                return identifier;
            }

            if (identifier[l - 1] != closeQuote)
            {
                string message = string.Format("Identifier \"{0}\" isn't quoted.",
                    identifier);
                throw new ArgumentException(message);
            }

            string p = identifier.Substring(1, l - 2);
            Debug.Assert(p != null);

            string v;
            if (openQuote == '`')
            {
                if (p.IndexOf('`') >= 0)
                {
                    throw new Exception("Backquotes cannot be quoted.");
                }

                v = p;
            }
            else
            {
                string pattern = string.Format("{0}{0}", closeQuote);
                string replacement = string.Format("{0}", closeQuote);
                v = Regex.Replace(p, pattern, replacement);
                Debug.Assert(v != null);
            }

            return v;
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new Identifier(m_identifier);
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }
            //Console.WriteLine("Table : " + this.ID);
            visitor.Perform(this);
        }

        #endregion
    }
}
