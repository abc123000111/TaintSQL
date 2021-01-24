using System;

namespace MacroScope
{
    /// <summary>
    /// SQL datetime fields.
    /// </summary>
    /// <remarks>
    /// SQL 92 only - MS extensions not supported.
    /// </remarks>
    public sealed class DateTimeUnit : INode
    {
        #region Fields

        private readonly string m_value;

        #endregion

        #region Well-known units

        private static readonly DateTimeUnit m_year = new DateTimeUnit("YEAR");

        private static readonly DateTimeUnit m_month = new DateTimeUnit("MONTH");

        private static readonly DateTimeUnit m_day = new DateTimeUnit("DAY");

        private static readonly DateTimeUnit m_hour = new DateTimeUnit("HOUR");

        private static readonly DateTimeUnit m_minute = new DateTimeUnit("MINUTE");

        private static readonly DateTimeUnit m_second = new DateTimeUnit("SECOND");

        #endregion

        #region Constructor

        private DateTimeUnit(string v)
        {
            if (v == null)
            {
                throw new ArgumentNullException("v");
            }

            m_value = v;
        }

        #endregion

        #region Properties

        public static DateTimeUnit Year
        {
            get { return DateTimeUnit.m_year; }
        }

        public static DateTimeUnit Month
        {
            get { return DateTimeUnit.m_month; }
        }

        public static DateTimeUnit Day
        {
            get { return DateTimeUnit.m_day; }
        }

        public static DateTimeUnit Hour
        {
            get { return DateTimeUnit.m_hour; }
        }

        public static DateTimeUnit Minute
        {
            get { return DateTimeUnit.m_minute; }
        }

        public static DateTimeUnit Second
        {
            get { return DateTimeUnit.m_second; }
        }

        public string Value
        {
            get { return m_value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return this;
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
