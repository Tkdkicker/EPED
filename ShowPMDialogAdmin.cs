using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPED
{
    public partial class ShowPMDialogAdmin : Form
    {
        DataTable dtbForTasks = new DataTable();
        DataTable dtbForPMAssets = new DataTable();
        public DataGridViewRowCollection DataRows { get; set; }
        public string SelectedEquipmentId { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string Station { get; set; }
        public string AssetLocation { get; set; }
        public bool InUse { get; set; }
        public ShowPMDialogAdmin()
        {
            InitializeComponent();
            CmbBoxPMTasksSelection.Visible = false;
        }
        public ShowPMDialogAdmin(DataGridViewRowCollection dataRows)
        {
            InitializeComponent();
            DataRows = dataRows;
            
            foreach (DataGridViewRow row in DataRows)
            {
                CmbBoxPMTasksSelection.Items.Add(row.Cells[0].Value.ToString());
            }
        }


        private void RefreshData()
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            SiteName = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "SiteName", "EquipmentID", SelectedEquipmentId, "", false);
            AssetLocation = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "Location", "EquipmentID", SelectedEquipmentId, "", false);
            Station = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "Station", "EquipmentID", SelectedEquipmentId, "", false);
            Description = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "EquipmentDescription", "EquipmentID", SelectedEquipmentId, "", false);
            if (DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "InUse", "EquipmentID", SelectedEquipmentId, "", false).ToString() == "1") { InUse = true; } else { InUse = false; };

            // show details
            lbDescription.Text = Description;
            lbEquipmentID.Text = SelectedEquipmentId;

            // need to make follwing combo lists GCS todo
            lbLocation.Text = AssetLocation + "," + SiteName;
            lbStation.Text = Station;
            if (Station != "") { lbStation.Text = "Part of " + Station + " equipment"; }

            // display message if no tasks schedules.
            if (tbl_pmscheduleDataGridView.Rows.Count > 0)
            {
                lbNoTasks1.Visible = false;
                lbNoTasks2.Visible = false;
            }
            else
            {
                lbNoTasks1.Visible = true;
                lbNoTasks2.Visible = true;
            }

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


        }



        private void ShowPMDialogAdmin_Load(object sender, EventArgs e)
        {
            this.tbl_pmscheduleTableAdapter.FillByEquipmentID(this.eped_db1DataSet.tbl_pmschedule, SelectedEquipmentId);
            estimatedDownTimePicker1.CustomFormat = "HH: mm:ss";
            tbl_pmscheduleDataGridView.Refresh();
           
            
            this.tbl_pmtasksTableAdapter.FillByTask(this.eped_db1DataSet.tbl_pmtasks, taskTextBox.Text);
            this.BackColor = Globals.defaultformsbgCol;
            UpdateComboBoxes();
            RefreshData();
            if (Globals.DefUser == "Admin") { tbl_pmscheduleBindingNavigator.Visible = true; } else { tbl_pmscheduleBindingNavigator.Visible = false; }
            //  DisplayDGV();
            this.estimatedDownTimePicker1.Value = DateTime.Today;
            startDateDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            estimatedDownTimePicker1.CustomFormat = "dd/MMM/yyyy";
        }


        private void UpdateComboBoxes()
        {

            List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            valuelist = DBUtils.FetchListOfUsers(dbCon, "tbl_users");
            valuelist.Sort();
            assignedTechComboBox.Items.Clear();
            assignedTechComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "EstimatedDownTime");
            valuelist.Sort();
            //estimatedDownTimeComboBox.Items.Clear();
            //estimatedDownTimeComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "Location");
            valuelist.Sort();
            locationComboBox.Items.Clear();
            locationComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmschedule", "GroupAllocation");
            valuelist.Sort();
            groupAllocationComboBox.Items.Clear();
            groupAllocationComboBox.Items.AddRange(valuelist.ToArray());


        }



        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (tbl_pmscheduleDataGridView.SelectedRows.Count == 0) { MessageBox.Show("Select row first"); return; }
            int rIndex = tbl_pmscheduleDataGridView.SelectedRows[0].Index;
            string selTask = taskTextBox.Text;

            DateTime startDate = Convert.ToDateTime(startDateDateTimePicker.Value.ToString());

            DialogResult response = MessageBox.Show("Are you sure you want to remove task " + selTask + "?", "Removing a task", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                // remove the task,tech and duedate from the database
                RemoveTaskFromScheduler(selTask, startDate);
                this.tbl_pmscheduleTableAdapter.FillByEquipmentID(this.eped_db1DataSet.tbl_pmschedule, SelectedEquipmentId);

            }
        }

        private void InsertTaskPMScheduler(string task, string startWeekNo, string values)
        {


            if ((task != "") && (startWeekNo != "") && (values != ""))
            {
                string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
                string sql = "INSERT INTO tbl_pmschedule (EquipmentID,Task,StartWeekNo)" +
                "VALUES ('" + SelectedEquipmentId + "','" + task + "'," + startWeekNo + ");";

                DBUtils.ExecuteSqlCmdInDB(dbCon, sql, false);
            }


        }



        /// <summary>
        /// Dialog adds to the DGV a new roe, this routine adds the other details to pkey t,f,s
        /// </summary>
        /// <param name="task"></param>
        /// <param name="frequency"></param>
        /// <param name="startWeekNo"></param>
        /// <param name="values"></param>
        private void UpdatePMScheduler(string task, string startWeekNo, string values)
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string Fields = "AssignedTech,Frequency,StartDate,GroupAllocation";
            DBUtils.UpdateDataToTableFields(dbCon, "tbl_pmschedule", Fields, values,
                "WHERE EquipmentID = '" + SelectedEquipmentId + "' AND Task = '" + task + "' AND StartWeekNo = " + startWeekNo);
            // update the mainassets with teh station value from glruoup allocation
            DBUtils.UpdateDataToTableFields(dbCon, "tbl_assetregister", "Station", "'" + Station + "'", "WHERE EquipmentID = '" + SelectedEquipmentId + "'", false);

        }

        private void RemoveTaskFromScheduler(string task, DateTime startDate)
        {
            string dateFormat = "yyyy-MM-dd hh:mm:ss";
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string sqlCommand = "DELETE FROM  tbl_pmschedule WHERE EquipmentID = '" + SelectedEquipmentId + "' AND Task = '" + task + "' AND StartDate = '" + startDate.ToString(dateFormat) + "';";
            DBUtils.ExecuteSqlCmdInDB(dbCon, sqlCommand);

        }



        private void SelectPMTasks()
        {
            // check to see if already open somewhere
            string dateFormat = "yyyy-MM-dd hh:mm:ss";
            var m = new SelectTasksDialog();
            m.AssetID = SelectedEquipmentId;
            m.ReturnToSelect = false;
            m.ShowDialog();
            if (m.DialogResult == DialogResult.OK)
            {
                // store fields against this assett
                // then udpate teh data and DGV
                string startWeekNo = Utils.GetWeekNo(m.StartDate);
                string values = "'" + m.TechAssigned + "','" + m.Frequency + "','" + m.StartDate.ToString(dateFormat) + "','" + m.GroupAllocation + "'";
                string freq = m.Frequency;
                string groupAllocation = m.GroupAllocation;
                Station = m.GroupAllocation;
                //// check that there is not same freq and weekno already in place if so advise create joint tasks for thsi freq.
                //int startWeekCur = Utils.DetermineStartWeekNo(m.StartDate, freq);
                // Insert new task, if task is already there jump out on excecption error.
                try
                {
                    InsertTaskPMScheduler(m.Task, startWeekNo, values);
                }
                catch
                {
                    MessageBox.Show("There is already a named task existing \nModify this task or create a new unique task name", "Information");
                }
                // udpate with the remainder values collected.
                UpdatePMScheduler(m.Task, startWeekNo, values);
                this.tbl_pmscheduleTableAdapter.FillByEquipmentID(this.eped_db1DataSet.tbl_pmschedule, SelectedEquipmentId);
                //RefreshData();


            }


        }





        private void btnAddTask_Click(object sender, EventArgs e)
        {
            SelectPMTasks();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void lbEquipmentID_DoubleClick(object sender, EventArgs e)
        {
            // make changes re Group allcoation etc

            var m = new SelectTasksDialog();
            m.ShowDialog();
            if (m.DialogResult == DialogResult.OK)
            {

            }
        }


        private void btnClose_click(object sender, EventArgs e)
        {
            //SavePMSchedule();
            Close();
        }


        private bool SavePMSchedule()
        {

            try
            {
                this.Validate();
                this.tbl_pmtasksBindingSource.EndEdit();
                this.tbl_pmscheduleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }



        }



        private void tbl_pmscheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //'pmtasks tbl Task:' combobox
            estimatedDownTimeComboBox.Text = InputValidation.UserValidationInput(estimatedDownTimeComboBox.Text);

            //'Location:' combobox
            locationComboBox.Text = InputValidation.UserValidationInput(locationComboBox.Text);

            //'Assignee:' combobox
            assignedTechComboBox.Text = InputValidation.UserValidationInput(assignedTechComboBox.Text);

            //'Frequency:' combobox
            frequencyComboBox.Text = InputValidation.UserValidationInput(frequencyComboBox.Text);

            //'Group Allocation:' combobox
            groupAllocationComboBox.Text = InputValidation.UserValidationInput(groupAllocationComboBox.Text);

            SavePMSchedule();

        }

        private void tbl_pmscheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //this.tbl_pmtasksTableAdapter.FillByTask(this.eped_db1DataSet.tbl_pmtasks, taskTextBox.Text);
        }

        private void taskTextBox_TextChanged(object sender, EventArgs e)
        {
            // called every letter presseda as a change
            if (taskTextBox.Text != "")
            {
                this.tbl_pmtasksTableAdapter.FillByTask(this.eped_db1DataSet.tbl_pmtasks, taskTextBox.Text);
            }

        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (btnEditTask.Text == "Edit task")
            {
                assignedTechComboBox.Enabled = true;
                startDateDateTimePicker.Enabled = true;
                frequencyComboBox.Enabled = true;
                perpetualNotesTextBox.Enabled = true;
                consequencesIfNotPerformedTextBox.Enabled = true;
                linkToInstructionTextBox.Enabled = true;
                estimatedDownTimeComboBox.Enabled = true;
                locationComboBox.Enabled = true;
                groupAllocationComboBox.Enabled = true;
                btnEditTask.Text = "Submit";
                btnAddTask.Enabled = false;
                btnRemove.Enabled = false;
                btnAddNewTask.Enabled = false;
            }
            else
            {
                assignedTechComboBox.Enabled = false;
                startDateDateTimePicker.Enabled = false;
                frequencyComboBox.Enabled = false;
                perpetualNotesTextBox.Enabled = false;
                consequencesIfNotPerformedTextBox.Enabled = false;
                estimatedDownTimeComboBox.Enabled = false;
                linkToInstructionTextBox.Enabled = false;
                locationComboBox.Enabled = false;
                groupAllocationComboBox.Enabled = false;
                btnEditTask.Text = "Edit task";
                btnAddTask.Enabled = true;
                btnRemove.Enabled = true;
                btnAddNewTask.Enabled = true;
                SavePMSchedule();
            }
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {

            if (btnAddNewTask.Text == "Add new task")
            {
                btnAddNewTask.Text = "Save to database";
                taskTextBox.Enabled = true;
                assignedTechComboBox.Enabled = true;
                startDateDateTimePicker.Enabled = true;
                frequencyComboBox.Enabled = true;
                perpetualNotesTextBox.Enabled = true;
                estimatedDownTimeComboBox.Enabled = true;
                linkToInstructionTextBox.Enabled = true;
                consequencesIfNotPerformedTextBox.Enabled = true;
                locationComboBox.Enabled = true;
                groupAllocationComboBox.Enabled = true;
                tbl_pmscheduleBindingSource.AddNew();
                lbEquipmentID.Text = SelectedEquipmentId;
                startDateDateTimePicker.Value = DateTime.Now;
                startWeekNoTextBox.Text = Utils.GetWeekNo(DateTime.Now);
                frequencyComboBox.Text = "WEEKLY";
                btnAddTask.Enabled = false;
                btnRemove.Enabled = false;
                btnEditTask.Enabled = false;

            }
            else
            {

                // check that you have loaded assignee at least
                if (assignedTechComboBox.Text == "")
                {
                    MessageBox.Show("Entries Missing \nAdd at least the assignee","Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (SavePMSchedule())
                {
                    taskTextBox.Enabled = false;
                    assignedTechComboBox.Enabled = false;
                    startDateDateTimePicker.Enabled = false;
                    frequencyComboBox.Enabled = false;
                    perpetualNotesTextBox.Enabled = false;
                    estimatedDownTimeComboBox.Enabled = false;
                    linkToInstructionTextBox.Enabled = false;
                    consequencesIfNotPerformedTextBox.Enabled = false;
                    locationComboBox.Enabled = false;
                    groupAllocationComboBox.Enabled = false;
                    btnAddNewTask.Text = "Add new task";
                    btnAddTask.Enabled = true;
                    btnRemove.Enabled = true;
                    btnEditTask.Enabled = true;
                }
                else
                {
                    var retVal = MessageBox.Show("Do you wish to rename the task\nor cancel this operation", "Error in operation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (retVal==DialogResult.Cancel)
                    {
                        taskTextBox.Enabled = false;
                        assignedTechComboBox.Enabled = false;
                        startDateDateTimePicker.Enabled = false;
                        frequencyComboBox.Enabled = false;
                        perpetualNotesTextBox.Enabled = false;
                        estimatedDownTimeComboBox.Enabled = false;
                        linkToInstructionTextBox.Enabled = false;
                        consequencesIfNotPerformedTextBox.Enabled = false;
                        locationComboBox.Enabled = false;
                        groupAllocationComboBox.Enabled = false;
                        btnAddNewTask.Text = "Add new task";
                        btnAddTask.Enabled = true;
                        btnRemove.Enabled = true;
                        btnEditTask.Enabled = true;
                        this.tbl_pmscheduleTableAdapter.FillByEquipmentID(this.eped_db1DataSet.tbl_pmschedule, SelectedEquipmentId);
                    }

                }
            }
        }

        private void taskTextBox_Validated(object sender, EventArgs e)
        {
            // check to see if already have this tasks.
            if(taskTextBox1.Text == "")
            {
                this.tbl_pmtasksBindingSource.AddNew();
                taskTextBox1.Text = taskTextBox.Text;
            }
            else
            {
                MessageBox.Show("This task is already set up saving will overwrite current task settings", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        private void PositionLable(Label lbl, Label reflbl)
        {

            Graphics g = lbl.CreateGraphics();

            Font font = lbl.Font;
            lbl.Width = (int)g.MeasureString(lbl.Text, font).Width + 20;
            lbl.Left = reflbl.Left + reflbl.Width - lbl.Width;

        }
        private void startDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startWeekNoTextBox.Text = Utils.GetWeekNo(startDateDateTimePicker.Value);
            
        }

        private void tbl_pmscheduleBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        //'Add new task' button
        private void btnAddNewTask_MouseMove(object sender, MouseEventArgs e)
        {
            btnAddNewTask.ForeColor = Globals.selectBtnfgCol;
            btnAddNewTask.BackColor = Color.LightCoral;
        }

        //'Add new task' button
        private void btnAddNewTask_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewTask.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnAddNewTask.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'Add existing' button
        private void btnAddTask_MouseMove(object sender, MouseEventArgs e)
        {
            btnAddTask.ForeColor = Globals.selectBtnfgCol;
            btnAddTask.BackColor = Color.LightCoral;
        }

        //'Add existing' button
        private void btnAddTask_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewTask.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnAddNewTask.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'Remove task' button
        private void btnRemove_MouseMove(object sender, MouseEventArgs e)
        {
            btnRemove.ForeColor = Globals.selectBtnfgCol;
            btnRemove.BackColor = Color.LightCoral;
        }

        //'Remove task' button
        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRemove.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnRemove.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'Edit task' button
        private void btnEditTask_MouseMove(object sender, MouseEventArgs e)
        {
            btnEditTask.ForeColor = Globals.selectBtnfgCol;
            btnEditTask.BackColor = Color.LightCoral;
        }

        //'Edit task' button
        private void btnEditTask_MouseLeave(object sender, EventArgs e)
        {
            btnEditTask.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnEditTask.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'CLOSE' button
        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.ForeColor = Globals.selectBtnfgCol;
            btnClose.BackColor = Color.LightCoral;
        }

        //'CLOSE' button
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnClose.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEquipmentId = CmbBoxPMTasksSelection.SelectedItem.ToString();
            ShowPMDialogAdmin_Load(this,new EventArgs());
        }
    }
}
