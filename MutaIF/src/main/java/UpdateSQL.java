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

public class UpdateSQL {
    public static Map<String, Integer> columntag = new HashMap<>();
    public static Map<String, Integer> predicatetag = new HashMap<>();
    public static Set<String> columninclause = new HashSet<>();
    public static Map<String, HashSet<Integer>> taintindb = new HashMap<>();

    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        Class.forName("com.mysql.cj.jdbc.Driver");
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/test?useSSL=FALSE&serverTimezone=UTC","root", "a19990209l");
        Statement st = conn.createStatement();
        String Qo = "UPDATE Patient SET age = 1 WHERE disease = 'Cancer'";
        List<String> columnlist = null;
        try {
            columnlist = SQLParser.update_column(Qo);
            columninclause = SQLParser.update_where(Qo);
        } catch (JSQLParserException e) {
            e.printStackTrace();
        }
        //System.out.println(columnlist);
        //System.out.println(columninclause);

        columntag.put("age", 64);
        predicatetag.put("disease='Cancer'", 128);

        Select select = SelectUtils.buildSelectFromTable(new Table("Patient"));
        ResultSet rs = st.executeQuery(select.toString());
        List<HashMap<String, Object>> Do = new ArrayList<HashMap<String,Object>>();
        while (rs.next()) {
            HashMap<String,Object> p = new HashMap<String,Object>();
            p.put("name", rs.getString(1));
            p.put("nametag", rs.getInt(2));
            p.put("age", rs.getString(3));
            p.put("agetag", rs.getInt(4));
            p.put("disease", rs.getString(5));
            p.put("diseasetag", rs.getInt(6));
            Do.add(p);
        }
        //System.out.println(Do);

        String backup = "CREATE TABLE Patient_copy AS " + select.toString();
        //System.out.println(backup);
        st.executeUpdate(backup);

        st.executeUpdate(Qo);
        rs = st.executeQuery(select.toString());
        List<HashMap<String, Object>> Dn = new ArrayList<HashMap<String,Object>>();

        while (rs.next()) {
            HashMap<String,Object> p = new HashMap<String,Object>();
            p.put("name", rs.getString(1));
            p.put("nametag", rs.getInt(2));
            p.put("age", rs.getString(3));
            p.put("agetag", rs.getInt(4));
            p.put("disease", rs.getString(5));
            p.put("diseasetag", rs.getInt(6));
            Dn.add(p);
        }

