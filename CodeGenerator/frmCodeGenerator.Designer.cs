namespace CodeGenerator
{
    partial class frmCodeGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbDatabases = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dgvDatabaseTablesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtGeneratedCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.rbAdvanced = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNormal = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.dgvTableColumnsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDataAccessLayerPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusinessLayerPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateDataAccessLayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateBusinessLayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGenerateLayersClasses = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCopy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tabcontrol = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpNormalMode = new System.Windows.Forms.TabPage();
            this.btnGenerateStoredProcedures = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpAdvancedMode = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseTablesList)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableColumnsList)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tpNormalMode.SuspendLayout();
            this.tpAdvancedMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(614, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Generator";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.cbDatabases);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(39, 86);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(469, 108);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Select Database";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDatabases
            // 
            this.cbDatabases.BackColor = System.Drawing.Color.Transparent;
            this.cbDatabases.BorderRadius = 23;
            this.cbDatabases.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDatabases.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDatabases.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbDatabases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDatabases.ItemHeight = 35;
            this.cbDatabases.Location = new System.Drawing.Point(160, 51);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(278, 41);
            this.cbDatabases.TabIndex = 2;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database :";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 35;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // dgvDatabaseTablesList
            // 
            this.dgvDatabaseTablesList.AllowUserToAddRows = false;
            this.dgvDatabaseTablesList.AllowUserToDeleteRows = false;
            this.dgvDatabaseTablesList.AllowUserToOrderColumns = true;
            this.dgvDatabaseTablesList.AllowUserToResizeColumns = false;
            this.dgvDatabaseTablesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.dgvDatabaseTablesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDatabaseTablesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabaseTablesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvDatabaseTablesList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabaseTablesList.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDatabaseTablesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatabaseTablesList.Location = new System.Drawing.Point(39, 278);
            this.dgvDatabaseTablesList.MultiSelect = false;
            this.dgvDatabaseTablesList.Name = "dgvDatabaseTablesList";
            this.dgvDatabaseTablesList.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabaseTablesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDatabaseTablesList.RowHeadersVisible = false;
            this.dgvDatabaseTablesList.RowHeadersWidth = 60;
            this.dgvDatabaseTablesList.RowTemplate.Height = 45;
            this.dgvDatabaseTablesList.Size = new System.Drawing.Size(272, 529);
            this.dgvDatabaseTablesList.TabIndex = 3;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatabaseTablesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDatabaseTablesList.ThemeStyle.ReadOnly = true;
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.Height = 45;
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDatabaseTablesList.SelectionChanged += new System.EventHandler(this.dgvDatabaseTablesList_SelectionChanged);
            // 
            // txtGeneratedCode
            // 
            this.txtGeneratedCode.BorderColor = System.Drawing.Color.Black;
            this.txtGeneratedCode.BorderRadius = 1;
            this.txtGeneratedCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGeneratedCode.DefaultText = "";
            this.txtGeneratedCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGeneratedCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGeneratedCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGeneratedCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGeneratedCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGeneratedCode.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedCode.ForeColor = System.Drawing.Color.Black;
            this.txtGeneratedCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGeneratedCode.Location = new System.Drawing.Point(525, 15);
            this.txtGeneratedCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGeneratedCode.Multiline = true;
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.PasswordChar = '\0';
            this.txtGeneratedCode.PlaceholderText = "";
            this.txtGeneratedCode.ReadOnly = true;
            this.txtGeneratedCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGeneratedCode.SelectedText = "";
            this.txtGeneratedCode.Size = new System.Drawing.Size(575, 529);
            this.txtGeneratedCode.TabIndex = 4;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.label);
            this.guna2GroupBox2.Controls.Add(this.rbAdvanced);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.rbNormal);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(575, 86);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(524, 108);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Select Mode";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label.Location = new System.Drawing.Point(374, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 22);
            this.label.TabIndex = 4;
            this.label.Text = "Advanced";
            // 
            // rbAdvanced
            // 
            this.rbAdvanced.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAdvanced.CheckedState.BorderThickness = 0;
            this.rbAdvanced.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAdvanced.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAdvanced.Location = new System.Drawing.Point(343, 58);
            this.rbAdvanced.Name = "rbAdvanced";
            this.rbAdvanced.Size = new System.Drawing.Size(23, 23);
            this.rbAdvanced.TabIndex = 3;
            this.rbAdvanced.Text = "guna2CustomRadioButton2";
            this.rbAdvanced.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAdvanced.UncheckedState.BorderThickness = 2;
            this.rbAdvanced.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAdvanced.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(74, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Normal";
            // 
            // rbNormal
            // 
            this.rbNormal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNormal.CheckedState.BorderThickness = 0;
            this.rbNormal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNormal.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNormal.Location = new System.Drawing.Point(43, 59);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(23, 23);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.Text = "guna2CustomRadioButton1";
            this.rbNormal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbNormal.UncheckedState.BorderThickness = 2;
            this.rbNormal.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNormal.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // dgvTableColumnsList
            // 
            this.dgvTableColumnsList.AllowUserToAddRows = false;
            this.dgvTableColumnsList.AllowUserToDeleteRows = false;
            this.dgvTableColumnsList.AllowUserToOrderColumns = true;
            this.dgvTableColumnsList.AllowUserToResizeColumns = false;
            this.dgvTableColumnsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvTableColumnsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTableColumnsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableColumnsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTableColumnsList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableColumnsList.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTableColumnsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableColumnsList.Location = new System.Drawing.Point(27, 15);
            this.dgvTableColumnsList.MultiSelect = false;
            this.dgvTableColumnsList.Name = "dgvTableColumnsList";
            this.dgvTableColumnsList.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableColumnsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTableColumnsList.RowHeadersVisible = false;
            this.dgvTableColumnsList.RowHeadersWidth = 60;
            this.dgvTableColumnsList.RowTemplate.Height = 45;
            this.dgvTableColumnsList.Size = new System.Drawing.Size(422, 529);
            this.dgvTableColumnsList.TabIndex = 6;
            this.dgvTableColumnsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableColumnsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTableColumnsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTableColumnsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTableColumnsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTableColumnsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableColumnsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableColumnsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTableColumnsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTableColumnsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dgvTableColumnsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTableColumnsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTableColumnsList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTableColumnsList.ThemeStyle.ReadOnly = true;
            this.dgvTableColumnsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableColumnsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTableColumnsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTableColumnsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTableColumnsList.ThemeStyle.RowsStyle.Height = 45;
            this.dgvTableColumnsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableColumnsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 20;
            this.guna2GroupBox3.Controls.Add(this.txtDataAccessLayerPath);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.Controls.Add(this.txtBusinessLayerPath);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(43, 47);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1044, 329);
            this.guna2GroupBox3.TabIndex = 7;
            this.guna2GroupBox3.Text = "Select Paths";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataAccessLayerPath
            // 
            this.txtDataAccessLayerPath.BorderRadius = 23;
            this.txtDataAccessLayerPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataAccessLayerPath.DefaultText = "";
            this.txtDataAccessLayerPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDataAccessLayerPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDataAccessLayerPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataAccessLayerPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataAccessLayerPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataAccessLayerPath.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDataAccessLayerPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataAccessLayerPath.Location = new System.Drawing.Point(369, 190);
            this.txtDataAccessLayerPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataAccessLayerPath.Multiline = true;
            this.txtDataAccessLayerPath.Name = "txtDataAccessLayerPath";
            this.txtDataAccessLayerPath.PasswordChar = '\0';
            this.txtDataAccessLayerPath.PlaceholderText = "";
            this.txtDataAccessLayerPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDataAccessLayerPath.SelectedText = "";
            this.txtDataAccessLayerPath.Size = new System.Drawing.Size(518, 98);
            this.txtDataAccessLayerPath.TabIndex = 5;
            this.txtDataAccessLayerPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtDataAccessLayerPath_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label5.Location = new System.Drawing.Point(69, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "DataAccess Layer Folder Path :\r\n";
            // 
            // txtBusinessLayerPath
            // 
            this.txtBusinessLayerPath.BorderRadius = 23;
            this.txtBusinessLayerPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusinessLayerPath.DefaultText = "";
            this.txtBusinessLayerPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusinessLayerPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusinessLayerPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusinessLayerPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusinessLayerPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusinessLayerPath.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBusinessLayerPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusinessLayerPath.Location = new System.Drawing.Point(369, 64);
            this.txtBusinessLayerPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusinessLayerPath.Multiline = true;
            this.txtBusinessLayerPath.Name = "txtBusinessLayerPath";
            this.txtBusinessLayerPath.PasswordChar = '\0';
            this.txtBusinessLayerPath.PlaceholderText = "";
            this.txtBusinessLayerPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBusinessLayerPath.SelectedText = "";
            this.txtBusinessLayerPath.Size = new System.Drawing.Size(518, 98);
            this.txtBusinessLayerPath.TabIndex = 3;
            this.txtBusinessLayerPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtBusinessLayerPath_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label4.Location = new System.Drawing.Point(69, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Business Layer Folder Path :\r\n";
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 23;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1187, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(256, 71);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerateDataAccessLayer
            // 
            this.btnGenerateDataAccessLayer.BorderRadius = 23;
            this.btnGenerateDataAccessLayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessLayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateDataAccessLayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessLayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateDataAccessLayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateDataAccessLayer.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateDataAccessLayer.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnGenerateDataAccessLayer.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDataAccessLayer.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDataAccessLayer.Location = new System.Drawing.Point(525, 552);
            this.btnGenerateDataAccessLayer.Name = "btnGenerateDataAccessLayer";
            this.btnGenerateDataAccessLayer.Size = new System.Drawing.Size(189, 67);
            this.btnGenerateDataAccessLayer.TabIndex = 9;
            this.btnGenerateDataAccessLayer.Text = "Generate DataAccess Layer";
            this.btnGenerateDataAccessLayer.Click += new System.EventHandler(this.btnGenerateDataAccessLayer_Click);
            // 
            // btnGenerateBusinessLayer
            // 
            this.btnGenerateBusinessLayer.BorderRadius = 23;
            this.btnGenerateBusinessLayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateBusinessLayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateBusinessLayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateBusinessLayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateBusinessLayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateBusinessLayer.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateBusinessLayer.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnGenerateBusinessLayer.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBusinessLayer.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBusinessLayer.Location = new System.Drawing.Point(738, 552);
            this.btnGenerateBusinessLayer.Name = "btnGenerateBusinessLayer";
            this.btnGenerateBusinessLayer.Size = new System.Drawing.Size(189, 67);
            this.btnGenerateBusinessLayer.TabIndex = 10;
            this.btnGenerateBusinessLayer.Text = "Generate Business Layer";
            this.btnGenerateBusinessLayer.Click += new System.EventHandler(this.btnGenerateBusinessLayer_Click);
            // 
            // btnGenerateLayersClasses
            // 
            this.btnGenerateLayersClasses.BorderRadius = 23;
            this.btnGenerateLayersClasses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateLayersClasses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateLayersClasses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateLayersClasses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateLayersClasses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateLayersClasses.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateLayersClasses.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnGenerateLayersClasses.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGenerateLayersClasses.ForeColor = System.Drawing.Color.White;
            this.btnGenerateLayersClasses.Location = new System.Drawing.Point(424, 412);
            this.btnGenerateLayersClasses.Name = "btnGenerateLayersClasses";
            this.btnGenerateLayersClasses.Size = new System.Drawing.Size(296, 69);
            this.btnGenerateLayersClasses.TabIndex = 11;
            this.btnGenerateLayersClasses.Text = "Generate Layers classes";
            this.btnGenerateLayersClasses.Click += new System.EventHandler(this.btnGenerateLayersClasses_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BorderRadius = 23;
            this.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopy.FillColor = System.Drawing.Color.SeaGreen;
            this.btnCopy.FillColor2 = System.Drawing.Color.SeaGreen;
            this.btnCopy.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(951, 556);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(149, 56);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnClose.Image = global::CodeGenerator.Properties.Resources.close1;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.Location = new System.Drawing.Point(1492, -4);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tpNormalMode);
            this.tabcontrol.Controls.Add(this.tpAdvancedMode);
            this.tabcontrol.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabcontrol.ItemSize = new System.Drawing.Size(550, 50);
            this.tabcontrol.Location = new System.Drawing.Point(361, 209);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1138, 706);
            this.tabcontrol.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabcontrol.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabcontrol.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcontrol.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabcontrol.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabcontrol.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabcontrol.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabcontrol.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcontrol.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabcontrol.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabcontrol.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabcontrol.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabcontrol.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcontrol.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabcontrol.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabcontrol.TabButtonSize = new System.Drawing.Size(550, 50);
            this.tabcontrol.TabIndex = 13;
            this.tabcontrol.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabcontrol.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpNormalMode
            // 
            this.tpNormalMode.BackColor = System.Drawing.Color.White;
            this.tpNormalMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNormalMode.Controls.Add(this.btnGenerateStoredProcedures);
            this.tpNormalMode.Controls.Add(this.dgvTableColumnsList);
            this.tpNormalMode.Controls.Add(this.btnCopy);
            this.tpNormalMode.Controls.Add(this.txtGeneratedCode);
            this.tpNormalMode.Controls.Add(this.btnGenerateBusinessLayer);
            this.tpNormalMode.Controls.Add(this.btnGenerateDataAccessLayer);
            this.tpNormalMode.Location = new System.Drawing.Point(4, 54);
            this.tpNormalMode.Name = "tpNormalMode";
            this.tpNormalMode.Padding = new System.Windows.Forms.Padding(3);
            this.tpNormalMode.Size = new System.Drawing.Size(1130, 648);
            this.tpNormalMode.TabIndex = 0;
            this.tpNormalMode.Text = "Normal Mode";
            // 
            // btnGenerateStoredProcedures
            // 
            this.btnGenerateStoredProcedures.BorderRadius = 23;
            this.btnGenerateStoredProcedures.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateStoredProcedures.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateStoredProcedures.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateStoredProcedures.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateStoredProcedures.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateStoredProcedures.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateStoredProcedures.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnGenerateStoredProcedures.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateStoredProcedures.ForeColor = System.Drawing.Color.White;
            this.btnGenerateStoredProcedures.Location = new System.Drawing.Point(112, 552);
            this.btnGenerateStoredProcedures.Name = "btnGenerateStoredProcedures";
            this.btnGenerateStoredProcedures.Size = new System.Drawing.Size(231, 67);
            this.btnGenerateStoredProcedures.TabIndex = 13;
            this.btnGenerateStoredProcedures.Text = "Generated Stored Procedures";
            this.btnGenerateStoredProcedures.Click += new System.EventHandler(this.btnGenerateStoredProcedures_Click);
            // 
            // tpAdvancedMode
            // 
            this.tpAdvancedMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAdvancedMode.Controls.Add(this.guna2GroupBox3);
            this.tpAdvancedMode.Controls.Add(this.btnGenerateLayersClasses);
            this.tpAdvancedMode.Location = new System.Drawing.Point(4, 54);
            this.tpAdvancedMode.Name = "tpAdvancedMode";
            this.tpAdvancedMode.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvancedMode.Size = new System.Drawing.Size(1130, 648);
            this.tpAdvancedMode.TabIndex = 1;
            this.tpAdvancedMode.Text = "Advanced Mode";
            this.tpAdvancedMode.UseVisualStyleBackColor = true;
            // 
            // frmCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1541, 940);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.dgvDatabaseTablesList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseTablesList)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableColumnsList)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tpNormalMode.ResumeLayout(false);
            this.tpAdvancedMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbDatabases;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDatabaseTablesList;
        private Guna.UI2.WinForms.Guna2TextBox txtGeneratedCode;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbAdvanced;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbNormal;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTableColumnsList;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtBusinessLayerPath;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtDataAccessLayerPath;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton btnReset;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateBusinessLayer;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateDataAccessLayer;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateLayersClasses;
        private Guna.UI2.WinForms.Guna2GradientButton btnCopy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TabControl tabcontrol;
        private System.Windows.Forms.TabPage tpNormalMode;
        private System.Windows.Forms.TabPage tpAdvancedMode;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateStoredProcedures;
    }
}