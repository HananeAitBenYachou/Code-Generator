using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGeneratorDataAccesLayer;

namespace CodeGeneratorBusinessLayer
{
    public static class clsCodeGenerator
    {
        public static DataTable ListDatabases()
        {
            return clsCodeGeneratorData.GetAllSystemDatabases();
        }

        public static DataTable ListDatabaseTables(string DatabaseName)
        {
            return clsCodeGeneratorData.GetAllDatabaseTables(DatabaseName);
        }

        public static DataTable ListTableColumns(string DatabaseName, string TableName)
        {
            return clsCodeGeneratorData.GetAllTableColumns(DatabaseName,TableName);
        }

        public static DataTable ListTableColumnsWithDataTypePrecision(string DatabaseName, string TableName)
        {
            return clsCodeGeneratorData.GetAllTableColumnsWithDataTypePrecision(DatabaseName, TableName);
        }
    }
}
