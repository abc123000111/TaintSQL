using System;
using System.Diagnostics;
using System.Globalization;

namespace MacroScope
{
    /// <summary>
    /// Represents an integer constant.
    /// </summary>
    public sealed class IntegerValue : INode
    {
        #region Fields

        /// <summary>
        /// AddressSearch needs higher range than int.
        /// </summary>
        private readonly decimal m_value;

        #endregion

        #region Constructor

        public IntegerValue(int v)
        {
            m_value = v;
        }

        public IntegerValue(decimal v)
        {
            m_value = v;
        }

        #endregion

        #region Properties

        public decimal Value
        {
            get { return m_value; }
        } 
        
        #endregion

        #region INode Members

        public INode Clone()
        {
            return new IntegerValue(m_value);
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

        #region Input parsing

        public static int ParseHex(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("s");
            }

            string t = s.ToLower(CultureInfo.InvariantCulture);
            if (!t.StartsWith("0x"))
            {
                string message = string.Format("\"{0}\" is not a hexadecimal number.",
                    s);
                throw new Exception(message);
            }

            int n = 0;
            int i = 2;
            while (i < t.Length)
            {
                if (n > int.MaxValue / 16)
                {
                    string message = string.Format("\"{0}\" overflows.",
                        s);
                    throw new Exception(message);
                }

                int d = ParseHexDigit(t[i]);
                if (d < 0)
                {
                    string message = string.Format("\"{0}\" isn't a hexadecimal number.",
                        s);
                    throw new Exception(message);
                }

                n = 16 * n + d;
                ++i;
            }

            return n;
        }

        static int ParseHexDigit(char d)
        {
            if ((d >= '0') && (d <= '9'))
            {
                return d - '0';
            }
            else if ((d >= 'a') && (d <= 'f'))
            {
                return 10 + d - 'a';
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
