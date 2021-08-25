import net.sf.jsqlparser.JSQLParserException;
import net.sf.jsqlparser.expression.*;
import net.sf.jsqlparser.expression.operators.conditional.AndExpression;
import net.sf.jsqlparser.expression.operators.conditional.OrExpression;
import net.sf.jsqlparser.expression.operators.relational.*;
import net.sf.jsqlparser.parser.CCJSqlParserUtil;
import net.sf.jsqlparser.schema.Column;
import net.sf.jsqlparser.statement.insert.Insert;
import net.sf.jsqlparser.statement.select.PlainSelect;
import net.sf.jsqlparser.statement.select.Select;
import net.sf.jsqlparser.statement.select.SelectBody;
import net.sf.jsqlparser.statement.select.SelectItem;
import net.sf.jsqlparser.statement.update.Update;
import net.sf.jsqlparser.util.TablesNamesFinder;
import net.sf.jsqlparser.statement.Statement;
import net.sf.jsqlparser.util.deparser.ExpressionDeParser;

import java.io.StringReader;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.*;

class SQLParser {

    //装载where后面的字段名称并去重
    private static Set<String> set = new HashSet<>();
    //解析出来的单个条件名称
    private static String columnName = null;

    public static List<String> update_column(String sql) throws JSQLParserException {
        Statement statement = CCJSqlParserUtil.parse(sql);
        Update updateStatement = (Update) statement;
        List<Column> update_column = updateStatement.getColumns();
        List<String> str_column = new ArrayList<String>();
        if (update_column != null) {
            for (int i = 0; i < update_column.size(); i++) {
                str_column.add(update_column.get(i).toString());
            }
        }
        return str_column;

    }

    public static List<String> select_items(String sql) throws JSQLParserException {
        Select select = (Select) CCJSqlParserUtil.parse(sql);
        PlainSelect plain = (PlainSelect) select.getSelectBody();
        List<SelectItem> selectitems = plain.getSelectItems();
        List<String> str_items = new ArrayList<String>();
        if (selectitems != null) {
            for (int i = 0; i < selectitems.size(); i++) {
                str_items.add(selectitems.get(i).toString());
            }
        }
        return str_items;
    }

    public static Set<String> getCloumnNames(String sql) throws JSQLParserException {
        Select statement = (Select) CCJSqlParserUtil.parse(sql);
        if (statement instanceof Select) {
            Select istatement = (Select) statement;
            Expression where = ((PlainSelect) istatement.getSelectBody()).getWhere();
            if (null != where) {
                return getParser(where);
            }
        }
        return null;
    }

    public static Set<String> update_where(String sql) throws JSQLParserException {
        Statement statement = CCJSqlParserUtil.parse(sql);
        Update updateStatement = (Update) statement;
        Expression where_expression = updateStatement.getWhere();
        return getParser(where_expression);
    }

    private static Set<String> getParser(Expression expression) {
        //初始化接受获得的字段信息
        if (expression instanceof BinaryExpression) {
            //获得左边表达式
            Expression leftExpression = ((BinaryExpression) expression).getLeftExpression();
            //获得左边表达式为Column对象，则直接获得列名
            if (leftExpression instanceof Column) {
                columnName = ((Column) leftExpression).getColumnName();
                set.add(columnName);
            } else if (leftExpression instanceof InExpression) {
                parserInExpression(leftExpression);
            } else if (leftExpression instanceof IsNullExpression) {
                parserIsNullExpression(leftExpression);
            } else if (leftExpression instanceof BinaryExpression) {//递归调用
                getParser(leftExpression);
            } else if (expression instanceof Parenthesis) {//递归调用
                Expression expression1 = ((Parenthesis) expression).getExpression();
                getParser(expression1);
            }

            //获得右边表达式，并分解
            Expression rightExpression = ((BinaryExpression) expression).getRightExpression();
            if (rightExpression instanceof BinaryExpression) {
                parserBinaryExpression(rightExpression);
            } else if (rightExpression instanceof InExpression) {
                parserInExpression(rightExpression);
            } else if (rightExpression instanceof IsNullExpression) {
                parserIsNullExpression(rightExpression);
            } else if (rightExpression instanceof Parenthesis) {//递归调用
                Expression expression1 = ((Parenthesis) rightExpression).getExpression();
                getParser(expression1);
            }
        } else if (expression instanceof InExpression) {
            parserInExpression(expression);
        } else if (expression instanceof IsNullExpression) {
            parserIsNullExpression(expression);
        } else if (expression instanceof Parenthesis) {//递归调用
            Expression expression1 = ((Parenthesis) expression).getExpression();
            getParser(expression1);
        }
        return set;
    }

