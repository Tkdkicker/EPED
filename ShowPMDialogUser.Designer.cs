namespace EPED
{
    partial class ShowPMDialogUser
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label consequencesIfNotPerformedLabel;
            System.Windows.Forms.Label perpetualNotesLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label assignedTechLabel;
            System.Windows.Forms.Label frequencyLabel;
            System.Windows.Forms.Label startWeekNoLabel;
            this.lbStation = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInUse = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbEquipmentID = new System.Windows.Forms.Label();
            this.lblPMFor = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbBoxPMTasksSelectionUser = new System.Windows.Forms.ComboBox();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInstructionLink = new System.Windows.Forms.Label();
            this.currentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.startWeekNoTextBox = new System.Windows.Forms.TextBox();
            this.tbl_pmscheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitAndNotify = new System.Windows.Forms.Button();
            this.lbDueInDays = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbInstructionLocation = new System.Windows.Forms.Label();
            this.tbl_pmtasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consequencesIfNotPerformedTextBox = new System.Windows.Forms.TextBox();
            this.perpetualNotesTextBox = new System.Windows.Forms.TextBox();
            this.tbAction = new System.Windows.Forms.TextBox();
            this.assignedTechLabel1 = new System.Windows.Forms.Label();
            this.frequencyLabel1 = new System.Windows.Forms.Label();
            this.lbNoTasks = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbl_pmscheduleTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_pmscheduleTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            this.tbl_pmtasksTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_pmtasksTableAdapter();
            label3 = new System.Windows.Forms.Label();
            consequencesIfNotPerformedLabel = new System.Windows.Forms.Label();
            perpetualNotesLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            assignedTechLabel = new System.Windows.Forms.Label();
            frequencyLabel = new System.Windows.Forms.Label();
            startWeekNoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            label3.Location = new System.Drawing.Point(11, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 44;
            label3.Text = "Due:";
            // 
            // consequencesIfNotPerformedLabel
            // 
            consequencesIfNotPerformedLabel.AutoSize = true;
            consequencesIfNotPerformedLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            consequencesIfNotPerformedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            consequencesIfNotPerformedLabel.Location = new System.Drawing.Point(11, 84);
            consequencesIfNotPerformedLabel.Name = "consequencesIfNotPerformedLabel";
            consequencesIfNotPerformedLabel.Size = new System.Drawing.Size(180, 15);
            consequencesIfNotPerformedLabel.TabIndex = 40;
            consequencesIfNotPerformedLabel.Text = "Consequences if not performed:";
            // 
            // perpetualNotesLabel
            // 
            perpetualNotesLabel.AutoSize = true;
            perpetualNotesLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            perpetualNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            perpetualNotesLabel.Location = new System.Drawing.Point(10, 141);
            perpetualNotesLabel.Name = "perpetualNotesLabel";
            perpetualNotesLabel.Size = new System.Drawing.Size(92, 15);
            perpetualNotesLabel.TabIndex = 38;
            perpetualNotesLabel.Text = "Perpetual notes:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            label5.Location = new System.Drawing.Point(388, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 15);
            label5.TabIndex = 36;
            label5.Text = "Task status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            label4.Location = new System.Drawing.Point(10, 202);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(127, 15);
            label4.TabIndex = 35;
            label4.Text = "Task completion notes:";
            // 
            // assignedTechLabel
            // 
            assignedTechLabel.AutoSize = true;
            assignedTechLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            assignedTechLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            assignedTechLabel.Location = new System.Drawing.Point(11, 36);
            assignedTechLabel.Name = "assignedTechLabel";
            assignedTechLabel.Size = new System.Drawing.Size(70, 15);
            assignedTechLabel.TabIndex = 32;
            assignedTechLabel.Text = "Assigned to:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            frequencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            frequencyLabel.Location = new System.Drawing.Point(10, 59);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new System.Drawing.Size(65, 15);
            frequencyLabel.TabIndex = 30;
            frequencyLabel.Text = "Frequency:";
            // 
            // startWeekNoLabel
            // 
            startWeekNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            startWeekNoLabel.AutoSize = true;
            startWeekNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            startWeekNoLabel.Location = new System.Drawing.Point(388, 5);
            startWeekNoLabel.Name = "startWeekNoLabel";
            startWeekNoLabel.Size = new System.Drawing.Size(84, 15);
            startWeekNoLabel.TabIndex = 52;
            startWeekNoLabel.Text = "Start Week No:";
            startWeekNoLabel.Visible = false;
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStation.Location = new System.Drawing.Point(7, 105);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(33, 18);
            this.lbStation.TabIndex = 25;
            this.lbStation.Text = "-----";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(105, 85);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(27, 16);
            this.lbLocation.TabIndex = 23;
            this.lbLocation.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Located in ";
            // 
            // lbInUse
            // 
            this.lbInUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInUse.AutoSize = true;
            this.lbInUse.BackColor = System.Drawing.Color.White;
            this.lbInUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInUse.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInUse.ForeColor = System.Drawing.Color.Lime;
            this.lbInUse.Location = new System.Drawing.Point(377, 71);
            this.lbInUse.Name = "lbInUse";
            this.lbInUse.Size = new System.Drawing.Size(126, 29);
            this.lbInUse.TabIndex = 21;
            this.lbInUse.Text = "NOT IN USE";
            this.lbInUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblStatus.Location = new System.Drawing.Point(375, 56);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status:";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbDescription.Location = new System.Drawing.Point(6, 38);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(349, 46);
            this.lbDescription.TabIndex = 19;
            this.lbDescription.Text = "Description";
            // 
            // lbEquipmentID
            // 
            this.lbEquipmentID.AutoSize = true;
            this.lbEquipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipmentID.Location = new System.Drawing.Point(251, 18);
            this.lbEquipmentID.Name = "lbEquipmentID";
            this.lbEquipmentID.Size = new System.Drawing.Size(27, 16);
            this.lbEquipmentID.TabIndex = 18;
            this.lbEquipmentID.Text = "-----";
            // 
            // lblPMFor
            // 
            this.lblPMFor.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblPMFor.Location = new System.Drawing.Point(7, 15);
            this.lblPMFor.Name = "lblPMFor";
            this.lblPMFor.Size = new System.Drawing.Size(228, 40);
            this.lblPMFor.TabIndex = 17;
            this.lblPMFor.Text = "Preventative maintenance for Asset ";
            this.lblPMFor.Click += new System.EventHandler(this.lblPMFor_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWeek.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblWeek.Location = new System.Drawing.Point(0, 0);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(538, 31);
            this.lblWeek.TabIndex = 27;
            this.lblWeek.Text = "Week";
            this.lblWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWeek.Click += new System.EventHandler(this.lblWeek_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CmbBoxPMTasksSelectionUser);
            this.panel1.Controls.Add(this.lbStation);
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbInUse);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lbDescription);
            this.panel1.Controls.Add(this.lbEquipmentID);
            this.panel1.Controls.Add(this.lblPMFor);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 135);
            this.panel1.TabIndex = 28;
            // 
            // CmbBoxPMTasksSelectionUser
            // 
            this.CmbBoxPMTasksSelectionUser.FormattingEnabled = true;
            this.CmbBoxPMTasksSelectionUser.Location = new System.Drawing.Point(378, 18);
            this.CmbBoxPMTasksSelectionUser.Name = "CmbBoxPMTasksSelectionUser";
            this.CmbBoxPMTasksSelectionUser.Size = new System.Drawing.Size(126, 23);
            this.CmbBoxPMTasksSelectionUser.TabIndex = 26;
            this.CmbBoxPMTasksSelectionUser.SelectedIndexChanged += new System.EventHandler(this.CmbBoxPMTasksSelectionUser_SelectedIndexChanged);
            // 
            // lblDateRange
            // 
            this.lblDateRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDateRange.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDateRange.Location = new System.Drawing.Point(0, 31);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(538, 15);
            this.lblDateRange.TabIndex = 29;
            this.lblDateRange.Text = "dd/mm/yyyy to dd/mm/yyyy";
            this.lblDateRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateRange.Click += new System.EventHandler(this.lblDateRange_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(12, 198);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 28);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblInstructionLink);
            this.panel2.Controls.Add(this.currentStatusComboBox);
            this.panel2.Controls.Add(startWeekNoLabel);
            this.panel2.Controls.Add(this.startWeekNoTextBox);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubmitAndNotify);
            this.panel2.Controls.Add(this.lbDueInDays);
            this.panel2.Controls.Add(this.lbDueDate);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(this.lbInstructionLocation);
            this.panel2.Controls.Add(consequencesIfNotPerformedLabel);
            this.panel2.Controls.Add(this.consequencesIfNotPerformedTextBox);
            this.panel2.Controls.Add(perpetualNotesLabel);
            this.panel2.Controls.Add(this.perpetualNotesTextBox);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.tbAction);
            this.panel2.Controls.Add(assignedTechLabel);
            this.panel2.Controls.Add(this.assignedTechLabel1);
            this.panel2.Controls.Add(frequencyLabel);
            this.panel2.Controls.Add(this.frequencyLabel1);
            this.panel2.Location = new System.Drawing.Point(12, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 321);
            this.panel2.TabIndex = 31;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // lblInstructionLink
            // 
            this.lblInstructionLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructionLink.AutoSize = true;
            this.lblInstructionLink.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblInstructionLink.Location = new System.Drawing.Point(420, 84);
            this.lblInstructionLink.Name = "lblInstructionLink";
            this.lblInstructionLink.Size = new System.Drawing.Size(69, 15);
            this.lblInstructionLink.TabIndex = 54;
            this.lblInstructionLink.Text = "Instructions";
            this.lblInstructionLink.Click += new System.EventHandler(this.lbInstructionLink_Click);
            this.lblInstructionLink.MouseEnter += new System.EventHandler(this.lblInstructionLink_MouseEnter);
            this.lblInstructionLink.MouseLeave += new System.EventHandler(this.lblInstructionLink_MouseLeave);
            this.lblInstructionLink.MouseHover += new System.EventHandler(this.lblInstructionLink_MouseHover);
            // 
            // currentStatusComboBox
            // 
            this.currentStatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentStatusComboBox.FormattingEnabled = true;
            this.currentStatusComboBox.Items.AddRange(new object[] {
            "To do",
            "Completed",
            "In progress",
            "Issue during maintenance"});
            this.currentStatusComboBox.Location = new System.Drawing.Point(335, 45);
            this.currentStatusComboBox.Name = "currentStatusComboBox";
            this.currentStatusComboBox.Size = new System.Drawing.Size(165, 23);
            this.currentStatusComboBox.TabIndex = 26;
            this.currentStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.currentStatusComboBox.SelectionChangeCommitted += new System.EventHandler(this.currentStatusComboBox_SelectionChangeCommitted);
            this.currentStatusComboBox.MouseLeave += new System.EventHandler(this.currentStatusComboBox_MouseLeave);
            // 
            // startWeekNoTextBox
            // 
            this.startWeekNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startWeekNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startWeekNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "StartWeekNo", true));
            this.startWeekNoTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.startWeekNoTextBox.Location = new System.Drawing.Point(472, 5);
            this.startWeekNoTextBox.Name = "startWeekNoTextBox";
            this.startWeekNoTextBox.Size = new System.Drawing.Size(39, 16);
            this.startWeekNoTextBox.TabIndex = 53;
            // 
            // tbl_pmscheduleBindingSource
            // 
            this.tbl_pmscheduleBindingSource.DataMember = "tbl_pmschedule";
            this.tbl_pmscheduleBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnCancel.Location = new System.Drawing.Point(12, 289);
            this.btnCancel.MaximumSize = new System.Drawing.Size(86, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 27);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitAndNotify
            // 
            this.btnSubmitAndNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitAndNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSubmitAndNotify.FlatAppearance.BorderSize = 0;
            this.btnSubmitAndNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAndNotify.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAndNotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSubmitAndNotify.Location = new System.Drawing.Point(377, 289);
            this.btnSubmitAndNotify.Name = "btnSubmitAndNotify";
            this.btnSubmitAndNotify.Size = new System.Drawing.Size(126, 27);
            this.btnSubmitAndNotify.TabIndex = 50;
            this.btnSubmitAndNotify.Text = "Submit and notify";
            this.btnSubmitAndNotify.UseVisualStyleBackColor = false;
            this.btnSubmitAndNotify.Visible = false;
            this.btnSubmitAndNotify.Click += new System.EventHandler(this.btnSubmitAndNotify_Click);
            // 
            // lbDueInDays
            // 
            this.lbDueInDays.AutoSize = true;
            this.lbDueInDays.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDueInDays.Location = new System.Drawing.Point(135, 10);
            this.lbDueInDays.Name = "lbDueInDays";
            this.lbDueInDays.Size = new System.Drawing.Size(27, 15);
            this.lbDueInDays.TabIndex = 49;
            this.lbDueInDays.Text = "-----";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDueDate.Location = new System.Drawing.Point(52, 10);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(77, 15);
            this.lbDueDate.TabIndex = 48;
            this.lbDueDate.Text = "dd/MM/yyyy";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnUpdate.Location = new System.Drawing.Point(192, 289);
            this.btnUpdate.MaximumSize = new System.Drawing.Size(86, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 27);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbInstructionLocation
            // 
            this.lbInstructionLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstructionLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "LinkToInstruction", true));
            this.lbInstructionLocation.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructionLocation.Location = new System.Drawing.Point(447, 135);
            this.lbInstructionLocation.Name = "lbInstructionLocation";
            this.lbInstructionLocation.Size = new System.Drawing.Size(38, 21);
            this.lbInstructionLocation.TabIndex = 43;
            this.lbInstructionLocation.Text = "-----";
            this.lbInstructionLocation.Visible = false;
            // 
            // tbl_pmtasksBindingSource
            // 
            this.tbl_pmtasksBindingSource.DataMember = "tbl_pmtasks";
            this.tbl_pmtasksBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // consequencesIfNotPerformedTextBox
            // 
            this.consequencesIfNotPerformedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consequencesIfNotPerformedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consequencesIfNotPerformedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "ConsequencesIfNotPerformed", true));
            this.consequencesIfNotPerformedTextBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consequencesIfNotPerformedTextBox.Location = new System.Drawing.Point(10, 104);
            this.consequencesIfNotPerformedTextBox.Multiline = true;
            this.consequencesIfNotPerformedTextBox.Name = "consequencesIfNotPerformedTextBox";
            this.consequencesIfNotPerformedTextBox.Size = new System.Drawing.Size(370, 35);
            this.consequencesIfNotPerformedTextBox.TabIndex = 42;
            // 
            // perpetualNotesTextBox
            // 
            this.perpetualNotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perpetualNotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perpetualNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmtasksBindingSource, "PerpetualNotes", true));
            this.perpetualNotesTextBox.Enabled = false;
            this.perpetualNotesTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perpetualNotesTextBox.Location = new System.Drawing.Point(12, 160);
            this.perpetualNotesTextBox.Multiline = true;
            this.perpetualNotesTextBox.Name = "perpetualNotesTextBox";
            this.perpetualNotesTextBox.Size = new System.Drawing.Size(492, 39);
            this.perpetualNotesTextBox.TabIndex = 39;
            // 
            // tbAction
            // 
            this.tbAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAction.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAction.Location = new System.Drawing.Point(12, 222);
            this.tbAction.Multiline = true;
            this.tbAction.Name = "tbAction";
            this.tbAction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAction.Size = new System.Drawing.Size(492, 60);
            this.tbAction.TabIndex = 34;
            // 
            // assignedTechLabel1
            // 
            this.assignedTechLabel1.AutoSize = true;
            this.assignedTechLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "AssignedTech", true));
            this.assignedTechLabel1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedTechLabel1.Location = new System.Drawing.Point(97, 36);
            this.assignedTechLabel1.Name = "assignedTechLabel1";
            this.assignedTechLabel1.Size = new System.Drawing.Size(27, 15);
            this.assignedTechLabel1.TabIndex = 33;
            this.assignedTechLabel1.Text = "-----";
            // 
            // frequencyLabel1
            // 
            this.frequencyLabel1.AutoSize = true;
            this.frequencyLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_pmscheduleBindingSource, "Frequency", true));
            this.frequencyLabel1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabel1.Location = new System.Drawing.Point(93, 59);
            this.frequencyLabel1.Name = "frequencyLabel1";
            this.frequencyLabel1.Size = new System.Drawing.Size(31, 15);
            this.frequencyLabel1.TabIndex = 31;
            this.frequencyLabel1.Text = "------";
            // 
            // lbNoTasks
            // 
            this.lbNoTasks.AutoSize = true;
            this.lbNoTasks.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTasks.Location = new System.Drawing.Point(77, 374);
            this.lbNoTasks.Name = "lbNoTasks";
            this.lbNoTasks.Size = new System.Drawing.Size(206, 27);
            this.lbNoTasks.TabIndex = 32;
            this.lbNoTasks.Text = "No tasks for this week";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnClose.Location = new System.Drawing.Point(440, 570);
            this.btnClose.MaximumSize = new System.Drawing.Size(86, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 27);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.tableAdapterManager.tbl_pmtasksTableAdapter = null;
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
            // ShowPMDialogUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(538, 660);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblDateRange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lbNoTasks);
            this.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(554, 699);
            this.Name = "ShowPMDialogUser";
            this.Text = "PM Dialog User View";
            this.Load += new System.EventHandler(this.ShowPMDialogUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmscheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pmtasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStation;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInUse;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbEquipmentID;
        private System.Windows.Forms.Label lblPMFor;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateRange;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_pmscheduleBindingSource;
        private eped_db1DataSetTableAdapters.tbl_pmscheduleTableAdapter tbl_pmscheduleTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbl_pmtasksBindingSource;
        private eped_db1DataSetTableAdapters.tbl_pmtasksTableAdapter tbl_pmtasksTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbInstructionLocation;
        private System.Windows.Forms.TextBox consequencesIfNotPerformedTextBox;
        private System.Windows.Forms.TextBox perpetualNotesTextBox;
        private System.Windows.Forms.TextBox tbAction;
        private System.Windows.Forms.Label assignedTechLabel1;
        private System.Windows.Forms.Label frequencyLabel1;
        private System.Windows.Forms.Label lbDueInDays;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.Label lbNoTasks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitAndNotify;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox startWeekNoTextBox;
        private System.Windows.Forms.ComboBox currentStatusComboBox;
        private System.Windows.Forms.Label lblInstructionLink;
        private System.Windows.Forms.ComboBox CmbBoxPMTasksSelectionUser;
    }
}