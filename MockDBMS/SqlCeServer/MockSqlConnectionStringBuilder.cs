using System;
//using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MockDBMSCE.SqlCeServer
{
    public class MockSqlConnectionStringBuilder
    {
        string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        bool encrypt;

        public bool Encrypt
        {
            get { return encrypt; }
            set { encrypt = value; }
        }

        public MockSqlConnectionStringBuilder(string cmd)
        {
            this.connectionString = cmd;
        }
    }
}
