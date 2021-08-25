using System;
//using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MockDBMSCE.Mock.System.Data
{
    public class MockDataRow
    {
        public object[] records;
        public MockDataTable table;
        //MockDataRow[i]

        public MockDataRow(MockDataTable t, object[] rec)
        {
            table = t;
            records = rec;
        }

        public object this [int i]
        {
          get
          {
              return records[i];
          }
          
        }
        public object this[string s]
        {
            get
            {
                return Field<object>(s);
            }

        }

        public T Field<T>(string p)
        {
            int index = table.columns.IndexOf(p);
            String type = this.GetType().Name;
            if (index == -1)
                throw new Exception("No Column found : " + p);
            else  return (T)this[index];
            
        }
    }
}
