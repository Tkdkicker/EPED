namespace EPED
{
    partial class UpdatePMAssetDetailsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePMAssetDetailsFrm));
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label dateIntroducedLabel;
            System.Windows.Forms.Label groupAllocationLabel;
            this.btnSave = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.tbl_multipmscheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_multipmscheduleTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_multipmscheduleTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_multipmscheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_multipmscheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.equipmentIDLabel1 = new System.Windows.Forms.Label();
            this.dateIntroducedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupAllocationComboBox = new System.Windows.Forms.ComboBox();
            equipmentIDLabel = new System.Windows.Forms.Label();
            dateIntroducedLabel = new System.Windows.Forms.Label();
            groupAllocationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_multipmscheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_multipmscheduleBindingNavigator)).BeginInit();
            this.tbl_multipmscheduleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(429, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 46);
            this.btnSave.TabIndex = 255;
            this.btnSave.Text = "SAVE SETTINGS";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Location = new System.Drawing.Point(623, 365);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(151, 48);
            this.Button1.TabIndex = 254;
            this.Button1.Text = "CLOSE";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_multipmscheduleBindingSource
            // 
            this.tbl_multipmscheduleBindingSource.DataMember = "tbl_multipmschedule";
            this.tbl_multipmscheduleBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // tbl_multipmscheduleTableAdapter
            // 
            this.tbl_multipmscheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = null;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = null;
            this.tableAdapterManager.tbl_multipmscheduleTableAdapter = this.tbl_multipmscheduleTableAdapter;
            this.tableAdapterManager.tbl_partslistTableAdapter = null;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = null;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = null;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_multipmscheduleBindingNavigator
            // 
            this.tbl_multipmscheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_multipmscheduleBindingNavigator.BindingSource = this.tbl_multipmscheduleBindingSource;
            this.tbl_multipmscheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_multipmscheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_multipmscheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_multipmscheduleBindingNavigatorSaveItem});
            this.tbl_multipmscheduleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_multipmscheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_multipmscheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_multipmscheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_multipmscheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_multipmscheduleBindingNavigator.Name = "tbl_multipmscheduleBindingNavigator";
            this.tbl_multipmscheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_multipmscheduleBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tbl_multipmscheduleBindingNavigator.TabIndex = 256;
            this.tbl_multipmscheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tbl_multipmscheduleBindingNavigatorSaveItem
            // 
            this.tbl_multipmscheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_multipmscheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_multipmscheduleBindingNavigatorSaveItem.Image")));
            this.tbl_multipmscheduleBindingNavigatorSaveItem.Name = "tbl_multipmscheduleBindingNavigatorSaveItem";
            this.tbl_multipmscheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tbl_multipmscheduleBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_multipmscheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_multipmscheduleBindingNavigatorSaveItem_Click_1);
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(111, 46);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(74, 13);
            equipmentIDLabel.TabIndex = 256;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // equipmentIDLabel1
            // 
            this.equipmentIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_multipmscheduleBindingSource, "EquipmentID", true));
            this.equipmentIDLabel1.Location = new System.Drawing.Point(191, 46);
            this.equipmentIDLabel1.Name = "equipmentIDLabel1";
            this.equipmentIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.equipmentIDLabel1.TabIndex = 257;
            this.equipmentIDLabel1.Text = "label1";
            // 
            // dateIntroducedLabel
            // 
            dateIntroducedLabel.AutoSize = true;
            dateIntroducedLabel.Location = new System.Drawing.Point(101, 76);
            dateIntroducedLabel.Name = "dateIntroducedLabel";
            dateIntroducedLabel.Size = new System.Drawing.Size(87, 13);
            dateIntroducedLabel.TabIndex = 257;
            dateIntroducedLabel.Text = "Date Introduced:";
            // 
            // dateIntroducedDateTimePicker
            // 
            this.dateIntroducedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_multipmscheduleBindingSource, "DateIntroduced", true));
            this.dateIntroducedDateTimePicker.Location = new System.Drawing.Point(194, 72);
            this.dateIntroducedDateTimePicker.Name = "dateIntroducedDateTimePicker";
            this.dateIntroducedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateIntroducedDateTimePicker.TabIndex = 258;
            // 
            // groupAllocationLabel
            // 
            groupAllocationLabel.AutoSize = true;
            groupAllocationLabel.Location = new System.Drawing.Point(100, 101);
            groupAllocationLabel.Name = "groupAllocationLabel";
            groupAllocationLabel.Size = new System.Drawing.Size(88, 13);
            groupAllocationLabel.TabIndex = 258;
            groupAllocationLabel.Text = "Group Allocation:";
            // 
            // groupAllocationComboBox
            // 
            this.groupAllocationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_multipmscheduleBindingSource, "GroupAllocation", true));
            this.groupAllocationComboBox.FormattingEnabled = true;
            this.groupAllocationComboBox.Location = new System.Drawing.Point(194, 98);
            this.groupAllocationComboBox.Name = "groupAllocationComboBox";
            this.groupAllocationComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupAllocationComboBox.TabIndex = 259;
            // 
            // UpdatePMAssetDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(groupAllocationLabel);
            this.Controls.Add(this.groupAllocationComboBox);
            this.Controls.Add(dateIntroducedLabel);
            this.Controls.Add(this.dateIntroducedDateTimePicker);
            this.Controls.Add(equipmentIDLabel);
            this.Controls.Add(this.equipmentIDLabel1);
            this.Controls.Add(this.tbl_multipmscheduleBindingNavigator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Button1);
            this.Name = "UpdatePMAssetDetailsFrm";
            this.Text = "UpdatePMAssetDetailsFrm";
            this.Load += new System.EventHandler(this.UpdatePMAssetDetailsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_multipmscheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_multipmscheduleBindingNavigator)).EndInit();
            this.tbl_multipmscheduleBindingNavigator.ResumeLayout(false);
            this.tbl_multipmscheduleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button Button1;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_multipmscheduleBindingSource;
        private eped_db1DataSetTableAdapters.tbl_multipmscheduleTableAdapter tbl_multipmscheduleTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_multipmscheduleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_multipmscheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.Label equipmentIDLabel1;
        private System.Windows.Forms.DateTimePicker dateIntroducedDateTimePicker;
        private System.Windows.Forms.ComboBox groupAllocationComboBox;
    }
}