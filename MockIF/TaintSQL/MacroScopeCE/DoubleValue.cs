using System;
using System.Globalization;

namespace MacroScope
{
    /// <summary>
    /// Represents a floating-point constant.
    /// </summary>
    public sealed class DoubleValue : INode
    {
        #region Fields

        private readonly double m_value;

        #endregion

        #region Constructor

        public DoubleValue(double v)
        {
            m_value = v;
        }

        #endregion

        #region Properties

        public static IFormatProvider Format
        {
            get
            {
                NumberFormatInfo format = new NumberFormatInfo();
                format.NumberDecimalSeparator = ".";
                format.NumberGroupSeparator = "";
                format.PositiveSign = "";
                return format;
            }
        }

        public double Value
        {
            get { return m_value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new DoubleValue(m_value);
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

        public static double Parse(string n)
        {
            if (n == null)
            {
                throw new ArgumentNullException("n");
            }

            return double.Parse(n, Format);
        }

        #endregion
    }
}
