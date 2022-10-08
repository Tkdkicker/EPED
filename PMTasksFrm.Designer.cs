namespace EPED
{
    partial class PMTasksFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMTasksFrm));
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.tbl_pmtasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pmtasksTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_pmtasksTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_pmtasksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_pmtasksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_pmtasksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.linkToInstructionTextBox = new System.Windows.Forms.TextBox();
            this.consequencesIfNotPerformedTextBox = new System.Windows.Forms.TextBox();
            this.perpetualNotesTextBox = new System.Windows.Forms.TextBox();
            this.estimatedDownTimeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            taskLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            linkToInstructionLabel = new System.Windows.Forms.Label();
            consequencesIfNotPerformedLabel = new System.Windows.Forms.Label();
            perpetualNotesLabel = new System.Windows.Forms.Label();
            estimatedDownTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingNavigator)).BeginInit();
            this.tbl_pmtasksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new System.Drawing.Point(27, 59);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new System.Drawing.Size(34, 13);
            taskLabel.TabIndex = 2;
            taskLabel.Text = "Task:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(27, 85);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location:";
            // 
            // linkToInstructionLabel
            // 
            linkToInstructionLabel.AutoSize = true;
            linkToInstructionLabel.Location = new System.Drawing.Point(27, 112);
            linkToInstructionLabel.Name = "linkToInstructionLabel";
            linkToInstructionLabel.Size = new System.Drawing.Size(98, 13);
            linkToInstructionLabel.TabIndex = 6;
            linkToInstructionLabel.Text = "Link To Instruction:";
            // 
            // consequencesIfNotPerformedLabel
            // 
            consequencesIfNotPerformedLabel.AutoSize = true;
            consequencesIfNotPerformedLabel.Location = new System.Drawing.Point(27, 138);
            consequencesIfNotPerformedLabel.Name = "consequencesIfNotPerformedLabel";
            consequencesIfNotPerformedLabel.Size = new System.Drawing.Size(161, 13);
            consequencesIfNotPerformedLabel.TabIndex = 8;
            consequencesIfNotPerformedLabel.Text = "Consequences If Not Performed:";
            // 
            // perpetualNotesLabel
            // 
            perpetualNotesLabel.AutoSize = true;
            perpetualNotesLabel.Location = new System.Drawing.Point(27, 164);
            perpetualNotesLabel.Name = "perpetualNotesLabel";
            perpetualNotesLabel.Size = new System.Drawing.Size(86, 13);
            perpetualNotesLabel.TabIndex = 10;
            perpetualNotesLabel.Text = "Perpetual Notes:";
            // 
            // estimatedDownTimeLabel
            // 
            estimatedDownTimeLabel.AutoSize = true;
            estimatedDownTimeLabel.Location = new System.Drawing.Point(27, 190);
            estimatedDownTimeLabel.Name = "estimatedDownTimeLabel";
            estimatedDownTimeLabel.Size = new System.Drawing.Size(113, 13);
            estimatedDownTimeLabel.TabIndex = 12;
            estimatedDownTimeLabel.Text = "Estimated Down Time:";
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_pmtasksBindingSource
            // 
            this.tbl_pmtasksBindingSource.DataMember = "tbl_pmtasks";
            this.tbl_pmtasksBindingSource.DataSource = this.eped_db1DataSet;
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
            this.tableAdapterManager.tbl_multipmscheduleTableAdapter = null;
            this.tableAdapterManager.tbl_partslistTableAdapter = null;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = this.tbl_pmtasksTableAdapter;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = null;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_pmtasksBindingNavigator
            // 
            this.tbl_pmtasksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_pmtasksBindingNavigator.BindingSource = this.tbl_pmtasksBindingSource;
            this.tbl_pmtasksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_pmtasksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.tbl_pmtasksBindingNavigator.Size = new System.Drawing.Size(1088, 25);
            this.tbl_pmtasksBindingNavigator.TabIndex = 0;
            this.tbl_pmtasksBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbl_pmtasksBindingNavigatorSaveItem
            // 
            this.tbl_pmtasksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_pmtasksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_pmtasksBindingNavigatorSaveItem.Image")));
            this.tbl_pmtasksBindingNavigatorSaveItem.Name = "tbl_pmtasksBindingNavigatorSaveItem";
            this.tbl_pmtasksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_pmtasksBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_pmtasksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_pmtasksBindingNavigatorSaveItem_Click);
            // 
            // tbl_pmtasksDataGridView
            // 
            this.tbl_pmtasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_pmtasksDataGridView.AutoGenerateColumns = false;
            this.tbl_pmtasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pmtasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tbl_pmtasksDataGridView.DataSource = this.tbl_pmtasksBindingSource;
            this.tbl_pmtasksDataGridView.Location = new System.Drawing.Point(12, 50);
            this.tbl_pmtasksDataGridView.Name = "tbl_pmtasksDataGridView";
            this.tbl_pmtasksDataGridView.Size = new System.Drawing.Size(665, 423);
            this.tbl_pmtasksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Task";
            this.dataGridViewTextBoxColumn1.HeaderText = "Task";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn2.HeaderText = "Location";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LinkToInstruction";
            this.dataGridViewTextBoxColumn3.HeaderText = "LinkToInstruction";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ConsequencesIfNotPerformed";
            this.dataGridViewTextBoxColumn4.HeaderText = "ConsequencesIfNotPerformed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PerpetualNotes";
            this.dataGridViewTextBoxColumn5.HeaderText = "PerpetualNotes";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EstimatedDownTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "EstimatedDownTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // taskTextBox
            // 
            this.taskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "Task", true));
            this.taskTextBox.Location = new System.Drawing.Point(194, 56);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(121, 20);
            this.taskTextBox.TabIndex = 3;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "Location", true));
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(194, 82);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(121, 21);
            this.locationComboBox.TabIndex = 5;
            // 
            // linkToInstructionTextBox
            // 
            this.linkToInstructionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "LinkToInstruction", true));
            this.linkToInstructionTextBox.Location = new System.Drawing.Point(194, 109);
            this.linkToInstructionTextBox.Name = "linkToInstructionTextBox";
            this.linkToInstructionTextBox.Size = new System.Drawing.Size(121, 20);
            this.linkToInstructionTextBox.TabIndex = 7;
            // 
            // consequencesIfNotPerformedTextBox
            // 
            this.consequencesIfNotPerformedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "ConsequencesIfNotPerformed", true));
            this.consequencesIfNotPerformedTextBox.Location = new System.Drawing.Point(194, 135);
            this.consequencesIfNotPerformedTextBox.Name = "consequencesIfNotPerformedTextBox";
            this.consequencesIfNotPerformedTextBox.Size = new System.Drawing.Size(121, 20);
            this.consequencesIfNotPerformedTextBox.TabIndex = 9;
            // 
            // perpetualNotesTextBox
            // 
            this.perpetualNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "PerpetualNotes", true));
            this.perpetualNotesTextBox.Location = new System.Drawing.Point(194, 161);
            this.perpetualNotesTextBox.Name = "perpetualNotesTextBox";
            this.perpetualNotesTextBox.Size = new System.Drawing.Size(121, 20);
            this.perpetualNotesTextBox.TabIndex = 11;
            // 
            // estimatedDownTimeTextBox
            // 
            this.estimatedDownTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "EstimatedDownTime", true));
            this.estimatedDownTimeTextBox.Location = new System.Drawing.Point(194, 187);
            this.estimatedDownTimeTextBox.Name = "estimatedDownTimeTextBox";
            this.estimatedDownTimeTextBox.Size = new System.Drawing.Size(121, 20);
            this.estimatedDownTimeTextBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Controls.Add(this.estimatedDownTimeTextBox);
            this.panel1.Location = new System.Drawing.Point(698, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 306);
            this.panel1.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(698, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 46);
            this.btnSave.TabIndex = 253;
            this.btnSave.Text = "SAVE SETTINGS";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Location = new System.Drawing.Point(892, 426);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(151, 48);
            this.Button1.TabIndex = 252;
            this.Button1.Text = "CLOSE";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PMTasksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 514);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_pmtasksDataGridView);
            this.Controls.Add(this.tbl_pmtasksBindingNavigator);
            this.Name = "PMTasksFrm";
            this.Text = "PMTasksFrm";
            this.Load += new System.EventHandler(this.PMTasksFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingNavigator)).EndInit();
            this.tbl_pmtasksBindingNavigator.ResumeLayout(false);
            this.tbl_pmtasksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.TextBox linkToInstructionTextBox;
        private System.Windows.Forms.TextBox consequencesIfNotPerformedTextBox;
        private System.Windows.Forms.TextBox perpetualNotesTextBox;
        private System.Windows.Forms.TextBox estimatedDownTimeTextBox;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button Button1;
    }
}