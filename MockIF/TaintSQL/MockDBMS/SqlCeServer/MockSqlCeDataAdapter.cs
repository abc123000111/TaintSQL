using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using MockDBMS.SqlServer;
using MyApplication;
using MockDBMSCE.Mock.System.Data;

namespace MockDBMS.SqlCeServer
{
    public class MockSqlCeDataAdapter :IDisposable
    {
        string query;
        MockSqlCeConnection connection;
        DataSet queryResult;
        DataTableMappingCollection dataTableMapping;
        MissingSchemaAction missingAction;
        MockSqlCeCommand cmd;
        //
        // Summary:
        //     Gets a collection that provides the master mapping between a source table
        //     and a System.Data.DataTable.
        //
        // Returns:
        //     A collection that provides the master mapping between the returned records
        //     and the System.Data.DataSet. The default value is an empty collection.
        public DataTableMappingCollection TableMappings { get { return dataTableMapping;} }

        //
        // Summary:
        //     Determines the action to take when existing System.Data.DataSet schema does
        //     not match incoming data.
        //
        // Returns:
        //     One of the System.Data.MissingSchemaAction values. The default is Add.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     The value set is not one of the System.Data.MissingSchemaAction values.
        public MissingSchemaAction MissingSchemaAction 
        {
            get { return missingAction; }
            set { missingAction = value; } 
        }


        public MockSqlCeDataAdapter(string command, MockSqlCeConnection connection)
        {
            query = command;
            this.connection = connection;
        }

        public MockSqlCeDataAdapter(MockSqlCeCommand command)
        {
            query = command.CommandText;
            this.connection = command.connection;
            cmd = command;
            //this.connection = connection;
        }

        //
        // Summary:
        //     Adds or refreshes rows in the System.Data.DataSet to match those in the data
        //     source using the System.Data.DataSet and System.Data.DataTable names.
        //
        // Parameters:
        //   dataSet:
        //     A System.Data.DataSet to fill with records and, if necessary, schema.
        //
        //   srcTable:
        //     The name of the source table to use for table mapping.
        //
        // Returns:
        //     The number of rows successfully added to or refreshed in the System.Data.DataSet.
        //     This does not include rows affected by statements that do not return rows.
        //
        // Exceptions:
        //   System.SystemException:
        //     The source table is invalid.
        public int Fill(DataSet dataSet, string srcTable)
        {
            throw new NotImplementedException();
            return - 1;
        }

        public void Fill(MockDataTable table)
        {

            MockSqlCeDataReader reader = cmd.ExecuteReader();
            List<string> tableNamesInQuery = cmd.parsedQuery.TableNames;
            MockDBMS.DBMS dbms = cmd.connection.Dbms;
            table.dbms = dbms;
            table.tablesInQuery = tableNamesInQuery;
            table.columns = cmd.selectedColumns;

            List<object[]> records = reader.records;
            foreach (object[] record in records)
                table.records.Add(new MockDataRow(table, record));
            //throw new NotImplementedException();
        }

        #region IDisposable Members

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
