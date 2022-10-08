using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using EPED.Properties;
using static Globals;


namespace EPED
{
    public partial class SelectFrm : Form
    {
        

        public SelectFrm()
        {
            InitializeComponent();
        }


        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " - Selection - " + "Version (" + Globals.CurrVersion + ")   Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }


        /// <summary>
        /// This routine is a one off to udpate teh databse autmatically on start up
        /// </summary>
        private void CheckForDatabaseChanges()
        {
            // inserted 14/02/2021
            // check to see if a new table needs to be added to datatbse if not found.
            string dbCon = Settings.Default.eped_db1ConnectionString;
            if (DBUtils.CheckTableExistsFromDB(dbCon, "tbl_pmschedule") == false)
            {
                // create a new table as defined in the SQL Command. 
                string sqlCmd = "CREATE TABLE " + "tbl_pmschedule" + "(" +
                       "EquipmentID VARCHAR(45) NOT NULL," +
                       "Task VARCHAR(45)," +
                       "StartWeekNo INT," +
                       "AssignedTech VARCHAR(45)," +
                       "Frequency VARCHAR(45)," +
                       "StartDate DATETIME," +
                       "PlannedMaintenance1 VARCHAR(1048)," +
                       "GroupAllocation VARCHAR(255)," +
                       "Notes VARCHAR(512)," +
                       "PRIMARY KEY (EquipmentID,Task,StartWeekNo)" +
                       ");";

                if (DBUtils.ExecuteSqlCmdInDB(dbCon, sqlCmd, false) == false)
                {
                    MessageBox.Show(" Error: unable to create a new table  'PMSchedule', contact Administrator");
                }
            }


            if (DBUtils.CheckTableExistsFromDB(dbCon, "tbl_pmtasks") == false)
            {

                // create a new table as defined in the SQL Command. 
                string sqlCmd = "CREATE TABLE " + "tbl_pmtasks" + "(" +
                       "Task VARCHAR(50) NOT NULL," +
                       "Location VARCHAR(255)," +
                       "LinkToInstruction VARCHAR(255)," +
                       "ConsequencesIfNotPerformed VARCHAR(1048)," +
                       "PerpetualNotes VARCHAR(1048)," +
                       "EstimatedDownTime VARCHAR(255)," +
                       "PRIMARY KEY (Task)" +
                       ");";

                if (DBUtils.ExecuteSqlCmdInDB(dbCon, sqlCmd, false) == false)
                {
                    MessageBox.Show(" Error: unable to create a new table for Preventative Maintenance Tasks, contact Administrator");
                }
            }


            if (DBUtils.CheckTableExistsFromDB(dbCon, "tbl_color") == false)
            {

                // create a new table as defined in the SQL Command. 
                string sqlCmd = "CREATE TABLE " + "tbl_color" + "(" +
                       "Allocation VARCHAR(255) NOT NULL," +
                       "ColourName VARCHAR(255) NOT NULL," +
                       "Red INT NOT NULL," +
                       "Green INT NOT NULL," +
                       "Blue INT NOT NULL," +
                       "PRIMARY KEY (Allocation)" +
                       ");";

                if (DBUtils.ExecuteSqlCmdInDB(dbCon, sqlCmd, false) == false)
                {
                    MessageBox.Show(" Error: unable to create a new table for Preventative Maintenance Tasks, contact Administrator");
                }
            }






            // check to see if a column exitsts if not insert column
            if (DBUtils.CheckColumnExistsFromDB(dbCon, "tbl_assetregister", "MultiplePM") == false)
            {
                // create a new table as defined in the SQL Command. 
                if (DBUtils.AddColumnToTable(dbCon, "tbl_assetregister", "MultiplePM", "BOOL DEFAULT 0 AFTER EquipmentReceivedDate") == false)
                {
                    MessageBox.Show(" Error: unable to insert column MultiplePM into table, contact Administrator");
                }
            }

            // check to see if a column exitsts if not insert column
            if (DBUtils.CheckColumnExistsFromDB(dbCon, "tbl_assetregister", "Station") == false)
            {
                // create a new table as defined in the SQL Command. 
                if (DBUtils.AddColumnToTable(dbCon, "tbl_assetregister", "Station", " VARCHAR(255) AFTER Location") == false)
                {
                    MessageBox.Show(" Error: unable to insert column Station into table, contact Administrator");
                }
            }




            // check to see if a column exitsts in teh logs if not insert column
            if (DBUtils.CheckColumnExistsFromDB(dbCon, "tbl_assetlogs", "DateDue") == false)
            {
                // create a new table as defined in the SQL Command. 
                if (DBUtils.AddColumnToTable(dbCon, "tbl_assetlogs", "DateDue", "DATETIME AFTER Date") == false)
                {
                    MessageBox.Show(" Error: unable to insert column DateDue into table, contact Administrator");
                }
            }

            // check to see if a column exitsts in the PMschedule if not insert column   gcs 15/5/21 no longer required using asset logs for task status
            //if (DBUtils.CheckColumnExistsFromDB(dbCon, "tbl_pmschedule", "CurrentStatus") == false)
            //{
            //    // create a new table as defined in the SQL Command. 
            //    if (DBUtils.AddColumnToTable(dbCon, "tbl_pmschedule", "CurrentStatus", "VARCHAR(255) DEFAULT 'To do' AFTER Notes") == false)
            //    {
            //        MessageBox.Show(" Error: unable to insert column CurrentStatus into table pm schedule, contact Administrator");
            //    }
            //}


            // check to see if a column exitsts in the PMschedule if not insert column
            if (DBUtils.CheckColumnExistsFromDB(dbCon, "tbl_assetlogs", "TaskStatus") == false)
            {
                // create a new table as defined in the SQL Command. 
                if (DBUtils.AddColumnToTable(dbCon, "tbl_assetlogs", "TaskStatus", "VARCHAR(255) DEFAULT 'Completed' AFTER Comments") == false)
                {
                    MessageBox.Show(" Error: unable to insert column CurrentStatus into table pm schedule, contact Administrator");
                }
            }



        }






