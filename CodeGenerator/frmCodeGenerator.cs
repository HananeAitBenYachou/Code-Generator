using CodeGeneratorBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class frmCodeGenerator : Form
    {
        private string _DatabaseName = "";

        private string _TableName = "";

        private string _TableSingularName = "";

        private DataTable _TableColumns = new DataTable();

        public frmCodeGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _FillDatabasesInComboBox();
            _ResetDefaultValues();
            rbNormal.Checked = true;
        }

        private void _ResetDefaultValues()
        {
            txtGeneratedCode.ResetText();
            cbDatabases.SelectedIndex = 0;
        }

        private void _RefreshTableColumnsList()
        {
            _TableColumns = clsCodeGenerator.ListTableColumns(_DatabaseName, _TableName);
            dgvTableColumnsList.DataSource = _TableColumns;
        }

        private void dgvDatabaseTablesList_SelectionChanged(object sender, EventArgs e)
        {
            _TableName = (string)dgvDatabaseTablesList.CurrentRow.Cells[0].Value;
        }

        private void _FillDatabasesInComboBox()
        {
            DataTable dataTable = clsCodeGenerator.ListDatabases();

            foreach (DataRow row in dataTable.Rows)
            {
                cbDatabases.Items.Add(row["Databases"]);
            }

        }

        private void _FillTablesInComboBox()
        {
            dgvDatabaseTablesList.DataSource = clsCodeGenerator.ListDatabaseTables(_DatabaseName);
        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DatabaseName = cbDatabases.SelectedItem.ToString();
            _FillTablesInComboBox();
        }

        private void txtBusinessLayerPath_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusinessLayerPath.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBusinessLayerPath, "Please provide the path of the data access layer folder");
                return;
            }

            else if (!Directory.Exists(txtBusinessLayerPath.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBusinessLayerPath, "This path does not exist");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBusinessLayerPath, null);
                return;
            }
        }

        private void txtDataAccessLayerPath_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDataAccessLayerPath.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDataAccessLayerPath, "Please provide the path of the data access layer folder");
                return;
            }

            else if (!Directory.Exists(txtDataAccessLayerPath.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDataAccessLayerPath, "This path does not exist");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDataAccessLayerPath, null);
                return;
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            txtDataAccessLayerPath.Enabled = !rbNormal.Checked;
            txtBusinessLayerPath.Enabled = !rbNormal.Checked;

            btnGenerateDataAccessLayer.Enabled = rbNormal.Checked;
            btnGenerateBusinessLayer.Enabled = rbNormal.Checked;

            btnGenerateBothLayers.Enabled = !rbNormal.Checked;
            btnCopy.Enabled = rbNormal.Checked;         
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGeneratedCode.Text))
            {
                Clipboard.SetText(txtGeneratedCode.Text);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateBothLayers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDataAccessLayerPath.Text))
            {
                MessageBox.Show("Please provide the path of the data access layer folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrEmpty(txtBusinessLayerPath.Text))
            {
                MessageBox.Show("Please provide the path of the business layer folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                try
                {
                    _GenerateDataAccessLayerClasses();
                    _GenerateBusinessLayerClasses();

                    MessageBox.Show("Classes for the business layer and data access layer have been generated successfully.", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }

        }

        private void btnGenerateDataAccessLayer_Click(object sender, EventArgs e)
        {
            if (dgvDatabaseTablesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a table from the list ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _RefreshTableColumnsList();
            txtGeneratedCode.ResetText();
            _GenerateDataAccessLayerClass();
        }

        private void btnGenerateBusinessLayer_Click(object sender, EventArgs e)
        {
            if (dgvDatabaseTablesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a table from the list ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _RefreshTableColumnsList();
            txtGeneratedCode.ResetText();
            _GenerateBusinessLayerClass();
        }

        /*************************************/

        private string _GetTableSingularName(string tableName)
        {
            switch (tableName)
            {
                case "People":
                    return "Person";

                case "Countries":
                    return "Country";

                default:
                    return tableName.Substring(0, tableName.Length - 1);
            }
        }

        private void _GenerateDataAccessLayerClass()
        {
            _TableSingularName = _GetTableSingularName(_TableName);

            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append( $"public class cls{_TableSingularName}Data \n" + "{");
            generatedCode.Append("\n" + _GenerateGetByFunction() + "\n");
            generatedCode.Append("\n" + _GenerateIsExistFunction() + "\n");
            generatedCode.Append("\n" + _GenerateAddFunction() + "\n");
            generatedCode.Append("\n" + _GenerateUpdateFunction() + "\n");
            generatedCode.Append("\n" + _GenerateDeleteFunction() + "\n");
            generatedCode.Append("\n" + _GenerateGetAllFunction() + "\n\n");
            generatedCode.Append("}\n");
            generatedCode.Append("}");

            txtGeneratedCode.Text = generatedCode.ToString();
        }

        private string _GenerateDataAccessLayer(string DataAccessNameSpace, string TableSingularName)
        {
            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append($"using System; \n");
            generatedCode.Append("using System.Data; \n");
            generatedCode.Append("using System.Data.SqlClient;\n");

            generatedCode.Append($"\nnamespace {DataAccessNameSpace} \n" + "{");

            generatedCode.Append($"\n\tpublic class cls{TableSingularName}Data \n" + "\t{");

            generatedCode.Append("\n\t\t" + _GenerateGetByFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateIsExistFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateAddFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateUpdateFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateDeleteFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateGetAllFunction() + "\n\n");
            generatedCode.Append("\t}\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private string _GetColumnDataType(object dataType, bool IsNullable = true)
        {
            switch (dataType.ToString().ToLower())
            {
                case "nvarchar":
                case "varchar":
                    return "string";

                case "char":
                    return IsNullable ? "char?" : "char";

                case "int":
                    return IsNullable ? "int?" : "int";

                case "tinyint":
                    return IsNullable ? "byte?" : "byte";

                case "smallint":
                    return IsNullable ? "short?" : "short";

                case "decimal":
                case "money":
                    return IsNullable ? "double?" : "double";

                case "smallmoney":
                    return IsNullable ? "float?" : "float";

                case "datetime":
                case "smalldatetime":
                case "date":
                    return IsNullable ? "DateTime?" : "DateTime";

                case "bit":
                    return IsNullable ? "bool?" : "bool";

                default:
                    return "Unknown";
            }
        }

        private string _GenerateGetByFunction()
        {
            StringBuilder parametersString = new StringBuilder();
            DataRow row = null;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 0)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");

                else
                    parametersString.Append($@", ref {_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");
            }

            string functionSignature = $@"public static bool Get{_TableSingularName}InfoByID ({parametersString})";

            string query = $@"@""SELECT * 
                            FROM {_TableName} 
                            WHERE {_TableColumns.Rows[0]["Column Name"]} = @{_TableColumns.Rows[0]["Column Name"]};""";

            StringBuilder fetchedData = new StringBuilder();

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                fetchedData.Append($@"
                {row["Column Name"]} = (reader[""{row["Column Name"]}""] != DBNull.Value) ? ({_GetColumnDataType(row["Data Type"])}) reader[""{row["Column Name"]}""] : null;");
                fetchedData.Append("\n");
            }

            string generatedCode = $@"{functionSignature} {{
            bool IsFound = false;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();
                    string query = {query};

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {{
                        command.Parameters.AddWithValue(""@{_TableColumns.Rows[0]["Column Name"]}"", (object){_TableColumns.Rows[0]["Column Name"]} ?? DBNull.Value);
                           
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                                if (reader.Read())
                                {{
                                    // The record was found successfully !
                                    IsFound = true;
                                    {fetchedData}                
                                }}
                
                                else 
                                {{
                                    // The record wasn't found !
                                    IsFound = false;
                                }}
                        }}

                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);
                IsFound = false;
            }}
            return IsFound;
            }}";

            return generatedCode;
        }

        private string _GenerateIsExistFunction()
        {
            string functionSignature = $@"public static bool Is{_TableSingularName}Exist ({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"])} {_TableColumns.Rows[0]["Column Name"]})";

            string query = $@"@""SELECT IsFound = 1 
                             FROM {_TableName}
                             WHERE {_TableColumns.Rows[0]["Column Name"]} = @{_TableColumns.Rows[0]["Column Name"]};""";

            string generatedCode = $@"{functionSignature} {{
            bool IsFound = false;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();
                    string query = {query};

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {{                        
                        command.Parameters.AddWithValue(""@{_TableColumns.Rows[0]["Column Name"]}"", (object){_TableColumns.Rows[0]["Column Name"]} ?? DBNull.Value);
                          
                        object reader = command.ExecuteScalar();

                        IsFound = (reader != null);
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);
                IsFound = false;
            }}
            return IsFound;
        }}";

            return generatedCode;
        }

        private string _GenerateUpdateFunction()
        {
            StringBuilder parametersString = new StringBuilder();
            DataRow row = null;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 0)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");

                else
                    parametersString.Append($@", {_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");
            }

            string functionSignature = $@"public static bool Update{_TableSingularName}Info ({parametersString})";

            StringBuilder queryValues = new StringBuilder();

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                queryValues.Append("\n");

                if (i != _TableColumns.Rows.Count - 1)
                    queryValues.Append("\t\t\t\t\t\t\t" + $"{row["Column Name"]} = @{row["Column Name"]},");

                else
                    queryValues.Append("\t\t\t\t\t\t\t" + $"{row["Column Name"]} = @{row["Column Name"]}");
            }

            string query = $@"@""UPDATE {_TableName}
                            SET {queryValues}
                            WHERE {_TableColumns.Rows[0]["Column Name"]} = @{_TableColumns.Rows[0]["Column Name"]};""";

            StringBuilder commandParameters = new StringBuilder();

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                commandParameters.Append($@"command.Parameters.AddWithValue(""@{row["Column Name"]}"",(object) {row["Column Name"]} ?? DBNull.Value);");

                commandParameters.Append("\n");
            }

            string generatedCode = $@"{functionSignature} {{
            int rowsAffected = 0;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();
                    string query = {query};

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {{
                        
                        {commandParameters}
                        rowsAffected = command.ExecuteNonQuery();

                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);
                rowsAffected = 0;
            }}
            return rowsAffected != 0;
        }}";

            return generatedCode;
        }

        private string _GenerateGetAllFunction()
        {
            string functionSignature = $@"public static DataTable GetAll{_TableName} ()";

            string query = $@"""SELECT * FROM {_TableName};""";

            string generatedCode = $@"{functionSignature} {{
            DataTable Datatable = new DataTable(); 

            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();
                    string query = {query};

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {{
                                                   
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                            if(reader.HasRows)
                 	        {{
                    		    Datatable.Load(reader); 
                	        }}        
                        }}

                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);
            }}
            return Datatable;
         }}";

            return generatedCode;
        }

        private string _GenerateDeleteFunction()
        {
            string functionSignature = $@"public static bool Delete{_TableSingularName} ({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"])} {_TableColumns.Rows[0]["Column Name"]})";

            string query = $@"@""DELETE {_TableName}
                              WHERE {_TableColumns.Rows[0]["Column Name"]} = @{_TableColumns.Rows[0]["Column Name"]};""";

            string generatedCode = $@"{functionSignature} {{
            int rowsAffected = 0;

            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();
                    string query = {query};

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {{
                        
                        command.Parameters.AddWithValue(""@{_TableColumns.Rows[0]["Column Name"]}"", (object){_TableColumns.Rows[0]["Column Name"]} ?? DBNull.Value);
                          
		                rowsAffected = command.ExecuteNonQuery(); 
                        
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);
            }}
            return rowsAffected != 0;
         }}";

            return generatedCode;
        }

        private string _GenerateAddFunction()
        {
            StringBuilder parametersString = new StringBuilder();

            DataRow row = null;

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 1)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");

                else
                    parametersString.Append($", {_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");
            }

            string functionSignature = $@"public static int? AddNew{_TableSingularName} ({parametersString})";

            StringBuilder queryParameters = new StringBuilder();
            StringBuilder queryValues = new StringBuilder();

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 1)
                {
                    queryParameters.Append($"{row["Column Name"]}");
                    queryValues.Append($@"@{row["Column Name"]}");
                }
                else
                {
                    queryParameters.Append($",{row["Column Name"]}");
                    queryValues.Append($@",@{row["Column Name"]}");
                }
            }

            string query = $@"@""INSERT INTO {_TableName} ({queryParameters})
                            VALUES ({queryValues});
                            SELECT SCOPE_IDENTITY();""";

            StringBuilder commandParameters = new StringBuilder();

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                commandParameters.Append($@"command.Parameters.AddWithValue(""@{row["Column Name"]}"",(object) {row["Column Name"]} ?? DBNull.Value);");

                commandParameters.Append(Environment.NewLine);
            }

            string generatedCode = $@"{functionSignature} {{
            {_TableColumns.Rows[0]["Data Type"]}? {_TableColumns.Rows[0]["Column Name"]} = null;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();
                    string query = {query};

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {{
                        
                        {commandParameters}
                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new {_TableColumns.Rows[0]["Column Name"]} was successfully inserted
                        if(InsertedRowID != null && int.TryParse(InsertedRowID.ToString(),out int InsertedID))
                        {{
                            {_TableColumns.Rows[0]["Column Name"]} = InsertedID;
                        }}
                
                        // Set {_TableColumns.Rows[0]["Column Name"]} to null to indicate failure
                        else
                            {_TableColumns.Rows[0]["Column Name"]} = null;

                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);
                {_TableColumns.Rows[0]["Column Name"]} = null;
            }}
            return {_TableColumns.Rows[0]["Column Name"]};
        }}";
            return generatedCode;
        }

        private void _GenerateBusinessLayerClass()
        {
            _TableSingularName = _GetTableSingularName(_TableName);

            StringBuilder generatedCode = new StringBuilder();

            generatedCode.AppendLine($"public class cls{_TableSingularName} \n" + "{");
            generatedCode.Append("\n" + _GenerateBusinessClassFields() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassConstructors() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassFindFunc() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassIsExistFunc() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassAddFunc() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassUpdateFunc() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassSaveFunc() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassDeleteFunc() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassListFunc() + "\n");
            generatedCode.Append("}");

            txtGeneratedCode.Text = generatedCode.ToString();
        }

        private string _GenerateBusinessLayer(string DataAccessNameSpace, string BusinessNameSpace, string TableSingularName)
        {
            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append($"using System; \n");
            generatedCode.Append("using System.Data; \n");
            generatedCode.Append($"using {DataAccessNameSpace};\n");

            generatedCode.Append($"\nnamespace {BusinessNameSpace} \n" + "{");

            generatedCode.Append($"\n\tpublic class cls{TableSingularName} \n" + "\t{");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassFields() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassConstructors() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassFindFunc() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassIsExistFunc() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassAddFunc() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassUpdateFunc() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassSaveFunc() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassDeleteFunc() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassListFunc() + "\n\n");
            generatedCode.Append("\t}\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private string _GenerateBusinessClassFields()
        {
            StringBuilder fields = new StringBuilder();

            fields.Append("private enum enMode {AddNew = 0 , Update = 1}; \n");
            fields.Append("private enMode _Mode;");

            DataRow row = null;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 0)
                    fields.Append($"\npublic {_GetColumnDataType(row["Data Type"])} {row["Column Name"]}" + "{get ; private set;}");

                else
                    fields.Append($"\npublic {_GetColumnDataType(row["Data Type"])} {row["Column Name"]}" + "{get ; set;}");
            }
            return fields.ToString();
        }

        private string _GenerateBusinessClassConstructors()
        {
            return _GenerateParameterlessConstructor() + _GenerateParameterizedConstructor();
        }

        private string _GenerateParameterlessConstructor()
        {
            StringBuilder parameterlessConstructor = new StringBuilder();

            parameterlessConstructor.Append($"public cls{_TableSingularName}() \n");
            parameterlessConstructor.Append("{ \n");
            parameterlessConstructor.Append("_Mode = enMode.AddNew;\n");

            DataRow row = null;
      
            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                parameterlessConstructor.Append($"{row["Column Name"]} = null; \n");
            }

            parameterlessConstructor.Append("}");

            return parameterlessConstructor.ToString();
        }

        private string _GenerateParameterizedConstructor()
        {
            StringBuilder parameterlessConstructor = new StringBuilder();
            StringBuilder parametersString = new StringBuilder();

            DataRow row = null;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                if (i == 0)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");

                else
                    parametersString.Append($@",{_GetColumnDataType(row["Data Type"])} {row["Column Name"]}");
            }

            parameterlessConstructor.Append($"private cls{_TableSingularName}({parametersString})\n");
            parameterlessConstructor.Append("{\n");
            parameterlessConstructor.Append("_Mode = enMode.Update;\n");

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                parameterlessConstructor.Append($"this.{row["Column Name"]} = {row["Column Name"]}; \n");
            }

            parameterlessConstructor.Append("}");

            return parameterlessConstructor.ToString();
        }

        private string _GenerateBusinessClassDeleteFunc()
        {
            StringBuilder generatedCode = new StringBuilder();
            generatedCode.Append($"public static bool Delete{_TableSingularName}({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"], false)} {_TableColumns.Rows[0]["Column Name"]})\n");
            generatedCode.Append("{\n");
            generatedCode.Append($"return cls{_TableSingularName}Data.Delete{_TableSingularName}({_TableColumns.Rows[0]["Column Name"]});\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private string _GenerateBusinessClassListFunc()
        {
            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append($"public static DataTable GetAll{_TableName} ()\n");
            generatedCode.Append("{\n");
            generatedCode.Append($"return cls{_TableSingularName}Data.GetAll{_TableName} ();\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private string _GenerateBusinessClassSaveFunc()
        {
            string generatedCode = "";

            generatedCode = $@"public bool Save()
            {{ 
            switch (_Mode)
            {{
                case enMode.AddNew:
                    if (_AddNew{_TableSingularName}())
                    {{
                        _Mode = enMode.Update;
                        return true;
                    }}
                    return false;

                case enMode.Update:
                    return _Update{_TableSingularName}();

            }}
            return false;
            }}";

            return generatedCode;
        }

        private string _GenerateBusinessClassAddFunc()
        {
            StringBuilder parametersString = new StringBuilder();
            DataRow row = null;

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 1)
                    parametersString.Append($"{row["Column Name"]}");

                else
                    parametersString.Append($@",{row["Column Name"]}");
            }
            string generatedCode = "";

            generatedCode = $@"private bool _AddNew{_TableSingularName}()
            {{
            {_TableColumns.Rows[0]["Column Name"]} = cls{_TableSingularName}Data.AddNew{_TableSingularName}({parametersString});
            return {_TableColumns.Rows[0]["Column Name"]}.HasValue;
            }}";

            return generatedCode;
        }

        private string _GenerateBusinessClassUpdateFunc()
        {
            StringBuilder parametersString = new StringBuilder();
            DataRow row = null;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 0)
                    parametersString.Append($"{row["Column Name"]}");

                else
                    parametersString.Append($@",{row["Column Name"]}");
            }
            string generatedCode = "";

            generatedCode = $@"private bool _Update{_TableSingularName}()
            {{
            return cls{_TableSingularName}Data.Update{_TableSingularName}Info ({parametersString});         
            }}";

            return generatedCode;
        }

        private string _GenerateBusinessClassFindFunc()
        {
            StringBuilder variablesString = new StringBuilder();
            StringBuilder functionParametersString = new StringBuilder();
            StringBuilder constructorParametersString = new StringBuilder();
            DataRow row = null;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                if (i == 0)
                {
                    functionParametersString.Append($"{row["Column Name"]}");
                    constructorParametersString.Append($"{row["Column Name"]}");
                }

                else
                {
                    functionParametersString.Append($@", ref {row["Column Name"]}");
                    constructorParametersString.Append($@",{row["Column Name"]}");
                    variablesString.Append($"{_GetColumnDataType(row["Data Type"])} {row["Column Name"]} = null; \n");
                }
            }

            string generatedCode = "";
            generatedCode = $@"public static cls{_TableSingularName} Find({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"], false)} {_TableColumns.Rows[0]["Column Name"]})
            {{ 
            {variablesString}
            bool IsFound = cls{_TableSingularName}Data.Get{_TableSingularName}InfoByID({functionParametersString});

            if (IsFound)
                return new cls{_TableSingularName}({constructorParametersString});
            else
                return null; 
            }}";

            return generatedCode;
        }

        private string _GenerateBusinessClassIsExistFunc()
        {
            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append($"public static bool Is{_TableSingularName}Exist({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"], false)} {_TableColumns.Rows[0]["Column Name"]})\n");
            generatedCode.Append("{\n");
            generatedCode.Append($"return cls{_TableSingularName}Data.Is{_TableSingularName}Exist({_TableColumns.Rows[0]["Column Name"]});\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private void _GenerateDataAccessLayerClasses()
        {
            string filePath = "";

            string NameSpace = _DatabaseName.Replace("DB", "") + "_" + "DataAccessLayer";

            foreach (DataRow row in clsCodeGenerator.ListDatabaseTables(_DatabaseName).Rows)
            {
                _TableName = (string)row["Tables"];

                _TableColumns = clsCodeGenerator.ListTableColumns(_DatabaseName, _TableName);

                _TableSingularName = _TableName.Substring(0, _TableName.Length - 1);

                filePath = txtDataAccessLayerPath.Text.Trim() + $"cls{_TableSingularName}Data" + ".cs";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(_GenerateDataAccessLayer(NameSpace, _TableSingularName));
                }
            }
        }

        private void _GenerateBusinessLayerClasses()
        {
            string filePath = "";
            string DataAcessLayerNameSpace = _DatabaseName.Replace("DB", "") + "_" + "DataAccessLayer";
            string BusinessLayerNameSpace = _DatabaseName.Replace("DB", "") + "_" + "BusinessLayer";

            foreach (DataRow row in clsCodeGenerator.ListDatabaseTables(_DatabaseName).Rows)
            {
                _TableName = (string)row["Tables"];

                _TableColumns = clsCodeGenerator.ListTableColumns(_DatabaseName, _TableName);

                _TableSingularName = _TableName.Substring(0, _TableName.Length - 1);

                filePath = txtBusinessLayerPath.Text.Trim() + $"cls{_TableSingularName}" + ".cs";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(_GenerateBusinessLayer(DataAcessLayerNameSpace, BusinessLayerNameSpace, _TableSingularName));
                }
            }
        }

    }
}
