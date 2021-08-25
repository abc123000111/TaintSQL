using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MacroScope
{
    /// <summary>
    /// Retrieves variable names from a SQL command, changing
    /// repeated references to new names.
    /// </summary>
    /// <remarks>
    /// Currently used only when the backend is MS Access, but
    /// could potentially be useful for other engines not supporting
    /// named parameters.
    /// </remarks>
    public class ParamGrower : PassiveVisitor
    {
        #region Fields

        /// <summary>
        /// Maps raw name (either specified by caller, or
        /// sythetized) to its key.
        /// </summary>
        private readonly Dictionary<string, string> m_unique;

        /// <summary>
        /// Captures the sequence of raw names.
        /// </summary>
        private readonly List<string> m_ordered;

        #endregion

        #region Constructor

        public ParamGrower()
        {
            m_unique = new Dictionary<string, string>();
            m_ordered = new List<string>();
        }

        #endregion

        #region Accessors

        /// <summary>
        /// Returns parameter names, in the order they're used in the SQL tree.
        /// </summary>
        /// <returns>
        /// An array of positive length, or null.
        /// </returns>
        /// <remarks>
        /// When this method is called before traversing the tree, it returns null.
        /// </remarks>
        public string[] GetAllParams()
        {
            if (m_ordered.Count == 0)
            {
                return null;
            }
            else
            {
                return m_ordered.ToArray();
            }
        }

        /// <summary>
        /// Accessor for renamed parameter names.
        /// </summary>
        /// <param name="prefixedName">
        /// The parameter name: a prefix, followed by an ASCII letter, optionally
        /// followed by more ASCII letters, digits and underscores.
        /// </param>
        /// <returns>
        /// The key of the variable originally specified in
        /// the traversed SQL tree, even when the variable has been
        /// renamed during traversal. When (the key derived from)
        /// <paramref name="paramName"/> isn't in the traversed SQL, this method
        /// returns null.
        /// </returns>
        public string GetOriginalKey(string paramName)
        {
            if (paramName == null)
            {
                throw new ArgumentNullException("paramName");
            }

            string rv = null;
            if (m_unique.ContainsKey(paramName))
            {
                rv = m_unique[paramName];
                Debug.Assert(rv != null);
            }

            return rv;
        }

        #endregion

        #region IVisitor Members

        public override void Perform(Variable node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            string key = Variable.Canonicalize(node.PrefixedName);
            if (m_unique.ContainsKey(node.PrefixedName))
            {
                node.NameStem = PickKey(key);
            }

            m_unique.Add(node.PrefixedName, key);
            m_ordered.Add(node.PrefixedName);
        }

        #endregion

        #region Utilities

        string PickKey(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            for (int i = 0; i < 1000; ++i)
            {
                string newKey = string.Format("{0}{1:000}", key, i);
                if (!m_unique.ContainsKey(newKey))
                {
                    return newKey;
                }
            }

            throw new Exception("Too many parameters.");
        }

        #endregion
    }
}
