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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbDatabases = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgvDatabaseTablesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtGeneratedCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbAdvanced = new System.Windows.Forms.Label();
            this.guna2CustomRadioButton2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
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
            this.btnGenerateBothLayers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCopy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseTablesList)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableColumnsList)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(519, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Generator";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbDatabases);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(35, 113);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(355, 108);
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
            this.cbDatabases.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDatabases.ItemHeight = 35;
            this.cbDatabases.Location = new System.Drawing.Point(123, 51);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(202, 41);
            this.cbDatabases.TabIndex = 2;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
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
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnClose.Image = global::CodeGenerator.Properties.Resources.close1;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.Location = new System.Drawing.Point(1453, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDatabaseTablesList
            // 
            this.dgvDatabaseTablesList.AllowUserToAddRows = false;
            this.dgvDatabaseTablesList.AllowUserToDeleteRows = false;
            this.dgvDatabaseTablesList.AllowUserToOrderColumns = true;
            this.dgvDatabaseTablesList.AllowUserToResizeColumns = false;
            this.dgvDatabaseTablesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatabaseTablesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabaseTablesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatabaseTablesList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabaseTablesList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatabaseTablesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatabaseTablesList.Location = new System.Drawing.Point(35, 247);
            this.dgvDatabaseTablesList.MultiSelect = false;
            this.dgvDatabaseTablesList.Name = "dgvDatabaseTablesList";
            this.dgvDatabaseTablesList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabaseTablesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatabaseTablesList.RowHeadersVisible = false;
            this.dgvDatabaseTablesList.RowHeadersWidth = 60;
            this.dgvDatabaseTablesList.RowTemplate.Height = 45;
            this.dgvDatabaseTablesList.Size = new System.Drawing.Size(230, 502);
            this.dgvDatabaseTablesList.TabIndex = 3;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatabaseTablesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatabaseTablesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatabaseTablesList.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDatabaseTablesList.ThemeStyle.ReadOnly = true;
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatabaseTablesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtGeneratedCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGeneratedCode.ForeColor = System.Drawing.Color.Black;
            this.txtGeneratedCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGeneratedCode.Location = new System.Drawing.Point(847, 308);
            this.txtGeneratedCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeneratedCode.Multiline = true;
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.PasswordChar = '\0';
            this.txtGeneratedCode.PlaceholderText = "";
            this.txtGeneratedCode.ReadOnly = true;
            this.txtGeneratedCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGeneratedCode.SelectedText = "";
            this.txtGeneratedCode.Size = new System.Drawing.Size(623, 441);
            this.txtGeneratedCode.TabIndex = 4;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.rbAdvanced);
            this.guna2GroupBox2.Controls.Add(this.guna2CustomRadioButton2);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.rbNormal);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(425, 113);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(392, 108);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Select Mode";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbAdvanced
            // 
            this.rbAdvanced.AutoSize = true;
            this.rbAdvanced.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.rbAdvanced.Location = new System.Drawing.Point(274, 60);
            this.rbAdvanced.Name = "rbAdvanced";
            this.rbAdvanced.Size = new System.Drawing.Size(82, 21);
            this.rbAdvanced.TabIndex = 4;
            this.rbAdvanced.Text = "Advanced";
            // 
            // guna2CustomRadioButton2
            // 
            this.guna2CustomRadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton2.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton2.Location = new System.Drawing.Point(243, 58);
            this.guna2CustomRadioButton2.Name = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.Size = new System.Drawing.Size(23, 23);
            this.guna2CustomRadioButton2.TabIndex = 3;
            this.guna2CustomRadioButton2.Text = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(71, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Normal";
            // 
            // rbNormal
            // 
            this.rbNormal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNormal.CheckedState.BorderThickness = 0;
            this.rbNormal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbNormal.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNormal.Location = new System.Drawing.Point(40, 59);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTableColumnsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableColumnsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableColumnsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableColumnsList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableColumnsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTableColumnsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTableColumnsList.Location = new System.Drawing.Point(298, 247);
            this.dgvTableColumnsList.MultiSelect = false;
            this.dgvTableColumnsList.Name = "dgvTableColumnsList";
            this.dgvTableColumnsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableColumnsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTableColumnsList.RowHeadersVisible = false;
            this.dgvTableColumnsList.RowHeadersWidth = 60;
            this.dgvTableColumnsList.RowTemplate.Height = 45;
            this.dgvTableColumnsList.Size = new System.Drawing.Size(519, 502);
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
            this.guna2GroupBox3.Controls.Add(this.txtDataAccessLayerPath);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.Controls.Add(this.txtBusinessLayerPath);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(847, 91);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(623, 203);
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
            this.txtDataAccessLayerPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDataAccessLayerPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataAccessLayerPath.Location = new System.Drawing.Point(272, 124);
            this.txtDataAccessLayerPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataAccessLayerPath.Multiline = true;
            this.txtDataAccessLayerPath.Name = "txtDataAccessLayerPath";
            this.txtDataAccessLayerPath.PasswordChar = '\0';
            this.txtDataAccessLayerPath.PlaceholderText = "";
            this.txtDataAccessLayerPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDataAccessLayerPath.SelectedText = "";
            this.txtDataAccessLayerPath.Size = new System.Drawing.Size(335, 64);
            this.txtDataAccessLayerPath.TabIndex = 5;
            this.txtDataAccessLayerPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtDataAccessLayerPath_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 21);
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
            this.txtBusinessLayerPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusinessLayerPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusinessLayerPath.Location = new System.Drawing.Point(272, 48);
            this.txtBusinessLayerPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusinessLayerPath.Multiline = true;
            this.txtBusinessLayerPath.Name = "txtBusinessLayerPath";
            this.txtBusinessLayerPath.PasswordChar = '\0';
            this.txtBusinessLayerPath.PlaceholderText = "";
            this.txtBusinessLayerPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBusinessLayerPath.SelectedText = "";
            this.txtBusinessLayerPath.Size = new System.Drawing.Size(335, 64);
            this.txtBusinessLayerPath.TabIndex = 3;
            this.txtBusinessLayerPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtBusinessLayerPath_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label4.Location = new System.Drawing.Point(32, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 21);
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
            this.btnReset.FillColor = System.Drawing.Color.SteelBlue;
            this.btnReset.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(64, 758);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 54);
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
            this.btnGenerateDataAccessLayer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDataAccessLayer.ForeColor = System.Drawing.Color.White;
            this.btnGenerateDataAccessLayer.Location = new System.Drawing.Point(877, 758);
            this.btnGenerateDataAccessLayer.Name = "btnGenerateDataAccessLayer";
            this.btnGenerateDataAccessLayer.Size = new System.Drawing.Size(196, 67);
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
            this.btnGenerateBusinessLayer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBusinessLayer.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBusinessLayer.Location = new System.Drawing.Point(1096, 758);
            this.btnGenerateBusinessLayer.Name = "btnGenerateBusinessLayer";
            this.btnGenerateBusinessLayer.Size = new System.Drawing.Size(196, 67);
            this.btnGenerateBusinessLayer.TabIndex = 10;
            this.btnGenerateBusinessLayer.Text = "Generate Business Layer";
            this.btnGenerateBusinessLayer.Click += new System.EventHandler(this.btnGenerateBusinessLayer_Click);
            // 
            // btnGenerateBothLayers
            // 
            this.btnGenerateBothLayers.BorderRadius = 23;
            this.btnGenerateBothLayers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateBothLayers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateBothLayers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateBothLayers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateBothLayers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateBothLayers.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateBothLayers.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnGenerateBothLayers.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBothLayers.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBothLayers.Location = new System.Drawing.Point(400, 758);
            this.btnGenerateBothLayers.Name = "btnGenerateBothLayers";
            this.btnGenerateBothLayers.Size = new System.Drawing.Size(271, 54);
            this.btnGenerateBothLayers.TabIndex = 11;
            this.btnGenerateBothLayers.Text = "Generate Both Layers";
            this.btnGenerateBothLayers.Click += new System.EventHandler(this.btnGenerateBothLayers_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BorderRadius = 23;
            this.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopy.FillColor = System.Drawing.Color.SteelBlue;
            this.btnCopy.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(1308, 758);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(147, 54);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1506, 871);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerateBothLayers);
            this.Controls.Add(this.btnGenerateBusinessLayer);
            this.Controls.Add(this.btnGenerateDataAccessLayer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.dgvTableColumnsList);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.txtGeneratedCode);
            this.Controls.Add(this.dgvDatabaseTablesList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
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
        private System.Windows.Forms.Label rbAdvanced;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton2;
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
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerateBothLayers;
        private Guna.UI2.WinForms.Guna2GradientButton btnCopy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}