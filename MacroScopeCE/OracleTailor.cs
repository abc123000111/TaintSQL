using System;

namespace MacroScope
{
    /// <summary>
    /// SQL for Oracle.
    /// </summary>
    /// <remarks>
    /// Transforms SQL SUBSTRING to Oracle SUBSTR function, which is
    /// more permissive of out-of-bounds parameters than standard
    /// SUBSTRING. When using this tailor, some queries which should
    /// either have failed, or returned an empty string, may instead
    /// return null.
    /// </remarks>
    public class OracleTailor : PassiveVisitor
    {
        #region Fields

        private Namer m_namer;

        #endregion

        #region Properties

        public Namer Namer
        {
            get
            {
                if (m_namer == null)
                {
                    m_namer = new Namer(':');
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

        public override void PerformBefore(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            Namer.PerformBefore(node);
            ReplaceOperator(node);
            ReplaceDate(node);
            ReplaceCurrentDate(node);
        }

        public override void Perform(ExpressionOperator node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if ((node == ExpressionOperator.Mod) ||
                (node == ExpressionOperator.MAccessMod))
            {
                throw new InvalidOperationException("Modulo operator not in expression.");
            }
        }

        public override void PerformBefore(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            string name = node.Name.ToLower();
            if (name.Equals(TailorUtil.GETDATE))
            {
                throw new InvalidOperationException("GETDATE() not in expression.");
            }
            else if (name.Equals(TailorUtil.LEFT))
            {
                ReplaceLeft(node);
            }
            else if (name.Equals(TailorUtil.NOW))
            {
                throw new InvalidOperationException("Now() not in expression.");
            }
            else if (name.Equals(TailorUtil.RIGHT))
            {
                ReplaceRight(node);
            }
            else if (name.Equals(TailorUtil.SUBSTRING))
            {
                node.Name = TailorUtil.SUBSTR.ToUpper();
            }
        }

        public override void Perform(Identifier node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            // Oracle 10g doesn't support table names in quotes, but then,
            // it also doesn't support table names which _need_ quoting,
            // so if this call doesn't remove the quotes from a table name,
            // it's probably because the input was wrong in the first
            // place... Other items (e.g. aliases) can be quoted with \",
            // although quotes inside them fail with
            // ORA-03001: unimplemented feature...
            //node.NormalizeQuotes('"');
        }

        public override void PerformBefore(Interval node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            IntegerValue integerValue = node.Value as IntegerValue;
            if (integerValue == null)
            {
                throw new InvalidOperationException(
                    "Non-constant interval cannot be stringified.");
            }

            if (!node.Positive)
            {
                node.Value = node.GetSignedValue();
                node.Positive = true;
            }

            decimal v = integerValue.Value;
            if (v < 0)
            {
                v = -1 * v;
            }

            string s = Convert.ToString(v);
            int requiredPrecision = s.Length;
            if (requiredPrecision < Interval.ImplicitPrecision)
            {
                requiredPrecision = Interval.ImplicitPrecision;
            }

            if (node.Precision < requiredPrecision)
            {
                node.Precision = requiredPrecision;
            }
        }

        public override void Perform(LiteralDateTime node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            throw new InvalidOperationException(
                "Oracle does not have datetime literals.");
        }

        public override void PerformBefore(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Top != null)
            {
                ReplaceTop(node);
            }

            if (node.From == null)
            {
                node.From = new AliasedItem(
                    new DbObject(new Identifier(TailorUtil.DUAL)));
            }
        }

        public override void PerformBefore(SwitchFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformBefore(node);

            throw new InvalidOperationException(
                "Switch not in expression.");
        }

        public override void Perform(Variable node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            node.Prefix = ':';
        }

        #endregion

        #region Transformations

        static void ReplaceLeft(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ExpressionItem head = node.ExpressionArguments;
            if (head == null)
            {
                throw new InvalidOperationException("LEFT has no arguments.");
            }

            ExpressionItem next = head.Next;
            if (next == null)
            {
                throw new InvalidOperationException("LEFT has only one argument.");
            }

            node.Name = TailorUtil.SUBSTR.ToUpper();

            ExpressionItem tail = new ExpressionItem(
                new IntegerValue(1));
            tail.Next = next;

            head.Next = tail;
        }

        static void ReplaceRight(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ExpressionItem head = node.ExpressionArguments;
            if (head == null)
            {
                throw new InvalidOperationException("RIGHT has no arguments.");
            }

            ExpressionItem next = head.Next;
            if (next == null)
            {
                throw new InvalidOperationException("RIGHT has only one argument.");
            }

            if (next.HasNext)
            {
                throw new InvalidOperationException("RIGHT has too many arguments.");
            }

            node.Name = TailorUtil.SUBSTR.ToUpper();
            head.Next = new ExpressionItem(
                    new Expression(new IntegerValue(-1), ExpressionOperator.Mult,
                        next));
        }

        void ReplaceOperator(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if ((node.Operator == ExpressionOperator.Mod) ||
                (node.Operator == ExpressionOperator.MAccessMod))
            {
                if ((node.Left == null) || (node.Right == null))
                {
                    throw new InvalidOperationException(
                        "Modulo operator must have 2 arguments.");
                }

                FunctionCall functionCall = new FunctionCall(
                    TailorUtil.MOD.ToUpper());
                functionCall.ExpressionArguments = new ExpressionItem(node.Left);
                functionCall.ExpressionArguments.Add(new ExpressionItem(node.Right));

                node.Operator = null;
                node.Left = functionCall;
                node.Right = null;
            }
        }

        static void ReplaceDate(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            LiteralDateTime left = node.Left as LiteralDateTime;
            if (left != null)
            {
                node.Left = MakeToDate(left);
            }

            LiteralDateTime right = node.Right as LiteralDateTime;
            if (right != null)
            {
                node.Right = MakeToDate(right);
            }
        }

        static void ReplaceCurrentDate(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            FunctionCall left = TailorUtil.CondGetFunctionCall(node.Left);
            if (IsCurrentDate(left))
            {
                node.Left = new DbObject(new Identifier(
                    TailorUtil.SYSDATE.ToUpper()));
            }

            FunctionCall right = TailorUtil.CondGetFunctionCall(node.Right);
            if (IsCurrentDate(right))
            {
                node.Right = new DbObject(new Identifier(
                    TailorUtil.SYSDATE.ToUpper()));
            }
        }

        static bool IsCurrentDate(FunctionCall functionCall)
        {
            if (functionCall == null)
            {
                return false;
            }

            string name = functionCall.Name;
            name = name.ToLower();
            return name.Equals(TailorUtil.GETDATE) || name.Equals(TailorUtil.NOW);
        }

        static void ReplaceTop(QueryExpression node)
        {
            // not actually how the parser would build "ROWNUM <= 7",
            // but simpler
            Expression filter = new Expression(
                new Identifier(TailorUtil.ROWNUM),
                ExpressionOperator.LessOrEqual,
                new IntegerValue((int)(node.Top)));

            if (node.Where == null)
            {
                node.Where = filter;
            }
            else
            {
                node.Where = new Expression(filter,
                    ExpressionOperator.And,
                    node.Where);
            }

            node.Top = null;
        }

        static FunctionCall MakeToDate(LiteralDateTime literalDateTime)
        {
            if (literalDateTime == null)
            {
                throw new ArgumentNullException("literalDateTime");
            }

            DateTime dateTime = literalDateTime.DateTime;
            string literal = dateTime.ToString("dd.MM.yyyy HH:mm:ss");

            FunctionCall functionCall = new FunctionCall(
                TailorUtil.TO_TIMESTAMP.ToUpper());
            functionCall.ExpressionArguments = TailorUtil.MakeLiteralString(literal);
            functionCall.ExpressionArguments.Add(
                TailorUtil.MakeLiteralString("dd.mm.yyyy HH24:mi:ss"));

            return functionCall;
        }

        #endregion
    }
}
