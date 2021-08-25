using System;
//using System.Linq;
using System.Collections.Generic;
using System.Text;
using MockDBMS.SqlServer;
using MockDBMS.SqlCeServer;

namespace MockDBMSCE.SqlCeServer
{
    public class MockSqlCeParameterCollection
    {
        List<object> parameters;
        MockSqlCeCommand command;
        public MockSqlCeParameterCollection(MockSqlCeCommand cmd)
        {
            parameters = new List<object>();
            this.command = cmd;
        }

        public void AddWithValue(string p, object p_2)
        {
            if(p_2 is String)
                command.CommandText = command.CommandText.Replace(p, "'" + p_2.ToString() + "'");
            else
                command.CommandText = command.CommandText.Replace(p, p_2.ToString());

        }
    }
}