        private void SelectFrm_Load(object sender, EventArgs e)
        {
            // check to see if already running
            string appName = Utils.GetAppName();
            if (Utils.CheckIfAppAlreadyRunning(appName) == true)
            {
                MessageBox.Show(appName + " is already running!\n Exiting this application.");
                Close();
            }

            // check to see if there is a new applciation to udpate with
            if (Utils.checkForUpdate())
            {
                Application.Exit();
            }

            string dbCon = Settings.Default.eped_db1ConnectionString;



            // reset settings
            // Settings.Default.Reset();   // gcs: only used to reset one off in the event of a problem;

            this.BackColor = Globals.defaultformsbgCol;
            Globals.CurrVersion = Utils.GetVersion();
            Globals.DefUser = Settings.Default.DefaultUser;
            Globals.AppName = Utils.GetAppName();






            tbMessages.BackColor = Globals.defaultformsbgCol;

            string dbName = Settings.Default.DBName;
            string dbPassword = EncryptKey.Decrypt(Settings.Default.DBPassword);
            if (Settings.Default.DBPassword == "******") { dbPassword = "Effect2020"; }
            string dbServer = Settings.Default.ServerLocation;
            string dbUser = Settings.Default.DBUserName;


            // check default password and db connections are repalced
            if (!dbCon.Contains(dbServer)) { dbCon = dbCon.Replace("desk-brx-eped.ep.uk", dbServer); }
            if (!dbCon.Contains(dbName)) { dbCon = dbCon.Replace("eped", dbName); }
            if (!dbCon.Contains(dbUser)) { dbCon = dbCon.Replace("eped", dbUser); }
            if (dbCon.Contains("******")) { dbCon = dbCon.Replace("******", dbPassword); }


            Settings.Default["eped_db1ConnectionString"] = dbCon;


            if (!DBUtils.IsServerConnected(dbCon))
            {
                MessageBox.Show("Error: Check database connection \n Check network Connection \n " +
                    "if new install refer to Administrator \n Verify in settings, server connection to database",
                    "Database Connection error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var m = new DBConnString();
                m.Show();
                this.WindowState = FormWindowState.Minimized;
                return;
            }
            else
            {
                DBUtils.FetchDBSettings(dbCon, "tbl_settings", Globals.DefUser);
                Globals.AccessLevel = Int16.Parse(DBUtils.FetchUserLevelFromUser(dbCon, "tbl_users", Globals.DefUser));

            }

            if (Globals.AccessLevel <= 1)
            {
                button10.Visible = true;
            }
            else
            {
                button10.Visible = false;
            }


            // check for any new database changes 

            CheckForDatabaseChanges();

            // set up colour scheme if diffrent to defaults

            UpdateColourScheme();








            // check if local start up selected to another option:

            string startUpView = Properties.Settings.Default.StartupView;

            switch (startUpView)
            {
                case "AssetList All":
                    DisplayAssetsAll();
                    break;
                case "Calibration Due":
                    DisplayCalibrationDue();
                    break;
                case "Verification Due":
                    DisplayVerificationDue();
                    break;
                case "PAT Due":
                    DisplayPatDue();
                    break;
                case "Maintenance Logs":
                    DisplayCalibrationDue();
                    break;
                case "Job Schedules":
                    DisplayAssetSchedule();
                    break;
                case "Work Orders":
                    DisplayWorksOrders();
                    break;
                case "Settings":
                    DisplaySettings();
                    break;
                case "Parts List":
                    DisplayParts();
                    break;

                default:
                    // leave in this screen selections...
                    break;
            }
        }



        private void UpdateColourScheme()
        {
            string dbCon = Settings.Default.eped_db1ConnectionString;
            DataTable dtb = DBUtils.FetchDBTable(dbCon, "tbl_color");
            int red, green, blue;
            foreach (DataRow dr in dtb.Rows)
            {
                red = Int16.Parse(dr["Red"].ToString());
                green = Int16.Parse(dr["Green"].ToString());
                blue = Int16.Parse(dr["Blue"].ToString());
                if (dr["Allocation"].ToString() == "Default Forms BG") { defaultformsbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Settings BG") { settingsbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "PM grid cell BG") { pmgridcellbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "No PM cell BG") { nopmgridcellbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "OverDue BG") { pmoverduebgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Outstanding BG") { pmoutstandingbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Completed BG") { pmcompletedbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Grid current week BG") { gridcurrentweekbgCol = Color.FromArgb(red, green, blue); }
                if (dr["Allocation"].ToString() == "Asset not in use BG") { notinusebgCol = Color.FromArgb(red, green, blue); }

            }

        }


        private void DisplayAssetsAll()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AssetListFrm")
                {
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowAssetListFrm();
                m.ShowScreen = "ShowAll";
                m.Show();
                m.Activate();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DisplayAssetsAll();
        }

        private void DisplayPatDue()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AssetListFrm")
                {
                    f.Close();
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowAssetListFrm();
                m.ShowScreen = "PatDueShow";
                m.Show();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // PatDueShow
            DisplayPatDue();
        }

        private void DisplaySettings()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "SettingsFrm")
                {
                    IsOpen = true;
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowSettingsFrm();
                m.Show();
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            DisplaySettings();
        }

