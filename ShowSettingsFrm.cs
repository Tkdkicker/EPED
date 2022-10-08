using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Globals;


namespace EPED
{
    public partial class ShowSettingsFrm : Form
    {
        public ShowSettingsFrm()
        {
            InitializeComponent();
        }


        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            SetBGColours();
            // TODO: This line of code loads data into the 'eped_db1DataSet.tbl_color' table. You can move, or remove it, as needed.
            this.tbl_colorTableAdapter.Fill(this.eped_db1DataSet.tbl_color);
            tbl_colorDataGridView.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            DisplaySettings();
        }



        private void ViewByUserLevel()
        {
            lblDefUser.Text = Globals.DefUser;
            btnViewPW.Visible = false;

            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string currLevel = DBUtils.FetchUserLevelFromUser(dbCon, "tbl_users", Globals.DefUser);
            if (Int16.Parse(currLevel) > 1)
            {
                // disable and hide screend
                if (Int16.Parse(currLevel) > 2)
                {
                    cbAllowAssetUpdates.CheckState = CheckState.Unchecked;
                    cbAllowWorkOrders.CheckState = CheckState.Unchecked;
                }
                GroupBox1.Visible = false;
                GroupBox2.Enabled = false;
                GroupBox3.Enabled = false;
                GroupBox5.Visible = false;
                tbl_usersBindingNavigator.Visible = false;
                btnDBCon.Enabled = false;
                btnTest.Visible = false;

            }
            else
            {
                cbAllowAssetUpdates.CheckState = CheckState.Checked;
                cbAllowWorkOrders.CheckState = CheckState.Checked;
                GroupBox1.Visible = true;
                GroupBox2.Enabled = true;
                GroupBox3.Enabled = true;
                GroupBox5.Visible = true;
                if (Globals.DefUser == "Admin")
                {
                    tbl_usersBindingNavigator.Visible = true;
                    btnViewPW.Visible = true;
                }
                btnDBCon.Enabled = true;
                btnTest.Visible = true;

            }
            try
            {
                tbl_settingsTableAdapter.FillByUserName(eped_db1DataSet.tbl_settings, Globals.DefUser);
                if (tbl_settingsBindingSource.Count == 0)
                {
                    // add a settings account automatically with guest settings
                    Globals.ChangesMade = true;
                    //   tbl_settingsBindingSource.AddNew();
                    tbl_settingsTableAdapter.Insert(Globals.DefUser, "Selection", "Orange", "Red", 0, 0, "", "", "", "", "", 0, "");
                    equipmentViewComboBox.Text = "Selection";
                    cbAllowAssetUpdates.Checked = false;
                    cbAllowWorkOrders.Checked = false;
                    //tbl_settingsTableAdapter.FillByUserName(eped_db1DataSet.tbl_settings, "Guest");

                }
            }
            catch (Exception)
            {

            }
            Period_ComboBox1.Text = Properties.Settings.Default.PeriodForReporting;
            DayReport_ComboBox1.Text = Properties.Settings.Default.DayToReport;
            Email1_ComboBox.Text = Properties.Settings.Default.Email1ReportTo;
            Email2_ComboBox.Text = Properties.Settings.Default.Email2ReportTo;
            Email1_CheckBox.Checked = Properties.Settings.Default.Email1Send;
            Email2_CheckBox.Checked = Properties.Settings.Default.Email2Send;
        }



        private void SettingsFrm_Activated(object sender, EventArgs e)
        {
            // on any screen change verify who user is set to
            lblDefUser.Text = Globals.DefUser;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;

        }



        private void DisplaySettings()
        {



            this.BackColor = Globals.defaultformsbgCol;
            // load with local settings first
            string constr = Properties.Settings.Default.eped_db1ConnectionString.ToString();

            cbPrintInColor.Checked = Properties.Settings.Default.PrintInColor;
            rbPrintReport.Checked = Properties.Settings.Default.PrintReport;
            rbEmailReport.Checked = Properties.Settings.Default.EmailReport;
            equipmentViewComboBox.Text = Properties.Settings.Default.StartupView;
            Period_ComboBox1.Text = Properties.Settings.Default.PeriodForReporting;
            DayReport_ComboBox1.Text = Properties.Settings.Default.DayToReport;
            tbDueForService.Checked = Properties.Settings.Default.DueForServiceReport;
            tbDueForMPM.Checked = Properties.Settings.Default.DueForMPMReport;
            tbReportOnBlankDueDates.Checked = Properties.Settings.Default.ReportOnBlankDueDates;
            Email1_ComboBox.Text = Properties.Settings.Default.Email1ReportTo;
            Email2_ComboBox.Text = Properties.Settings.Default.Email2ReportTo;
            Email1_CheckBox.Checked = Properties.Settings.Default.Email1Send;
            Email2_CheckBox.Checked = Properties.Settings.Default.Email2Send;
            string[] splitstr = constr.Split(';');
            lblDefUser.Text = Globals.DefUser;
            MaintDBPath_Label.Text = splitstr[0] + "  " + splitstr[1];
            UpdatesLocation_Label.Text = Properties.Settings.Default.ApplicationUpdateLocation.ToString();

            // check connection can be made to databse
            try
            {
                tbl_settingsTableAdapter.FillByUserName(eped_db1DataSet.tbl_settings, Globals.DefUser);
                tbl_usersTableAdapter.Fill(this.eped_db1DataSet.tbl_users);
                ViewByUserLevel();
                UpdateComboBoxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Unable to connect to database \n Refer to Administrator to change connection settings");
                btnDBCon.Enabled = true;
            }

        }





