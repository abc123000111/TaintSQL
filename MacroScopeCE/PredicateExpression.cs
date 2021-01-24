using System;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Comparison with a quantifier, i.e.
    /// <c>max(price) &gt; SOME (SELECT price FROM sales)</c>.
    /// </summary>
    public sealed class PredicateExpression : IExpression
    {
        #region Fields

        private readonly IExpression m_left;

        private readonly BracketedExpression m_right;

        private readonly ExpressionOperator m_operator;

        private readonly PredicateQuantifier m_quantifier;

        #endregion

        #region Constructor

        public PredicateExpression(IExpression left, ExpressionOperator op,
            PredicateQuantifier quantifier, BracketedExpression subQuery)
        {
            if (left == null)
            {
                throw new ArgumentNullException("left");
            }

            if (op == null)
            {
                throw new ArgumentNullException("op");
            }

            if (quantifier == null)
            {
                throw new ArgumentNullException("quantifier");
            }

            if (subQuery == null)
            {
                throw new ArgumentNullException("subQuery");
            }

            m_left = left;
            m_right = subQuery;
            m_operator = op;
            m_quantifier = quantifier;
        }

        #endregion

        #region Properties

        public IExpression Left
        {
            get
            {
                return m_left;
            }
        }

        public bool IsComposed
        {
            get
            {
                return true;
            }
        }

        public ExpressionOperator Operator
        {
            get
            {
                return m_operator;
            }
        }

        public PredicateQuantifier Quantifier
        {
            get { return m_quantifier; }
        }

        public BracketedExpression SubQuery
        {
            get { return m_right; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new PredicateExpression(
                (IExpression)(m_left.Clone()),
                (ExpressionOperator)(m_operator.Clone()),
                (PredicateQuantifier)(m_quantifier.Clone()),
                (BracketedExpression)(m_right.Clone()));
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_left.Traverse(visitor);
            visitor.PerformOnOperator(this);
            m_operator.Traverse(visitor);
            visitor.PerformOnQuantifier(this);
            m_quantifier.Traverse(visitor);
            visitor.PerformOnSelect(this);
            m_right.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion
    }
}
