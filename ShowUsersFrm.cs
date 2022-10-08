using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EPED
{
    public partial class ShowUsersFrm : Form
    {
        public ShowUsersFrm()
        {
            InitializeComponent();
        }

        private void tbl_usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);

        }

        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " -Users- " + " - Version " + Globals.CurrVersion + " Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }


        private void UsersFrm_Load(object sender, EventArgs e)
        {
            tbl_usersTableAdapter.Fill(this.eped_db1DataSet.tbl_users);
            this.tbl_usersDataGridView.DefaultCellStyle.Font = new Font("Calibra Light", 9);
            ViewByLevel();
        }

        private void ViewByLevel()
        {
            if (Globals.AccessLevel == 1)
            {
                tbl_usersBindingNavigator.Visible = true;
                userLevelComboBox.Enabled = true;
                btnAddNew.Enabled = true;
                btnViewPW.Visible = true;
            }
            else
            {
                tbl_usersBindingNavigator.Visible = false;
                userLevelComboBox.Enabled = false;
                btnAddNew.Enabled = false;
                btnViewPW.Visible = false;
            }

        }



        private void AddNew_Button_Click(object sender, EventArgs e)
        {
            this.tbl_usersBindingSource.AddNew();
        }

        private void UpdateDB_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tbl_usersBindingSource.EndEdit();
                this.tbl_usersTableAdapter.Update(eped_db1DataSet.tbl_users);
                Properties.Settings.Default.DefaultUser = Globals.DefUser;
                Properties.Settings.Default.Save();
                MessageBox.Show("Update Successful");
                btnChangePassword.Enabled = false;
                Globals.ChangesMade = false;
              //  DialogResult result = DialogResult.OK;
            }
            catch 
            {
                MessageBox.Show("Update Failed\nTry closing and re opening this form");
            }


        }

        private void userPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            // encrypt before saving to database
          //  userPasswordTextBox.Text = EncryptKey.Encrypt(userPasswordTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
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
            else
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string selUser = userNameTextBox.Text;
            string currUser = Properties.Settings.Default.DefaultUser.ToString();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string currLevel = DBUtils.FetchUserLevelFromUser(dbCon, "tbl_users", currUser);
            string selLevel = DBUtils.FetchUserLevelFromUser(dbCon, "tbl_users", selUser);

            try
            {
                if ((currUser.ToLower() == "admin") || ((selUser.ToLower() != "admin") && (Int16.Parse(currLevel) <= Int16.Parse(selLevel))))
                {
                    Properties.Settings.Default.DefaultUser = selUser;
                    Properties.Settings.Default.Save();
                    Globals.DefUser = selUser;
                    DBUtils.FetchDBSettings(dbCon, "tbl_settings", Globals.DefUser);
                    Globals.AccessLevel = Int16.Parse(selLevel);
                }

                else
                // validate admin with password
                {

                    string UserPassword = "";
                    string Password = "";
                    if (Utils.InputBox("Login", "Enter Password for " + selUser, true, ref Password) == DialogResult.OK)
                    {
                        UserPassword = DBUtils.FetchPasswordFromUser(dbCon, "tbl_users", selUser);
                        UserPassword = EncryptKey.Decrypt(UserPassword);
                        if (UserPassword == Password)
                        {
                            Properties.Settings.Default.DefaultUser = selUser;
                            Properties.Settings.Default.Save();
                            Globals.DefUser = selUser;
                            DBUtils.FetchDBSettings(dbCon, "tbl_settings", Globals.DefUser);
                            Globals.AccessLevel = Int16.Parse(selLevel);
                        }
                        else
                        {
                            MessageBox.Show("Password Failed!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ViewByLevel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnChangePassword.Text == "CHANGE PASSWORD")
            {
                pnlNewPassword.Visible = true;
                btnChangePassword.Text = "CANCEL";
                btnChangePassword.Enabled = true;
            }
            else
            {
                pnlNewPassword.Visible = false;
                btnChangePassword.Text = "CHANGE PASSWORD";
                btnChangePassword.Enabled = false;
            }
        }



        private void txbNewPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txbNewPassword.TextLength >= 8)
                txbVerifyPassword.Focus();
        }

        private void txbVerifyPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txbCurPassword_Validating(object sender, CancelEventArgs e)
        {
            // check this is the current password
            if (EncryptKey.Decrypt(userPasswordTextBox.Text) == txbCurPassword.Text)
            {
                txbNewPassword.Focus();
            }
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if ((txbNewPassword.Text == txbVerifyPassword.Text) && (txbNewPassword.Text.Length > 7))
            {
                string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
                string filter = " WHERE UserName = '" + userNameTextBox.Text + "'";
                userPasswordTextBox.Text = EncryptKey.Encrypt(txbNewPassword.Text);
                DBUtils.UpdateDataToTableFields(dbCon, "tbl_users", "UserPassword", "'" + userPasswordTextBox.Text + "'", filter);
                txbCurPassword.Text = "";
                txbNewPassword.Text = "";
                txbVerifyPassword.Text = "";
                pnlNewPassword.Visible = false;
                btnChangePassword.Text = "CHANGE PASSWORD";
            }
            else
            {
                MessageBox.Show("Password do not match and need to be greater than 7 characters");
            }

        }

        private void btnViewPW_MouseDown(object sender, MouseEventArgs e)
        {
            if (Globals.DefUser == "Admin")
            {
                userPasswordTextBox.PasswordChar = char.Parse("\0");
                userPasswordTextBox.Text = EncryptKey.Decrypt(userPasswordTextBox.Text);
            }
        }

        private void btnViewPW_MouseUp(object sender, MouseEventArgs e)
        {
            if (Globals.DefUser == "Admin")
            {
                userPasswordTextBox.PasswordChar = char.Parse("*");
                userPasswordTextBox.Text = EncryptKey.Encrypt(userPasswordTextBox.Text);
            }
        }

        private void tbl_usersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }

        private void ShowUsersFrm_Activated(object sender, EventArgs e)
        {
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;
        }





        //'CHANGE PASSWORD' button
        private void btnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnChangePassword.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'SAVE NEW PASSWORD' button

      

  

 
    }
}
