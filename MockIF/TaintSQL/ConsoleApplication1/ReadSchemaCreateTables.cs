using System;
using System.Collections.Generic;
using System.Text;
using MockDBMS;
using MockDBMS.SqlServer;

namespace ExampleCode
{
    class ReadSchemaCreateTables
    {
        /*static void Main(string[] args)
        {
            
            Console.WriteLine("Hello");
            // MG: Example code to read a schema txt file and create mock tables in the mock DBMS
            string schemaFilePath = @"C:\schema.txt";
            List<Table> tables = new List<Table>();
            string[] lines = System.IO.File.ReadAllLines(schemaFilePath);
            Table table = null;
            foreach (string line in lines)
            {
                if (line.Contains("CREATE TABLE"))
                {
                    int i = line.IndexOf("CREATE TABLE");
                    int j = line.IndexOf("(");
                    string tableName = line.Substring(i + 12, j - i - 12).Trim();
                    Console.WriteLine(tableName);
                    table = new Table(tableName);
                    continue;
                }
                DataTypes type = DataTypes.INT;
                int index = -1;
                if (line.Contains("varchar"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("varchar");
                }
                if (line.Contains("VARCHAR"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("VARCHAR");
                }
                if (line.Contains("int"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("int");
                }
                if (line.Contains("INT"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("INT");
                }
                if (line.Contains("enum"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("enum");
                }
                if (line.Contains("ENUM"))
                {
                    type = DataTypes.STRING;
                    index = line.IndexOf("ENUM");
                }
                if (line.Contains("bigint"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("bigint");
                }
                if (line.Contains("BIGINT"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("BIGINT");
                }
                if (line.Contains("TINYINT"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("TINYINT");
                }
                if (line.Contains("tinyint"))
                {
                    type = DataTypes.INT;
                    index = line.IndexOf("tinyint");
                }
                if (index == -1)
                    continue;
                string cname = line.Substring(0, index).Trim();
                Console.WriteLine(cname);
                Console.WriteLine(type);
                table.AddColumn(cname, type);
                table.AddColumn(cname + "$TAINT", DataTypes.STRING);
            }
            
            Console.ReadKey(true);
        }*/
    }
}
