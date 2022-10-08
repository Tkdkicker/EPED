namespace EPED
{
    partial class ShowAssetLogsFrm
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
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label workOrderNoLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label technicianLabel;
            System.Windows.Forms.Label actionTakenLabel;
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label siteNameLabel;
            System.Windows.Forms.Label dateDueLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAssetLogsFrm));
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.tbl_assetlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_assetlogsTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_assetlogsTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_assetlogsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIDTextBox1 = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.workOrderNoTextBox1 = new System.Windows.Forms.TextBox();
            this.reasonTextBox1 = new System.Windows.Forms.TextBox();
            this.actionTakenTextBox1 = new System.Windows.Forms.TextBox();
            this.commentsTextBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbl_assetlogsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.siteNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSiteName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbSearchOn = new System.Windows.Forms.TextBox();
            this.btnSearchOn = new System.Windows.Forms.Button();
            equipmentIDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            workOrderNoLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            technicianLabel = new System.Windows.Forms.Label();
            actionTakenLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            siteNameLabel = new System.Windows.Forms.Label();
            dateDueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingNavigator)).BeginInit();
            this.tbl_assetlogsBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentIDLabel.Location = new System.Drawing.Point(6, 18);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(83, 15);
            equipmentIDLabel.TabIndex = 2;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateLabel.Location = new System.Drawing.Point(6, 72);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(96, 15);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date Completed:";
            // 
            // workOrderNoLabel
            // 
            workOrderNoLabel.AutoSize = true;
            workOrderNoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workOrderNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            workOrderNoLabel.Location = new System.Drawing.Point(6, 124);
            workOrderNoLabel.Name = "workOrderNoLabel";
            workOrderNoLabel.Size = new System.Drawing.Size(92, 15);
            workOrderNoLabel.TabIndex = 6;
            workOrderNoLabel.Text = "Work Order No:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reasonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            reasonLabel.Location = new System.Drawing.Point(6, 150);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(50, 15);
            reasonLabel.TabIndex = 8;
            reasonLabel.Text = "Reason:";
            // 
            // technicianLabel
            // 
            technicianLabel.AutoSize = true;
            technicianLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            technicianLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            technicianLabel.Location = new System.Drawing.Point(6, 226);
            technicianLabel.Name = "technicianLabel";
            technicianLabel.Size = new System.Drawing.Size(69, 15);
            technicianLabel.TabIndex = 10;
            technicianLabel.Text = "Technician:";
            // 
            // actionTakenLabel
            // 
            actionTakenLabel.AutoSize = true;
            actionTakenLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            actionTakenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            actionTakenLabel.Location = new System.Drawing.Point(6, 264);
            actionTakenLabel.Name = "actionTakenLabel";
            actionTakenLabel.Size = new System.Drawing.Size(78, 15);
            actionTakenLabel.TabIndex = 12;
            actionTakenLabel.Text = "Action Taken:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            commentsLabel.Location = new System.Drawing.Point(6, 333);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(67, 15);
            commentsLabel.TabIndex = 14;
            commentsLabel.Text = "Comments:";
            // 
            // siteNameLabel
            // 
            siteNameLabel.AutoSize = true;
            siteNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            siteNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            siteNameLabel.Location = new System.Drawing.Point(6, 44);
            siteNameLabel.Name = "siteNameLabel";
            siteNameLabel.Size = new System.Drawing.Size(64, 15);
            siteNameLabel.TabIndex = 77;
            siteNameLabel.Text = "Site Name:";
            // 
            // dateDueLabel
            // 
            dateDueLabel.AutoSize = true;
            dateDueLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateDueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateDueLabel.Location = new System.Drawing.Point(6, 100);
            dateDueLabel.Name = "dateDueLabel";
            dateDueLabel.Size = new System.Drawing.Size(59, 15);
            dateDueLabel.TabIndex = 79;
            dateDueLabel.Text = "Date Due:";
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_assetlogsBindingSource
            // 
            this.tbl_assetlogsBindingSource.DataMember = "tbl_assetlogs";
            this.tbl_assetlogsBindingSource.DataSource = this.eped_db1DataSet;
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
            // tbl_assetlogsDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tbl_assetlogsDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_assetlogsDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_assetlogsDataGridView1.AutoGenerateColumns = false;
            this.tbl_assetlogsDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_assetlogsDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_assetlogsDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbl_assetlogsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_assetlogsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.SiteName,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.DateDue});
            this.tbl_assetlogsDataGridView1.DataSource = this.tbl_assetlogsBindingSource;
            this.tbl_assetlogsDataGridView1.Location = new System.Drawing.Point(12, 45);
            this.tbl_assetlogsDataGridView1.Name = "tbl_assetlogsDataGridView1";
            this.tbl_assetlogsDataGridView1.RowHeadersWidth = 51;
            this.tbl_assetlogsDataGridView1.Size = new System.Drawing.Size(576, 402);
            this.tbl_assetlogsDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EquipmentID";
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "EquipmentID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 103;
            // 
            // SiteName
            // 
            this.SiteName.DataPropertyName = "SiteName";
            this.SiteName.HeaderText = "SiteName";
            this.SiteName.MinimumWidth = 6;
            this.SiteName.Name = "SiteName";
            this.SiteName.Width = 86;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 58;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "WorkOrderNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "WorkOrderNo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 110;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn11.HeaderText = "Reason";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 71;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Technician";
            this.dataGridViewTextBoxColumn12.HeaderText = "Technician";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 87;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ActionTaken";
            this.dataGridViewTextBoxColumn13.HeaderText = "ActionTaken";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 98;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn14.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 92;
            // 
            // DateDue
            // 
            this.DateDue.DataPropertyName = "DateDue";
            this.DateDue.HeaderText = "DateDue";
            this.DateDue.MinimumWidth = 6;
            this.DateDue.Name = "DateDue";
            this.DateDue.Width = 80;
            // 
            // equipmentIDTextBox1
            // 
            this.equipmentIDTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "EquipmentID", true));
            this.equipmentIDTextBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentIDTextBox1.Location = new System.Drawing.Point(140, 15);
            this.equipmentIDTextBox1.Name = "equipmentIDTextBox1";
            this.equipmentIDTextBox1.Size = new System.Drawing.Size(200, 23);
            this.equipmentIDTextBox1.TabIndex = 3;
            // 
            // dateDateTimePicker1
            // 
            this.dateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetlogsBindingSource, "Date", true));
            this.dateDateTimePicker1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker1.Location = new System.Drawing.Point(191, 68);
            this.dateDateTimePicker1.Name = "dateDateTimePicker1";
            this.dateDateTimePicker1.Size = new System.Drawing.Size(149, 23);
            this.dateDateTimePicker1.TabIndex = 5;
            // 
            // workOrderNoTextBox1
            // 
            this.workOrderNoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workOrderNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "WorkOrderNo", true));
            this.workOrderNoTextBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workOrderNoTextBox1.Location = new System.Drawing.Point(140, 121);
            this.workOrderNoTextBox1.Name = "workOrderNoTextBox1";
            this.workOrderNoTextBox1.Size = new System.Drawing.Size(200, 23);
            this.workOrderNoTextBox1.TabIndex = 7;
            // 
            // reasonTextBox1
            // 
            this.reasonTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reasonTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "Reason", true));
            this.reasonTextBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonTextBox1.Location = new System.Drawing.Point(140, 147);
            this.reasonTextBox1.Multiline = true;
            this.reasonTextBox1.Name = "reasonTextBox1";
            this.reasonTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reasonTextBox1.Size = new System.Drawing.Size(200, 70);
            this.reasonTextBox1.TabIndex = 9;
            // 
            // actionTakenTextBox1
            // 
            this.actionTakenTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionTakenTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "ActionTaken", true));
            this.actionTakenTextBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTakenTextBox1.Location = new System.Drawing.Point(140, 249);
            this.actionTakenTextBox1.Multiline = true;
            this.actionTakenTextBox1.Name = "actionTakenTextBox1";
            this.actionTakenTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actionTakenTextBox1.Size = new System.Drawing.Size(200, 75);
            this.actionTakenTextBox1.TabIndex = 13;
            // 
            // commentsTextBox1
            // 
            this.commentsTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentsTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "Comments", true));
            this.commentsTextBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox1.Location = new System.Drawing.Point(140, 330);
            this.commentsTextBox1.Multiline = true;
            this.commentsTextBox1.Name = "commentsTextBox1";
            this.commentsTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox1.Size = new System.Drawing.Size(200, 60);
            this.commentsTextBox1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbl_assetlogsBindingNavigator
            // 
            this.tbl_assetlogsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_assetlogsBindingNavigator.BindingSource = this.tbl_assetlogsBindingSource;
            this.tbl_assetlogsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_assetlogsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.tbl_assetlogsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_assetlogsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_assetlogsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_assetlogsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_assetlogsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_assetlogsBindingNavigator.Name = "tbl_assetlogsBindingNavigator";
            this.tbl_assetlogsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_assetlogsBindingNavigator.Size = new System.Drawing.Size(973, 27);
            this.tbl_assetlogsBindingNavigator.TabIndex = 16;
            this.tbl_assetlogsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnClose.Location = new System.Drawing.Point(203, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 41);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnUpdateDatabase.FlatAppearance.BorderSize = 0;
            this.btnUpdateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDatabase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnUpdateDatabase.Location = new System.Drawing.Point(12, 43);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(135, 41);
            this.btnUpdateDatabase.TabIndex = 77;
            this.btnUpdateDatabase.Text = "SAVE UPDATES";
            this.btnUpdateDatabase.UseVisualStyleBackColor = false;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(dateDueLabel);
            this.panel1.Controls.Add(this.dateDueDateTimePicker);
            this.panel1.Controls.Add(this.technicianComboBox);
            this.panel1.Controls.Add(siteNameLabel);
            this.panel1.Controls.Add(this.siteNameComboBox);
            this.panel1.Controls.Add(equipmentIDLabel);
            this.panel1.Controls.Add(this.equipmentIDTextBox1);
            this.panel1.Controls.Add(dateLabel);
            this.panel1.Controls.Add(this.dateDateTimePicker1);
            this.panel1.Controls.Add(workOrderNoLabel);
            this.panel1.Controls.Add(this.workOrderNoTextBox1);
            this.panel1.Controls.Add(reasonLabel);
            this.panel1.Controls.Add(this.reasonTextBox1);
            this.panel1.Controls.Add(technicianLabel);
            this.panel1.Controls.Add(actionTakenLabel);
            this.panel1.Controls.Add(this.actionTakenTextBox1);
            this.panel1.Controls.Add(commentsLabel);
            this.panel1.Controls.Add(this.commentsTextBox1);
            this.panel1.Location = new System.Drawing.Point(598, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 412);
            this.panel1.TabIndex = 78;
            // 
            // dateDueDateTimePicker
            // 
            this.dateDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetlogsBindingSource, "DateDue", true));
            this.dateDueDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDueDateTimePicker.Location = new System.Drawing.Point(191, 94);
            this.dateDueDateTimePicker.Name = "dateDueDateTimePicker";
            this.dateDueDateTimePicker.Size = new System.Drawing.Size(149, 23);
            this.dateDueDateTimePicker.TabIndex = 80;
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "Technician", true));
            this.technicianComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(140, 223);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(200, 23);
            this.technicianComboBox.TabIndex = 79;
            // 
            // siteNameComboBox
            // 
            this.siteNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetlogsBindingSource, "SiteName", true));
            this.siteNameComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteNameComboBox.FormattingEnabled = true;
            this.siteNameComboBox.Location = new System.Drawing.Point(233, 41);
            this.siteNameComboBox.Name = "siteNameComboBox";
            this.siteNameComboBox.Size = new System.Drawing.Size(107, 23);
            this.siteNameComboBox.TabIndex = 78;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnUpdateDatabase);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(600, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 94);
            this.panel2.TabIndex = 79;
            // 
            // cmbSiteName
            // 
            this.cmbSiteName.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSiteName.FormattingEnabled = true;
            this.cmbSiteName.Location = new System.Drawing.Point(272, 63);
            this.cmbSiteName.Name = "cmbSiteName";
            this.cmbSiteName.Size = new System.Drawing.Size(94, 22);
            this.cmbSiteName.TabIndex = 79;
            this.cmbSiteName.SelectionChangeCommitted += new System.EventHandler(this.cmbSiteName_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(163, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "SHOW BY AREA:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbSiteName);
            this.panel3.Controls.Add(this.txbSearchOn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSearchOn);
            this.panel3.Location = new System.Drawing.Point(11, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 93);
            this.panel3.TabIndex = 80;
            // 
            // txbSearchOn
            // 
            this.txbSearchOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchOn.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchOn.Location = new System.Drawing.Point(272, 20);
            this.txbSearchOn.Name = "txbSearchOn";
            this.txbSearchOn.Size = new System.Drawing.Size(179, 22);
            this.txbSearchOn.TabIndex = 257;
            this.txbSearchOn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchOn_KeyPress);
            // 
            // btnSearchOn
            // 
            this.btnSearchOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSearchOn.FlatAppearance.BorderSize = 0;
            this.btnSearchOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSearchOn.Location = new System.Drawing.Point(15, 16);
            this.btnSearchOn.Name = "btnSearchOn";
            this.btnSearchOn.Size = new System.Drawing.Size(241, 37);
            this.btnSearchOn.TabIndex = 256;
            this.btnSearchOn.Text = "SEARCH ON Equipment ID";
            this.btnSearchOn.UseVisualStyleBackColor = false;
            this.btnSearchOn.Click += new System.EventHandler(this.btnSearchOn_Click);
            // 
            // ShowAssetLogsFrm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(973, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_assetlogsBindingNavigator);
            this.Controls.Add(this.tbl_assetlogsDataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(989, 609);
            this.Name = "ShowAssetLogsFrm";
            this.Activated += new System.EventHandler(this.AssetLogsFrm_Activated);
            this.Load += new System.EventHandler(this.AssetLogsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetlogsBindingNavigator)).EndInit();
            this.tbl_assetlogsBindingNavigator.ResumeLayout(false);
            this.tbl_assetlogsBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
       
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_assetlogsBindingSource;
        private eped_db1DataSetTableAdapters.tbl_assetlogsTableAdapter tbl_assetlogsTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_assetlogsDataGridView1;
        private System.Windows.Forms.TextBox equipmentIDTextBox1;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker1;
        private System.Windows.Forms.TextBox workOrderNoTextBox1;
        private System.Windows.Forms.TextBox reasonTextBox1;
        private System.Windows.Forms.TextBox actionTakenTextBox1;
        private System.Windows.Forms.TextBox commentsTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingNavigator tbl_assetlogsBindingNavigator;
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
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox siteNameComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbSiteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox txbSearchOn;
        internal System.Windows.Forms.Button btnSearchOn;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDue;
        private System.Windows.Forms.DateTimePicker dateDueDateTimePicker;
    }
}