using System;

namespace MacroScope
{
    /// <summary>
    /// Represents a named SQL parameter.
    /// </summary>
    public sealed class Variable : INode
    {
        #region Fields

        private string m_prefixedName;

        #endregion

        #region Constructor

        public Variable(string prefixedName)
        {
            SetName(prefixedName);
        }

        #endregion

        #region Properties

        public char Prefix
        {
            get
            {
                return m_prefixedName[0];
            }

            set
            {
                if (!IsPrefix(value))
                {
                    string message = string.Format("Not a variable prefix: '{0}'.",
                        value);
                    throw new ArgumentException(message);
                }

                if (value != m_prefixedName[0])
                {
                    m_prefixedName = string.Format("{0}{1}", value, NameStem);
                }
            }
        }

        public string NameStem
        {
            get
            {
                return m_prefixedName.Substring(1);
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (value.Equals(""))
                {
                    throw new ArgumentException("Variable name stem can't be empty.");
                }

                m_prefixedName = string.Format("{0}{1}", m_prefixedName[0], value);
            }
        }

        /// <summary>
        /// The variable name, including prefix (never null).
        /// </summary>
        public string PrefixedName
        {
            get
            {
                return m_prefixedName;
            }

            set
            {
                SetName(value);
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new Variable(m_prefixedName);
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

        #region Value semantics

        /// <summary>
        /// Normalizes the name to a form suitable for string comparisons.
        /// </summary>
        /// <param name="prefixedName">
        /// The variable name: a prefix, followed by an ASCII letter, optionally
        /// followed by more ASCII letters, digits and underscores.
        /// </param>
        /// <returns>
        /// Name stem in lowercase (never null).
        /// </returns>
        public static string Canonicalize(string prefixedName)
        {
            if (prefixedName == null)
            {
                throw new ArgumentNullException("prefixedName");
            }

            if (prefixedName.Length < 2)
            {
                string message = string.Format("Variable name {0} has no prefix.",
                    prefixedName);
                throw new ArgumentException(message, "prefixedName");
            }

            if (!IsPrefix(prefixedName[0]))
            {
                string message = string.Format("Variable {0} has no prefix.",
                    prefixedName);
                throw new ArgumentException(message, "prefixedName");
            }

            string tail = prefixedName.Substring(1);
            string v = tail.ToLower();
            if (v == null)
            {
                string message = string.Format("Can't lowercase {0}.", prefixedName);
                throw new Exception(message);
            }

            return v;
        }

        public override bool Equals(object obj)
        {
            Variable other = obj as Variable;
            if (other == null)
            {
                return false;
            }

            string left = Canonicalize(PrefixedName);
            string right = Canonicalize(other.PrefixedName);

            return left.Equals(right);
        }

        public override int GetHashCode()
        {
            string left = Canonicalize(PrefixedName);
            return left.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Variable other = obj as Variable;
            if (other == null)
            {
                throw new ArgumentException("Object is not a Variable.", "obj");
            }

            string left = Canonicalize(PrefixedName);
            string right = Canonicalize(other.PrefixedName);

            return left.CompareTo(right);
        }

        #endregion

        #region Utilities

        void SetName(string prefixedName)
        {
            if (prefixedName == null)
            {
                throw new ArgumentNullException("prefixedName");
            }

            if (prefixedName.Length < 2)
            {
                string message = string.Format("Variable name {0} has no prefix.",
                    prefixedName);
                throw new ArgumentException(message, "prefixedName");
            }

            if (!IsPrefix(prefixedName[0]))
            {
                string message = string.Format("Variable {0} has no prefix.",
                    prefixedName);
                throw new ArgumentException(message, "prefixedName");
            }

            m_prefixedName = prefixedName;
        }

        public static bool IsPrefix(char c)
        {
            return (c == '@') || (c == ':');
        }

        #endregion
    }
}