        private void SetBGColours()
        {


            tbl_colorDataGridView.BackgroundColor = Globals.settingsbgCol;
            foreach (Control c in this.Controls)
            {

                if (c is GroupBox)
                {
                    c.BackColor = Globals.settingsbgCol;
                }

            }

            tbl_colorDataGridView.DefaultCellStyle.ForeColor = Color.Black;



        }




        private void UpdateComboBoxes()
        {
            List<string> userlist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            userlist = DBUtils.FetchListOfUsers(dbCon, "tbl_users");
            Email1_ComboBox.Items.Clear();
            Email1_ComboBox.Items.AddRange(userlist.ToArray());
            Email2_ComboBox.Items.Clear();
            Email2_ComboBox.Items.AddRange(userlist.ToArray());
        }



        private void Button1_Click(object sender, EventArgs e)
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
            var m = new DBConnString();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tbl_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);

        }

        private void SaveLocalSettings()
        {
            Properties.Settings.Default.StartupView = equipmentViewComboBox.Text;
            Properties.Settings.Default.PeriodForReporting = Period_ComboBox1.Text;
            Properties.Settings.Default.DayToReport = DayReport_ComboBox1.Text;
            Properties.Settings.Default.Email1ReportTo = Email1_ComboBox.Text;
            Properties.Settings.Default.Email2ReportTo = Email2_ComboBox.Text;
            Properties.Settings.Default.Email1Send = Email1_CheckBox.Checked;
            Properties.Settings.Default.Email2Send = Email2_CheckBox.Checked;
            Properties.Settings.Default.Save();
            Globals.MailFromAddress = mailFromAddressTextBox.Text;
            Globals.MailSmtpServer = mailSmtpServerTextBox.Text;
            Globals.MailPortAddress = mailPortAddressTextBox.Text;
            Globals.MailLoginAddress = mailLoginAddressTextBox.Text;
            Globals.MailPassword = mailPasswordTextBox.Text;
            Globals.MailPassword = EncryptKey.Decrypt(Globals.MailPassword);


        }


        private void UpdateColourScheme()
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            DataTable dtb = DBUtils.FetchDBTable(dbCon, "tbl_color");
            int red, green, blue;
            foreach (DataRow dr in dtb.Rows)
            {
                red = Int16.Parse(dr["Red"].ToString());
                green = Int16.Parse(dr["Green"].ToString());
                blue = Int16.Parse(dr["Blue"].ToString());
                if (dr["Allocation"].ToString() == "Select button FG") { selectBtnfgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Default Forms BG") { defaultformsbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Settings BG") { settingsbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "PM grid cell BG") { pmgridcellbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "No PM cell BG") { nopmgridcellbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Overdue BG") { pmoverduebgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Outstanding BG") { pmoutstandingbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Completed BG") { pmcompletedbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Grid current week BG") { gridcurrentweekbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Grid current week BG") { gridcurrentweekbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Asset not in use BG") { gridcurrentweekbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "No Longer Scheduled BG") { nolongerscheduledbgCol = Color.FromArgb(red, green, blue); }
            }

        }


        private void ResetColourScheme()
        {
            List<string> AllocatedName = new List<string>
            {
              "Select button FG",
              "Default Forms BG",
              "Settings BG",
              "PM grid cell BG",
              "No PM cell BG",
              "Overdue BG",
              "Outstanding BG",
              "Completed BG",
              "Grid current week BG",
              "Asset not in use BG"
            };
            List<Color> DefColour = new List<Color>
            {
              lightRed,
              offWhite,
              darkGray,
              offWhite,
              lightGray,
              lightRed,
              coral,
              lightGreen,
              lightBlue,
              lightGreen
            };


            try
            {




                // check to see if the dgv has been filled 
                if (tbl_colorDataGridView.Rows.Count == 0)
                {
                    for (int i = 0; i < AllocatedName.Count; i++)
                    {
                        tbl_colorBindingSource.AddNew();
                        tbl_colorDataGridView.Rows[i].Cells[0].Value = AllocatedName[i];
                        tbl_colorDataGridView.Rows[i].Cells[1].Value = ColorUtils.getColorNameFromRgb(DefColour[i].R, DefColour[i].G, DefColour[i].B);
                        tbl_colorDataGridView.Rows[i].Cells[2].Value = DefColour[i].R;
                        tbl_colorDataGridView.Rows[i].Cells[3].Value = DefColour[i].G;
                        tbl_colorDataGridView.Rows[i].Cells[4].Value = DefColour[i].B;
                    }
                }

                else
                {
                    foreach (DataGridViewRow dr in tbl_colorDataGridView.Rows)
                    {

                        if (dr.Cells[0].Value.ToString() == "Select button FG") { dr.Cells[2].Value = lightRed.R; dr.Cells[3].Value = lightRed.G; dr.Cells[4].Value = lightRed.B; }
                        if (dr.Cells[0].Value.ToString() == "Default Forms BG") { dr.Cells[2].Value = offWhite.R; dr.Cells[3].Value = offWhite.G; dr.Cells[4].Value = offWhite.B; }
                        if (dr.Cells[0].Value.ToString() == "Settings BG") { dr.Cells[2].Value = darkGray.R; dr.Cells[3].Value = darkGray.G; dr.Cells[4].Value = darkGray.B; }
                        if (dr.Cells[0].Value.ToString() == "PM grid cell BG") { dr.Cells[2].Value = offWhite.R; dr.Cells[3].Value = offWhite.G; dr.Cells[4].Value = offWhite.B; }
                        if (dr.Cells[0].Value.ToString() == "No PM cell BG") { dr.Cells[2].Value = lightGray.R; dr.Cells[3].Value = lightGray.G; dr.Cells[4].Value = lightGray.B; }
                        if (dr.Cells[0].Value.ToString() == "Overdue BG") { dr.Cells[2].Value = lightRed.R; dr.Cells[3].Value = lightRed.G; dr.Cells[4].Value = lightRed.B; }
                        if (dr.Cells[0].Value.ToString() == "Outstanding BG") { dr.Cells[2].Value = coral.R; dr.Cells[3].Value = coral.G; dr.Cells[4].Value = coral.B; }
                        if (dr.Cells[0].Value.ToString() == "Completed BG") { dr.Cells[2].Value = lightGreen.R; dr.Cells[3].Value = lightGreen.G; dr.Cells[4].Value = lightGreen.B; }
                        if (dr.Cells[0].Value.ToString() == "Grid current week BG") { dr.Cells[2].Value = lightBlue.R; dr.Cells[3].Value = lightBlue.G; dr.Cells[4].Value = lightBlue.B; }
                        if (dr.Cells[0].Value.ToString() == "Asset not in use BG") { dr.Cells[2].Value = offWhite.R; dr.Cells[3].Value = offWhite.G; dr.Cells[4].Value = offWhite.B; }
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // set globals to default colours.
            defaultformsbgCol = offWhite;
            selectBtnfgCol = lightRed;
            settingsbgCol = darkGray;
            pmgridcellbgCol = offWhite;
            nopmgridcellbgCol = lightGray;
            notinusebgCol = offWhite;
            pmoverduebgCol = lightRed;
            pmoutstandingbgCol = coral;
            pmcompletedbgCol = lightGreen;
            gridcurrentweekbgCol = lightBlue;
            nolongerscheduledbgCol = lightGreen;
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SaveLocalSettings();
                UpdateColourScheme();
                this.Validate();
                this.tbl_settingsBindingSource.EndEdit();
                this.tbl_settingsTableAdapter.Update(eped_db1DataSet.tbl_settings);
                MessageBox.Show("Update Successful");

                Globals.ChangesMade = false;
            }
            catch
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // select location for udpates
            string initDir = UpdatesLocation_Label.Text;

            initDir = System.IO.Path.GetDirectoryName(initDir);
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = initDir,
                Title = "Locate updated application file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "application",
                Filter = "app files (*.application)|*.application",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UpdatesLocation_Label.Text = openFileDialog1.FileName;
                Properties.Settings.Default.ApplicationUpdateLocation = UpdatesLocation_Label.Text;
            }
        }

        private void btnSelectUsers_Click(object sender, EventArgs e)

        {
            var m = new ShowUsersFrm();
            m.ShowDialog();
            if (m.DialogResult == DialogResult.Cancel)
            {
                DisplaySettings();
            }
        }



        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " -Settings " + "-Version (" + Globals.CurrVersion + ")   Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }



        private void mailPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            // encrypt before saving to database
            mailPasswordTextBox.Text = EncryptKey.Encrypt(mailPasswordTextBox.Text);
        }



        private void lblDefUser_TextChanged(object sender, EventArgs e)
        {
            ViewByUserLevel();
        }

        private void rbPrintReport_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintReport = rbPrintReport.Checked;
            Properties.Settings.Default.Save();
        }

        private void rbEmailReport_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailReport = rbEmailReport.Checked;
            Properties.Settings.Default.Save();
        }

        private void Period_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Period_ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = Period_ComboBox1.Items[Period_ComboBox1.SelectedIndex].ToString();
            Properties.Settings.Default.PeriodForReporting = value;
        }


        private void tbDueForService_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DueForServiceReport = tbDueForService.Checked;
        }

        private void DayReport_ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = DayReport_ComboBox1.Items[DayReport_ComboBox1.SelectedIndex].ToString();
            Properties.Settings.Default.DayToReport = value;
        }

        private void Email1_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = Email1_ComboBox.Items[Email1_ComboBox.SelectedIndex].ToString();
            Properties.Settings.Default.Email1ReportTo = value;
        }

        private void Email2_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = Email2_ComboBox.Items[Email2_ComboBox.SelectedIndex].ToString();
            Properties.Settings.Default.Email2ReportTo = value;
        }

        private void Email1_CheckBox_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Email1Send = Email1_CheckBox.Checked;
        }

        private void Email2_CheckBox_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Email2Send = Email2_CheckBox.Checked;
        }

        private void tbReportObBlankDueDates_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReportOnBlankDueDates = tbReportOnBlankDueDates.Checked;
        }

        private void cbPrintInColor_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintInColor = cbPrintInColor.Checked;
        }

        private void equipmentViewComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string value = equipmentViewComboBox.Items[equipmentViewComboBox.SelectedIndex].ToString();
            Properties.Settings.Default.StartupView = value;
        }

        private void tbReportOnInUseOnly_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReportOnInUseOnly = tbReportOnInUseOnly.Checked;
        }

        private void tbDueForMPM_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DueForMPMReport = tbDueForMPM.Checked;
            Properties.Settings.Default.Save();
        }




        private void DisplayColour()
        {

            try
            {
                if(tbl_colorBindingSource.Current != null)
                {
                    int red = Int16.Parse(((DataRowView)tbl_colorBindingSource.Current).Row["Red"].ToString());
                    int green = Int16.Parse(((DataRowView)tbl_colorBindingSource.Current).Row["Green"].ToString());
                    int blue = Int16.Parse(((DataRowView)tbl_colorBindingSource.Current).Row["Blue"].ToString());
                    //if((red ==0)|(green==0) | (blue == 0)) { MessageBox.Show("Select number greater than 0"); return; }
                    if ((red > 255) | (green > 255) | (blue > 255)) { MessageBox.Show("Select number less than 256"); return; }
                    txbCol.BackColor = Color.FromArgb(red, green, blue);
                    colourNameTextBox.Text = ColorUtils.getColorNameFromRgb(red, green, blue);
                }
               
            }
            catch
            {

            }

        }





        private void tbl_colorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayColour();
        }

        private void tbl_colorDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                DisplayColour();
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("This will reset colours back to defaults", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (response == DialogResult.OK)
            {
                ResetColourScheme();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tbl_colorBindingSource.EndEdit();
                this.tbl_colorTableAdapter.Update(eped_db1DataSet.tbl_color);
                MessageBox.Show("Update Successful");
                Globals.ChangesMade = false;
            }
            catch
            {
                MessageBox.Show("Update Failed");
            }

            UpdateColourScheme();
            SetBGColours();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            if (rbStopReporting.Checked)
            {
                MessageBox.Show("Reports disabled\nselect email or printed report");
                return;
            }

            if (System.Windows.Forms.Application.OpenForms["SelectFrm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["SelectFrm"] as SelectFrm).SendReport();
                MessageBox.Show((System.Windows.Forms.Application.OpenForms["SelectFrm"] as SelectFrm).tbMessages.Text);
            }
            else
            {
                // instantiate form to access public method
                SelectFrm frm = new SelectFrm();
                frm.SendReport();
                MessageBox.Show(frm.tbMessages.Text);
            }
        }

        private void cbxReportOnOverdueIncluded_CheckedChanged(object sender, EventArgs e)
        {
            Globals.reportOnOverDue = cbxReportOnOverdueIncluded.Checked;
        }

        private void btnViewPW_MouseDown(object sender, MouseEventArgs e)
        {
            if (Globals.DefUser == "Admin")
            {
                mailPasswordTextBox.PasswordChar = char.Parse("\0");
                mailPasswordTextBox.Text = EncryptKey.Decrypt(mailPasswordTextBox.Text);
            }
        }

        private void btnViewPW_MouseUp(object sender, MouseEventArgs e)
        {
            if (Globals.DefUser == "Admin")
            {
                mailPasswordTextBox.PasswordChar = char.Parse("*");
                mailPasswordTextBox.Text = EncryptKey.Encrypt(mailPasswordTextBox.Text);
            }
        }

    }
}

