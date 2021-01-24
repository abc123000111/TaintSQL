using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MacroScope
{
    /// <summary>
    /// Retrieves variable names from a SQL command.
    /// </summary>
    public class ParamPicker : PassiveVisitor
    {
        #region Fields

        private readonly Dictionary<string, string> m_unique;

        /// <summary>
        /// Captures the sequence of raw names.
        /// </summary>
        private readonly List<string> m_ordered;

        #endregion

        #region Constructor

        public ParamPicker()
        {
            m_unique = new Dictionary<string, string>();
            m_ordered = new List<string>();
        }

        #endregion

        #region Accessors

        public bool IsParam(string paramName)
        {
            if (paramName == null)
            {
                throw new ArgumentNullException("paramName");
            }

            string key = Variable.Canonicalize(paramName);
            return m_unique.ContainsKey(key);
        }

        /// <summary>
        /// Returns parameter names, in the order they're used in the SQL tree.
        /// </summary>
        /// <returns>
        /// An array of positive length, or null.
        /// </returns>
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
        /// Returns parameter names used in the SQL tree.
        /// </summary>
        /// <returns>
        /// An array of positive length, or null.
        /// </returns>
        /// <remarks>
        /// Same variables with different prefixes are collapsed
        /// into one name.
        /// </remarks>
        public string[] GetUniqueParams()
        {
            if (m_unique.Count == 0)
            {
                return null;
            }

            string[] unique = new string[m_unique.Count];
            int i = 0;
            foreach (string v in m_unique.Values)
            {
                Debug.Assert(v != null);
                unique[i++] = v;
            }

            Array.Sort(unique);
            return unique;
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
            if (!m_unique.ContainsKey(key))
            {
                m_unique.Add(key, node.PrefixedName);
            }

            m_ordered.Add(node.PrefixedName);
        }

        #endregion
    }
}
