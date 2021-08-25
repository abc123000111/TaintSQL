using System;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Replaces <see cref="Placeholder">placeholders</see> with
    /// individually named variables.
    /// </summary>
    public class Namer
    {
        #region Constants

        public static readonly string DEFAULT_STEM = "x";

        #endregion

        #region Fields

        private readonly char m_prefix;

        private readonly string m_stem;

        private int m_counter;

        #endregion

        #region Constructors

        public Namer(char prefix):
            this(prefix, DEFAULT_STEM)
        {
        }

        public Namer(char prefix, string stem)
        {
            if (!Variable.IsPrefix(prefix))
            {
                string message = string.Format("Invalid variable name prefix '{0}'.",
                    prefix);
                throw new ArgumentException(message, "prefix");
            }

            if (stem == null)
            {
                throw new ArgumentNullException("stem");
            }

            m_prefix = prefix;
            m_stem = stem;
            m_counter = 0;
        }

        #endregion

        #region IVisitor members

        public void PerformBefore(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            Variable left = CondGetVariable(node.Left);
            if (left != null)
            {
                node.Left = left;
            }

            Variable right = CondGetVariable(node.Right);
            if (right != null)
            {
                node.Right = right;
            }
        }

        #endregion

        #region Transformations

        Variable CondGetVariable(INode arg)
        {
            Placeholder p = arg as Placeholder;
            if (p == null)
            {
                return null;
            }

            return new Variable(GenName());
        }

        public string GenName()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_prefix);
            sb.Append(m_stem);

            sb.AppendFormat("{0:000}", m_counter++);
            if (m_counter >= 1000)
            {
                throw new Exception("Seriously...");
            }

            return sb.ToString();
        }

        #endregion
    }
}
