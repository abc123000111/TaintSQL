using System;
// using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace MockDBMSCE.Mock.System.Data
{
    public class MockDataTable : IEnumerable<MockDataRow>, IEnumerator<MockDataRow>
    {
        public List<MockDataRow> records;
        public MockDBMS.DBMS dbms;
        public List<string> tablesInQuery = new List<string>();
        public List<string> columns = new List<string>();

        string tableName, tableNamespace;
        int position = 0;


        // Summary:
        //     Initializes a new instance of the System.Data.DataTable class with no arguments.
        public MockDataTable()
        {
            records = new List<MockDataRow>();
        }
        //
        // Summary:
        //     Initializes a new instance of the System.Data.DataTable class with the specified
        //     table name.
        //
        // Parameters:
        //   tableName:
        //     The name to give the table. If tableName is null or an empty string, a default
        //     name is given when added to the System.Data.DataTableCollection.
        public MockDataTable(string tableName)
        {
            this.tableName = tableName;
            records = new List<MockDataRow>();
        }
        //
        // Summary:
        //     Initializes a new instance of the System.Data.DataTable class using the specified
        //     table name and namespace.
        //
        // Parameters:
        //   tableName:
        //     The name to give the table. If tableName is null or an empty string, a default
        //     name is given when added to the System.Data.DataTableCollection.
        //
        //   tableNamespace:
        //     The namespace for the XML representation of the data stored in the DataTable.
        public MockDataTable(string tableName, string tableNamespace)
        {
            this.tableName = tableName;
            this.tableNamespace = tableNamespace;
            records = new List<MockDataRow>();
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        #endregion

        public IEnumerable<DataRow> AsEnumerable()
        {
            return (IEnumerable<DataRow>)this;
            //EnumerableRowCollection<DataRow> collection = new EnumerableRowCollection<DataRow>();
            
        }

        #region IEnumerator Members

        MockDataRow IEnumerator<MockDataRow>.Current
        {
            get { return records[position]; }
        }

        public bool MoveNext()
        {
            if (records == null || position >= records.Count-1)
                return false;
            position++;
            return true;
        }

        public void Reset()
        {
            position = 0;
        }

        #endregion



        

        #region IDisposable Members

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator Members

        object IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IEnumerable<MockDataRow> Members

        IEnumerator<MockDataRow> IEnumerable<MockDataRow>.GetEnumerator()
        {
            return (IEnumerator<MockDataRow>)this;
        }

        #endregion
    }
}
