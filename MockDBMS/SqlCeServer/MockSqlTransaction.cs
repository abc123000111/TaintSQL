using System;
//using System.Linq;
using System.Collections.Generic;
using System.Text;
using MockDBMS.SqlCeServer;

namespace MockDBMSCE.SqlCeServer
{
    public class MockSqlTransaction :IDisposable
    {
        MockSqlCeCommand command;
        public MockSqlTransaction(MockSqlCeCommand cmd)
        {
            this.command = cmd;
        }


        public void Commit()
        {
            throw new NotImplementedException();
        }

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
