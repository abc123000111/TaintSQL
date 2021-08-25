using System;
using System.Collections.Generic;
using System.Text;

namespace MockDBMS.SqlServer
{
    public class MockSqlDataReader
    {
        public List<object[]> records;
        int currentIndex = -1;
        object[] currentRecord; 

        private List<object[]> Records
        {
            get { return records; }
            set { records = value; }
        }
        public MockSqlDataReader(List<object[]> records)
        {
            this.records = records;
        }

        public bool HasRows()
        {
            if (records.Count !=0 )
                return true;
            else
                return false;
        }


        // Summary:
        //     Gets the value of the specified column in its native format given the column
        //     ordinal.
        //
        // Parameters:
        //   i:
        //     The zero-based column ordinal.
        //
        // Returns:
        //     The value of the specified column in its native format.
        //
        // Exceptions:
        //   System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public object this[int i] 
        {       
            get 
            {
                if (currentRecord == null)
                {
                    throw new Exception("Not expected to be null");
                }
                return currentRecord[i]; 
            } 
        }
        public object this[string name] 
        {
            get { throw new NotImplementedException(); }
        }

        //
        // Summary:
        //     Advances the System.Data.SqlClient.SqlDataReader to the next record.
        //
        // Returns:
        //     true if there are more rows; otherwise false.
        public bool Read()
        {
            if (currentIndex == records.Count - 1)
                return false;
            currentRecord = records[++currentIndex];
            return true;
        }

    }
}
