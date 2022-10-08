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
    public partial class SelectTasksDialog : Form
    {
        public string AssetID { get; set; }
        public string Task { get; set; }
        public string TechAssigned { get; set; }
        public DateTime StartDate { get; set; }
        public string Frequency { get; set; }
        public string GroupAllocation { get; set; }
        public bool ReturnToSelect { get; set; }

        public SelectTasksDialog()
        {
            InitializeComponent();
        }

        private void tbl_pmtasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_pmtasksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);

        }

        private void SelectTasksDialog_Load(object sender, EventArgs e)
        {
            this.BackColor = Globals.defaultformsbgCol;
            estimatedDownTimePicker.CustomFormat = "HH:mm:ss";
            tpStartDate.CustomFormat = "dd/MMM/yyyy";

            // TODO: This line of code loads data into the 'eped_db1DataSet.tbl_pmtasks' table. You can move, or remove it, as needed.
            this.tbl_pmtasksTableAdapter.Fill(this.eped_db1DataSet.tbl_pmtasks);
            this.tbl_pmtasksDataGridView.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            lblTaskAllocation.Text = "Task allocations for " + AssetID;
            UpdateCombBoxes();
            if (ReturnToSelect)
            {
                btnSave.Visible = false;
                panel2.Visible = false;
                this.tbl_pmtasksDataGridView.AllowUserToAddRows = true;
            }
            estimatedDownTimePicker.Value = DateTime.Today;
        }



        private void UpdateCombBoxes()
        {
        
             List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "Location");
            valuelist.Sort();
            locationComboBox.Items.Clear();
            locationComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "EstimatedDownTime");
            valuelist.Sort();
            estimatedDownTimeComboBox.Items.Clear();
            estimatedDownTimeComboBox.Items.AddRange(valuelist.ToArray());


            valuelist = DBUtils.FetchListOfUsers(dbCon, "tbl_users");
            valuelist.Sort();
            cmbTech.Items.Clear();
            cmbTech.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmschedule", "GroupAllocation");
            valuelist.Sort();
            cmbGroupAllocation.Items.Clear();
            cmbGroupAllocation.Items.AddRange(valuelist.ToArray());


            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "Task");
            valuelist.Sort();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ALL");
            comboBox1.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "Location");
            valuelist.Sort();
            comboBox2.Items.Clear();
            comboBox2.Items.Add("ALL");
            comboBox2.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "LinkToInstruction");
            valuelist.Sort();
            comboBox3.Items.Clear();
            comboBox3.Items.Add("ALL");
            comboBox3.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "ConsequencesIfNotPerformed");
            valuelist.Sort();
            comboBox4.Items.Clear();
            comboBox4.Items.Add("ALL");
            comboBox4.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "PerpetualNotes");
            valuelist.Sort();
            comboBox5.Items.Clear();
            comboBox5.Items.Add("ALL");
            comboBox5.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_pmtasks", "EstimatedDownTime");
            valuelist.Sort();
            comboBox6.Items.Clear();
            comboBox6.Items.Add("ALL");
            comboBox6.Items.AddRange(valuelist.ToArray());







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check that frequency and tech has been assigned.
            if ((cmbTech.Text == "")|(cmbFreq.Text == ""))
            {
                MessageBox.Show("Both Tech and Frequency fields required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // first update any new additional tasks created
            UpdateDatabase();
            DialogResult = DialogResult.OK;
            Task = taskTextBox.Text;
            // pass back teh selected values
            TechAssigned = cmbTech.Text;
            Frequency = cmbFreq.Text;
            StartDate = tpStartDate.Value;
            GroupAllocation = cmbGroupAllocation.Text;  // this is also stored as station in main assets table
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // cancel
            DialogResult = DialogResult.Cancel;
            this.Close();
            if (ReturnToSelect)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "SelectFrm")
                    {

                        f.WindowState = FormWindowState.Normal;
                        break;
                    }
                }
            }

        }


        private void UpdateDatabase()
        {
            // check to see if this a task to be added
           

            // update any tasks if changed
            this.Validate();
            this.tbl_pmtasksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);
            UpdateCombBoxes();

        }




        private void tbl_pmtasksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            UpdateDatabase();

        }

        private void SelectTasksDialog_Activated(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;
        }


        private void FilterTasks()
        { 
            string[] filter = { "", "", "", "", "", ""};
            if (comboBox1.Text == "ALL") { filter[0] = "%"; } else { filter[0] = "%" + comboBox1.Text + "%"; }
            if (comboBox2.Text == "ALL") { filter[1] = "%"; } else { filter[1] = "%" + comboBox2.Text + "%"; }
            if (comboBox3.Text == "ALL") { filter[2] = "%"; } else { filter[2] = "%" + comboBox3.Text + "%"; }
            if (comboBox4.Text == "ALL") { filter[3] = "%"; } else { filter[3] = "%" + comboBox4.Text + "%"; }
            if (comboBox5.Text == "ALL") { filter[4] = "%"; } else { filter[4] = "%" + comboBox5.Text + "%"; }
            if (comboBox6.Text == "ALL") { filter[5] = "%"; } else { filter[5] = "%" + comboBox6.Text + "%"; }
            this.tbl_pmtasksTableAdapter.FillByAll(this.eped_db1DataSet.tbl_pmtasks,filter[0], filter[1], filter[2], filter[3], filter[4], filter[5]);
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTasks();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FilterTasks();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void estimatedDownTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //'Add selected task to active' button
        private void btnSave_MouseMove(object sender, MouseEventArgs e)
        {
            btnSave.ForeColor = Globals.selectBtnfgCol;
            btnSave.BackColor = Color.LightCoral;
        }

        //'Add selected task to active' button
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnSave.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
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
            btnClose.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnClose.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        private void taskTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
