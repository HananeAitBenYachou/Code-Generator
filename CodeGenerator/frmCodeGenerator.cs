using CodeGeneratorBusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CodeGenerator
{
    public partial class frmCodeGenerator : Form
    {
        private string _DatabaseName = "";

        private string _TableName = "";

        private string _TableSingularName = "";

        private DataTable _TableColumns = new DataTable();

        private DataTable _TableColumnsWithDataTypePrecision = new DataTable();

        public frmCodeGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _FillDatabasesInComboBox();
            _ResetDefaultValues();
            rbNormal.Checked = true;

            //DEMO
            cbDatabases.SelectedIndex = 4;
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
            _RefreshTableColumnsList();

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
            btnGenerateStoredProcedures.Enabled = rbNormal.Checked;

            btnGenerateLayersClasses.Enabled = !rbNormal.Checked;
            btnCopy.Enabled = rbNormal.Checked;

            tabcontrol.SelectedTab = rbNormal.Checked ? tpNormalMode : tpAdvancedMode;
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

        private string ConvertFirstCharacterLowercase(string input)
        {
            char firstChar = char.ToLower(input[0]);
            return firstChar + input.Substring(1);
        }


        #region Data Access Layer

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

        private void _GenerateDataAccessLayerClass()
        {
            _TableSingularName = _GetTableSingularName(_TableName);

            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append( $"public class {_TableSingularName}Data \n" + "{");
            generatedCode.Append("\n" + _GenerateGetByIDFunction() + "\n");
            generatedCode.Append("\n" + _GenerateDoesExistFunction() + "\n");
            generatedCode.Append("\n" + _GenerateAddFunction() + "\n");
            generatedCode.Append("\n" + _GenerateUpdateFunction() + "\n");
            generatedCode.Append("\n" + _GenerateDeleteFunction() + "\n");
            generatedCode.Append("\n" + _GenerateGetAllFunction() + "\n\n");
            generatedCode.Append("}\n");

            txtGeneratedCode.Text = generatedCode.ToString();
        }

        private string _GenerateDataAccessLayer(string DataAccessNameSpace, string TableSingularName)
        {
            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append($"using System; \n");
            generatedCode.Append("using System.Data; \n");
            generatedCode.Append("using System.Data.SqlClient;\n");

            generatedCode.Append($"\nnamespace {DataAccessNameSpace} \n" + "{");

            generatedCode.Append($"\n\tpublic class {TableSingularName}Data \n" + "\t{");

            generatedCode.Append("\n\t\t" + _GenerateGetByIDFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateDoesExistFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateAddFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateUpdateFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateDeleteFunction() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateGetAllFunction() + "\n\n");
            generatedCode.Append("\t}\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private string _GetColumnDataType(object dataType, bool IsNullable = false)
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

        private string _GenerateGetByIDFunction()
        {
            StringBuilder parametersString = new StringBuilder();
            DataRow row = null;
            bool IsNullable = false;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if (i == 0)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"],true)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");

                else
                    parametersString.Append($@", ref {_GetColumnDataType(row["Data Type"],IsNullable)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
            }

            string functionSignature = $@"public static bool Get{_TableSingularName}InfoByID ({parametersString})";

            StringBuilder fetchedData = new StringBuilder();

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if(IsNullable)
                fetchedData.Append($@"
                {ConvertFirstCharacterLowercase(row["Column Name"].ToString())} = (reader[""{row["Column Name"]}""] != DBNull.Value) ? ({_GetColumnDataType(row["Data Type"],true)}) reader[""{row["Column Name"]}""] : null;");
                
                else
                    fetchedData.Append($@"
                {ConvertFirstCharacterLowercase(row["Column Name"].ToString())} = ({_GetColumnDataType(row["Data Type"])}) reader[""{row["Column Name"]}""];");

                fetchedData.Append("\n");
            }

            string storedProcedureName = $"SP_{_TableName}_Get{_TableSingularName}InfoByID";

            string generatedCode = $@"{functionSignature} {{
            bool isFound = false;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();

                    using(SqlCommand command = new SqlCommand(""{storedProcedureName}"",connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue(""@{_TableColumns.Rows[0]["Column Name"]}"", (object) {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())} ?? DBNull.Value);
                           
                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                                if (reader.Read())
                                {{
                                    // The record was found successfully !
                                    isFound = true;
                                    {fetchedData}                
                                }}
                
                                else 
                                {{
                                    // The record wasn't found !
                                    isFound = false;
                                }}
                        }}
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);

                isFound = false;
            }}
            return isFound;
            }}";

            return generatedCode;
        }

        private string _GenerateDoesExistFunction()
        {
            string functionSignature = $@"public static bool Does{_TableSingularName}Exist ({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"],true)} {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())})";

            string storedProcedureName = $"SP_{_TableName}_CheckIf{_TableSingularName}Exists";

            string generatedCode = $@"{functionSignature} {{
            bool isFound = false;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();

                    using(SqlCommand command = new SqlCommand(""{storedProcedureName}"",connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue(""@{_TableColumns.Rows[0]["Column Name"]}"", (object){ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())} ?? DBNull.Value);
                          
                        SqlParameter returnValue = new SqlParameter
                        {{
                              Direction = ParameterDirection.ReturnValue
                        }};

                        command.Parameters.Add(returnValue);

                        command.ExecuteScalar();

                        isFound = (int)returnValue.Value == 1;                      
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);

                isFound = false;
            }}
            return isFound;
        }}";

            return generatedCode;
        }

        private string _GenerateUpdateFunction()
        {
            StringBuilder parametersString = new StringBuilder();
            DataRow row = null;
            bool IsNullable = false;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if (i == 0)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"], true)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");

                else
                    parametersString.Append($@", {_GetColumnDataType(row["Data Type"], IsNullable)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
            }

            string functionSignature = $@"public static bool Update{_TableSingularName}Info ({parametersString})";

            StringBuilder commandParameters = new StringBuilder();

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if(IsNullable)
                   commandParameters.Append($@"command.Parameters.AddWithValue(""@{row["Column Name"]}"",(object) {ConvertFirstCharacterLowercase(row["Column Name"].ToString())} ?? DBNull.Value);");
                else
                    commandParameters.Append($@"command.Parameters.AddWithValue(""@{row["Column Name"]}"",{ConvertFirstCharacterLowercase(row["Column Name"].ToString())});");

                commandParameters.Append("\n");
            }

            string storedProcedureName = $"SP_{_TableName}_Update{_TableSingularName}Info";

            string generatedCode = $@"{functionSignature} {{
            int rowsAffected = 0;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();

                    using(SqlCommand command = new SqlCommand(""{storedProcedureName}"",connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;
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
            string functionSignature = $@"public static DataTable GetAll{_TableName}()";

            string storedProcedureName = $"SP_{_TableName}_GetAll{_TableName}";

            string generatedCode = $@"{functionSignature} {{
            DataTable {ConvertFirstCharacterLowercase(_TableName)} = new DataTable(); 

            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();

                    using(SqlCommand command = new SqlCommand(""{storedProcedureName}"",connection))
                    {{              
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {{
                            if(reader.HasRows)
                 	        {{
                    		    {ConvertFirstCharacterLowercase(_TableName)}.Load(reader); 
                	        }}        
                        }}
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);
            }}
            return {ConvertFirstCharacterLowercase(_TableName)};
         }}";

            return generatedCode;
        }

        private string _GenerateDeleteFunction()
        {
            string functionSignature = $@"public static bool Delete{_TableSingularName} ({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"], true)} {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())})";

            string storedProcedureName = $"SP_{_TableName}_Delete{_TableSingularName}";

            string generatedCode = $@"{functionSignature} {{
            int rowsAffected = 0;

            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();

                    using(SqlCommand command = new SqlCommand(""{storedProcedureName}"",connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue(""@{_TableColumns.Rows[0]["Column Name"]}"", (object){ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())} ?? DBNull.Value);
                          
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
            bool IsNullable = false;

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if (i == 1)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"],IsNullable)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");

                else
                    parametersString.Append($", {_GetColumnDataType(row["Data Type"],IsNullable)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
            }

            string functionSignature = $@"public static int? AddNew{_TableSingularName} ({parametersString})";

            StringBuilder commandParameters = new StringBuilder();

            for (int i = 1; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];

                IsNullable = (string)row["Is Nullable"] == "YES";

                if (IsNullable)
                    commandParameters.Append($@"command.Parameters.AddWithValue(""@{row["Column Name"]}"",(object) {ConvertFirstCharacterLowercase(row["Column Name"].ToString())} ?? DBNull.Value);");
                else
                    commandParameters.Append($@"command.Parameters.AddWithValue(""@{row["Column Name"]}"",{ConvertFirstCharacterLowercase(row["Column Name"].ToString())});");

                commandParameters.Append(Environment.NewLine);
            }

            string storedProcedureName = $"SP_{_TableName}_AddNew{_TableSingularName}";

            string generatedCode = $@"{functionSignature} {{
            {_TableColumns.Rows[0]["Data Type"]}? {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())} = null;
      
            try
            {{
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {{
                    connection.Open();

                    using(SqlCommand command = new SqlCommand(""{storedProcedureName}"",connection))
                    {{          
                        command.CommandType = CommandType.StoredProcedure;
                        {commandParameters}

                        SqlParameter output{_TableColumns.Rows[0]["Column Name"]}Parameter = new SqlParameter(""@New{_TableColumns.Rows[0]["Column Name"]}"", SqlDbType.Int)
                        {{
                            Direction = ParameterDirection.Output
                        }};

                        command.Parameters.Add(output{_TableColumns.Rows[0]["Column Name"]}Parameter);

                        command.ExecuteNonQuery();

                        {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())} = (int)output{_TableColumns.Rows[0]["Column Name"]}Parameter.Value;
                    }}
                }}
            }}
            catch (Exception ex)
            {{
                clsErrorLogger.LogError(ex);

                {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())} = null;
            }}
            return {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())};
        }}";
            return generatedCode;
        }

        #endregion

        #region Business Layer
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

        private void _GenerateBusinessLayerClass()
        {
            _TableSingularName = _GetTableSingularName(_TableName);

            StringBuilder generatedCode = new StringBuilder();

            generatedCode.AppendLine($"public class {_TableSingularName} \n" + "{");
            generatedCode.Append("\n" + _GenerateBusinessClassFields() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassConstructors() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassFindFunc() + "\n");
            generatedCode.Append("\n" + _GenerateBusinessClassDoesExistFunc() + "\n");
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

            generatedCode.Append($"\n\tpublic class {TableSingularName} \n" + "\t{");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassFields() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassConstructors() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassFindFunc() + "\n");
            generatedCode.Append("\n\t\t" + _GenerateBusinessClassDoesExistFunc() + "\n");
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

            fields.Append("private enum EnMode {AddNew = 0 , Update = 1}; \n");
            fields.Append("private EnMode _mode;");

            DataRow row = null;
            bool IsNullable = false;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if (i == 0)
                    fields.Append($"\npublic {_GetColumnDataType(row["Data Type"],true)} {row["Column Name"]}" + "{get ; private set;}");

                else
                    fields.Append($"\npublic {_GetColumnDataType(row["Data Type"], IsNullable)} {row["Column Name"]}" + "{get ; set;}");
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

            parameterlessConstructor.Append($"public {_TableSingularName}() \n");
            parameterlessConstructor.Append("{ \n");
            parameterlessConstructor.Append("_mode = EnMode.AddNew;\n");

            DataRow row = null;
            bool IsNullable = false;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if(i == 0 || IsNullable)
                    parameterlessConstructor.Append($"{row["Column Name"]} = null; \n");
                else
                    parameterlessConstructor.Append($"{row["Column Name"]} = default; \n");
            }

            parameterlessConstructor.Append("}");

            return parameterlessConstructor.ToString();
        }

        private string _GenerateParameterizedConstructor()
        {
            StringBuilder parameterizedConstructor = new StringBuilder();
            StringBuilder parametersString = new StringBuilder();

            DataRow row = null;
            bool IsNullable = false;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if (i == 0)
                    parametersString.Append($"{_GetColumnDataType(row["Data Type"],true)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");

                else
                    parametersString.Append($@",{_GetColumnDataType(row["Data Type"],IsNullable)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
            }

            parameterizedConstructor.Append($"private {_TableSingularName}({parametersString})\n");
            parameterizedConstructor.Append("{\n");
            parameterizedConstructor.Append("_mode = EnMode.Update;\n");

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                parameterizedConstructor.Append($"this.{row["Column Name"]} = {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}; \n");
            }

            parameterizedConstructor.Append("}");

            return parameterizedConstructor.ToString();
        }

        private string _GenerateBusinessClassDeleteFunc()
        {
            StringBuilder generatedCode = new StringBuilder();
            generatedCode.Append($"public static bool Delete{_TableSingularName}({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"], true)} {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())})\n");
            generatedCode.Append("{\n");
            generatedCode.Append($"return {_TableSingularName}Data.Delete{_TableSingularName}({ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())});\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private string _GenerateBusinessClassListFunc()
        {
            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append($"public static DataTable GetAll{_TableName}()\n");
            generatedCode.Append("{\n");
            generatedCode.Append($"return {_TableSingularName}Data.GetAll{_TableName}();\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        private string _GenerateBusinessClassSaveFunc()
        {
            string generatedCode = "";

            generatedCode = $@"public bool Save()
            {{ 
            switch (_mode)
            {{
                case EnMode.AddNew:
                    if (AddNew{_TableSingularName}())
                    {{
                        _mode = EnMode.Update;
                        return true;
                    }}
                    return false;

                case EnMode.Update:
                    return Update{_TableSingularName}();

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

            generatedCode = $@"private bool AddNew{_TableSingularName}()
            {{
            {_TableColumns.Rows[0]["Column Name"]} = {_TableSingularName}Data.AddNew{_TableSingularName}({parametersString});
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

            generatedCode = $@"private bool Update{_TableSingularName}()
            {{
            return {_TableSingularName}Data.Update{_TableSingularName}Info ({parametersString});         
            }}";

            return generatedCode;
        }

        private string _GenerateBusinessClassFindFunc()
        {
            StringBuilder variablesString = new StringBuilder();
            StringBuilder functionParametersString = new StringBuilder();
            StringBuilder constructorParametersString = new StringBuilder();

            DataRow row = null;
            bool IsNullable = false;

            for (int i = 0; i < _TableColumns.Rows.Count; i++)
            {
                row = _TableColumns.Rows[i];
                IsNullable = (string)row["Is Nullable"] == "YES";

                if (i == 0)
                {
                    functionParametersString.Append($"{ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
                    constructorParametersString.Append($"{ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
                }

                else
                {
                    functionParametersString.Append($@", ref {ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
                    constructorParametersString.Append($@",{ConvertFirstCharacterLowercase(row["Column Name"].ToString())}");
                    variablesString.Append($"{_GetColumnDataType(row["Data Type"], IsNullable)} {ConvertFirstCharacterLowercase(row["Column Name"].ToString())} = default; \n");
                }
            }

            string generatedCode = "";
            generatedCode = $@"public static {_TableSingularName} Find({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"], true)} {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())})
            {{ 
            {variablesString}
            bool isFound = {_TableSingularName}Data.Get{_TableSingularName}InfoByID({functionParametersString});

            if (isFound)
                return new {_TableSingularName}({constructorParametersString});
            else
                return null; 
            }}";

            return generatedCode;
        }

        private string _GenerateBusinessClassDoesExistFunc()
        {
            StringBuilder generatedCode = new StringBuilder();

            generatedCode.Append($"public static bool Does{_TableSingularName}Exist({_GetColumnDataType(_TableColumns.Rows[0]["Data Type"], true)} {ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())})\n");
            generatedCode.Append("{\n");
            generatedCode.Append($"return {_TableSingularName}Data.Does{_TableSingularName}Exist({ConvertFirstCharacterLowercase(_TableColumns.Rows[0]["Column Name"].ToString())});\n");
            generatedCode.Append("}");

            return generatedCode.ToString();
        }

        #endregion

        #region Both Layers
        private void _GenerateDataAccessLayerClasses()
        {
            string filePath = "";

            string NameSpace = _DatabaseName.Replace("DB", "") + "_" + "DataAccessLayer";

            foreach (DataRow row in clsCodeGenerator.ListDatabaseTables(_DatabaseName).Rows)
            {
                _TableName = (string)row["Tables"];

                _TableColumns = clsCodeGenerator.ListTableColumns(_DatabaseName, _TableName);

                _TableSingularName = _TableName.Substring(0, _TableName.Length - 1);

                filePath = txtDataAccessLayerPath.Text.Trim() + $"{_TableSingularName}Data" + ".cs";

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

                filePath = txtBusinessLayerPath.Text.Trim() + $"{_TableSingularName}" + ".cs";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(_GenerateBusinessLayer(DataAcessLayerNameSpace, BusinessLayerNameSpace, _TableSingularName));
                }
            }
        }

        private void btnGenerateLayersClasses_Click(object sender, EventArgs e)
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

        #endregion

        #region Stored Procedures
        private void btnGenerateStoredProcedures_Click(object sender, EventArgs e)
        {
            if (dgvDatabaseTablesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a table from the list ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TableColumnsWithDataTypePrecision = clsCodeGenerator.ListTableColumnsWithDataTypePrecision(_DatabaseName, _TableName);
            txtGeneratedCode.ResetText();
            _GenerateTableStoredProcedures();
        }

        private void _GenerateTableStoredProcedures()
        {
            _TableSingularName = _GetTableSingularName(_TableName);

            StringBuilder generatedStoredProcedures = new StringBuilder();

            generatedStoredProcedures.Append(_GenerateGetAllStoredProcedure() + "\n");
            generatedStoredProcedures.Append("--------------------------------------------------------");
            generatedStoredProcedures.Append(_GenerateCheckIfExistsStoredProcedure() + "\n");
            generatedStoredProcedures.Append("--------------------------------------------------------");
            generatedStoredProcedures.Append(_GenerateDeleteStoredProcedure() + "\n");
            generatedStoredProcedures.Append("--------------------------------------------------------");
            generatedStoredProcedures.Append(_GenerateGetInfoByIDStoredProcedure() + "\n");
            generatedStoredProcedures.Append("--------------------------------------------------------");
            generatedStoredProcedures.Append(_GenerateAddNewStoredProcedure() + "\n");
            generatedStoredProcedures.Append("--------------------------------------------------------");
            generatedStoredProcedures.Append(_GenerateUpdateStoredProcedure() + "\n");

            txtGeneratedCode.Text = generatedStoredProcedures.ToString();
        }

        private string _GenerateGetAllStoredProcedure()
        {
            string storedProcedureName = $"SP_{_TableName}_GetAll{_TableName}";

            string generatedStoredProcedure = $@"
CREATE PROCEDURE {storedProcedureName}
AS 
    BEGIN 
        SELECT * FROM {_TableName};
    END
GO";
            return generatedStoredProcedure;

        }

        private string _GenerateCheckIfExistsStoredProcedure()
        {
            string storedProcedureName = $"SP_{_TableName}_CheckIf{_TableSingularName}Exists";

            string generatedStoredProcedure = $@"
CREATE PROCEDURE {storedProcedureName}
    @{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} {_TableColumnsWithDataTypePrecision.Rows[0]["Data Type"].ToString().ToUpper()}
AS 
    BEGIN 
        IF EXISTS(SELECT isFound = 1 FROM {_TableName} WHERE {_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} = @{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]})
            RETURN 1;
        ELSE
            RETURN 0;
    END
GO";
            return generatedStoredProcedure;

        }

        private string _GenerateDeleteStoredProcedure()
        {
            string storedProcedureName = $"SP_{_TableName}_Delete{_TableSingularName}";

            string generatedStoredProcedure = $@"
CREATE PROCEDURE {storedProcedureName}
    @{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} {_TableColumnsWithDataTypePrecision.Rows[0]["Data Type"].ToString().ToUpper()}
AS 
    BEGIN                    
        DELETE FROM {_TableName} WHERE {_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} = @{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]};
    END
GO";
            return generatedStoredProcedure;

        }

        private string _GenerateGetInfoByIDStoredProcedure()
        {
            string storedProcedureName = $"SP_{_TableName}_Get{_TableSingularName}InfoByID";

            string generatedStoredProcedure = $@"
CREATE PROCEDURE {storedProcedureName}
    @{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} {_TableColumnsWithDataTypePrecision.Rows[0]["Data Type"].ToString().ToUpper()}
AS 
    BEGIN                    
        SELECT * FROM {_TableName} WHERE {_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} = @{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]};
    END
GO";
            return generatedStoredProcedure;

        }

        private string _GenerateAddNewStoredProcedure()
        {
            StringBuilder parametersString = new StringBuilder();

            DataRow row = null;

            parametersString.AppendLine($"\t@New{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} {_TableColumnsWithDataTypePrecision.Rows[0]["Data Type"].ToString().ToUpper()} OUTPUT ,");

            for (int i = 1; i < _TableColumnsWithDataTypePrecision.Rows.Count; i++)
            {
                row = _TableColumnsWithDataTypePrecision.Rows[i];

                if (i == _TableColumnsWithDataTypePrecision.Rows.Count-1)
                    parametersString.AppendLine($"\t@{row["Column Name"]} {row["Data Type"].ToString().ToUpper()}");

                else
                    parametersString.AppendLine($"\t@{row["Column Name"]} {row["Data Type"].ToString().ToUpper()},");
            }

            StringBuilder queryParameters = new StringBuilder();
            StringBuilder queryValues = new StringBuilder();

            for (int i = 1; i < _TableColumnsWithDataTypePrecision.Rows.Count; i++)
            {
                row = _TableColumnsWithDataTypePrecision.Rows[i];

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

            string storedProcedureName = $"SP_{_TableName}_AddNew{_TableSingularName}";

            string generatedStoredProcedure = $@"
CREATE PROCEDURE {storedProcedureName}
{parametersString}
AS 
    BEGIN                    
        INSERT INTO {_TableName} ({queryParameters})
        VALUES ({queryValues});

        SET @New{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} = SCOPE_IDENTITY();
    END
GO";
            return generatedStoredProcedure;

        }

        private string _GenerateUpdateStoredProcedure()
        {
            StringBuilder parametersString = new StringBuilder();

            DataRow row = null;

            for (int i = 0; i < _TableColumnsWithDataTypePrecision.Rows.Count; i++)
            {
                row = _TableColumnsWithDataTypePrecision.Rows[i];

                if (i == _TableColumnsWithDataTypePrecision.Rows.Count - 1)
                    parametersString.AppendLine($"\t@{row["Column Name"]} {row["Data Type"].ToString().ToUpper()}");

                else
                    parametersString.AppendLine($"\t@{row["Column Name"]} {row["Data Type"].ToString().ToUpper()},");
            }

            StringBuilder queryValues = new StringBuilder();

            for (int i = 1; i < _TableColumnsWithDataTypePrecision.Rows.Count; i++)
            {
                row = _TableColumnsWithDataTypePrecision.Rows[i];

                queryValues.Append("\n");

                if (i != _TableColumnsWithDataTypePrecision.Rows.Count - 1)
                    queryValues.Append("\t\t\t" + $"{row["Column Name"]} = @{row["Column Name"]},");

                else
                    queryValues.Append("\t\t\t" + $"{row["Column Name"]} = @{row["Column Name"]}");
            }

            string storedProcedureName = $"SP_{_TableName}_Update{_TableSingularName}Info";

            string generatedStoredProcedure = $@"
CREATE PROCEDURE {storedProcedureName}
{parametersString}
AS 
    BEGIN                    
        UPDATE {_TableName}
        SET {queryValues}
        WHERE {_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]} = @{_TableColumnsWithDataTypePrecision.Rows[0]["Column Name"]};
    END
GO";
            return generatedStoredProcedure;

        }
        #endregion
    }
}
