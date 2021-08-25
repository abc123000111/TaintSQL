using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MacroScope
{
    /// <summary>
    /// Common transformations for <see cref="MSqlServerTailor"/>
    /// and <see cref="MAccessTailor"/>.
    /// </summary>
    public abstract class MTailor : PassiveVisitor
    {
        #region Fields

        private readonly Dictionary<IExpression, QueryExpression> m_backref;

        private IExpression m_currentWhere;

        private Namer m_namer;

        private readonly ExpressionOperator m_modOp;

        private readonly List<Expression> m_expressionStack;

        #endregion

        #region Constructor

        public MTailor(ExpressionOperator modOp)
        {
            if (modOp == null)
            {
                throw new ArgumentNullException("modOp");
            }

            m_backref = new Dictionary<IExpression, QueryExpression>();
            m_currentWhere = null;
            m_modOp = modOp;
            m_expressionStack = new List<Expression>();
        }

        #endregion

        #region Properties

        public Namer Namer
        {
            get
            {
                if (m_namer == null)
                {
                    m_namer = new Namer('@');
                }

                return m_namer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_namer = value;
            }
        }

        #endregion

        #region IVisitor Members

        public override void PerformAfter(ExpressionItem node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            // this isn't called in all the places where it should be,
            // but apart from being inefficient, extra nodes in
            // the stack probably shouldn't cause any trouble...
            m_expressionStack.Clear();
        }

        public override void Perform(Identifier node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (IsRownum(node))
            {
                throw new InvalidOperationException(
                    "MS engines do not have ROWNUM.");
            }

            if (TailorUtil.IsSysdate(node))
            {
                throw new InvalidOperationException(
                    "MS engines do not have SYSDATE.");
            }
        }

        public override void PerformBefore(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ReplaceSubstring(node);
            ReplaceExtract(node);

            if ((m_currentWhere != null) &&
                (node.Operator == ExpressionOperator.And))
            {
                int limit = GetRownumExpressionLimit(node.Left);
                if (limit > 0)
                {
                    node.Operator = null;
                    node.Left = null;
                    LimitTop(limit);
                }
                else
                {
                    limit = GetRownumExpressionLimit(node.Right);
                    if (limit > 0)
                    {
                        node.Operator = null;
                        node.Right = null;
                        LimitTop(limit);
                    }
                }
            }

            Expression leftMod = GetModCall(node.Left);
            if (leftMod != null)
            {
                node.Left = leftMod;
            }

            Expression rightMod = GetModCall(node.Right);
            if (rightMod != null)
            {
                node.Right = rightMod;
            }

            Namer.PerformBefore(node);            
        }

        public override void PerformBefore(ExtractFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            throw new InvalidOperationException("EXTRACT not in expression.");
        }

        public override void PerformBefore(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            IExpression where = node.Where;
            if (where != null)
            {
                if (m_backref.ContainsKey(where))
                {
                    throw new InvalidOperationException("Tailor can't be re-used.");
                }

                int limit = GetRownumExpressionLimit(where);
                if (limit > 0)
                {
                    SetTop(node, limit);
                    node.Where = null;
                }
                else
                {
                    m_backref.Add(where, node);
                }
            }
            else
            {
                AliasedItem from = node.From;
                if ((from != null) && (from.Alias == null) && !from.HasNext)
                {
                    Table singleTable = from.Item as Table;
                    if ((singleTable != null) && (singleTable.Alias == null) &&
                        (singleTable.JoinCondition == null) &&
                        (singleTable.JoinType == null) && !singleTable.HasNext)
                    {                        
                        DbObject singleName = TailorUtil.GetTerm(
                            singleTable.Source) as DbObject;
                        if ((singleName != null) && !singleName.HasNext)
                        {
                            Identifier identifier = singleName.Identifier;

                            // Not canonicalizing - we're accepting quoted "dual"
                            // as a regular identifier.
                            if (TailorUtil.DUAL.Equals(
                                identifier.ID.ToLower()))
                            {
                                node.From = null;
                            }
                        }
                    }
                }
            }

            m_currentWhere = null;  // even if node does have WHERE,
                                    // the traversal isn't in it yet
        }

        public override void PerformBeforeBinaryOp(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_expressionStack.Add(node);
            ReplaceIntervals(m_expressionStack.Count - 1);
        }

        public override void PerformOnWhere(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_currentWhere = node.Where;

            // this isn't called in all the places where it should be,
            // but apart from being inefficient, extra nodes in
            // the stack probably shouldn't cause any trouble...
            m_expressionStack.Clear();
        }

        public override void PerformOnGroupBy(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_currentWhere = null;  // if there are constructions like
                                    // ORDER BY rownum, we're going to fail on them
        }

        public override void Perform(Variable node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            node.Prefix = '@';
        }

        #endregion

        #region Transformations

        protected abstract FunctionCall GetDateaddCall(DateTimeUnit unit,
            INode number, INode date);

        protected abstract INode CompleteSubstring(FunctionCall substringCall);

        protected abstract FunctionCall ReplaceExtractFunction(
            ExtractFunction extractFunction);

        void LimitTop(int limit)
        {
            if (limit <= 0)
            {
                throw new ArgumentOutOfRangeException("limit");
            }

            Debug.Assert(m_currentWhere != null);

            if (!m_backref.ContainsKey(m_currentWhere))
            {
                throw new InvalidOperationException("WHERE without SELECT.");
            }

            QueryExpression query = m_backref[m_currentWhere];
            Debug.Assert(query != null);

            SetTop(query, limit);
        }

        static void SetTop(QueryExpression query, int limit)
        {
            if (query.Top == null)
            {
                query.Top = limit;
            }
            else
            {
                query.Top = Math.Min((int)(query.Top), limit);
            }
        }

        void ReplaceSubstring(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            FunctionCall leftSubstring = TailorUtil.GetSubstringTerm(node.Left);
            if (leftSubstring != null)
            {
                node.Left = CompleteSubstring(leftSubstring);
            }

            FunctionCall rightSubstring = TailorUtil.GetSubstringTerm(node.Right);
            if (rightSubstring != null)
            {
                node.Right = CompleteSubstring(rightSubstring);
            }
        }

        void ReplaceExtract(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ExtractFunction leftExtract = TailorUtil.GetExtractTerm(node.Left);
            if (leftExtract != null)
            {
                node.Left = ReplaceExtractFunction(leftExtract);
            }

            ExtractFunction rightExtract = TailorUtil.GetExtractTerm(node.Right);
            if (rightExtract != null)
            {
                node.Right = ReplaceExtractFunction(rightExtract);
            }
        }

        void ReplaceIntervals(int last)
        {
            if (last < 0)
            {
                throw new ArgumentOutOfRangeException("last");
            }

            Expression node = m_expressionStack[last];

            Interval leftInterval = GetInterval(node.Left);
            Interval rightInterval = GetInterval(node.Right);

            if (leftInterval != null)
            {
                if (rightInterval != null)
                {
                    ReplaceBothIntervals(last, node, leftInterval, rightInterval);
                }
                else
                {
                    ReplaceLeftInterval(last, node, leftInterval);
                }
            }
            else if (rightInterval != null)
            {
                ReplaceRightInterval(last, node, rightInterval);
            }
        }

        void ReplaceBothIntervals(int last, Expression node, Interval leftInterval,
            Interval rightInterval)
        {
            if (leftInterval.DateTimeUnit != rightInterval.DateTimeUnit)
            {
                throw new InvalidOperationException(
                    "Can't combine intervals with different units.");
            }

            if ((node.Operator != ExpressionOperator.Plus) &&
                (node.Operator != ExpressionOperator.Minus))
            {
                throw new InvalidOperationException("Can't multiply intervals.");
            }

            node.Left = new Interval(
                new Expression(leftInterval.GetSignedValue(),
                    node.Operator,
                    rightInterval.GetSignedValue()),
                leftInterval.DateTimeUnit);
            node.Operator = null;
            node.Right = null;

            if (last > 0)
            {
                ReplaceIntervals(last - 1);
            }
        }

        void ReplaceLeftInterval(int last, Expression node, Interval leftInterval)
        {
            if (node.Operator == ExpressionOperator.Plus)
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = GetDateaddCall(leftInterval.DateTimeUnit,
                    leftInterval.GetSignedValue(),
                    node.Right);
                node.Operator = null;
                node.Left = null;
            }
            else if ((node.Operator == ExpressionOperator.Mult) ||
                (node.Operator == ExpressionOperator.Div))
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = new Interval(
                    GetMultipliedInterval(leftInterval,
                        node.Right,
                        node.Operator),
                    leftInterval.DateTimeUnit);
                node.Operator = null;
                node.Left = null;

                if (last > 0)
                {
                    ReplaceIntervals(last - 1);
                }
            }
            else
            {
                throw new InvalidOperationException(
                    "Subtraction from interval not supported.");
            }
        }

        void ReplaceRightInterval(int last, Expression node, Interval rightInterval)
        {
            if (node.Operator == ExpressionOperator.Plus)
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = GetDateaddCall(rightInterval.DateTimeUnit,
                    rightInterval.GetSignedValue(),
                    node.Left);
                node.Operator = null;
                node.Left = null;
            }
            else if (node.Operator == ExpressionOperator.Minus)
            {
                Interval negativeInterval = (Interval)(rightInterval.Clone());
                negativeInterval.Positive = !negativeInterval.Positive;

                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = GetDateaddCall(negativeInterval.DateTimeUnit,
                    negativeInterval.GetSignedValue(),
                    node.Left);
                node.Operator = null;
                node.Left = null;
            }
            else if (node.Operator == ExpressionOperator.Mult)
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = new Interval(
                    GetMultipliedInterval(rightInterval,
                        node.Left,
                        ExpressionOperator.Mult),
                    rightInterval.DateTimeUnit);
                node.Operator = null;
                node.Left = null;

                if (last > 0)
                {
                    ReplaceIntervals(last - 1);
                }
            }
            else
            {
                throw new InvalidOperationException(
                    "Division by interval not supported.");
            }
        }

        static INode GetMultipliedInterval(Interval interval,
            INode multiplier, ExpressionOperator op)
        {
            if (interval == null)
            {
                throw new ArgumentNullException("interval");
            }

            if (multiplier == null)
            {
                throw new ArgumentNullException("multiplier");
            }

            if (op == null)
            {
                throw new ArgumentNullException("op");
            }

            INode inner = interval.GetSignedValue();
            IntegerValue integerValue = inner as IntegerValue;
            INode newValue;
            if ((integerValue != null) &&
                (integerValue.Value == 1))
            {
                newValue = multiplier;
            }
            else
            {
                newValue = new Expression(inner, op, multiplier);
            }

            return newValue;
        }

        Expression GetModCall(INode arg)
        {
            FunctionCall functionCall = arg as FunctionCall;
            if (functionCall == null)
            {
                return null;
            }

            if (!TailorUtil.MOD.Equals(functionCall.Name.ToLower()))
            {
                return null;
            }

            ExpressionItem head = functionCall.ExpressionArguments;
            if (head == null)
            {
                throw new InvalidOperationException("MOD has no arguments.");
            }

            ExpressionItem next = head.Next;
            if (next == null)
            {
                throw new InvalidOperationException("MOD has only one argument.");
            }

            if (next.Next != null)
            {
                throw new InvalidOperationException("MOD has too many arguments.");
            }

            return new Expression(head.Expression,
                m_modOp,
                next.Expression);
        }

        static Interval GetInterval(INode arg)
        {
            Expression expr = arg as Expression;
            while ((expr != null) && (expr.Operator == null))
            {
                arg = (expr.Left != null) ? expr.Left : expr.Right;
                expr = arg as Expression;
            }

            return arg as Interval;
        }

        static int GetRownumExpressionLimit(INode arg)
        {
            if (arg == null)
            {
                throw new InvalidOperationException("AND operator missing argument.");
            }

            Expression expr = arg as Expression;
            if (expr == null)
            {
                return -1;
            }

            decimal limit = -2;
            if (expr.Operator == ExpressionOperator.LessOrEqual)
            {
                if (IsRownumTerm(expr.Left))
                {
                    limit = GetTermLimit(expr.Right);
                }
            }
            else if (expr.Operator == ExpressionOperator.Less)
            {
                if (IsRownumTerm(expr.Left))
                {
                    limit = GetSharpTermLimit(expr.Right);
                }
            }
            else if (expr.Operator == ExpressionOperator.GreaterOrEqual)
            {
                if (IsRownumTerm(expr.Right))
                {
                    limit = GetTermLimit(expr.Left);
                }
            }
            else if (expr.Operator == ExpressionOperator.Greater)
            {
                if (IsRownumTerm(expr.Right))
                {
                    limit = GetSharpTermLimit(expr.Left);
                }
            }

            int ilimit = (int)limit;
            if (limit != ilimit)
            {
                string message = string.Format("TOP argument {0} too large.",
                    limit);
                throw new Exception(message);
            }

            return ilimit;
        }

        static decimal GetSharpTermLimit(INode arg)
        {
            decimal limit = GetTermLimit(arg);
            if (limit > 0)
            {
                --limit;
            }

            return limit;
        }

        static decimal GetTermLimit(INode arg)
        {
            arg = GetComparedTerm(arg);

            IntegerValue iv = arg as IntegerValue;
            if (iv == null)
            {
                return -1;
            }

            return iv.Value;
        }

        static bool IsRownumTerm(INode arg)
        {
            arg = GetComparedTerm(arg);

            DbObject dbObject = arg as DbObject;
            if ((dbObject == null) || dbObject.HasNext)
            {
                return false;
            }

            return IsRownum(dbObject.Identifier);
        }

        static INode GetComparedTerm(INode arg)
        {
            if (arg == null)
            {
                throw new InvalidOperationException(
                    "Comparison operator missing argument.");
            }

            return TailorUtil.GetTerm(arg);
        }

        /// <summary>
        /// Test for unquoted <see cref="TailorUtil.ROWNUM"/>.
        /// </summary>
        /// <remarks>
        /// Not canonicalizing - we're accepting quoted "rownum"
        /// as a regular identifier.
        /// </remarks>
        static bool IsRownum(Identifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            return TailorUtil.ROWNUM.Equals(
                identifier.ID.ToLower());
        }

        #endregion
    }
}