        //source: column indexes
        List<HashMap<String, Object>> Dn1 = new ArrayList<HashMap<String,Object>>();
        for(HashMap<String,Object> p: Dn)
        {
            int flag1 = 0;
            for(HashMap<String,Object> q: Do)
            {
                int flag2 = 0;
                for (HashMap.Entry<String, Object> entry : p.entrySet())
                {
                    if(entry.getKey().endsWith("tag")) continue;
                    //System.out.println(q.get(entry.getKey()));
                    if(!entry.getValue().equals(q.get(entry.getKey())))
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
                /*for (HashMap.Entry<String, Integer> entry : columntag.entrySet())
                {
                    int tag = (int)p.get(entry.getKey()+"tag");
                    p.put(entry.getKey()+"tag", tag | entry.getValue());
                }*/
                Dn1.add(p);
            }
        }
        //System.out.println(Dn1);
        String drop = "DROP TABLE Patient";
        st.executeUpdate(drop);
        String restore = "ALTER TABLE Patient_copy RENAME Patient";
        //System.out.println(restore);
        st.executeUpdate(restore);


        //source: condition predicates
        for (HashMap.Entry<String, Integer> entry : predicatetag.entrySet()) {
            backup = "CREATE TABLE Patient_copy AS " + select.toString();
            //System.out.println(backup);
            st.executeUpdate(backup);
            //System.out.println("Key = " + entry.getKey() + ", Value = " + entry.getValue());
            Update stmt = null;
            try {
                stmt = (Update) CCJSqlParserUtil.parse(Qo);
            } catch (JSQLParserException e) {
                e.printStackTrace();
            }
            //System.out.println("before " + stmt.toString());
            stmt.getWhere().accept(new ExpressionVisitorAdapter() {
                @Override
                public void visit(EqualsTo e) {
                    if(entry.getKey().replace(" ", "").equals(e.toString().replace(" ", "")))
                        e.setNot();
                }
            });
            String Qm = stmt.toString();
            //System.out.println("after " + stmt.toString());
            st.executeUpdate(Qm);

            rs = st.executeQuery(select.toString());
            List<HashMap<String, Object>> Dm = new ArrayList<HashMap<String,Object>>();
            while (rs.next()) {
                HashMap<String,Object> p = new HashMap<String,Object>();
                p.put("name", rs.getString(1));
                p.put("nametag", rs.getInt(2));
                p.put("age", rs.getString(3));
                p.put("agetag", rs.getInt(4));
                p.put("disease", rs.getString(5));
                p.put("diseasetag", rs.getInt(6));
                Dm.add(p);
            }

            List<HashMap<String, Object>> Dm1 = new ArrayList<HashMap<String,Object>>();
            for(HashMap<String,Object> p: Dm)
            {
                int flag1 = 0;
                for(HashMap<String,Object> q: Do)
                {
                    int flag2 = 0;
                    for (HashMap.Entry<String, Object> entry2 : p.entrySet())
                    {
                        if(entry2.getKey().endsWith("tag")) continue;
                        if(!entry2.getValue().equals(q.get(entry2.getKey())))
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
                    Dm1.add(p);
                }
            }

            List<HashMap<String, Object>> Dd = new ArrayList<HashMap<String,Object>>();
            for(HashMap<String,Object> p: Dn1)
            {
                int flag1 = 0;
                for(HashMap<String,Object> q: Dm1)
                {
                    int flag2 = 0;
                    for (HashMap.Entry<String, Object> entry2 : p.entrySet())
                    {
                        if(entry2.getKey().endsWith("tag")) continue;
                        if(!entry2.getValue().equals(q.get(entry2.getKey())))
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
                    Dd.add(p);
                }
            }

            for(HashMap<String,Object> p: Dn)
            {
                int flag1 = 0;
                for(HashMap<String,Object> q: Dd)
                {
                    int flag2 = 0;
                    for (HashMap.Entry<String, Object> entry2 : p.entrySet())
                    {
                        if(entry2.getKey().endsWith("tag")) continue;
                        if(!entry2.getValue().equals(q.get(entry2.getKey())))
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
                if(flag1 == 1)
                {
                    for(String c: columnlist)
                    {
                        int tag = (int)p.get(c+"tag");
                        p.put(c+"tag", tag | entry.getValue());
                    }
                }
            }
            drop = "DROP TABLE Patient";
            st.executeUpdate(drop);
            restore = "ALTER TABLE Patient_copy RENAME Patient";
            //System.out.println(restore);
            st.executeUpdate(restore);
        }
        //System.out.println(Dn);


        //source: components

        String col = "";
        for(String s: columninclause)
        {
            col = col + s + "tag,";
            HashSet<Integer> hs = new HashSet<>();
            taintindb.put(s, hs);
        }
        col.substring(0, col.length()-2);
        select = null;
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

                backup = "CREATE TABLE Patient_" + taint + " AS " + select.toString();
                //System.out.println(backup);
                st.executeUpdate(backup);
                st.executeUpdate(update.toString());
                rs = st.executeQuery(select.toString());
                List<HashMap<String, Object>> Dm = new ArrayList<HashMap<String,Object>>();
                while (rs.next()) {
                    HashMap<String,Object> p = new HashMap<String,Object>();
                    p.put("name", rs.getString(1));
                    p.put("nametag", rs.getInt(2));
                    p.put("age", rs.getString(3));
                    p.put("agetag", rs.getInt(4));
                    p.put("disease", rs.getString(5));
                    p.put("diseasetag", rs.getInt(6));
                    Dm.add(p);
                }

                List<HashMap<String, Object>> Dm1 = new ArrayList<HashMap<String,Object>>();
                for(HashMap<String,Object> p: Dm)
                {
                    int flag1 = 0;
                    for(HashMap<String,Object> q: Do)
                    {
                        int flag2 = 0;
                        for (HashMap.Entry<String, Object> entry2 : p.entrySet())
                        {
                            //System.out.println(q.get(entry2.getKey()));
                            if(entry2.getKey().endsWith("tag") || entry2.getValue() == null) continue;
                            if(!entry2.getValue().equals(q.get(entry2.getKey())))
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
                        Dm1.add(p);
                    }
                }

                List<HashMap<String, Object>> Dd = new ArrayList<HashMap<String,Object>>();
                for(HashMap<String,Object> p: Dn1)
                {
                    int flag1 = 0;
                    for(HashMap<String,Object> q: Dm1)
                    {
                        int flag2 = 0;
                        for (HashMap.Entry<String, Object> entry2 : p.entrySet())
                        {
                            if(entry2.getKey().endsWith("tag")) continue;
                            if(!entry2.getValue().equals(q.get(entry2.getKey())))
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
                        Dd.add(p);
                    }
                }

                for(HashMap<String,Object> p: Dn)
                {
                    int flag1 = 0;
                    for(HashMap<String,Object> q: Dd)
                    {
                        int flag2 = 0;
                        for (HashMap.Entry<String, Object> entry2 : p.entrySet())
                        {
                            if(entry2.getKey().endsWith("tag")) continue;
                            if(!entry2.getValue().equals(q.get(entry2.getKey())))
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
                    if(flag1 == 1)
                    {
                        for(String c: columnlist)
                        {
                            int tag = (int)p.get(c+"tag");
                            p.put(c+"tag", tag | taint);
                        }
                    }
                }
                drop = "DROP TABLE Patient";
                st.executeUpdate(drop);
                restore = "ALTER TABLE Patient_" + taint + " RENAME Patient";
                //System.out.println(restore);
                st.executeUpdate(restore);

            }
        }

        //output
        for(HashMap<String,Object> p: Dn)
        {
            System.out.println(p.toString());
        }
    }
}
