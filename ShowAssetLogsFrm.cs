using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EPED
{
    public partial class ShowAssetLogsFrm : Form
    {
        public ShowAssetLogsFrm()
        {
            InitializeComponent();
        }

        private void AssetLogsFrm_Load(object sender, EventArgs e)
        {

            this.BackColor = Globals.defaultformsbgCol;
            cmbSiteName.Text = Properties.Settings.Default.DefaultSiteName;
            this.tbl_assetlogsDataGridView1.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            UpdateComboBoxes();
            // TODO: This line of code loads data into the 'eped_db1DataSet.tbl_assetlogs' table. You can move, or remove it, as needed.
            this.tbl_assetlogsTableAdapter.Fill(this.eped_db1DataSet.tbl_assetlogs);
            if (Globals.AccessLevel > 1)
            {
                tbl_assetlogsBindingNavigator.DeleteItem.Visible = false;
                tbl_assetlogsBindingNavigator.AddNewItem.Visible = false;
                btnUpdateDatabase.Enabled = false;
            }
            dateDateTimePicker1.CustomFormat = "dd/MMM/yyyy";
            dateDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
        }



        private void UpdateComboBoxes()
        {
            List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_users", "UserName");
            valuelist.Sort();
            technicianComboBox.Items.Clear();
            technicianComboBox.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "SiteName");
            valuelist.Sort();
            siteNameComboBox.Items.Clear();
            siteNameComboBox.Items.AddRange(valuelist.ToArray());
            cmbSiteName.Items.Clear();
            cmbSiteName.Items.Add("ALL");
            cmbSiteName.Items.AddRange(valuelist.ToArray());
        }


        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " -LOGS- " + "Version (" + Globals.CurrVersion + ")   Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Globals.ChangesMade = true;
        }

        private void btnUpdateDatabase_Click(object sender, EventArgs e)
        {
            //'Site Name:' combobox on the right
            siteNameComboBox.Text = InputValidation.UserValidationInput(siteNameComboBox.Text);

            //'Technician:' combobox on the right
            technicianComboBox.Text = InputValidation.UserValidationInput(technicianComboBox.Text);

            //SHOW BY AREA:' combobox on the left
            cmbSiteName.Text = InputValidation.UserValidationInput(cmbSiteName.Text);
            
            try
            {
                this.Validate();
                this.tbl_assetlogsBindingSource.EndEdit();
                this.tbl_assetlogsTableAdapter.Update(eped_db1DataSet.tbl_assetlogs);
                Properties.Settings.Default.DefaultUser = Globals.DefUser;
                Properties.Settings.Default.Save();

                MessageBox.Show("Update Successful");

                Globals.ChangesMade = false;
            }
            catch
            {
                MessageBox.Show("Update Failed");
            }
        }


        private void SearchOnFilter(string searchFor)
        {

            Cursor.Current = Cursors.WaitCursor;

            string sqlQuery = "SELECT * FROM tbl_assetlogs;";
            string searchOnName = "EquipmentID";
            string siteName = cmbSiteName.Text;

            if ((siteName != "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_assetlogs WHERE SiteName LIKE '" + siteName + "';"; }
            if ((siteName != "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_assetlogs WHERE SiteName LIKE '" + siteName + "' AND " + searchOnName + " LIKE '%" + searchFor + "%';"; }
            if ((siteName == "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_assetlogs ;"; }
            if ((siteName == "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_assetlogs WHERE " + searchOnName + " LIKE '%" + searchFor + "%';"; }


            try
            {
                tbl_assetlogsTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
                tbl_assetlogsTableAdapter.ClearBeforeFill = true;
                tbl_assetlogsTableAdapter.Fill(eped_db1DataSet.tbl_assetlogs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }





        private void cmbSiteName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cmbSiteName.SelectedIndex > -1) { cmbSiteName.Text = cmbSiteName.Items[cmbSiteName.SelectedIndex].ToString(); }
            //  Properties.Settings.Default.DefaultSiteName = cmbSiteName.Text;
            txbSearchOn.Text = "";
            SearchOnFilter("");
            Cursor.Current = Cursors.Default;
        }

        private void txbSearchOn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchOnFilter(txbSearchOn.Text);
            }
        }

        private void btnSearchOn_Click(object sender, EventArgs e)
        {
            SearchOnFilter(txbSearchOn.Text);
        }

        private void AssetLogsFrm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;
        }
        //'SEARCH ON [Eqipment ID]' button
        private void btnSearchOn_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearchOn.ForeColor = Globals.selectBtnfgCol;
            btnSearchOn.BackColor = Color.LightCoral;
        }

        //'SEARCH ON [Equipment ID]' button
        private void btnSearchOn_MouseLeave(object sender, EventArgs e)
        {
            btnSearchOn.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnSearchOn.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'SAVE UPDATES' button
        private void btnUpdateDatabase_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdateDatabase.ForeColor = Globals.selectBtnfgCol;
            btnUpdateDatabase.BackColor = Color.LightCoral;
        }

        //'SAVE UPDATES' button
        private void btnUpdateDatabase_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateDatabase.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnUpdateDatabase.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
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
    }
}

