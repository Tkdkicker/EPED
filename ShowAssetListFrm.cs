using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EPED
{
    public partial class ShowAssetListFrm : Form
    {
        // api declaration to tunr off screen udpates for DGV  to speed this up
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;
        public string ShowScreen { get; set; }
        bool showDueCols = false;
      

        // print globals
        private static StringFormat strFormat;
        private static List<int> colsPrint = new List<int>();
        private static List<int> arrColumnLefts = new List<int>();
        private static List<int> arrColumnWidths = new List<int>();
        private static int iCellHeight;
        private static int iRow = 0;
        private static bool bFirstPage = true;
        private static bool bNewPage = false;
        private static int iTotalWidth;
        private static int iHeaderHeight;
        private int pageCount = 1;

        string SearchOnName = "EquipmentID";

        public ShowAssetListFrm()
        {
            InitializeComponent();
            
        }

        DataSet ds = new DataSet();

        private void ShowSelection()
        {
            if (ShowScreen == "CalibDueShow")
            {
                rbCalib.Checked = true;
                showDueCols = true;
                lblOngoing.Text = "Due within 4 weeks";
                lblIn.Visible = true;
                lblOut.Visible = true;
                lblOngoing.Visible = true;
                equipmentReceivedDateDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                dateOfCalibrationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                dateOfVerificationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                dateVerificationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                dateOfPATDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                datePATDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            }
            if (ShowScreen == "VerifyDueShow")
            {
                rbVerify.Checked = true;
                showDueCols = true;
                lblOngoing.Text = "Due within 4 weeks";
                lblIn.Visible = true;
                lblOut.Visible = true;
                lblOngoing.Visible = true;
                equipmentReceivedDateDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                dateOfCalibrationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                dateOfVerificationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                dateVerificationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                dateOfPATDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                datePATDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            }

            if (ShowScreen == "PatDueShow")
            {
                rbPAT.Checked = true;
                showDueCols = true;
                groupBox1.Visible = false;
                lblIn.Visible = false;
                lblOut.Visible = false;
                lblOngoing.Visible = false;
                equipmentReceivedDateDateTimePicker.CustomFormat = " ";

                dateOfCalibrationDateTimePicker.CustomFormat = " ";
                dateCalibrationDueDateTimePicker.CustomFormat = " ";

                dateOfVerificationDateTimePicker.CustomFormat = " ";
                dateVerificationDueDateTimePicker.CustomFormat = " ";

                dateOfPATDateTimePicker.CustomFormat = " ";
                datePATDueDateTimePicker.CustomFormat = " ";
            }
        }
        private void AssetListFrm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;
        }

       



        private void AssetListFrm_Load(object sender, EventArgs e)
        {
           

            Cursor.Current = Cursors.WaitCursor;
            BackColor = Globals.defaultformsbgCol;
            ViewByUserLevel();

            // takes a long time
            RefreshDataGridView();

            // turn off redrawing method for grid to improve speed.
            SendMessage(tbl_assetregisterDataGridView.Handle, WM_SETREDRAW, false, 0);


            this.tbl_assetregisterDataGridView.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            UpdateComBoxes();
            ShowSelection();
            // had to do this twice due to issues with site 
            if (showDueCols) { SelectEquipmentDueForService(); }
            if (showDueCols) { SelectEquipmentDueForService(); }
            Cursor.Current = Cursors.Default;


            // turn on redrawing method 
            SendMessage(tbl_assetregisterDataGridView.Handle, WM_SETREDRAW, true, 0);
        }


        private void  RefreshDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;


            string siteName = Properties.Settings.Default.DefaultSiteName;
            if (siteName == "ALL")
            {
                tbl_assetregisterTableAdapter.Fill(this.eped_db1DataSet.tbl_assetregister);
            }
            else
            {
                tbl_assetregisterTableAdapter.FillBySiteName(this.eped_db1DataSet.tbl_assetregister, siteName);
            }

            Cursor.Current = Cursors.Default;

        }




        private void ViewByUserLevel()
        {
            switch (Globals.AccessLevel)
            {

                case 1:
                    // full admin rights
                    tbl_assetregisterBindingNavigator.Visible = true;
                    btnAddNewAsset.Enabled = true;
                    btnSaveUpdates.Enabled = true;
                    panel3.Enabled = true;
                    break;
                case 2:
                    // most read and right not all though
                    tbl_assetregisterBindingNavigatorSaveItem.Visible = false;
                    bindingNavigatorAddNewItem.Visible = false;
                    bindingNavigatorDeleteItem.Visible = false;
                    btnAddNewAsset.Enabled = true;
                    btnSaveUpdates.Enabled = true;
                    panel3.Enabled = true;
                    break;
                case 3:
                    // part restrictive
                    tbl_assetregisterBindingNavigatorSaveItem.Visible = false;
                    bindingNavigatorAddNewItem.Visible = false;
                    bindingNavigatorDeleteItem.Visible = false;
                    btnAddNewAsset.Enabled = false;
                    btnSaveUpdates.Enabled = false;
                    panel3.Enabled = false;
                    break;
                case 4:
                    // guest rights only to view
                    tbl_assetregisterBindingNavigatorSaveItem.Visible = false;
                    bindingNavigatorAddNewItem.Visible = false;
                    bindingNavigatorDeleteItem.Visible = false;
                    btnAddNewAsset.Enabled = false;
                    btnSaveUpdates.Enabled = false;
                    panel3.Enabled = false;
                    break;
                default:
                    // guest rights only to view.
                    tbl_assetregisterBindingNavigator.Visible = false;
                    btnAddNewAsset.Enabled = false;
                    btnSaveUpdates.Enabled = false;
                    panel3.Enabled = false;
                    break;
            }
            if (Globals.DefUser != "Admin") { tbl_assetregisterBindingNavigator.Enabled = false; }
        }
        private void UpdateComBoxes()
        {
            List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "SiteName");
            valuelist.Sort();
            siteNameComboBox.Items.Clear();
            siteNameComboBox.Items.AddRange(valuelist.ToArray());
            cmbByArea.Items.Clear();
            cmbByArea.Items.Add("ALL");
            cmbByArea.Items.AddRange(valuelist.ToArray());
            cmbByArea.Text = Properties.Settings.Default.DefaultSiteName;

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "Location");
            valuelist.Sort();
            locationComboBox.Items.Clear();
            locationComboBox.Items.AddRange(valuelist.ToArray());
            

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "Station");
            valuelist.Sort();
            stationComboBox.Items.Clear();
            stationComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "EquipmentManufacturer");
            valuelist.Sort();
            equipmentManufacturerComboBox.Items.Clear();
            equipmentManufacturerComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "CalibrationInterval");
            valuelist.Sort();
            calibrationIntervalComboBox.Items.Clear();
            calibrationIntervalComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "ReminderPeriodForCalibration");
            valuelist.Sort();
            reminderPeriodForCalibrationComboBox.Items.Clear();
            reminderPeriodForCalibrationComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "VerificationInterval");
            valuelist.Sort();
            verificationIntervalComboBox.Items.Clear();
            verificationIntervalComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "ReminderPeriodForVerification");
            valuelist.Sort();
            reminderPeriodForVerificationComboBox.Items.Clear();
            reminderPeriodForVerificationComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "PATInterval");
            valuelist.Sort();
            pATIntervalComboBox.Items.Clear();
            pATIntervalComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "ReminderPeriodForPAT");
            valuelist.Sort();
            reminderPeriodForPATComboBox.Items.Clear();
            reminderPeriodForPATComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "GroupAllocation");
            valuelist.Sort();
            groupAllocationComboBox.Items.Clear();
            groupAllocationComboBox.Items.AddRange(valuelist.ToArray());
            cmbGroupAllocation.Items.Clear();
            cmbGroupAllocation.Items.AddRange(valuelist.ToArray());
            cmbSetGroupAllocation.Items.Clear();
            cmbSetGroupAllocation.Items.Add("CLEAR ALLOCATION");
            cmbSetGroupAllocation.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "Custodian");
            valuelist.Sort();
            custodianComboBox.Items.Clear();
            custodianComboBox.Items.AddRange(valuelist.ToArray());
            // list of users technicians
            valuelist = DBUtils.FetchListOfUsers(dbCon, "tbl_users");
            cmbTechnician.Items.Clear();
            cmbTechnician.Items.AddRange(valuelist.ToArray());

        }

        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " -Asset Register - " + "Version (" + Globals.CurrVersion + ")   Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }

        private void tbl_AssetRegisterDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                btnSearchOn.Text = "SEARCH ON " + tbl_assetregisterDataGridView.Columns[e.ColumnIndex].HeaderText;
                SearchOnName = tbl_assetregisterDataGridView.Columns[e.ColumnIndex].DataPropertyName;
                Cursor.Current = Cursors.Default;

               


            }

        }

        private void tbl_AssetRegisterDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel3.Enabled)
            {


                if (e.Button == (MouseButtons.Right) & (tbl_assetregisterDataGridView.SelectedRows.Count > 0))
                {


                    // display option to allocated selected to a group allocation type or to allocate as work order

                    if (rbRowsToWorkOrder.Checked)
                    {
                        cmbTechnician.Visible = true;
                        DialogResult result = MessageBox.Show("Select Technician to allocate work to:", "Scheduled WORK", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            cmbTechnician.Visible = true;
                            cmbTechnician.Focus();
                        }
                        else { cmbTechnician.Visible = false; }
                    }

                    if (rbRowsToGroupAllocation.Checked)
                    {
                        DialogResult result = MessageBox.Show("Select Existing Group allocation \n or write anew one:", "Scheduled WORK", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.OK)
                        {
                            cmbSetGroupAllocation.Visible = true;
                            cmbSetGroupAllocation.Focus();
                        }
                        else { cmbSetGroupAllocation.Visible = false; }
                    }
                }

                else
                {
                    if(tbl_assetregisterDataGridView.SelectedCells.Count != 0)
                    {
                        if ((e.Button == (MouseButtons.Right)) &
                        (tbl_assetregisterDataGridView.Columns[tbl_assetregisterDataGridView.SelectedCells[0].ColumnIndex].HeaderText == "PreventativeMaintenanceRequired") &
                        (Globals.AccessLevel == 1) & (tbl_assetregisterDataGridView.SelectedCells[0].Value.ToString() == "True"))
                        {
                            DisplayAdminPMDialog();
                        }
                    }
                    

                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Globals.AccessLevel==4) { Globals.ChangesMade = false;}
            if (Globals.ChangesMade == true)
            {
                DialogResult result = MessageBox.Show("New details added/changed but not saved to database, click OK to ignore changes", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.OK)
                {
                    Globals.ChangesMade = false;
                    Close();
                }
                else if(result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "SelectFrm")
                {
                    f.Activate();
                    break;
                }
            }

        }


        private void tbl_assetregisterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tbl_assetregisterBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.eped_db1DataSet);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchOnFilter()
        {

            Cursor.Current = Cursors.WaitCursor;

            string sqlQuery = "SELECT * FROM tbl_assetregister;";

            string siteName = cmbByArea.Text;
            string groupAlloc = cmbGroupAllocation.Text;
            string searchFor = txbSearchOn.Text;

            if ((groupAlloc == "") && (siteName != "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_assetregister WHERE SiteName LIKE '" + siteName + "';"; }
            if ((groupAlloc != "") && (siteName != "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_assetregister WHERE SiteName LIKE '" + siteName + "' AND GroupAllocation LIKE '%" + groupAlloc + "%';"; }
            if ((groupAlloc == "") && (siteName != "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_assetregister WHERE SiteName LIKE '" + siteName + "' AND (" + SearchOnName + " LIKE '%" + searchFor + "%'" + " OR  Location  LIKE '%" + searchFor + "%'" + " OR  SiteName  LIKE '%" + searchFor + "%'" + " OR  EquipmentDescription  LIKE '%" + searchFor + "%'" + " OR  EquipmentManufacturer  LIKE '%" + searchFor + "%'" + " OR  Station  LIKE '%" + searchFor + "%')" + ";"; }
            if ((groupAlloc != "") && (siteName != "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_assetregister WHERE SiteName LIKE '" + siteName + "' AND (" + SearchOnName + " LIKE '%" + searchFor + "%'"+" OR  Location  LIKE '%" + searchFor + "%'" + " OR  SiteName  LIKE '%" + searchFor + "%'" + " OR  EquipmentDescription  LIKE '%" + searchFor + "%'" + " OR  EquipmentManufacturer  LIKE '%" + searchFor + "%'" + " OR  Station  LIKE '%" + searchFor + "%')" + " AND GroupAllocation LIKE '%" + groupAlloc + "%';"; }
            if ((groupAlloc == "") && (siteName == "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_assetregister ;"; }
            if ((groupAlloc != "") && (siteName == "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_assetregister WHERE GroupAllocation LIKE '%" + groupAlloc + "%';"; }
            if ((groupAlloc == "") && (siteName == "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_assetregister WHERE " + SearchOnName + " LIKE '%" + searchFor + "%'" + " OR  Location  LIKE '%" + searchFor + "%'" + " OR  SiteName  LIKE '%" + searchFor + "%'" + " OR  EquipmentDescription  LIKE '%" + searchFor + "%'" + " OR  EquipmentManufacturer  LIKE '%" + searchFor + "%'" + " OR  Station  LIKE '%" + searchFor + "%'" + ";"; }
            if ((groupAlloc != "") && (siteName == "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_assetregister WHERE " + SearchOnName + " LIKE '%" + searchFor + "%' AND GroupAllocation = '%" + groupAlloc + "%';"; }

            try
            {
                tbl_assetregisterTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
                tbl_assetregisterTableAdapter.ClearBeforeFill = true;
                tbl_assetregisterTableAdapter.Fill(eped_db1DataSet.tbl_assetregister);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }


        private void SearchOn_button_Click(object sender, EventArgs e)
        {
            SearchOnFilter();
        }

        private void txbSearchOn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchOnFilter();
            }
        }


        private void btnShowByGroupAllcoation_Click(object sender, EventArgs e)
        {
            if (cmbGroupAllocation.Text == "CLEAR ALLOCATION") { cmbGroupAllocation.Text = ""; }
            SearchOnFilter();
        }


        private void UpdateEquipmentDataGridViewDueRowCol()
        {
            // colour the grid rows according to duedate
            DateTime dueDate, dateNow, recordDate;
            int reminderInWeeks, rwIndex = 0, dnIndex = 0;

            dateNow = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (rbAll.Checked | rbCalib.Checked)
                {
                    dnIndex = tbl_assetregisterDataGridView.IndexByName("DateCalibrationDue");
                    rwIndex = tbl_assetregisterDataGridView.IndexByName("ReminderPeriodForCalibration");
                }
                if (rbVerify.Checked)
                {
                    dnIndex = tbl_assetregisterDataGridView.IndexByName("DateVerificationDue");
                    rwIndex = tbl_assetregisterDataGridView.IndexByName("ReminderPeriodForVerification");
                }
                if (rbPAT.Checked)
                {
                    dnIndex = tbl_assetregisterDataGridView.IndexByName("DatePATDue");
                    rwIndex = tbl_assetregisterDataGridView.IndexByName("ReminderPeriodForPAT");
                }

                for (int i = 0; i < tbl_assetregisterDataGridView.RowCount; i++)
                {
                    if (Convert.IsDBNull(tbl_assetregisterDataGridView.Rows[i].Cells[rwIndex].Value))
                    {
                        reminderInWeeks = 0;
                    }
                    else
                    {
                        reminderInWeeks = Utils.ConvertToWeeks(tbl_assetregisterDataGridView.Rows[i].Cells[rwIndex].Value.ToString());
                    }

                    dueDate = dateNow.AddDays(reminderInWeeks * 7);
                    if (Convert.IsDBNull(tbl_assetregisterDataGridView.Rows[i].Cells[dnIndex].Value))
                    {
                        recordDate = dateNow;
                    }
                    else
                    {
                        recordDate = Convert.ToDateTime(tbl_assetregisterDataGridView.Rows[i].Cells[dnIndex].Value.ToString());
                    }
                 

                    if ((dateNow < recordDate) && (recordDate <= dueDate))
                    {
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    else if (dateNow >= recordDate)
                    {
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (dateNow < recordDate)
                    {
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        tbl_assetregisterDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }


        private void SelectEquipmentDueForService()
        {
            string siteName = cmbByArea.Text;
            DateTime dueDate = DateTime.Now;
            int colindex = 0;
            txbSearchOn.Text = "";
            cmbSetGroupAllocation.Text = "";

            string sqlQuery = "SELECT * FROM tbl_assetregister;";
            // clear seach filter for this 
            txbSearchOn.Text = "";
            // look at items coming up to 30 days for calibration
            dueDate = dueDate.AddDays(30);
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                if (rbAll.Checked)
                {
                    if (siteName == "ALL")
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE ((CalibrationRequired = '1') OR (VerificationRequired = '1') OR (PATTestRequired = '1'));";
                    }
                    else
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE (SiteName = '" + siteName + "') AND ((CalibrationRequired = '1') OR (VerificationRequired = '1') OR (PATTestRequired = '1'));";
                    }
                    colindex = tbl_assetregisterDataGridView.IndexByName("DateCalibrationDue");
                    lblOngoing.Text = "ONGOING";
                    groupBox1.Visible = true;
                    lblOngoing.Visible = true;
                    lblIn.Visible = true;
                    lblOut.Visible = true;
                    equipmentReceivedDateDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfCalibrationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfVerificationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    dateVerificationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfPATDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    datePATDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                }
                if (rbCalib.Checked)
                {
                    if (siteName == "ALL")
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE ((CalibrationRequired = '1'));";// AND (DateCalibrationDue <= " + dueDate.ToString() + "));";
                    }
                    else
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE (SiteName LIKE '" + siteName + "') AND (CalibrationRequired = '1');";// AND (DateCalibrationDue <= " + dueDate.ToString() + "));";
                    }
                    colindex = tbl_assetregisterDataGridView.IndexByName("DateCalibrationDue");
                    groupBox1.Visible = true;
                    lblOngoing.Visible = true;
                    lblIn.Visible = true;
                    lblOut.Visible = true;
                    equipmentReceivedDateDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfCalibrationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfVerificationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    dateVerificationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfPATDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    datePATDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                }
                if (rbVerify.Checked)
                {
                    if (siteName == "ALL")
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE ((VerificationRequired = '1'));";// AND (DateVerificationDue <= " + dueDate.ToString() + ") );";
                    }
                    else
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE (SiteName = '" + siteName + "') AND ((VerificationRequired = '1'));";// AND (DateVerificationDue <= " + dueDate.ToString() + ") );";
                    }
                    colindex = tbl_assetregisterDataGridView.IndexByName("DateVerificationDue");
                    groupBox1.Visible = true;
                    lblOngoing.Visible = true;
                    lblIn.Visible = true;
                    lblOut.Visible = true;
                    equipmentReceivedDateDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfCalibrationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfVerificationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    dateVerificationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";

                    dateOfPATDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                    datePATDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
                }

                if (rbPAT.Checked)
                {
                    if (siteName == "ALL")
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE ((PATTestRequired = '1'));";// AND (DatePATDue <= " + dueDate.ToString() + ") );";
                    }
                    else
                    {
                        sqlQuery = "SELECT * FROM tbl_assetregister WHERE (SiteName = '" + siteName + "') AND ((PATTestRequired = '1'));";// AND (DatePATDue <= " + dueDate.ToString() + ") );";
                    }
                    colindex = tbl_assetregisterDataGridView.IndexByName("DatePATDue");
                    groupBox1.Visible = false;
                    lblIn.Visible = false;
                    lblOut.Visible = false;
                    lblOngoing.Visible = false;
                    equipmentReceivedDateDateTimePicker.CustomFormat = " ";

                    dateOfCalibrationDateTimePicker.CustomFormat = " ";
                    dateCalibrationDueDateTimePicker.CustomFormat = " ";

                    dateOfVerificationDateTimePicker.CustomFormat = " ";
                    dateVerificationDueDateTimePicker.CustomFormat = " ";

                    dateOfPATDateTimePicker.CustomFormat = " ";
                    datePATDueDateTimePicker.CustomFormat = " ";
                }


                tbl_assetregisterTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
                tbl_assetregisterTableAdapter.ClearBeforeFill = true;
                tbl_assetregisterTableAdapter.Fill(eped_db1DataSet.tbl_assetregister);
                tbl_assetregisterDataGridView.Sort(tbl_assetregisterDataGridView.Columns[colindex], ListSortDirection.Ascending);

                UpdateEquipmentDataGridViewDueRowCol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: Unable to extract all data, Please Check \n" + ex.Message);
                UpdateEquipmentDataGridViewDueRowCol();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnShowAssetsDue_Click(object sender, EventArgs e)
        {
            showDueCols = true;
            cmbGroupAllocation.Text = "";
            txbSearchOn.Text = "";
            SelectEquipmentDueForService();
        }

        private void tbl_assetregisterDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (showDueCols) UpdateEquipmentDataGridViewDueRowCol();
            Cursor.Current = Cursors.Default;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            cmbGroupAllocation.Text = "";
            cmbByArea.Text = "ALL";
            Properties.Settings.Default.DefaultSiteName = cmbByArea.Text;
            txbSearchOn.Text = "";
            rbAll.Checked = true;
            showDueCols = false;

            string sqlQuery = "SELECT * FROM tbl_assetregister;";
            tbl_assetregisterTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
            tbl_assetregisterTableAdapter.ClearBeforeFill = true;
            tbl_assetregisterTableAdapter.Fill(eped_db1DataSet.tbl_assetregister);
            Cursor.Current = Cursors.Default;
        }




        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            string fileName, filePathName, value;
            List<int> colsPrint = new List<int>();

            value = DateTime.Now.ToString("yyyyMMdd HHmmss") + " EPDB Report";
            if (Utils.InputBox("CSV Data for Excel", "Type Name for document", false, ref value) == DialogResult.OK)
            {
                fileName = value;
                filePathName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + fileName + ".csv";
                // collect all columns for data:
                for (int i = 0; i < tbl_assetregisterDataGridView.ColumnCount; i++)
                {
                    colsPrint.Add(i);
                }

                string title = "Report Dated " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " EPDB Asset List";

                Utils.WriteReportFile(tbl_assetregisterDataGridView, title, filePathName, colsPrint, false);

                MessageBox.Show("Report of all Assets in grid data placed to:\n" + filePathName, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void tbl_assetregisterBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void cmbByArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cmbByArea.SelectedIndex > -1) { cmbByArea.Text = cmbByArea.Items[cmbByArea.SelectedIndex].ToString(); }
            Properties.Settings.Default.DefaultSiteName = cmbByArea.Text;
            txbSearchOn.Text = "";
            SearchOnFilter();
            Cursor.Current = Cursors.Default;
        }



        private void AllocateWorkOrder()
        {
            // start to allocate jobs to technician OK..
            // fetch new WOYYMMDD99
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string lastWO = DBUtils.FetchLastJob(dbCon, "tbl_worksorders");
            string newWo = Utils.NewJobId(lastWO);
            string TechName = cmbTechnician.Items[cmbTechnician.SelectedIndex].ToString();
            int iEID = tbl_assetregisterDataGridView.IndexByName("EquipmentID");
            int iED = tbl_assetregisterDataGridView.IndexByName("EquipmentDescription");
            List<string> equipmentList = new List<string>();
            List<string> descriptionList = new List<string>();


            DialogResult result = DialogResult.Cancel;
            if (tbl_assetregisterDataGridView.SelectedRows.Count > 1)
            {
                result = MessageBox.Show("Allocate selected equipment to " + TechName + " \n Job ID to be: "
                   + newWo, "New Job Creation", MessageBoxButtons.OKCancel);

            }
            else
            {
                string equipmentID = tbl_assetregisterDataGridView.CurrentRow.Cells[iEID].Value.ToString();
                result = MessageBox.Show("Allocate " + equipmentID + " to " + TechName + " \n Job ID to be: " + newWo, "New Job Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            if (result == DialogResult.OK)
            {
                //   
                foreach (DataGridViewRow item in tbl_assetregisterDataGridView.SelectedRows)
                {
                    equipmentList.Add(item.Cells[iEID].Value.ToString());
                    descriptionList.Add(item.Cells[iED].Value.ToString());
                }
                DBUtils.InsertWorkOrder(dbCon, "tbl_worksorders", newWo, TechName, equipmentList, descriptionList, true);
            }
            cmbTechnician.Text = "";
            cmbTechnician.Visible = false;
        }


        private void cmbTechnician_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AllocateWorkOrder();
        }


        private void UpdateSetGroupAllocation()
        {
            int iGA = tbl_assetregisterDataGridView.IndexByName("GroupAllocation");
            string value = "";
            string typeAllocation = cmbSetGroupAllocation.Text;
            Globals.ChangesMade = true;

            foreach (DataGridViewRow item in tbl_assetregisterDataGridView.SelectedRows)
            {
                if (typeAllocation == "CLEAR ALLOCATION")
                {
                    item.Cells[iGA].Value = "";
                }
                else
                {
                    value = item.Cells[iGA].Value.ToString();
                    if (!value.Contains(typeAllocation))
                    {
                        item.Cells[iGA].Value = (value + " " + typeAllocation).Trim();
                    }
                    else
                    {
                        item.Cells[iGA].Value = value;
                    }
                }
            }
            cmbSetGroupAllocation.Text = "";
            cmbSetGroupAllocation.Visible = false;
        }





        private void cmbSetGroupAllocation_SelectionChangeCommitted(object sender, EventArgs e)
        // for exsiting allcoations
        {
            Globals.ChangesMade = true;
            Refresh();
            if (cmbSetGroupAllocation.SelectedIndex != -1) { cmbSetGroupAllocation.Text = cmbSetGroupAllocation.Items[cmbSetGroupAllocation.SelectedIndex].ToString(); }
            UpdateSetGroupAllocation();
        }




        private void cmbSetGroupAllocation_KeyPress(object sender, KeyPressEventArgs e)
        // for new entries
        {
            if (e.KeyChar == 13)
            {
                UpdateSetGroupAllocation();
            }
        }

        private void btnSaveUpdates_Click(object sender, EventArgs e)
        {
            tbl_assetregisterDataGridView.Enabled = true;
            btnAddNewAsset.Enabled = true;
            Cursor.Current = Cursors.WaitCursor;

            //'Site Name:' combobox
            siteNameComboBox.Text = InputValidation.UserValidationInput(siteNameComboBox.Text);

            //'Location:' combobox
            locationComboBox.Text = InputValidation.UserValidationInput(locationComboBox.Text);

            //'Station:' combobox
            stationComboBox.Text = InputValidation.UserValidationInput(stationComboBox.Text);

            //'Equipment Manufacturer:' combobox
            equipmentManufacturerComboBox.Text = InputValidation.UserValidationInput(equipmentManufacturerComboBox.Text);

            //'Calibration Interval:' combobox
            calibrationIntervalComboBox.Text = InputValidation.UserValidationInput(calibrationIntervalComboBox.Text);

            //Reminder Period For Calibration:' combobox
            reminderPeriodForCalibrationComboBox.Text = InputValidation.UserValidationInput(reminderPeriodForCalibrationComboBox.Text);

            //Verification Interval:' combobox
            verificationIntervalComboBox.Text = InputValidation.UserValidationInput(verificationIntervalComboBox.Text);

            //Reminder Period For Verification:' combobox
            reminderPeriodForVerificationComboBox.Text = InputValidation.UserValidationInput(reminderPeriodForVerificationComboBox.Text); ;

            //'PATInterval:' combobox
            pATIntervalComboBox.Text = InputValidation.UserValidationInput(pATIntervalComboBox.Text);

            //'Reminder Period For PAT:' combobox
            reminderPeriodForPATComboBox.Text = InputValidation.UserValidationInput(reminderPeriodForPATComboBox.Text);

            //'Group Allocation:' combobox
            groupAllocationComboBox.Text = InputValidation.UserValidationInput(groupAllocationComboBox.Text);

            //'Custodian:' combobox
            custodianComboBox.Text = InputValidation.UserValidationInput(custodianComboBox.Text);

            try
            {
                //SaveLocalSettings();
                Properties.Settings.Default.Save();
                this.Validate();
                this.tbl_assetregisterBindingSource.EndEdit();
                this.tbl_assetregisterTableAdapter.Update(eped_db1DataSet.tbl_assetregister);
                MessageBox.Show("Update Successful");
                Globals.ChangesMade = false;
                UpdateComBoxes();
                // refesh dates that may have now been added
              //  CheckDateDisplay();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Update Failed\n"+ex.Message);
                RefreshDataGridView();
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnAddNewAsset_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_assetregisterDataGridView.Enabled = false;
                btnAddNewAsset.Enabled = false;
                Globals.ChangesMade = true;
                if (!string.IsNullOrEmpty(equipmentIDTextBox.Text))
                {
                    tbl_assetregisterBindingSource.AddNew();
                    // fill it with defaults
                    equipmentReceivedDateDateTimePicker.Value = DateTime.Now;
                    calibrationRequiredcheckBox.Checked = false;
                    verificationRequiredcheckBox.Checked = false;
                    pATTestRequiredcheckBox.Checked = false;
                    inUsecheckBox.CheckState = CheckState.Checked;

                    siteNameComboBox.Text = cmbByArea.Text;
                    
                }
                else
                {
                    MessageBox.Show("EquipmentID need to be filled!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnAddNewAsset.Enabled = true;
                tbl_assetregisterDataGridView.Enabled = true;
            }
           
        }

        private void cmbGroupAllocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbGroupAllocation.SelectedIndex != -1) { cmbGroupAllocation.Text = cmbGroupAllocation.Items[cmbGroupAllocation.SelectedIndex].ToString(); }
            if (cmbGroupAllocation.Text == "CLEAR ALLOCATION")
            {
                cmbGroupAllocation.Text = "";
            }
            SearchOnFilter();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }




        private void printDocument1_BeginPrint(object sender,
    System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                DataGridView dgv = tbl_assetregisterDataGridView;
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                bFirstPage = true;
                bNewPage = true;
                pageCount = 0;

                // Calculating Total Widths of selected columns
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgv.Columns)
                {
                    if (colsPrint.Contains(dgvGridCol.DisplayIndex))
                    {
                        iTotalWidth += dgvGridCol.Width;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void printDocument1_PrintPage(object sender,
                            System.Drawing.Printing.PrintPageEventArgs e)
        {

            DataGridView dgv = tbl_assetregisterDataGridView;
            bool prnInCol = Properties.Settings.Default.PrintInColor;
            Color fgCol;
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                pageCount++;
                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgv.Columns)
                        if (colsPrint.Contains(GridCol.DisplayIndex))
                        {
                            {
                                iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                    (double)iTotalWidth * (double)iTotalWidth *
                                    ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                                iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                                // Save width and height of headers
                                arrColumnLefts.Add(iLeftMargin);
                                arrColumnWidths.Add(iTmpWidth);
                                iLeftMargin += iTmpWidth;
                            }
                        }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dgv.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgv.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allows more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            // Print Page No
                            e.Graphics.DrawString("Page No " + pageCount,
                               new Font(dgv.Font, FontStyle.Bold),
                               Brushes.Black, (e.MarginBounds.Left + e.MarginBounds.Width / 2),
                               e.MarginBounds.Top - e.Graphics.MeasureString("Page No ",
                               new Font(dgv.Font, FontStyle.Bold),
                               e.MarginBounds.Width).Height - 13);
                            //Draw Header
                            e.Graphics.DrawString("Printed Report as at ",
                                new Font(dgv.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString("Printed Report as at ",
                                new Font(dgv.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height - 13);
                            // deteremine date now
                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate,
                                new Font(dgv.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(dgv.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Printed Report as at ",
                                new Font(new Font(dgv.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns listed in colsPrint                
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgv.Columns)
                                if (colsPrint.Contains(GridCol.DisplayIndex))
                                {
                                    {
                                        e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                            new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                            (int)arrColumnWidths[iCount], iHeaderHeight));

                                        e.Graphics.DrawRectangle(Pens.Black,
                                            new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                            (int)arrColumnWidths[iCount], iHeaderHeight));

                                        e.Graphics.DrawString(GridCol.HeaderText,
                                            GridCol.InheritedStyle.Font,
                                            new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                            (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                        iCount++;
                                    }
                                }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {

                            if (colsPrint.Contains(Cel.ColumnIndex))
                            {
                                if (Cel.Value != null)
                                {
                                    // fill background color
                                    if (prnInCol)
                                    {
                                        e.Graphics.FillRectangle(new SolidBrush(Cel.InheritedStyle.BackColor), (int)arrColumnLefts[iCount], iTopMargin,
                                  (int)arrColumnWidths[iCount], iCellHeight);
                                        fgCol = Cel.InheritedStyle.ForeColor;
                                    }
                                    else
                                    {
                                        fgCol = Color.Black;
                                    }
                                    // add text from cell

                                    e.Graphics.DrawString(Cel.Value.ToString(),
                                        Cel.InheritedStyle.Font,
                                        new SolidBrush(fgCol),
                                        new RectangleF((int)arrColumnLefts[iCount],
                                        (float)iTopMargin,
                                        (int)arrColumnWidths[iCount], (float)iCellHeight),

                                        strFormat);
                                }
                                //Drawing Cells Borders new SolidBrush(Cel.InheritedStyle.BackColor),
                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iCellHeight));
                                iCount++;
                            }
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                {
                    e.HasMorePages = false;
                    iRow = 0;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            // define what headings to print:
            DataGridView dgv = tbl_assetregisterDataGridView;
            colsPrint.Add(Utils.GetColIndex(dgv, "EquipmentID"));
            colsPrint.Add(Utils.GetColIndex(dgv, "EquipmentDescription"));
            colsPrint.Add(Utils.GetColIndex(dgv, "CalibrationRequired"));
            colsPrint.Add(Utils.GetColIndex(dgv, "DateCalibrationDue"));
            colsPrint.Add(Utils.GetColIndex(dgv, "VerificationRequired"));
            colsPrint.Add(Utils.GetColIndex(dgv, "DateVerificationDue"));
            colsPrint.Add(Utils.GetColIndex(dgv, "PATTestRequired"));
            colsPrint.Add(Utils.GetColIndex(dgv, "DatePATDue"));

            //Open the print preview dialog

            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            printDocument1.DefaultPageSettings.Landscape = true;
            objPPdialog.Top = Top - 10;
            objPPdialog.Width = (int)(Width * 0.7);
            objPPdialog.Height = (int)(Height * 0.9);
            objPPdialog.PrintPreviewControl.Zoom = 1.0;
            objPPdialog.Document = printDocument1;
            //objPPdialog.PrintPreviewControl.Controls.
            objPPdialog.ShowDialog();

        }

        private void btnByArea_Click(object sender, EventArgs e)
        {
            // clear search filer first
            txbSearchOn.Text = "";
            SearchOnFilter();
        }

        private void btnCertLocation_Click(object sender, EventArgs e)
        {
            // select location for udpates
            string initDir = @"\\Properties.Settings.Default.ServerLocation\setup$";

            initDir = System.IO.Path.GetDirectoryName(initDir);
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = initDir,
                Title = "Locate Certificate to save",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "images",
                Filter = "app files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Globals.ChangesMade = true;
                calibrationCertLocationTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void btnManualLocation_Click(object sender, EventArgs e)
        {

            string initDir = @"\\Properties.Settings.Default.ServerLocation\setup$";
            FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog
            {
                SelectedPath = initDir,
                Description = "Locate folder for Asset Manuals"
            };

            if (openFolderDialog1.ShowDialog() == DialogResult.OK)
            {
                Globals.ChangesMade = true;
                equipmentManualLocationTextBox.Text = openFolderDialog1.SelectedPath;
            }
        }

        private void equipmentManualLocationLabel_Click(object sender, EventArgs e)
        {
            // open filedialog to select manual to open
            string initDir = equipmentManualLocationTextBox.Text;
            if (initDir != "")
            {
                Process.Start(initDir);
            }

        }

        private void calibrationCertLocationLabel_Click(object sender, EventArgs e)
        {
            string sf = calibrationCertLocationTextBox.Text;
            if (File.Exists(sf))
            {
                Process.Start(sf);
            }
        }

        private void ShowMainDialog(int rowSelected, int colSelected)
        {
            DataGridView dgv = tbl_assetregisterDataGridView;
            string equipmentid;
            Color cellColor;
            // is this a row select if so jump out here.
            if (colSelected == -1) { return; }
            cellColor = dgv.Rows[rowSelected].Cells[colSelected].Style.BackColor;
            //if ((cellColor == Color.Empty) | (cellColor == Color.White)) { return; }  // exit routine 

            try
            {
                equipmentid = "";
                equipmentid = dgv.Rows[rowSelected].Cells[0].Value.ToString();  // fetch first column, Equipment Id
                var m = new ShowMaintDialog();
                m.SelectedEquipmentId = equipmentid;
                m.SelectedWeekNo = Int16.Parse(Utils.GetWeekNo(DateTime.Now));
                m.SelectedYear = DateTime.Now.Year;
                m.ShowDialog();   // show dialog sets tis to modal form...
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void tbl_assetregisterDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            // sort out week no 
            ShowMainDialog(e.RowIndex, 1);
        }

        private void CheckDateDisplay()
        {
            // fetch current row form grid
            //DataRowView currentDataRowView = (DataRowView)tbl_assetregisterDataGridView.CurrentRow.DataBoundItem;
            //DataRow row = currentDataRowView.Row;
            string retval = "";

            try
            {
                if(tbl_assetregisterBindingSource.Current != null)
                {
                    retval = ((DataRowView)tbl_assetregisterBindingSource.Current).Row["EquipmentReceivedDate"].ToString();
                    if (retval == "") { equipmentReceivedDateDateTimePicker.CustomFormat = " "; }
                    else { equipmentReceivedDateDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }

                    retval = ((DataRowView)tbl_assetregisterBindingSource.Current).Row["DateOfCalibration"].ToString();
                    if (retval == "") { dateOfCalibrationDateTimePicker.CustomFormat = " "; }
                    else { dateOfCalibrationDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }

                    retval = ((DataRowView)tbl_assetregisterBindingSource.Current).Row["DateCalibrationDue"].ToString();
                    if (retval == "") { dateCalibrationDueDateTimePicker.CustomFormat = " "; }
                    else { dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }

                    retval = ((DataRowView)tbl_assetregisterBindingSource.Current).Row["DateOfVerification"].ToString();
                    if (retval == "") { dateOfVerificationDateTimePicker.CustomFormat = " "; }
                    else { dateOfVerificationDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }

                    retval = ((DataRowView)tbl_assetregisterBindingSource.Current).Row["DateVerificationDue"].ToString();
                    if (retval == "") { dateVerificationDueDateTimePicker.CustomFormat = " "; }
                    else { dateVerificationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }

                    retval = ((DataRowView)tbl_assetregisterBindingSource.Current).Row["DateOfPAT"].ToString();
                    if (retval == "") { dateOfPATDateTimePicker.CustomFormat = " "; }
                    else { dateOfPATDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }

                    retval = ((DataRowView)tbl_assetregisterBindingSource.Current).Row["DatePATDue"].ToString();
                    if (retval == "") { datePATDueDateTimePicker.CustomFormat = " "; }
                    else { datePATDueDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }
                }
                
            }
            catch (Exception)
            {

                //  MessageBox.Show(ex.Message);
            }

        }

        private void equipmentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDateDisplay();
            if (multiplePMCheckBox.Checked) { btnPMTasks.Visible = true; } else { btnPMTasks.Visible = false; }

        }

       

        private void equipmentReceivedDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            equipmentReceivedDateDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            //Globals.ChangesMade = true;
        }

        private void dateOfCalibrationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateOfCalibrationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            //Globals.ChangesMade = true;
        }

        private void dateCalibrationDueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            //Globals.ChangesMade = true;
        }

        private void dateOfVerificationDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateOfVerificationDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            //Globals.ChangesMade = true;
        }

        private void dateVerificationDueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateVerificationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            //Globals.ChangesMade = true;
        }

        private void dateOfPATDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateOfPATDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            Globals.ChangesMade = true;
        }

        private void datePATDueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            datePATDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            Globals.ChangesMade = true;
        }

        private void calibrationCostsTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(calibrationCostsTextBox.Text == "")
            {
                int selCol= tbl_assetregisterDataGridView.IndexByName("CalibrationCosts");
                tbl_assetregisterDataGridView.CurrentRow.Cells[selCol].Value = DBNull.Value; }
        }

        private void multiplePMCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            // check to see if set to show dialog for dates if true.

            if (multiplePMCheckBox.Checked)
            {
                btnPMTasks.Visible = true;
            }
            else
            {
                btnPMTasks.Visible = false;
            }


        }

        private void tbl_assetregisterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // this commits the change an d fires the event cell valuechanged.
            // only admin to make changes here hence return if not admin
            var current = tbl_assetregisterDataGridView.CurrentCell;
            if (Globals.AccessLevel==1)
            {
                tbl_assetregisterDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            tbl_assetregisterDataGridView.CurrentCell = current;

        }


        private void DisplayAdminPMDialog ()
        {
            DialogResult response;

            ShowPMDialogAdmin f = new ShowPMDialogAdmin();
            f.SelectedEquipmentId= equipmentIDTextBox.Text;

           // f.SelectedWeekNo = Int16.Parse(Utils.GetWeekNo(DateTime.Now));
           // f.SelectedYear = DateTime.Now.Year;
            f.Description = equipmentDescriptionTextBox.Text;
            f.SiteName= siteNameComboBox.Text;
            f.AssetLocation = locationComboBox.Text;
            f.Station = stationComboBox.Text;
        

          //  f.lblWeekno.Text = Utils.GetWeekNo(DateTime.Now);
            //f.lbTimeLeft.Text = value;
            response = f.ShowDialog();
            if (response == DialogResult.OK)
            {
                
            }
            else
            {

            }

        }

       

        private void tbl_assetregisterDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.ColumnIndex < 0) | (e.RowIndex < 0) ) { return; }
            Cursor.Current = Cursors.WaitCursor;

            if ((tbl_assetregisterDataGridView.Columns[e.ColumnIndex].HeaderText == "PreventativeMaintenanceRequired") & (Globals.AccessLevel ==1))
            {
                object value = tbl_assetregisterDataGridView[e.ColumnIndex, e.RowIndex].Value;
                if (value != null && (Boolean)value)
                {
                    multiplePMCheckBox.Checked = true;
                    btnPMTasks.Visible = true;
                    tbl_assetregisterBindingSource.MoveNext();
                    //DisplayAdminPMDialog();
                    //Globals.ChangesMade = true;
                    Refresh();
                }
                else
                {
                    DialogResult response = MessageBox.Show("This will delete this record from the system","Clear PM Record",MessageBoxButtons.OKCancel);
                    if (response == DialogResult.OK)
                    {
                        // delete entry from pm table
                        string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
                        if (DBUtils.ExecuteSqlCmdInDB(dbCon, "DELETE FROM tbl_pmschedule WHERE EquipmentID LIKE '"+equipmentIDTextBox.Text+"';",false))
                            {
                                multiplePMCheckBox.Checked = false;
                                Globals.ChangesMade = true;
                        }
                    }
                    else
                    {
                        tbl_assetregisterDataGridView[e.ColumnIndex, e.RowIndex].Value = true;
                        // moving to next in row causes the table udpate to refresh with current not changed data.
                        tbl_assetregisterBindingSource.MoveNext();
                    }
                    
                }
                // write teh bool to the database directlry
                UpdateMP();
                Globals.ChangesMade = false;
                Cursor.Current = Cursors.Default;
            }
        }
        private void UpdateMP()
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string filter = " WHERE EquipmentID LIKE '%" + equipmentIDTextBox.Text + "%';";
            int mpmVal = 1;
            if (multiplePMCheckBox.Checked) { mpmVal = 1; } else { mpmVal = 0; }
            DBUtils.UpdateDataToTableFields(dbCon, "tbl_assetregister", "MultiplePM", mpmVal.ToString(),filter);

        }

        private void btnPMTasks_Click(object sender, EventArgs e)
        {
            if (Globals.AccessLevel == 1)
                DisplayAdminPMDialog();
            else
                MessageBox.Show("Your access level is to low. Contact Administrator");
        }

        //Inside panel - 2nd '...' button
        private void btnManualLocation_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        //Inside panel - 2nd '...' button
        private void btnManualLocation_MouseLeave(object sender, EventArgs e)
        {
           
        }






        // end of this class asset lists
    }





    public static class MyTools
    {
        public static int IndexByName(this DataGridView dgv, string name)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.HeaderText.ToUpper().Trim() == name.ToUpper().Trim())
                {
                    return col.Index;
                }
            }
            return -1;
        }
    }
}
