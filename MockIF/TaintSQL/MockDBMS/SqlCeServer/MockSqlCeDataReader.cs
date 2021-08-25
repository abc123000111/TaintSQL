using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication
{
    public class MockSqlCeDataReader
    {
        public List<object[]> records;
        int currentIndex = -1;
        object[] currentRecord;

        private List<object[]> Records
        {
            get { return records; }
            set { records = value; }
        }
        public MockSqlCeDataReader(List<object[]> records)
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


        public bool IsDBNull(int field)
        {
            if (currentRecord[field] == null)
                return true;
            else
                return false;
        }

        public string GetString(int field)
        {
            return currentRecord[field].ToString();
        }

        public DateTime GetDateTime(int field)
        {
            return new DateTime(field);
        }

        public int GetInt32(int field)
        {
            throw new NotImplementedException();
        }

        public bool GetBoolean(int field)
        {
            if (field == 0) return false;
            else return true;
        }

        public object GetValue(int field)
        {
            throw new NotImplementedException();
        }

        public double GetDouble(int field)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            //throw new NotImplementedException();
        }

        public long GetInt64(int field)
        {
            object o = currentRecord[field];
            Int32 i = (int)o;
            
            return (Int64)i;
        }
    }
}