    /**
     * 解析in关键字左边的条件
     *
     * @param expression
     */
    public static void parserInExpression(Expression expression) {
        Expression leftExpression = ((InExpression) expression).getLeftExpression();
        if (leftExpression instanceof Column) {
            columnName = ((Column) leftExpression).getColumnName();
            set.add(columnName);
        }
    }

    /**
     * 解析is null 和 is not null关键字左边的条件
     *
     * @param expression
     */
    public static void parserIsNullExpression(Expression expression) {
        Expression leftExpression = ((IsNullExpression) expression).getLeftExpression();
        if (leftExpression instanceof Column) {
            columnName = ((Column) leftExpression).getColumnName();
            set.add(columnName);
        }
    }

    public static void parserBinaryExpression(Expression expression) {
        Expression leftExpression = ((BinaryExpression) expression).getLeftExpression();
        if (leftExpression instanceof Column) {
            columnName = ((Column) leftExpression).getColumnName();
            set.add(columnName);
        }
    }

    // *********update column
    public static String build_update_column(String sql, List<String> str_column)
            throws JSQLParserException {
        Statement statement = CCJSqlParserUtil.parse(sql);
        Update updateStatement = (Update) statement;
        List<Column> update_column = new ArrayList<Column>();
        for (int i = 0; i < str_column.size(); i++) {
            update_column.add((Column) CCJSqlParserUtil
                    .parseExpression(str_column.get(i)));
        }
        updateStatement.setColumns(update_column);
        return updateStatement.toString();

    }
    // *********update values
    public static String build_update_values(String sql, List<String> str_values)
            throws JSQLParserException {
        Statement statement = CCJSqlParserUtil.parse(sql);
        Update updateStatement = (Update) statement;
        List<Expression> update_values = new ArrayList<Expression>();
        for (int i = 0; i < str_values.size(); i++) {
            update_values.add((Expression) CCJSqlParserUtil
                    .parseExpression(str_values.get(i)));
        }
        updateStatement.setExpressions(update_values);
        return updateStatement.toString();

    }
    // ********* insert column
    public static String build_insert_column(String sql, List<String> str_column)
            throws JSQLParserException {
        Statement statement = CCJSqlParserUtil.parse(sql);
        Insert insertStatement = (Insert) statement;
        List<Column> insert_column = insertStatement.getColumns();

        for (int i = 0; i < str_column.size(); i++) {
            insert_column.add((Column) CCJSqlParserUtil
                    .parseCondExpression(str_column.get(i)));
        }
        insertStatement.setColumns(insert_column);
        return insertStatement.toString();

    }

    // ********* insert values
    public static String build_insert_values(String sql, List<String> str_value)
            throws JSQLParserException {
        Statement statement = CCJSqlParserUtil.parse(sql);
        Insert insertStatement = (Insert) statement;
        List<Expression> insert_values_expression = ((ExpressionList)insertStatement.getItemsList()).getExpressions();
        for (int i = 0; i < str_value.size(); i++) {
            insert_values_expression.add((Expression) CCJSqlParserUtil
                    .parseExpression(str_value.get(i)));
        }
        // list to expressionlist to Itemlist
        insertStatement.setItemsList(new ExpressionList(
                insert_values_expression));
        return insertStatement.toString();

    }

}
