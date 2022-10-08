namespace EPED
{
    partial class ShowPartsListFrm
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
            System.Windows.Forms.Label supplierPartNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label effectAssetNumberLabel;
            System.Windows.Forms.Label criticalLabel;
            System.Windows.Forms.Label internalStockLevelLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label leadTimeLabel;
            System.Windows.Forms.Label lastFittedLabel;
            System.Windows.Forms.Label groupAllocationLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label minStockLevelLabel;
            System.Windows.Forms.Label nextDueLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label siteNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPartsListFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.criticalCheckBox = new System.Windows.Forms.CheckBox();
            this.tbl_partslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.siteNameComboBox = new System.Windows.Forms.ComboBox();
            this.nextDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minStockLevelTextBox = new System.Windows.Forms.TextBox();
            this.groupAllocationComboBox = new System.Windows.Forms.ComboBox();
            this.supplierPartNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.effectAssetNumberTextBox = new System.Windows.Forms.TextBox();
            this.internalStockLevelTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.leadTimeTextBox = new System.Windows.Forms.TextBox();
            this.lastFittedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.txbSearchOn = new System.Windows.Forms.TextBox();
            this.btnSearchOn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbGroupAllocation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbl_partslistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_partslistBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_partslistDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinStockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbSetGroupAllocation = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbSiteName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_partslistTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_partslistTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMid = new System.Windows.Forms.Label();
            this.lblAbove = new System.Windows.Forms.Label();
            this.lblBelow = new System.Windows.Forms.Label();
            supplierPartNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            effectAssetNumberLabel = new System.Windows.Forms.Label();
            criticalLabel = new System.Windows.Forms.Label();
            internalStockLevelLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            leadTimeLabel = new System.Windows.Forms.Label();
            lastFittedLabel = new System.Windows.Forms.Label();
            groupAllocationLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            minStockLevelLabel = new System.Windows.Forms.Label();
            nextDueLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            siteNameLabel = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partslistBindingNavigator)).BeginInit();
            this.tbl_partslistBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partslistDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierPartNumberLabel
            // 
            supplierPartNumberLabel.AutoSize = true;
            supplierPartNumberLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierPartNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            supplierPartNumberLabel.Location = new System.Drawing.Point(14, 10);
            supplierPartNumberLabel.Name = "supplierPartNumberLabel";
            supplierPartNumberLabel.Size = new System.Drawing.Size(128, 15);
            supplierPartNumberLabel.TabIndex = 0;
            supplierPartNumberLabel.Text = "Supplier Part Number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            descriptionLabel.Location = new System.Drawing.Point(14, 70);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(73, 15);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            supplierLabel.Location = new System.Drawing.Point(14, 120);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(56, 15);
            supplierLabel.TabIndex = 4;
            supplierLabel.Text = "Supplier:";
            // 
            // effectAssetNumberLabel
            // 
            effectAssetNumberLabel.AutoSize = true;
            effectAssetNumberLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            effectAssetNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            effectAssetNumberLabel.Location = new System.Drawing.Point(14, 146);
            effectAssetNumberLabel.Name = "effectAssetNumberLabel";
            effectAssetNumberLabel.Size = new System.Drawing.Size(118, 15);
            effectAssetNumberLabel.TabIndex = 6;
            effectAssetNumberLabel.Text = "Effect Asset Number:";
            // 
            // criticalLabel
            // 
            criticalLabel.AutoSize = true;
            criticalLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            criticalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            criticalLabel.Location = new System.Drawing.Point(14, 172);
            criticalLabel.Name = "criticalLabel";
            criticalLabel.Size = new System.Drawing.Size(50, 15);
            criticalLabel.TabIndex = 8;
            criticalLabel.Text = "Critical:";
            // 
            // internalStockLevelLabel
            // 
            internalStockLevelLabel.AutoSize = true;
            internalStockLevelLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            internalStockLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            internalStockLevelLabel.Location = new System.Drawing.Point(14, 224);
            internalStockLevelLabel.Name = "internalStockLevelLabel";
            internalStockLevelLabel.Size = new System.Drawing.Size(116, 15);
            internalStockLevelLabel.TabIndex = 12;
            internalStockLevelLabel.Text = "Internal Stock Level:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            costLabel.Location = new System.Drawing.Point(14, 250);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(34, 15);
            costLabel.TabIndex = 14;
            costLabel.Text = "Cost:";
            // 
            // leadTimeLabel
            // 
            leadTimeLabel.AutoSize = true;
            leadTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            leadTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            leadTimeLabel.Location = new System.Drawing.Point(14, 276);
            leadTimeLabel.Name = "leadTimeLabel";
            leadTimeLabel.Size = new System.Drawing.Size(64, 15);
            leadTimeLabel.TabIndex = 16;
            leadTimeLabel.Text = "Lead Time:";
            // 
            // lastFittedLabel
            // 
            lastFittedLabel.AutoSize = true;
            lastFittedLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastFittedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            lastFittedLabel.Location = new System.Drawing.Point(14, 303);
            lastFittedLabel.Name = "lastFittedLabel";
            lastFittedLabel.Size = new System.Drawing.Size(66, 15);
            lastFittedLabel.TabIndex = 18;
            lastFittedLabel.Text = "Last Fitted:";
            // 
            // groupAllocationLabel
            // 
            groupAllocationLabel.AutoSize = true;
            groupAllocationLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupAllocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            groupAllocationLabel.Location = new System.Drawing.Point(14, 354);
            groupAllocationLabel.Name = "groupAllocationLabel";
            groupAllocationLabel.Size = new System.Drawing.Size(103, 15);
            groupAllocationLabel.TabIndex = 22;
            groupAllocationLabel.Text = "Group Allocation:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            notesLabel.Location = new System.Drawing.Point(14, 380);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(41, 15);
            notesLabel.TabIndex = 24;
            notesLabel.Text = "Notes:";
            // 
            // minStockLevelLabel
            // 
            minStockLevelLabel.AutoSize = true;
            minStockLevelLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            minStockLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            minStockLevelLabel.Location = new System.Drawing.Point(14, 198);
            minStockLevelLabel.Name = "minStockLevelLabel";
            minStockLevelLabel.Size = new System.Drawing.Size(94, 15);
            minStockLevelLabel.TabIndex = 26;
            minStockLevelLabel.Text = "Min Stock Level:";
            // 
            // nextDueLabel
            // 
            nextDueLabel.AutoSize = true;
            nextDueLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nextDueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            nextDueLabel.Location = new System.Drawing.Point(14, 331);
            nextDueLabel.Name = "nextDueLabel";
            nextDueLabel.Size = new System.Drawing.Size(58, 15);
            nextDueLabel.TabIndex = 27;
            nextDueLabel.Text = "Next Due:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            label1.Location = new System.Drawing.Point(14, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 15);
            label1.TabIndex = 23;
            label1.Text = "Set to Group Allocation:";
            // 
            // siteNameLabel
            // 
            siteNameLabel.AutoSize = true;
            siteNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            siteNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            siteNameLabel.Location = new System.Drawing.Point(14, 42);
            siteNameLabel.Name = "siteNameLabel";
            siteNameLabel.Size = new System.Drawing.Size(64, 15);
            siteNameLabel.TabIndex = 28;
            siteNameLabel.Text = "Site Name:";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.criticalCheckBox);
            this.Panel1.Controls.Add(this.siteNameComboBox);
            this.Panel1.Controls.Add(siteNameLabel);
            this.Panel1.Controls.Add(nextDueLabel);
            this.Panel1.Controls.Add(this.nextDueDateTimePicker);
            this.Panel1.Controls.Add(minStockLevelLabel);
            this.Panel1.Controls.Add(this.minStockLevelTextBox);
            this.Panel1.Controls.Add(this.groupAllocationComboBox);
            this.Panel1.Controls.Add(supplierPartNumberLabel);
            this.Panel1.Controls.Add(this.supplierPartNumberTextBox);
            this.Panel1.Controls.Add(descriptionLabel);
            this.Panel1.Controls.Add(this.descriptionTextBox);
            this.Panel1.Controls.Add(supplierLabel);
            this.Panel1.Controls.Add(this.supplierTextBox);
            this.Panel1.Controls.Add(effectAssetNumberLabel);
            this.Panel1.Controls.Add(this.effectAssetNumberTextBox);
            this.Panel1.Controls.Add(criticalLabel);
            this.Panel1.Controls.Add(internalStockLevelLabel);
            this.Panel1.Controls.Add(this.internalStockLevelTextBox);
            this.Panel1.Controls.Add(costLabel);
            this.Panel1.Controls.Add(this.costTextBox);
            this.Panel1.Controls.Add(leadTimeLabel);
            this.Panel1.Controls.Add(this.leadTimeTextBox);
            this.Panel1.Controls.Add(lastFittedLabel);
            this.Panel1.Controls.Add(this.lastFittedDateTimePicker);
            this.Panel1.Controls.Add(groupAllocationLabel);
            this.Panel1.Controls.Add(notesLabel);
            this.Panel1.Controls.Add(this.notesTextBox);
            this.Panel1.Location = new System.Drawing.Point(740, 82);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(354, 452);
            this.Panel1.TabIndex = 249;
            // 
            // criticalCheckBox
            // 
            this.criticalCheckBox.AutoSize = true;
            this.criticalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_partslistBindingSource, "Critical", true));
            this.criticalCheckBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticalCheckBox.Location = new System.Drawing.Point(144, 172);
            this.criticalCheckBox.Name = "criticalCheckBox";
            this.criticalCheckBox.Size = new System.Drawing.Size(15, 14);
            this.criticalCheckBox.TabIndex = 30;
            this.criticalCheckBox.UseVisualStyleBackColor = true;
            // 
            // tbl_partslistBindingSource
            // 
            this.tbl_partslistBindingSource.DataMember = "tbl_partslist";
            this.tbl_partslistBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteNameComboBox
            // 
            this.siteNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "SiteName", true));
            this.siteNameComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteNameComboBox.FormattingEnabled = true;
            this.siteNameComboBox.Location = new System.Drawing.Point(225, 39);
            this.siteNameComboBox.Name = "siteNameComboBox";
            this.siteNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.siteNameComboBox.TabIndex = 29;
            // 
            // nextDueDateTimePicker
            // 
            this.nextDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_partslistBindingSource, "NextDue", true));
            this.nextDueDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nextDueDateTimePicker.Location = new System.Drawing.Point(146, 325);
            this.nextDueDateTimePicker.Name = "nextDueDateTimePicker";
            this.nextDueDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.nextDueDateTimePicker.TabIndex = 28;
            this.nextDueDateTimePicker.ValueChanged += new System.EventHandler(this.nextDueDateTimePicker_ValueChanged);
            // 
            // minStockLevelTextBox
            // 
            this.minStockLevelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minStockLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "MinStockLevel", true));
            this.minStockLevelTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minStockLevelTextBox.Location = new System.Drawing.Point(263, 195);
            this.minStockLevelTextBox.Name = "minStockLevelTextBox";
            this.minStockLevelTextBox.Size = new System.Drawing.Size(83, 23);
            this.minStockLevelTextBox.TabIndex = 27;
            // 
            // groupAllocationComboBox
            // 
            this.groupAllocationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "GroupAllocation", true));
            this.groupAllocationComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAllocationComboBox.FormattingEnabled = true;
            this.groupAllocationComboBox.Location = new System.Drawing.Point(146, 351);
            this.groupAllocationComboBox.Name = "groupAllocationComboBox";
            this.groupAllocationComboBox.Size = new System.Drawing.Size(200, 23);
            this.groupAllocationComboBox.TabIndex = 26;
            // 
            // supplierPartNumberTextBox
            // 
            this.supplierPartNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierPartNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "SupplierPartNumber", true));
            this.supplierPartNumberTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierPartNumberTextBox.Location = new System.Drawing.Point(146, 7);
            this.supplierPartNumberTextBox.Name = "supplierPartNumberTextBox";
            this.supplierPartNumberTextBox.Size = new System.Drawing.Size(200, 23);
            this.supplierPartNumberTextBox.TabIndex = 1;
            this.supplierPartNumberTextBox.TextChanged += new System.EventHandler(this.supplierPartNumberTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(146, 70);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 41);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "Supplier", true));
            this.supplierTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierTextBox.Location = new System.Drawing.Point(146, 117);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(200, 23);
            this.supplierTextBox.TabIndex = 5;
            // 
            // effectAssetNumberTextBox
            // 
            this.effectAssetNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.effectAssetNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "EffectAssetNumber", true));
            this.effectAssetNumberTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectAssetNumberTextBox.Location = new System.Drawing.Point(146, 143);
            this.effectAssetNumberTextBox.Name = "effectAssetNumberTextBox";
            this.effectAssetNumberTextBox.Size = new System.Drawing.Size(200, 23);
            this.effectAssetNumberTextBox.TabIndex = 7;
            // 
            // internalStockLevelTextBox
            // 
            this.internalStockLevelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.internalStockLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "InternalStockLevel", true));
            this.internalStockLevelTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internalStockLevelTextBox.Location = new System.Drawing.Point(263, 221);
            this.internalStockLevelTextBox.Name = "internalStockLevelTextBox";
            this.internalStockLevelTextBox.Size = new System.Drawing.Size(83, 23);
            this.internalStockLevelTextBox.TabIndex = 13;
            // 
            // costTextBox
            // 
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "Cost", true));
            this.costTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(263, 247);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(83, 23);
            this.costTextBox.TabIndex = 15;
            // 
            // leadTimeTextBox
            // 
            this.leadTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leadTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "LeadTime", true));
            this.leadTimeTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadTimeTextBox.Location = new System.Drawing.Point(146, 273);
            this.leadTimeTextBox.Name = "leadTimeTextBox";
            this.leadTimeTextBox.Size = new System.Drawing.Size(200, 23);
            this.leadTimeTextBox.TabIndex = 17;
            // 
            // lastFittedDateTimePicker
            // 
            this.lastFittedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_partslistBindingSource, "LastFitted", true));
            this.lastFittedDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastFittedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastFittedDateTimePicker.Location = new System.Drawing.Point(146, 299);
            this.lastFittedDateTimePicker.Name = "lastFittedDateTimePicker";
            this.lastFittedDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.lastFittedDateTimePicker.TabIndex = 19;
            this.lastFittedDateTimePicker.ValueChanged += new System.EventHandler(this.lastFittedDateTimePicker_ValueChanged);
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_partslistBindingSource, "Notes", true));
            this.notesTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(146, 377);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(200, 60);
            this.notesTextBox.TabIndex = 25;
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnExportData.FlatAppearance.BorderSize = 0;
            this.btnExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnExportData.Location = new System.Drawing.Point(13, 61);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(97, 53);
            this.btnExportData.TabIndex = 252;
            this.btnExportData.Text = "EXPORT DATA (CSV_Format)";
            this.btnExportData.UseVisualStyleBackColor = false;
            this.btnExportData.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnImportData.FlatAppearance.BorderSize = 0;
            this.btnImportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnImportData.Location = new System.Drawing.Point(13, 6);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(97, 53);
            this.btnImportData.TabIndex = 251;
            this.btnImportData.Text = "IMPORT DATA (CSV_Format)";
            this.btnImportData.UseVisualStyleBackColor = false;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.Button3.Location = new System.Drawing.Point(116, 65);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(143, 51);
            this.Button3.TabIndex = 250;
            this.Button3.Text = "CLOSE";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExportData);
            this.panel2.Controls.Add(this.btnImportData);
            this.panel2.Controls.Add(this.Button3);
            this.panel2.Location = new System.Drawing.Point(832, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 120);
            this.panel2.TabIndex = 253;
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.Button6.Location = new System.Drawing.Point(9, 58);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(124, 52);
            this.Button6.TabIndex = 257;
            this.Button6.Text = "UPDATE DATABASE";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.Button5.Location = new System.Drawing.Point(9, 3);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(124, 51);
            this.Button5.TabIndex = 256;
            this.Button5.Text = "ADD NEW ITEM";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // txbSearchOn
            // 
            this.txbSearchOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchOn.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchOn.Location = new System.Drawing.Point(204, 16);
            this.txbSearchOn.Name = "txbSearchOn";
            this.txbSearchOn.Size = new System.Drawing.Size(108, 23);
            this.txbSearchOn.TabIndex = 255;
            this.txbSearchOn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchOn_KeyPress);
            // 
            // btnSearchOn
            // 
            this.btnSearchOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSearchOn.FlatAppearance.BorderSize = 0;
            this.btnSearchOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSearchOn.Location = new System.Drawing.Point(3, 3);
            this.btnSearchOn.Name = "btnSearchOn";
            this.btnSearchOn.Size = new System.Drawing.Size(195, 51);
            this.btnSearchOn.TabIndex = 254;
            this.btnSearchOn.Text = "SEARCH ON SupplierPartNumber";
            this.btnSearchOn.UseVisualStyleBackColor = false;
            this.btnSearchOn.Click += new System.EventHandler(this.btnSearchOn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbGroupAllocation);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txbSearchOn);
            this.panel3.Controls.Add(this.btnSearchOn);
            this.panel3.Location = new System.Drawing.Point(12, 576);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 120);
            this.panel3.TabIndex = 258;
            // 
            // cmbGroupAllocation
            // 
            this.cmbGroupAllocation.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupAllocation.FormattingEnabled = true;
            this.cmbGroupAllocation.Location = new System.Drawing.Point(204, 75);
            this.cmbGroupAllocation.Name = "cmbGroupAllocation";
            this.cmbGroupAllocation.Size = new System.Drawing.Size(108, 23);
            this.cmbGroupAllocation.TabIndex = 257;
            this.cmbGroupAllocation.SelectionChangeCommitted += new System.EventHandler(this.cmbGroupAllocation_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.button1.Location = new System.Drawing.Point(3, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 256;
            this.button1.Text = "SHOW BY GROUP ALLOCATION";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Button6);
            this.panel4.Controls.Add(this.Button5);
            this.panel4.Location = new System.Drawing.Point(684, 576);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 120);
            this.panel4.TabIndex = 259;
            // 
            // tbl_partslistBindingNavigator
            // 
            this.tbl_partslistBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_partslistBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_partslistBindingNavigator.BindingSource = this.tbl_partslistBindingSource;
            this.tbl_partslistBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_partslistBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_partslistBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_partslistBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_partslistBindingNavigatorSaveItem});
            this.tbl_partslistBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_partslistBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_partslistBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_partslistBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_partslistBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_partslistBindingNavigator.Name = "tbl_partslistBindingNavigator";
            this.tbl_partslistBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_partslistBindingNavigator.Size = new System.Drawing.Size(1118, 27);
            this.tbl_partslistBindingNavigator.TabIndex = 260;
            this.tbl_partslistBindingNavigator.Text = "bindingNavigator1";
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
            // tbl_partslistBindingNavigatorSaveItem
            // 
            this.tbl_partslistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_partslistBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_partslistBindingNavigatorSaveItem.Image")));
            this.tbl_partslistBindingNavigatorSaveItem.Name = "tbl_partslistBindingNavigatorSaveItem";
            this.tbl_partslistBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_partslistBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_partslistBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_partslistBindingNavigatorSaveItem_Click);
            // 
            // tbl_partslistDataGridView
            // 
            this.tbl_partslistDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tbl_partslistDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_partslistDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_partslistDataGridView.AutoGenerateColumns = false;
            this.tbl_partslistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_partslistDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_partslistDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbl_partslistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_partslistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SiteName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.MinStockLevel,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.tbl_partslistDataGridView.DataSource = this.tbl_partslistBindingSource;
            this.tbl_partslistDataGridView.Location = new System.Drawing.Point(14, 26);
            this.tbl_partslistDataGridView.Name = "tbl_partslistDataGridView";
            this.tbl_partslistDataGridView.RowHeadersWidth = 51;
            this.tbl_partslistDataGridView.Size = new System.Drawing.Size(703, 508);
            this.tbl_partslistDataGridView.TabIndex = 260;
            this.tbl_partslistDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_partslistDataGridView_CellClick);
            this.tbl_partslistDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_partslistDataGridView_ColumnHeaderMouseClick);
            this.tbl_partslistDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbl_partslistDataGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierPartNumber";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplierPartNumber";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 146;
            // 
            // SiteName
            // 
            this.SiteName.DataPropertyName = "SiteName";
            this.SiteName.HeaderText = "SiteName";
            this.SiteName.MinimumWidth = 6;
            this.SiteName.Name = "SiteName";
            this.SiteName.Width = 86;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Supplier";
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EffectAssetNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "EffectAssetNumber";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 139;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Critical";
            this.dataGridViewTextBoxColumn5.HeaderText = "Critical";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InternalStockLevel";
            this.dataGridViewTextBoxColumn7.HeaderText = "InternalStockLevel";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 133;
            // 
            // MinStockLevel
            // 
            this.MinStockLevel.DataPropertyName = "MinStockLevel";
            this.MinStockLevel.HeaderText = "MinStockLevel";
            this.MinStockLevel.MinimumWidth = 6;
            this.MinStockLevel.Name = "MinStockLevel";
            this.MinStockLevel.Width = 111;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cost";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn8.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 56;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LeadTime";
            this.dataGridViewTextBoxColumn9.HeaderText = "LeadTime";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 85;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LastFitted";
            this.dataGridViewTextBoxColumn10.HeaderText = "LastFitted";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 86;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NextDue";
            this.dataGridViewTextBoxColumn11.HeaderText = "NextDue";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 81;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "GroupAllocation";
            this.dataGridViewTextBoxColumn12.HeaderText = "GroupAllocation";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn13.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 65;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(label1);
            this.panel5.Controls.Add(this.cmbSetGroupAllocation);
            this.panel5.Location = new System.Drawing.Point(740, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 50);
            this.panel5.TabIndex = 261;
            // 
            // cmbSetGroupAllocation
            // 
            this.cmbSetGroupAllocation.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSetGroupAllocation.FormattingEnabled = true;
            this.cmbSetGroupAllocation.Location = new System.Drawing.Point(165, 15);
            this.cmbSetGroupAllocation.Name = "cmbSetGroupAllocation";
            this.cmbSetGroupAllocation.Size = new System.Drawing.Size(181, 23);
            this.cmbSetGroupAllocation.TabIndex = 3;
            this.cmbSetGroupAllocation.Visible = false;
            this.cmbSetGroupAllocation.SelectionChangeCommitted += new System.EventHandler(this.cmbSetGroupAllocation_SelectionChangeCommitted);
            this.cmbSetGroupAllocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSetGroupAllocation_KeyPress);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cmbSiteName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(339, 576);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(128, 120);
            this.panel6.TabIndex = 262;
            // 
            // cmbSiteName
            // 
            this.cmbSiteName.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSiteName.FormattingEnabled = true;
            this.cmbSiteName.Location = new System.Drawing.Point(15, 75);
            this.cmbSiteName.Name = "cmbSiteName";
            this.cmbSiteName.Size = new System.Drawing.Size(94, 23);
            this.cmbSiteName.TabIndex = 1;
            this.cmbSiteName.SelectionChangeCommitted += new System.EventHandler(this.cmbSiteName_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SHOW BY AREA:";
            // 
            // tbl_partslistTableAdapter
            // 
            this.tbl_partslistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = null;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = null;
            this.tableAdapterManager.tbl_colorTableAdapter = null;
            this.tableAdapterManager.tbl_partslistTableAdapter = this.tbl_partslistTableAdapter;
            this.tableAdapterManager.tbl_pmscheduleTableAdapter = null;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = null;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = null;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.lblMid);
            this.groupBox1.Controls.Add(this.lblAbove);
            this.groupBox1.Controls.Add(this.lblBelow);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 113);
            this.groupBox1.TabIndex = 263;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LEGEND";
            // 
            // lblMid
            // 
            this.lblMid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMid.AutoSize = true;
            this.lblMid.BackColor = System.Drawing.Color.Orange;
            this.lblMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMid.Location = new System.Drawing.Point(34, 52);
            this.lblMid.MinimumSize = new System.Drawing.Size(140, 14);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(140, 17);
            this.lblMid.TabIndex = 17;
            this.lblMid.Text = "BELOW/MID";
            this.lblMid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbove
            // 
            this.lblAbove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAbove.AutoSize = true;
            this.lblAbove.BackColor = System.Drawing.Color.Green;
            this.lblAbove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbove.Location = new System.Drawing.Point(34, 75);
            this.lblAbove.MinimumSize = new System.Drawing.Size(140, 14);
            this.lblAbove.Name = "lblAbove";
            this.lblAbove.Size = new System.Drawing.Size(140, 17);
            this.lblAbove.TabIndex = 16;
            this.lblAbove.Text = "ABOVE";
            this.lblAbove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBelow
            // 
            this.lblBelow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBelow.AutoSize = true;
            this.lblBelow.BackColor = System.Drawing.Color.Red;
            this.lblBelow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBelow.Location = new System.Drawing.Point(34, 29);
            this.lblBelow.MinimumSize = new System.Drawing.Size(140, 14);
            this.lblBelow.Name = "lblBelow";
            this.lblBelow.Size = new System.Drawing.Size(140, 17);
            this.lblBelow.TabIndex = 15;
            this.lblBelow.Text = "BELOW";
            this.lblBelow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowPartsListFrm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 708);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tbl_partslistDataGridView);
            this.Controls.Add(this.tbl_partslistBindingNavigator);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1134, 747);
            this.Name = "ShowPartsListFrm";
            this.Activated += new System.EventHandler(this.PartsListFrm_Activated);
            this.Load += new System.EventHandler(this.PartsListFrm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partslistBindingNavigator)).EndInit();
            this.tbl_partslistBindingNavigator.ResumeLayout(false);
            this.tbl_partslistBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partslistDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnExportData;
        internal System.Windows.Forms.Button btnImportData;
        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.TextBox txbSearchOn;
        internal System.Windows.Forms.Button btnSearchOn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_partslistBindingSource;
        private eped_db1DataSetTableAdapters.tbl_partslistTableAdapter tbl_partslistTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_partslistBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_partslistBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox groupAllocationComboBox;
        private System.Windows.Forms.TextBox supplierPartNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox effectAssetNumberTextBox;
        private System.Windows.Forms.TextBox internalStockLevelTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox leadTimeTextBox;
        private System.Windows.Forms.DateTimePicker lastFittedDateTimePicker;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.DataGridView tbl_partslistDataGridView;
       // private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker nextDueDateTimePicker;
        private System.Windows.Forms.TextBox minStockLevelTextBox;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbGroupAllocation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbSetGroupAllocation;
        private System.Windows.Forms.ComboBox siteNameComboBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbSiteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinStockLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.CheckBox criticalCheckBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label lblMid;
        internal System.Windows.Forms.Label lblAbove;
        internal System.Windows.Forms.Label lblBelow;
    }
}