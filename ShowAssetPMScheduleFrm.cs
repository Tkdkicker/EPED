using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Globals;

namespace EPED
{
    public partial class ShowAssetPMScheduleFrm : Form
    {
        // api declaration to tunr off screen udpates for DGV  to speed this up
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;
        DataTable dtbForAssetRegister = new DataTable();
        //DataTable dtbForPMAssets = new DataTable();
        DataTable dtbForLogs = new DataTable();
        DataTable dtbForPMSched = new DataTable();
        int CurrentYear = DateTime.Now.Year;

        int serviceOnTime = 0;
        int serviceNotOnTime = 0;
        int serviceCount = 0;
        public ShowAssetPMScheduleFrm()
        {
            InitializeComponent();
        }
        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " - Preventative Maintenance Scheduler - " + "Version: (" + Globals.CurrVersion + ")   Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }

        private void AssetScheduleFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = Globals.defaultformsbgCol;
            cmbSiteName.Text = Properties.Settings.Default.DefaultSiteName;
            lblYear.Text = DateTime.Now.Year.ToString();
            UpdateComBoxes();
            this.dgv.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            Task<bool> task =  UpdateSchedulerDisplay();
        }




        private void UpdateComBoxes()
        {
            List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmschedule", "GroupAllocation");
            valuelist.Sort();
            cmbGroupAllocation.Items.Clear();
            cmbGroupAllocation.Items.Add("ALL");
            cmbGroupAllocation.Items.AddRange(valuelist.ToArray());
            cmbGroupAllocation.Text = "ALL";

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "SiteName");
            valuelist.Sort();
            cmbSiteName.Items.Clear();
            cmbSiteName.Items.Add("ALL");
            cmbSiteName.Items.AddRange(valuelist.ToArray());
            cmbSiteName.Text = "ALL";

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "Station");
            valuelist.Sort();
            cmbStation.Items.Clear();
            cmbStation.Items.Add("ALL");
            cmbStation.Items.AddRange(valuelist.ToArray());
            cmbStation.Text = "ALL";

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

            if (partfilter == "")
            {
                partfilter = partfilter + " (YEAR(Date) = " + lblYear.Text + ")";
            }
            else
            {
                partfilter = partfilter + " AND (YEAR(Date) = " + lblYear.Text + ")";
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
            string station = cmbStation.Text;


            if ((cmbGroupAllocation.Text != "") && (cmbGroupAllocation.Text != "ALL"))
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



        private void ShowLegendColors()
        {
            // define legend colour
            lbCompleted.BackColor = pmcompletedbgCol;
            lbOverdue.BackColor = pmoverduebgCol;
            lbOutstanding.BackColor = pmoutstandingbgCol;
            lbScheduled.BackColor = pmgridcellbgCol;
            lbOutOfUse.BackColor = notinusebgCol;
            lbCurrentWeek.BackColor = gridcurrentweekbgCol;
            lbNotScheduled.BackColor = nolongerscheduledbgCol;
        }




        private void DisplayScheduledTasks(int irow, DateTime assetStartDate, string frequency, bool inUse)
        {
            // trap to ensure there is data:
            if (irow < 0) { return; }

            // this routine adds to selected dgvrow teh cell information cell trst type WMQYF6
            int assetStartWeek = Int16.Parse(Utils.GetWeekNo(assetStartDate));
            int weekNow = Int16.Parse(Utils.GetWeekNo(DateTime.Now));
            int yearNow = DateTime.Now.Year;
            int dueWeekNo = assetStartWeek;
            DateTime dueDateNext = assetStartDate;
            string cellTestType = "";
            string testType = TypeFromFrequency(frequency);  // determine letter for frequency to be placed to cell


            // cycle through the weeks
            for (int icol = 2; icol < 55; icol++)
            {
                //if (icol == 52)
                //{
                //    MessageBox.Show("hello");
                //}
                cellTestType = "";
                // check if asset introduced in this year, to start from
                if (icol - 1 == dueWeekNo)
                {
                    // now check if asset has PM scheduled already append or insert with new test type
                    if (dgv.Rows[irow].Cells[icol].Value != null) { cellTestType = dgv.Rows[irow].Cells[icol].Value.ToString(); }


                    // if not already displayed add cell type
                    //  if (cellTestType.Contains(testType) == false)
                    {
                        cellTestType = cellTestType + testType;
                    }

                    dgv.Rows[irow].Cells[icol].Value = cellTestType;
                    // distinguish between asset in use and not in use
                    if (inUse)
                    {
                        // increment service count
                        serviceCount++;
                        // show as scheduled
                        dgv.Rows[irow].Cells[icol].Style.BackColor = pmgridcellbgCol;
                        // for current year and week change bg color
                        if (yearNow == Int16.Parse(lblYear.Text))
                        {
                            // check for current week
                            if (weekNow == (icol - 1))
                            {
                                // make font bold for this week
                                dgv.Rows[irow].Cells[icol].Style.Font = new Font("Calibra Light", 8, FontStyle.Bold);
                            }

                            // prior to maintenance log check for work done mark all previous as overdue
                            if ((icol - 1) < weekNow)
                            {
                                serviceNotOnTime++;
                                // make font bold for this week
                                dgv.Rows[irow].Cells[icol].Style.BackColor = pmoverduebgCol;
                                dgv.Rows[irow].Cells[icol].Style.Font = new Font("Calibra Light", 8, FontStyle.Bold);
                            }
                        }
                    }
                    else
                    {
                        // check if cell is not in use but had something scheduled:
                        if (dgv.Rows[irow].Cells[icol].Value != null)
                        {
                            dgv.Rows[irow].Cells[icol].Style.BackColor = notinusebgCol;
                        }

                    }

                    // now select next due date
                    dueDateNext = Utils.DetermineNextDate(dueDateNext, frequency);
                    dueWeekNo = Int16.Parse(Utils.GetWeekNo(dueDateNext));

                }
                else
                {
                    // check if cell is empty if so tehm make blank:
                    if (dgv.Rows[irow].Cells[icol].Value == null)
                    {
                        dgv.Rows[irow].Cells[icol].Style.BackColor = nopmgridcellbgCol;
                    }
                }
            }
        }


        /// <summary>
        /// for each row passed to this routine i.e. asset Cycles through Maint log and show on the cell for the date due teh week no done.
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="irow"></param>
        /// <param name="assetStartWeek"></param>
        /// <param name="freq"></param>
        private void DisplayMaintainedTasks(int irow)
        {
            // now attempt to extract maintenance log data and change color accordingly per equipment id
            string assetID;
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            DataRow[] returnRows;
            DataRow[] returnTasks;
            string[] splitReason;
            string testType = "";
            int totalMPM = 0;
            bool mpmItem = false;
            string[] splitItems;
            DateTime dateCompleted, dueDate;
            string reason = "";
            string taskStatus = "";
            int totMPM = totalMPM, weekJobDone, weekDue, prevWeekDue = 0;
            string cellVal = "";

            listA.Clear();
            // now the testtypes per week
            for (int icol = 2; icol < 55; icol++)
            {
                if (dgv.Rows[irow].Cells[icol].Value == null)
                {
                    listA.Add("");
                }
                else
                {
                    listA.Add(dgv.Rows[irow].Cells[icol].Value.ToString());
                }
            }
            assetID = dgv.Rows[irow].Cells[0].Value.ToString();
            listB.Clear();
            try
            {
                // fetch all logs for this asset id
                returnRows = dtbForLogs.Select("EquipmentID LIKE '%" + assetID + "%'");


                if (returnRows != null)
                {
                    foreach (DataRow dr in returnRows)
                    {
                        listB.Add(dr["Date"].ToString() + "~" + dr["Reason"].ToString() + "~"
                            + dr["Technician"].ToString() + "~" + dr["ActionTaken"].ToString() + "~" + dr["DateDue"].ToString() + "~" + dr["TaskStatus"].ToString());
                    }
                }
            }
            catch (Exception )
            {
                // MessageBox.Show(ex.Message);
            }


            // pass from datarow to list the log values





            foreach (string item in listB)
            {

                mpmItem = false;
                splitItems = item.Split('~');
                dateCompleted = DateTime.Parse(splitItems[0]);   // date completed
                reason = splitItems[1].ToUpper();
                splitReason = reason.Split();
                testType = TypeFromFrequency(splitReason[0]);
                dueDate = DateTime.Parse(splitItems[4]);// date that was due for job
                taskStatus = splitItems[5].ToUpper();
                weekJobDone = Int16.Parse(Utils.GetWeekNo(dateCompleted));  // week job was done
                weekDue = Int16.Parse(Utils.GetWeekNo(dueDate)); // week job was due

                // fetch all tasks for this asset id
                returnTasks = dtbForPMSched.Select("EquipmentID LIKE '%" + assetID + "%'");

                // count up number of tasks per letter this routine allows now for multiple same freq
                //foreach (DataRow dr in returnTasks)
                //{
                //    if (cellVal.Contains(dr["Frequency"].ToString().Substring(0, 1)))
                //    {
                //        totalMPM++;
                //    }
                //}

               // totalMPM = cellVal.Length;

                // check to see if this task has since been removed if so then add in to schedule

                if (dgv.Rows[irow].Cells[weekDue + 1].Value == null)
                {

                    if (cbNotScheduled.Checked)
                    {
                        dgv.Rows[irow].Cells[weekDue + 1].Value = "R" + testType;
                    }
                    else
                    {
                        dgv.Rows[irow].Cells[weekDue + 1].Value = "";
                    }
                }
                else
                {  // check to see if this task is not currently scheduled but may have been in the past.
                    if ((dgv.Rows[irow].Cells[weekDue + 1].Value.ToString().Contains(testType) == false) & (cbNotScheduled.Checked))
                    {
                        dgv.Rows[irow].Cells[weekDue + 1].Value = dgv.Rows[irow].Cells[weekDue + 1].Value + "R" + testType;
                    }
                }
                cellVal = dgv.Rows[irow].Cells[weekDue + 1].Value.ToString();


                // check to see if this is a reported cell.
                if (cellVal != "")
                {
                    cellVal = Utils.AlphaOnly(cellVal);
                    cellVal = cellVal.Replace("R", "");  //Strip out removed tasks for counter
                                                         // totmpm: this will indicated how many jobs allocated against this task this week from letters in cell

                    totalMPM = cellVal.Length;
                    //totalMPM =  ListOfTestTypes[weekDue-1].ToString().Length;  // did not work
                    // if (Utils.Num(dgv.Rows[irow].Cells[weekDue + 1].Value.ToString()) == 0)

                    // check to see if this has been marked as completed with a week no allocated, if not then check.
                    if (Utils.Num(listA[weekDue - 1].ToString()) == 0 || Utils.Num(listA[weekDue - 1].ToString()) == 6)
                    {
                        if (prevWeekDue != weekDue)
                        {
                            totMPM = totalMPM;
                        }

                        if (reason.Contains("WEEKLY MAINTENANCE FOR") & (taskStatus == "COMPLETED"))
                        {
                            mpmItem = true;
                            // if (prevWeekDue == weekDue)
                            {
                                totMPM--;
                            }
                        }
                        if (reason.Contains("FORTNIGHTLY MAINTENANCE FOR") & (taskStatus == "COMPLETED"))
                        {
                            mpmItem = true;
                            //  if (prevWeekDue == weekDue)
                            {
                                totMPM--;
                            }
                        }
                        if (reason.Contains("MONTHLY MAINTENANCE FOR") & (taskStatus == "COMPLETED") & !reason.Contains("6MONTHLY MAINTENANCE FOR"))
                        {
                            mpmItem = true;
                            //   if (prevWeekDue == weekDue)
                            {
                                totMPM--;
                            }
                        }
                        if (reason.Contains("QUARTERLY MAINTENANCE FOR") & (taskStatus == "COMPLETED"))
                        {
                            mpmItem = true;
                            //   if (prevWeekDue == weekDue)
                            {
                                totMPM--;
                            }
                        }

                        if (reason.Contains("6MONTHLY MAINTENANCE FOR") & (taskStatus == "COMPLETED"))
                        {
                            mpmItem = true;
                            //   if (prevWeekDue == weekDue)
                            {
                                totMPM--;
                            }
                        }

                        if (reason.Contains("YEARLY MAINTENANCE FOR") & (taskStatus == "COMPLETED"))
                        {
                            mpmItem = true;
                            if (prevWeekDue == weekDue)
                            {
                                totMPM--;
                            }
                        }

                        prevWeekDue = weekDue;



                        if ((weekJobDone < 53) & mpmItem)
                        {
                            // check to see if there are any outstanding jobs for asset on weekdue
                            if (totMPM > 0)
                            {
                                dgv.Rows[irow].Cells[weekDue + 1].Style.BackColor = pmoutstandingbgCol;
                                dgv.Rows[irow].Cells[weekDue + 1].Style.Font = new Font("Calibra Light", 8, FontStyle.Bold);
                            }
                            else
                            {
                                if (Int16.Parse(Utils.GetWeekNo(dateCompleted)) > weekDue)
                                {
                                    serviceNotOnTime++;
                                    dgv.Rows[irow].Cells[weekDue + 1].Style.BackColor = pmoverduebgCol;
                                    dgv.Rows[irow].Cells[weekDue + 1].Style.Font = new Font("Calibra Light", 8, FontStyle.Bold);
                                }
                                else
                                {
                                    // check for multiple same if all completed?

                                    serviceOnTime++;
                                    dgv.Rows[irow].Cells[weekDue + 1].Style.BackColor = pmcompletedbgCol;
                                    dgv.Rows[irow].Cells[weekDue + 1].Style.Font = new Font("Calibra Light", 8, FontStyle.Regular);
                                }
                                dgv.Rows[irow].Cells[weekDue + 1].Value = "(" + Utils.AlphaOnly(dgv.Rows[irow].Cells[weekDue + 1].Value.ToString()) + Utils.GetWeekNo(dateCompleted) + ")";  // GCS changed from DD MMM to week no EPED Request.
                                if (dgv.Rows[irow].Cells[weekDue + 1].Value.ToString().Contains("R"))
                                {
                                    dgv.Rows[irow].Cells[weekDue + 1].Style.BackColor = nolongerscheduledbgCol;
                                }

                            }

                            // all jobs done for this asset this week
                        }
                    }
                }  // end of week defined colours
            } // end loop of logs listd for asset

            // strip out duplicated cell  flags

            if (cbShowMultipleLetters.Checked == false)
            {
                string cellValUnique = "";
                for (int icol = 2; icol < 55; icol++)
                {
                    if (dgv.Rows[irow].Cells[icol].Value != null)
                    {
                        cellVal = dgv.Rows[irow].Cells[icol].Value.ToString();
                        cellValUnique = new string(cellVal.Distinct().ToArray());
                        dgv.Rows[irow].Cells[icol].Value = cellValUnique;
                    }
                }
            }
            lblNoOfRecords.Text = dgv.Rows.Count.ToString();
            Cursor.Current = Cursors.Default;

        } // end loop of list of assets listed.

        private string TypeFromFrequency(string freq)
        {
            string testType = "";

            switch (freq)
            {
                case "WEEKLY":
                    testType = testType + "W";
                    //if (assetStartWeek == 0)
                    //{
                    //    // will alsways be january first week 1
                    //    assetStartWeek = 1;
                    //}
                    break;
                case "FORTNIGHTLY":

                    testType = testType + "F";

                    break;
                case "MONTHLY":

                    testType = testType + "M";
                    break;
                case "QUARTERLY":

                    testType = testType + "Q";
                    break;
                case "6MONTHLY":

                    testType = testType + "6M";
                    break;
                case "YEARLY":

                    testType = testType + "Y";
                    break;
                default:

                    testType = testType + "W";
                    break;
            }

            return testType;


        }





        /// <summary>
        /// Complicated routine to display completed and scheduled maintenance items
        /// </summary>
        private async Task<bool> UpdateSchedulerDisplay()
        {
            try
            {
                string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
                DateTime datenow = DateTime.MinValue;
                DateTime assetStartDate;
                int yearNow, weekNow, irow, assetStartWeek = 0;
                bool inUse = true;
                bool newRow = false;
                bool displayAsset = true;
                DataRow dr;
                string filter = "";
                string freq = "WEEKLY";
                string assetID = "";
                string description = "";
                string groupAllocation = "";
                string location = "";
                string station = "";
                string siteName = "";
                int ServiceEfficiency = 100;  // percentage against KPI + values


                // initilaise variables.
                serviceCount = 0;
                serviceOnTime = 0;
                serviceNotOnTime = 0;
                Cursor.Current = Cursors.WaitCursor;


                // pre load the datatables to improve on speed.
                dtbForPMSched = DBUtils.FetchDBTableByFilter(dbCon, "tbl_pmschedule", filter);
                filter = LogFilterMatrix();
                dtbForLogs = DBUtils.FetchDBTableByFilter(dbCon, "tbl_assetlogs", filter);
                dtbForAssetRegister = DBUtils.FetchDBTable(dbCon, "tbl_assetregister");
                ShowLegendColors();
                // define color sceme for DGV
                dgv.BackgroundColor = nopmgridcellbgCol;

                // turn off redrawing method for grid to improve speed.
                SendMessage(dgv.Handle, WM_SETREDRAW, false, 0);

                // if there are no PM assets then leave.
                if (dtbForPMSched.Rows.Count == 0) { return true; }
                // initialise the dgv
                dgv.Rows.Clear();
                irow = -1;
                weekNow = Int16.Parse(Utils.GetWeekNo(DateTime.Now));
                yearNow = DateTime.Now.Year;

                // define week no cell text format:
                // dgv.Columns[weekNow + 1].DefaultCellStyle.BackColor = Color.Red;  gcs not set red only over due as oposed to due
                dgv.Columns[weekNow + 1].DefaultCellStyle.ForeColor = Color.Black;
                dgv.Columns[weekNow + 1].DefaultCellStyle.Font = new Font("Calibra Light", 8, FontStyle.Regular);

                // mark the column header blue
                dgv.Columns[weekNow + 1].HeaderCell.Style.BackColor = gridcurrentweekbgCol;
                dgv.EnableHeadersVisualStyles = false;
                // main loop for each PM asset in tbl_pmschedule
                int currentrow = 0;
                foreach (DataRow row in dtbForPMSched.Rows)
                {
                   
                        // initialise variable
                        displayAsset = true;
                        freq = row["Frequency"].ToString();
                        groupAllocation = row["GroupAllocation"].ToString();
                        // check to see if this next asset is a different one to add to scheduler
                        if (assetID != row["EquipmentID"].ToString())
                        { newRow = true; }
                        else
                        { newRow = false; }
                        // set to assetID 
                        assetID = row["EquipmentID"].ToString();
                        dr = dtbForAssetRegister.Select("EquipmentID LIKE '%" + assetID + "%'")[0];
                        description = dr["EquipmentDescription"].ToString();
                        siteName = dr["SiteName"].ToString();
                        location = dr["Location"].ToString();
                        station = dr["Station"].ToString();
                        if (dr["InUse"].ToString() == "1") { inUse = true; } else { inUse = false; };
                        // check groupallcoation,station/sitename for filtering
                        if ((cmbSiteName.Text != "ALL") && (cmbSiteName.Text != siteName)) { displayAsset = false; }
                        if ((cmbGroupAllocation.Text != "ALL") && (cmbGroupAllocation.Text != groupAllocation)) { displayAsset = false; }
                        if ((cmbStation.Text != "ALL") && (cmbStation.Text != station)) { displayAsset = false; }
                        // check when asset was introduced if in this year then what week
                        assetStartDate = Convert.ToDateTime("01/01/" + lblYear.Text);
                        assetStartWeek = 0;
                        if (row["StartDate"].ToString() != "")
                        {
                            assetStartDate = Convert.ToDateTime(row["StartDate"].ToString());
                            // check when asset was introduced if in this year then what week
                            if (assetStartDate.Year == Int16.Parse(lblYear.Text))
                            {

                                assetStartWeek = Int16.Parse(row["StartWeekNo"].ToString());
                            }
                        }
                        if (assetStartDate.Year > Int16.Parse(lblYear.Text)) { displayAsset = false; }

                        if (assetStartDate.Year < Int16.Parse(lblYear.Text))
                        {
                            int difYear = Int16.Parse(lblYear.Text) - assetStartDate.Year;
                            assetStartDate = assetStartDate.AddYears(difYear);
                        }

                        if (displayAsset)
                        {
                            // check to see if inuse only
                            if ((cbInUse.Checked == false) | ((cbInUse.Checked) & (inUse)))
                            {

                                // add new row if this is a new asset to DGV
                                if (newRow)
                                {
                                    dgv.Rows.Add();
                                    irow = irow + 1;
                                    dgv.Rows[irow].Cells[0].Value = assetID;
                                    dgv.Rows[irow].Cells[1].Value = description;
                                }

                                // determine the startweek no for the asset
                                if (assetStartWeek == 0)
                                {
                                    assetStartDate = Utils.DetermineStartDateForYear(assetStartDate, freq);
                                    assetStartWeek = Int16.Parse(Utils.GetWeekNo(assetStartDate));
                                    // trap if last week in year, occurs rarely, add a week
                                    if (assetStartWeek >= 52)
                                    {
                                        assetStartDate = assetStartDate.AddDays(7);
                                        assetStartWeek = 1;
                                    }
                                }
                                if (assetStartWeek != 0)
                                {
                                    DisplayScheduledTasks(irow, assetStartDate, freq, inUse);
                                }

                            }
                        }


                   

                    // turn on redrawing method 
                    SendMessage(dgv.Handle, WM_SETREDRAW, true, 0);
                    

                    if (serviceCount > 0)
                    {
                        ServiceEfficiency = serviceOnTime / serviceCount * 100;
                    }
                    

                    Cursor.Current = Cursors.Default;
                }
                // now cycle through logs and repalce with week Nos
                for (int i = 0; i < dtbForPMSched.Rows.Count; i++)
                    DisplayMaintainedTasks(i);

                dgv.Refresh();
                pnlKpi.Refresh();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            

        }

        private void DrawProgress(Graphics g, Rectangle rect, Single intval, Single inttotval, Color fgCol, int thickness = 2)
        {
            //work out the angles for each arc
            float percentage = (intval / inttotval * 100);
            float progressAngle = ((float)360 / 100 * percentage);
            Single remainderAngle = 360 - progressAngle;

            //create pens to use for the arcs

            using (Pen progressPen = new Pen(fgCol, thickness), remainderPen = new Pen(lightGray, thickness))
            {
                //set the smoothing to high quality for better output
                g.SmoothingMode = SmoothingMode.AntiAlias;

                //draw the blue and white arcs
                g.DrawArc(progressPen, rect, -90, progressAngle);
                g.DrawArc(remainderPen, rect, progressAngle - 90, remainderAngle);
            }

            //draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
            using (Font fnt = new Font(this.Font.FontFamily, 18, FontStyle.Bold))
            {
                string text = percentage.ToString("0") + "%";
                var textSize = g.MeasureString(text, fnt);
                Point textPoint = new Point(Convert.ToInt16(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), Convert.ToInt16(rect.Top + (rect.Height / 2) - (textSize.Height / 2)));
                //now we have all the values draw the text
                g.DrawString(text, fnt, Brushes.Black, textPoint);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }

        private async void Next_Button_Click(object sender, EventArgs e)
        {
            lblYear.Text = (Int16.Parse(lblYear.Text) + 1).ToString();
            if (btnCurrentPeriod.Text == "CURRENT YEAR") { CurrentYear = Int16.Parse(lblYear.Text); }
            await UpdateSchedulerDisplay();
            if (DateTime.Now.Year.ToString() != lblYear.Text)
            {
                lblEfficiency.Text = "Efficiency for year";
            }
            else
            {
                lblEfficiency.Text = "Efficiency to date for year";
            }
        }

        private void Prev_Button_Click(object sender, EventArgs e)
        {
            lblYear.Text = (Int16.Parse(lblYear.Text) - 1).ToString();
            Task<bool> task = UpdateSchedulerDisplay();
            if (DateTime.Now.Year.ToString() != lblYear.Text)
            {
                lblEfficiency.Text = "Efficiency for year";
            }
            else
            {
                lblEfficiency.Text = "Efficiency to date for year";
            }
        }


        private void DisplayCurrentPeriod()
        {

            lblYear.Text = DateTime.Now.Year.ToString();
            btnCurrentPeriod.Text = "CURRENT YEAR";
            dgv.FirstDisplayedScrollingColumnIndex = 2;
            lblEfficiency.Text = "Efficiency to date for year";
        }



        private void btnCurrentPeriod_Click(object sender, EventArgs e)
        {
            DisplayCurrentPeriod();
            Task<bool> task = UpdateSchedulerDisplay();
        }



        /// <summary>
        /// show details related to this part 
        /// </summary>
        /// <param name="rowSelected"></param>
        /// <param name="colSelected"></param>



        private void ShowPMDialogUser(int rowSelected, int colSelected)
        {

            string period = "";
            string equipmentID;
            Color cellColor;
            // is this a row select if so jump out here.
            if (colSelected <= 1) { return; }
            if (rowSelected == -1) { return; }
            cellColor = dgv.Rows[rowSelected].Cells[colSelected].Style.BackColor;
            if ((cellColor == Color.Empty) | (cellColor == nopmgridcellbgCol)) { return; }  // exit routine 

            try
            {
                equipmentID = "";
                equipmentID = dgv.Rows[rowSelected].Cells[0].Value.ToString();  // fetch first column
                period = btnCurrentPeriod.Text;
                period = period.Remove(0, 7);
                var f = new ShowPMDialogUser(dgv.Rows);


                f.SelectedEquipmentId = equipmentID;

                f.Description = dgv.Rows[rowSelected].Cells[1].Value.ToString();
                f.SelectedWeekNo = (colSelected - 1);
                f.TestType = dgv.Rows[rowSelected].Cells[colSelected].Value.ToString();
                f.SelectedYear = lblYear.Text;
                f.SiteName = cmbSiteName.Text;
                // showdialog sets form modal
                f.ShowDialog();
                Task<bool> task = UpdateSchedulerDisplay();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowPMDialogAdmin(int rowSelected, int colSelected)
        {

            string period = "";
            string equipmentID;
            Color cellColor;
            // is this a row select if so jump out here.
            if (colSelected == -1) { return; }
            cellColor = dgv.Rows[rowSelected].Cells[colSelected].Style.BackColor;
            if (cellColor == nopmgridcellbgCol) { return; }  // exit routine 

            try
            {
                equipmentID = "";
                equipmentID = dgv.Rows[rowSelected].Cells[0].Value.ToString();  // fetch first column
                period = btnCurrentPeriod.Text;
                period = period.Remove(0, 7);
                var f = new ShowPMDialogAdmin(dgv.Rows);
                f.SelectedEquipmentId = equipmentID;
                f.SiteName = cmbSiteName.Text;
                f.Description = dgv.Rows[rowSelected].Cells[1].Value.ToString();
                f.ShowDialog();
                Task<bool> task = UpdateSchedulerDisplay();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void rbdisplaybycal_CheckedChanged(object sender, EventArgs e)
        {
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void rbdisplaybyver_CheckedChanged(object sender, EventArgs e)
        {
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void rbdisplaybypat_CheckedChanged(object sender, EventArgs e)
        {
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void rbdisplaybyga_CheckedChanged(object sender, EventArgs e)
        {
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

        }

        private void cmbSiteName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbSiteName.Text = cmbSiteName.Items[cmbSiteName.SelectedIndex].ToString();
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) & (Globals.AccessLevel == 1))
            {

                if (e.RowIndex < 0) { return; }
                ShowPMDialogAdmin(e.RowIndex, e.ColumnIndex);
            }
            else
            {

                // todo ShowPMDialogUser(e.RowIndex, e.ColumnIndex);
                ShowPMDialogUser(e.RowIndex, e.ColumnIndex);

            }





        }

        private void cbInUse_CheckedChanged(object sender, EventArgs e)
        {
            // redraw DGV depending upn in use only or all, routine checks flag when run
            Task<bool> task = UpdateSchedulerDisplay();


        }

        private void cmbGroupAllocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbGroupAllocation.Text = cmbGroupAllocation.Items[cmbGroupAllocation.SelectedIndex].ToString();
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void cmbStation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbStation.Text = cmbStation.Items[cmbStation.SelectedIndex].ToString();
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void pnlKpi_Paint(object sender, PaintEventArgs e)
        {
            if (serviceCount == 0)
            {
                serviceCount = 100;
                serviceOnTime = 100;
                serviceNotOnTime = 0;
            }
            else
            {
                // caluculation based on all jobs to do as being on time
                //serviceOnTime = serviceCount - serviceNotOnTime;
                // calculation based on jobs to do date

                serviceCount = serviceOnTime + serviceNotOnTime;
                if (serviceCount == 0)
                {
                    serviceCount = 100;
                    serviceOnTime = 100;
                }

            }
            DrawProgress(e.Graphics, new Rectangle(5, 5, 85, 85), serviceOnTime, serviceCount, lightRed, 10);
        }

        private void AssetPMScheduleFrm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;

        }

        private void cbNotScheduled_CheckedChanged(object sender, EventArgs e)
        {
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void cbShowMultipleLetters_CheckedChanged(object sender, EventArgs e)
        {
            Task<bool> task = UpdateSchedulerDisplay();
        }

        private void cmbSiteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //'Site Name:' combobox
            cmbSiteName.Text = InputValidation.UserValidationInput(cmbSiteName.Text);
        }


        private void cmbGroupAllocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //'Equipment part of:' combobox
            cmbGroupAllocation.Text = InputValidation.UserValidationInput(cmbGroupAllocation.Text);
        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //'Station:' combobox
            cmbStation.Text = InputValidation.UserValidationInput(cmbStation.Text);
        }

  
    }
}
