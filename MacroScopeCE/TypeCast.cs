using System;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// SQL type cast, i.e. <c>CAST(expression AS type)</c>.
    /// </summary>
    public sealed class TypeCast : IExpression
    {
        #region Fields

        private readonly IExpression m_expression;

        private readonly string m_type;

        private int? m_precision;

        private int? m_secondPrecision;

        #endregion

        #region Constructor

        public TypeCast(IExpression expression, string type)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            m_expression = expression;
            m_type = type;
        }

        #endregion

        #region Properties

        public IExpression Expression
        {
            get { return m_expression; }
        }

        public string Type
        {
            get { return m_type; }
        }

        public int? Precision
        {
            get { return m_precision; }
            set { m_precision = value; }
        }

        public int? SecondPrecision
        {
            get { return m_secondPrecision; }
            set { m_secondPrecision = value; }
        }

        public bool IsComposed
        {
            get { return false; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            TypeCast typeCast = new TypeCast((IExpression)(m_expression.Clone()),
                m_type);
            typeCast.Precision = m_precision;
            typeCast.SecondPrecision = m_secondPrecision;
            return typeCast;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_expression.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion
    }
}
