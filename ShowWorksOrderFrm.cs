using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace EPED
{
    public partial class ShowWorksOrderFrm : Form
    {
        public ShowWorksOrderFrm()
        {
            InitializeComponent();
        }


        private void WorksOrderFrm_Load(object sender, EventArgs e)
        {
            this.BackColor = Globals.defaultformsbgCol;
            this.tbl_worksordersTableAdapter.Fill(this.eped_db1DataSet.tbl_worksorders);
            this.tbl_worksordersDataGridView.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            SetUpDataGridView(dataGridView1);
            PopulateDataGridView(dataGridView1);
            dateJobAllocatedDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            dateJobCompletedDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            requiredCompletionDateTimePicker.CustomFormat = "dd/MMM/yyyy";
        }

        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " -Works Orders - " + "Version (" + Globals.CurrVersion + ")  Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PopulateDataGridView(DataGridView dgv)
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string[] assetid;
            string[] description;
            string duedate;
            string notes;
            string testtype;
            //    List<string> rowdata = new List<string>();
            DataTable dtb = new DataTable();

            dtb = DBUtils.FetchDBTable(dbCon, "tbl_assetregister");
            assetid = assetIDTextBox.Text.Split(',');
            description = equipmentNameTextBox.Text.Split(',');
            int noOfRows = assetid.Count();
            // clear any rows already in dgv
            dgv.Rows.Clear();

            for (int i = 0; i < noOfRows; i++)
            {
                testtype = "";
                notes = "";
                duedate = DateTime.Now.ToString("dd/MM/yyyy");
                //  rowdata = DBUtils.FetchRowOfData(dbCon, "tbl_assetregister", " WHERE EquipmentID LIKE '" + assetid[i]+"'");
                DataRow[] dr = dtb.Select("EquipmentID= '" + assetid[i] + "'");
                foreach (DataRow row in dr)
                {
                    notes = "";
                    testtype = "MIS";
                    duedate = DateTime.Now.ToString("dd/MM/yyyy");
                    if (row["CalibrationRequired"].ToString() == "1")
                    {
                        testtype = "CAL";
                        duedate = row["DateCalibrationDue"].ToString();
                        if (duedate != "") { duedate = Convert.ToDateTime(duedate).ToString("dd/MM/yyyy"); }

                    }
                    if (row["VerificationRequired"].ToString() == "1")
                    {
                        testtype = "VER";
                        duedate = row["DateVerificationDue"].ToString();
                        if (duedate != "") { duedate = Convert.ToDateTime(duedate).ToString("dd/MM/yyyy"); }

                    }

                    if (row["PATTestRequired"].ToString() == "1")
                    {
                        testtype = "VER";
                        duedate = row["DatePATDue"].ToString();
                        if (duedate != "") { duedate = Convert.ToDateTime(duedate).ToString("dd/MM/yyyy"); }
                    }
                    notes = row["Notes"].ToString();
                }
                dgv.Rows.Add(assetid[i], description[i], testtype, duedate, notes);
            }
        }


        private void SetUpDataGridView(DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Black;
            dgv.RowHeadersVisible = true;
            dgv.Columns[0].Name = "Asset ID";
            dgv.Columns[1].Name = "Description";
            dgv.Columns[2].Name = "TestType";
            dgv.Columns[3].Name = "Due Date";
            dgv.Columns[4].Name = "Notes";
            dgv.Columns[4].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Italic);
        }




        private void SendEmailtoTechForJob()
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            Cursor.Current = Cursors.WaitCursor;

            string jobid = jobIdNoTextBox.Text;
            string techname = jobAllocationToTextBox.Text;
            string jobnote = notesTextBox.Text;
            string techmailaddress = DBUtils.FetchStringFromDB(dbCon, "tbl_users", "UserEmailAddress", "UserName", techname);
            string subject = "Assets Due  Job ID: " + jobid;
            string heading = "Below are listed Assets requiring attention, Total no of Records: " + dataGridView1.Rows.Count.ToString();
            string htmlStr = Utils.getHtmlForWO(dataGridView1, heading, jobnote, "Cal/Ver/PAT");


            if (Utils.Email(techmailaddress, subject, htmlStr))
            {
                // mark as email bein sent
                cbEmailSent.CheckState = CheckState.Checked;
                DBUtils.UpdateDataToTableFields(dbCon, "tbl_worksorders", "EmailSent", "1", "WHERE JobIdNo = '" + jobid + "'");
                MessageBox.Show("Email sent successfully to  " + techname, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Error unable to send email ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DBUtils.UpdateDataToTableFields(dbCon, "tbl_worksorders", "EmailSent", "0", "WHERE JobIdNo = '" + jobid + "'");
            }
            Cursor.Current = Cursors.Default;
        }



        private void OpenEmail_Button_Click(object sender, EventArgs e)
        {
            SendEmailtoTechForJob();
        }


        private void tbl_worksordersDataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PopulateDataGridView(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
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
            else Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "SelectFrm")
                {

                    f.WindowState = FormWindowState.Normal;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //SaveLocalSettings();
                this.Validate();
                this.tbl_worksordersBindingSource.EndEdit();
                this.tbl_worksordersTableAdapter.Update(eped_db1DataSet.tbl_worksorders);
                MessageBox.Show("Update Successful");
                Globals.ChangesMade = false;

            }
            catch
            {
                MessageBox.Show("Update Failed");
            }

            Cursor.Current = Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }

        private void notesTextBox1_TextChanged(object sender, EventArgs e)
        {
            Globals.ChangesMade = true;
        }

        private void ShowMainDialog(int rowSelected, int colSelected)
        {
            DataGridView dgv = dataGridView1;
            string equipmentid;

            // is this a row select if so jump out here.
            if (colSelected == -1) { return; }
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

        private bool CheckIfJobCompleted()
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            bool allworkdone = true;
            DataGridView dgv = dataGridView1;
            string assetId, value;
            DateTime recordDate = new DateTime(), jobDueDate;

            try
            {
                jobDueDate = dateJobAllocatedDateTimePicker.Value;
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    assetId = dgv.Rows[i].Cells[0].Value.ToString();
                    value = DBUtils.FetchLastMainRecordForAsset(dbCon, "tbl_assetlogs", assetId);
                    if (value != "")
                    {
                        recordDate = Convert.ToDateTime(value);
                        if (jobDueDate > recordDate) { allworkdone = false; }
                    }
                    else
                    {
                        allworkdone = false;
                    }
                }
            }
            catch (Exception)
            {
            }
            return allworkdone;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string jobid = jobIdNoTextBox.Text;
            ShowMainDialog(e.RowIndex, 1);

            if (dateJobCompletedDateTimePicker.Value.Date == DateTime.Now.Date)
            {
                if (CheckIfJobCompleted())
                {
                    DialogResult result = MessageBox.Show("All assets appear to have been serviced, click OK to set Job completed for today", "Notice", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        dateJobCompletedDateTimePicker.Value = DateTime.Now;
                        Globals.ChangesMade = true;
                    };
                }
            }
        }

        private void CheckDateDisplay()
        {
            // fetch current row form grid
            //DataRowView currentDataRowView = (DataRowView)tbl_assetregisterDataGridView.CurrentRow.DataBoundItem;
            //DataRow row = currentDataRowView.Row;
            string retval = "";

            try
            {
                retval = ((DataRowView)tbl_worksordersBindingSource.Current).Row["DateJobCompleted"].ToString();
                if (retval == "") { dateJobCompletedDateTimePicker.CustomFormat = " "; }
                else { dateJobCompletedDateTimePicker.CustomFormat = "dd MMMM yyyy"; }
                retval = ((DataRowView)tbl_worksordersBindingSource.Current).Row["RequiredCompletion"].ToString();
                if (retval == "") { requiredCompletionDateTimePicker.CustomFormat = " "; }
                else { requiredCompletionDateTimePicker.CustomFormat = "dd MMMM yyyy"; }

            }
            catch (Exception)
            {
            }

        }

        private void jobIdNoTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDateDisplay();
        }

        private void WorksOrderFrm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;
        }

    }
}
