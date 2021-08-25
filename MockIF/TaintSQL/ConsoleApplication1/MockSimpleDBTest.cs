using System;
using System.Collections.Generic;
using System.Text;
using MockDBMS;
using MockDBMS.SqlServer;
using System.Diagnostics;


namespace ExampleCode
{
    class MockSimpleDBTest
    {
        static void Main(string[] args)
        {
            /*int passwordId = 1;
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();
            string query = String.Format("INSERT INTO Favorite (PasswordId, FolderId) VALUES (1, 1)");
            MockSqlCommand myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();

            query = String.Format("INSERT INTO Folder (Orde, ParentId, Name, Id) VALUES (1, 1, \"lw\", 1)");
            myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();

            string sql = "select Folder.Orde, Folder.ParentId, Folder.Name, Folder.Id, Favorite.PasswordId from Folder, Favorite where Folder.Id=Favorite.FolderId and Favorite.PasswordId={0}";
            query = String.Format(sql, DBMS.processData(passwordId, "00000001", sql, true));
            Console.WriteLine(query);
            myCommand = new MockSqlCommand(query, myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("order: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
                Console.WriteLine("parentid: " + myReader[2]);
                Console.WriteLine("tag: " + myReader[3]);
                Console.WriteLine("name: " + myReader[4]);
                Console.WriteLine("tag: " + myReader[5]);
                Console.WriteLine("id: " + myReader[6]);
                Console.WriteLine("tag: " + myReader[7]);
                Console.WriteLine("pasid: " + myReader[8]);
                Console.WriteLine("tag: " + myReader[9]);
            }*/
            
            int index1 = 1, index2 = 2, index3 = 3;
            string name1 = "lw", name2 = "sanshu";
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();

            string query = String.Format("INSERT INTO PERSONS (index, name) VALUES ({0}, {1})", index1, name1);
            query = String.Format("INSERT INTO PERSONS (index, name) VALUES ({0}, {1})", DBMS.processData(index1, "00000001", query, false), DBMS.processData(name1, "00000008", query, false));

            MockSqlCommand myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();

            query = String.Format("INSERT INTO PERSONS (index, name) VALUES ({0}, {1})", index2, name2);
            query = String.Format("INSERT INTO PERSONS (index, name) VALUES ({0}, {1})", DBMS.processData(index2, "00000002", query, false), DBMS.processData(name2, "00000010", query, false));
            myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();
            
            /*for (int i = 1; i < 100; i++)
            {
                query = String.Format("INSERT INTO PERSONS (index, name) VALUES ({0}, {1})", index3, name2);
                query = String.Format("INSERT INTO PERSONS (index, name) VALUES ({0}, {1})", DBMS.processData(index3, "00000004", query, false), DBMS.processData(name2, "00000010", query, false));
                myCommand = new MockSqlCommand(query, myConnection);
                myCommand.ExecuteScalar();
            }*/

            query = String.Format("INSERT INTO USER (name, password) VALUES ({0}, 123)", name1);
            query = String.Format("INSERT INTO USER (name, password) VALUES ({0}, 123)", DBMS.processData(name1, "00000008", query, false));
            myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();
        
            
            query = String.Format("UPDATE PERSONS SET name = {0} WHERE index = {1}", name1, index2);
            query = String.Format("UPDATE PERSONS SET name = {0} WHERE index = {1}", DBMS.processData(name1, "00000008", query, true), DBMS.processData(index2, "00000002", query, true));
            myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();
          
            
            query = String.Format("DELETE FROM PERSONS WHERE index = {0}", index1);
            //query = String.Format("DELETE FROM PERSONS WHERE index = {0}", DBMS.processData(index1, "00000001", query, true));
            myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();


            query = String.Format("SELECT PERSONS.name, USER.password, PERSONS.index FROM PERSONS, USER WHERE USER.name=PERSONS.name AND PERSONS.index = {0}", DBMS.processData(index2, "00000004", query, true));
            myCommand = new MockSqlCommand(query, myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("PERSONS.name: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
                Console.WriteLine("USER.password: " + myReader[2]);
                Console.WriteLine("tag: " + myReader[3]);
                Console.WriteLine("PERSONS.index: " + myReader[4]);
                Console.WriteLine("tag: " + myReader[5]);
            }


            query = String.Format("SELECT LAST(index) FROM PERSONS WHERE name = {0}", name1);
            query = String.Format("SELECT LAST(index) FROM PERSONS WHERE name = {0}", DBMS.processData(name1, "00000008", query, true));
            myCommand = new MockSqlCommand(query, myConnection);

            object resultSet = myCommand.ExecuteScalar();
            //Console.WriteLine("last index: " + resultSet.ToString());

          
            query = String.Format("SELECT name, index FROM PERSONS WHERE name = {0}", name2);
            query = String.Format("SELECT name, index FROM PERSONS WHERE name = {0}", DBMS.processData(name2, "00000010", query, true));
            myCommand = new MockSqlCommand(query, myConnection);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("name: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
                Console.WriteLine("index: " + myReader[2]);
                Console.WriteLine("tag: " + myReader[3]);
            }
            sw.Stop();
            Console.WriteLine("time: " + sw.ElapsedMilliseconds.ToString());

            query = "SELECT name, index FROM PERSONS WHERE 1 = 1";
            myCommand = new MockSqlCommand(query, myConnection);

            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("name: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
                Console.WriteLine("index: " + myReader[2]);
                Console.WriteLine("tag: " + myReader[3]);
            }
           
            Console.ReadKey(true);

        }
    }
}
