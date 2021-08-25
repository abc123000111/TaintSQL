using System;

namespace MacroScope
{
    /// <summary>
    /// Represents an SQL datetime interval.
    /// </summary>
    /// <remarks>
    /// Much simplified from SQL 92 - basically just enough
    /// for a simple transformation to DATEADD.
    /// </remarks>
    public sealed class Interval : INode
    {
        #region Fields

        private bool m_positive;

        private INode m_value;

        private readonly DateTimeUnit m_dateTimeUnit;

        private int m_precision;

        #endregion

        #region Constructors

        public Interval(bool positive, decimal number, DateTimeUnit dateTimeUnit)
        {                   
            if (dateTimeUnit == null)
            {
                throw new ArgumentNullException("dateTimeUnit");
            }

            m_positive = positive;
            m_value = new IntegerValue(number);
            m_dateTimeUnit = dateTimeUnit;
            m_precision = ImplicitPrecision;
        }

        public Interval(INode val, DateTimeUnit dateTimeUnit):
            this(true, val, dateTimeUnit)
        {
        }

        private Interval(bool positive, INode val, DateTimeUnit dateTimeUnit)
        {
            if (val == null)
            {
                throw new ArgumentNullException("val");
            }

            if (dateTimeUnit == null)
            {
                throw new ArgumentNullException("dateTimeUnit");
            }

            m_positive = positive;
            m_value = val;
            m_dateTimeUnit = dateTimeUnit;
            m_precision = ImplicitPrecision;
        }

        #endregion

        #region Properties

        public static int ImplicitPrecision
        {
            get
            {
                // SQL 92
                return 2;
            }
        }

        /// <summary>
        /// Sign before the value string.
        /// </summary>
        /// <remarks>
        /// SQL 92 says the value must be unsigned, but Oracle accepts negative
        /// numbers (and doesn't accept sign before the value string), so
        /// the object model has the '-' sign in 2 separate places.
        /// </remarks>
        public bool Positive
        {
            get { return m_positive; }
            set { m_positive = value; }
        }

        /// <summary>
        /// <c>true</c> if this instance represents an interval literal,
        /// <c>false</c> otherwise.
        /// </summary>
        /// <remarks>
        /// Instances of this class can represent non-constant intervals,
        /// but such intervals don't have a SQL representation - that is,
        /// they cannot be stringified.
        /// </remarks>
        public bool IsLiteral
        {
            get
            {
                IntegerValue integerValue = m_value as IntegerValue;
                return integerValue != null;
            }
        }

        public INode Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_value = value;
            }
        }

        public DateTimeUnit DateTimeUnit
        {
            get { return m_dateTimeUnit; }
        }

        public int Precision
        {
            get
            {
                return m_precision;
            }

            set
            {
                if (value < ImplicitPrecision)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "Interval precision must be at least Interval.ImplicitPrecision.");
                }

                m_precision = value;
            }
        }

        #endregion

        #region Other accessors

        /// <summary>
        /// The value of this interval.
        /// </summary>
        public INode GetSignedValue()
        {
            if (m_positive)
            {
                return m_value.Clone();
            }
            else
            {
                IntegerValue integerValue = m_value as IntegerValue;
                if (integerValue != null)
                {
                    return new IntegerValue(-1 * integerValue.Value);
                }
                else
                {
                    return new Expression(
                        new IntegerValue(-1),
                        ExpressionOperator.Mult,
                        m_value.Clone());
                }
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new Interval(m_positive, m_value,
                (DateTimeUnit)(m_dateTimeUnit.Clone()));
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_value.Traverse(visitor);
            visitor.PerformOnUnit(this);
            m_dateTimeUnit.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion

        #region Input parsing

        /// <summary>
        /// Parsing interval value.
        /// </summary>
        /// <param name="n">
        /// The value, which must be a whole number.
        /// </param>
        /// <returns>
        /// Parsed value.
        /// </returns>
        public static int Parse(string n)
        {
            if (n == null)
            {
                throw new ArgumentNullException("n");
            }

            return int.Parse(n);
        }

        #endregion
    }
}
