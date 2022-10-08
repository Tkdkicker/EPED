using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EPED
{

    public partial class ShowMaintDialog : Form
    {
        // variables passed through

        public string SelectedEquipmentId { get; set; }
        public int SelectedWeekNo { get; set; }
        public int SelectedYear { get; set; }
        public string SelectedPeriod { get; set; }
        public string SelectedGroup { get; set; }
        public string SelectedWorkOrder { get; set; }

        public ShowMaintDialog()
        {
            InitializeComponent();
        }



        private void MaintDialog_Load(object sender, EventArgs e)
        {
            this.tbl_assetlogsTableAdapter.Fill(this.eped_db1DataSet.tbl_assetlogs);
            if (Globals.AccessLevel > 2)
            {
                btnSave.Enabled = false;
                btnAddNew.Enabled = false;
                panel3.Enabled = false;
            }
            DisplayRecords();
            UpdateComBoxes();
            this.WindowState = FormWindowState.Normal;

            DateDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            dateCalibrationDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            dtpNextDueDate.CustomFormat = "dd/MMM/yyyy";
        }

        private void UpdateComBoxes()
        {
            DataTable dtb = new DataTable();
            List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            workOrderNoComboBox.Items.Clear();
            if (equipmentIDTextBox.Text != "")
            {
                string filter = " WHERE AssetID LIKE '%" + equipmentIDTextBox.Text + "%'  ORDER BY DateJobAllocated";
                dtb = DBUtils.FetchDBTableByFilter(dbCon, "tbl_worksorders", filter);
                foreach (DataRow item in dtb.Rows)
                {
                    valuelist.Add(item["JobIdNo"].ToString());
                }
                valuelist.Reverse();
                workOrderNoComboBox.Items.AddRange(valuelist.ToArray());

                valuelist = DBUtils.FetchListOfUsers(dbCon, "tbl_users");
                technicianComboBox.Items.Clear();
                technicianComboBox.Items.AddRange(valuelist.ToArray());
            }
        }





        private void DisplayRecords()
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            DataTable dtb = new DataTable();
            int reccnt, noofrecs, intervalWeeks;
            DateTime schedDate, nextSchedDate, ddate;
            string dateStr = "1/1/" + SelectedYear;
            string sqlQuery = "";
            string value, cValue = "";

            lbInterval.Text = "-----";


            string filter = " WHERE EquipmentID LIKE '%" + SelectedEquipmentId + "%'";
            // update the selected equipment id to the next due date here   GCS todo
            dtb = DBUtils.FetchDBTableByFilter(dbCon, "tbl_assetregister", filter);
            // determeine fields from selected equipment

            value = dtb.Rows[0]["CalibrationRequired"].ToString();
            if (value == "1")
            {
                cValue = dtb.Rows[0]["DateCalibrationDue"].ToString();
                rbCalibReq.Checked = true;
                if (cValue == "") { cValue = DateTime.Now.ToShortDateString(); }
                ddate = Convert.ToDateTime(cValue);
                dateCalibrationDueDateTimePicker.Value = ddate;
                cValue = dtb.Rows[0]["CalibrationInterval"].ToString();
                lbInterval.Text = cValue;
                intervalWeeks = Utils.ConvertToWeeks(cValue);
                nextSchedDate = ddate.AddDays(intervalWeeks * 7);
                dtpNextDueDate.Value = nextSchedDate;

            }

            value = dtb.Rows[0]["VerificationRequired"].ToString();
            if (value == "1")
            {
                cValue = dtb.Rows[0]["DateVerificationDue"].ToString();
                rbVerifyReq.Checked = true;
                if (cValue == "") { cValue = DateTime.Now.ToShortDateString(); }
                ddate = Convert.ToDateTime(cValue);
                dateCalibrationDueDateTimePicker.Value = ddate;
                cValue = dtb.Rows[0]["VerificationInterval"].ToString();
                lbInterval.Text = cValue;
                intervalWeeks = Utils.ConvertToWeeks(cValue);
                nextSchedDate = ddate.AddDays(intervalWeeks * 7);
                dtpNextDueDate.Value = nextSchedDate;
            }

            value = dtb.Rows[0]["PATTestRequired"].ToString();
            if (value == "1")
            {
                cValue = dtb.Rows[0]["DatePATDue"].ToString();
                rbPatReq.Checked = true;
                if (cValue == "") { cValue = DateTime.Now.ToShortDateString(); }
                ddate = Convert.ToDateTime(cValue);
                dateCalibrationDueDateTimePicker.Value = ddate;
                cValue = dtb.Rows[0]["PATInterval"].ToString();
                lbInterval.Text = cValue;
                intervalWeeks = Utils.ConvertToWeeks(cValue);
                nextSchedDate = ddate.AddDays(intervalWeeks * 7);
                dtpNextDueDate.Value = nextSchedDate;
            }

            dtb.Dispose();


            sqlQuery = "SELECT * FROM tbl_assetlogs WHERE EquipmentID LIKE '" + SelectedEquipmentId + "' ORDER BY Date;";
            // initialise scheduled and record date to selected date from week no and current year.

            try
            {
                schedDate = Utils.FirstDateOfWeek(SelectedYear, SelectedWeekNo);
                ddate = schedDate;
                tbl_assetlogsTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
                tbl_assetlogsTableAdapter.ClearBeforeFill = true;
                tbl_assetlogsTableAdapter.Fill(eped_db1DataSet.tbl_assetlogs);

                noofrecs = tbl_assetlogsBindingSource.List.Count;
                tbl_assetlogsBindingSource.Position = 0;
                reccnt = 0;
                for (int i = 0; i < noofrecs; i++)
                {
                    // not getting record date bacl correctly
                    ddate = Convert.ToDateTime(((DataRowView)tbl_assetlogsBindingSource.Current).Row["Date"].ToString());
                    if ((Int16.Parse(Utils.GetWeekNo(ddate)) == SelectedWeekNo) && (ddate.Year == SelectedYear))
                    {
                        reccnt = i;
                        break;
                    }
                    tbl_assetlogsBindingSource.MoveNext();
                }
                tbl_assetlogsBindingSource.Position = reccnt;




                // if there are no records then provide todo details
                if (noofrecs == 0)

                {
                    //  tbl_assetlogsBindingSource.AddNew();
                    DateDateTimePicker.Value = schedDate;
                    equipmentIDTextBox.Text = SelectedEquipmentId;
                    technicianComboBox.Text = "Select technician";
                    ActionTakenTextBox.Text = "Write Action taken";
                    ReasonTextBox.Text = "Write Reason here";
                    panel3.Enabled = false;
                }

                // check equipmentIDComboBox.Text = SelectedEquipmentId;to see if record related to this year
                if (ddate.Year != SelectedYear)
                {
                    dateStr = "1/1/" + SelectedYear;
                    schedDate = Convert.ToDateTime(dateStr);

                    // locate first monday of year
                    while (schedDate.DayOfWeek != DayOfWeek.Monday)
                    {
                        schedDate = schedDate.AddDays(1);
                    }

                    schedDate = schedDate.AddDays(SelectedWeekNo - 1 * 7);
                    DateDateTimePicker.Value = schedDate;
                    equipmentIDTextBox.Text = SelectedEquipmentId;


                    technicianComboBox.Text = "Select technician";
                    ActionTakenTextBox.Text = "Write Action taken";
                    ReasonTextBox.Text = "Write Reason here";
                }

            }
            catch (Exception)
            {
                //   MessageBox.Show(ex.Message);
                equipmentIDTextBox.Text = SelectedEquipmentId;
                technicianComboBox.Text = "Select technician";
                ActionTakenTextBox.Text = "Write Action taken";
                ReasonTextBox.Text = "Write Reason here";
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Globals.ChangesMade = true;
            tbl_assetlogsBindingSource.AddNew();
            panel3.Enabled = true;
            equipmentIDTextBox.Text = SelectedEquipmentId;
            DateDateTimePicker.Value = DateTime.Now;
            btnSetNextDueDate.Enabled = true;
            dtpNextDueDate.Enabled = true;
        }

        private void MaintDialog_Activated(object sender, EventArgs e)
        {
            //  DisplayRecords();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;

            //'Work Order No:' combobox
            workOrderNoComboBox.Text = InputValidation.UserValidationInput(workOrderNoComboBox.Text);

            //'Technician:' combobox
            technicianComboBox.Text = InputValidation.UserValidationInput(technicianComboBox.Text);

            try
            {
                Validate();
                tbl_assetlogsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(this.eped_db1DataSet);
                // update teh assetregister with next due date
                if (rbCalibReq.Checked)
                {
                    DBUtils.UpdateDataToTableFields(dbCon, "tbl_assetregister", "DateCalibrationDue", "'" + dtpNextDueDate.Value.ToString("yyyy-MM-dd") + "'", " WHERE EquipmentID = '" + SelectedEquipmentId + "'");
                }

                if (rbVerifyReq.Checked)
                {
                    DBUtils.UpdateDataToTableFields(dbCon, "tbl_assetregister", "DateVerificationDue", "'" + dtpNextDueDate.Value.ToString("yyyy-MM-dd") + "'", " WHERE EquipmentID = '" + SelectedEquipmentId + "'");
                }
                if (rbPatReq.Checked)
                {
                    DBUtils.UpdateDataToTableFields(dbCon, "tbl_assetregister", "DatePATDue", "'" + dtpNextDueDate.Value.ToString("yyyy-MM-dd") + "'", " WHERE EquipmentID = '" + SelectedEquipmentId + "'");
                }

                {
                    DisplayRecords();
                    MessageBox.Show("Update Successful");
                    Globals.ChangesMade = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Update \n" + ex.Message);
            }

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Globals.ChangesMade == true)
            {
                DialogResult result = MessageBox.Show("New details added/changed but not saved to database, click OK to ignore changes", "Notice", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    Globals.ChangesMade = false;
                    Close();
                }
            }
            else this.Close();
        }

        private void DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            lblWeekno.Text = Utils.GetWeekNo(DateDateTimePicker.Value);
        }

        private void btnSetNextDueDate_Click(object sender, EventArgs e)
        {

        }
    }
}
