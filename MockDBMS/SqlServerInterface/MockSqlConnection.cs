using System;
using System.Collections.Generic;
using System.Text;

namespace MockDBMS.SqlServer
{
    /// <summary>
    /// MG: This class contains only one MockDBMS.DBMS object
    /// </summary>
    public class MockSqlConnection
    {
        MockDBMS.DBMS dbms;

        public MockDBMS.DBMS Dbms
        {
            get { return dbms; }
            set { dbms = value; }
        }

        public MockSqlConnection(string s)
        {
            dbms = new MockDBMS.DBMS();

        }

        /// <summary>
        /// MG: Initializes the DBMS state of the one and only MockD
        /// </summary>
        public void Open()
        {
            dbms.CreateDatabaseState();
        }
    }
}
