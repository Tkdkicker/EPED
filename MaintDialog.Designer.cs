namespace EPED
    {
    partial class MaintDialog
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
            System.Windows.Forms.Label DateLabel1;
            System.Windows.Forms.Label DateLabel;
            System.Windows.Forms.Label ReasonLabel;
            System.Windows.Forms.Label ActionTakenLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label workOrderNoLabel;
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label technicianLabel;
            System.Windows.Forms.Label dateCalibrationDueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintDialog));
            this.lblWeekno = new System.Windows.Forms.Label();
            this.DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbl_assetlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.ReasonTextBox = new System.Windows.Forms.TextBox();
            this.ActionTakenTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbl_assetlogsTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_assetlogsTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_assetlogsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.workOrderNoComboBox = new System.Windows.Forms.ComboBox();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.btnSetNextDueDate = new System.Windows.Forms.Button();
            this.dtpNextDueDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCalibrationDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rbPatReq = new System.Windows.Forms.RadioButton();
            this.rbVerifyReq = new System.Windows.Forms.RadioButton();
            this.rbCalibReq = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbl_assetlogsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DateLabel1 = new System.Windows.Forms.Label();
            DateLabel = new System.Windows.Forms.Label();
            ReasonLabel = new System.Windows.Forms.Label();
            ActionTakenLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            workOrderNoLabel = new System.Windows.Forms.Label();
            equipmentIDLabel = new System.Windows.Forms.Label();
            technicianLabel = new System.Windows.Forms.Label();
            dateCalibrationDueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingNavigator)).BeginInit();
            this.tbl_assetlogsBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel1
            // 
            DateLabel1.AutoSize = true;
            DateLabel1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            DateLabel1.Location = new System.Drawing.Point(11, 8);
            DateLabel1.Name = "DateLabel1";
            DateLabel1.Size = new System.Drawing.Size(54, 15);
            DateLabel1.TabIndex = 25;
            DateLabel1.Text = "WeekNo:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            DateLabel.Location = new System.Drawing.Point(5, 112);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new System.Drawing.Size(34, 15);
            DateLabel.TabIndex = 17;
            DateLabel.Text = "Date:";
            // 
            // ReasonLabel
            // 
            ReasonLabel.AutoSize = true;
            ReasonLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ReasonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            ReasonLabel.Location = new System.Drawing.Point(5, 142);
            ReasonLabel.Name = "ReasonLabel";
            ReasonLabel.Size = new System.Drawing.Size(48, 15);
            ReasonLabel.TabIndex = 19;
            ReasonLabel.Text = "Reason:";
            // 
            // ActionTakenLabel
            // 
            ActionTakenLabel.AutoSize = true;
            ActionTakenLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ActionTakenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            ActionTakenLabel.Location = new System.Drawing.Point(5, 230);
            ActionTakenLabel.Name = "ActionTakenLabel";
            ActionTakenLabel.Size = new System.Drawing.Size(77, 15);
            ActionTakenLabel.TabIndex = 23;
            ActionTakenLabel.Text = "Action Taken:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            commentsLabel.Location = new System.Drawing.Point(5, 359);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(66, 15);
            commentsLabel.TabIndex = 30;
            commentsLabel.Text = "Comments:";
            // 
            // workOrderNoLabel
            // 
            workOrderNoLabel.AutoSize = true;
            workOrderNoLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workOrderNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            workOrderNoLabel.Location = new System.Drawing.Point(5, 41);
            workOrderNoLabel.Name = "workOrderNoLabel";
            workOrderNoLabel.Size = new System.Drawing.Size(88, 15);
            workOrderNoLabel.TabIndex = 31;
            workOrderNoLabel.Text = "Work Order No:";
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentIDLabel.Location = new System.Drawing.Point(5, 81);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(81, 15);
            equipmentIDLabel.TabIndex = 32;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // technicianLabel
            // 
            technicianLabel.AutoSize = true;
            technicianLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            technicianLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            technicianLabel.Location = new System.Drawing.Point(5, 199);
            technicianLabel.Name = "technicianLabel";
            technicianLabel.Size = new System.Drawing.Size(66, 15);
            technicianLabel.TabIndex = 33;
            technicianLabel.Text = "Technician:";
            // 
            // dateCalibrationDueLabel
            // 
            dateCalibrationDueLabel.AutoSize = true;
            dateCalibrationDueLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateCalibrationDueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateCalibrationDueLabel.Location = new System.Drawing.Point(15, 74);
            dateCalibrationDueLabel.Name = "dateCalibrationDueLabel";
            dateCalibrationDueLabel.Size = new System.Drawing.Size(160, 15);
            dateCalibrationDueLabel.TabIndex = 40;
            dateCalibrationDueLabel.Text = "Current Date Calibration Due:";
            // 
            // lblWeekno
            // 
            this.lblWeekno.AutoSize = true;
            this.lblWeekno.BackColor = System.Drawing.Color.White;
            this.lblWeekno.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekno.Location = new System.Drawing.Point(93, 6);
            this.lblWeekno.Name = "lblWeekno";
            this.lblWeekno.Size = new System.Drawing.Size(21, 15);
            this.lblWeekno.TabIndex = 26;
            this.lblWeekno.Text = "00";
            // 
            // DateDateTimePicker
            // 
            this.DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetlogsBindingSource, "Date", true));
            this.DateDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDateTimePicker.Location = new System.Drawing.Point(93, 109);
            this.DateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateDateTimePicker.Name = "DateDateTimePicker";
            this.DateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.DateDateTimePicker.TabIndex = 18;
            this.DateDateTimePicker.ValueChanged += new System.EventHandler(this.DateDateTimePicker_ValueChanged);
            // 
            // tbl_assetlogsBindingSource
            // 
            this.tbl_assetlogsBindingSource.DataMember = "tbl_assetlogs";
            this.tbl_assetlogsBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReasonTextBox
            // 
            this.ReasonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "Reason", true));
            this.ReasonTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonTextBox.Location = new System.Drawing.Point(93, 139);
            this.ReasonTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReasonTextBox.Multiline = true;
            this.ReasonTextBox.Name = "ReasonTextBox";
            this.ReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReasonTextBox.Size = new System.Drawing.Size(200, 50);
            this.ReasonTextBox.TabIndex = 20;
            // 
            // ActionTakenTextBox
            // 
            this.ActionTakenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionTakenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "ActionTaken", true));
            this.ActionTakenTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionTakenTextBox.Location = new System.Drawing.Point(93, 226);
            this.ActionTakenTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActionTakenTextBox.Multiline = true;
            this.ActionTakenTextBox.Name = "ActionTakenTextBox";
            this.ActionTakenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ActionTakenTextBox.Size = new System.Drawing.Size(200, 108);
            this.ActionTakenTextBox.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnClose.Location = new System.Drawing.Point(102, 26);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // tbl_assetlogsTableAdapter
            // 
            this.tbl_assetlogsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = this.tbl_assetlogsTableAdapter;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = null;
            this.tableAdapterManager.tbl_colorTableAdapter = null;
            this.tableAdapterManager.tbl_partslistTableAdapter = null;
            this.tableAdapterManager.tbl_pmscheduleTableAdapter = null;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = null;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = null;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_assetlogsBindingNavigator
            // 
            this.tbl_assetlogsBindingNavigator.AddNewItem = null;
            this.tbl_assetlogsBindingNavigator.BindingSource = this.tbl_assetlogsBindingSource;
            this.tbl_assetlogsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_assetlogsBindingNavigator.DeleteItem = null;
            this.tbl_assetlogsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_assetlogsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tbl_assetlogsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_assetlogsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_assetlogsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_assetlogsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_assetlogsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_assetlogsBindingNavigator.Name = "tbl_assetlogsBindingNavigator";
            this.tbl_assetlogsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_assetlogsBindingNavigator.Size = new System.Drawing.Size(576, 27);
            this.tbl_assetlogsBindingNavigator.TabIndex = 27;
            this.tbl_assetlogsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnAddNew.Location = new System.Drawing.Point(40, 15);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(96, 41);
            this.btnAddNew.TabIndex = 29;
            this.btnAddNew.Text = "ADD TO LOG";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSave.Location = new System.Drawing.Point(3, 26);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 41);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "SAVE TO DATABASE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "Comments", true));
            this.commentsTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(93, 355);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(200, 89);
            this.commentsTextBox.TabIndex = 31;
            // 
            // workOrderNoComboBox
            // 
            this.workOrderNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "WorkOrderNo", true));
            this.workOrderNoComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workOrderNoComboBox.FormattingEnabled = true;
            this.workOrderNoComboBox.Location = new System.Drawing.Point(93, 38);
            this.workOrderNoComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workOrderNoComboBox.Name = "workOrderNoComboBox";
            this.workOrderNoComboBox.Size = new System.Drawing.Size(121, 23);
            this.workOrderNoComboBox.TabIndex = 32;
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "Technician", true));
            this.technicianComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(93, 195);
            this.technicianComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(200, 23);
            this.technicianComboBox.TabIndex = 34;
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "EquipmentID", true));
            this.equipmentIDTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentIDTextBox.Location = new System.Drawing.Point(93, 78);
            this.equipmentIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.Size = new System.Drawing.Size(200, 23);
            this.equipmentIDTextBox.TabIndex = 35;
            // 
            // btnSetNextDueDate
            // 
            this.btnSetNextDueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSetNextDueDate.Enabled = false;
            this.btnSetNextDueDate.FlatAppearance.BorderSize = 0;
            this.btnSetNextDueDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetNextDueDate.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetNextDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSetNextDueDate.Location = new System.Drawing.Point(37, 248);
            this.btnSetNextDueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetNextDueDate.Name = "btnSetNextDueDate";
            this.btnSetNextDueDate.Size = new System.Drawing.Size(96, 41);
            this.btnSetNextDueDate.TabIndex = 36;
            this.btnSetNextDueDate.Text = "SET NEXT DUE DATE";
            this.btnSetNextDueDate.UseVisualStyleBackColor = false;
            // 
            // dtpNextDueDate
            // 
            this.dtpNextDueDate.Enabled = false;
            this.dtpNextDueDate.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNextDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextDueDate.Location = new System.Drawing.Point(25, 351);
            this.dtpNextDueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNextDueDate.Name = "dtpNextDueDate";
            this.dtpNextDueDate.Size = new System.Drawing.Size(132, 21);
            this.dtpNextDueDate.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbInterval);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(dateCalibrationDueLabel);
            this.panel1.Controls.Add(this.dateCalibrationDueDateTimePicker);
            this.panel1.Controls.Add(this.rbPatReq);
            this.panel1.Controls.Add(this.rbVerifyReq);
            this.panel1.Controls.Add(this.btnSetNextDueDate);
            this.panel1.Controls.Add(this.rbCalibReq);
            this.panel1.Controls.Add(this.dtpNextDueDate);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Location = new System.Drawing.Point(349, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 382);
            this.panel1.TabIndex = 38;
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(41, 320);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(39, 15);
            this.lbInterval.TabIndex = 43;
            this.lbInterval.Text = "--------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(41, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Due date Interval:";
            // 
            // dateCalibrationDueDateTimePicker
            // 
            this.dateCalibrationDueDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCalibrationDueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCalibrationDueDateTimePicker.Location = new System.Drawing.Point(25, 92);
            this.dateCalibrationDueDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateCalibrationDueDateTimePicker.Name = "dateCalibrationDueDateTimePicker";
            this.dateCalibrationDueDateTimePicker.Size = new System.Drawing.Size(132, 21);
            this.dateCalibrationDueDateTimePicker.TabIndex = 41;
            // 
            // rbPatReq
            // 
            this.rbPatReq.AutoSize = true;
            this.rbPatReq.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbPatReq.Location = new System.Drawing.Point(37, 188);
            this.rbPatReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPatReq.Name = "rbPatReq";
            this.rbPatReq.Size = new System.Drawing.Size(93, 19);
            this.rbPatReq.TabIndex = 40;
            this.rbPatReq.TabStop = true;
            this.rbPatReq.Text = "PAT Required";
            this.rbPatReq.UseVisualStyleBackColor = true;
            // 
            // rbVerifyReq
            // 
            this.rbVerifyReq.AutoSize = true;
            this.rbVerifyReq.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVerifyReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbVerifyReq.Location = new System.Drawing.Point(37, 160);
            this.rbVerifyReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVerifyReq.Name = "rbVerifyReq";
            this.rbVerifyReq.Size = new System.Drawing.Size(134, 19);
            this.rbVerifyReq.TabIndex = 39;
            this.rbVerifyReq.TabStop = true;
            this.rbVerifyReq.Text = "Verification Required";
            this.rbVerifyReq.UseVisualStyleBackColor = true;
            // 
            // rbCalibReq
            // 
            this.rbCalibReq.AutoSize = true;
            this.rbCalibReq.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCalibReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbCalibReq.Location = new System.Drawing.Point(37, 130);
            this.rbCalibReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCalibReq.Name = "rbCalibReq";
            this.rbCalibReq.Size = new System.Drawing.Size(132, 19);
            this.rbCalibReq.TabIndex = 38;
            this.rbCalibReq.TabStop = true;
            this.rbCalibReq.Text = "Calibration Required";
            this.rbCalibReq.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(349, 422);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 77);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.equipmentIDTextBox);
            this.panel3.Controls.Add(technicianLabel);
            this.panel3.Controls.Add(this.technicianComboBox);
            this.panel3.Controls.Add(equipmentIDLabel);
            this.panel3.Controls.Add(workOrderNoLabel);
            this.panel3.Controls.Add(this.workOrderNoComboBox);
            this.panel3.Controls.Add(commentsLabel);
            this.panel3.Controls.Add(this.commentsTextBox);
            this.panel3.Controls.Add(this.lblWeekno);
            this.panel3.Controls.Add(DateLabel1);
            this.panel3.Controls.Add(DateLabel);
            this.panel3.Controls.Add(this.DateDateTimePicker);
            this.panel3.Controls.Add(ReasonLabel);
            this.panel3.Controls.Add(this.ReasonTextBox);
            this.panel3.Controls.Add(ActionTakenLabel);
            this.panel3.Controls.Add(this.ActionTakenTextBox);
            this.panel3.Location = new System.Drawing.Point(4, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 466);
            this.panel3.TabIndex = 40;
            // 
            // tbl_assetlogsDataGridView
            // 
            this.tbl_assetlogsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_assetlogsDataGridView.AutoGenerateColumns = false;
            this.tbl_assetlogsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_assetlogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_assetlogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tbl_assetlogsDataGridView.DataSource = this.tbl_assetlogsBindingSource;
            this.tbl_assetlogsDataGridView.Location = new System.Drawing.Point(333, 34);
            this.tbl_assetlogsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbl_assetlogsDataGridView.Name = "tbl_assetlogsDataGridView";
            this.tbl_assetlogsDataGridView.RowHeadersWidth = 51;
            this.tbl_assetlogsDataGridView.Size = new System.Drawing.Size(0, 466);
            this.tbl_assetlogsDataGridView.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EquipmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EquipmentID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 56;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WorkOrderNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "WorkOrderNo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn4.HeaderText = "Reason";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Technician";
            this.dataGridViewTextBoxColumn5.HeaderText = "Technician";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 88;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ActionTaken";
            this.dataGridViewTextBoxColumn6.HeaderText = "ActionTaken";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn7.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 88;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SiteName";
            this.dataGridViewTextBoxColumn8.HeaderText = "SiteName";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // MaintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(576, 565);
            this.Controls.Add(this.tbl_assetlogsDataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_assetlogsBindingNavigator);
            this.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(592, 604);
            this.Name = "MaintDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintDialog";
            this.Activated += new System.EventHandler(this.MaintDialog_Activated);
            this.Load += new System.EventHandler(this.MaintDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingNavigator)).EndInit();
            this.tbl_assetlogsBindingNavigator.ResumeLayout(false);
            this.tbl_assetlogsBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        internal System.Windows.Forms.Label lblWeekno;
        internal System.Windows.Forms.DateTimePicker DateDateTimePicker;
        internal System.Windows.Forms.TextBox ReasonTextBox;
        internal System.Windows.Forms.TextBox ActionTakenTextBox;
        internal System.Windows.Forms.Button btnClose;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_assetlogsBindingSource;
        private eped_db1DataSetTableAdapters.tbl_assetlogsTableAdapter tbl_assetlogsTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_assetlogsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        internal System.Windows.Forms.Button btnAddNew;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.ComboBox workOrderNoComboBox;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.TextBox equipmentIDTextBox;
        internal System.Windows.Forms.Button btnSetNextDueDate;
        internal System.Windows.Forms.DateTimePicker dtpNextDueDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbPatReq;
        private System.Windows.Forms.RadioButton rbVerifyReq;
        private System.Windows.Forms.RadioButton rbCalibReq;
        private System.Windows.Forms.DateTimePicker dateCalibrationDueDateTimePicker;
        private System.Windows.Forms.DataGridView tbl_assetlogsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.Label label1;
    }
    }