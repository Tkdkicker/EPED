namespace EPED
{
    partial class ShowAssetListFrm
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
            System.Windows.Forms.Label siteNameLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label equipmentDescriptionLabel;
            System.Windows.Forms.Label equipmentManufacturerLabel;
            System.Windows.Forms.Label modelNoLabel;
            System.Windows.Forms.Label serialNoLabel;
            System.Windows.Forms.Label equipmentReceivedDateLabel;
            System.Windows.Forms.Label calibrationRequiredLabel;
            System.Windows.Forms.Label dateOfCalibrationLabel;
            System.Windows.Forms.Label dateCalibrationDueLabel;
            System.Windows.Forms.Label calibrationIntervalLabel;
            System.Windows.Forms.Label calibrationCertLocationLabel;
            System.Windows.Forms.Label calibrationTestHouseLabel;
            System.Windows.Forms.Label calibrationCostsLabel;
            System.Windows.Forms.Label reminderPeriodForCalibrationLabel;
            System.Windows.Forms.Label verificationRequiredLabel;
            System.Windows.Forms.Label dateOfVerificationLabel;
            System.Windows.Forms.Label dateVerificationDueLabel;
            System.Windows.Forms.Label verificationIntervalLabel;
            System.Windows.Forms.Label reminderPeriodForVerificationLabel;
            System.Windows.Forms.Label pATTestRequiredLabel;
            System.Windows.Forms.Label dateOfPATLabel;
            System.Windows.Forms.Label datePATDueLabel;
            System.Windows.Forms.Label pATIntervalLabel;
            System.Windows.Forms.Label reminderPeriodForPATLabel;
            System.Windows.Forms.Label eHVAssetNoLabel;
            System.Windows.Forms.Label equipmentManualLocationLabel;
            System.Windows.Forms.Label groupAllocationLabel;
            System.Windows.Forms.Label custodianLabel;
            System.Windows.Forms.Label inUseLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label multiplePMLabel;
            System.Windows.Forms.Label stationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAssetListFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchOn = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnShowByGroupAllcoation = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPMTasks = new System.Windows.Forms.Button();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.tbl_assetregisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eped_db1DataSet = new EPED.eped_db1DataSet();
            this.multiplePMCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCertLocation = new System.Windows.Forms.Button();
            this.btnManualLocation = new System.Windows.Forms.Button();
            this.inUsecheckBox = new System.Windows.Forms.CheckBox();
            this.pATTestRequiredcheckBox = new System.Windows.Forms.CheckBox();
            this.verificationRequiredcheckBox = new System.Windows.Forms.CheckBox();
            this.calibrationRequiredcheckBox = new System.Windows.Forms.CheckBox();
            this.reminderPeriodForPATComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.siteNameComboBox = new System.Windows.Forms.ComboBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.equipmentManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.modelNoTextBox = new System.Windows.Forms.TextBox();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.equipmentReceivedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfCalibrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCalibrationDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calibrationIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.calibrationCertLocationTextBox = new System.Windows.Forms.TextBox();
            this.calibrationTestHouseTextBox = new System.Windows.Forms.TextBox();
            this.calibrationCostsTextBox = new System.Windows.Forms.TextBox();
            this.reminderPeriodForCalibrationComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfVerificationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateVerificationDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.verificationIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.reminderPeriodForVerificationComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfPATDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datePATDueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pATIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.eHVAssetNoTextBox = new System.Windows.Forms.TextBox();
            this.equipmentManualLocationTextBox = new System.Windows.Forms.TextBox();
            this.groupAllocationComboBox = new System.Windows.Forms.ComboBox();
            this.custodianComboBox = new System.Windows.Forms.ComboBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveUpdates = new System.Windows.Forms.Button();
            this.btnAddNewAsset = new System.Windows.Forms.Button();
            this.cmbGroupAllocation = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOngoing = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.cmbByArea = new System.Windows.Forms.ComboBox();
            this.btnByArea = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbPAT = new System.Windows.Forms.RadioButton();
            this.rbVerify = new System.Windows.Forms.RadioButton();
            this.rbCalib = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnShowAssetsDue = new System.Windows.Forms.Button();
            this.txbSearchOn = new System.Windows.Forms.TextBox();
            this.tbl_assetregisterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_assetregisterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_assetregisterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MultiplePM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSetGroupAllocation = new System.Windows.Forms.ComboBox();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.rbRowsToGroupAllocation = new System.Windows.Forms.RadioButton();
            this.rbRowsToWorkOrder = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tbl_assetregisterTableAdapter = new EPED.eped_db1DataSetTableAdapters.tbl_assetregisterTableAdapter();
            this.tableAdapterManager = new EPED.eped_db1DataSetTableAdapters.TableAdapterManager();
            equipmentIDLabel = new System.Windows.Forms.Label();
            siteNameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            equipmentDescriptionLabel = new System.Windows.Forms.Label();
            equipmentManufacturerLabel = new System.Windows.Forms.Label();
            modelNoLabel = new System.Windows.Forms.Label();
            serialNoLabel = new System.Windows.Forms.Label();
            equipmentReceivedDateLabel = new System.Windows.Forms.Label();
            calibrationRequiredLabel = new System.Windows.Forms.Label();
            dateOfCalibrationLabel = new System.Windows.Forms.Label();
            dateCalibrationDueLabel = new System.Windows.Forms.Label();
            calibrationIntervalLabel = new System.Windows.Forms.Label();
            calibrationCertLocationLabel = new System.Windows.Forms.Label();
            calibrationTestHouseLabel = new System.Windows.Forms.Label();
            calibrationCostsLabel = new System.Windows.Forms.Label();
            reminderPeriodForCalibrationLabel = new System.Windows.Forms.Label();
            verificationRequiredLabel = new System.Windows.Forms.Label();
            dateOfVerificationLabel = new System.Windows.Forms.Label();
            dateVerificationDueLabel = new System.Windows.Forms.Label();
            verificationIntervalLabel = new System.Windows.Forms.Label();
            reminderPeriodForVerificationLabel = new System.Windows.Forms.Label();
            pATTestRequiredLabel = new System.Windows.Forms.Label();
            dateOfPATLabel = new System.Windows.Forms.Label();
            datePATDueLabel = new System.Windows.Forms.Label();
            pATIntervalLabel = new System.Windows.Forms.Label();
            reminderPeriodForPATLabel = new System.Windows.Forms.Label();
            eHVAssetNoLabel = new System.Windows.Forms.Label();
            equipmentManualLocationLabel = new System.Windows.Forms.Label();
            groupAllocationLabel = new System.Windows.Forms.Label();
            custodianLabel = new System.Windows.Forms.Label();
            inUseLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            multiplePMLabel = new System.Windows.Forms.Label();
            stationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetregisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetregisterBindingNavigator)).BeginInit();
            this.tbl_assetregisterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetregisterDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentIDLabel.Location = new System.Drawing.Point(7, 10);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(81, 15);
            equipmentIDLabel.TabIndex = 0;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // siteNameLabel
            // 
            siteNameLabel.AutoSize = true;
            siteNameLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            siteNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            siteNameLabel.Location = new System.Drawing.Point(7, 39);
            siteNameLabel.Name = "siteNameLabel";
            siteNameLabel.Size = new System.Drawing.Size(62, 15);
            siteNameLabel.TabIndex = 2;
            siteNameLabel.Text = "Site Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            locationLabel.Location = new System.Drawing.Point(7, 70);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(55, 15);
            locationLabel.TabIndex = 4;
            locationLabel.Text = "Location:";
            // 
            // equipmentDescriptionLabel
            // 
            equipmentDescriptionLabel.AutoSize = true;
            equipmentDescriptionLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentDescriptionLabel.Location = new System.Drawing.Point(7, 136);
            equipmentDescriptionLabel.Name = "equipmentDescriptionLabel";
            equipmentDescriptionLabel.Size = new System.Drawing.Size(130, 15);
            equipmentDescriptionLabel.TabIndex = 6;
            equipmentDescriptionLabel.Text = "Equipment Description:";
            // 
            // equipmentManufacturerLabel
            // 
            equipmentManufacturerLabel.AutoSize = true;
            equipmentManufacturerLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentManufacturerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentManufacturerLabel.Location = new System.Drawing.Point(7, 168);
            equipmentManufacturerLabel.Name = "equipmentManufacturerLabel";
            equipmentManufacturerLabel.Size = new System.Drawing.Size(142, 15);
            equipmentManufacturerLabel.TabIndex = 8;
            equipmentManufacturerLabel.Text = "Equipment Manufacturer:";
            // 
            // modelNoLabel
            // 
            modelNoLabel.AutoSize = true;
            modelNoLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            modelNoLabel.Location = new System.Drawing.Point(7, 200);
            modelNoLabel.Name = "modelNoLabel";
            modelNoLabel.Size = new System.Drawing.Size(62, 15);
            modelNoLabel.TabIndex = 10;
            modelNoLabel.Text = "Model No:";
            // 
            // serialNoLabel
            // 
            serialNoLabel.AutoSize = true;
            serialNoLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serialNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            serialNoLabel.Location = new System.Drawing.Point(7, 230);
            serialNoLabel.Name = "serialNoLabel";
            serialNoLabel.Size = new System.Drawing.Size(56, 15);
            serialNoLabel.TabIndex = 12;
            serialNoLabel.Text = "Serial No:";
            // 
            // equipmentReceivedDateLabel
            // 
            equipmentReceivedDateLabel.AutoSize = true;
            equipmentReceivedDateLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentReceivedDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentReceivedDateLabel.Location = new System.Drawing.Point(7, 261);
            equipmentReceivedDateLabel.Name = "equipmentReceivedDateLabel";
            equipmentReceivedDateLabel.Size = new System.Drawing.Size(144, 15);
            equipmentReceivedDateLabel.TabIndex = 14;
            equipmentReceivedDateLabel.Text = "Equipment Received Date:";
            // 
            // calibrationRequiredLabel
            // 
            calibrationRequiredLabel.AutoSize = true;
            calibrationRequiredLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calibrationRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            calibrationRequiredLabel.Location = new System.Drawing.Point(7, 321);
            calibrationRequiredLabel.Name = "calibrationRequiredLabel";
            calibrationRequiredLabel.Size = new System.Drawing.Size(117, 15);
            calibrationRequiredLabel.TabIndex = 16;
            calibrationRequiredLabel.Text = "Calibration Required:";
            // 
            // dateOfCalibrationLabel
            // 
            dateOfCalibrationLabel.AutoSize = true;
            dateOfCalibrationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfCalibrationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateOfCalibrationLabel.Location = new System.Drawing.Point(7, 351);
            dateOfCalibrationLabel.Name = "dateOfCalibrationLabel";
            dateOfCalibrationLabel.Size = new System.Drawing.Size(110, 15);
            dateOfCalibrationLabel.TabIndex = 18;
            dateOfCalibrationLabel.Text = "Date Of Calibration:";
            // 
            // dateCalibrationDueLabel
            // 
            dateCalibrationDueLabel.AutoSize = true;
            dateCalibrationDueLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateCalibrationDueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateCalibrationDueLabel.Location = new System.Drawing.Point(7, 381);
            dateCalibrationDueLabel.Name = "dateCalibrationDueLabel";
            dateCalibrationDueLabel.Size = new System.Drawing.Size(118, 15);
            dateCalibrationDueLabel.TabIndex = 20;
            dateCalibrationDueLabel.Text = "Date Calibration Due:";
            // 
            // calibrationIntervalLabel
            // 
            calibrationIntervalLabel.AutoSize = true;
            calibrationIntervalLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calibrationIntervalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            calibrationIntervalLabel.Location = new System.Drawing.Point(7, 410);
            calibrationIntervalLabel.Name = "calibrationIntervalLabel";
            calibrationIntervalLabel.Size = new System.Drawing.Size(109, 15);
            calibrationIntervalLabel.TabIndex = 22;
            calibrationIntervalLabel.Text = "Calibration Interval:";
            // 
            // calibrationCertLocationLabel
            // 
            calibrationCertLocationLabel.AutoSize = true;
            calibrationCertLocationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calibrationCertLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            calibrationCertLocationLabel.Location = new System.Drawing.Point(7, 447);
            calibrationCertLocationLabel.Name = "calibrationCertLocationLabel";
            calibrationCertLocationLabel.Size = new System.Drawing.Size(139, 15);
            calibrationCertLocationLabel.TabIndex = 28;
            calibrationCertLocationLabel.Text = "Calibration Cert Location:";
            calibrationCertLocationLabel.Click += new System.EventHandler(this.calibrationCertLocationLabel_Click);
            // 
            // calibrationTestHouseLabel
            // 
            calibrationTestHouseLabel.AutoSize = true;
            calibrationTestHouseLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calibrationTestHouseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            calibrationTestHouseLabel.Location = new System.Drawing.Point(7, 477);
            calibrationTestHouseLabel.Name = "calibrationTestHouseLabel";
            calibrationTestHouseLabel.Size = new System.Drawing.Size(126, 15);
            calibrationTestHouseLabel.TabIndex = 30;
            calibrationTestHouseLabel.Text = "Calibration Test House:";
            // 
            // calibrationCostsLabel
            // 
            calibrationCostsLabel.AutoSize = true;
            calibrationCostsLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calibrationCostsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            calibrationCostsLabel.Location = new System.Drawing.Point(7, 509);
            calibrationCostsLabel.Name = "calibrationCostsLabel";
            calibrationCostsLabel.Size = new System.Drawing.Size(98, 15);
            calibrationCostsLabel.TabIndex = 32;
            calibrationCostsLabel.Text = "Calibration Costs:";
            // 
            // reminderPeriodForCalibrationLabel
            // 
            reminderPeriodForCalibrationLabel.AutoSize = true;
            reminderPeriodForCalibrationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reminderPeriodForCalibrationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            reminderPeriodForCalibrationLabel.Location = new System.Drawing.Point(7, 539);
            reminderPeriodForCalibrationLabel.Name = "reminderPeriodForCalibrationLabel";
            reminderPeriodForCalibrationLabel.Size = new System.Drawing.Size(177, 15);
            reminderPeriodForCalibrationLabel.TabIndex = 34;
            reminderPeriodForCalibrationLabel.Text = "Reminder Period For Calibration:";
            // 
            // verificationRequiredLabel
            // 
            verificationRequiredLabel.AutoSize = true;
            verificationRequiredLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            verificationRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            verificationRequiredLabel.Location = new System.Drawing.Point(7, 571);
            verificationRequiredLabel.Name = "verificationRequiredLabel";
            verificationRequiredLabel.Size = new System.Drawing.Size(119, 15);
            verificationRequiredLabel.TabIndex = 36;
            verificationRequiredLabel.Text = "Verification Required:";
            // 
            // dateOfVerificationLabel
            // 
            dateOfVerificationLabel.AutoSize = true;
            dateOfVerificationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfVerificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateOfVerificationLabel.Location = new System.Drawing.Point(7, 601);
            dateOfVerificationLabel.Name = "dateOfVerificationLabel";
            dateOfVerificationLabel.Size = new System.Drawing.Size(112, 15);
            dateOfVerificationLabel.TabIndex = 38;
            dateOfVerificationLabel.Text = "Date Of Verification:";
            // 
            // dateVerificationDueLabel
            // 
            dateVerificationDueLabel.AutoSize = true;
            dateVerificationDueLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateVerificationDueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateVerificationDueLabel.Location = new System.Drawing.Point(7, 631);
            dateVerificationDueLabel.Name = "dateVerificationDueLabel";
            dateVerificationDueLabel.Size = new System.Drawing.Size(120, 15);
            dateVerificationDueLabel.TabIndex = 40;
            dateVerificationDueLabel.Text = "Date Verification Due:";
            // 
            // verificationIntervalLabel
            // 
            verificationIntervalLabel.AutoSize = true;
            verificationIntervalLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            verificationIntervalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            verificationIntervalLabel.Location = new System.Drawing.Point(3, 662);
            verificationIntervalLabel.Name = "verificationIntervalLabel";
            verificationIntervalLabel.Size = new System.Drawing.Size(111, 15);
            verificationIntervalLabel.TabIndex = 42;
            verificationIntervalLabel.Text = "Verification Interval:";
            // 
            // reminderPeriodForVerificationLabel
            // 
            reminderPeriodForVerificationLabel.AutoSize = true;
            reminderPeriodForVerificationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reminderPeriodForVerificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            reminderPeriodForVerificationLabel.Location = new System.Drawing.Point(3, 693);
            reminderPeriodForVerificationLabel.Name = "reminderPeriodForVerificationLabel";
            reminderPeriodForVerificationLabel.Size = new System.Drawing.Size(179, 15);
            reminderPeriodForVerificationLabel.TabIndex = 44;
            reminderPeriodForVerificationLabel.Text = "Reminder Period For Verification:";
            // 
            // pATTestRequiredLabel
            // 
            pATTestRequiredLabel.AutoSize = true;
            pATTestRequiredLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pATTestRequiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            pATTestRequiredLabel.Location = new System.Drawing.Point(3, 723);
            pATTestRequiredLabel.Name = "pATTestRequiredLabel";
            pATTestRequiredLabel.Size = new System.Drawing.Size(98, 15);
            pATTestRequiredLabel.TabIndex = 46;
            pATTestRequiredLabel.Text = "PATTest Required:";
            // 
            // dateOfPATLabel
            // 
            dateOfPATLabel.AutoSize = true;
            dateOfPATLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfPATLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dateOfPATLabel.Location = new System.Drawing.Point(3, 754);
            dateOfPATLabel.Name = "dateOfPATLabel";
            dateOfPATLabel.Size = new System.Drawing.Size(70, 15);
            dateOfPATLabel.TabIndex = 48;
            dateOfPATLabel.Text = "Date Of PAT:";
            // 
            // datePATDueLabel
            // 
            datePATDueLabel.AutoSize = true;
            datePATDueLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePATDueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            datePATDueLabel.Location = new System.Drawing.Point(3, 784);
            datePATDueLabel.Name = "datePATDueLabel";
            datePATDueLabel.Size = new System.Drawing.Size(76, 15);
            datePATDueLabel.TabIndex = 50;
            datePATDueLabel.Text = "Date PATDue:";
            // 
            // pATIntervalLabel
            // 
            pATIntervalLabel.AutoSize = true;
            pATIntervalLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pATIntervalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            pATIntervalLabel.Location = new System.Drawing.Point(3, 820);
            pATIntervalLabel.Name = "pATIntervalLabel";
            pATIntervalLabel.Size = new System.Drawing.Size(67, 15);
            pATIntervalLabel.TabIndex = 52;
            pATIntervalLabel.Text = "PATInterval:";
            // 
            // reminderPeriodForPATLabel
            // 
            reminderPeriodForPATLabel.AutoSize = true;
            reminderPeriodForPATLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reminderPeriodForPATLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            reminderPeriodForPATLabel.Location = new System.Drawing.Point(3, 851);
            reminderPeriodForPATLabel.Name = "reminderPeriodForPATLabel";
            reminderPeriodForPATLabel.Size = new System.Drawing.Size(137, 15);
            reminderPeriodForPATLabel.TabIndex = 54;
            reminderPeriodForPATLabel.Text = "Reminder Period For PAT:";
            // 
            // eHVAssetNoLabel
            // 
            eHVAssetNoLabel.AutoSize = true;
            eHVAssetNoLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eHVAssetNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            eHVAssetNoLabel.Location = new System.Drawing.Point(3, 877);
            eHVAssetNoLabel.Name = "eHVAssetNoLabel";
            eHVAssetNoLabel.Size = new System.Drawing.Size(79, 15);
            eHVAssetNoLabel.TabIndex = 56;
            eHVAssetNoLabel.Text = "TDA Asset No:";
            // 
            // equipmentManualLocationLabel
            // 
            equipmentManualLocationLabel.AutoSize = true;
            equipmentManualLocationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipmentManualLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            equipmentManualLocationLabel.Location = new System.Drawing.Point(3, 910);
            equipmentManualLocationLabel.Name = "equipmentManualLocationLabel";
            equipmentManualLocationLabel.Size = new System.Drawing.Size(158, 15);
            equipmentManualLocationLabel.TabIndex = 58;
            equipmentManualLocationLabel.Text = "Equipment Manual Location:";
            equipmentManualLocationLabel.Click += new System.EventHandler(this.equipmentManualLocationLabel_Click);
            // 
            // groupAllocationLabel
            // 
            groupAllocationLabel.AutoSize = true;
            groupAllocationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupAllocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            groupAllocationLabel.Location = new System.Drawing.Point(3, 940);
            groupAllocationLabel.Name = "groupAllocationLabel";
            groupAllocationLabel.Size = new System.Drawing.Size(99, 15);
            groupAllocationLabel.TabIndex = 60;
            groupAllocationLabel.Text = "Group Allocation:";
            // 
            // custodianLabel
            // 
            custodianLabel.AutoSize = true;
            custodianLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            custodianLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            custodianLabel.Location = new System.Drawing.Point(3, 971);
            custodianLabel.Name = "custodianLabel";
            custodianLabel.Size = new System.Drawing.Size(63, 15);
            custodianLabel.TabIndex = 62;
            custodianLabel.Text = "Custodian:";
            // 
            // inUseLabel
            // 
            inUseLabel.AutoSize = true;
            inUseLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inUseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            inUseLabel.Location = new System.Drawing.Point(3, 1003);
            inUseLabel.Name = "inUseLabel";
            inUseLabel.Size = new System.Drawing.Size(42, 15);
            inUseLabel.TabIndex = 64;
            inUseLabel.Text = "In Use:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            notesLabel.Location = new System.Drawing.Point(3, 1059);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(40, 15);
            notesLabel.TabIndex = 66;
            notesLabel.Text = "Notes:";
            // 
            // multiplePMLabel
            // 
            multiplePMLabel.AutoSize = true;
            multiplePMLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            multiplePMLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            multiplePMLabel.Location = new System.Drawing.Point(7, 293);
            multiplePMLabel.Name = "multiplePMLabel";
            multiplePMLabel.Size = new System.Drawing.Size(78, 15);
            multiplePMLabel.TabIndex = 257;
            multiplePMLabel.Text = "PM Required:";
            // 
            // stationLabel
            // 
            stationLabel.AutoSize = true;
            stationLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            stationLabel.Location = new System.Drawing.Point(7, 102);
            stationLabel.Name = "stationLabel";
            stationLabel.Size = new System.Drawing.Size(47, 15);
            stationLabel.TabIndex = 258;
            stationLabel.Text = "Station:";
            // 
            // btnSearchOn
            // 
            this.btnSearchOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSearchOn.FlatAppearance.BorderSize = 0;
            this.btnSearchOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOn.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSearchOn.Location = new System.Drawing.Point(7, 18);
            this.btnSearchOn.Name = "btnSearchOn";
            this.btnSearchOn.Size = new System.Drawing.Size(89, 40);
            this.btnSearchOn.TabIndex = 2;
            this.btnSearchOn.Text = "SEARCH";
            this.btnSearchOn.UseVisualStyleBackColor = false;
            this.btnSearchOn.Click += new System.EventHandler(this.SearchOn_button_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnExportCSV.Location = new System.Drawing.Point(7, 70);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(89, 40);
            this.btnExportCSV.TabIndex = 4;
            this.btnExportCSV.Text = "EXPORT FOR Excel";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnShowByGroupAllcoation
            // 
            this.btnShowByGroupAllcoation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnShowByGroupAllcoation.FlatAppearance.BorderSize = 0;
            this.btnShowByGroupAllcoation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowByGroupAllcoation.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowByGroupAllcoation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnShowByGroupAllcoation.Location = new System.Drawing.Point(480, 17);
            this.btnShowByGroupAllcoation.Name = "btnShowByGroupAllcoation";
            this.btnShowByGroupAllcoation.Size = new System.Drawing.Size(165, 40);
            this.btnShowByGroupAllcoation.TabIndex = 5;
            this.btnShowByGroupAllcoation.Text = "SHOW BY GROUP ALLOCATION:";
            this.btnShowByGroupAllcoation.UseVisualStyleBackColor = false;
            this.btnShowByGroupAllcoation.Click += new System.EventHandler(this.btnShowByGroupAllcoation_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnPrint.Location = new System.Drawing.Point(118, 72);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 40);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "PRINT ASSET LIST";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPMTasks);
            this.panel1.Controls.Add(stationLabel);
            this.panel1.Controls.Add(this.stationComboBox);
            this.panel1.Controls.Add(multiplePMLabel);
            this.panel1.Controls.Add(this.multiplePMCheckBox);
            this.panel1.Controls.Add(this.btnCertLocation);
            this.panel1.Controls.Add(this.btnManualLocation);
            this.panel1.Controls.Add(this.inUsecheckBox);
            this.panel1.Controls.Add(this.pATTestRequiredcheckBox);
            this.panel1.Controls.Add(this.verificationRequiredcheckBox);
            this.panel1.Controls.Add(this.calibrationRequiredcheckBox);
            this.panel1.Controls.Add(this.reminderPeriodForPATComboBox);
            this.panel1.Controls.Add(equipmentIDLabel);
            this.panel1.Controls.Add(this.equipmentIDTextBox);
            this.panel1.Controls.Add(siteNameLabel);
            this.panel1.Controls.Add(this.siteNameComboBox);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationComboBox);
            this.panel1.Controls.Add(equipmentDescriptionLabel);
            this.panel1.Controls.Add(this.equipmentDescriptionTextBox);
            this.panel1.Controls.Add(equipmentManufacturerLabel);
            this.panel1.Controls.Add(this.equipmentManufacturerComboBox);
            this.panel1.Controls.Add(modelNoLabel);
            this.panel1.Controls.Add(this.modelNoTextBox);
            this.panel1.Controls.Add(serialNoLabel);
            this.panel1.Controls.Add(this.serialNoTextBox);
            this.panel1.Controls.Add(equipmentReceivedDateLabel);
            this.panel1.Controls.Add(this.equipmentReceivedDateDateTimePicker);
            this.panel1.Controls.Add(calibrationRequiredLabel);
            this.panel1.Controls.Add(dateOfCalibrationLabel);
            this.panel1.Controls.Add(this.dateOfCalibrationDateTimePicker);
            this.panel1.Controls.Add(dateCalibrationDueLabel);
            this.panel1.Controls.Add(this.dateCalibrationDueDateTimePicker);
            this.panel1.Controls.Add(calibrationIntervalLabel);
            this.panel1.Controls.Add(this.calibrationIntervalComboBox);
            this.panel1.Controls.Add(calibrationCertLocationLabel);
            this.panel1.Controls.Add(this.calibrationCertLocationTextBox);
            this.panel1.Controls.Add(calibrationTestHouseLabel);
            this.panel1.Controls.Add(this.calibrationTestHouseTextBox);
            this.panel1.Controls.Add(calibrationCostsLabel);
            this.panel1.Controls.Add(this.calibrationCostsTextBox);
            this.panel1.Controls.Add(reminderPeriodForCalibrationLabel);
            this.panel1.Controls.Add(this.reminderPeriodForCalibrationComboBox);
            this.panel1.Controls.Add(verificationRequiredLabel);
            this.panel1.Controls.Add(dateOfVerificationLabel);
            this.panel1.Controls.Add(this.dateOfVerificationDateTimePicker);
            this.panel1.Controls.Add(dateVerificationDueLabel);
            this.panel1.Controls.Add(this.dateVerificationDueDateTimePicker);
            this.panel1.Controls.Add(verificationIntervalLabel);
            this.panel1.Controls.Add(this.verificationIntervalComboBox);
            this.panel1.Controls.Add(reminderPeriodForVerificationLabel);
            this.panel1.Controls.Add(this.reminderPeriodForVerificationComboBox);
            this.panel1.Controls.Add(pATTestRequiredLabel);
            this.panel1.Controls.Add(dateOfPATLabel);
            this.panel1.Controls.Add(this.dateOfPATDateTimePicker);
            this.panel1.Controls.Add(datePATDueLabel);
            this.panel1.Controls.Add(this.datePATDueDateTimePicker);
            this.panel1.Controls.Add(pATIntervalLabel);
            this.panel1.Controls.Add(this.pATIntervalComboBox);
            this.panel1.Controls.Add(reminderPeriodForPATLabel);
            this.panel1.Controls.Add(eHVAssetNoLabel);
            this.panel1.Controls.Add(this.eHVAssetNoTextBox);
            this.panel1.Controls.Add(equipmentManualLocationLabel);
            this.panel1.Controls.Add(this.equipmentManualLocationTextBox);
            this.panel1.Controls.Add(groupAllocationLabel);
            this.panel1.Controls.Add(this.groupAllocationComboBox);
            this.panel1.Controls.Add(custodianLabel);
            this.panel1.Controls.Add(this.custodianComboBox);
            this.panel1.Controls.Add(inUseLabel);
            this.panel1.Controls.Add(notesLabel);
            this.panel1.Controls.Add(this.notesTextBox);
            this.panel1.Location = new System.Drawing.Point(1267, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 940);
            this.panel1.TabIndex = 7;
            // 
            // btnPMTasks
            // 
            this.btnPMTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnPMTasks.FlatAppearance.BorderSize = 0;
            this.btnPMTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMTasks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPMTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnPMTasks.Location = new System.Drawing.Point(317, 286);
            this.btnPMTasks.Name = "btnPMTasks";
            this.btnPMTasks.Size = new System.Drawing.Size(135, 36);
            this.btnPMTasks.TabIndex = 260;
            this.btnPMTasks.Text = "PM Tasks";
            this.btnPMTasks.UseVisualStyleBackColor = false;
            this.btnPMTasks.Visible = false;
            this.btnPMTasks.Click += new System.EventHandler(this.btnPMTasks_Click);
            // 
            // stationComboBox
            // 
            this.stationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "Station", true));
            this.stationComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Location = new System.Drawing.Point(219, 102);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(233, 23);
            this.stationComboBox.Sorted = true;
            this.stationComboBox.TabIndex = 259;
            // 
            // tbl_assetregisterBindingSource
            // 
            this.tbl_assetregisterBindingSource.DataMember = "tbl_assetregister";
            this.tbl_assetregisterBindingSource.DataSource = this.eped_db1DataSet;
            // 
            // eped_db1DataSet
            // 
            this.eped_db1DataSet.DataSetName = "eped_db1DataSet";
            this.eped_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // multiplePMCheckBox
            // 
            this.multiplePMCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_assetregisterBindingSource, "MultiplePM", true));
            this.multiplePMCheckBox.Location = new System.Drawing.Point(219, 286);
            this.multiplePMCheckBox.Name = "multiplePMCheckBox";
            this.multiplePMCheckBox.Size = new System.Drawing.Size(29, 28);
            this.multiplePMCheckBox.TabIndex = 258;
            this.multiplePMCheckBox.UseVisualStyleBackColor = true;
            this.multiplePMCheckBox.CheckStateChanged += new System.EventHandler(this.multiplePMCheckBox_CheckStateChanged);
            // 
            // btnCertLocation
            // 
            this.btnCertLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnCertLocation.FlatAppearance.BorderSize = 0;
            this.btnCertLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnCertLocation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCertLocation.Location = new System.Drawing.Point(408, 443);
            this.btnCertLocation.Name = "btnCertLocation";
            this.btnCertLocation.Size = new System.Drawing.Size(44, 23);
            this.btnCertLocation.TabIndex = 256;
            this.btnCertLocation.Text = "\'\'\'";
            this.btnCertLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCertLocation.UseVisualStyleBackColor = false;
            this.btnCertLocation.Click += new System.EventHandler(this.btnCertLocation_Click);
            // 
            // btnManualLocation
            // 
            this.btnManualLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnManualLocation.FlatAppearance.BorderSize = 0;
            this.btnManualLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnManualLocation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManualLocation.Location = new System.Drawing.Point(408, 908);
            this.btnManualLocation.Name = "btnManualLocation";
            this.btnManualLocation.Size = new System.Drawing.Size(44, 23);
            this.btnManualLocation.TabIndex = 255;
            this.btnManualLocation.Text = "\'\'\'";
            this.btnManualLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManualLocation.UseVisualStyleBackColor = false;
            this.btnManualLocation.Click += new System.EventHandler(this.btnManualLocation_Click);
            this.btnManualLocation.MouseLeave += new System.EventHandler(this.btnManualLocation_MouseLeave);
            this.btnManualLocation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnManualLocation_MouseMove);
            // 
            // inUsecheckBox
            // 
            this.inUsecheckBox.AutoSize = true;
            this.inUsecheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_assetregisterBindingSource, "InUse", true));
            this.inUsecheckBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inUsecheckBox.Location = new System.Drawing.Point(219, 1005);
            this.inUsecheckBox.Name = "inUsecheckBox";
            this.inUsecheckBox.Size = new System.Drawing.Size(15, 14);
            this.inUsecheckBox.TabIndex = 72;
            this.inUsecheckBox.UseVisualStyleBackColor = true;
            // 
            // pATTestRequiredcheckBox
            // 
            this.pATTestRequiredcheckBox.AutoSize = true;
            this.pATTestRequiredcheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_assetregisterBindingSource, "PATTestRequired", true));
            this.pATTestRequiredcheckBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pATTestRequiredcheckBox.Location = new System.Drawing.Point(219, 720);
            this.pATTestRequiredcheckBox.Name = "pATTestRequiredcheckBox";
            this.pATTestRequiredcheckBox.Size = new System.Drawing.Size(15, 14);
            this.pATTestRequiredcheckBox.TabIndex = 71;
            this.pATTestRequiredcheckBox.UseVisualStyleBackColor = true;
            // 
            // verificationRequiredcheckBox
            // 
            this.verificationRequiredcheckBox.AutoSize = true;
            this.verificationRequiredcheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_assetregisterBindingSource, "VerificationRequired", true));
            this.verificationRequiredcheckBox.Location = new System.Drawing.Point(219, 569);
            this.verificationRequiredcheckBox.Name = "verificationRequiredcheckBox";
            this.verificationRequiredcheckBox.Size = new System.Drawing.Size(15, 14);
            this.verificationRequiredcheckBox.TabIndex = 70;
            this.verificationRequiredcheckBox.UseVisualStyleBackColor = true;
            // 
            // calibrationRequiredcheckBox
            // 
            this.calibrationRequiredcheckBox.AutoSize = true;
            this.calibrationRequiredcheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_assetregisterBindingSource, "CalibrationRequired", true));
            this.calibrationRequiredcheckBox.Location = new System.Drawing.Point(219, 320);
            this.calibrationRequiredcheckBox.Name = "calibrationRequiredcheckBox";
            this.calibrationRequiredcheckBox.Size = new System.Drawing.Size(15, 14);
            this.calibrationRequiredcheckBox.TabIndex = 69;
            this.calibrationRequiredcheckBox.UseVisualStyleBackColor = true;
            // 
            // reminderPeriodForPATComboBox
            // 
            this.reminderPeriodForPATComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "ReminderPeriodForPAT", true));
            this.reminderPeriodForPATComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderPeriodForPATComboBox.FormattingEnabled = true;
            this.reminderPeriodForPATComboBox.Location = new System.Drawing.Point(219, 845);
            this.reminderPeriodForPATComboBox.Name = "reminderPeriodForPATComboBox";
            this.reminderPeriodForPATComboBox.Size = new System.Drawing.Size(233, 23);
            this.reminderPeriodForPATComboBox.Sorted = true;
            this.reminderPeriodForPATComboBox.TabIndex = 68;
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "EquipmentID", true));
            this.equipmentIDTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentIDTextBox.Location = new System.Drawing.Point(219, 10);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.Size = new System.Drawing.Size(233, 23);
            this.equipmentIDTextBox.TabIndex = 1;
            this.equipmentIDTextBox.TextChanged += new System.EventHandler(this.equipmentIDTextBox_TextChanged);
            // 
            // siteNameComboBox
            // 
            this.siteNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "SiteName", true));
            this.siteNameComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteNameComboBox.FormattingEnabled = true;
            this.siteNameComboBox.Location = new System.Drawing.Point(219, 39);
            this.siteNameComboBox.Name = "siteNameComboBox";
            this.siteNameComboBox.Size = new System.Drawing.Size(233, 23);
            this.siteNameComboBox.Sorted = true;
            this.siteNameComboBox.TabIndex = 3;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "Location", true));
            this.locationComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(219, 70);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(233, 23);
            this.locationComboBox.TabIndex = 5;
            // 
            // equipmentDescriptionTextBox
            // 
            this.equipmentDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "EquipmentDescription", true));
            this.equipmentDescriptionTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentDescriptionTextBox.Location = new System.Drawing.Point(219, 133);
            this.equipmentDescriptionTextBox.Multiline = true;
            this.equipmentDescriptionTextBox.Name = "equipmentDescriptionTextBox";
            this.equipmentDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.equipmentDescriptionTextBox.Size = new System.Drawing.Size(233, 27);
            this.equipmentDescriptionTextBox.TabIndex = 7;
            // 
            // equipmentManufacturerComboBox
            // 
            this.equipmentManufacturerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "EquipmentManufacturer", true));
            this.equipmentManufacturerComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentManufacturerComboBox.FormattingEnabled = true;
            this.equipmentManufacturerComboBox.Location = new System.Drawing.Point(219, 165);
            this.equipmentManufacturerComboBox.Name = "equipmentManufacturerComboBox";
            this.equipmentManufacturerComboBox.Size = new System.Drawing.Size(233, 23);
            this.equipmentManufacturerComboBox.TabIndex = 9;
            // 
            // modelNoTextBox
            // 
            this.modelNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "ModelNo", true));
            this.modelNoTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelNoTextBox.Location = new System.Drawing.Point(219, 196);
            this.modelNoTextBox.Name = "modelNoTextBox";
            this.modelNoTextBox.Size = new System.Drawing.Size(233, 23);
            this.modelNoTextBox.TabIndex = 11;
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serialNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "SerialNo", true));
            this.serialNoTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoTextBox.Location = new System.Drawing.Point(219, 226);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(233, 23);
            this.serialNoTextBox.TabIndex = 13;
            // 
            // equipmentReceivedDateDateTimePicker
            // 
            this.equipmentReceivedDateDateTimePicker.CustomFormat = "";
            this.equipmentReceivedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetregisterBindingSource, "EquipmentReceivedDate", true));
            this.equipmentReceivedDateDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentReceivedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.equipmentReceivedDateDateTimePicker.Location = new System.Drawing.Point(286, 256);
            this.equipmentReceivedDateDateTimePicker.Name = "equipmentReceivedDateDateTimePicker";
            this.equipmentReceivedDateDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.equipmentReceivedDateDateTimePicker.TabIndex = 15;
            this.equipmentReceivedDateDateTimePicker.ValueChanged += new System.EventHandler(this.equipmentReceivedDateDateTimePicker_ValueChanged);
            // 
            // dateOfCalibrationDateTimePicker
            // 
            this.dateOfCalibrationDateTimePicker.CustomFormat = "";
            this.dateOfCalibrationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetregisterBindingSource, "DateOfCalibration", true));
            this.dateOfCalibrationDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfCalibrationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfCalibrationDateTimePicker.Location = new System.Drawing.Point(286, 346);
            this.dateOfCalibrationDateTimePicker.Name = "dateOfCalibrationDateTimePicker";
            this.dateOfCalibrationDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.dateOfCalibrationDateTimePicker.TabIndex = 19;
            this.dateOfCalibrationDateTimePicker.ValueChanged += new System.EventHandler(this.dateOfCalibrationDateTimePicker_ValueChanged);
            // 
            // dateCalibrationDueDateTimePicker
            // 
            this.dateCalibrationDueDateTimePicker.CustomFormat = "";
            this.dateCalibrationDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetregisterBindingSource, "DateCalibrationDue", true));
            this.dateCalibrationDueDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCalibrationDueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCalibrationDueDateTimePicker.Location = new System.Drawing.Point(286, 376);
            this.dateCalibrationDueDateTimePicker.Name = "dateCalibrationDueDateTimePicker";
            this.dateCalibrationDueDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.dateCalibrationDueDateTimePicker.TabIndex = 21;
            this.dateCalibrationDueDateTimePicker.ValueChanged += new System.EventHandler(this.dateCalibrationDueDateTimePicker_ValueChanged);
            // 
            // calibrationIntervalComboBox
            // 
            this.calibrationIntervalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "CalibrationInterval", true));
            this.calibrationIntervalComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrationIntervalComboBox.FormattingEnabled = true;
            this.calibrationIntervalComboBox.Location = new System.Drawing.Point(219, 406);
            this.calibrationIntervalComboBox.Name = "calibrationIntervalComboBox";
            this.calibrationIntervalComboBox.Size = new System.Drawing.Size(233, 23);
            this.calibrationIntervalComboBox.Sorted = true;
            this.calibrationIntervalComboBox.TabIndex = 23;
            // 
            // calibrationCertLocationTextBox
            // 
            this.calibrationCertLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibrationCertLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "CalibrationCertLocation", true));
            this.calibrationCertLocationTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrationCertLocationTextBox.Location = new System.Drawing.Point(219, 443);
            this.calibrationCertLocationTextBox.Name = "calibrationCertLocationTextBox";
            this.calibrationCertLocationTextBox.Size = new System.Drawing.Size(181, 23);
            this.calibrationCertLocationTextBox.TabIndex = 29;
            // 
            // calibrationTestHouseTextBox
            // 
            this.calibrationTestHouseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibrationTestHouseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "CalibrationTestHouse", true));
            this.calibrationTestHouseTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrationTestHouseTextBox.Location = new System.Drawing.Point(219, 473);
            this.calibrationTestHouseTextBox.Name = "calibrationTestHouseTextBox";
            this.calibrationTestHouseTextBox.Size = new System.Drawing.Size(233, 23);
            this.calibrationTestHouseTextBox.TabIndex = 31;
            // 
            // calibrationCostsTextBox
            // 
            this.calibrationCostsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibrationCostsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "CalibrationCosts", true));
            this.calibrationCostsTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrationCostsTextBox.Location = new System.Drawing.Point(334, 503);
            this.calibrationCostsTextBox.Name = "calibrationCostsTextBox";
            this.calibrationCostsTextBox.Size = new System.Drawing.Size(118, 23);
            this.calibrationCostsTextBox.TabIndex = 33;
            this.calibrationCostsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.calibrationCostsTextBox_Validating);
            // 
            // reminderPeriodForCalibrationComboBox
            // 
            this.reminderPeriodForCalibrationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "ReminderPeriodForCalibration", true));
            this.reminderPeriodForCalibrationComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderPeriodForCalibrationComboBox.FormattingEnabled = true;
            this.reminderPeriodForCalibrationComboBox.Location = new System.Drawing.Point(257, 533);
            this.reminderPeriodForCalibrationComboBox.Name = "reminderPeriodForCalibrationComboBox";
            this.reminderPeriodForCalibrationComboBox.Size = new System.Drawing.Size(195, 23);
            this.reminderPeriodForCalibrationComboBox.TabIndex = 35;
            // 
            // dateOfVerificationDateTimePicker
            // 
            this.dateOfVerificationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetregisterBindingSource, "DateOfVerification", true));
            this.dateOfVerificationDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfVerificationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfVerificationDateTimePicker.Location = new System.Drawing.Point(286, 594);
            this.dateOfVerificationDateTimePicker.Name = "dateOfVerificationDateTimePicker";
            this.dateOfVerificationDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.dateOfVerificationDateTimePicker.TabIndex = 39;
            this.dateOfVerificationDateTimePicker.ValueChanged += new System.EventHandler(this.dateOfVerificationDateTimePicker_ValueChanged);
            // 
            // dateVerificationDueDateTimePicker
            // 
            this.dateVerificationDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetregisterBindingSource, "DateVerificationDue", true));
            this.dateVerificationDueDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVerificationDueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVerificationDueDateTimePicker.Location = new System.Drawing.Point(286, 624);
            this.dateVerificationDueDateTimePicker.Name = "dateVerificationDueDateTimePicker";
            this.dateVerificationDueDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.dateVerificationDueDateTimePicker.TabIndex = 41;
            this.dateVerificationDueDateTimePicker.ValueChanged += new System.EventHandler(this.dateVerificationDueDateTimePicker_ValueChanged);
            // 
            // verificationIntervalComboBox
            // 
            this.verificationIntervalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "VerificationInterval", true));
            this.verificationIntervalComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificationIntervalComboBox.FormattingEnabled = true;
            this.verificationIntervalComboBox.Location = new System.Drawing.Point(219, 654);
            this.verificationIntervalComboBox.Name = "verificationIntervalComboBox";
            this.verificationIntervalComboBox.Size = new System.Drawing.Size(233, 23);
            this.verificationIntervalComboBox.Sorted = true;
            this.verificationIntervalComboBox.TabIndex = 43;
            // 
            // reminderPeriodForVerificationComboBox
            // 
            this.reminderPeriodForVerificationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "ReminderPeriodForVerification", true));
            this.reminderPeriodForVerificationComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderPeriodForVerificationComboBox.FormattingEnabled = true;
            this.reminderPeriodForVerificationComboBox.Location = new System.Drawing.Point(250, 686);
            this.reminderPeriodForVerificationComboBox.Name = "reminderPeriodForVerificationComboBox";
            this.reminderPeriodForVerificationComboBox.Size = new System.Drawing.Size(202, 23);
            this.reminderPeriodForVerificationComboBox.Sorted = true;
            this.reminderPeriodForVerificationComboBox.TabIndex = 45;
            // 
            // dateOfPATDateTimePicker
            // 
            this.dateOfPATDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetregisterBindingSource, "DateOfPAT", true));
            this.dateOfPATDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfPATDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfPATDateTimePicker.Location = new System.Drawing.Point(286, 747);
            this.dateOfPATDateTimePicker.Name = "dateOfPATDateTimePicker";
            this.dateOfPATDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.dateOfPATDateTimePicker.TabIndex = 49;
            this.dateOfPATDateTimePicker.ValueChanged += new System.EventHandler(this.dateOfPATDateTimePicker_ValueChanged);
            // 
            // datePATDueDateTimePicker
            // 
            this.datePATDueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_assetregisterBindingSource, "DatePATDue", true));
            this.datePATDueDateTimePicker.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePATDueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePATDueDateTimePicker.Location = new System.Drawing.Point(286, 777);
            this.datePATDueDateTimePicker.Name = "datePATDueDateTimePicker";
            this.datePATDueDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.datePATDueDateTimePicker.TabIndex = 51;
            this.datePATDueDateTimePicker.ValueChanged += new System.EventHandler(this.datePATDueDateTimePicker_ValueChanged);
            // 
            // pATIntervalComboBox
            // 
            this.pATIntervalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "PATInterval", true));
            this.pATIntervalComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pATIntervalComboBox.FormattingEnabled = true;
            this.pATIntervalComboBox.Location = new System.Drawing.Point(219, 814);
            this.pATIntervalComboBox.Name = "pATIntervalComboBox";
            this.pATIntervalComboBox.Size = new System.Drawing.Size(233, 23);
            this.pATIntervalComboBox.Sorted = true;
            this.pATIntervalComboBox.TabIndex = 53;
            // 
            // eHVAssetNoTextBox
            // 
            this.eHVAssetNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eHVAssetNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "EHVAssetNo", true));
            this.eHVAssetNoTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eHVAssetNoTextBox.Location = new System.Drawing.Point(219, 875);
            this.eHVAssetNoTextBox.Name = "eHVAssetNoTextBox";
            this.eHVAssetNoTextBox.Size = new System.Drawing.Size(233, 23);
            this.eHVAssetNoTextBox.TabIndex = 57;
            // 
            // equipmentManualLocationTextBox
            // 
            this.equipmentManualLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentManualLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "EquipmentManualLocation", true));
            this.equipmentManualLocationTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentManualLocationTextBox.Location = new System.Drawing.Point(234, 908);
            this.equipmentManualLocationTextBox.Name = "equipmentManualLocationTextBox";
            this.equipmentManualLocationTextBox.Size = new System.Drawing.Size(166, 23);
            this.equipmentManualLocationTextBox.TabIndex = 59;
            // 
            // groupAllocationComboBox
            // 
            this.groupAllocationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "GroupAllocation", true));
            this.groupAllocationComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAllocationComboBox.FormattingEnabled = true;
            this.groupAllocationComboBox.Location = new System.Drawing.Point(219, 938);
            this.groupAllocationComboBox.Name = "groupAllocationComboBox";
            this.groupAllocationComboBox.Size = new System.Drawing.Size(233, 23);
            this.groupAllocationComboBox.Sorted = true;
            this.groupAllocationComboBox.TabIndex = 61;
            // 
            // custodianComboBox
            // 
            this.custodianComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "Custodian", true));
            this.custodianComboBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custodianComboBox.FormattingEnabled = true;
            this.custodianComboBox.Location = new System.Drawing.Point(219, 969);
            this.custodianComboBox.Name = "custodianComboBox";
            this.custodianComboBox.Size = new System.Drawing.Size(233, 23);
            this.custodianComboBox.Sorted = true;
            this.custodianComboBox.TabIndex = 63;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_assetregisterBindingSource, "Notes", true));
            this.notesTextBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(219, 1056);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(233, 77);
            this.notesTextBox.TabIndex = 67;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnClose.Location = new System.Drawing.Point(1572, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSaveUpdates
            // 
            this.btnSaveUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnSaveUpdates.FlatAppearance.BorderSize = 0;
            this.btnSaveUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdates.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnSaveUpdates.Location = new System.Drawing.Point(1649, 6);
            this.btnSaveUpdates.Name = "btnSaveUpdates";
            this.btnSaveUpdates.Size = new System.Drawing.Size(79, 40);
            this.btnSaveUpdates.TabIndex = 9;
            this.btnSaveUpdates.Text = "SAVE UPDATES";
            this.btnSaveUpdates.UseVisualStyleBackColor = false;
            this.btnSaveUpdates.Click += new System.EventHandler(this.btnSaveUpdates_Click);
            // 
            // btnAddNewAsset
            // 
            this.btnAddNewAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnAddNewAsset.FlatAppearance.BorderSize = 0;
            this.btnAddNewAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAsset.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnAddNewAsset.Location = new System.Drawing.Point(1568, 6);
            this.btnAddNewAsset.Name = "btnAddNewAsset";
            this.btnAddNewAsset.Size = new System.Drawing.Size(75, 40);
            this.btnAddNewAsset.TabIndex = 10;
            this.btnAddNewAsset.Text = "ADD NEW ASSET";
            this.btnAddNewAsset.UseVisualStyleBackColor = false;
            this.btnAddNewAsset.Click += new System.EventHandler(this.btnAddNewAsset_Click);
            // 
            // cmbGroupAllocation
            // 
            this.cmbGroupAllocation.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupAllocation.FormattingEnabled = true;
            this.cmbGroupAllocation.Location = new System.Drawing.Point(651, 18);
            this.cmbGroupAllocation.Name = "cmbGroupAllocation";
            this.cmbGroupAllocation.Size = new System.Drawing.Size(101, 21);
            this.cmbGroupAllocation.TabIndex = 11;
            this.cmbGroupAllocation.SelectionChangeCommitted += new System.EventHandler(this.cmbGroupAllocation_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cmbByArea);
            this.panel2.Controls.Add(this.btnByArea);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.rbPAT);
            this.panel2.Controls.Add(this.rbVerify);
            this.panel2.Controls.Add(this.rbCalib);
            this.panel2.Controls.Add(this.rbAll);
            this.panel2.Controls.Add(this.btnShowAssetsDue);
            this.panel2.Controls.Add(this.txbSearchOn);
            this.panel2.Controls.Add(this.cmbGroupAllocation);
            this.panel2.Controls.Add(this.btnAddNewAsset);
            this.panel2.Controls.Add(this.btnSaveUpdates);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnShowByGroupAllcoation);
            this.panel2.Controls.Add(this.btnExportCSV);
            this.panel2.Controls.Add(this.btnSearchOn);
            this.panel2.Location = new System.Drawing.Point(7, 1090);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1745, 126);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOngoing);
            this.groupBox1.Controls.Add(this.lblIn);
            this.groupBox1.Controls.Add(this.lblOut);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(777, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 113);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LEGEND";
            // 
            // lblOngoing
            // 
            this.lblOngoing.AutoSize = true;
            this.lblOngoing.BackColor = System.Drawing.Color.Orange;
            this.lblOngoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOngoing.Location = new System.Drawing.Point(34, 52);
            this.lblOngoing.MinimumSize = new System.Drawing.Size(140, 14);
            this.lblOngoing.Name = "lblOngoing";
            this.lblOngoing.Size = new System.Drawing.Size(140, 17);
            this.lblOngoing.TabIndex = 17;
            this.lblOngoing.Text = "ONGOING";
            this.lblOngoing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.BackColor = System.Drawing.Color.Green;
            this.lblIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIn.Location = new System.Drawing.Point(34, 75);
            this.lblIn.MinimumSize = new System.Drawing.Size(140, 14);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(140, 17);
            this.lblIn.TabIndex = 16;
            this.lblIn.Text = "IN";
            this.lblIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.BackColor = System.Drawing.Color.Red;
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut.Location = new System.Drawing.Point(34, 29);
            this.lblOut.MinimumSize = new System.Drawing.Size(140, 14);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(140, 17);
            this.lblOut.TabIndex = 15;
            this.lblOut.Text = "OUT";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbByArea
            // 
            this.cmbByArea.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbByArea.FormattingEnabled = true;
            this.cmbByArea.Location = new System.Drawing.Point(652, 65);
            this.cmbByArea.Name = "cmbByArea";
            this.cmbByArea.Size = new System.Drawing.Size(100, 23);
            this.cmbByArea.TabIndex = 20;
            this.cmbByArea.Text = "ALL";
            this.cmbByArea.SelectionChangeCommitted += new System.EventHandler(this.cmbByArea_SelectionChangeCommitted);
            // 
            // btnByArea
            // 
            this.btnByArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnByArea.FlatAppearance.BorderSize = 0;
            this.btnByArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByArea.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnByArea.Location = new System.Drawing.Point(576, 65);
            this.btnByArea.Name = "btnByArea";
            this.btnByArea.Size = new System.Drawing.Size(70, 45);
            this.btnByArea.TabIndex = 19;
            this.btnByArea.Text = "BY AREA";
            this.btnByArea.UseVisualStyleBackColor = false;
            this.btnByArea.Click += new System.EventHandler(this.btnByArea_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnReset.Location = new System.Drawing.Point(484, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 45);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "RESET DISPLAY";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbPAT
            // 
            this.rbPAT.AutoSize = true;
            this.rbPAT.FlatAppearance.BorderSize = 0;
            this.rbPAT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbPAT.Location = new System.Drawing.Point(361, 89);
            this.rbPAT.Name = "rbPAT";
            this.rbPAT.Size = new System.Drawing.Size(104, 19);
            this.rbPAT.TabIndex = 17;
            this.rbPAT.Text = "PAT Equipment";
            this.rbPAT.UseVisualStyleBackColor = true;
            // 
            // rbVerify
            // 
            this.rbVerify.AutoSize = true;
            this.rbVerify.FlatAppearance.BorderSize = 0;
            this.rbVerify.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbVerify.Location = new System.Drawing.Point(361, 63);
            this.rbVerify.Name = "rbVerify";
            this.rbVerify.Size = new System.Drawing.Size(87, 19);
            this.rbVerify.TabIndex = 16;
            this.rbVerify.Text = "Verification";
            this.rbVerify.UseVisualStyleBackColor = true;
            // 
            // rbCalib
            // 
            this.rbCalib.AutoSize = true;
            this.rbCalib.FlatAppearance.BorderSize = 0;
            this.rbCalib.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCalib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbCalib.Location = new System.Drawing.Point(264, 91);
            this.rbCalib.Name = "rbCalib";
            this.rbCalib.Size = new System.Drawing.Size(87, 19);
            this.rbCalib.TabIndex = 15;
            this.rbCalib.Text = "Calibration";
            this.rbCalib.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.FlatAppearance.BorderSize = 0;
            this.rbAll.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbAll.Location = new System.Drawing.Point(264, 65);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(42, 19);
            this.rbAll.TabIndex = 14;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "ALL";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // btnShowAssetsDue
            // 
            this.btnShowAssetsDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnShowAssetsDue.FlatAppearance.BorderSize = 0;
            this.btnShowAssetsDue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAssetsDue.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAssetsDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnShowAssetsDue.Location = new System.Drawing.Point(264, 17);
            this.btnShowAssetsDue.Name = "btnShowAssetsDue";
            this.btnShowAssetsDue.Size = new System.Drawing.Size(195, 40);
            this.btnShowAssetsDue.TabIndex = 13;
            this.btnShowAssetsDue.Text = "SHOW ASSETS DUE:";
            this.btnShowAssetsDue.UseVisualStyleBackColor = false;
            this.btnShowAssetsDue.Click += new System.EventHandler(this.btnShowAssetsDue_Click);
            // 
            // txbSearchOn
            // 
            this.txbSearchOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchOn.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchOn.Location = new System.Drawing.Point(118, 25);
            this.txbSearchOn.Name = "txbSearchOn";
            this.txbSearchOn.Size = new System.Drawing.Size(118, 23);
            this.txbSearchOn.TabIndex = 12;
            this.txbSearchOn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearchOn_KeyPress);
            // 
            // tbl_assetregisterBindingNavigator
            // 
            this.tbl_assetregisterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_assetregisterBindingNavigator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbl_assetregisterBindingNavigator.BindingSource = this.tbl_assetregisterBindingSource;
            this.tbl_assetregisterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_assetregisterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_assetregisterBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_assetregisterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_assetregisterBindingNavigatorSaveItem});
            this.tbl_assetregisterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_assetregisterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_assetregisterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_assetregisterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_assetregisterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_assetregisterBindingNavigator.Name = "tbl_assetregisterBindingNavigator";
            this.tbl_assetregisterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_assetregisterBindingNavigator.Size = new System.Drawing.Size(1806, 27);
            this.tbl_assetregisterBindingNavigator.TabIndex = 15;
            this.tbl_assetregisterBindingNavigator.Text = "bindingNavigator1";
            this.tbl_assetregisterBindingNavigator.RefreshItems += new System.EventHandler(this.tbl_assetregisterBindingNavigator_RefreshItems);
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
            // tbl_assetregisterBindingNavigatorSaveItem
            // 
            this.tbl_assetregisterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_assetregisterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_assetregisterBindingNavigatorSaveItem.Image")));
            this.tbl_assetregisterBindingNavigatorSaveItem.Name = "tbl_assetregisterBindingNavigatorSaveItem";
            this.tbl_assetregisterBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_assetregisterBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_assetregisterBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_assetregisterBindingNavigatorSaveItem_Click);
            // 
            // tbl_assetregisterDataGridView
            // 
            this.tbl_assetregisterDataGridView.AllowUserToAddRows = false;
            this.tbl_assetregisterDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.tbl_assetregisterDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_assetregisterDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_assetregisterDataGridView.AutoGenerateColumns = false;
            this.tbl_assetregisterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tbl_assetregisterDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tbl_assetregisterDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tbl_assetregisterDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbl_assetregisterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_assetregisterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.Station,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.MultiplePM,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63});
            this.tbl_assetregisterDataGridView.DataSource = this.tbl_assetregisterBindingSource;
            this.tbl_assetregisterDataGridView.Location = new System.Drawing.Point(7, 51);
            this.tbl_assetregisterDataGridView.Name = "tbl_assetregisterDataGridView";
            this.tbl_assetregisterDataGridView.RowHeadersWidth = 51;
            this.tbl_assetregisterDataGridView.Size = new System.Drawing.Size(1191, 1033);
            this.tbl_assetregisterDataGridView.TabIndex = 15;
            this.tbl_assetregisterDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_AssetRegisterDataGridView_CellClick);
            this.tbl_assetregisterDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_assetregisterDataGridView_CellContentClick);
            this.tbl_assetregisterDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_assetregisterDataGridView_CellValueChanged);
            this.tbl_assetregisterDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_assetregisterDataGridView_ColumnHeaderMouseClick);
            this.tbl_assetregisterDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_assetregisterDataGridView_RowHeaderMouseDoubleClick);
            this.tbl_assetregisterDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbl_AssetRegisterDataGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "EquipmentID";
            this.dataGridViewTextBoxColumn30.Frozen = true;
            this.dataGridViewTextBoxColumn30.HeaderText = "EquipmentID";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 103;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "SiteName";
            this.dataGridViewTextBoxColumn31.HeaderText = "SiteName";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 86;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn32.HeaderText = "Location";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 78;
            // 
            // Station
            // 
            this.Station.DataPropertyName = "Station";
            this.Station.HeaderText = "Station";
            this.Station.MinimumWidth = 6;
            this.Station.Name = "Station";
            this.Station.Width = 71;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "EquipmentDescription";
            this.dataGridViewTextBoxColumn33.HeaderText = "EquipmentDescription";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 154;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "EquipmentManufacturer";
            this.dataGridViewTextBoxColumn34.HeaderText = "EquipmentManufacturer";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 167;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "ModelNo";
            this.dataGridViewTextBoxColumn35.HeaderText = "ModelNo";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 83;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "SerialNo";
            this.dataGridViewTextBoxColumn36.HeaderText = "SerialNo";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 78;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "EquipmentReceivedDate";
            this.dataGridViewTextBoxColumn37.HeaderText = "EquipmentReceivedDate";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 167;
            // 
            // MultiplePM
            // 
            this.MultiplePM.DataPropertyName = "MultiplePM";
            this.MultiplePM.HeaderText = "PreventativeMaintenanceRequired";
            this.MultiplePM.MinimumWidth = 6;
            this.MultiplePM.Name = "MultiplePM";
            this.MultiplePM.Width = 205;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "CalibrationRequired";
            this.dataGridViewTextBoxColumn38.HeaderText = "CalibrationRequired";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn38.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn38.Width = 141;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "DateOfCalibration";
            this.dataGridViewTextBoxColumn39.HeaderText = "DateOfCalibration";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Width = 130;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "DateCalibrationDue";
            this.dataGridViewTextBoxColumn40.HeaderText = "DateCalibrationDue";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Width = 139;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "CalibrationInterval";
            this.dataGridViewTextBoxColumn41.HeaderText = "CalibrationInterval";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.Width = 133;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "CalibrationStatus";
            this.dataGridViewTextBoxColumn42.HeaderText = "CalibrationStatus";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.Width = 125;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "CalibrationLableAttached";
            this.dataGridViewTextBoxColumn43.HeaderText = "CalibrationLableAttached";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn43.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn43.Width = 169;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "CalibrationCertLocation";
            this.dataGridViewTextBoxColumn44.HeaderText = "CalibrationCertLocation";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.Width = 161;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "CalibrationTestHouse";
            this.dataGridViewTextBoxColumn45.HeaderText = "CalibrationTestHouse";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.Width = 147;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "CalibrationCosts";
            this.dataGridViewTextBoxColumn46.HeaderText = "CalibrationCosts";
            this.dataGridViewTextBoxColumn46.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.Width = 120;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "ReminderPeriodForCalibration";
            this.dataGridViewTextBoxColumn47.HeaderText = "ReminderPeriodForCalibration";
            this.dataGridViewTextBoxColumn47.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.Width = 199;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "VerificationRequired";
            this.dataGridViewTextBoxColumn48.HeaderText = "VerificationRequired";
            this.dataGridViewTextBoxColumn48.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn48.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn48.Width = 144;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "DateOfVerification";
            this.dataGridViewTextBoxColumn49.HeaderText = "DateOfVerification";
            this.dataGridViewTextBoxColumn49.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.Width = 133;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "DateVerificationDue";
            this.dataGridViewTextBoxColumn50.HeaderText = "DateVerificationDue";
            this.dataGridViewTextBoxColumn50.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.Width = 142;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "VerificationInterval";
            this.dataGridViewTextBoxColumn51.HeaderText = "VerificationInterval";
            this.dataGridViewTextBoxColumn51.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.Width = 136;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "ReminderPeriodForVerification";
            this.dataGridViewTextBoxColumn52.HeaderText = "ReminderPeriodForVerification";
            this.dataGridViewTextBoxColumn52.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.Width = 202;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "PATTestRequired";
            this.dataGridViewTextBoxColumn53.HeaderText = "PATTestRequired";
            this.dataGridViewTextBoxColumn53.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn53.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn53.Width = 123;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "DateOfPAT";
            this.dataGridViewTextBoxColumn54.HeaderText = "DateOfPAT";
            this.dataGridViewTextBoxColumn54.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.Width = 90;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "DatePATDue";
            this.dataGridViewTextBoxColumn55.HeaderText = "DatePATDue";
            this.dataGridViewTextBoxColumn55.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.Width = 99;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "PATInterval";
            this.dataGridViewTextBoxColumn56.HeaderText = "PATInterval";
            this.dataGridViewTextBoxColumn56.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.Width = 93;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "ReminderPeriodForPAT";
            this.dataGridViewTextBoxColumn57.HeaderText = "ReminderPeriodForPAT";
            this.dataGridViewTextBoxColumn57.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.Width = 159;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "EHVAssetNo";
            this.dataGridViewTextBoxColumn58.HeaderText = "EHVAssetNo";
            this.dataGridViewTextBoxColumn58.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.Width = 99;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "EquipmentManualLocation";
            this.dataGridViewTextBoxColumn59.HeaderText = "EquipmentManualLocation";
            this.dataGridViewTextBoxColumn59.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.Width = 178;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "GroupAllocation";
            this.dataGridViewTextBoxColumn60.HeaderText = "GroupAllocation";
            this.dataGridViewTextBoxColumn60.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.Width = 120;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "Custodian";
            this.dataGridViewTextBoxColumn61.HeaderText = "Custodian";
            this.dataGridViewTextBoxColumn61.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.Width = 86;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "InUse";
            this.dataGridViewTextBoxColumn62.HeaderText = "InUse";
            this.dataGridViewTextBoxColumn62.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn62.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn62.Width = 62;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn63.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn63.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.Width = 65;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbSetGroupAllocation);
            this.panel3.Controls.Add(this.cmbTechnician);
            this.panel3.Controls.Add(this.rbRowsToGroupAllocation);
            this.panel3.Controls.Add(this.rbRowsToWorkOrder);
            this.panel3.Location = new System.Drawing.Point(1266, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 57);
            this.panel3.TabIndex = 16;
            // 
            // cmbSetGroupAllocation
            // 
            this.cmbSetGroupAllocation.FormattingEnabled = true;
            this.cmbSetGroupAllocation.Location = new System.Drawing.Point(311, 29);
            this.cmbSetGroupAllocation.Name = "cmbSetGroupAllocation";
            this.cmbSetGroupAllocation.Size = new System.Drawing.Size(163, 23);
            this.cmbSetGroupAllocation.TabIndex = 3;
            this.cmbSetGroupAllocation.Visible = false;
            this.cmbSetGroupAllocation.SelectionChangeCommitted += new System.EventHandler(this.cmbSetGroupAllocation_SelectionChangeCommitted);
            this.cmbSetGroupAllocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSetGroupAllocation_KeyPress);
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(311, 2);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(163, 23);
            this.cmbTechnician.TabIndex = 2;
            this.cmbTechnician.Visible = false;
            this.cmbTechnician.SelectionChangeCommitted += new System.EventHandler(this.cmbTechnician_SelectionChangeCommitted);
            // 
            // rbRowsToGroupAllocation
            // 
            this.rbRowsToGroupAllocation.AutoSize = true;
            this.rbRowsToGroupAllocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRowsToGroupAllocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbRowsToGroupAllocation.Location = new System.Drawing.Point(12, 30);
            this.rbRowsToGroupAllocation.Name = "rbRowsToGroupAllocation";
            this.rbRowsToGroupAllocation.Size = new System.Drawing.Size(220, 19);
            this.rbRowsToGroupAllocation.TabIndex = 1;
            this.rbRowsToGroupAllocation.Text = "Selected Rows for Group Allocation:";
            this.rbRowsToGroupAllocation.UseVisualStyleBackColor = true;
            // 
            // rbRowsToWorkOrder
            // 
            this.rbRowsToWorkOrder.AutoSize = true;
            this.rbRowsToWorkOrder.Checked = true;
            this.rbRowsToWorkOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRowsToWorkOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbRowsToWorkOrder.Location = new System.Drawing.Point(12, 3);
            this.rbRowsToWorkOrder.Name = "rbRowsToWorkOrder";
            this.rbRowsToWorkOrder.Size = new System.Drawing.Size(194, 19);
            this.rbRowsToWorkOrder.TabIndex = 0;
            this.rbRowsToWorkOrder.TabStop = true;
            this.rbRowsToWorkOrder.Text = "Selected Rows for Work Order :";
            this.rbRowsToWorkOrder.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tbl_assetregisterTableAdapter
            // 
            this.tbl_assetregisterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_assetlogsTableAdapter = null;
            this.tableAdapterManager.tbl_assetregisterTableAdapter = this.tbl_assetregisterTableAdapter;
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
            // ShowAssetListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1806, 1224);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbl_assetregisterDataGridView);
            this.Controls.Add(this.tbl_assetregisterBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ShowAssetListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AssetListFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.AssetListFrm_Activated);
            this.Load += new System.EventHandler(this.AssetListFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetregisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eped_db1DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetregisterBindingNavigator)).EndInit();
            this.tbl_assetregisterBindingNavigator.ResumeLayout(false);
            this.tbl_assetregisterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_assetregisterDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchOn;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnShowByGroupAllcoation;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveUpdates;
        private System.Windows.Forms.Button btnAddNewAsset;
        private System.Windows.Forms.ComboBox cmbGroupAllocation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSearchOn;
        private System.Windows.Forms.RadioButton rbVerify;
        private System.Windows.Forms.RadioButton rbCalib;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnShowAssetsDue;
        private eped_db1DataSet eped_db1DataSet;
        private System.Windows.Forms.BindingSource tbl_assetregisterBindingSource;
        private eped_db1DataSetTableAdapters.tbl_assetregisterTableAdapter tbl_assetregisterTableAdapter;
        private eped_db1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_assetregisterBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_assetregisterBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbl_assetregisterDataGridView;
        private System.Windows.Forms.TextBox equipmentIDTextBox;
        private System.Windows.Forms.ComboBox siteNameComboBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.TextBox equipmentDescriptionTextBox;
        private System.Windows.Forms.ComboBox equipmentManufacturerComboBox;
        private System.Windows.Forms.TextBox modelNoTextBox;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.DateTimePicker equipmentReceivedDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfCalibrationDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateCalibrationDueDateTimePicker;
        private System.Windows.Forms.ComboBox calibrationIntervalComboBox;
        private System.Windows.Forms.TextBox calibrationCertLocationTextBox;
        private System.Windows.Forms.TextBox calibrationTestHouseTextBox;
        private System.Windows.Forms.TextBox calibrationCostsTextBox;
        private System.Windows.Forms.ComboBox reminderPeriodForCalibrationComboBox;
        private System.Windows.Forms.DateTimePicker dateOfVerificationDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateVerificationDueDateTimePicker;
        private System.Windows.Forms.ComboBox verificationIntervalComboBox;
        private System.Windows.Forms.ComboBox reminderPeriodForVerificationComboBox;
        private System.Windows.Forms.DateTimePicker dateOfPATDateTimePicker;
        private System.Windows.Forms.DateTimePicker datePATDueDateTimePicker;
        private System.Windows.Forms.ComboBox pATIntervalComboBox;
        private System.Windows.Forms.TextBox eHVAssetNoTextBox;
        private System.Windows.Forms.TextBox equipmentManualLocationTextBox;
        private System.Windows.Forms.ComboBox groupAllocationComboBox;
        private System.Windows.Forms.ComboBox custodianComboBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ComboBox reminderPeriodForPATComboBox;
        private System.Windows.Forms.CheckBox inUsecheckBox;
        private System.Windows.Forms.CheckBox pATTestRequiredcheckBox;
        private System.Windows.Forms.CheckBox verificationRequiredcheckBox;
        private System.Windows.Forms.CheckBox calibrationRequiredcheckBox;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbByArea;
        private System.Windows.Forms.Button btnByArea;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbSetGroupAllocation;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.RadioButton rbRowsToGroupAllocation;
        private System.Windows.Forms.RadioButton rbRowsToWorkOrder;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.RadioButton rbPAT;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnCertLocation;
        private System.Windows.Forms.Button btnManualLocation;
        private System.Windows.Forms.CheckBox multiplePMCheckBox;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MultiplePM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.Button btnPMTasks;
        internal System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label lblOngoing;
        internal System.Windows.Forms.Label lblIn;
    }
}