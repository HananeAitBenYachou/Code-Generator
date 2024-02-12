using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneratorDataAccesLayer
{
    public static class clsCodeGeneratorData
    {
        public static DataTable GetAllSystemDatabases()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Name as Databases
                             FROM SYS.DATABASES
                             WHERE database_id > 4;";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable databasesDataTable = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader(); 

                if (reader.HasRows)
                {
                    databasesDataTable.Load(reader);
                }
            }
            catch (Exception ex) {}
            
            finally
            {
                reader.Close();
                connection.Close(); 
            }

            return databasesDataTable;
        }

        public static DataTable GetAllDatabaseTables(string DatabaseName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = $"USE [{DatabaseName}];" +
               @"SELECT TABLE_NAME as Tables
                 FROM INFORMATION_SCHEMA.TABLES
                 WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME <> 'sysdiagrams';";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable TablesDataTable = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    TablesDataTable.Load(reader);
                }
            }
            catch (Exception ex) { }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return TablesDataTable;
        }

        public static DataTable GetAllTableColumns(string DatabaseName , string TableName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = $@"USE {DatabaseName}; 
                             SELECT COLUMN_NAME as 'Column Name' , DATA_TYPE as 'Data Type', IS_NULLABLE as 'Is Nullable'
                             FROM INFORMATION_SCHEMA.COLUMNS
                             WHERE TABLE_NAME = @TableName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TableName", TableName);

            SqlDataReader reader = null;

            DataTable ColumnsDataTable = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ColumnsDataTable.Load(reader);
                }
            }
            catch (Exception ex) { }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return ColumnsDataTable;
        }

        public static DataTable GetAllTableColumnsWithDataTypePrecision(string DatabaseName, string TableName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = $@"USE {DatabaseName}; 
                             SELECT 
                                COLUMN_NAME as 'Column Name',
	                            CASE 
	                            WHEN CHARACTER_MAXIMUM_LENGTH IS NULL THEN DATA_TYPE
	                            WHEN CHARACTER_MAXIMUM_LENGTH IS NOT NULL THEN DATA_TYPE +'('+ CAST(CHARACTER_MAXIMUM_LENGTH AS NVARCHAR) + ')'
                                END AS 'Data Type'
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_NAME = @TableName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TableName", TableName);

            SqlDataReader reader = null;

            DataTable ColumnsDataTable = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ColumnsDataTable.Load(reader);
                }
            }
            catch (Exception ex) { }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return ColumnsDataTable;
        }

    }
}
