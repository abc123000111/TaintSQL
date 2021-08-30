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
import net.sf.jsqlparser.statement.Statement;
import net.sf.jsqlparser.util.deparser.ExpressionDeParser;

import java.io.StringReader;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.*;

public class MutaSQL {
    public static Map<String, Integer> columntag = new HashMap<>();
    public static Map<String, Integer> predicatetag = new HashMap<>();
    public static Set<String> columninclause = new HashSet<>();
    public static Map<String, HashSet<Integer>> taintindb = new HashMap<>();

    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        Class.forName("com.mysql.cj.jdbc.Driver");
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/test?useSSL=FALSE&serverTimezone=UTC","root", "a19990209l");
        java.sql.Statement st = conn.createStatement();
        String Qo = "SELECT age, sex FROM Patient, user WHERE Patient.name=user.name and disease = 'Cancer'";
        List<String> columnlist = null;
        try {
            columnlist = SQLParser.select_items(Qo);
            columninclause = SQLParser.getCloumnNames(Qo);
        } catch (JSQLParserException e) {
            e.printStackTrace();
        }

        columntag.put("age", 64);
        predicatetag.put("disease='Cancer'", 128);
        //System.out.println(columninclause.toString());
        long begintime = System.nanoTime();

        ResultSet rs = st.executeQuery(Qo);
        List<HashMap<String, Object>> Rn = new ArrayList<HashMap<String,Object>>();

        while (rs.next()) {
            HashMap<String,Object> p = new HashMap<String,Object>();
            for(String c: columnlist)
            {
                p.put(c, rs.getString(c));
                p.put(c+"tag", 0);
            }
            Rn.add(p);
        }

        //source: column indexes
        for (HashMap.Entry<String, Integer> entry : columntag.entrySet()) {
            for(HashMap<String,Object> p: Rn)
            {
                String tagname = entry.getKey()+"tag";
                int tag = (int)p.get(tagname);
                p.put(tagname, tag | entry.getValue());
            }
        }

        //source: condition predicates
        for (HashMap.Entry<String, Integer> entry : predicatetag.entrySet()) {
            //System.out.println("Key = " + entry.getKey() + ", Value = " + entry.getValue());
            Select stmt = null;
            try {
                stmt = (Select) CCJSqlParserUtil.parse(Qo);
            } catch (JSQLParserException e) {
                e.printStackTrace();
            }
            //System.out.println("before " + stmt.toString());
            ((PlainSelect)stmt.getSelectBody()).getWhere().accept(new ExpressionVisitorAdapter() {
                @Override
                public void visit(EqualsTo e) {
                    if(entry.getKey().replace(" ", "").equals(e.toString().replace(" ", "")))
                        e.setNot();
                }
            });
            String Qm = stmt.toString();
            //System.out.println("after " + stmt.toString());
            rs = st.executeQuery(Qm);
            List<HashMap<String, Object>> Rm = new ArrayList<HashMap<String,Object>>();
            while (rs.next()) {
                HashMap<String,Object> p = new HashMap<String,Object>();
                for(String c: columnlist)
                {
                    p.put(c, rs.getString(c));
                    p.put(c+"tag", 0);
                }
                Rm.add(p);
            }

            for(HashMap<String,Object> p: Rn)
            {
                int flag1 = 0;
                for(HashMap<String,Object> q: Rm)
                {
                    int flag2 = 0;
                    for(String c: columnlist)
                    {
                        if(!p.get(c).equals(q.get(c)))
                        {
                            flag2 = 1;
                            break;
                        }
                    }
                    if(flag2 == 0)
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if(flag1 == 0)
                {
                    for(String c: columnlist)
                    {
                        int tag = (int)p.get(c+"tag");
                        p.put(c+"tag", tag | entry.getValue());
                    }
                }
            }

        }

        //source: components
        String col = "";
        for(String s: columninclause)
        {
            col = col + s + "tag,";
            HashSet<Integer> hs = new HashSet<>();
            taintindb.put(s, hs);
        }
        col.substring(0, col.length()-2);
        Select select = null;
        try {
            select = SelectUtils.buildSelectFromTableAndExpressions(new Table("Patient"), col);

        } catch (JSQLParserException e) {
            e.printStackTrace();
        }
        //System.out.println(select.toString());//SELECT A, B FROM TABLE1
        rs = st.executeQuery(select.toString());

        while (rs.next()) {
            for(String s: columninclause)
            {
                int taint = rs.getInt(s+"tag");
                if(taint != 0)
                {
                    taintindb.get(s).add(taint);
                }
            }
        }
        //System.out.println(taintindb.toString());

        for(String s: columninclause)
        {
            for(Integer taint: taintindb.get(s))
            {
                Update update = new Update();
                List<Table> tables = new ArrayList<>();
                tables.add(new Table("Patient"));
                update.setTables(tables);

                List<Column> columns = new ArrayList<>();
                columns.add(new Column(s));
                update.setColumns(columns);

                List<Expression> expressions = new ArrayList<>();
                expressions.add(new NullValue());
                update.setExpressions(expressions);

                EqualsTo equalsTo = new EqualsTo();
                equalsTo.setLeftExpression(new Column(s+"tag"));
                equalsTo.setRightExpression(new LongValue(taint));
                update.setWhere(equalsTo);

                select = SelectUtils.buildSelectFromTable(new Table("Patient"));

                String backup = "CREATE TABLE Patient_" + taint + " AS " + select.toString();
                //System.out.println(backup);
                st.executeUpdate(backup);
                st.executeUpdate(update.toString());
                rs = st.executeQuery(Qo);
                List<HashMap<String, Object>> Rm = new ArrayList<HashMap<String,Object>>();
                while (rs.next()) {
                    HashMap<String,Object> p = new HashMap<String,Object>();
                    for(String c: columnlist)
                    {
                        p.put(c, rs.getString(c));
                        p.put(c+"tag", 0);
                    }
                    Rm.add(p);
                }

                for(HashMap<String,Object> p: Rn)
                {
                    int flag1 = 0;
                    for(HashMap<String,Object> q: Rm)
                    {
                        int flag2 = 0;
                        for(String c: columnlist)
                        {
                            if(!p.get(c).equals(q.get(c)))
                            {
                                flag2 = 1;
                                break;
                            }
                        }
                        if(flag2 == 0)
                        {
                            flag1 = 1;
                            break;
                        }
                    }
                    if(flag1 == 0)
                    {
                        for(String c: columnlist)
                        {
                            int tag = (int)p.get(c+"tag");
                            p.put(c+"tag", tag | taint);
                        }
                    }
                }

                String drop = "DROP TABLE Patient";
                st.executeUpdate(drop);
                String restore = "ALTER TABLE Patient_" + taint + " RENAME Patient";
                //System.out.println(restore);
                st.executeUpdate(restore);

            }
        }

        //output
        for(HashMap<String,Object> p: Rn)
        {
            System.out.println(p.toString());
        }

        long endtime = System.nanoTime();
        long costTime = (endtime - begintime)/1000000;
        System.out.println(costTime);
    }
}
