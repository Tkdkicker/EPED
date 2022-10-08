using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace EPED
{
    class DBUtils
    {
        public static bool IsServerConnected(string connectionString)
        {
            bool retval = false;

            string providerName = Properties.Settings.Default.providerName.ToString();
            // providerName = "System.Data.ODBC";
            // Properties.Settings.Default.providerName = providerName;
            // Properties.Settings.Default.Save();
            if (providerName == "MySql.Data.MySqlClient")
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        retval = true;
                    }
                    catch (MySqlException)
                    {
                        retval = false;
                    }
                }
            }
            return retval;
        }


        public static bool ExecuteSqlCmdInDB(string dbCon, string sqlCmd, bool showMessages = true)
        {
            bool retVal = true;
            string providerName = Properties.Settings.Default.providerName.ToString();
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    cnn.Open();
                    cmd = new MySqlCommand(sqlCmd, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Error unable to execute sql command\n Contact Administrator\n" + ex.Message); }
                retVal = false;
            }
            return retVal;
        }





        public static bool CheckTableExistsFromDB(string dbCon, string tblName)
        {
            bool retVal = true;
            string sql = "SELECT * FROM " + tblName + ";";
            string providerName = Properties.Settings.Default.providerName.ToString();
             try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    cmd.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception)
            {
                retVal = false;
            }
            return retVal;
        }

        public static bool CheckColumnExistsFromDB(string dbCon, string tblName, string colName)
        {
            bool retVal = true;
            string sql = "SELECT "+ colName + " FROM " + tblName + ";";
            string providerName = Properties.Settings.Default.providerName.ToString();
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    cmd.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception)
            {
                retVal = false;
            }
            return retVal;
        }



        public static bool AddColumnToTable(string dbCon, string tblName,string colName, string colType, bool showMessages=true)
        {
            bool retVal = true;
            string sql = "ALTER TABLE " + tblName + " ADD COLUMN " + colName + " " + colType + ";";

            string providerName = Properties.Settings.Default.providerName.ToString();
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                }
            }
             
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not create column " + colName + " in table " + tblName + "\n" + ex.Message); }
                retVal = false;
            }
            return retVal;

        }
       




        public static DataTable FetchDBTable(string dbCon, string tblName, bool showMessages = true)
        {

            string sql = "SELECT * FROM " + tblName + ";";
            string providerName = Properties.Settings.Default.providerName.ToString();
            DataTable dtb = new DataTable();

            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlDataAdapter dad = new MySqlDataAdapter(sql, cnn);
                    cnn.Open();
                    dad.Fill(dtb);
                    dad.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch table " + ex.Message); }
            }

            return dtb;
        }

        public static DataTable FetchDBTableByFilter(string dbCon, string tblName, string filter, bool showMessages = true)
        {

            string sql = "SELECT * FROM " + tblName + filter + ";";
            string providerName = Properties.Settings.Default.providerName.ToString();
            DataTable dtb = new DataTable();

            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlDataAdapter dad = new MySqlDataAdapter(sql, cnn);
                    cnn.Open();
                    dad.Fill(dtb);
                    dad.Dispose();
                    cnn.Close();
                }

            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch table " + ex.Message); }
            }

            return dtb;
        }


        public static bool UpdateDataToTableFields(string dbCon, string tblName, string fieldname, string newvalue, string filter, bool showMessages = true)
        {

            string providerName = Properties.Settings.Default.providerName.ToString();
            string sql;
            string[] splitFieldNames;
            string[] splitNewValues;
            string setFields = "";

            try
            {
                splitFieldNames = fieldname.Split(',');
                splitNewValues = newvalue.Split(',');
                for (int i = 0; i < splitFieldNames.Count(); i++)
                {
                    if (setFields == "")
                    {
                        setFields = splitFieldNames[i] + " = " + splitNewValues[i];
                    }
                    else
                    {
                        setFields = setFields + "," + splitFieldNames[i] + " = " + splitNewValues[i];
                    }
                }
                sql = "UPDATE " + tblName + " SET " + setFields + " " + filter + ";";

                //    sql = "UPDATE " + tblName + " SET " + setFields + " DateVerificationDue = CURDATE() " + filter + ";";
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    cmd.Dispose();
                }

                return true;
            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not update field/s \n " + ex.Message); }
                return false;
            }
        }
        public static string FetchLastJob(string dbCon, string tblName, bool showMessages = true)
        {
            string providerName = Properties.Settings.Default.providerName.ToString();
            string value = "";
            string sql;
            sql = "SELECT JobIdNo FROM " + tblName + "  ORDER BY JobIdNo DESC;";

            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        value = reader.GetValue(0).ToString();
                        break;
                    }
                    cnn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch value " + ex.Message); }
            }
            return value;
        }

        public static string FetchLastMainRecordForAsset(string dbCon, string tblName, string assetID, bool showMessages = true)
        {
            string providerName = Properties.Settings.Default.providerName.ToString();
            string value = "";
            string sql;
            sql = "SELECT Date FROM " + tblName + " WHERE EquipmentID LIKE '" + assetID + "' ORDER BY Date DESC;";

            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        value = reader.GetValue(0).ToString();
                        break;
                    }
                    cnn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch value " + ex.Message); }
            }
            return value;
        }

        public static bool FetchDBSettings(string dbCon, string tblName, string user, bool showMessages = true)
        {
            string providerName = Properties.Settings.Default.providerName.ToString();
            string sql;
            sql = "SELECT * FROM " + tblName + " WHERE UserName = '" + user + "';";

            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Globals.DuePeriodColor = reader.IsDBNull(reader.GetOrdinal("DuePeriodColor")) ? string.Empty : reader.GetString(reader.GetOrdinal("DuePeriodColor"));
                        Globals.OverDueColor = reader.IsDBNull(reader.GetOrdinal("OverDueColor")) ? string.Empty : reader.GetString(reader.GetOrdinal("OverDueColor"));
                        Globals.AllowAssetsUpdate = reader.IsDBNull(reader.GetOrdinal("AllowAssetsUpdate")) ? 0 : reader.GetUInt16(reader.GetOrdinal("AllowAssetsUpdate"));
                        Globals.AllowJobAllocation = reader.IsDBNull(reader.GetOrdinal("AllowJobAllocation")) ? 0 : reader.GetUInt16(reader.GetOrdinal("AllowJobAllocation"));
                        Globals.EquipmentView = reader.IsDBNull(reader.GetOrdinal("EquipmentView")) ? string.Empty : reader.GetString(reader.GetOrdinal("EquipmentView"));
                        Globals.MailFromAddress = reader.IsDBNull(reader.GetOrdinal("MailFromAddress")) ? string.Empty : reader.GetString(reader.GetOrdinal("MailFromAddress"));
                        Globals.MailSmtpServer = reader.IsDBNull(reader.GetOrdinal("MailSmtpServer")) ? string.Empty : reader.GetString(reader.GetOrdinal("MailSmtpServer"));
                        Globals.MailPortAddress = reader.IsDBNull(reader.GetOrdinal("MailPortAddress")) ? string.Empty : reader.GetString(reader.GetOrdinal("MailPortAddress"));
                        Globals.MailLoginAddress = reader.IsDBNull(reader.GetOrdinal("MailLoginAddress")) ? string.Empty : reader.GetString(reader.GetOrdinal("MailLoginAddress"));
                        Globals.MailPassword = reader.IsDBNull(reader.GetOrdinal("MailPassword")) ? string.Empty : reader.GetString(reader.GetOrdinal("MailPassword"));
                        Globals.MailPassword = EncryptKey.Decrypt(Globals.MailPassword);

                    }
                    //   value = reader.GetValue(0).ToString();
                    cnn.Close();
                    cmd.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch value " + ex.Message); }
                return false;
            }
        }


        public static string FetchPasswordFromUser(string dbCon, string tblName, string user, bool showMessages = true)
        {
            string providerName = Properties.Settings.Default.providerName.ToString();
            string value = "";
            string sql;
            sql = "SELECT UserPassword FROM " + tblName + " WHERE UserName = '" + user + "';";

            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    value = reader.GetValue(0).ToString();
                    cnn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (showMessages){ MessageBox.Show(" Can not fetch value " + ex.Message); }
            }
            return value;
        }


        public static string FetchStringFromDB(string dbCon, string tblName, string getValue, string searchName, string searchValue1, string searchValue2="", bool showMessages = true)
        {
            string providerName = Properties.Settings.Default.providerName.ToString();
            string value = "";
            string sql;

            sql = "SELECT " + getValue + " FROM " + tblName + " WHERE " + searchName + " Like '" + searchValue1 + "'" + searchValue2;
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    value = reader.GetValue(0).ToString();
                    cnn.Close();
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch value " + ex.Message); }
                return "";
            }
            return value;
        }


       




        public static string FetchUserLevelFromUser(string dbCon, string tblName, string user, bool showMessages = true)
        {
            string providerName = Properties.Settings.Default.providerName.ToString();
            string value = "4";  // guest level
            string sql;
            sql = "SELECT UserLevel FROM " + tblName + " WHERE UserName = '" + user + "';";
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        value = reader.IsDBNull(0) ? "4" : reader.GetValue(0).ToString();
                    }
                    cnn.Close();
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch value " + ex.Message); }
            }
            return value;
        }

        public static bool InsertWorkOrder(string dbCon, string tblName, string newWo, string techName, List<string> equipmentList, List<string> descriptionList, bool showMessages=true)
        {
            // load this into the works order table 
            try
            {
                string providerName = Properties.Settings.Default.providerName.ToString();

                string sql;
                string equipcsv = string.Join(",", equipmentList.Select(x => x.ToString()).ToArray());
                string desccsv = string.Join(",", descriptionList.Select(x => x.ToString()).ToArray());
                sql = "INSERT INTO " + tblName + " (JobIdNo,AssetID,EquipmentName,JobAllocationTo,DateJobAllocated) VALUES ('" +
                              newWo + "','" + equipcsv + "','" + desccsv + "','" + techName + "',  CURDATE());";

                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    cmd.Dispose();
                }

                return true;
            }
            catch (Exception ex)
            {
                if (showMessages)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }



        public static List<string> FetchListOfUsers(string dbCon, string tblName, bool showMessages = true)
        {
            List<string> userList = new List<string>();
            string providerName = Properties.Settings.Default.providerName.ToString();
            string sql;
            sql = "SELECT UserName FROM " + tblName + ";";
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userList.Add(reader.GetValue(0).ToString());
                    }
                    cnn.Close();
                    cmd.Dispose();
                }


            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch value " + ex.Message); }
            }
            return userList;
        }



        public static List<string> FetchDistinctListOfValues(string dbCon, string tblName, string header, bool showMessages = true)
        {
            List<string> userList = new List<string>();
            string providerName = Properties.Settings.Default.providerName.ToString();
            string sql;
            sql = "SELECT DISTINCT " + header + " FROM " + tblName + ";";
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    MySqlConnection cnn = new MySqlConnection(dbCon);
                    MySqlCommand cmd;
                    MySqlDataReader reader;
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userList.Add(reader.GetValue(0).ToString());
                    }
                    cnn.Close();
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                if (showMessages) { MessageBox.Show(" Can not fetch value " + ex.Message); }
            }
            return userList;
        }




        public static bool UpdateConnectionString(string providerName, string serverName, string database, string userName, string dbPassword, bool showMessages=true)
        {
            try
            {
                if (providerName == "MySql.Data.MySqlClient")
                {
                    string connectionString = string.Format("server={0};database={1}; user id={2}; persistsecurityinfo=True;  password={3}", serverName, database, userName, dbPassword);
                    MySqlConnection myConnection = new MySqlConnection(connectionString);
                    myConnection.Open();
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Close();
                        AppSetting setting = new AppSetting();
                        setting.SaveConnectionString("EPED.Properties.Settings.eped_db1ConnectionString", connectionString, providerName);
                        if (showMessages)
                        {
                            MessageBox.Show("Your connection string has been successfully saved \n Restart Application ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                if (showMessages)
                {
                    if (showMessages) { MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                return false;
            }

        }

    }
}

