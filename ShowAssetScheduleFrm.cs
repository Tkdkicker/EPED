using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace EPED
{
    public partial class ShowAssetScheduleFrm : Form
    {
        // api declaration to tunr off screen udpates for DGV  to speed this up
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;
        //DataSet dsml = new DataSet();
        // List<string> ListA = new List<string>();
        DataTable dtbForAssets = new DataTable();
        DataTable dtbForLogs = new DataTable();
        int CurrentYear = DateTime.Now.Year;

        public ShowAssetScheduleFrm()
        {
            InitializeComponent();
        }
        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " -Scheduler- " + "Version: (" + Globals.CurrVersion + ")   Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }

        private void AssetScheduleFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = Globals.defaultformsbgCol;
            cmbSiteName.Text = Properties.Settings.Default.DefaultSiteName;
            lblPeriod.Text = DateTime.Now.Year.ToString();
            this.dgv.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            UpdateComBoxes();
            UpdateSchedulerDisplay();
        }


        private void UpdateComBoxes()
        {
            List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "GroupAllocation");
            valuelist.Sort();
            cmbGroupAllocation.Items.Clear();
            cmbGroupAllocation.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "SiteName");
            valuelist.Sort();
            cmbSiteName.Items.Clear();
            cmbSiteName.Items.Add("ALL");
            cmbSiteName.Items.AddRange(valuelist.ToArray());
        }


        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "SelectFrm")
                {

                    f.WindowState = FormWindowState.Normal;
                    break;
                }
            }
        }


        private string LogFilterMatrix()
        {
            string filter = "";
            string partfilter = "";
            string siteFilter = cmbSiteName.Text;
            if (rbdisplaybyyear.Checked)
            {
                if (partfilter == "")
                {
                    partfilter = partfilter + " (YEAR(Date) = " + lblPeriod.Text + ")";
                }
                else
                {
                    partfilter = partfilter + " AND (YEAR(Date) = " + lblPeriod.Text + ")";
                }
            }

            if (rbdisplaybymonth.Checked)
            {
                if (partfilter == "")
                {
                    partfilter = partfilter + " (MONTH(Date) = " + lblPeriod.Text + ")";
                }
                else
                {
                    partfilter = partfilter + " AND (MONTH(Date) = " + lblPeriod.Text + ")";
                }
            }

            if (rbdisplaybyweek.Checked)
            {
                if (partfilter == "")
                {
                    partfilter = partfilter + " (WEEK(Date) = " + lblPeriod.Text + ")";
                }
                else
                {
                    partfilter = partfilter + " AND (WEEK(Date) = " + lblPeriod.Text + ")";
                }
            }

            if ((siteFilter != "ALL") && (siteFilter != ""))
            {
                partfilter = partfilter + " AND (SiteName = '" + cmbSiteName.Text + "')";
            }

            if (partfilter != "")
            {
                filter = " WHERE " + partfilter + " ORDER BY Date";
            }
            else
            {
                filter = " ORDER BY Date";
            }
            return filter;
        }


        private string AssetFilterMatrix()
        {
            string filter = "";
            string partfilter = "";
            string siteFilter = cmbSiteName.Text;
            if (rbdisplaybycal.Checked)
            {
                if (partfilter == "")
                {
                    partfilter = partfilter + " CalibrationRequired = 1";
                }
                else
                {
                    partfilter = partfilter + " AND  CalibrationRequired = 1";
                }
            }

            if (rbdisplaybyver.Checked)
            {
                if (partfilter == "")
                {
                    partfilter = partfilter + " VerificationRequired = 1";
                }
                else
                {
                    partfilter = partfilter + " AND  VerificationRequired = 1";
                }
            }

            if (rbdisplaybypat.Checked)
            {
                if (partfilter == "")
                {
                    partfilter = partfilter + " PATTestRequired = 1";
                }
                else
                {
                    partfilter = partfilter + " AND  PATTestRequired = 1";
                }
            }

            if (rbdisplaybycal.Checked)
            {
                if (partfilter == "")
                {
                    partfilter = partfilter + " CalibrationRequired = 1";
                }
                else
                {
                    partfilter = partfilter + " AND  CalibrationRequired = 1";
                }
            }

            if (rbdisplaybyga.Checked)
            {
                if (cmbGroupAllocation.Text != "")
                {
                    if (partfilter == "")
                    {
                        partfilter = partfilter + " GroupAllocation = '" + cmbGroupAllocation.Text + "'";
                    }
                    else
                    {
                        partfilter = partfilter + " AND GroupAllocation = '" + cmbGroupAllocation.Text + "'";
                    }
                }
            }

            if ((siteFilter != "ALL") && (siteFilter != ""))
            {

                if (partfilter == "")
                {

                    partfilter = " (SiteName = '" + cmbSiteName.Text + "')";

                }
                else
                {
                    partfilter = partfilter + " AND (SiteName = '" + cmbSiteName.Text + "')";
                }
            }

            if (cbInUse.Checked)
            {
                if (cmbGroupAllocation.Text != "")
                {
                    if (partfilter == "")
                    {
                        partfilter = partfilter + " InUse = 1";
                    }
                    else
                    {
                        partfilter = partfilter + " AND InUse = 1";
                    }
                }
            }

            if (partfilter != "")
            {
                filter = " WHERE " + partfilter + " ORDER BY EquipmentID";
            }
            else
            {
                filter = " ORDER BY EquipmentID";
            }
            return filter;
        }


        private void UpdateSchedulerDisplay()
        {
            List<string> listB = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            DateTime datenow = DateTime.MinValue;
            DateTime duedate;
            int weekno, period = 0, weeknextdue, irow;
            DataRow[] returnRows;


            Cursor.Current = Cursors.WaitCursor;

            string filter = " WHERE (YEAR(Date) = " + lblPeriod.Text + ") ORDER BY [Date];";
            //    List<string> rowdata = new List<string>();

            filter = AssetFilterMatrix();
            dtbForAssets = DBUtils.FetchDBTableByFilter(dbCon, "tbl_assetregister", filter);
            filter = LogFilterMatrix();
            dtbForLogs = DBUtils.FetchDBTableByFilter(dbCon, "tbl_assetlogs", filter);

            if (dtbForAssets.Rows.Count == 0) { return; }
            // todo 
            dgv.Rows.Clear();

            // turn off redrawing method for grid to improve speed.
            SendMessage(dgv.Handle, WM_SETREDRAW, false, 0);



            irow = -1;

            weekno = Int16.Parse(Utils.GetWeekNo(DateTime.Now));

            bool duethisyear = false;
            foreach (DataRow row in dtbForAssets.Rows)
            {
                // initialsie variable
                duethisyear = false;
                weeknextdue = 54;
                // create a new row to fill with data
                dgv.Rows.Add();
                irow = irow + 1;
                dgv.Rows[irow].Cells[0].Value = row["EquipmentID"];
                dgv.Rows[irow].Cells[1].Value = row["EquipmentDescription"];
                // determine date due  for required
                if (row["CalibrationRequired"].ToString() == "1")
                {
                    if (row["DateCalibrationDue"].ToString() != "")
                    {
                        duedate = Convert.ToDateTime(row["DateCalibrationDue"]);
                        weeknextdue = Int16.Parse(Utils.GetWeekNo(duedate));
                        period = Utils.ConvertToWeeks(row["CalibrationInterval"].ToString());
                        if (duedate.Year == Int16.Parse(lblPeriod.Text)) { duethisyear = true; }
                    }
                    else
                    {
                        duethisyear = true;
                    }

                }
                if (row["VerificationRequired"].ToString() == "1")
                {
                    if (row["DateVerificationDue"].ToString() != "")
                    {
                        duedate = Convert.ToDateTime(row["DateVerificationDue"]);
                        weeknextdue = Int16.Parse(Utils.GetWeekNo(duedate));
                        period = Utils.ConvertToWeeks(row["VerificationInterval"].ToString());
                        if (duedate.Year == Int16.Parse(lblPeriod.Text)) { duethisyear = true; }
                    }
                    else
                    {
                        duethisyear = true;
                    }
                    // add for mont then week here
                }
                if (row["PATTestRequired"].ToString() == "1")
                {
                    if (row["DatePATDue"].ToString() != "")
                    {
                        duedate = Convert.ToDateTime(Convert.ToDateTime(row["DatePATDue"]));
                        weeknextdue = Int16.Parse(Utils.GetWeekNo(duedate));
                        period = Utils.ConvertToWeeks(row["PATInterval"].ToString());
                        if (duedate.Year == Int16.Parse(lblPeriod.Text)) { duethisyear = true; }
                    }
                    else
                    {
                        duethisyear = true;
                    }
                }
                if (period == 0) { period = 52; }

                if ((period <= 52) | ((period > 52) && duethisyear))
                {

                    for (int icol = 2; icol < 55; icol++)
                    {
                        if (((icol - 1 - weeknextdue) % period) == 0)
                        {
                            if (row["InUse"].ToString() == "1")
                            {
                                dgv.Rows[irow].Cells[icol].Style.BackColor = Color.Gray;

                            }
                            else
                            {
                                dgv.Rows[irow].Cells[icol].Style.BackColor = Color.LightGray;
                            }

                        }
                    }
                }
                // now attempt to extract maintenance log data
                listB.Clear();
                try
                {
                    returnRows = dtbForLogs.Select("EquipmentID LIKE '%" + row["EquipmentID"].ToString() + "%'");

                    if (returnRows != null)
                    {
                        foreach (DataRow dr in returnRows)
                        {
                            listB.Add(dr["Date"].ToString() + "," + dr["Reason"].ToString() + ","
                                + dr["Technician"].ToString() + "," + dr["ActionTaken"].ToString());
                        }

                    }
                }
                catch (Exception)
                {
                }
                if (row["InUse"].ToString() != "1") { dgv.Rows[irow].DefaultCellStyle.BackColor = Color.LightBlue; }
                // pass frome datarow to list the log values

                string[] splitItems;
                DateTime time;
                foreach (string item in listB)
                {
                    splitItems = item.Split(',');
                    time = DateTime.Parse(splitItems[0]);
                    weekno = Int16.Parse(Utils.GetWeekNo(time));

                    if ((weekno < 53) && ((splitItems[1].ToUpper().Contains("SERVICE")) | (splitItems[1].ToUpper().Contains("MAINT"))))
                    {
                        dgv.Rows[irow].Cells[weekno + 1].Value = time.ToString("dd-MMM");
                        // pre mark remainder weeks with serve to do

                        if (period == 0) { period = 52; }

                        for (int i = weekno; i < 53; i++)
                        {
                            if ((i - weekno - 1) % period == 0)
                            {
                                if (row["InUse"].ToString() != "1")
                                {
                                    dgv.Rows[irow].Cells[i + 1].Style.BackColor = Color.LightGray;
                                }
                                else
                                {
                                    dgv.Rows[irow].Cells[i + 1].Style.BackColor = Color.Gray;
                                }
                            }
                            else
                            {
                                if (row["InUse"].ToString() != "1")
                                {
                                    dgv.Rows[irow].Cells[i + 1].Style.BackColor = Color.LightBlue;
                                }
                                else
                                {
                                    dgv.Rows[irow].Cells[i + 1].Style.BackColor = Color.White;
                                }
                            }


                        }
                    }

                    if (dgv.Rows[irow].Cells[weekno + 1].Value == null)
                    {

                        dgv.Rows[irow].Cells[weekno + 1].Style.BackColor = Color.LightPink;

                    }
                    else
                    {
                        dgv.Rows[irow].Cells[weekno + 1].Style.BackColor = Color.LightGreen;
                    }
                }
            }

            // turn on redrawing method 
            SendMessage(dgv.Handle, WM_SETREDRAW, true, 0);
            dgv.Refresh();


            lblNoOfRecords.Text = dgv.Rows.Count.ToString();
            Cursor.Current = Cursors.Default;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            lblPeriod.Text = (Int16.Parse(lblPeriod.Text) + 1).ToString();
            if (btnCurrentPeriod.Text == "CURRENT YEAR") { CurrentYear = Int16.Parse(lblPeriod.Text); }
            UpdateSchedulerDisplay();
        }

        private void Prev_Button_Click(object sender, EventArgs e)
        {
            lblPeriod.Text = (Int16.Parse(lblPeriod.Text) - 1).ToString();
            UpdateSchedulerDisplay();
        }

        private void rbdisplaybymonth_CheckedChanged(object sender, EventArgs e)
        {
            DisplayCurrentPeriod();
        }

        private void rbdisplaybyweek_CheckedChanged(object sender, EventArgs e)
        {
            DisplayCurrentPeriod();
        }

        private void DisplayCurrentPeriod()
        {
            if (rbdisplaybyyear.Checked)
            {
                lblPeriod.Text = DateTime.Now.Year.ToString();
                btnCurrentPeriod.Text = "CURRENT YEAR";
                dgv.FirstDisplayedScrollingColumnIndex = 2;

            }

            if (rbdisplaybymonth.Checked)
            {
                lblPeriod.Text = DateTime.Now.Month.ToString();
                btnCurrentPeriod.Text = "CURRENT MONTH";
                dgv.FirstDisplayedScrollingColumnIndex = Int16.Parse(Utils.GetWeekNo(DateTime.Now)) + 2;

            }

            if (rbdisplaybyweek.Checked)
            {
                lblPeriod.Text = Utils.GetWeekNo(DateTime.Now);
                btnCurrentPeriod.Text = "CURRENT WEEK";
                dgv.FirstDisplayedScrollingColumnIndex = Int16.Parse(Utils.GetWeekNo(DateTime.Now)) + 2;
            }
        }



        private void btnCurrentPeriod_Click(object sender, EventArgs e)
        {
            DisplayCurrentPeriod();
            UpdateSchedulerDisplay();
        }

        private void rbdisplaybyyear_CheckedChanged(object sender, EventArgs e)
        {
            DisplayCurrentPeriod();
        }


        private void ShowMainDialog(int rowSelected, int colSelected)
        {

            string period = "";
            string equipmentid;
            Color cellColor;
            // is this a row select if so jump out here.
            if (colSelected == -1) { return; }
            cellColor = dgv.Rows[rowSelected].Cells[colSelected].Style.BackColor;
            if ((cellColor == Color.Empty) | (cellColor == Color.White)) { return; }  // exit routine 

            try
            {
                equipmentid = "";
                equipmentid = dgv.Rows[rowSelected].Cells[0].Value.ToString();  // fetch first column
                period = btnCurrentPeriod.Text;
                period = period.Remove(0, 7);
                var m = new ShowMaintDialog();
                m.SelectedEquipmentId = equipmentid;
                m.SelectedWeekNo = colSelected - 1;
                m.SelectedPeriod = period + lblPeriod.Text;
                m.SelectedYear = CurrentYear;
                // showdialog sets form modal
                m.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            ShowMainDialog(e.RowIndex, e.ColumnIndex);
        }

        private void rbdisplaybycal_CheckedChanged(object sender, EventArgs e)
        {
            //'ASSET TYPE' combobox
            cmbGroupAllocation.Text = InputValidation.UserValidationInput(cmbGroupAllocation.Text);

            UpdateSchedulerDisplay();
        }

        private void rbdisplaybyver_CheckedChanged(object sender, EventArgs e)
        {
            //'ASSET TYPE' combobox
            cmbGroupAllocation.Text = InputValidation.UserValidationInput(cmbGroupAllocation.Text);

            UpdateSchedulerDisplay();
        }

        private void rbdisplaybypat_CheckedChanged(object sender, EventArgs e)
        {
            //'ASSET TYPE' combobox
            cmbGroupAllocation.Text = InputValidation.UserValidationInput(cmbGroupAllocation.Text);

            UpdateSchedulerDisplay();
        }

        private void rbdisplaybyga_CheckedChanged(object sender, EventArgs e)
        {
            //'ASSET TYPE' combobox
            cmbGroupAllocation.Text = InputValidation.UserValidationInput(cmbGroupAllocation.Text);

            UpdateSchedulerDisplay();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

        }

        private void cmbSiteName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbSiteName.Text = cmbSiteName.Items[cmbSiteName.SelectedIndex].ToString();
            UpdateSchedulerDisplay();
        }

        private void AssetScheduleFrm_Activated(object sender, EventArgs e)
        {
            this.BringToFront();
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;
        }

        private void cmbSiteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //'SHOWN BY AREA:' combobox
            cmbSiteName.Text = InputValidation.UserValidationInput(cmbSiteName.Text);
        }
       

    }
}
