using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPED
{
    public partial class ShowPMDialogUser : Form
    {
        DataTable dtbForTasks = new DataTable();
        DataTable dtbForPMAssets = new DataTable();
        DataTable dtbForLogs = new DataTable();
        DateTime tabDateDone;
        public DataGridViewRowCollection DataRows { get; set; }
        public string SelectedEquipmentId { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string Station { get; set; }
        public string AssetLocation { get; set; }
        public bool InUse { get; set; }
        public int SelectedWeekNo { get; set; }
        public string SelectedYear { get; set; }
        public DateTime StartDate { get; set; }

        public string TestType { get; set; }


        public ShowPMDialogUser()
        {
            InitializeComponent();
            
            CmbBoxPMTasksSelectionUser.Visible = false;
        }

        public ShowPMDialogUser(DataGridViewRowCollection dataRows)
        {
            InitializeComponent();
            DataRows = dataRows;
            foreach (DataGridViewRow row in DataRows)
            {
                

                CmbBoxPMTasksSelectionUser.Items.Add(row.Cells[0].Value.ToString());
            }
        }

        private void ShowPMDialogUser_Load(object sender, EventArgs e)
        {
            this.tbl_pmtasksTableAdapter.Fill(this.eped_db1DataSet.tbl_pmtasks);
            this.tbl_pmscheduleTableAdapter.FillByEquipmentID(this.eped_db1DataSet.tbl_pmschedule, SelectedEquipmentId);
            this.BackColor = Globals.defaultformsbgCol;
            RefreshData();
            UpdateHeadings();
            UpdateTabs();
        }


        private void RefreshData()
        {

            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string filter = " WHERE EquipmentID LIKE '%" + SelectedEquipmentId + "%';";
            // dtbForPMAssets = DBUtils.FetchDBTableByFilter(dbCon, "tbl_pmschedule", filter);
            // dtbForPMAssets = DBUtils.FetchDBTableByFilter(dbCon, "tbl_pmschedule", filter);
            dtbForTasks = DBUtils.FetchDBTable(dbCon, "tbl_pmtasks");
            SiteName = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "SiteName", "EquipmentID", SelectedEquipmentId, "", false);
            AssetLocation = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "Location", "EquipmentID", SelectedEquipmentId, "", false);
            Station = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "Station", "EquipmentID", SelectedEquipmentId, "", false);
            Description = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "EquipmentDescription", "EquipmentID", SelectedEquipmentId, "", false);
            if (DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "InUse", "EquipmentID", SelectedEquipmentId, "", false).ToString() == "1") { InUse = true; } else { InUse = false; };
        }

        private void UpdateHeadings()
        {
            lblWeek.Text = "WEEK " + SelectedWeekNo.ToString();
            // get first monday od the week of the year

            StartDate = Utils.FirstDateOfWeek(Int16.Parse(SelectedYear), SelectedWeekNo);
            DateTime EndDate = StartDate.AddDays(6);
            lblDateRange.Text = StartDate.ToString("dd/MM/yyyy") + "-" + EndDate.ToString("dd/MM/yyyy");
            lbEquipmentID.Text = SelectedEquipmentId;
            lbDescription.Text = Description;
            lbLocation.Text = AssetLocation + "," + SiteName;
            lbStation.Text = Station;
            if (Station != "") { lbStation.Text = "Part of " + Station + " equipment"; }
            if (InUse)
            {
                lbInUse.Text = "IN USE";
                lbInUse.ForeColor = Globals.lightGreen;
            }
            else
            {
                lbInUse.Text = "NOT IN USE";
                lbInUse.ForeColor = Globals.lightRed;
            }
            PositionLable(lbInUse, lblStatus);

            // display tabs for each task
            if (tbl_pmscheduleBindingSource.List.Count > 0)
            {
                if (tabControl1.TabPages.Count > 0)
                    tabControl1.TabPages.Clear();
                panel2.Visible = true;
                string task = "";
                string freq = frequencyLabel1.Text;
                foreach (DataRowView dr in tbl_pmscheduleBindingSource.List)
                {
                    task = dr["Task"].ToString();
                    freq = dr["Frequency"].ToString();
                    // check if selected testype has this frequency for this selected week.
                    if (freq.Length > 0)
                        if (TestType.Contains(freq.Substring(0, 1))) { tabControl1.TabPages.Add(task); }
                }


            }

            // check for removed task
            if (TestType.Contains("RW")) { tabControl1.TabPages.Add("RW"); }
            if (TestType.Contains("RF")) { tabControl1.TabPages.Add("RF"); }
            if (TestType.Contains("RM")) { tabControl1.TabPages.Add("RM"); }
            if (TestType.Contains("RQ")) { tabControl1.TabPages.Add("RQ"); }
            if (TestType.Contains("R6")) { tabControl1.TabPages.Add("R6"); }
            if (TestType.Contains("RY")) { tabControl1.TabPages.Add("RY"); }
            if (tabControl1.TabPages.Count == 0) { panel2.Visible = false; }




        }


        /// <summary>
        /// Routine to ensure we have correct day in week
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="selectedWeekNo"></param>
        /// <returns></returns>
        private DateTime SelectedDueDate(DateTime startDate, int selectedWeekNo, string freq)
        {
            DateTime dueDate = startDate;

            if (Int16.Parse(Utils.GetWeekNo(dueDate)) == selectedWeekNo)
            {
                return dueDate;
            }
            else
            {
                for (int i = 1; i < 53; i++)
                {
                    if (freq == "WEEKLY") { dueDate = dueDate.AddDays(7); }
                    if (freq == "FORTNIGHTLY") { dueDate = dueDate.AddDays(14); }
                    if (freq == "MONTHLY") { dueDate = dueDate.AddMonths(1); }

                    if (freq == "QUARTERLY") { dueDate = dueDate.AddMonths(3); }

                    if (freq == "6MONTHLY") { dueDate = dueDate.AddMonths(6); }
                    if (freq == "YEARLY") { dueDate = dueDate.AddYears(1); }
                    if (Int16.Parse(Utils.GetWeekNo(dueDate)) == selectedWeekNo)
                    {
                        return dueDate;
                    }

                }

            }
            // if not found return original startdate
            return StartDate;

        }






        private void UpdateTabs()
        {
            DateTime currentDueDate, dateDue;
            // if not tasks then jump out here
            if (tabControl1.TabPages.Count == 0)
            {
                tabControl1.Visible = false;
                panel2.Visible = false;
                return;
            }
            tabControl1.Visible = true;
            panel2.Visible = true;
            btnUpdate.Enabled = true;
           // trap if user not allowed to change not in use assets if required.. if (InUse) {btnUpdate.Enabled = true; } else { btnUpdate.Enabled = false; }
                    
            btnUpdate.Text = "Update";
            btnCancel.Enabled = false;
            tbAction.Enabled = false;
            perpetualNotesTextBox.Enabled = false;
            btnSubmitAndNotify.Visible = false;
            tbAction.Text = "";

            string task = tabControl1.SelectedTab.Text;
            tbl_pmscheduleBindingSource.Position = tbl_pmscheduleBindingSource.Find( "Task", task);
            string freq = frequencyLabel1.Text;
            freq = ((DataRowView)tbl_pmscheduleBindingSource.Current).Row["Frequency"].ToString();
            if (tabControl1.SelectedTab.Text == "RW") { freq = "WEEKLY"; }
            if (tabControl1.SelectedTab.Text == "RF") { freq = "FORTNIGHTLY"; }
            if (tabControl1.SelectedTab.Text == "RM") { freq = "MONTHLY"; }
            if (tabControl1.SelectedTab.Text == "RQ") { freq = "QUARTERLY"; }
            if (tabControl1.SelectedTab.Text == "R6") { freq = "6MONTHLY"; }
            if (tabControl1.SelectedTab.Text == "RY") { freq = "YEARLY"; }

            frequencyLabel1.Text = freq;
            // select the task
            //string task = tabControl1.SelectedTab.Text;

            // if (task.Contains("R") == false)
            {
                DateTime StartDueDate = Convert.ToDateTime(((DataRowView)tbl_pmscheduleBindingSource.Current).Row["StartDate"].ToString());
              //  currentStatusComboBox.Text = ((DataRowView)tbl_pmscheduleBindingSource.Current).Row["CurrentStatus"].ToString();
                currentDueDate = StartDueDate;
                if (StartDueDate.Year < Int16.Parse(SelectedYear))
                {
                    currentDueDate = StartDate.AddYears(Int16.Parse(SelectedYear) - StartDate.Year);
                }
                StartDueDate = SelectedDueDate(currentDueDate, SelectedWeekNo, freq);
                //  StartDueDate = Utils.DetermineStartDateForYear(StartDueDate, frequencyLabel1.Text);
                //  StartDueDate = StartDueDate.AddDays(7 * SelectedWeekNo);
                lbDueDate.Text = StartDueDate.ToString("dd/MM/yyyy");
                TimeSpan ts = StartDueDate - DateTime.Now;
                if (ts.Days > 0)
                {
                    lbDueInDays.Text = "Due in " + Math.Abs(ts.Days).ToString() + " days";
                    currentStatusComboBox.Text = "To Do";
                   currentStatusComboBox.ForeColor = Globals.coral;
                }
                if (ts.Days < 0)
                {
                    lbDueInDays.Text = "Overdue by " + Math.Abs(ts.Days).ToString() + " days";
                    currentStatusComboBox.Text = "Over due";
                    currentStatusComboBox.ForeColor = Globals.lightRed;
                    
                }

                if (ts.Days == 0)
                {
                   lbDueInDays.Text = "Due today " ;
                   currentStatusComboBox.Text = "Due now";
                   currentStatusComboBox.ForeColor = Globals.lightRed;
                }





                int index = tbl_pmtasksBindingSource.Find("Task", task);
                if (index < 0)
                {
                    // task not found hence blank out details
                    consequencesIfNotPerformedTextBox.Text = "- not found -";
                    perpetualNotesTextBox.Text = "- not found -";
                    lbInstructionLocation.Text = "";
                }
                else
                {
                    tbl_pmtasksBindingSource.Position = index;
                    tbl_pmtasksBindingSource.ResetBindings(false);
                    perpetualNotesTextBox.Refresh();
                   
                }
                tabControl1.Focus();
            }

            // check maint logs
            DateTime startWeekDate, endWeekDate, dateDone;
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            DataRow[] returnRows;
            startWeekDate = Convert.ToDateTime(lblDateRange.Text.Substring(0, 10));
            endWeekDate = startWeekDate.AddDays(7);
            string weekDone;
            string filter = " WHERE (YEAR(Date) = " + SelectedYear.ToString() + ") ORDER BY [Date];";
            filter = LogFilterMatrix();
            dtbForLogs = DBUtils.FetchDBTableByFilter(dbCon, "tbl_assetlogs", filter);
            returnRows = dtbForLogs.Select("(DateDue >= '" + startWeekDate + "') AND  " +
                "(DateDue < '" + endWeekDate + "') AND " +
                "(Reason LIKE '%" + freq + " MAINTENANCE FOR%')","Date ASC");

           

            if (returnRows.Length > 0)
            {
                foreach (DataRow dr in returnRows)
                {
                    task = dr["Reason"].ToString();
                    task = task.Substring((freq + " MAINTENANCE FOR ").Length);
                    if (tabControl1.SelectedTab.Text == task)
                    {
                        tbAction.Text = dr["ActionTaken"].ToString();
                        assignedTechLabel1.Text = dr["Technician"].ToString();
                        dateDone = Convert.ToDateTime(dr["Date"]);
                        tabDateDone = dateDone;
                        dateDue = Convert.ToDateTime(dr["DateDue"]);
                        weekDone = Utils.GetWeekNo(dateDone);
                        currentStatusComboBox.Text = dr["TaskStatus"].ToString();
                        lbDueInDays.Text = " "+ currentStatusComboBox.Text+" on " + dateDone.ToString("dd/MM/yyyy") + " week " + weekDone;
                        lbDueDate.Text = dateDue.ToString("dd/MM/yyyy");
                        frequencyLabel1.Text = freq;
                       
                        if (currentStatusComboBox.Text.ToUpper() == "COMPLETED")
                        {
                            currentStatusComboBox.ForeColor = Globals.lightGreen;
                        }
                        else
                        {
                            currentStatusComboBox.ForeColor = Globals.coral;
                        }

                        //SaveStatusToTask(currentStatusComboBox.Text);
                        //PositionTaskStatus();
                        tbAction.Enabled = false;
                        //btnUpdate.Enabled = false;
                        btnCancel.Enabled = false;
                        btnSubmitAndNotify.Visible = false;
                    }

                } // end for each
            }
            // sort out padding for task status combo box
            PositionTaskStatus();
            //if (tbAction.Text == "")
            //{
            //    // extract from current task status
            //   // currentStatusComboBox.Text = "To do";
            //    // currentStatusComboBox.ForeColor = Globals.coral;
            //    //SaveStatusToTask(currentStatusComboBox.Text);
            //}


        }


        private string LogFilterMatrix()
        {
            string filter = "";
            string partfilter = "";
            string siteFilter = SiteName;


            if (partfilter == "")
            {
                partfilter = partfilter + " (YEAR(Date) = " + SelectedYear + ")";
            }
            else
            {
                partfilter = partfilter + " AND (YEAR(Date) = " + SelectedYear + ")";
            }

            if ((siteFilter != "ALL") && (siteFilter != ""))
            {
                partfilter = partfilter + " AND (SiteName = '" + SiteName + "')";
            }

            if (SelectedEquipmentId != "")
            {
                partfilter = partfilter + " AND (EquipmentID = '" + SelectedEquipmentId + "')";
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




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbInstructionLink_Click(object sender, EventArgs e)
        {
            // run the path for isntruction as process.
            if (lbInstructionLocation.Text == "")
            {
                MessageBox.Show("No instructions for this task!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                Process.Start(lbInstructionLocation.Text);
            }


        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            // move the update button
            btnUpdate.Left = panel1.Width / 2 - btnUpdate.Width / 2;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = -1;
            if(tabControl1.TabPages.Count != 0)
            {
                string task = tabControl1.SelectedTab.Text;

                index = tbl_pmscheduleBindingSource.Find("Task", task);
                // udpate dates for task selected
                if (index >= 0)
                {
                    // move to selected task
                    tbl_pmscheduleBindingSource.Position = index;
                }

                // update task details
                index = tbl_pmtasksBindingSource.Find("Task", task);
                if (index >= 0)
                {
                    // move to selected task
                    tbl_pmtasksBindingSource.Position = index;
                }
                UpdateTabs();
            }

        }

        private bool UpdateLogRecords(string freq)
        {
            // string dateFormat = "MM/dd/yyyy hh:mm:ss";
            string task = tabControl1.SelectedTab.Text;
            string dateFormat = "yyyy-MM-dd hh:mm:ss";
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string sql = "INSERT INTO tbl_assetlogs (EquipmentID,SiteName,Date,DateDue,Technician,Reason,ActionTaken,Comments,TaskStatus) VALUES ('" +
                              SelectedEquipmentId + "','" + SiteName + "',";


            {
                sql = sql + "'" + DateTime.Now.ToString(dateFormat) + "'," +
                            "'" + Convert.ToDateTime(lbDueDate.Text).ToString(dateFormat) + "'," +
                            "'" + assignedTechLabel1.Text + "',";
                string pmaint = freq + " MAINTENANCE FOR " + task;
                // update log datatbase table
                sql = sql + "'" + pmaint + "'," +
                          "'" + tbAction.Text + "'," +
                          "'" + "" + "',"+ "'" +currentStatusComboBox.Text + "')" +
                          ";";
            }

            {
                if (DBUtils.ExecuteSqlCmdInDB(dbCon, sql, false)) { return true; } else { return false; }
            }
        }


        private bool UpdateperpetualNotes()
        {
            bool retval = true;
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string task = tabControl1.SelectedTab.Text;
            string filter = "WHERE Task = '" + task + "'";
            retval = DBUtils.UpdateDataToTableFields(dbCon, "tbl_pmtasks", "PerpetualNotes", "'"+perpetualNotesTextBox.Text+"'", filter, false);
            return retval;

        }





        private bool UpdateRecords()
        {
            // check notes have been written
            if (tbAction.Text.Length < 5)
            {
                MessageBox.Show("No completion notes have been written!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (tbAction.Text.Contains('~'))//we use this character later to split the string for loading tasks. do not change that without changing DisplayMaintainedTasks() method. 
            {
                MessageBox.Show("Illegal character in the Task Completion Notes: ~. Please replace ~ character, it will be bad otherwise!!!");
                return false;
            }
            // update perpetual notes
            if (perpetualNotesTextBox.Enabled)
            {
                UpdateperpetualNotes();
            }

            // add to maintenance logs
            string freq = frequencyLabel1.Text;
            if (currentStatusComboBox.Text.ToUpper() == "TO DO")
            {
                currentStatusComboBox.Text = "Completed";
                currentStatusComboBox.ForeColor = Globals.lightGreen;
            }
            bool retVal = UpdateLogRecords(freq);

            if (retVal == false)
            {
                MessageBox.Show("Failed to update Maintenance log!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                tbAction.Enabled = false;
                perpetualNotesTextBox.Enabled = false;
                btnSubmitAndNotify.Visible = false;
                btnCancel.Enabled = false;
                PositionTaskStatus();
                return true;
            }
     





        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                btnCancel.Enabled = true;
                tbAction.Enabled = true;
                btnSubmitAndNotify.Visible = true;
                perpetualNotesTextBox.Enabled = true;
                currentStatusComboBox.Enabled = true;
                btnUpdate.Text = "Submit";
            }
            else
            {
                UpdateRecords();
                btnUpdate.Text = "Update";
            }
           
        }

        private void lblWeek_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Text = "Update";
            btnCancel.Enabled = false;
            btnSubmitAndNotify.Visible = false;
            perpetualNotesTextBox.Enabled = false;
            tbAction.Text = "";
            perpetualNotesTextBox.Text = "";
            this.tbl_pmtasksTableAdapter.Fill(this.eped_db1DataSet.tbl_pmtasks);
            UpdateTabs();
        }

        private void btnSubmitAndNotify_Click(object sender, EventArgs e)
        {
            if (UpdateRecords())
            {
                string task = tabControl1.SelectedTab.Text;
                string subject = "Preventative maintenance on asset: " + SelectedEquipmentId;
                string body = "Allocated to: " + assignedTechLabel1.Text + "%0d%0A" +
                     "Task: " + task + "%0d%0A" +
                     "Frequency: " + frequencyLabel1.Text + "%0d%0A" +
                     "Asset description: " + lbDescription.Text + "%0d%0A" +
                     "Service due: " + lbDueDate.Text + "%0d%0A" + "%0d%0A" +
                     "Completion notes:" + "%0d%0A" +
                     tbAction.Text;
                Utils.OpenEmail("", subject, body);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblDateRange_Click(object sender, EventArgs e)
        {

        }

        private bool SaveStatusToTask(string status)
        {
            bool retVal = true;
            if (status == "") { return retVal; }


            try
            {
             string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string task = tabControl1.SelectedTab.Text;
            string filter = "WHERE Task = '" + task + "' AND EquipmentID LIKE '"+SelectedEquipmentId+"' AND StartWeekNo = "+startWeekNoTextBox.Text;
            retVal = DBUtils.UpdateDataToTableFields(dbCon, "tbl_pmschedule", "CurrentStatus", "'" + status + "'", filter, false);
            return retVal;
            }
            catch
            {
                return false;
            }
            
        }

        private bool SaveTaskStatusToLogs(string status)
        {
            bool retVal = true;
            if (status == "") { return retVal; }


            try
            {
                string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
                string task = tabControl1.SelectedTab.Text;
                string dateFormat = "yyyy-MM-dd hh:mm:ss";
                string filter = "WHERE Date = '" + tabDateDone.ToString(dateFormat) + "' AND EquipmentID LIKE '" + SelectedEquipmentId+"'";
                retVal = DBUtils.UpdateDataToTableFields(dbCon, "tbl_assetlogs", "TaskStatus", "'" + status + "'", filter, false);
                return retVal;
            }
            catch
            {
                return false;
            }

        }




        private int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

        private void PositionLable(Label lbl,  Label reflbl)
        {

            Graphics g = lbl.CreateGraphics();
           
            Font font = lbl.Font;
            lbl.Width = (int)g.MeasureString(lbl.Text, font).Width + 20;
            lbl.Left = reflbl.Left+reflbl.Width - lbl.Width;

        }



        private void PositionTaskStatus()
        {

            Graphics g = currentStatusComboBox.CreateGraphics();
            string status = currentStatusComboBox.Text;
            Font font = currentStatusComboBox.Font;
            currentStatusComboBox.Width = (int)g.MeasureString(status, font).Width + 20;
            currentStatusComboBox.Left = startWeekNoTextBox.Left - currentStatusComboBox.Width;
            currentStatusComboBox.DropDownWidth = DropDownWidth(currentStatusComboBox) + 20;
            //currentStatusComboBox.SelectionLength = 0;

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          


        }

        private void currentStatusComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
             if (currentStatusComboBox.SelectedIndex == 0) currentStatusComboBox.ForeColor = Globals.coral;     // todo
            if (currentStatusComboBox.SelectedIndex == 1) currentStatusComboBox.ForeColor = Globals.lightGreen;  // completed
            if (currentStatusComboBox.SelectedIndex == 2) currentStatusComboBox.ForeColor = Globals.coral;   // inprogress
            if (currentStatusComboBox.SelectedIndex == 3) currentStatusComboBox.ForeColor = Globals.coral;  // issue during maintenance
            if (tabControl1.SelectedTab != null)
            {
                currentStatusComboBox.Text = currentStatusComboBox.Items[currentStatusComboBox.SelectedIndex].ToString();
                
                //SaveStatusToTask(currentStatusComboBox.Text);
                if (tbAction.Text != "")
                {
                    // save to maintenance log
                    SaveTaskStatusToLogs(currentStatusComboBox.Text);
                    
                }
                else
                {
                    MessageBox.Show("Click update to save this Task status change with details in task completion notes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            PositionTaskStatus();
            //currentStatusComboBox.SelectionLength = 0;
        }

        private void lbInstructionLink_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void lbInstructionLink_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void lblInstructionLink_MouseHover(object sender, EventArgs e)
        {
           // lblInstructionLink.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblInstructionLink_MouseEnter(object sender, EventArgs e)
        {
            lblInstructionLink.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblInstructionLink_MouseLeave(object sender, EventArgs e)
        {
            lblInstructionLink.BorderStyle = BorderStyle.None;
        }

        private void currentStatusComboBox_MouseLeave(object sender, EventArgs e)
        {
            currentStatusComboBox.SelectionLength = 0;
        }

        //'Close' button
        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.ForeColor = Globals.selectBtnfgCol;
            btnClose.BackColor = Color.LightCoral;
        }

        //'Close' button
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
           
        }


        private void CmbBoxPMTasksSelectionUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEquipmentId = CmbBoxPMTasksSelectionUser.SelectedItem.ToString();
            ShowPMDialogUser_Load(this, new EventArgs());
        }

        private void lblPMFor_Click(object sender, EventArgs e)
        {

        }
    }
}
