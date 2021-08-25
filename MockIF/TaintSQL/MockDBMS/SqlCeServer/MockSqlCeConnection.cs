using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MockDBMSCE.SqlCeServer;

namespace MockDBMS.SqlCeServer
{
    public enum MockConnectionState { Closed, Open};

    public class MockSqlCeConnection
    {
        MockDBMS.DBMS dbms;
        MockConnectionState state;

        public MockConnectionState State
        {
            get { return state; }
            set { state = value; }
        }

        public MockDBMS.DBMS Dbms
        {
            get { return dbms; }
            set { dbms = value; }
        }
        public MockSqlCeConnection(string s)
        {
            dbms = new MockDBMS.DBMS();
            state = MockConnectionState.Closed;
        }
        public void Open()
        {
            dbms.CreateDatabaseState();
            state = MockConnectionState.Open;
        }
        public void Close()
        {
            state = MockConnectionState.Closed;
        }

        public MockSqlCeCommand CreateCommand()
        {
            MockSqlCeCommand command = new MockSqlCeCommand(this);
            return command;
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public MockSqlTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