        private void DisplayMaintRecords()
        {

            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AssetLogsFrm")
                {
                    IsOpen = true;
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowAssetLogsFrm();
                m.Show();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DisplayMaintRecords();
        }


        private void DisplayCalibrationDue()
        {
            // CalibDueShow
            // check to see if already open somewhere
            WindowState = FormWindowState.Minimized;
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AssetListFrm")
                {
                    f.Close();
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowAssetListFrm();
                m.ShowScreen = "CalibDueShow";
                m.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayCalibrationDue();
        }


        private void DisplayAssetSchedule()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AssetScheduleFrm")
                {
                    IsOpen = true;
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowAssetScheduleFrm();
                m.Show();
            }
        }



        private void DisplayMPMSchedule()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AssetMPMScheduleFrm")
                {
                    IsOpen = true;
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowAssetPMScheduleFrm();
                m.Show();
                m.Activate();
               
            }
        }



        private void DisplayPMTasks()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "SelectTasksDialog")
                {
                    IsOpen = true;
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new SelectTasksDialog();
                m.ReturnToSelect = true;
                m.Show();
                m.Activate();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DisplayAssetSchedule();
        }


        private void DisplayParts()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "PartsListFrm")
                {
                    IsOpen = true;
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowPartsListFrm();
                m.Show();
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            DisplayParts();
        }

        private void DisplayWorksOrders()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "WorksOrderFrm")
                {
                    IsOpen = true;
                    f.Focus();
                    f.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowWorksOrderFrm();
                m.Show();
            }

        }


        private void button7_Click(object sender, EventArgs e)
        {
            DisplayWorksOrders();
        }
        private void DisplayVerificationDue()
        {
            // check to see if already open somewhere
            bool IsOpen = false;
            WindowState = FormWindowState.Minimized;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AssetListFrm")
                {
                    f.Close();
                    break;
                }
            }
            if (IsOpen == false)
            {
                var m = new ShowAssetListFrm();
                m.ShowScreen = "VerifyDueShow";
                m.Show();
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            // verification show
            DisplayVerificationDue();
        }


        private void EmailEquipmentDueForService(DataGridView dgv,string reportType)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {



                string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
                string sendto = "";
                string subject = "Assets Due to be serviced Report as at " + DateTime.Now.ToString("dd/MM/yyyy");
                string heading = "Listed below are equipment due for " + Settings.Default.PeriodForReporting + " " + reportType + " Report";
                string jobnote = "Total No of records listed : " + (dgv.Rows.Count - 1).ToString();
                string htmlStr = Utils.getHtmlForWO(dgv, heading, jobnote, reportType);
                // fetch email addresses to those receiving report
                if (Settings.Default.Email1Send)
                {
                    sendto = DBUtils.FetchStringFromDB
                    (dbCon, "tbl_users", "UserEmailAddress", "UserName", Settings.Default.Email1ReportTo);
                }
                if (Settings.Default.Email2Send)
                {

                    sendto = sendto + ";" + DBUtils.FetchStringFromDB
                    (dbCon, "tbl_users", "UserEmailAddress", "UserName", Settings.Default.Email2ReportTo);
                }

                if (emailSender.Send(sendto,
                    subject, htmlStr))
                {
                    // Mark as email bein sent
                    tbMessages.ForeColor = Color.Black;
                    tbMessages.Text = "Email sent successfully to  " + sendto + " as at " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    // MessageBox.Show("Email sent successfully to  " + sendto, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    tbMessages.ForeColor = Color.Red;
                    tbMessages.Text = "*** Error unable to send email to " + sendto + " as at " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "\n Error Message: " + Globals.retErrorMessage;
                    // Reset error message
                    Globals.retErrorMessage = "";
                    // MessageBox.Show("Error unable to send email ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch(Exception ex)
            {

                MessageBox.Show("Error in EmailEquipmentDueForService method, creating report to email\n" + ex.Message);

            }



            Cursor.Current = Cursors.Default;
        }


        private DataGridView PopulateMPMDataGridView(DataGridView dgv)
        {
            try
            {
                string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
                string siteName = "";// Settings.Default.DefaultSiteName;
                string downTime = "", tech = "", task = "", notes = "";
                DateTime dateNow = DateTime.Now;
                DateTime dueDate, startDate, firstStartDate;
                int fromWeekNo = 1, endWeekNo = 1, dueWeek = 1;
                Color overdue = Color.LightPink, duenow = Color.LightCoral, notdue = Color.LightGreen, bgCol = Color.White, fgCol = Color.Black;
                string startDateStr = "", freq = "";
                int remWeeks = Globals.reminderPeriodForMPM;
                string EquipmentDescription = "";
                string assetID = "";
                string inUse = "1";
                int periodForReportInWeeks = Utils.ConvertToWeeks(Settings.Default.PeriodForReporting);
                //    List<string> rowdata = new List<string>();
                DataTable dtb = new DataTable();

                dtb = DBUtils.FetchDBTable(dbCon, "tbl_pmschedule");
                DataRow row;
                int noOfRows = dtb.Rows.Count;
                // datenow = datenow.AddDays(30);
                dueDate = dateNow;
                fromWeekNo = Int16.Parse(Utils.GetWeekNo(dateNow));
                endWeekNo = Int16.Parse(Utils.GetWeekNo(dateNow.AddDays(7 * periodForReportInWeeks)));

                for (int i = 0; i < noOfRows; i++)
                {
                    row = dtb.Rows[i];
                    bgCol = Color.White;
                    fgCol = Color.Black;
                    assetID = row["EquipmentID"].ToString();
                    freq = row["Frequency"].ToString();
                    startDateStr = row["StartDate"].ToString();
                    tech = row["AssignedTech"].ToString();
                    task = row["Task"].ToString();
                    downTime = DBUtils.FetchStringFromDB(dbCon, "tbl_pmtasks", "EstimatedDownTime", "Task", task, "", false);
                    notes = DBUtils.FetchStringFromDB(dbCon, "tbl_pmtasks", "PerpetualNotes", "Task", task, "", false);
                    EquipmentDescription = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "EquipmentDescription", "EquipmentID", assetID);
                    siteName = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "SiteName", "EquipmentID", assetID);
                    inUse = DBUtils.FetchStringFromDB(dbCon, "tbl_assetregister", "InUse", "EquipmentID", assetID);

                    startDate = Convert.ToDateTime(startDateStr);
                    // check that this is teh correct current week
                    firstStartDate = Utils.DetermineStartDateForYear(startDate, freq);
                    //if (freq == "WEEKLY") { firstStartDate = Utils.FirstDateOfWeek(dateNow.Year, 1); }
                    // check asset start date is ready to be considered
                    if (dateNow > startDate)
                    {
                        if (firstStartDate.Year < dateNow.Year)
                        {
                            firstStartDate = firstStartDate.AddYears(dateNow.Year - firstStartDate.Year);
                        }

                        // initise startdate
                        dueDate = firstStartDate;
                        dueWeek = Int16.Parse(Utils.GetWeekNo(dueDate));
                        // if we are at week 1
                        if ((dueWeek >= fromWeekNo) && (dueWeek <= endWeekNo))
                        {
                            dgv = AddtoDGV(dgv, siteName, inUse, task, notes, assetID, EquipmentDescription, freq, dueDate.ToString("yyyy/MM/dd"), downTime, tech, fgCol);
                        }

                        // loop through consecutive weeks to get to current week
                        for (int j = 1; j < 53; j++)
                        {
                            dueDate = Utils.DetermineNextDate(dueDate, freq);
                            dueWeek = Int16.Parse(Utils.GetWeekNo(dueDate));
                            if ((dueWeek >= fromWeekNo) && (dueWeek <= endWeekNo))
                            {
                                dgv = AddtoDGV(dgv, siteName, inUse, task, notes, assetID, EquipmentDescription, freq, dueDate.ToString("yyyy/MM/dd"), downTime, tech, fgCol);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in PopulateMPMDataGridView \n" + ex.Message);
            }

            return dgv;
        }


        private static DataGridView AddtoDGV(DataGridView dgv, string siteName, string inUse, string task, string notes, string equipmentID, string equipmentDescription, string testType, string dueDate, string downTime,string tech,Color fgCol)
        {
            int curRow = 0;
            string defSiteName = Properties.Settings.Default.DefaultSiteName;

            if ((siteName == defSiteName) || (defSiteName == "ALL"))
            {
                if ((inUse == "1") || (Settings.Default.ReportOnInUseOnly == false))
                {

                    dgv.Rows.Add(equipmentID, equipmentDescription, task, dueDate, downTime,tech,notes);
                    curRow = dgv.Rows.Count - 1;
                    dgv.Rows[curRow].DefaultCellStyle.ForeColor = fgCol;
                }
            }
            return dgv;

        }



        private static DataGridView PopulateDataGridView(DataGridView dgv)
        {
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
            string siteName = Settings.Default.DefaultSiteName;
            DateTime datenow = DateTime.Now;
            DateTime duedate, repdate;
            Color overdue = Color.LightPink, duenow = Color.LightCoral, notdue = Color.LightGreen, bgCol = Color.White, fgCol = Color.Black;
            string assetID = "";
            string equipmentDescription = "";
            string freq = "";
            string duedateStr = "";
       
            string tech = "";
            string testtype;
            string downTime = "";
            bool addtoreport = false;
            int remWeeks = 4;
            //    List<string> rowdata = new List<string>();
            DataTable dtb = new DataTable();

            dtb = DBUtils.FetchDBTable(dbCon, "tbl_assetregister");
            DataRow row;
            int noOfRows = dtb.Rows.Count;
            string inUse = "1";
            // datenow = datenow.AddDays(30);

            for (int i = 0; i < noOfRows; i++)
            {
                freq = "";
                row = dtb.Rows[i];
                duedate = datenow;
                addtoreport = false;
                testtype = "MIS";
                assetID = row["EquipmentID"].ToString();
                inUse= row["InUse"].ToString();
                equipmentDescription = row["EquipmentDescription"].ToString();
                siteName = row["SiteName"].ToString();
                bgCol = Color.White;
                fgCol = Color.Black;
                if (row["CalibrationRequired"].ToString() == "1")
                {
                    testtype = "CAL";
                    freq = row["CalibrationInterval"].ToString();
                    duedateStr = row["DateCalibrationDue"].ToString();
                    if (duedateStr != "") { duedate = Convert.ToDateTime(duedateStr); }
                    remWeeks = Utils.ConvertToWeeks(row["ReminderPeriodForCalibration"].ToString());
                    repdate = datenow.AddDays(remWeeks * 7);
                    if (Settings.Default.ReportOnBlankDueDates | (duedateStr != ""))
                    {
                        if ((datenow < duedate) && (duedate <= repdate))
                        {
                            fgCol = duenow;
                            addtoreport = true;
                        }
                        if ((repdate >= duedate) && reportOnOverDue)
                        {
                            fgCol = overdue;
                            addtoreport = true;
                        }
                    }
                }
                if (row["VerificationRequired"].ToString() == "1")
                {
                    testtype = "VER";
                    freq = row["VerificationInterval"].ToString();
                    duedateStr = row["DateVerificationDue"].ToString();
                    if (duedateStr != "") { duedate = Convert.ToDateTime(duedateStr); }
                    remWeeks = Utils.ConvertToWeeks(row["ReminderPeriodForVerification"].ToString());
                    repdate = datenow.AddDays(remWeeks * 7);
                    if (Settings.Default.ReportOnBlankDueDates | (duedateStr != ""))
                    {
                        if ((datenow < duedate) && (duedate <= repdate))
                        {
                            fgCol = duenow;
                            addtoreport = true;
                        }
                        if ((repdate >= duedate)&& reportOnOverDue)
                        {
                            fgCol = overdue;
                            addtoreport = true;
                        }
                    }
                }

                if (row["PATTestRequired"].ToString() == "1")
                {
                    testtype = "PAT";
                    freq = row["PATInterval"].ToString();
                    duedateStr = row["DatePATDue"].ToString();
                    if (duedateStr != "") { duedate = Convert.ToDateTime(duedateStr); }
                    remWeeks = Utils.ConvertToWeeks(row["ReminderPeriodForPAT"].ToString());
                    repdate = datenow.AddDays(remWeeks * 7);
                    if (Settings.Default.ReportOnBlankDueDates | (duedateStr != ""))
                    {
                        if ((datenow < duedate) && (duedate <= repdate))
                        {
                            fgCol = duenow;
                            addtoreport = true;
                        }
                        if ((repdate >= duedate) && reportOnOverDue)
                        {
                            fgCol = overdue;
                            addtoreport = true;
                        }
                    }
                }

                if (addtoreport)
                {
                    dgv = AddtoDGV(dgv, siteName, inUse,testtype, row["Notes"].ToString(), assetID, equipmentDescription, freq, duedate.ToString("yyyy/MM/dd"), downTime, tech, fgCol);
          
                }

            }
            return dgv;
        }





        private static DataGridView SetUpDataGridView(DataGridView dgv)
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
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].Name = "Asset ID";
            dgv.Columns[1].Name = "Description";
            dgv.Columns[2].Name = "TestType";
            dgv.Columns[3].Name = "Due Date";
            dgv.Columns[4].Name = "Notes";
            dgv.Columns[4].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Italic);
            return dgv;
        }


        private static DataGridView SetUpDataPMGridView(DataGridView dgv)
        {
            dgv.ColumnCount = 7;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Black;
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].Name = "Asset ID";
            dgv.Columns[1].Name = "Description";
            dgv.Columns[2].Name = "TestType";
            dgv.Columns[3].Name = "Due Date";
            dgv.Columns[4].Name = "Down Time";
            dgv.Columns[5].Name = "Technician";
            dgv.Columns[6].Name = "Notes";
            dgv.Columns[6].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Italic);
            return dgv;
        }



        private void CreateEmailMPMReport()
        {
            DataGridView dgv = new DataGridView();
            dgv = SetUpDataPMGridView(dgv);
            PopulateMPMDataGridView(dgv);
            // sort by due date asscending
            dgv.Sort(dgv.Columns["Due Date"], ListSortDirection.Ascending);
            EmailEquipmentDueForService(dgv,"PMSchedule");

            Settings.Default.ReportCreated = true;
            Settings.Default.Save();
        }


        private void CreateEmailReport()
        {
            DataGridView dgv = new DataGridView();
            dgv = SetUpDataGridView(dgv);
            PopulateDataGridView(dgv);
            // sort by due date asscending
            dgv.Sort(dgv.Columns["Due Date"], ListSortDirection.Ascending);
            EmailEquipmentDueForService(dgv, "Cal/Ver/PAT");

            Settings.Default.ReportCreated = true;
            Settings.Default.Save();
        }

        private void CreatePrintReport()
        {
            Settings.Default.ReportCreated = true;
            Settings.Default.Save();
        }


        public void SendReport()
        {

                        if (Settings.Default.EmailReport)
                        {
                            {
                                Settings.Default.ReportCreated = true;
                                if (Settings.Default.DueForServiceReport) { CreateEmailReport(); }
                                if (Settings.Default.DueForMPMReport) { CreateEmailMPMReport(); }
                            }
                        }
                        if (Settings.Default.PrintReport)
                        {
                            {
                                Settings.Default.ReportCreated = true;
                                if (Settings.Default.DueForServiceReport) { CreatePrintReport(); }
                            }
                        }



        }




        private void checkschedulereporting()
        {
            if (Settings.Default.EmailReport | Settings.Default.PrintReport)
            {
                if (Utils.ReportDue(Settings.Default.DayToReport, Settings.Default.PeriodForReporting))
                {
                    if (Settings.Default.ReportCreated == false)
                    {
                        SendReport();


                        Settings.Default.Save();
                    }
                }
                else
                {
                    Settings.Default.ReportCreated = false;
                    Settings.Default.Save();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
            if ((Settings.Default.DueForServiceReport) | (Settings.Default.DueForMPMReport))
            { checkschedulereporting(); }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DisplayMPMSchedule();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            DisplayPMTasks();
        }

        private void SelectFrm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        // end 
    }
}
