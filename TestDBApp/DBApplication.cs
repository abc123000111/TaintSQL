using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using MockDBMS;
using MockDBMS.SqlServer;
using MockDBMS.SqlCeServer;

namespace MyApplication
{
    [PexClass, TestClass]
    public class DBApplication
    {
        public static void TestMe()
        {

            MockSqlConnection myConnection = new MockSqlConnection("");     // Creates the (singleton) DBMS object

            myConnection.Open();   // Initializes the database state

            MockSqlCommand myCommand = new MockSqlCommand("SELECT firstname, x FROM persons WHERE lastname = 'Smith'", myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader[0].Equals("John"))
                {
                    //myCommand = new MockSqlCommand("SELECT firstname FROM persons WHERE lastname = 'smith'", myConnection);
                    myCommand = new MockSqlCommand("SELECT salary FROM salary WHERE firstname = 'John' AND lastname = 'Smith'", myConnection);
                    /*int salary = (int)myCommand.ExecuteScalar();
                    if (salary < 0)
                        PexAssert.ReachEventually("Negative Salary for John!!");*/
                }
                else if (myReader[0].Equals("Tom"))
                {
                    string command = String.Format("SELECT salary FROM salary WHERE x = {0}", myReader[1]);
                    myCommand = new MockSqlCommand(command, myConnection);
                    /*int salary = (int)myCommand.ExecuteScalar();
                    if (salary < 0)
                        PexAssert.ReachEventually("Negative Salary for Tom!!");*/
                }
            }
        }

       
        public static string ExampleProgram(int k, string[] names)
        {
            MockSqlConnection myConnection = new MockSqlConnection("");
            myConnection.Open();
            MockSqlCommand myCommand = new MockSqlCommand("DELETE FROM PERSONS WHERE index > 0", myConnection);
            myCommand.ExecuteScalar();
            for (int i = 0; i < k; i++)
            {
                String query = String.Format("INSERT INTO PERSONS (index, name) VALUES (({0}, {1}))", i, names[i]);
                myCommand = new MockSqlCommand(query, myConnection);
                myCommand.ExecuteScalar();
            }
            myCommand = new MockSqlCommand("SELECT name FROM PERSONS WHERE index = 5", myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                //throw new PexGoalException();
                if (myReader[0].Equals("John"))
                {
                    PexAssert.ReachEventually();
                }
            }
            return PexSymbolicValue.GetPathConditionString();
        }
        
        public static void Main()
        {
            /*
            string[] names = new string[1];
            names[0] = "John";
            ExampleProgram(1, names); 
            */
            MockSqlConnection myConnection = new MockSqlConnection("");
            myConnection.Open();

            
            //MockSqlCommand myCommand = new MockSqlCommand("SELECT count(*) FROM persons WHERE lastname = \"Smith\" AND NOT x < 6", myConnection);
            //MockSqlCommand myCommand = new MockSqlCommand("SELECT firstname FROM persons WHERE x = 100 AND lastname = 'bob_y'", myConnection);
            //MockSqlCommand myCommand = new MockSqlCommand("SELECT distinct SignsSyms.SignSymText, SignsSyms.SignSymID FROM SignsSyms, ChiefComplaintToSignsSyms where ChiefComplaintToSignsSyms.CCID = 100 and ChiefComplaintToSignsSyms.SignSymID = SignsSyms.SignSymID order by SignsSyms.SignSymText", myConnection);
            //MockSqlCommand myCommand = new MockSqlCommand("SELECT sum(AssessmentSignsSymWeights.Weight) FROM AssessmentSignsSymWeights INNER JOIN SignsSyms ON AssessmentSignsSymWeights.SignSymID = SignsSyms.SignSymID WHERE AssessmentSignsSymWeights.AssessID = 1 AND (SignsSyms.SignSymText = 'a' OR SignsSyms.SignSymText = 'b')", myConnection);
            
            //MockSqlCommand myCommand = new MockSqlCommand("SELECT SignsSyms.SignSymText, SignsSyms.SignSymID FROM SignsSyms, PhysFindingsToSignsSyms, PhysFindings where PhysFindingsToSignsSyms.PFID = PhysFindings.PFID AND PhysFindingsToSignsSyms.SignSymID = SignsSyms.SignSymID AND PhysFindings.PFID = 17 and PhysFindings.SystemID = 0", myConnection);
            // MG this query throws exception

            MockSqlCommand myCommand = new MockSqlCommand("DELETE FROM persons WHERE lastname = \"Smith\"", myConnection);
            //MockSqlCommand myCommand = new MockSqlCommand("INSERT INTO persons (serial, lastname, x) VALUES (1005, \"smith\", 10)", myConnection);
            //MockSqlCommand myCommand = new MockSqlCommand("UPDATE persons SET lastname = 'Smith', firstname = 'John' WHERE x=10", myConnection);
            
            // MG: Failure in this line 
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            int c = myReader.records.Count;
            if (c == 1)
                PexAssert.ReachEventually("Ye : 1");
            else if (c == 2)
                PexAssert.ReachEventually("Ye : 2");
            //myReader.Rea
            //myCommand = new MockSqlCommand("SELECT salary FROM salaryTable WHERE x = 100 AND lastname = 'bob_y'", myConnection);
            /*
             * int c = myReader.records.Count;
            if (c == 1)
                throw new PexGoalException("Ye : 1");
            else if( c == 3  )
                throw new PexGoalException("Yes: ");
            */

           // SqlCommand command = new SqlCommand();
           
            //SqlCommand command;
            //command.ExecuteScalar()
            //tailor.
        }
        

