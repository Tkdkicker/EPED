namespace EPED
{
    partial class ShowWorksOrderFrm
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
            System.Windows.Forms.Label jobIdNoLabel;
            System.Windows.Forms.Label assetIDLabel;
            System.Windows.Forms.Label equipmentNameLabel;
            System.Windows.Forms.Label jobAllocationToLabel;
            System.Windows.Forms.Label dateJobAllocatedLabel;
            System.Windows.Forms.Label emailSentLabel;
            System.Windows.Forms.Label dateJobCompletedLabel;
            System.Windows.Forms.Label workSheetLocationLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label requiredCompletionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowWorksOrderFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.tbl_worksordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_worksordersTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_worksordersTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_worksordersBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_worksordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbEmailSent = new System.Windows.Forms.CheckBox();
            this.jobIdNoTextBox = new System.Windows.Forms.TextBox();
            this.assetIDTextBox = new System.Windows.Forms.TextBox();
            this.equipmentNameTextBox = new System.Windows.Forms.TextBox();
            this.jobAllocationToTextBox = new System.Windows.Forms.TextBox();
            this.dateJobAllocatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateJobCompletedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workSheetLocationTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.requiredCompletionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmailTech = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btnUpdateDatabase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            jobIdNoLabel = new System.Windows.Forms.Label();
            assetIDLabel = new System.Windows.Forms.Label();
            equipmentNameLabel = new System.Windows.Forms.Label();
            jobAllocationToLabel = new System.Windows.Forms.Label();
            dateJobAllocatedLabel = new System.Windows.Forms.Label();
            emailSentLabel = new System.Windows.Forms.Label();
            dateJobCompletedLabel = new System.Windows.Forms.Label();
            workSheetLocationLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            requiredCompletionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_worksordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_worksordersBindingSource1BindingNavigator)).BeginInit();
            this.tbl_worksordersBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_worksordersDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // jobIdNoLabel
            // 
            jobIdNoLabel.AutoSize = true;
            jobIdNoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobIdNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            jobIdNoLabel.Location = new System.Drawing.Point(10, 11);
            jobIdNoLabel.Name = "jobIdNoLabel";
            jobIdNoLabel.Size = new System.Drawing.Size(60, 15);
            jobIdNoLabel.TabIndex = 0;
            jobIdNoLabel.Text = "Job Id No:";
            // 
            // assetIDLabel
            // 
            assetIDLabel.AutoSize = true;
            assetIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            assetIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            assetIDLabel.Location = new System.Drawing.Point(10, 37);
            assetIDLabel.Name = "assetIDLabel";
            assetIDLabel.Size = new System.Drawing.Size(54, 15);
            assetIDLabel.TabIndex = 2;
            assetIDLabel.Text = "Asset ID:";
            // 
            // equipmentNameLabel
            // 
            equipmentNameLabel.AutoSize = true;
            equipmentNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentNameLabel.Location = new System.Drawing.Point(10, 84);
            equipmentNameLabel.Name = "equipmentNameLabel";
            equipmentNameLabel.Size = new System.Drawing.Size(102, 15);
            equipmentNameLabel.TabIndex = 4;
            equipmentNameLabel.Text = "Equipment Name:";
            // 
            // jobAllocationToLabel
            // 
            jobAllocationToLabel.AutoSize = true;
            jobAllocationToLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobAllocationToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            jobAllocationToLabel.Location = new System.Drawing.Point(10, 133);
            jobAllocationToLabel.Name = "jobAllocationToLabel";
            jobAllocationToLabel.Size = new System.Drawing.Size(102, 15);
            jobAllocationToLabel.TabIndex = 6;
            jobAllocationToLabel.Text = "Job Allocation To:";
            // 
            // dateJobAllocatedLabel
            // 
            dateJobAllocatedLabel.AutoSize = true;
            dateJobAllocatedLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateJobAllocatedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateJobAllocatedLabel.Location = new System.Drawing.Point(10, 160);
            dateJobAllocatedLabel.Name = "dateJobAllocatedLabel";
            dateJobAllocatedLabel.Size = new System.Drawing.Size(111, 15);
            dateJobAllocatedLabel.TabIndex = 8;
            dateJobAllocatedLabel.Text = "Date Job Allocated:";
            // 
            // emailSentLabel
            // 
            emailSentLabel.AutoSize = true;
            emailSentLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailSentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            emailSentLabel.Location = new System.Drawing.Point(10, 185);
            emailSentLabel.Name = "emailSentLabel";
            emailSentLabel.Size = new System.Drawing.Size(67, 15);
            emailSentLabel.TabIndex = 10;
            emailSentLabel.Text = "Email Sent:";
            // 
            // dateJobCompletedLabel
            // 
            dateJobCompletedLabel.AutoSize = true;
            dateJobCompletedLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateJobCompletedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateJobCompletedLabel.Location = new System.Drawing.Point(10, 212);
            dateJobCompletedLabel.Name = "dateJobCompletedLabel";
            dateJobCompletedLabel.Size = new System.Drawing.Size(117, 15);
            dateJobCompletedLabel.TabIndex = 12;
            dateJobCompletedLabel.Text = "Date Job Completed:";
            // 
            // workSheetLocationLabel
            // 
            workSheetLocationLabel.AutoSize = true;
            workSheetLocationLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            workSheetLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            workSheetLocationLabel.Location = new System.Drawing.Point(10, 237);
            workSheetLocationLabel.Name = "workSheetLocationLabel";
            workSheetLocationLabel.Size = new System.Drawing.Size(120, 15);
            workSheetLocationLabel.TabIndex = 14;
            workSheetLocationLabel.Text = "Work Sheet Location:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            notesLabel.Location = new System.Drawing.Point(10, 263);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(41, 15);
            notesLabel.TabIndex = 16;
            notesLabel.Text = "Notes:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priorityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            priorityLabel.Location = new System.Drawing.Point(10, 355);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(52, 15);
            priorityLabel.TabIndex = 18;
            priorityLabel.Text = "Priority:";
            // 
            // requiredCompletionLabel
            // 
            requiredCompletionLabel.AutoSize = true;
            requiredCompletionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requiredCompletionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            requiredCompletionLabel.Location = new System.Drawing.Point(10, 382);
            requiredCompletionLabel.Name = "requiredCompletionLabel";
            requiredCompletionLabel.Size = new System.Drawing.Size(124, 15);
            requiredCompletionLabel.TabIndex = 20;
            requiredCompletionLabel.Text = "Required Completion:";
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_worksordersBindingSource
            // 
            this.tbl_worksordersBindingSource.DataMember = "tbl_worksorders";
            this.tbl_worksordersBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // tbl_worksordersTableAdapter
            // 
            this.tbl_worksordersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbl_usersTableAdapter = null;
            this.tableAdapterManager.tbl_worksordersTableAdapter = this.tbl_worksordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_worksordersBindingSource1BindingNavigator
            // 
            this.tbl_worksordersBindingSource1BindingNavigator.AddNewItem = null;
            this.tbl_worksordersBindingSource1BindingNavigator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbl_worksordersBindingSource1BindingNavigator.BindingSource = this.tbl_worksordersBindingSource;
            this.tbl_worksordersBindingSource1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_worksordersBindingSource1BindingNavigator.DeleteItem = null;
            this.tbl_worksordersBindingSource1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_worksordersBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tbl_worksordersBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_worksordersBindingSource1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_worksordersBindingSource1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_worksordersBindingSource1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_worksordersBindingSource1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_worksordersBindingSource1BindingNavigator.Name = "tbl_worksordersBindingSource1BindingNavigator";
            this.tbl_worksordersBindingSource1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_worksordersBindingSource1BindingNavigator.Size = new System.Drawing.Size(988, 27);
            this.tbl_worksordersBindingSource1BindingNavigator.TabIndex = 0;
            this.tbl_worksordersBindingSource1BindingNavigator.Text = "bindingNavigator1";
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
            // tbl_worksordersDataGridView
            // 
            this.tbl_worksordersDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tbl_worksordersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_worksordersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_worksordersDataGridView.AutoGenerateColumns = false;
            this.tbl_worksordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_worksordersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_worksordersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbl_worksordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_worksordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31});
            this.tbl_worksordersDataGridView.DataSource = this.tbl_worksordersBindingSource;
            this.tbl_worksordersDataGridView.Location = new System.Drawing.Point(12, 28);
            this.tbl_worksordersDataGridView.MultiSelect = false;
            this.tbl_worksordersDataGridView.Name = "tbl_worksordersDataGridView";
            this.tbl_worksordersDataGridView.RowHeadersWidth = 51;
            this.tbl_worksordersDataGridView.Size = new System.Drawing.Size(570, 288);
            this.tbl_worksordersDataGridView.TabIndex = 1;
            this.tbl_worksordersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_worksordersDataGridView2_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "JobIdNo";
            this.dataGridViewTextBoxColumn21.HeaderText = "JobIdNo";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 76;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "AssetID";
            this.dataGridViewTextBoxColumn22.HeaderText = "AssetID";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 73;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "EquipmentName";
            this.dataGridViewTextBoxColumn23.HeaderText = "EquipmentName";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "JobAllocationTo";
            this.dataGridViewTextBoxColumn24.HeaderText = "JobAllocationTo";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 116;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "DateJobAllocated";
            this.dataGridViewTextBoxColumn25.HeaderText = "DateJobAllocated";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 127;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "EmailSent";
            this.dataGridViewTextBoxColumn26.HeaderText = "EmailSent";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn26.Width = 86;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "DateJobCompleted";
            this.dataGridViewTextBoxColumn27.HeaderText = "DateJobCompleted";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 137;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "WorkSheetLocation";
            this.dataGridViewTextBoxColumn28.HeaderText = "WorkSheetLocation";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 139;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn29.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 65;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Priority";
            this.dataGridViewTextBoxColumn30.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 73;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "RequiredCompletion";
            this.dataGridViewTextBoxColumn31.HeaderText = "RequiredCompletion";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 146;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbEmailSent);
            this.panel2.Controls.Add(jobIdNoLabel);
            this.panel2.Controls.Add(this.jobIdNoTextBox);
            this.panel2.Controls.Add(assetIDLabel);
            this.panel2.Controls.Add(this.assetIDTextBox);
            this.panel2.Controls.Add(equipmentNameLabel);
            this.panel2.Controls.Add(this.equipmentNameTextBox);
            this.panel2.Controls.Add(jobAllocationToLabel);
            this.panel2.Controls.Add(this.jobAllocationToTextBox);
            this.panel2.Controls.Add(dateJobAllocatedLabel);
            this.panel2.Controls.Add(this.dateJobAllocatedDateTimePicker);
            this.panel2.Controls.Add(emailSentLabel);
            this.panel2.Controls.Add(dateJobCompletedLabel);
            this.panel2.Controls.Add(this.dateJobCompletedDateTimePicker);
            this.panel2.Controls.Add(workSheetLocationLabel);
            this.panel2.Controls.Add(this.workSheetLocationTextBox);
            this.panel2.Controls.Add(notesLabel);
            this.panel2.Controls.Add(this.notesTextBox);
            this.panel2.Controls.Add(priorityLabel);
            this.panel2.Controls.Add(this.priorityTextBox);
            this.panel2.Controls.Add(requiredCompletionLabel);
            this.panel2.Controls.Add(this.requiredCompletionDateTimePicker);
            this.panel2.Location = new System.Drawing.Point(606, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 420);
            this.panel2.TabIndex = 2;
            // 
            // cbEmailSent
            // 
            this.cbEmailSent.AutoSize = true;
            this.cbEmailSent.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_worksordersBindingSource, "EmailSent", true));
            this.cbEmailSent.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmailSent.Location = new System.Drawing.Point(144, 183);
            this.cbEmailSent.Name = "cbEmailSent";
            this.cbEmailSent.Size = new System.Drawing.Size(15, 14);
            this.cbEmailSent.TabIndex = 22;
            this.cbEmailSent.UseVisualStyleBackColor = true;
            // 
            // jobIdNoTextBox
            // 
            this.jobIdNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobIdNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_worksordersBindingSource, "JobIdNo", true));
            this.jobIdNoTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobIdNoTextBox.Location = new System.Drawing.Point(144, 8);
            this.jobIdNoTextBox.Name = "jobIdNoTextBox";
            this.jobIdNoTextBox.Size = new System.Drawing.Size(200, 23);
            this.jobIdNoTextBox.TabIndex = 1;
            this.jobIdNoTextBox.TextChanged += new System.EventHandler(this.jobIdNoTextBox_TextChanged);
            // 
            // assetIDTextBox
            // 
            this.assetIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assetIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_worksordersBindingSource, "AssetID", true));
            this.assetIDTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetIDTextBox.Location = new System.Drawing.Point(144, 34);
            this.assetIDTextBox.Multiline = true;
            this.assetIDTextBox.Name = "assetIDTextBox";
            this.assetIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.assetIDTextBox.Size = new System.Drawing.Size(200, 41);
            this.assetIDTextBox.TabIndex = 3;
            // 
            // equipmentNameTextBox
            // 
            this.equipmentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_worksordersBindingSource, "EquipmentName", true));
            this.equipmentNameTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentNameTextBox.Location = new System.Drawing.Point(144, 81);
            this.equipmentNameTextBox.Multiline = true;
            this.equipmentNameTextBox.Name = "equipmentNameTextBox";
            this.equipmentNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.equipmentNameTextBox.Size = new System.Drawing.Size(200, 43);
            this.equipmentNameTextBox.TabIndex = 5;
            // 
            // jobAllocationToTextBox
            // 
            this.jobAllocationToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobAllocationToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_worksordersBindingSource, "JobAllocationTo", true));
            this.jobAllocationToTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobAllocationToTextBox.Location = new System.Drawing.Point(144, 130);
            this.jobAllocationToTextBox.Name = "jobAllocationToTextBox";
            this.jobAllocationToTextBox.Size = new System.Drawing.Size(200, 23);
            this.jobAllocationToTextBox.TabIndex = 7;
            // 
            // dateJobAllocatedDateTimePicker
            // 
            this.dateJobAllocatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_worksordersBindingSource, "DateJobAllocated", true));
            this.dateJobAllocatedDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJobAllocatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateJobAllocatedDateTimePicker.Location = new System.Drawing.Point(200, 156);
            this.dateJobAllocatedDateTimePicker.Name = "dateJobAllocatedDateTimePicker";
            this.dateJobAllocatedDateTimePicker.Size = new System.Drawing.Size(144, 23);
            this.dateJobAllocatedDateTimePicker.TabIndex = 9;
            // 
            // dateJobCompletedDateTimePicker
            // 
            this.dateJobCompletedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_worksordersBindingSource, "DateJobCompleted", true));
            this.dateJobCompletedDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJobCompletedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateJobCompletedDateTimePicker.Location = new System.Drawing.Point(200, 208);
            this.dateJobCompletedDateTimePicker.Name = "dateJobCompletedDateTimePicker";
            this.dateJobCompletedDateTimePicker.Size = new System.Drawing.Size(144, 23);
            this.dateJobCompletedDateTimePicker.TabIndex = 13;
            // 
            // workSheetLocationTextBox
            // 
            this.workSheetLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workSheetLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_worksordersBindingSource, "WorkSheetLocation", true));
            this.workSheetLocationTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSheetLocationTextBox.Location = new System.Drawing.Point(144, 234);
            this.workSheetLocationTextBox.Name = "workSheetLocationTextBox";
            this.workSheetLocationTextBox.Size = new System.Drawing.Size(168, 23);
            this.workSheetLocationTextBox.TabIndex = 15;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_worksordersBindingSource, "Notes", true));
            this.notesTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(144, 260);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(200, 86);
            this.notesTextBox.TabIndex = 17;
            this.notesTextBox.TextChanged += new System.EventHandler(this.notesTextBox1_TextChanged);
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_worksordersBindingSource, "Priority", true));
            this.priorityTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTextBox.Location = new System.Drawing.Point(144, 352);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(40, 23);
            this.priorityTextBox.TabIndex = 19;
            // 
            // requiredCompletionDateTimePicker
            // 
            this.requiredCompletionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_worksordersBindingSource, "RequiredCompletion", true));
            this.requiredCompletionDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredCompletionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.requiredCompletionDateTimePicker.Location = new System.Drawing.Point(200, 378);
            this.requiredCompletionDateTimePicker.Name = "requiredCompletionDateTimePicker";
            this.requiredCompletionDateTimePicker.Size = new System.Drawing.Size(144, 23);
            this.requiredCompletionDateTimePicker.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEmailTech);
            this.panel3.Controls.Add(this.btClose);
            this.panel3.Controls.Add(this.btnUpdateDatabase);
            this.panel3.Location = new System.Drawing.Point(606, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 130);
            this.panel3.TabIndex = 3;
            // 
            // btnEmailTech
            // 
            this.btnEmailTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEmailTech.FlatAppearance.BorderSize = 0;
            this.btnEmailTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailTech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnEmailTech.Location = new System.Drawing.Point(13, 14);
            this.btnEmailTech.Name = "btnEmailTech";
            this.btnEmailTech.Size = new System.Drawing.Size(121, 41);
            this.btnEmailTech.TabIndex = 194;
            this.btnEmailTech.Text = "EMail to Technician";
            this.btnEmailTech.UseVisualStyleBackColor = false;
            this.btnEmailTech.Click += new System.EventHandler(this.OpenEmail_Button_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btClose.Location = new System.Drawing.Point(209, 74);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 38);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUpdateDatabase
            // 
            this.btnUpdateDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnUpdateDatabase.FlatAppearance.BorderSize = 0;
            this.btnUpdateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnUpdateDatabase.Location = new System.Drawing.Point(13, 74);
            this.btnUpdateDatabase.Name = "btnUpdateDatabase";
            this.btnUpdateDatabase.Size = new System.Drawing.Size(121, 38);
            this.btnUpdateDatabase.TabIndex = 0;
            this.btnUpdateDatabase.Text = "Update DATABASE";
            this.btnUpdateDatabase.UseVisualStyleBackColor = false;
            this.btnUpdateDatabase.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(570, 232);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMAIL  Message Body:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShowWorksOrderFrm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(988, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbl_worksordersDataGridView);
            this.Controls.Add(this.tbl_worksordersBindingSource1BindingNavigator);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1004, 656);
            this.Name = "ShowWorksOrderFrm";
            this.Activated += new System.EventHandler(this.WorksOrderFrm_Activated);
            this.Load += new System.EventHandler(this.WorksOrderFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_worksordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_worksordersBindingSource1BindingNavigator)).EndInit();
            this.tbl_worksordersBindingSource1BindingNavigator.ResumeLayout(false);
            this.tbl_worksordersBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_worksordersDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_worksordersBindingSource;
        private eped_db1DataSetTableAdapters.tbl_worksordersTableAdapter tbl_worksordersTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_worksordersBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tbl_worksordersDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox jobIdNoTextBox;
        private System.Windows.Forms.TextBox assetIDTextBox;
        private System.Windows.Forms.TextBox equipmentNameTextBox;
        private System.Windows.Forms.TextBox jobAllocationToTextBox;
        private System.Windows.Forms.DateTimePicker dateJobAllocatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateJobCompletedDateTimePicker;
        private System.Windows.Forms.TextBox workSheetLocationTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.DateTimePicker requiredCompletionDateTimePicker;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnEmailTech;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.CheckBox cbEmailSent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        }
}