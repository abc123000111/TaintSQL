using System;

namespace MacroScope
{
    /// <summary>
    /// SQL operators - both unary and binary.
    /// </summary>
    public sealed class ExpressionOperator : INode
    {
        #region Fields

        private readonly string m_value;

        #endregion

        #region Well-known operators

        private static readonly ExpressionOperator m_plus = new ExpressionOperator("+");

        private static readonly ExpressionOperator m_minus = new ExpressionOperator("-");

        private static readonly ExpressionOperator m_mult = new ExpressionOperator("*");

        private static readonly ExpressionOperator m_div = new ExpressionOperator("/");

        private static readonly ExpressionOperator m_mod = new ExpressionOperator("%");

        private static readonly ExpressionOperator m_mAccessMod = new ExpressionOperator("MOD");

        private static readonly ExpressionOperator m_equal = new ExpressionOperator("=");

        private static readonly ExpressionOperator m_notEqual = new ExpressionOperator("<>");

        private static readonly ExpressionOperator m_lessOrEqual = new ExpressionOperator("<=");

        private static readonly ExpressionOperator m_less = new ExpressionOperator("<");

        private static readonly ExpressionOperator m_greaterOrEqual = new ExpressionOperator(">=");

        private static readonly ExpressionOperator m_greater = new ExpressionOperator(">");

        private static readonly ExpressionOperator m_or = new ExpressionOperator("OR");

        private static readonly ExpressionOperator m_and = new ExpressionOperator("AND");

        private static readonly ExpressionOperator m_not = new ExpressionOperator("NOT");

        private static readonly ExpressionOperator m_isNull = new ExpressionOperator("IS NULL");

        private static readonly ExpressionOperator m_isNotNull = new ExpressionOperator("IS NOT NULL");

        private static readonly ExpressionOperator m_like = new ExpressionOperator("LIKE");

        private static readonly ExpressionOperator m_notLike = new ExpressionOperator("NOT LIKE");

        private static readonly ExpressionOperator m_between = new ExpressionOperator("BETWEEN");

        private static readonly ExpressionOperator m_in = new ExpressionOperator("IN");

        private static readonly ExpressionOperator m_notIn = new ExpressionOperator("NOT IN");

        private static readonly ExpressionOperator m_exists = new ExpressionOperator("EXISTS");

        private static readonly ExpressionOperator m_strConcat = new ExpressionOperator("||");

        #endregion

        #region Constructor

        private ExpressionOperator(string v)
        {
            if (v == null)
            {
                throw new ArgumentNullException("v");
            }

            m_value = v;
        }

        #endregion

        #region Properties

        public static ExpressionOperator Plus
        {
            get { return ExpressionOperator.m_plus; }
        }

        public static ExpressionOperator Minus
        {
            get { return ExpressionOperator.m_minus; }
        }

        public static ExpressionOperator Mult
        {
            get { return ExpressionOperator.m_mult; }
        }

        public static ExpressionOperator Div
        {
            get { return ExpressionOperator.m_div; }
        }

        public static ExpressionOperator Mod
        {
            get { return ExpressionOperator.m_mod; }
        }

        public static ExpressionOperator MAccessMod
        {
            get { return ExpressionOperator.m_mAccessMod; }
        }

        public static ExpressionOperator Equal
        {
            get { return ExpressionOperator.m_equal; }
        }

        public static ExpressionOperator NotEqual
        {
            get { return ExpressionOperator.m_notEqual; }
        }

        public static ExpressionOperator LessOrEqual
        {
            get { return ExpressionOperator.m_lessOrEqual; }
        }

        public static ExpressionOperator Less
        {
            get { return ExpressionOperator.m_less; }
        }

        public static ExpressionOperator GreaterOrEqual
        {
            get { return ExpressionOperator.m_greaterOrEqual; }
        }

        public static ExpressionOperator Greater
        {
            get { return ExpressionOperator.m_greater; }
        }

        public static ExpressionOperator Or
        {
            get { return ExpressionOperator.m_or; }
        }

        public static ExpressionOperator And
        {
            get { return ExpressionOperator.m_and; }
        }

        public static ExpressionOperator Not
        {
            get { return ExpressionOperator.m_not; }
        }

        public static ExpressionOperator IsNull
        {
            get { return ExpressionOperator.m_isNull; }
        }

        public static ExpressionOperator IsNotNull
        {
            get { return ExpressionOperator.m_isNotNull; }
        }

        public static ExpressionOperator Like
        {
            get { return ExpressionOperator.m_like; }
        }

        public static ExpressionOperator NotLike
        {
            get { return ExpressionOperator.m_notLike; }
        }

        public static ExpressionOperator Between
        {
            get { return ExpressionOperator.m_between; }
        }

        public static ExpressionOperator In
        {
            get { return ExpressionOperator.m_in; }
        }

        public static ExpressionOperator NotIn
        {
            get { return ExpressionOperator.m_notIn; }
        }

        public static ExpressionOperator Exists
        {
            get { return ExpressionOperator.m_exists; }
        }

        public static ExpressionOperator StrConcat
        {
            get { return ExpressionOperator.m_strConcat; }
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
