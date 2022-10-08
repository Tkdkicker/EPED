namespace EPED
{
    partial class ShowSettingsFrm
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
            System.Windows.Forms.Label AllowJobAllocationLabel1;
            System.Windows.Forms.Label AllowEquipmentUpdateLabel;
            System.Windows.Forms.Label equipmentViewLabel;
            System.Windows.Forms.Label mailFromAddressLabel;
            System.Windows.Forms.Label mailSmtpServerLabel;
            System.Windows.Forms.Label mailPortAddressLabel;
            System.Windows.Forms.Label mailLoginAddressLabel;
            System.Windows.Forms.Label mailPasswordLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label colourNameLabel;
            System.Windows.Forms.Label allocationLabel;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSettingsFrm));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViewPW = new System.Windows.Forms.Button();
            this.mailPasswordTextBox = new System.Windows.Forms.TextBox();
            this.tbl_settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.mailLoginAddressTextBox = new System.Windows.Forms.TextBox();
            this.mailPortAddressTextBox = new System.Windows.Forms.TextBox();
            this.mailSmtpServerTextBox = new System.Windows.Forms.TextBox();
            this.mailFromAddressTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxReportOnOverdueIncluded = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbDueForMPM = new System.Windows.Forms.CheckBox();
            this.tbReportOnInUseOnly = new System.Windows.Forms.CheckBox();
            this.tbReportOnBlankDueDates = new System.Windows.Forms.CheckBox();
            this.tbDueForService = new System.Windows.Forms.CheckBox();
            this.rbEmailReport = new System.Windows.Forms.RadioButton();
            this.rbPrintReport = new System.Windows.Forms.RadioButton();
            this.rbStopReporting = new System.Windows.Forms.RadioButton();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.DayReport_ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Period_ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Email2_ComboBox = new System.Windows.Forms.ComboBox();
            this.Email1_ComboBox = new System.Windows.Forms.ComboBox();
            this.Email2_CheckBox = new System.Windows.Forms.CheckBox();
            this.Email1_CheckBox = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPrintInColor = new System.Windows.Forms.CheckBox();
            this.equipmentViewComboBox = new System.Windows.Forms.ComboBox();
            this.cbAllowWorkOrders = new System.Windows.Forms.CheckBox();
            this.cbAllowAssetUpdates = new System.Windows.Forms.CheckBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectUsers = new System.Windows.Forms.Button();
            this.lblDefUser = new System.Windows.Forms.Label();
            this.btnUpdateLocation = new System.Windows.Forms.Button();
            this.btnDBCon = new System.Windows.Forms.Button();
            this.UpdatesLocation_Label = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.MaintDBPath_Label = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.tbl_usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbl_usersTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_usersTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_settingsTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_settingsTableAdapter();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.colourNameTextBox = new System.Windows.Forms.TextBox();
            this.tbl_colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allocationTextBox = new System.Windows.Forms.TextBox();
            this.tbl_colorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Green = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbCol = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbl_colorTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_colorTableAdapter();
            AllowJobAllocationLabel1 = new System.Windows.Forms.Label();
            AllowEquipmentUpdateLabel = new System.Windows.Forms.Label();
            equipmentViewLabel = new System.Windows.Forms.Label();
            mailFromAddressLabel = new System.Windows.Forms.Label();
            mailSmtpServerLabel = new System.Windows.Forms.Label();
            mailPortAddressLabel = new System.Windows.Forms.Label();
            mailLoginAddressLabel = new System.Windows.Forms.Label();
            mailPasswordLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            colourNameLabel = new System.Windows.Forms.Label();
            allocationLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            this.GroupBox5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingNavigator)).BeginInit();
            this.tbl_usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_colorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllowJobAllocationLabel1
            // 
            AllowJobAllocationLabel1.AutoSize = true;
            AllowJobAllocationLabel1.ForeColor = System.Drawing.Color.White;
            AllowJobAllocationLabel1.Location = new System.Drawing.Point(20, 88);
            AllowJobAllocationLabel1.Name = "AllowJobAllocationLabel1";
            AllowJobAllocationLabel1.Size = new System.Drawing.Size(164, 15);
            AllowJobAllocationLabel1.TabIndex = 232;
            AllowJobAllocationLabel1.Text = "Allow WorkOrder Allocation:";
            // 
            // AllowEquipmentUpdateLabel
            // 
            AllowEquipmentUpdateLabel.AutoSize = true;
            AllowEquipmentUpdateLabel.ForeColor = System.Drawing.Color.White;
            AllowEquipmentUpdateLabel.Location = new System.Drawing.Point(35, 60);
            AllowEquipmentUpdateLabel.Name = "AllowEquipmentUpdateLabel";
            AllowEquipmentUpdateLabel.Size = new System.Drawing.Size(148, 15);
            AllowEquipmentUpdateLabel.TabIndex = 231;
            AllowEquipmentUpdateLabel.Text = "Allow Equipment Update:";
            // 
            // equipmentViewLabel
            // 
            equipmentViewLabel.AutoSize = true;
            equipmentViewLabel.Location = new System.Drawing.Point(51, 25);
            equipmentViewLabel.Name = "equipmentViewLabel";
            equipmentViewLabel.Size = new System.Drawing.Size(83, 15);
            equipmentViewLabel.TabIndex = 234;
            equipmentViewLabel.Text = "Startup View:";
            // 
            // mailFromAddressLabel
            // 
            mailFromAddressLabel.AutoSize = true;
            mailFromAddressLabel.Location = new System.Drawing.Point(35, 21);
            mailFromAddressLabel.Name = "mailFromAddressLabel";
            mailFromAddressLabel.Size = new System.Drawing.Size(113, 15);
            mailFromAddressLabel.TabIndex = 0;
            mailFromAddressLabel.Text = "Mail From Address:";
            // 
            // mailSmtpServerLabel
            // 
            mailSmtpServerLabel.AutoSize = true;
            mailSmtpServerLabel.Location = new System.Drawing.Point(42, 51);
            mailSmtpServerLabel.Name = "mailSmtpServerLabel";
            mailSmtpServerLabel.Size = new System.Drawing.Size(105, 15);
            mailSmtpServerLabel.TabIndex = 2;
            mailSmtpServerLabel.Text = "Mail Smtp Server:";
            // 
            // mailPortAddressLabel
            // 
            mailPortAddressLabel.AutoSize = true;
            mailPortAddressLabel.Location = new System.Drawing.Point(40, 81);
            mailPortAddressLabel.Name = "mailPortAddressLabel";
            mailPortAddressLabel.Size = new System.Drawing.Size(108, 15);
            mailPortAddressLabel.TabIndex = 4;
            mailPortAddressLabel.Text = "Mail Port Address:";
            // 
            // mailLoginAddressLabel
            // 
            mailLoginAddressLabel.AutoSize = true;
            mailLoginAddressLabel.Location = new System.Drawing.Point(31, 112);
            mailLoginAddressLabel.Name = "mailLoginAddressLabel";
            mailLoginAddressLabel.Size = new System.Drawing.Size(113, 15);
            mailLoginAddressLabel.TabIndex = 6;
            mailLoginAddressLabel.Text = "Mail Login Address:";
            // 
            // mailPasswordLabel
            // 
            mailPasswordLabel.AutoSize = true;
            mailPasswordLabel.Location = new System.Drawing.Point(56, 144);
            mailPasswordLabel.Name = "mailPasswordLabel";
            mailPasswordLabel.Size = new System.Drawing.Size(89, 15);
            mailPasswordLabel.TabIndex = 8;
            mailPasswordLabel.Text = "Mail Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(20, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 15);
            label3.TabIndex = 239;
            label3.Text = "Prints in Colour:";
            // 
            // colourNameLabel
            // 
            colourNameLabel.AutoSize = true;
            colourNameLabel.Location = new System.Drawing.Point(31, 280);
            colourNameLabel.Name = "colourNameLabel";
            colourNameLabel.Size = new System.Drawing.Size(83, 15);
            colourNameLabel.TabIndex = 1;
            colourNameLabel.Text = "Colour Name:";
            // 
            // allocationLabel
            // 
            allocationLabel.AutoSize = true;
            allocationLabel.Location = new System.Drawing.Point(31, 232);
            allocationLabel.Name = "allocationLabel";
            allocationLabel.Size = new System.Drawing.Size(65, 15);
            allocationLabel.TabIndex = 3;
            allocationLabel.Text = "Allocation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(35, 324);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "Colour:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox2.Controls.Add(this.btnViewPW);
            this.GroupBox2.Controls.Add(mailPasswordLabel);
            this.GroupBox2.Controls.Add(this.mailPasswordTextBox);
            this.GroupBox2.Controls.Add(mailLoginAddressLabel);
            this.GroupBox2.Controls.Add(this.mailLoginAddressTextBox);
            this.GroupBox2.Controls.Add(mailPortAddressLabel);
            this.GroupBox2.Controls.Add(this.mailPortAddressTextBox);
            this.GroupBox2.Controls.Add(mailSmtpServerLabel);
            this.GroupBox2.Controls.Add(this.mailSmtpServerTextBox);
            this.GroupBox2.Controls.Add(mailFromAddressLabel);
            this.GroupBox2.Controls.Add(this.mailFromAddressTextBox);
            this.GroupBox2.ForeColor = System.Drawing.Color.White;
            this.GroupBox2.Location = new System.Drawing.Point(476, 190);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(467, 184);
            this.GroupBox2.TabIndex = 243;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mail account details";
            // 
            // btnViewPW
            // 
            this.btnViewPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnViewPW.FlatAppearance.BorderSize = 0;
            this.btnViewPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPW.Font = new System.Drawing.Font("Wingdings 2", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnViewPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnViewPW.Location = new System.Drawing.Point(424, 141);
            this.btnViewPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewPW.Name = "btnViewPW";
            this.btnViewPW.Size = new System.Drawing.Size(29, 22);
            this.btnViewPW.TabIndex = 16;
            this.btnViewPW.Text = "8";
            this.btnViewPW.UseVisualStyleBackColor = false;
            this.btnViewPW.Visible = false;
            this.btnViewPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnViewPW_MouseDown);
            this.btnViewPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnViewPW_MouseUp);
            // 
            // mailPasswordTextBox
            // 
            this.mailPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_settingsBindingSource, "MailPassword", true));
            this.mailPasswordTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailPasswordTextBox.Location = new System.Drawing.Point(154, 141);
            this.mailPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailPasswordTextBox.Name = "mailPasswordTextBox";
            this.mailPasswordTextBox.PasswordChar = '*';
            this.mailPasswordTextBox.Size = new System.Drawing.Size(264, 22);
            this.mailPasswordTextBox.TabIndex = 9;
            this.mailPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.mailPasswordTextBox_Validating);
            // 
            // tbl_settingsBindingSource
            // 
            this.tbl_settingsBindingSource.DataMember = "tbl_settings";
            this.tbl_settingsBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailLoginAddressTextBox
            // 
            this.mailLoginAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_settingsBindingSource, "MailLoginAddress", true));
            this.mailLoginAddressTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailLoginAddressTextBox.Location = new System.Drawing.Point(154, 109);
            this.mailLoginAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailLoginAddressTextBox.Name = "mailLoginAddressTextBox";
            this.mailLoginAddressTextBox.Size = new System.Drawing.Size(264, 22);
            this.mailLoginAddressTextBox.TabIndex = 7;
            // 
            // mailPortAddressTextBox
            // 
            this.mailPortAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_settingsBindingSource, "MailPortAddress", true));
            this.mailPortAddressTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailPortAddressTextBox.Location = new System.Drawing.Point(154, 78);
            this.mailPortAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailPortAddressTextBox.Name = "mailPortAddressTextBox";
            this.mailPortAddressTextBox.Size = new System.Drawing.Size(45, 22);
            this.mailPortAddressTextBox.TabIndex = 5;
            // 
            // mailSmtpServerTextBox
            // 
            this.mailSmtpServerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_settingsBindingSource, "MailSmtpServer", true));
            this.mailSmtpServerTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailSmtpServerTextBox.Location = new System.Drawing.Point(154, 48);
            this.mailSmtpServerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailSmtpServerTextBox.Name = "mailSmtpServerTextBox";
            this.mailSmtpServerTextBox.Size = new System.Drawing.Size(264, 22);
            this.mailSmtpServerTextBox.TabIndex = 3;
            // 
            // mailFromAddressTextBox
            // 
            this.mailFromAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_settingsBindingSource, "MailFromAddress", true));
            this.mailFromAddressTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailFromAddressTextBox.Location = new System.Drawing.Point(154, 18);
            this.mailFromAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailFromAddressTextBox.Name = "mailFromAddressTextBox";
            this.mailFromAddressTextBox.Size = new System.Drawing.Size(264, 22);
            this.mailFromAddressTextBox.TabIndex = 1;
            // 
            // GroupBox5
            // 
            this.GroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox5.Controls.Add(this.cbxReportOnOverdueIncluded);
            this.GroupBox5.Controls.Add(this.btnTest);
            this.GroupBox5.Controls.Add(this.tbDueForMPM);
            this.GroupBox5.Controls.Add(this.tbReportOnInUseOnly);
            this.GroupBox5.Controls.Add(this.tbReportOnBlankDueDates);
            this.GroupBox5.Controls.Add(this.tbDueForService);
            this.GroupBox5.Controls.Add(this.rbEmailReport);
            this.GroupBox5.Controls.Add(this.rbPrintReport);
            this.GroupBox5.Controls.Add(this.rbStopReporting);
            this.GroupBox5.Controls.Add(this.Label9);
            this.GroupBox5.Controls.Add(this.Label8);
            this.GroupBox5.Controls.Add(this.DayReport_ComboBox1);
            this.GroupBox5.Controls.Add(this.Period_ComboBox1);
            this.GroupBox5.Controls.Add(this.Email2_ComboBox);
            this.GroupBox5.Controls.Add(this.Email1_ComboBox);
            this.GroupBox5.Controls.Add(this.Email2_CheckBox);
            this.GroupBox5.Controls.Add(this.Email1_CheckBox);
            this.GroupBox5.Controls.Add(this.Label6);
            this.GroupBox5.ForeColor = System.Drawing.Color.White;
            this.GroupBox5.Location = new System.Drawing.Point(92, 381);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox5.Size = new System.Drawing.Size(377, 418);
            this.GroupBox5.TabIndex = 247;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Scheduled reports";
            // 
            // cbxReportOnOverdueIncluded
            // 
            this.cbxReportOnOverdueIncluded.AutoSize = true;
            this.cbxReportOnOverdueIncluded.Location = new System.Drawing.Point(20, 168);
            this.cbxReportOnOverdueIncluded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxReportOnOverdueIncluded.Name = "cbxReportOnOverdueIncluded";
            this.cbxReportOnOverdueIncluded.Size = new System.Drawing.Size(327, 19);
            this.cbxReportOnOverdueIncluded.TabIndex = 31;
            this.cbxReportOnOverdueIncluded.Text = "Report include overdue assets before report start date";
            this.cbxReportOnOverdueIncluded.UseVisualStyleBackColor = true;
            this.cbxReportOnOverdueIncluded.CheckedChanged += new System.EventHandler(this.cbxReportOnOverdueIncluded_CheckedChanged);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnTest.Location = new System.Drawing.Point(222, 215);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(132, 35);
            this.btnTest.TabIndex = 30;
            this.btnTest.Text = "TEST REPORT";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbDueForMPM
            // 
            this.tbDueForMPM.AutoSize = true;
            this.tbDueForMPM.Checked = true;
            this.tbDueForMPM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDueForMPM.Location = new System.Drawing.Point(20, 86);
            this.tbDueForMPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDueForMPM.Name = "tbDueForMPM";
            this.tbDueForMPM.Size = new System.Drawing.Size(215, 19);
            this.tbDueForMPM.TabIndex = 29;
            this.tbDueForMPM.Text = "Due for Preventative Maintenance";
            this.tbDueForMPM.UseVisualStyleBackColor = true;
            this.tbDueForMPM.Click += new System.EventHandler(this.tbDueForMPM_Click);
            // 
            // tbReportOnInUseOnly
            // 
            this.tbReportOnInUseOnly.AutoSize = true;
            this.tbReportOnInUseOnly.Checked = true;
            this.tbReportOnInUseOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbReportOnInUseOnly.Location = new System.Drawing.Point(20, 141);
            this.tbReportOnInUseOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReportOnInUseOnly.Name = "tbReportOnInUseOnly";
            this.tbReportOnInUseOnly.Size = new System.Drawing.Size(183, 19);
            this.tbReportOnInUseOnly.TabIndex = 28;
            this.tbReportOnInUseOnly.Text = "Report on IN USE only Assets";
            this.tbReportOnInUseOnly.UseVisualStyleBackColor = true;
            this.tbReportOnInUseOnly.Click += new System.EventHandler(this.tbReportOnInUseOnly_Click);
            // 
            // tbReportOnBlankDueDates
            // 
            this.tbReportOnBlankDueDates.AutoSize = true;
            this.tbReportOnBlankDueDates.Checked = true;
            this.tbReportOnBlankDueDates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbReportOnBlankDueDates.Location = new System.Drawing.Point(20, 114);
            this.tbReportOnBlankDueDates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReportOnBlankDueDates.Name = "tbReportOnBlankDueDates";
            this.tbReportOnBlankDueDates.Size = new System.Drawing.Size(233, 19);
            this.tbReportOnBlankDueDates.TabIndex = 27;
            this.tbReportOnBlankDueDates.Text = "Report on blank due dates as overdue";
            this.tbReportOnBlankDueDates.UseVisualStyleBackColor = true;
            this.tbReportOnBlankDueDates.Click += new System.EventHandler(this.tbReportObBlankDueDates_Click);
            // 
            // tbDueForService
            // 
            this.tbDueForService.AutoSize = true;
            this.tbDueForService.Checked = true;
            this.tbDueForService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbDueForService.Location = new System.Drawing.Point(20, 60);
            this.tbDueForService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDueForService.Name = "tbDueForService";
            this.tbDueForService.Size = new System.Drawing.Size(164, 19);
            this.tbDueForService.TabIndex = 26;
            this.tbDueForService.Text = "Due for Service reporting";
            this.tbDueForService.UseVisualStyleBackColor = true;
            this.tbDueForService.Click += new System.EventHandler(this.tbDueForService_Click);
            // 
            // rbEmailReport
            // 
            this.rbEmailReport.AutoSize = true;
            this.rbEmailReport.ForeColor = System.Drawing.Color.White;
            this.rbEmailReport.Location = new System.Drawing.Point(240, 34);
            this.rbEmailReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbEmailReport.Name = "rbEmailReport";
            this.rbEmailReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbEmailReport.Size = new System.Drawing.Size(95, 19);
            this.rbEmailReport.TabIndex = 4;
            this.rbEmailReport.Text = "Email Report";
            this.rbEmailReport.UseVisualStyleBackColor = true;
            this.rbEmailReport.CheckedChanged += new System.EventHandler(this.rbEmailReport_CheckedChanged);
            // 
            // rbPrintReport
            // 
            this.rbPrintReport.AutoSize = true;
            this.rbPrintReport.ForeColor = System.Drawing.Color.White;
            this.rbPrintReport.Location = new System.Drawing.Point(139, 34);
            this.rbPrintReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPrintReport.Name = "rbPrintReport";
            this.rbPrintReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbPrintReport.Size = new System.Drawing.Size(93, 19);
            this.rbPrintReport.TabIndex = 3;
            this.rbPrintReport.Text = "Print Report";
            this.rbPrintReport.UseVisualStyleBackColor = true;
            this.rbPrintReport.CheckedChanged += new System.EventHandler(this.rbPrintReport_CheckedChanged);
            // 
            // rbStopReporting
            // 
            this.rbStopReporting.AutoSize = true;
            this.rbStopReporting.Checked = true;
            this.rbStopReporting.ForeColor = System.Drawing.Color.White;
            this.rbStopReporting.Location = new System.Drawing.Point(20, 34);
            this.rbStopReporting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbStopReporting.Name = "rbStopReporting";
            this.rbStopReporting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStopReporting.Size = new System.Drawing.Size(107, 19);
            this.rbStopReporting.TabIndex = 2;
            this.rbStopReporting.TabStop = true;
            this.rbStopReporting.Text = "Stop Reporting";
            this.rbStopReporting.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(16, 251);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(87, 15);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "Day to Report:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(16, 202);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(125, 15);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "Period For Reporting:";
            // 
            // DayReport_ComboBox1
            // 
            this.DayReport_ComboBox1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayReport_ComboBox1.FormattingEnabled = true;
            this.DayReport_ComboBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.DayReport_ComboBox1.Location = new System.Drawing.Point(20, 274);
            this.DayReport_ComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DayReport_ComboBox1.Name = "DayReport_ComboBox1";
            this.DayReport_ComboBox1.Size = new System.Drawing.Size(133, 22);
            this.DayReport_ComboBox1.TabIndex = 11;
            this.DayReport_ComboBox1.SelectionChangeCommitted += new System.EventHandler(this.DayReport_ComboBox1_SelectionChangeCommitted);
            // 
            // Period_ComboBox1
            // 
            this.Period_ComboBox1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Period_ComboBox1.FormattingEnabled = true;
            this.Period_ComboBox1.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.Period_ComboBox1.Location = new System.Drawing.Point(20, 221);
            this.Period_ComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Period_ComboBox1.Name = "Period_ComboBox1";
            this.Period_ComboBox1.Size = new System.Drawing.Size(133, 22);
            this.Period_ComboBox1.TabIndex = 10;
            this.Period_ComboBox1.SelectedIndexChanged += new System.EventHandler(this.Period_ComboBox1_SelectedIndexChanged);
            this.Period_ComboBox1.SelectionChangeCommitted += new System.EventHandler(this.Period_ComboBox1_SelectionChangeCommitted);
            // 
            // Email2_ComboBox
            // 
            this.Email2_ComboBox.DisplayMember = "EmailAddress";
            this.Email2_ComboBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email2_ComboBox.FormattingEnabled = true;
            this.Email2_ComboBox.Location = new System.Drawing.Point(20, 375);
            this.Email2_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email2_ComboBox.Name = "Email2_ComboBox";
            this.Email2_ComboBox.Size = new System.Drawing.Size(238, 22);
            this.Email2_ComboBox.TabIndex = 8;
            this.Email2_ComboBox.ValueMember = "EmailAddress";
            this.Email2_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.Email2_ComboBox_SelectionChangeCommitted);
            // 
            // Email1_ComboBox
            // 
            this.Email1_ComboBox.DisplayMember = "EmailAddress";
            this.Email1_ComboBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email1_ComboBox.FormattingEnabled = true;
            this.Email1_ComboBox.Location = new System.Drawing.Point(20, 336);
            this.Email1_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email1_ComboBox.Name = "Email1_ComboBox";
            this.Email1_ComboBox.Size = new System.Drawing.Size(238, 22);
            this.Email1_ComboBox.TabIndex = 7;
            this.Email1_ComboBox.ValueMember = "EmailAddress";
            this.Email1_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.Email1_ComboBox_SelectionChangeCommitted);
            // 
            // Email2_CheckBox
            // 
            this.Email2_CheckBox.AutoSize = true;
            this.Email2_CheckBox.ForeColor = System.Drawing.Color.White;
            this.Email2_CheckBox.Location = new System.Drawing.Point(266, 379);
            this.Email2_CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email2_CheckBox.Name = "Email2_CheckBox";
            this.Email2_CheckBox.Size = new System.Drawing.Size(69, 19);
            this.Email2_CheckBox.TabIndex = 6;
            this.Email2_CheckBox.Text = "Enabled";
            this.Email2_CheckBox.UseVisualStyleBackColor = true;
            this.Email2_CheckBox.Click += new System.EventHandler(this.Email2_CheckBox_Click);
            // 
            // Email1_CheckBox
            // 
            this.Email1_CheckBox.AutoSize = true;
            this.Email1_CheckBox.ForeColor = System.Drawing.Color.White;
            this.Email1_CheckBox.Location = new System.Drawing.Point(266, 338);
            this.Email1_CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email1_CheckBox.Name = "Email1_CheckBox";
            this.Email1_CheckBox.Size = new System.Drawing.Size(69, 19);
            this.Email1_CheckBox.TabIndex = 5;
            this.Email1_CheckBox.Text = "Enabled";
            this.Email1_CheckBox.UseVisualStyleBackColor = true;
            this.Email1_CheckBox.Click += new System.EventHandler(this.Email1_CheckBox_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(16, 311);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 15);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Service Emails To:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox3.Controls.Add(label3);
            this.GroupBox3.Controls.Add(this.cbPrintInColor);
            this.GroupBox3.Controls.Add(this.equipmentViewComboBox);
            this.GroupBox3.Controls.Add(equipmentViewLabel);
            this.GroupBox3.Controls.Add(AllowJobAllocationLabel1);
            this.GroupBox3.Controls.Add(this.cbAllowWorkOrders);
            this.GroupBox3.Controls.Add(AllowEquipmentUpdateLabel);
            this.GroupBox3.Controls.Add(this.cbAllowAssetUpdates);
            this.GroupBox3.ForeColor = System.Drawing.Color.White;
            this.GroupBox3.Location = new System.Drawing.Point(92, 190);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Size = new System.Drawing.Size(377, 184);
            this.GroupBox3.TabIndex = 248;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Local preferences";
            // 
            // cbPrintInColor
            // 
            this.cbPrintInColor.Location = new System.Drawing.Point(189, 110);
            this.cbPrintInColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPrintInColor.Name = "cbPrintInColor";
            this.cbPrintInColor.Size = new System.Drawing.Size(29, 28);
            this.cbPrintInColor.TabIndex = 240;
            this.cbPrintInColor.UseVisualStyleBackColor = true;
            this.cbPrintInColor.Click += new System.EventHandler(this.cbPrintInColor_Click);
            // 
            // equipmentViewComboBox
            // 
            this.equipmentViewComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_settingsBindingSource, "EquipmentView", true));
            this.equipmentViewComboBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentViewComboBox.FormattingEnabled = true;
            this.equipmentViewComboBox.Items.AddRange(new object[] {
            "Selection",
            "AssetList All",
            "Calibration Due",
            "Verification Due",
            "PAT Due",
            "Maintenance Logs",
            "Job Schedules",
            "Settings",
            "Asset Schedule",
            "Parts List",
            "Work Orders"});
            this.equipmentViewComboBox.Location = new System.Drawing.Point(189, 22);
            this.equipmentViewComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equipmentViewComboBox.Name = "equipmentViewComboBox";
            this.equipmentViewComboBox.Size = new System.Drawing.Size(140, 22);
            this.equipmentViewComboBox.TabIndex = 237;
            this.equipmentViewComboBox.SelectionChangeCommitted += new System.EventHandler(this.equipmentViewComboBox_SelectionChangeCommitted);
            // 
            // cbAllowWorkOrders
            // 
            this.cbAllowWorkOrders.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_settingsBindingSource, "AllowJobAllocation", true));
            this.cbAllowWorkOrders.Location = new System.Drawing.Point(189, 82);
            this.cbAllowWorkOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAllowWorkOrders.Name = "cbAllowWorkOrders";
            this.cbAllowWorkOrders.Size = new System.Drawing.Size(29, 28);
            this.cbAllowWorkOrders.TabIndex = 233;
            this.cbAllowWorkOrders.UseVisualStyleBackColor = true;
            // 
            // cbAllowAssetUpdates
            // 
            this.cbAllowAssetUpdates.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_settingsBindingSource, "AllowAssetsUpdate", true));
            this.cbAllowAssetUpdates.Location = new System.Drawing.Point(189, 54);
            this.cbAllowAssetUpdates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAllowAssetUpdates.Name = "cbAllowAssetUpdates";
            this.cbAllowAssetUpdates.Size = new System.Drawing.Size(29, 28);
            this.cbAllowAssetUpdates.TabIndex = 232;
            this.cbAllowAssetUpdates.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox4.Controls.Add(this.btnSelectUsers);
            this.GroupBox4.Controls.Add(this.lblDefUser);
            this.GroupBox4.Controls.Add(this.btnUpdateLocation);
            this.GroupBox4.Controls.Add(this.btnDBCon);
            this.GroupBox4.Controls.Add(this.UpdatesLocation_Label);
            this.GroupBox4.Controls.Add(this.Label10);
            this.GroupBox4.Controls.Add(this.MaintDBPath_Label);
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox4.ForeColor = System.Drawing.Color.White;
            this.GroupBox4.Location = new System.Drawing.Point(92, 46);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox4.Size = new System.Drawing.Size(850, 138);
            this.GroupBox4.TabIndex = 249;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Database locations";
            // 
            // btnSelectUsers
            // 
            this.btnSelectUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSelectUsers.FlatAppearance.BorderSize = 0;
            this.btnSelectUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSelectUsers.Location = new System.Drawing.Point(470, 16);
            this.btnSelectUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectUsers.Name = "btnSelectUsers";
            this.btnSelectUsers.Size = new System.Drawing.Size(183, 28);
            this.btnSelectUsers.TabIndex = 257;
            this.btnSelectUsers.Text = "Select Current User";
            this.btnSelectUsers.UseVisualStyleBackColor = false;
            this.btnSelectUsers.Click += new System.EventHandler(this.btnSelectUsers_Click);
            // 
            // lblDefUser
            // 
            this.lblDefUser.AutoSize = true;
            this.lblDefUser.BackColor = System.Drawing.Color.White;
            this.lblDefUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDefUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefUser.ForeColor = System.Drawing.Color.Black;
            this.lblDefUser.Location = new System.Drawing.Point(192, 19);
            this.lblDefUser.MinimumSize = new System.Drawing.Size(141, 17);
            this.lblDefUser.Name = "lblDefUser";
            this.lblDefUser.Size = new System.Drawing.Size(141, 20);
            this.lblDefUser.TabIndex = 256;
            this.lblDefUser.Text = "unknown";
            this.lblDefUser.TextChanged += new System.EventHandler(this.lblDefUser_TextChanged);
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnUpdateLocation.FlatAppearance.BorderSize = 0;
            this.btnUpdateLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnUpdateLocation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateLocation.Location = new System.Drawing.Point(799, 99);
            this.btnUpdateLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(44, 20);
            this.btnUpdateLocation.TabIndex = 254;
            this.btnUpdateLocation.Text = "\'\'\'";
            this.btnUpdateLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateLocation.UseVisualStyleBackColor = false;
            this.btnUpdateLocation.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnDBCon
            // 
            this.btnDBCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnDBCon.FlatAppearance.BorderSize = 0;
            this.btnDBCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnDBCon.Location = new System.Drawing.Point(660, 16);
            this.btnDBCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDBCon.Name = "btnDBCon";
            this.btnDBCon.Size = new System.Drawing.Size(183, 28);
            this.btnDBCon.TabIndex = 252;
            this.btnDBCon.Text = "Change SQL Connection";
            this.btnDBCon.UseVisualStyleBackColor = false;
            this.btnDBCon.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdatesLocation_Label
            // 
            this.UpdatesLocation_Label.AutoSize = true;
            this.UpdatesLocation_Label.ForeColor = System.Drawing.Color.White;
            this.UpdatesLocation_Label.Location = new System.Drawing.Point(282, 99);
            this.UpdatesLocation_Label.Name = "UpdatesLocation_Label";
            this.UpdatesLocation_Label.Size = new System.Drawing.Size(58, 15);
            this.UpdatesLocation_Label.TabIndex = 223;
            this.UpdatesLocation_Label.Text = "unknown";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(20, 99);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(183, 15);
            this.Label10.TabIndex = 222;
            this.Label10.Text = "Location for Application Update:";
            // 
            // MaintDBPath_Label
            // 
            this.MaintDBPath_Label.AutoSize = true;
            this.MaintDBPath_Label.ForeColor = System.Drawing.Color.White;
            this.MaintDBPath_Label.Location = new System.Drawing.Point(282, 60);
            this.MaintDBPath_Label.Name = "MaintDBPath_Label";
            this.MaintDBPath_Label.Size = new System.Drawing.Size(58, 15);
            this.MaintDBPath_Label.TabIndex = 221;
            this.MaintDBPath_Label.Text = "unknown";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(20, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(219, 15);
            this.Label2.TabIndex = 219;
            this.Label2.Text = "Location for Effect Photonics Database:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(20, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(125, 15);
            this.Label1.TabIndex = 217;
            this.Label1.Text = "Current Default User:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSave.Location = new System.Drawing.Point(961, 638);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 52);
            this.btnSave.TabIndex = 251;
            this.btnSave.Text = "SAVE SETTINGS";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.Button1.Location = new System.Drawing.Point(961, 708);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(176, 55);
            this.Button1.TabIndex = 250;
            this.Button1.Text = "CLOSE";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbl_usersBindingNavigator
            // 
            this.tbl_usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_usersBindingNavigator.BindingSource = this.tbl_usersBindingSource;
            this.tbl_usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_usersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_usersBindingNavigatorSaveItem});
            this.tbl_usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_usersBindingNavigator.Name = "tbl_usersBindingNavigator";
            this.tbl_usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_usersBindingNavigator.Size = new System.Drawing.Size(1170, 29);
            this.tbl_usersBindingNavigator.TabIndex = 252;
            this.tbl_usersBindingNavigator.Text = "bindingNavigator1";
            this.tbl_usersBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbl_usersBindingSource
            // 
            this.tbl_usersBindingSource.DataMember = "tbl_users";
            this.tbl_usersBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 26);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tbl_usersBindingNavigatorSaveItem
            // 
            this.tbl_usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_usersBindingNavigatorSaveItem.Image")));
            this.tbl_usersBindingNavigatorSaveItem.Name = "tbl_usersBindingNavigatorSaveItem";
            this.tbl_usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 26);
            this.tbl_usersBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_usersBindingNavigatorSaveItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbl_usersTableAdapter
            // 
            this.tbl_usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = null;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = null;
            this.tableAdapterManager.tbl_colorTableAdapter = null;
            this.tableAdapterManager.tbl_partslistTableAdapter = null;
            this.tableAdapterManager.tbl_pmscheduleTableAdapter = null;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = null;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = this.tbl_usersTableAdapter;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_settingsTableAdapter
            // 
            this.tbl_settingsTableAdapter.ClearBeforeFill = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox1.Controls.Add(this.btnReset);
            this.GroupBox1.Controls.Add(this.colourNameTextBox);
            this.GroupBox1.Controls.Add(this.allocationTextBox);
            this.GroupBox1.Controls.Add(this.tbl_colorDataGridView);
            this.GroupBox1.Controls.Add(label4);
            this.GroupBox1.Controls.Add(this.txbCol);
            this.GroupBox1.Controls.Add(this.btnUpdate);
            this.GroupBox1.Controls.Add(allocationLabel);
            this.GroupBox1.Controls.Add(colourNameLabel);
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(476, 382);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(467, 415);
            this.GroupBox1.TabIndex = 253;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Colour scheme";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnReset.Location = new System.Drawing.Point(331, 232);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 26);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // colourNameTextBox
            // 
            this.colourNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_colorBindingSource, "ColourName", true));
            this.colourNameTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourNameTextBox.Location = new System.Drawing.Point(120, 278);
            this.colourNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colourNameTextBox.Name = "colourNameTextBox";
            this.colourNameTextBox.Size = new System.Drawing.Size(140, 22);
            this.colourNameTextBox.TabIndex = 16;
            // 
            // tbl_colorBindingSource
            // 
            this.tbl_colorBindingSource.DataMember = "tbl_color";
            this.tbl_colorBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // allocationTextBox
            // 
            this.allocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_colorBindingSource, "Allocation", true));
            this.allocationTextBox.Enabled = false;
            this.allocationTextBox.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allocationTextBox.Location = new System.Drawing.Point(120, 232);
            this.allocationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allocationTextBox.Name = "allocationTextBox";
            this.allocationTextBox.Size = new System.Drawing.Size(140, 22);
            this.allocationTextBox.TabIndex = 15;
            // 
            // tbl_colorDataGridView
            // 
            this.tbl_colorDataGridView.AllowUserToAddRows = false;
            this.tbl_colorDataGridView.AutoGenerateColumns = false;
            this.tbl_colorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_colorDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbl_colorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_colorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Red,
            this.Green,
            this.Blue});
            this.tbl_colorDataGridView.DataSource = this.tbl_colorBindingSource;
            this.tbl_colorDataGridView.Location = new System.Drawing.Point(27, 50);
            this.tbl_colorDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbl_colorDataGridView.Name = "tbl_colorDataGridView";
            this.tbl_colorDataGridView.RowHeadersVisible = false;
            this.tbl_colorDataGridView.RowHeadersWidth = 51;
            this.tbl_colorDataGridView.Size = new System.Drawing.Size(407, 165);
            this.tbl_colorDataGridView.TabIndex = 13;
            this.tbl_colorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_colorDataGridView_CellClick);
            this.tbl_colorDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_colorDataGridView_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Allocation";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Allocation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 86;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ColourName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ColourName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 101;
            // 
            // Red
            // 
            this.Red.DataPropertyName = "Red";
            this.Red.HeaderText = "Red";
            this.Red.MinimumWidth = 6;
            this.Red.Name = "Red";
            this.Red.Width = 53;
            // 
            // Green
            // 
            this.Green.DataPropertyName = "Green";
            this.Green.HeaderText = "Green";
            this.Green.MinimumWidth = 6;
            this.Green.Name = "Green";
            this.Green.Width = 66;
            // 
            // Blue
            // 
            this.Blue.DataPropertyName = "Blue";
            this.Blue.HeaderText = "Blue";
            this.Blue.MinimumWidth = 6;
            this.Blue.Name = "Blue";
            this.Blue.Width = 56;
            // 
            // txbCol
            // 
            this.txbCol.Enabled = false;
            this.txbCol.Location = new System.Drawing.Point(120, 324);
            this.txbCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCol.Name = "txbCol";
            this.txbCol.Size = new System.Drawing.Size(140, 23);
            this.txbCol.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnUpdate.Location = new System.Drawing.Point(331, 324);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 26);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "SAVE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbl_colorTableAdapter
            // 
            this.tbl_colorTableAdapter.ClearBeforeFill = true;
            // 
            // ShowSettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1170, 812);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.tbl_usersBindingNavigator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1186, 851);
            this.Name = "ShowSettingsFrm";
            this.Text = "SettingsFrm";
            this.Activated += new System.EventHandler(this.SettingsFrm_Activated);
            this.Load += new System.EventHandler(this.SettingsFrm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingNavigator)).EndInit();
            this.tbl_usersBindingNavigator.ResumeLayout(false);
            this.tbl_usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usersBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_colorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.CheckBox tbDueForService;
        internal System.Windows.Forms.RadioButton rbEmailReport;
        internal System.Windows.Forms.RadioButton rbPrintReport;
        internal System.Windows.Forms.RadioButton rbStopReporting;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox DayReport_ComboBox1;
        internal System.Windows.Forms.ComboBox Period_ComboBox1;
        internal System.Windows.Forms.ComboBox Email2_ComboBox;
        internal System.Windows.Forms.ComboBox Email1_ComboBox;
        internal System.Windows.Forms.CheckBox Email2_CheckBox;
        internal System.Windows.Forms.CheckBox Email1_CheckBox;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.CheckBox cbAllowWorkOrders;
        internal System.Windows.Forms.CheckBox cbAllowAssetUpdates;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label UpdatesLocation_Label;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label MaintDBPath_Label;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button btnDBCon;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_usersBindingSource;
        private eped_db1DataSetTableAdapters.tbl_usersTableAdapter tbl_usersTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_usersBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnUpdateLocation;
        private System.Windows.Forms.BindingSource tbl_settingsBindingSource;
        private eped_db1DataSetTableAdapters.tbl_settingsTableAdapter tbl_settingsTableAdapter;
        private System.Windows.Forms.Label lblDefUser;
        private System.Windows.Forms.TextBox mailPasswordTextBox;
        private System.Windows.Forms.TextBox mailLoginAddressTextBox;
        private System.Windows.Forms.TextBox mailPortAddressTextBox;
        private System.Windows.Forms.TextBox mailSmtpServerTextBox;
        private System.Windows.Forms.TextBox mailFromAddressTextBox;
        private System.Windows.Forms.Button btnSelectUsers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox equipmentViewComboBox;
        internal System.Windows.Forms.CheckBox tbReportOnBlankDueDates;
        internal System.Windows.Forms.CheckBox cbPrintInColor;
        internal System.Windows.Forms.CheckBox tbReportOnInUseOnly;
        internal System.Windows.Forms.CheckBox tbDueForMPM;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.BindingSource tbl_colorBindingSource;
        private eped_db1DataSetTableAdapters.tbl_colorTableAdapter tbl_colorTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbCol;
        private System.Windows.Forms.DataGridView tbl_colorDataGridView;
        private System.Windows.Forms.TextBox allocationTextBox;
        private System.Windows.Forms.TextBox colourNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Green;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTest;
        internal System.Windows.Forms.CheckBox cbxReportOnOverdueIncluded;
        private System.Windows.Forms.Button btnViewPW;
    }
}