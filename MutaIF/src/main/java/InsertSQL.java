import net.sf.jsqlparser.JSQLParserException;
import net.sf.jsqlparser.expression.*;
import net.sf.jsqlparser.expression.operators.conditional.AndExpression;
import net.sf.jsqlparser.expression.operators.conditional.OrExpression;
import net.sf.jsqlparser.expression.operators.relational.*;
import net.sf.jsqlparser.parser.CCJSqlParserUtil;
import net.sf.jsqlparser.schema.Column;
import net.sf.jsqlparser.schema.Table;
import net.sf.jsqlparser.statement.select.*;
import net.sf.jsqlparser.statement.update.Update;
import net.sf.jsqlparser.util.SelectUtils;
import net.sf.jsqlparser.util.TablesNamesFinder;
import net.sf.jsqlparser.util.deparser.ExpressionDeParser;

import java.io.StringReader;
import java.sql.*;
import java.util.*;

public class InsertSQL {
    public static Map<String, Integer> columntag = new HashMap<>();

    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        Class.forName("com.mysql.cj.jdbc.Driver");
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/test?useSSL=FALSE&serverTimezone=UTC","root", "a19990209l");
        Statement st = conn.createStatement();
        String Qo = "INSERT INTO Patient(name, age, disease) VALUES('linwei', 22, 'Healthy')";

        //System.out.println(columnlist);
        //System.out.println(columninclause);

        columntag.put("age", 64);
        //System.out.println(columninclause.toString());
        long begintime = System.nanoTime();

        // ********* insert column
        List<String> str_column = new ArrayList<String>();
        List<String> str_value = new ArrayList<String>();
        for (HashMap.Entry<String, Integer> entry: columntag.entrySet())
        {
            str_column.add(entry.getKey()+"tag");
            str_value.add(""+entry.getValue());
        }
        String Qm = null;
        try {
            Qm = SQLParser.build_insert_column(Qo, str_column);
            Qm = SQLParser.build_insert_values(Qm, str_value);
        } catch (JSQLParserException e) {
            e.printStackTrace();
        }

        //System.out.println("final:" + Qm);
        st.executeUpdate(Qm);

        long endtime = System.nanoTime();
        long costTime = (endtime - begintime)/1000000;
        System.out.println(costTime);
    }
}
