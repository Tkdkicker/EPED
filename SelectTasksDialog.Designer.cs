namespace EPED
{
    partial class SelectTasksDialog
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
            System.Windows.Forms.Label taskLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label linkToInstructionLabel;
            System.Windows.Forms.Label consequencesIfNotPerformedLabel;
            System.Windows.Forms.Label perpetualNotesLabel;
            System.Windows.Forms.Label estimatedDownTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTasksDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbTech = new System.Windows.Forms.ComboBox();
            this.cmbFreq = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbl_pmtasksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_pmtasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
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
            this.tbl_pmtasksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_pmtasksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl3 = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.linkToInstructionTextBox = new System.Windows.Forms.TextBox();
            this.consequencesIfNotPerformedTextBox = new System.Windows.Forms.TextBox();
            this.perpetualNotesTextBox = new System.Windows.Forms.TextBox();
            this.estimatedDownTimeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.estimatedDownTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbGroupAllocation = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTaskAllocation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbl_pmtasksTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_pmtasksTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            taskLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            linkToInstructionLabel = new System.Windows.Forms.Label();
            consequencesIfNotPerformedLabel = new System.Windows.Forms.Label();
            perpetualNotesLabel = new System.Windows.Forms.Label();
            estimatedDownTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingNavigator)).BeginInit();
            this.tbl_pmtasksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            taskLabel.Location = new System.Drawing.Point(3, 22);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new System.Drawing.Size(34, 15);
            taskLabel.TabIndex = 40;
            taskLabel.Text = "Task:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            locationLabel.Location = new System.Drawing.Point(3, 53);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(56, 15);
            locationLabel.TabIndex = 42;
            locationLabel.Text = "Location:";
            // 
            // linkToInstructionLabel
            // 
            linkToInstructionLabel.AutoSize = true;
            linkToInstructionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkToInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            linkToInstructionLabel.Location = new System.Drawing.Point(3, 83);
            linkToInstructionLabel.Name = "linkToInstructionLabel";
            linkToInstructionLabel.Size = new System.Drawing.Size(110, 15);
            linkToInstructionLabel.TabIndex = 44;
            linkToInstructionLabel.Text = "Link To Instruction:";
            // 
            // consequencesIfNotPerformedLabel
            // 
            consequencesIfNotPerformedLabel.AutoSize = true;
            consequencesIfNotPerformedLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            consequencesIfNotPerformedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            consequencesIfNotPerformedLabel.Location = new System.Drawing.Point(3, 115);
            consequencesIfNotPerformedLabel.Name = "consequencesIfNotPerformedLabel";
            consequencesIfNotPerformedLabel.Size = new System.Drawing.Size(181, 15);
            consequencesIfNotPerformedLabel.TabIndex = 46;
            consequencesIfNotPerformedLabel.Text = "Consequences If Not Performed:";
            // 
            // perpetualNotesLabel
            // 
            perpetualNotesLabel.AutoSize = true;
            perpetualNotesLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            perpetualNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            perpetualNotesLabel.Location = new System.Drawing.Point(3, 220);
            perpetualNotesLabel.Name = "perpetualNotesLabel";
            perpetualNotesLabel.Size = new System.Drawing.Size(97, 15);
            perpetualNotesLabel.TabIndex = 48;
            perpetualNotesLabel.Text = "Perpetual Notes:";
            // 
            // estimatedDownTimeLabel
            // 
            estimatedDownTimeLabel.AutoSize = true;
            estimatedDownTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estimatedDownTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            estimatedDownTimeLabel.Location = new System.Drawing.Point(3, 332);
            estimatedDownTimeLabel.Name = "estimatedDownTimeLabel";
            estimatedDownTimeLabel.Size = new System.Drawing.Size(126, 15);
            estimatedDownTimeLabel.TabIndex = 50;
            estimatedDownTimeLabel.Text = "Estimated Down Time:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSave.Location = new System.Drawing.Point(704, 518);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 41);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Add selected task to active asset";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnClose.Location = new System.Drawing.Point(1022, 518);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 41);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbTech
            // 
            this.cmbTech.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTech.FormattingEnabled = true;
            this.cmbTech.Location = new System.Drawing.Point(169, 50);
            this.cmbTech.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTech.Name = "cmbTech";
            this.cmbTech.Size = new System.Drawing.Size(145, 23);
            this.cmbTech.TabIndex = 34;
            // 
            // cmbFreq
            // 
            this.cmbFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFreq.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFreq.FormattingEnabled = true;
            this.cmbFreq.Items.AddRange(new object[] {
            "WEEKLY",
            "FORTNIGHTLY",
            "MONTHLY",
            "QUARTERLY",
            "6MONTHS",
            "YEARLY"});
            this.cmbFreq.Location = new System.Drawing.Point(169, 82);
            this.cmbFreq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFreq.Name = "cmbFreq";
            this.cmbFreq.Size = new System.Drawing.Size(145, 23);
            this.cmbFreq.TabIndex = 35;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl1.Location = new System.Drawing.Point(15, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 15);
            this.lbl1.TabIndex = 36;
            this.lbl1.Text = "Technician";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl2.Location = new System.Drawing.Point(15, 86);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(63, 15);
            this.lbl2.TabIndex = 37;
            this.lbl2.Text = "Frequency";
            // 
            // tbl_pmtasksBindingNavigator
            // 
            this.tbl_pmtasksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_pmtasksBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_pmtasksBindingNavigator.BindingSource = this.tbl_pmtasksBindingSource;
            this.tbl_pmtasksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_pmtasksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_pmtasksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_pmtasksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_pmtasksBindingNavigatorSaveItem});
            this.tbl_pmtasksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_pmtasksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_pmtasksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_pmtasksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_pmtasksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_pmtasksBindingNavigator.Name = "tbl_pmtasksBindingNavigator";
            this.tbl_pmtasksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_pmtasksBindingNavigator.Size = new System.Drawing.Size(1145, 27);
            this.tbl_pmtasksBindingNavigator.TabIndex = 38;
            this.tbl_pmtasksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbl_pmtasksBindingSource
            // 
            this.tbl_pmtasksBindingSource.DataMember = "tbl_pmtasks";
            this.tbl_pmtasksBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
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
            // tbl_pmtasksBindingNavigatorSaveItem
            // 
            this.tbl_pmtasksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_pmtasksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_pmtasksBindingNavigatorSaveItem.Image")));
            this.tbl_pmtasksBindingNavigatorSaveItem.Name = "tbl_pmtasksBindingNavigatorSaveItem";
            this.tbl_pmtasksBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_pmtasksBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_pmtasksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_pmtasksBindingNavigatorSaveItem_Click_1);
            // 
            // tbl_pmtasksDataGridView
            // 
            this.tbl_pmtasksDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tbl_pmtasksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_pmtasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_pmtasksDataGridView.AutoGenerateColumns = false;
            this.tbl_pmtasksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_pmtasksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_pmtasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pmtasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tbl_pmtasksDataGridView.DataSource = this.tbl_pmtasksBindingSource;
            this.tbl_pmtasksDataGridView.Location = new System.Drawing.Point(14, 54);
            this.tbl_pmtasksDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbl_pmtasksDataGridView.Name = "tbl_pmtasksDataGridView";
            this.tbl_pmtasksDataGridView.RowHeadersWidth = 51;
            this.tbl_pmtasksDataGridView.Size = new System.Drawing.Size(675, 282);
            this.tbl_pmtasksDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Task";
            this.dataGridViewTextBoxColumn1.HeaderText = "Task";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn2.HeaderText = "Location";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LinkToInstruction";
            this.dataGridViewTextBoxColumn3.HeaderText = "LinkToInstruction";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ConsequencesIfNotPerformed";
            this.dataGridViewTextBoxColumn4.HeaderText = "ConsequencesIfNotPerformed";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 198;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PerpetualNotes";
            this.dataGridViewTextBoxColumn5.HeaderText = "PerpetualNotes";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 119;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EstimatedDownTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "EstimatedDownTime";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 146;
            // 
            // tpStartDate
            // 
            this.tpStartDate.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpStartDate.Location = new System.Drawing.Point(169, 113);
            this.tpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpStartDate.Name = "tpStartDate";
            this.tpStartDate.Size = new System.Drawing.Size(145, 23);
            this.tpStartDate.TabIndex = 39;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl3.Location = new System.Drawing.Point(15, 117);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(60, 15);
            this.lbl3.TabIndex = 40;
            this.lbl3.Text = "Start date";
            // 
            // taskTextBox
            // 
            this.taskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "Task", true));
            this.taskTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTextBox.Location = new System.Drawing.Point(219, 14);
            this.taskTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(202, 23);
            this.taskTextBox.TabIndex = 41;
            this.taskTextBox.TextChanged += new System.EventHandler(this.taskTextBox_TextChanged);
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "Location", true));
            this.locationComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(281, 50);
            this.locationComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(140, 23);
            this.locationComboBox.TabIndex = 43;
            // 
            // linkToInstructionTextBox
            // 
            this.linkToInstructionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkToInstructionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "LinkToInstruction", true));
            this.linkToInstructionTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToInstructionTextBox.Location = new System.Drawing.Point(119, 79);
            this.linkToInstructionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.linkToInstructionTextBox.Name = "linkToInstructionTextBox";
            this.linkToInstructionTextBox.Size = new System.Drawing.Size(302, 23);
            this.linkToInstructionTextBox.TabIndex = 45;
            // 
            // consequencesIfNotPerformedTextBox
            // 
            this.consequencesIfNotPerformedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consequencesIfNotPerformedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "ConsequencesIfNotPerformed", true));
            this.consequencesIfNotPerformedTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consequencesIfNotPerformedTextBox.Location = new System.Drawing.Point(219, 110);
            this.consequencesIfNotPerformedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.consequencesIfNotPerformedTextBox.Multiline = true;
            this.consequencesIfNotPerformedTextBox.Name = "consequencesIfNotPerformedTextBox";
            this.consequencesIfNotPerformedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consequencesIfNotPerformedTextBox.Size = new System.Drawing.Size(202, 96);
            this.consequencesIfNotPerformedTextBox.TabIndex = 47;
            // 
            // perpetualNotesTextBox
            // 
            this.perpetualNotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perpetualNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "PerpetualNotes", true));
            this.perpetualNotesTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perpetualNotesTextBox.Location = new System.Drawing.Point(219, 214);
            this.perpetualNotesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.perpetualNotesTextBox.Multiline = true;
            this.perpetualNotesTextBox.Name = "perpetualNotesTextBox";
            this.perpetualNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.perpetualNotesTextBox.Size = new System.Drawing.Size(202, 104);
            this.perpetualNotesTextBox.TabIndex = 49;
            // 
            // estimatedDownTimeComboBox
            // 
            this.estimatedDownTimeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "EstimatedDownTime", true));
            this.estimatedDownTimeComboBox.Enabled = false;
            this.estimatedDownTimeComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedDownTimeComboBox.FormattingEnabled = true;
            this.estimatedDownTimeComboBox.Location = new System.Drawing.Point(219, 384);
            this.estimatedDownTimeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.estimatedDownTimeComboBox.Name = "estimatedDownTimeComboBox";
            this.estimatedDownTimeComboBox.Size = new System.Drawing.Size(140, 23);
            this.estimatedDownTimeComboBox.TabIndex = 51;
            this.estimatedDownTimeComboBox.Visible = false;
            this.estimatedDownTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.estimatedDownTimeComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.estimatedDownTimePicker);
            this.panel1.Controls.Add(taskLabel);
            this.panel1.Controls.Add(this.taskTextBox);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationComboBox);
            this.panel1.Controls.Add(linkToInstructionLabel);
            this.panel1.Controls.Add(this.linkToInstructionTextBox);
            this.panel1.Controls.Add(consequencesIfNotPerformedLabel);
            this.panel1.Controls.Add(this.consequencesIfNotPerformedTextBox);
            this.panel1.Controls.Add(perpetualNotesLabel);
            this.panel1.Controls.Add(this.perpetualNotesTextBox);
            this.panel1.Controls.Add(estimatedDownTimeLabel);
            this.panel1.Controls.Add(this.estimatedDownTimeComboBox);
            this.panel1.Location = new System.Drawing.Point(704, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 413);
            this.panel1.TabIndex = 52;
            // 
            // estimatedDownTimePicker
            // 
            this.estimatedDownTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "EstimatedDownTime", true));
            this.estimatedDownTimePicker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedDownTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.estimatedDownTimePicker.Location = new System.Drawing.Point(219, 329);
            this.estimatedDownTimePicker.Name = "estimatedDownTimePicker";
            this.estimatedDownTimePicker.ShowUpDown = true;
            this.estimatedDownTimePicker.Size = new System.Drawing.Size(200, 23);
            this.estimatedDownTimePicker.TabIndex = 52;
            this.estimatedDownTimePicker.Value = new System.DateTime(2021, 8, 30, 0, 0, 0, 0);
            // 
            // cmbGroupAllocation
            // 
            this.cmbGroupAllocation.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupAllocation.FormattingEnabled = true;
            this.cmbGroupAllocation.Items.AddRange(new object[] {
            "WEEKLY",
            "FORTNIGHTLY",
            "MONTHLY",
            "QUARTERLY",
            "6MONTHS",
            "YEARLY"});
            this.cmbGroupAllocation.Location = new System.Drawing.Point(169, 150);
            this.cmbGroupAllocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGroupAllocation.Name = "cmbGroupAllocation";
            this.cmbGroupAllocation.Size = new System.Drawing.Size(145, 23);
            this.cmbGroupAllocation.TabIndex = 53;
            this.cmbGroupAllocation.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl4.Location = new System.Drawing.Point(15, 150);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(108, 15);
            this.lbl4.TabIndex = 55;
            this.lbl4.Text = "Equipment part of:";
            this.lbl4.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lblTaskAllocation);
            this.panel2.Controls.Add(this.lbl4);
            this.panel2.Controls.Add(this.cmbGroupAllocation);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.tpStartDate);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.cmbFreq);
            this.panel2.Controls.Add(this.cmbTech);
            this.panel2.Location = new System.Drawing.Point(14, 344);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 219);
            this.panel2.TabIndex = 56;
            // 
            // lblTaskAllocation
            // 
            this.lblTaskAllocation.AutoSize = true;
            this.lblTaskAllocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskAllocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblTaskAllocation.Location = new System.Drawing.Point(17, 13);
            this.lblTaskAllocation.Name = "lblTaskAllocation";
            this.lblTaskAllocation.Size = new System.Drawing.Size(117, 19);
            this.lblTaskAllocation.TabIndex = 56;
            this.lblTaskAllocation.Text = "Task Allocations";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(385, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 220);
            this.panel3.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 57;
            this.label8.Text = "Filters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(3, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Estimated down time";
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(138, 184);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(166, 23);
            this.comboBox6.TabIndex = 46;
            this.comboBox6.Text = "ALL";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Perpetual notes";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(138, 155);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(166, 23);
            this.comboBox5.TabIndex = 44;
            this.comboBox5.Text = "ALL";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Consequences";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(138, 126);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(166, 23);
            this.comboBox4.TabIndex = 42;
            this.comboBox4.Text = "ALL";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Link to instructions";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(138, 99);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(166, 23);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.Text = "ALL";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Location";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(138, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 23);
            this.comboBox2.TabIndex = 38;
            this.comboBox2.Text = "ALL";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tasks";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "ALL";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // tbl_pmtasksTableAdapter
            // 
            this.tbl_pmtasksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = null;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = null;
            this.tableAdapterManager.tbl_colorTableAdapter = null;
            this.tableAdapterManager.tbl_partslistTableAdapter = null;
            this.tableAdapterManager.tbl_pmscheduleTableAdapter = null;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = this.tbl_pmtasksTableAdapter;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = null;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SelectTasksDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1145, 599);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_pmtasksDataGridView);
            this.Controls.Add(this.tbl_pmtasksBindingNavigator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1161, 615);
            this.Name = "SelectTasksDialog";
            this.Text = "Select Tasks Dialog";
            this.Activated += new System.EventHandler(this.SelectTasksDialog_Activated);
            this.Load += new System.EventHandler(this.SelectTasksDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingNavigator)).EndInit();
            this.tbl_pmtasksBindingNavigator.ResumeLayout(false);
            this.tbl_pmtasksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbTech;
        private System.Windows.Forms.ComboBox cmbFreq;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_pmtasksBindingSource;
        private eped_db1DataSetTableAdapters.tbl_pmtasksTableAdapter tbl_pmtasksTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_pmtasksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_pmtasksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbl_pmtasksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker tpStartDate;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.TextBox linkToInstructionTextBox;
        private System.Windows.Forms.TextBox consequencesIfNotPerformedTextBox;
        private System.Windows.Forms.TextBox perpetualNotesTextBox;
        private System.Windows.Forms.ComboBox estimatedDownTimeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGroupAllocation;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTaskAllocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker estimatedDownTimePicker;
    }
}