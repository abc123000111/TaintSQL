using System;

namespace MacroScope
{
    /// <summary>
    /// Common interface for tasks performed on SQL statement trees.
    /// </summary>
    public interface IVisitor
    {
        void PerformBefore(AliasedItem node);

        void PerformOnAlias(AliasedItem node);

        void PerformAfter(AliasedItem node);

        void PerformBefore(Assignment node);

        void PerformOnAssignment(Assignment node);

        void PerformAfter(Assignment node);

        void PerformBefore(BracketedExpression node);

        void PerformAfter(BracketedExpression node);

        void PerformBefore(CaseAlternative node);

        void PerformOnThen(CaseAlternative node);

        void PerformAfter(CaseAlternative node);

        void PerformBefore(CaseExpression node);

        void PerformOnWhen(CaseExpression node);

        void PerformOnElse(CaseExpression node);

        void PerformAfter(CaseExpression node);

        void Perform(DateTimeUnit node);

        void PerformBefore(DbObject node);

        void PerformAfter(DbObject node);

        void Perform(DefaultValue node);

        void PerformBefore(DeleteStatement node);

        void PerformOnWhere(DeleteStatement node);

        void PerformAfter(DeleteStatement node);

        void Perform(DoubleValue node);

        void PerformBefore(Expression node);

        void PerformBeforePrefixOp(Expression node);

        void PerformAfterPrefixOp(Expression node);

        void PerformBeforePostfixOp(Expression node);

        void PerformAfterPostfixOp(Expression node);

        void PerformBeforeBinaryOp(Expression node);

        void PerformAfterBinaryOp(Expression node);

        void PerformAfter(Expression node);

        void PerformBefore(ExpressionItem node);

        void PerformAfter(ExpressionItem node);

        void Perform(ExpressionOperator node);

        void PerformBefore(ExtractFunction node);

        void PerformOnSource(ExtractFunction node);

        void PerformAfter(ExtractFunction node);

        void PerformBefore(FunctionCall node);

        void PerformAfter(FunctionCall node);

        void PerformBefore(GroupByClause node);

        void PerformOnHaving(GroupByClause node);

        void PerformAfter(GroupByClause node);

        void Perform(Identifier node);

        void PerformBefore(InsertStatement node);

        void PerformOnNames(InsertStatement node);

        void PerformOnValues(InsertStatement node);

        void PerformAfter(InsertStatement node);

        void Perform(IntegerValue node);

        void PerformBefore(Interval node);

        void PerformOnUnit(Interval node);

        void PerformAfter(Interval node);

        void Perform(Join node);

        void Perform(LiteralDateTime node);

        void Perform(NullValue node);

        void PerformBefore(OrderExpression node);

        void PerformAfter(OrderExpression node);

        void PerformBefore(PatternExpression node);

        void PerformOnEscape(PatternExpression node);

        void PerformAfter(PatternExpression node);

        void Perform(Placeholder node);

        void PerformBefore(PredicateExpression node);

        void PerformOnOperator(PredicateExpression node);

        void PerformOnQuantifier(PredicateExpression node);

        void PerformOnSelect(PredicateExpression node);

        void PerformAfter(PredicateExpression node);

        void Perform(PredicateQuantifier node);

        void PerformBefore(QueryExpression node);

        void PerformOnFrom(QueryExpression node);

        void PerformOnWhere(QueryExpression node);

        void PerformOnGroupBy(QueryExpression node);

        void PerformOnOrderBy(QueryExpression node);

        void PerformAfter(QueryExpression node);

        void PerformBefore(Range node);

        void PerformOnAnd(Range node);

        void PerformAfter(Range node);

        void PerformBefore(SelectStatement node);

        void PerformAfter(SelectStatement node);

        void Perform(StringValue node);

        void PerformBefore(SwitchFunction node);

        void PerformAfter(SwitchFunction node);

        void PerformBefore(Table node);

        void PerformOnSource(Table node);

        void PerformOnAlias(Table node);

        void PerformBeforeCondition(Table node);

        void PerformAfterCondition(Table node);

        void PerformAfter(Table node);

        void PerformBefore(TableWildcard node);

        void PerformAfter(TableWildcard node);

        void PerformBefore(TypeCast node);

        void PerformAfter(TypeCast node);

        void PerformBefore(UpdateStatement node);

        void PerformOnAssignments(UpdateStatement node);

        void PerformOnWhere(UpdateStatement node);

        void PerformAfter(UpdateStatement node);

        void Perform(Variable node);

        void Perform(Wildcard node);
    }
}
