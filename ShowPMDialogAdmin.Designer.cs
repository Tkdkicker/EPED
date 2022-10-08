namespace EPED
{
    partial class ShowPMDialogAdmin
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
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label taskLabel;
            System.Windows.Forms.Label assignedTechLabel;
            System.Windows.Forms.Label frequencyLabel1;
            System.Windows.Forms.Label linkToInstructionLabel;
            System.Windows.Forms.Label consequencesIfNotPerformedLabel;
            System.Windows.Forms.Label perpetualNotesLabel;
            System.Windows.Forms.Label estimatedDownTimeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label taskLabel1;
            System.Windows.Forms.Label groupAllocationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPMDialogAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbBoxPMTasksSelection = new System.Windows.Forms.ComboBox();
            this.estimatedDownTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbl_pmtasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.groupAllocationComboBox = new System.Windows.Forms.ComboBox();
            this.tbl_pmscheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTextBox1 = new System.Windows.Forms.TextBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.startWeekNoTextBox = new System.Windows.Forms.TextBox();
            this.estimatedDownTimeComboBox = new System.Windows.Forms.ComboBox();
            this.perpetualNotesTextBox = new System.Windows.Forms.TextBox();
            this.consequencesIfNotPerformedTextBox = new System.Windows.Forms.TextBox();
            this.linkToInstructionTextBox = new System.Windows.Forms.TextBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.assignedTechComboBox = new System.Windows.Forms.ComboBox();
            this.frequencyComboBox = new System.Windows.Forms.ComboBox();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbNoTasks1 = new System.Windows.Forms.Label();
            this.lbNoTasks2 = new System.Windows.Forms.Label();
            this.tbl_pmscheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInUse = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbEquipmentID = new System.Windows.Forms.Label();
            this.lblPMFor = new System.Windows.Forms.Label();
            this.tbl_pmscheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_pmscheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_pmscheduleTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_pmscheduleTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_pmtasksTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_pmtasksTableAdapter();
            startDateLabel = new System.Windows.Forms.Label();
            taskLabel = new System.Windows.Forms.Label();
            assignedTechLabel = new System.Windows.Forms.Label();
            frequencyLabel1 = new System.Windows.Forms.Label();
            linkToInstructionLabel = new System.Windows.Forms.Label();
            consequencesIfNotPerformedLabel = new System.Windows.Forms.Label();
            perpetualNotesLabel = new System.Windows.Forms.Label();
            estimatedDownTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            taskLabel1 = new System.Windows.Forms.Label();
            groupAllocationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleBindingNavigator)).BeginInit();
            this.tbl_pmscheduleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            startDateLabel.Location = new System.Drawing.Point(443, 271);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(123, 17);
            startDateLabel.TabIndex = 27;
            startDateLabel.Text = "Start Date/week no:";
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            taskLabel.Location = new System.Drawing.Point(544, 183);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new System.Drawing.Size(36, 17);
            taskLabel.TabIndex = 32;
            taskLabel.Text = "Task:";
            // 
            // assignedTechLabel
            // 
            assignedTechLabel.AutoSize = true;
            assignedTechLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            assignedTechLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            assignedTechLabel.Location = new System.Drawing.Point(515, 242);
            assignedTechLabel.Name = "assignedTechLabel";
            assignedTechLabel.Size = new System.Drawing.Size(61, 17);
            assignedTechLabel.TabIndex = 34;
            assignedTechLabel.Text = "Assignee:";
            // 
            // frequencyLabel1
            // 
            frequencyLabel1.AutoSize = true;
            frequencyLabel1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            frequencyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            frequencyLabel1.Location = new System.Drawing.Point(505, 301);
            frequencyLabel1.Name = "frequencyLabel1";
            frequencyLabel1.Size = new System.Drawing.Size(70, 17);
            frequencyLabel1.TabIndex = 37;
            frequencyLabel1.Text = "Frequency:";
            // 
            // linkToInstructionLabel
            // 
            linkToInstructionLabel.AutoSize = true;
            linkToInstructionLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkToInstructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            linkToInstructionLabel.Location = new System.Drawing.Point(453, 330);
            linkToInstructionLabel.Name = "linkToInstructionLabel";
            linkToInstructionLabel.Size = new System.Drawing.Size(113, 17);
            linkToInstructionLabel.TabIndex = 40;
            linkToInstructionLabel.Text = "Link To Instruction:";
            // 
            // consequencesIfNotPerformedLabel
            // 
            consequencesIfNotPerformedLabel.AutoSize = true;
            consequencesIfNotPerformedLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            consequencesIfNotPerformedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            consequencesIfNotPerformedLabel.Location = new System.Drawing.Point(366, 360);
            consequencesIfNotPerformedLabel.Name = "consequencesIfNotPerformedLabel";
            consequencesIfNotPerformedLabel.Size = new System.Drawing.Size(189, 17);
            consequencesIfNotPerformedLabel.TabIndex = 41;
            consequencesIfNotPerformedLabel.Text = "Consequences If Not Performed:";
            // 
            // perpetualNotesLabel
            // 
            perpetualNotesLabel.AutoSize = true;
            perpetualNotesLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            perpetualNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            perpetualNotesLabel.Location = new System.Drawing.Point(466, 390);
            perpetualNotesLabel.Name = "perpetualNotesLabel";
            perpetualNotesLabel.Size = new System.Drawing.Size(103, 17);
            perpetualNotesLabel.TabIndex = 42;
            perpetualNotesLabel.Text = "Perpetual Notes:";
            // 
            // estimatedDownTimeLabel
            // 
            estimatedDownTimeLabel.AutoSize = true;
            estimatedDownTimeLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estimatedDownTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            estimatedDownTimeLabel.Location = new System.Drawing.Point(430, 420);
            estimatedDownTimeLabel.Name = "estimatedDownTimeLabel";
            estimatedDownTimeLabel.Size = new System.Drawing.Size(136, 17);
            estimatedDownTimeLabel.TabIndex = 43;
            estimatedDownTimeLabel.Text = "Estimated Down Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            locationLabel.Location = new System.Drawing.Point(525, 213);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(60, 17);
            locationLabel.TabIndex = 45;
            locationLabel.Text = "Location:";
            // 
            // taskLabel1
            // 
            taskLabel1.AutoSize = true;
            taskLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            taskLabel1.Location = new System.Drawing.Point(482, 117);
            taskLabel1.Name = "taskLabel1";
            taskLabel1.Size = new System.Drawing.Size(103, 17);
            taskLabel1.TabIndex = 46;
            taskLabel1.Text = "pmtasks tbl Task:";
            taskLabel1.Visible = false;
            // 
            // groupAllocationLabel
            // 
            groupAllocationLabel.AutoSize = true;
            groupAllocationLabel.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupAllocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            groupAllocationLabel.Location = new System.Drawing.Point(463, 449);
            groupAllocationLabel.Name = "groupAllocationLabel";
            groupAllocationLabel.Size = new System.Drawing.Size(106, 17);
            groupAllocationLabel.TabIndex = 47;
            groupAllocationLabel.Text = "Group Allocation:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CmbBoxPMTasksSelection);
            this.panel1.Controls.Add(this.estimatedDownTimePicker1);
            this.panel1.Controls.Add(groupAllocationLabel);
            this.panel1.Controls.Add(this.groupAllocationComboBox);
            this.panel1.Controls.Add(taskLabel1);
            this.panel1.Controls.Add(this.taskTextBox1);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationComboBox);
            this.panel1.Controls.Add(this.startWeekNoTextBox);
            this.panel1.Controls.Add(estimatedDownTimeLabel);
            this.panel1.Controls.Add(this.estimatedDownTimeComboBox);
            this.panel1.Controls.Add(perpetualNotesLabel);
            this.panel1.Controls.Add(this.perpetualNotesTextBox);
            this.panel1.Controls.Add(consequencesIfNotPerformedLabel);
            this.panel1.Controls.Add(this.consequencesIfNotPerformedTextBox);
            this.panel1.Controls.Add(linkToInstructionLabel);
            this.panel1.Controls.Add(this.linkToInstructionTextBox);
            this.panel1.Controls.Add(this.taskTextBox);
            this.panel1.Controls.Add(this.assignedTechComboBox);
            this.panel1.Controls.Add(frequencyLabel1);
            this.panel1.Controls.Add(this.frequencyComboBox);
            this.panel1.Controls.Add(this.btnEditTask);
            this.panel1.Controls.Add(this.btnAddNewTask);
            this.panel1.Controls.Add(assignedTechLabel);
            this.panel1.Controls.Add(taskLabel);
            this.panel1.Controls.Add(startDateLabel);
            this.panel1.Controls.Add(this.startDateDateTimePicker);
            this.panel1.Controls.Add(this.lbNoTasks1);
            this.panel1.Controls.Add(this.lbNoTasks2);
            this.panel1.Controls.Add(this.tbl_pmscheduleDataGridView);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbStation);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbInUse);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lbDescription);
            this.panel1.Controls.Add(this.lbEquipmentID);
            this.panel1.Controls.Add(this.lblPMFor);
            this.panel1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(43, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 553);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CmbBoxPMTasksSelection
            // 
            this.CmbBoxPMTasksSelection.FormattingEnabled = true;
            this.CmbBoxPMTasksSelection.Location = new System.Drawing.Point(459, 20);
            this.CmbBoxPMTasksSelection.Name = "CmbBoxPMTasksSelection";
            this.CmbBoxPMTasksSelection.Size = new System.Drawing.Size(121, 23);
            this.CmbBoxPMTasksSelection.TabIndex = 50;
            this.CmbBoxPMTasksSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // estimatedDownTimePicker1
            // 
            this.estimatedDownTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "EstimatedDownTime", true));
            this.estimatedDownTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.estimatedDownTimePicker1.Location = new System.Drawing.Point(601, 416);
            this.estimatedDownTimePicker1.Name = "estimatedDownTimePicker1";
            this.estimatedDownTimePicker1.ShowUpDown = true;
            this.estimatedDownTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.estimatedDownTimePicker1.TabIndex = 49;
            this.estimatedDownTimePicker1.Value = new System.DateTime(2021, 9, 27, 0, 0, 0, 0);
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
            // groupAllocationComboBox
            // 
            this.groupAllocationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "GroupAllocation", true));
            this.groupAllocationComboBox.Enabled = false;
            this.groupAllocationComboBox.FormattingEnabled = true;
            this.groupAllocationComboBox.Location = new System.Drawing.Point(601, 446);
            this.groupAllocationComboBox.Name = "groupAllocationComboBox";
            this.groupAllocationComboBox.Size = new System.Drawing.Size(200, 23);
            this.groupAllocationComboBox.TabIndex = 48;
            // 
            // tbl_pmscheduleBindingSource
            // 
            this.tbl_pmscheduleBindingSource.DataMember = "tbl_pmschedule";
            this.tbl_pmscheduleBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // taskTextBox1
            // 
            this.taskTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.taskTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "Task", true));
            this.taskTextBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.taskTextBox1.Location = new System.Drawing.Point(601, 117);
            this.taskTextBox1.Name = "taskTextBox1";
            this.taskTextBox1.Size = new System.Drawing.Size(200, 17);
            this.taskTextBox1.TabIndex = 47;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "Location", true));
            this.locationComboBox.Enabled = false;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(601, 210);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(200, 23);
            this.locationComboBox.TabIndex = 46;
            // 
            // startWeekNoTextBox
            // 
            this.startWeekNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startWeekNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "StartWeekNo", true));
            this.startWeekNoTextBox.Enabled = false;
            this.startWeekNoTextBox.Location = new System.Drawing.Point(774, 268);
            this.startWeekNoTextBox.Name = "startWeekNoTextBox";
            this.startWeekNoTextBox.Size = new System.Drawing.Size(27, 24);
            this.startWeekNoTextBox.TabIndex = 45;
            // 
            // estimatedDownTimeComboBox
            // 
            this.estimatedDownTimeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "EstimatedDownTime", true));
            this.estimatedDownTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.estimatedDownTimeComboBox.Enabled = false;
            this.estimatedDownTimeComboBox.FormattingEnabled = true;
            this.estimatedDownTimeComboBox.Location = new System.Drawing.Point(601, 147);
            this.estimatedDownTimeComboBox.Name = "estimatedDownTimeComboBox";
            this.estimatedDownTimeComboBox.Size = new System.Drawing.Size(200, 23);
            this.estimatedDownTimeComboBox.TabIndex = 44;
            this.estimatedDownTimeComboBox.Visible = false;
            // 
            // perpetualNotesTextBox
            // 
            this.perpetualNotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perpetualNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "PerpetualNotes", true));
            this.perpetualNotesTextBox.Enabled = false;
            this.perpetualNotesTextBox.Location = new System.Drawing.Point(601, 387);
            this.perpetualNotesTextBox.Name = "perpetualNotesTextBox";
            this.perpetualNotesTextBox.Size = new System.Drawing.Size(200, 24);
            this.perpetualNotesTextBox.TabIndex = 43;
            // 
            // consequencesIfNotPerformedTextBox
            // 
            this.consequencesIfNotPerformedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consequencesIfNotPerformedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "ConsequencesIfNotPerformed", true));
            this.consequencesIfNotPerformedTextBox.Enabled = false;
            this.consequencesIfNotPerformedTextBox.Location = new System.Drawing.Point(601, 357);
            this.consequencesIfNotPerformedTextBox.Name = "consequencesIfNotPerformedTextBox";
            this.consequencesIfNotPerformedTextBox.Size = new System.Drawing.Size(200, 24);
            this.consequencesIfNotPerformedTextBox.TabIndex = 42;
            // 
            // linkToInstructionTextBox
            // 
            this.linkToInstructionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkToInstructionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "LinkToInstruction", true));
            this.linkToInstructionTextBox.Enabled = false;
            this.linkToInstructionTextBox.Location = new System.Drawing.Point(601, 327);
            this.linkToInstructionTextBox.Name = "linkToInstructionTextBox";
            this.linkToInstructionTextBox.Size = new System.Drawing.Size(200, 24);
            this.linkToInstructionTextBox.TabIndex = 41;
            // 
            // taskTextBox
            // 
            this.taskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "Task", true));
            this.taskTextBox.Enabled = false;
            this.taskTextBox.Location = new System.Drawing.Point(601, 180);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(200, 24);
            this.taskTextBox.TabIndex = 40;
            this.taskTextBox.TextChanged += new System.EventHandler(this.taskTextBox_TextChanged);
            this.taskTextBox.Validated += new System.EventHandler(this.taskTextBox_Validated);
            // 
            // assignedTechComboBox
            // 
            this.assignedTechComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "AssignedTech", true));
            this.assignedTechComboBox.Enabled = false;
            this.assignedTechComboBox.FormattingEnabled = true;
            this.assignedTechComboBox.Location = new System.Drawing.Point(601, 239);
            this.assignedTechComboBox.Name = "assignedTechComboBox";
            this.assignedTechComboBox.Size = new System.Drawing.Size(200, 23);
            this.assignedTechComboBox.TabIndex = 39;
            // 
            // frequencyComboBox
            // 
            this.frequencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "Frequency", true));
            this.frequencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frequencyComboBox.Enabled = false;
            this.frequencyComboBox.FormattingEnabled = true;
            this.frequencyComboBox.Items.AddRange(new object[] {
            "WEEKLY",
            "FORTNIGHTLY",
            "MONTHLY",
            "QUARTERLY",
            "6MONTHLY",
            "YEARLY"});
            this.frequencyComboBox.Location = new System.Drawing.Point(601, 298);
            this.frequencyComboBox.Name = "frequencyComboBox";
            this.frequencyComboBox.Size = new System.Drawing.Size(200, 23);
            this.frequencyComboBox.TabIndex = 38;
            // 
            // btnEditTask
            // 
            this.btnEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEditTask.FlatAppearance.BorderSize = 0;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnEditTask.Location = new System.Drawing.Point(508, 496);
            this.btnEditTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(121, 34);
            this.btnEditTask.TabIndex = 37;
            this.btnEditTask.Text = "Edit task";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnAddNewTask.FlatAppearance.BorderSize = 0;
            this.btnAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTask.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnAddNewTask.Location = new System.Drawing.Point(33, 496);
            this.btnAddNewTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(121, 34);
            this.btnAddNewTask.TabIndex = 36;
            this.btnAddNewTask.Text = "Add new task";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_pmscheduleBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Enabled = false;
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(601, 268);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(167, 24);
            this.startDateDateTimePicker.TabIndex = 28;
            this.startDateDateTimePicker.ValueChanged += new System.EventHandler(this.startDateDateTimePicker_ValueChanged);
            // 
            // lbNoTasks1
            // 
            this.lbNoTasks1.AutoSize = true;
            this.lbNoTasks1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbNoTasks1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTasks1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbNoTasks1.Location = new System.Drawing.Point(65, 253);
            this.lbNoTasks1.Name = "lbNoTasks1";
            this.lbNoTasks1.Size = new System.Drawing.Size(191, 15);
            this.lbNoTasks1.TabIndex = 9;
            this.lbNoTasks1.Text = "There are currently no tasks for this";
            // 
            // lbNoTasks2
            // 
            this.lbNoTasks2.AutoSize = true;
            this.lbNoTasks2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbNoTasks2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTasks2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbNoTasks2.Location = new System.Drawing.Point(65, 287);
            this.lbNoTasks2.Name = "lbNoTasks2";
            this.lbNoTasks2.Size = new System.Drawing.Size(217, 15);
            this.lbNoTasks2.TabIndex = 10;
            this.lbNoTasks2.Text = "asset, click the button below to add one";
            // 
            // tbl_pmscheduleDataGridView
            // 
            this.tbl_pmscheduleDataGridView.AllowUserToAddRows = false;
            this.tbl_pmscheduleDataGridView.AutoGenerateColumns = false;
            this.tbl_pmscheduleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_pmscheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pmscheduleDataGridView.ColumnHeadersVisible = false;
            this.tbl_pmscheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.tbl_pmscheduleDataGridView.DataSource = this.tbl_pmscheduleBindingSource;
            this.tbl_pmscheduleDataGridView.Location = new System.Drawing.Point(33, 180);
            this.tbl_pmscheduleDataGridView.Name = "tbl_pmscheduleDataGridView";
            this.tbl_pmscheduleDataGridView.RowHeadersWidth = 51;
            this.tbl_pmscheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_pmscheduleDataGridView.Size = new System.Drawing.Size(258, 283);
            this.tbl_pmscheduleDataGridView.TabIndex = 17;
            this.tbl_pmscheduleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_pmscheduleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Task";
            this.dataGridViewTextBoxColumn2.HeaderText = "Task";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "PM Tasks:";
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStation.Location = new System.Drawing.Point(33, 122);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(27, 15);
            this.lbStation.TabIndex = 16;
            this.lbStation.Text = "-----";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnClose.Location = new System.Drawing.Point(680, 496);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 34);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnRemove.Location = new System.Drawing.Point(323, 496);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 34);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove task";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnAddTask.Location = new System.Drawing.Point(174, 496);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(121, 34);
            this.btnAddTask.TabIndex = 11;
            this.btnAddTask.Text = "Add existing task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(106, 94);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(28, 17);
            this.lbLocation.TabIndex = 7;
            this.lbLocation.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Located in ";
            // 
            // lbInUse
            // 
            this.lbInUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInUse.AutoSize = true;
            this.lbInUse.BackColor = System.Drawing.Color.White;
            this.lbInUse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInUse.ForeColor = System.Drawing.Color.Lime;
            this.lbInUse.Location = new System.Drawing.Point(730, 53);
            this.lbInUse.Name = "lbInUse";
            this.lbInUse.Size = new System.Drawing.Size(71, 26);
            this.lbInUse.TabIndex = 5;
            this.lbInUse.Text = "IN USE";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblStatus.Location = new System.Drawing.Point(756, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbDescription.Location = new System.Drawing.Point(33, 44);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(619, 46);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description";
            // 
            // lbEquipmentID
            // 
            this.lbEquipmentID.AutoSize = true;
            this.lbEquipmentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "EquipmentID", true));
            this.lbEquipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipmentID.Location = new System.Drawing.Point(290, 20);
            this.lbEquipmentID.Name = "lbEquipmentID";
            this.lbEquipmentID.Size = new System.Drawing.Size(27, 16);
            this.lbEquipmentID.TabIndex = 2;
            this.lbEquipmentID.Text = "-----";
            this.lbEquipmentID.DoubleClick += new System.EventHandler(this.lbEquipmentID_DoubleClick);
            // 
            // lblPMFor
            // 
            this.lblPMFor.AutoSize = true;
            this.lblPMFor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblPMFor.Location = new System.Drawing.Point(33, 20);
            this.lblPMFor.Name = "lblPMFor";
            this.lblPMFor.Size = new System.Drawing.Size(202, 15);
            this.lblPMFor.TabIndex = 0;
            this.lblPMFor.Text = "Preventative maintenance for Asset ";
            // 
            // tbl_pmscheduleBindingNavigator
            // 
            this.tbl_pmscheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_pmscheduleBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbl_pmscheduleBindingNavigator.BindingSource = this.tbl_pmscheduleBindingSource;
            this.tbl_pmscheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_pmscheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_pmscheduleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_pmscheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_pmscheduleBindingNavigatorSaveItem});
            this.tbl_pmscheduleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_pmscheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_pmscheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_pmscheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_pmscheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_pmscheduleBindingNavigator.Name = "tbl_pmscheduleBindingNavigator";
            this.tbl_pmscheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_pmscheduleBindingNavigator.Size = new System.Drawing.Size(941, 27);
            this.tbl_pmscheduleBindingNavigator.TabIndex = 1;
            this.tbl_pmscheduleBindingNavigator.Text = "bindingNavigator1";
            this.tbl_pmscheduleBindingNavigator.RefreshItems += new System.EventHandler(this.tbl_pmscheduleBindingNavigator_RefreshItems);
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
            // tbl_pmscheduleBindingNavigatorSaveItem
            // 
            this.tbl_pmscheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_pmscheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_pmscheduleBindingNavigatorSaveItem.Image")));
            this.tbl_pmscheduleBindingNavigatorSaveItem.Name = "tbl_pmscheduleBindingNavigatorSaveItem";
            this.tbl_pmscheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_pmscheduleBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_pmscheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_pmscheduleBindingNavigatorSaveItem_Click);
            // 
            // tbl_pmscheduleTableAdapter
            // 
            this.tbl_pmscheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = null;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = null;
            this.tableAdapterManager.tbl_colorTableAdapter = null;
            this.tableAdapterManager.tbl_partslistTableAdapter = null;
            this.tableAdapterManager.tbl_pmscheduleTableAdapter = this.tbl_pmscheduleTableAdapter;
            this.tableAdapterManager.tbl_pmtasksTableAdapter = this.tbl_pmtasksTableAdapter;
            this.tableAdapterManager.tbl_reportTableAdapter = null;
            this.tableAdapterManager.tbl_settingsTableAdapter = null;
            this.tableAdapterManager.tbl_usersTableAdapter = null;
            this.tableAdapterManager.tbl_worksordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EPED.eped_db1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_pmtasksTableAdapter
            // 
            this.tbl_pmtasksTableAdapter.ClearBeforeFill = true;
            // 
            // ShowPMDialogAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(941, 608);
            this.Controls.Add(this.tbl_pmscheduleBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(957, 655);
            this.MinimumSize = new System.Drawing.Size(957, 607);
            this.Name = "ShowPMDialogAdmin";
            this.Text = "Edit PM Tasks";
            this.Load += new System.EventHandler(this.ShowPMDialogAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleBindingNavigator)).EndInit();
            this.tbl_pmscheduleBindingNavigator.ResumeLayout(false);
            this.tbl_pmscheduleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPMFor;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInUse;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbEquipmentID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lbNoTasks2;
        private System.Windows.Forms.Label lbNoTasks1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStation;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_pmscheduleBindingSource;
        private eped_db1DataSetTableAdapters.tbl_pmscheduleTableAdapter tbl_pmscheduleTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_pmscheduleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_pmscheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DataGridView tbl_pmscheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox assignedTechComboBox;
        private System.Windows.Forms.ComboBox frequencyComboBox;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private eped_db1DataSetTableAdapters.tbl_pmtasksTableAdapter tbl_pmtasksTableAdapter;
        private System.Windows.Forms.BindingSource tbl_pmtasksBindingSource;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.TextBox perpetualNotesTextBox;
        private System.Windows.Forms.TextBox consequencesIfNotPerformedTextBox;
        private System.Windows.Forms.TextBox linkToInstructionTextBox;
        private System.Windows.Forms.TextBox startWeekNoTextBox;
        private System.Windows.Forms.ComboBox groupAllocationComboBox;
        private System.Windows.Forms.TextBox taskTextBox1;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.DateTimePicker estimatedDownTimePicker1;
        private System.Windows.Forms.ComboBox estimatedDownTimeComboBox;
        private System.Windows.Forms.ComboBox CmbBoxPMTasksSelection;
    }
}