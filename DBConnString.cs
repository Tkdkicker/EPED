using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace EPED
{
    public partial class DBConnString : Form
    {
        public DBConnString()
        {
            InitializeComponent();
        }

        private void DBConnString_Load(object sender, EventArgs e)
        {
            //load default connection string
            // mysql:server=localhost;user id=admin;persistsecurityinfo=True;database=eped_db1;password=3ff3ctPh0t0n1c5

            if (Globals.DefUser == "gcs") { cboProvider.Enabled = true; }

            string constr = Properties.Settings.Default.eped_db1ConnectionString.ToString();
            string providerName = Properties.Settings.Default.providerName.ToString();
            Cursor.Current = Cursors.WaitCursor;

            cboProvider.Items.Add("MySql.Data.MySqlClient");
           
            cboProvider.SelectedIndex = 0;
            cboProvider.Text = providerName;
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(constr);
                    cboServer.Items.Add(builder.Server);
                    txtDatabase.Text = builder.Database;
                    txtUsername.Text = builder.UserID;
                    txtPassword.Text = builder.Password;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            cboServer.Items.Add("localhost");

            cboServer.SelectedIndex = 0;

            Cursor.Current = Cursors.Default;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string providerName = cboProvider.Text;
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                if (providerName == "MySql.Data.MySqlClient")
                {
                    string connectionString = string.Format("server={0};database={1}; user id={2};  persistsecurityinfo=True;  password={3}", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
                    MySqlConnection myConnection = new MySqlConnection(connectionString);
                    myConnection.Open();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Close();
                        MessageBox.Show("Test Connection successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // sqlserver: string connectionString = string.Format("DataSource={0};Initial Catalog={1}; User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);

            Cursor.Current = Cursors.WaitCursor;

            DBUtils.UpdateConnectionString(cboProvider.Text, cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text, true);
            Properties.Settings.Default.providerName = cboProvider.Text;
            Properties.Settings.Default.DBPassword = EncryptKey.Encrypt(txtPassword.Text);
            Properties.Settings.Default.DBName = txtDatabase.Text;
            Properties.Settings.Default.DBUserName = txtUsername.Text;
            Properties.Settings.Default.ServerLocation = cboServer.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            Cursor.Current = Cursors.Default;
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = char.Parse("\0");
        }

        private void txtPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = char.Parse("*");
        }


        

     
    }
}