        /*
        [PexMethod]
        public static void Main(String name)
        {

            MockSqlConnection myConnection = new MockSqlConnection("user id=username;" +
                       "password=password;server=serverurl;" +
                       "Trusted_Connection=yes;" +
                       "database=database; " +
                       "connection timeout=30");

            try
            {
                myConnection.Open();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            MockSqlCommand myCommand = new MockSqlCommand("INSERT INTO persons (serial, lastname, x) VALUES (1005, \"smith\", 10)", myConnection);

            MockSqlCommand myCommand = new MockSqlCommand("SELECT serial, firstname FROM persons WHERE lastname = \"smith\"", myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            
            
            while (myReader.Read())
            {
                String serial = myReader[0].ToString();
                myCommand = new MockSqlCommand("SELECT salary FROM SalaryTable WHERE serial = \"" + serial + "\" AND salary > 100 ", myConnection);
                MockSqlDataReader myReader2 = myCommand.ExecuteReader();
                if (myReader2.HasRows())
                {
                    if(myReader2.records.Count == 2)
                        throw new PexGoalException();
                }
            }
        }*/
    

    }
    [PexClass, TestClass]
    public partial class PexTestClass
    {
        [PexMethod(MaxBranches = 20000)]
        public void ExecuteQuery()
        {
            MockSqlConnection myConnection = new MockSqlConnection("");
            myConnection.Open();
            MockSqlCommand myCommand = new MockSqlCommand("DELETE FROM persons WHERE firstname = ’John’ AND lastname = ’Smith’ AND age>25", myConnection);
            myCommand.ExecuteScalar();
            myCommand = new MockSqlCommand("SELECT firstname, lastname FROM persons WHERE age > 25", myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader[0].Equals("John") && myReader[1].Equals("Smith"))
                {
                    PexAssert.ReachEventually("1");
                }
                else if (myReader[0].Equals("Tom") && myReader[1].Equals("Smith")) 
                {
                    PexAssert.ReachEventually("2");
                }
            }
        }

        [PexMethod]
        public string getRole(int mid, string role)
        {
            
            MockSqlConnection myConnection = new MockSqlConnection("");
            myConnection.Open();
            // MockSqlCommand myCommand = new MockSqlCommand("DELETE FROM persons WHERE firstname = ’John’ AND lastname = ’Smith’ AND age>25", myConnection);
            //myCommand.ExecuteScalar();
            MockSqlCommand myCommand = new MockSqlCommand("SELECT Role FROM Users WHERE MID = 5 AND Role = 'mrole'", myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            string symbolicValue = PexSymbolicValue.GetPathConditionString();
            File.WriteAllText(@"C:\MODA.txt", "" + PexSymbolicValue.IsSymbolic<MockSqlCommand>(myCommand));
            while (myReader.Read())
            {
                if (myReader[0].Equals("MYROLE"))
                {
                    PexAssert.ReachEventually("1");
                }
            }
            return symbolicValue;
        }


        [PexMethod(MaxBranches = 1000000000, MaxConditions = 1000000000, Timeout = 480, MaxRunsWithoutNewTests = 400, MaxConstraintSolverTime = 6), TestMethod]
        //[PexExpectedException()]
        public void TestMain()
        {
            DBApplication.Main();
        }
        [PexMethod(MaxBranches = 1000000000, MaxConditions = 1000000000, Timeout = 480, MaxRunsWithoutNewTests = 400, MaxConstraintSolverTime = 6), TestMethod]
        public void testMe()
        {
            DBApplication.TestMe();
        }


        [PexMethod(MaxBranches = 40000)]
        public string testExample(int k, string[] n)
        {
            
            PexAssume.IsTrue(k>=0 && k<=6);
            PexAssume.IsTrue(n != null && n.Length == k);
            for (int i = 0; i < n.Length; i++)
            {
                PexAssume.IsTrue(n[i] != null && n[i].Length>0);            
            }
        
           /* string[] n = new string[k]; 
            
            for (int i = 0; i < k; i++)
            {
                n[i] = "John";
            }*/
            DBApplication.ExampleProgram(k, n);
            return PexSymbolicValue.GetPathConditionString();
        }

        [PexMethod]
        public void TestpexChoose()
        {
            //var chooser = PexChoose.FromCall(this);
            string value = PexChoose.Value<string>("letsC");
            if (value.Equals("abcde"))
                PexAssert.ReachEventually();
            string value2 = PexChoose.Value<string>("letsC2");
            if (value2.Equals("uvwxyz"))
                PexAssert.ReachEventually();
        }

        [PexMethod(MaxBranches = 40000)]
        public void TestOdysseyCreateFavorite(int passwordId, int folderId)
        {
            PexAssume.IsTrue(passwordId > 0 && folderId > 0 && passwordId < 10 && folderId < 10);
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();

            string sql = "insert into Favorite (PasswordId,FolderId) VALUES ({0}, {1})";
            string query = String.Format(sql, DBMS.processData(passwordId, "00000001", sql, false), DBMS.processData(folderId, "00000010", sql, false));
            MockSqlCommand myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();

            query = "SELECT * FROM Favorite WHERE 1 = 1";
            myCommand = new MockSqlCommand(query, myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("PasswordId: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
                Console.WriteLine("FolderId: " + myReader[2]);
                Console.WriteLine("tag: " + myReader[3]);
            }
        }

        [PexMethod(MaxBranches = 40000)]
        public void TestOdysseyGetExistingFaves(int passwordId)
        {
            PexAssume.IsTrue(passwordId > 0 && passwordId < 10);
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();

            string query = "select * from Favorite where 1=1";
            MockSqlCommand myCommand = new MockSqlCommand(query, myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader[0].Equals(passwordId) && Convert.ToInt32(myReader[2]) > 0)
                {
                    PexAssert.ReachEventually();
                }
            }

            string sql = "select FolderId from Favorite where PasswordId={0}";
            query = String.Format(sql, DBMS.processData(passwordId, "00000001", sql, true));
            myCommand = new MockSqlCommand(query, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("FolderId: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
            }
        }

        [PexMethod(MaxBranches = 40000)]
        public void TestOdysseyUpdateField(string name, string value, int order, int id)
        {
            PexAssume.IsTrue(name == "lw" && value == "123");
            PexAssume.IsTrue(order > 0 && order < 10 && id > 0 && id < 10);
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();

            string query = "select * from StringField where 1=1";
            MockSqlCommand myCommand = new MockSqlCommand(query, myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader[10].Equals(id) && Convert.ToInt32(myReader[8]) > 0)
                {
                    PexAssert.ReachEventually();
                    Console.WriteLine("order!!： " + myReader[8]);
                }
            }

            string sql = "update StringField set Name={0}, Value={1}, Orde={2} where Id={3}";
            query = String.Format(sql, DBMS.processData(name, "00000001", sql, true), DBMS.processData(value, "00000010", sql, true), DBMS.processData(order, "00000100", sql, true), DBMS.processData(id, "00001000", sql, true));
            myCommand = new MockSqlCommand(query, myConnection);
            myCommand.ExecuteScalar();

            sql = "select * from StringField where 1=1";
            myCommand = new MockSqlCommand(sql, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("Name: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
                Console.WriteLine("Value: " + myReader[2]);
                Console.WriteLine("tag: " + myReader[3]);
                Console.WriteLine("Order: " + myReader[8]);
                Console.WriteLine("tag: " + myReader[9]);
            }
        }

        [PexMethod(MaxBranches = 40000)]
        public void TestOdysseyGetFolderByPasswordId(int passwordId)
        {
            PexAssume.IsTrue(passwordId > 0 && passwordId < 10);
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();

            string query = "select Favorite.PasswordId, Favorite.FolderId, Folder.Id, Folder.Orde, Folder.ParentId, Folder.Name from Favorite, Folder where 1=1";
            MockSqlCommand myCommand = new MockSqlCommand(query, myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader[4].Equals(myReader[2]) && myReader[0].Equals(passwordId) && myReader[10].Equals("lw"))
                {
                    PexAssert.ReachEventually();
                }
            }

            string sql = "select Folder.Orde, Folder.ParentId, Folder.Name, Folder.Id, Favorite.PasswordId, Favorite.FolderId from Folder, Favorite where Folder.Id=Favorite.FolderId and Favorite.PasswordId={0}";
            query = String.Format(sql, DBMS.processData(passwordId, "00000001", sql, true));
            myCommand = new MockSqlCommand(query, myConnection);
            myReader = myCommand.ExecuteReader();
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
                Console.WriteLine("foid: " + myReader[10]);
                Console.WriteLine("tag: " + myReader[11]);
            }
        }

        [PexMethod(MaxBranches = 80000)]
        public void TestMarketMSIsRightPassword(int LoginId, string LoginPassword)
        {
            PexAssume.IsTrue(LoginId == 4 && LoginPassword == "lw");
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();

            MockSqlCommand myCommand = new MockSqlCommand("insert into SysAdmins(LoginId,LoginPassword,AdminName,AdminStatus,RoleId) values(4,\"lw\",\"d\",2,3)", myConnection);
            myCommand.ExecuteScalar();

            string sql = "select count(*) from SysAdmins where LoginId={0} and LoginPassword={1}";
            string query = String.Format(sql, DBMS.processData(LoginId, "00000001", sql, true), DBMS.processData(LoginPassword, "00000010", sql, true));
            myCommand = new MockSqlCommand(query, myConnection);
            Console.WriteLine(myCommand.ExecuteScalar().ToString());
        }


        [PexMethod(MaxBranches = 80000)]
        public void TestMarketMSShowAllCheckInLogByID(string ID)
        {
            PexAssume.IsTrue(ID == "lw");
            MockSqlConnection myConnection = new MockSqlConnection("user id=username;password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30");
            myConnection.Open();

            string query = "select check_in.ID_CARD,roomer_management.ID_CARD from roomer_management,check_in where 1=1";
            MockSqlCommand myCommand = new MockSqlCommand(query, myConnection);
            MockSqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader[0].Equals(myReader[2]) && myReader[2].Equals(ID))
                {
                    PexAssert.ReachEventually();
                }
            }

            string sql = "SELECT check_in.ROOM_NAME,roomer_management.NAME,check_in.ID_CARD,check_in.STATE,check_in.IN_TIME,check_in.OUT_TIME FROM roomer_management,check_in where check_in.ID_CARD = roomer_management.ID_CARD and roomer_management.ID_CARD = {0}";
            query = String.Format(sql, DBMS.processData(ID, "00000001", sql, true));
            myCommand = new MockSqlCommand(query, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                Console.WriteLine("ROOM_NAME: " + myReader[0]);
                Console.WriteLine("tag: " + myReader[1]);
                Console.WriteLine("Name: " + myReader[2]);
                Console.WriteLine("tag: " + myReader[3]);
                Console.WriteLine("ID_CARD: " + myReader[4]);
                Console.WriteLine("tag: " + myReader[5]);
                Console.WriteLine("STATE: " + myReader[6]);
                Console.WriteLine("tag: " + myReader[7]);
                Console.WriteLine("IN_TIME: " + myReader[8]);
                Console.WriteLine("tag: " + myReader[9]);
                Console.WriteLine("OUT_TIME: " + myReader[10]);
                Console.WriteLine("tag: " + myReader[11]);
            }
        }

    }
 
}
