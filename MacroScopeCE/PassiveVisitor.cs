using System;

namespace MacroScope
{
    /// <summary>
    /// Visits SQL statement trees not doing anything.
    /// </summary>
    /// <remarks>
    /// Base for visitors not wishing to implement all
    /// callbacks of <see cref="IVisitor"/>.
    /// </remarks>
    public class PassiveVisitor : IVisitor
    {
        #region IVisitor Members

        public virtual void PerformBefore(AliasedItem node)
        {
        }

        public virtual void PerformOnAlias(AliasedItem node)
        {
        }

        public virtual void PerformAfter(AliasedItem node)
        {
        }

        public virtual void PerformBefore(Assignment node)
        {
        }

        public virtual void PerformOnAssignment(Assignment node)
        {
        }

        public virtual void PerformAfter(Assignment node)
        {
        }

        public virtual void PerformBefore(BracketedExpression node)
        {
        }

        public virtual void PerformAfter(BracketedExpression node)
        {
        }

        public virtual void PerformBefore(CaseAlternative node)
        {
        }

        public virtual void PerformOnThen(CaseAlternative node)
        {
        }

        public virtual void PerformAfter(CaseAlternative node)
        {
        }

        public virtual void PerformBefore(CaseExpression node)
        {
        }

        public virtual void PerformOnWhen(CaseExpression node)
        {
        }

        public virtual void PerformOnElse(CaseExpression node)
        {
        }

        public virtual void PerformAfter(CaseExpression node)
        {
        }

        public virtual void Perform(DateTimeUnit node)
        {
        }

        public virtual void PerformBefore(DbObject node)
        {
        }

        public virtual void PerformAfter(DbObject node)
        {
        }

        public virtual void Perform(DefaultValue node)
        {
        }

        public virtual void PerformBefore(DeleteStatement node)
        {
        }

        public virtual void PerformOnWhere(DeleteStatement node)
        {
        }

        public virtual void PerformAfter(DeleteStatement node)
        {
        }

        public virtual void Perform(DoubleValue node)
        {
        }

        public virtual void PerformBefore(Expression node)
        {
        }

        public virtual void PerformBeforePrefixOp(Expression node)
        {
        }

        public virtual void PerformAfterPrefixOp(Expression node)
        {
        }

        public virtual void PerformBeforePostfixOp(Expression node)
        {
        }

        public virtual void PerformAfterPostfixOp(Expression node)
        {
        }

        public virtual void PerformBeforeBinaryOp(Expression node)
        {
        }

        public virtual void PerformAfterBinaryOp(Expression node)
        {
        }

        public virtual void PerformAfter(Expression node)
        {
        }

        public virtual void PerformBefore(ExpressionItem node)
        {
        }

        public virtual void PerformAfter(ExpressionItem node)
        {
        }

        public virtual void Perform(ExpressionOperator node)
        {
        }

        public virtual void PerformBefore(ExtractFunction node)
        {
        }

        public virtual void PerformOnSource(ExtractFunction node)
        {
        }

        public virtual void PerformAfter(ExtractFunction node)
        {
        }

        public virtual void PerformBefore(FunctionCall node)
        {
        }

        public virtual void PerformAfter(FunctionCall node)
        {
        }

        public virtual void PerformBefore(GroupByClause node)
        {
        }

        public virtual void PerformOnHaving(GroupByClause node)
        {
        }

        public virtual void PerformAfter(GroupByClause node)
        {
        }

        public virtual void Perform(Identifier node)
        {
        }

        public virtual void PerformBefore(InsertStatement node)
        {
        }

        public virtual void PerformOnNames(InsertStatement node)
        {
        }

        public virtual void PerformOnValues(InsertStatement node)
        {
        }

        public virtual void PerformAfter(InsertStatement node)
        {
        }

        public virtual void Perform(IntegerValue node)
        {
        }

        public virtual void PerformBefore(Interval node)
        {
        }

        public virtual void PerformOnUnit(Interval node)
        {
        }

        public virtual void PerformAfter(Interval node)
        {
        }

        public virtual void Perform(Join node)
        {
        }

        public virtual void Perform(LiteralDateTime node)
        {
        }

        public virtual void Perform(NullValue node)
        {
        }

        public virtual void PerformBefore(OrderExpression node)
        {
        }

        public virtual void PerformAfter(OrderExpression node)
        {
        }

        public virtual void PerformBefore(PatternExpression node)
        {
        }

        public virtual void PerformOnEscape(PatternExpression node)
        {
        }

        public virtual void PerformAfter(PatternExpression node)
        {
        }

        public virtual void Perform(Placeholder node)
        {
        }

        public virtual void PerformBefore(PredicateExpression node)
        {
        }

        public virtual void PerformOnOperator(PredicateExpression node)
        {
        }

        public virtual void PerformOnQuantifier(PredicateExpression node)
        {
        }

        public virtual void PerformOnSelect(PredicateExpression node)
        {
        }

        public virtual void PerformAfter(PredicateExpression node)
        {
        }

        public virtual void Perform(PredicateQuantifier node)
        {
        }

        public virtual void PerformBefore(QueryExpression node)
        {
        }

        public virtual void PerformOnFrom(QueryExpression node)
        {
        }

        public virtual void PerformOnWhere(QueryExpression node)
        {
        }

        public virtual void PerformOnGroupBy(QueryExpression node)
        {
        }

        public virtual void PerformOnOrderBy(QueryExpression node)
        {
        }

        public virtual void PerformAfter(QueryExpression node)
        {
        }

        public virtual void PerformBefore(Range node)
        {
        }

        public virtual void PerformOnAnd(Range node)
        {
        }

        public virtual void PerformAfter(Range node)
        {
        }

        public virtual void PerformBefore(SelectStatement node)
        {
        }

        public virtual void PerformAfter(SelectStatement node)
        {
        }

        public virtual void Perform(StringValue node)
        {
        }

        public virtual void PerformBefore(SwitchFunction node)
        {
        }

        public virtual void PerformAfter(SwitchFunction node)
        {
        }

        public virtual void PerformBefore(Table node)
        {
        }

        public virtual void PerformOnSource(Table node)
        {
        }

        public virtual void PerformOnAlias(Table node)
        {
        }

        public virtual void PerformBeforeCondition(Table node)
        {
        }

        public virtual void PerformAfterCondition(Table node)
        {
        }

        public virtual void PerformAfter(Table node)
        {
        }

        public virtual void PerformBefore(TableWildcard node)
        {
        }

        public virtual void PerformAfter(TableWildcard node)
        {
        }

        public virtual void PerformBefore(TypeCast node)
        {
        }

        public virtual void PerformAfter(TypeCast node)
        {
        }

        public virtual void PerformBefore(UpdateStatement node)
        {
        }

        public virtual void PerformOnAssignments(UpdateStatement node)
        {
        }

        public virtual void PerformOnWhere(UpdateStatement node)
        {
        }

        public virtual void PerformAfter(UpdateStatement node)
        {
        }

        public virtual void Perform(Variable node)
        {
        }

        public virtual void Perform(Wildcard node)
        {
        }

        #endregion
    }
}
