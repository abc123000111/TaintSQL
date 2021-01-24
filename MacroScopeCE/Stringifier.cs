using System;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Converts the tree representation of a SQL command into
    /// executable command strings.
    /// </summary>
    public class Stringifier : PassiveVisitor
    {
        #region Constants

        /// <summary>
        /// Line separator, occasionally inserted instead of a space.
        /// </summary>
        /// <remarks>
        /// This class doesn't use <see cref="Environment.NewLine"/>
        /// so that its output is consistent across different environments
        /// (although in practice it isn't used on any alternative platforms
        /// and probably never will be).
        /// </remarks>
        private static readonly string NewLine = "\r\n";

        #endregion

        #region Fields

        private readonly StringBuilder m_sql;

        private bool m_outputIso8601;

        private bool m_ignoreNextOperator;

        private bool m_separatePreviousQueryExpression;

        private bool m_inMSAccessSwitch;

        #endregion

        #region Constructor

        public Stringifier()
        {
            m_sql = new StringBuilder();
            m_outputIso8601 = false;
            m_ignoreNextOperator = false;
        }

        #endregion

        #region Accessors

        /// <summary>
        /// Set to output datetime literals in
        /// ISO 8601 format, i.e. <c>yyyy-MM-ddTHH:mm:ss</c>.
        /// </summary>
        /// <remarks>
        /// Default is <c>false</c>, meaning datetime literals
        /// are formatted for MS Access.
        /// </remarks>
        public bool OutputIso8601
        {
            get { return m_outputIso8601; }
            set { m_outputIso8601 = value; }
        }

        public string ToSql()
        {
            return m_sql.ToString();
        }

        #endregion

        #region IVisitor Members

        public override void PerformOnAlias(AliasedItem node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Alias != null)
            {
                m_sql.Append(" AS ");
            }
        }

        public override void PerformAfter(AliasedItem node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.HasNext)
            {
                m_sql.Append(", ");
            }
        }

        public override void PerformOnAssignment(Assignment node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(" = ");
        }

        public override void PerformAfter(Assignment node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.HasNext)
            {
                m_sql.Append(", ");
            }
        }

        public override void PerformBefore(BracketedExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append('(');

            if (node.Spaced)
            {
                m_sql.Append(' ');
            }
        }

        public override void PerformAfter(BracketedExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Spaced)
            {
                m_sql.Append(' ');
            }

            m_sql.Append(')');
        }

        public override void PerformBefore(CaseAlternative node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (!m_inMSAccessSwitch)
            {
                m_sql.Append("WHEN ");
            }
        }

        public override void PerformOnThen(CaseAlternative node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (!m_inMSAccessSwitch)
            {
                m_sql.Append(" THEN ");
            }
            else
            {
                m_sql.Append(", ");
            }
        }

        public override void PerformAfter(CaseAlternative node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (!m_inMSAccessSwitch)
            {
                m_sql.Append(NewLine);
            }
            else
            {
                if (node.HasNext)
                {
                    m_sql.Append(", ");
                }
            }
        }

        public override void PerformBefore(CaseExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("CASE");
            if (node.Case != null)
            {
                m_sql.Append(' ');
            }
        }

        public override void PerformOnWhen(CaseExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(NewLine);
        }

        public override void PerformOnElse(CaseExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Else != null)
            {
                m_sql.Append("ELSE ");
            }
        }

        public override void PerformAfter(CaseExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Else != null)
            {
                m_sql.Append(NewLine);
            }

            m_sql.Append("END");
        }

        public override void Perform(DateTimeUnit node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(node.Value);
        }
        
        public override void PerformAfter(DbObject node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.HasNext)
            {
                m_sql.Append('.');
            }
        }

        public override void Perform(DefaultValue node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("DEFAULT");
        }

        public override void PerformBefore(DeleteStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            // FROM optional for SQL, required by MS Access
            m_sql.Append("DELETE FROM ");
        }

        public override void PerformOnWhere(DeleteStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Where != null)
            {
                m_sql.Append(NewLine);
                m_sql.Append("WHERE ");
            }
        }

        public override void Perform(DoubleValue node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            string v = node.Value.ToString(DoubleValue.Format);
            m_sql.Append(v);
        }

        public override void PerformBefore(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            INode left = node.Left;
            if ((left != null) && (node.Operator != null))
            {   // either PerformBeforePostfixOp,
                // or PerformBeforeBinaryOp will be called
                if (BracketExpression(left))
                {
                    m_sql.Append('(');
                }
            }
        }

        public override void PerformBeforePrefixOp(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Operator == ExpressionOperator.Plus)
            {
                m_ignoreNextOperator = true;
            }
        }

        public override void PerformAfterPrefixOp(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ExpressionOperator op = node.Operator;
            if (op == null)
            {
                throw new InvalidOperationException("No prefix operator.");
            }

            if ((op == ExpressionOperator.Not) ||
                (op == ExpressionOperator.Exists))
            {
                m_sql.Append(' ');
            }
            else if ((op != ExpressionOperator.Plus) &&
                (op != ExpressionOperator.Minus))
            {
                string message = string.Format("Invalid prefix operator {0}.",
                    op.Value);
                throw new InvalidOperationException(message);
            }

            if ((op == ExpressionOperator.Exists) ||
                BracketExpression(node.Right))
            {
                m_sql.Append('(');
            }
        }

        public override void PerformBeforePostfixOp(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (BracketExpression(node.Left))
            {
                m_sql.Append(')');
            }

            m_sql.Append(' ');
        }

        public override void PerformAfterPostfixOp(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ExpressionOperator op = node.Operator;
            if (op == null)
            {
                throw new InvalidOperationException("No postfix operator.");
            }

            if ((op != ExpressionOperator.IsNull) &&
                (op != ExpressionOperator.IsNotNull))
            {
                string message = string.Format("Invalid postfix operator {0}.",
                    op.Value);
                throw new InvalidOperationException(message);
            }
        }

        public override void PerformBeforeBinaryOp(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (BracketExpression(node.Left))
            {
                m_sql.Append(')');
            }

            m_sql.Append(' '); // before operator
        }

        public override void PerformAfterBinaryOp(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(' '); // after operator

            ExpressionOperator op = node.Operator;
            if ((op == ExpressionOperator.In) ||
                (op == ExpressionOperator.NotIn) ||
                BracketExpression(node.Right))
            {
                m_sql.Append('(');
            }
        }

        public override void PerformAfter(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ExpressionOperator op = node.Operator;
            INode right = node.Right;
            if ((op != null) && (right != null))
            {   // either PerformAfterPrefixOp, or
                // PerformAfterBinaryOp has been called
                if ((op == ExpressionOperator.Exists) ||
                    (op == ExpressionOperator.In) ||
                    (op == ExpressionOperator.NotIn) ||
                    BracketExpression(right))
                {
                    m_sql.Append(')');
                }
            }
        }

        static bool BracketExpression(INode subExpression)
        {
            if (subExpression == null)
            {
                throw new ArgumentNullException("subExpression");
            }

            IExpression expression = subExpression as IExpression;
            return (expression != null) && expression.IsComposed;
        }

        public override void PerformAfter(ExpressionItem node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.HasNext)
            {
                m_sql.Append(", ");
            }
        }

        public override void Perform(ExpressionOperator node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (m_ignoreNextOperator)
            {
                Debug.Assert(node == ExpressionOperator.Plus);
                m_ignoreNextOperator = false;
            }
            else
            {
                m_sql.Append(node.Value);
            }
        }

        public override void PerformBefore(ExtractFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("EXTRACT(");
        }

        public override void PerformOnSource(ExtractFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(" FROM ");
        }

        public override void PerformAfter(ExtractFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(')');
        }

        public override void PerformBefore(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            string name = node.Name;
            Debug.Assert(name != null);

            m_sql.Append(name);

            m_sql.Append('(');

            if (node.Distinct)
            {
                m_sql.Append("DISTINCT ");
            }
        }

        public override void PerformAfter(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(')');
        }

        public override void PerformBefore(GroupByClause node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("GROUP BY ");

            if (node.All)
            {
                m_sql.Append("ALL ");
            }
        }

        public override void PerformOnHaving(GroupByClause node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Having != null)
            {
                m_sql.Append(NewLine);
                m_sql.Append("HAVING ");
            }
        }

        public override void Perform(Identifier node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(node.ID);
        }

        public override void PerformBefore(InsertStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            // INTO required by MS Access
            m_sql.Append("INSERT INTO ");
        }

        public override void PerformOnNames(InsertStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append('(');
        }

        public override void PerformOnValues(InsertStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(") VALUES(");
        }

        public override void PerformAfter(InsertStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(')');
        }

        public override void Perform(IntegerValue node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(node.Value);
        }

        public override void PerformBefore(Interval node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("INTERVAL ");
            if (!node.Positive)
            {
                m_sql.Append('-');
            }

            if (!node.IsLiteral)
            {
                throw new InvalidOperationException(
                    "Computed interval cannot be stringified.");
            }

            m_sql.Append('\'');
        }

        public override void PerformOnUnit(Interval node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("' ");
        }

        public override void PerformAfter(Interval node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Precision != Interval.ImplicitPrecision)
            {
                m_sql.AppendFormat("({0})", node.Precision);
            }
        }

        public override void Perform(Join node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.AppendFormat("{0} JOIN", node.Type);
        }

        public override void Perform(LiteralDateTime node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            string literal = m_outputIso8601 ? node.Iso8601Literal : node.MAccessLiteral;
            m_sql.Append(literal);
        }

        public override void Perform(NullValue node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("NULL");
        }

        public override void PerformAfter(OrderExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (!node.Asc)
            {
                m_sql.Append(" DESC");
            }

            if (node.HasNext)
            {
                m_sql.Append(", ");
            }
        }

        public override void PerformBefore(PatternExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Expression.IsComposed)
            {
                m_sql.Append('(');
            }
        }

        public override void PerformOnEscape(PatternExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Expression.IsComposed)
            {
                m_sql.Append(')');
            }

            if (node.Escape != null)
            {
                m_sql.Append(" ESCAPE ");
            }
        }

        public override void Perform(Placeholder node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append('?');
        }

        public override void PerformBefore(PredicateExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Left.IsComposed)
            {
                m_sql.Append('(');
            }
        }

        public override void PerformOnOperator(PredicateExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Left.IsComposed)
            {
                m_sql.Append(')');
            }

            m_sql.Append(' ');
        }

        public override void PerformOnQuantifier(PredicateExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            // after operator
            m_sql.Append(' ');
        }

        public override void PerformOnSelect(PredicateExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            // after quantifier
            m_sql.Append(' ');
        }

        public override void Perform(PredicateQuantifier node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(node.Value);
        }

        public override void PerformBefore(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.All)
            {
                m_sql.Append(" ALL");
            }

            if (m_separatePreviousQueryExpression)
            {
                m_sql.Append(NewLine);
                m_separatePreviousQueryExpression = false;
            }

            m_sql.Append("SELECT");

            if (node.Top != null)
            {
                m_sql.AppendFormat(" TOP {0}", (int)(node.Top));
            }

            if (node.Distinct)
            {
                m_sql.Append(" DISTINCT");
            }

            m_sql.Append(' ');
        }

        public override void PerformOnFrom(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.From != null)
            {
                m_sql.Append(NewLine);
                m_sql.Append("FROM ");
            }
        }

        public override void PerformOnWhere(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Where != null)
            {
                m_sql.Append(NewLine);
                m_sql.Append("WHERE ");
            }
        }

        public override void PerformOnGroupBy(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.GroupBy != null)
            {
                m_sql.Append(NewLine);
            }
        }

        public override void PerformOnOrderBy(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.OrderBy != null)
            {
                m_sql.Append(NewLine);
                m_sql.Append("ORDER BY ");
            }
        }

        public override void PerformAfter(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.HasNext)
            {
                m_sql.Append(NewLine);
                m_sql.Append("UNION");
                m_separatePreviousQueryExpression = true;
            }
        }

        public override void PerformBefore(Range node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.From.IsComposed)
            {
                m_sql.Append('(');
            }
        }

        public override void PerformOnAnd(Range node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.From.IsComposed)
            {
                m_sql.Append(')');
            }

            m_sql.Append(" AND ");

            if (node.To.IsComposed)
            {
                m_sql.Append('(');
            }
        }

        public override void PerformAfter(Range node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.To.IsComposed)
            {
                m_sql.Append(')');
            }
        }

        public override void Perform(StringValue node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(node.QuotedValue);
        }

        public override void PerformBefore(SwitchFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("Switch(");
            m_inMSAccessSwitch = true;
        }

        public override void PerformAfter(SwitchFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_inMSAccessSwitch = false;
            m_sql.Append(')');
        }

        public override void PerformBefore(Table node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.JoinCondition != null)
            {
                if (node.JoinType == null)
                {
                    Perform(Join.Inner);
                }
            }
        }

        public override void PerformOnSource(Table node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if ((node.JoinCondition != null) ||
                (node.JoinType != null)) // CROSS JOIN
            {
                m_sql.Append(' ');
            }
        }

        public override void PerformOnAlias(Table node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Alias != null)
            {
                // Oracle 10g Express Edition doesn't like AS
                m_sql.AppendFormat(" ");
            }
        }

        public override void PerformBeforeCondition(Table node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.JoinCondition != null)
            {
                m_sql.Append(" ON ");
            }
        }

        public override void PerformAfterCondition(Table node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.HasNext)
            {
                m_sql.Append(' ');
            }
        }

        public override void PerformAfter(TableWildcard node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(".*");
        }

        public override void PerformBefore(TypeCast node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("CAST(");
        }

        public override void PerformAfter(TypeCast node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(" AS ");
            m_sql.Append(node.Type);

            if (node.Precision != null)
            {
                m_sql.Append('(');
                m_sql.Append((int)(node.Precision));

                if (node.SecondPrecision != null)
                {
                    m_sql.Append(", ");
                    m_sql.Append((int)(node.SecondPrecision));
                }

                m_sql.Append(')');
            }

            m_sql.Append(')');
        }

        public override void PerformBefore(UpdateStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append("UPDATE ");
        }

        public override void PerformOnAssignments(UpdateStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(" SET "); // after table
        }

        public override void PerformOnWhere(UpdateStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.Where != null)
            {
                m_sql.Append(NewLine);
                m_sql.Append("WHERE ");
            }
        }

        public override void Perform(Variable node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append(node.PrefixedName);
        }

        public override void Perform(Wildcard node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_sql.Append('*');
        }

        #endregion
    }
}
