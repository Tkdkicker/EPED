using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Deployment.Application;


namespace EPED
{
    class Utils
    {
        public static bool CheckIfAppAlreadyRunning(string appName)
        {
            // enure this is the only app running on this computer
            if(Process.GetProcessesByName(appName).Length > 1)
            {
                return true;
            }
            return false;
        }


        public static bool checkForUpdate()
        {
            DialogResult retval;
            bool updatedue = true;
            string updatefile;
            string updatelocation;
            string nl = Environment.NewLine;
            DateTime currentLWTDate;
            DateTime updateLWTDate;
            try
            {
                updatefile = Properties.Settings.Default.ApplicationUpdateLocation;
                updatelocation = Path.GetDirectoryName(updatefile).ToString();
                currentLWTDate = File.GetLastWriteTime(Application.ExecutablePath);
                updateLWTDate = System.IO.File.GetLastWriteTime(updatefile);
                string temp = Application.ExecutablePath.ToString();
                TimeSpan elapsedtime = (updateLWTDate - currentLWTDate);
                if (elapsedtime.Minutes > 5)
                {
                    retval = MessageBox.Show("Update available do you wish to update?" + nl + "New Update dated " +
                        updateLWTDate.ToString("dd/MM/yy HH:mm") + nl + "Current is dated " + currentLWTDate.ToString("dd/MM/yy HH:mm"),
                        "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (retval == DialogResult.Yes)
                    {
                        Process.Start(updatelocation + @"\setup.exe", "");
                        updatedue = true;
                    }
                }
                else
                {
                    updatedue = false;
                }
            }

            catch (Exception)
            {
                updatedue = false;
            }
            return updatedue;
        }

        public static string GetVersion()
        {
            //  string value = AppDomain.CurrentDomain.DomainManager.EntryAssembly.GetName().Version.ToString();
            // var version = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location);
            //Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            string value = "";
            //  value = version.FileVersion.ToString();
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                value = string.Format("v{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
            else
            {
                value = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString("yyyy.MM.dd.HH.mm.ss").ToString();
            }
            // value = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString("yyyy.MM.dd.HH.mm.ss").ToString();
            //value = string.Format("{0}.{1}.{2}.{3}", version.FileMajorPart, version.FileMinorPart, version.FilePrivatePart, version.FileVersion);
            return value;
        }

        public static string GetAppName()
        {

            //  string value = AppDomain.CurrentDomain.DomainManager.EntryAssembly.GetName().Name;
            string value = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return value;
        }

        public static string GetWeekNo(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum.ToString();
        }

        public static DateTime FirstDateOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            // Use first Thursday in January to get first week of the year as
            // it will never be in Week 52/53
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            // As we're adding days to a date in Week 1,
            // we need to subtract 1 in order to get the right date for week #1
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            // Using the first Thursday as starting week ensures that we are starting in the right year
            // then we add number of weeks multiplied with days
            var result = firstThursday.AddDays(weekNum * 7);

            // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
            return result.AddDays(-3);
        }




        public static DialogResult InputBox(string title, string promptText, bool hideInput, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

           
            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;
            if (hideInput == true)
            {
                textBox.PasswordChar = char.Parse("*");
            }

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.TopMost = false;
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }


        public static int Num(string valueStr)
        {
            int iValue;
            try
            {
                var value = Regex.Match(valueStr, @"\d+").Value;
                iValue = Int16.Parse(value);
            }
            catch (Exception)
            {
                iValue = 0;
            }
            return iValue;
        }

        public static string AlphaOnly(string valueStr)
        {
            string sValue;
            try
            {
                var value = Regex.Match(valueStr, @"[a-zA-Z]+").Value;
                sValue = value;
            }
            catch (Exception)
            {
                sValue = "";
            }
            return sValue;
        }




        public static string dgvColumnsHeaderText(DataGridView dgv, List<int> colsPrint, int[] colWidth, bool padData)
        {
            string gData, value = "";
            foreach (int i in colsPrint)
            {
                gData = dgv.Columns[i].HeaderText;
                if (padData)
                {
                    value = value + gData.PadRight(colWidth[i]);
                }
                else
                {
                    value = value + gData + ",";
                }
            }
            return value;
        }



        public static int ConvertToWeeks(string periodStr)
        {
            int number, value;

            // trap incase there was null string
            if (periodStr == "") { periodStr = "0"; }

            number = Utils.Num(periodStr);
            if (number == 0) { number = 1; }
            value = number;

            if (periodStr.ToUpper().Contains("MONTH")) { value = (int)(Math.Ceiling(number * ((double)52 / 12))); }
            if (periodStr.ToUpper().Contains("MNT")) { value = (int)(Math.Ceiling(number * ((double)52 / 12))); }
            if (periodStr.ToUpper().Contains("YEAR")) { value = number * 52; }
            if (periodStr.ToUpper().Contains("DAY")) { value = (number / 7) + 1; }
            if (periodStr.ToUpper().Contains("WEEK")) { value = number; }
            return value;
        }


        public static string NewJobId(string lastJobID)
        {
            //format WOYYMMDDX
            string dd, cm, cy, pn, pnbase;
            int lastIndex = 0;

            pn = "WOXXXXXX";
            // trap if there are no jobs picked up
            if (lastJobID == "") { lastJobID = pn; }
            cm = DateTime.Now.ToString("MM");
            cy = DateTime.Now.ToString("yy");
            dd = DateTime.Now.ToString("dd");
            pnbase = "WO" + cy + cm + dd;
            if (lastJobID.Substring(0, 8) == pnbase)
            {
                lastIndex = Int16.Parse(lastJobID.Substring(8, 2));
            }
            else
            {
                lastIndex = 0;
            }
            lastIndex = lastIndex + 1;
            pn = pnbase + lastIndex.ToString("00");
            return pn;
        }

        public static string getHtmlForWO(DataGridView grid, string heading, string notes, string reportType)
        {
            try
            {
                Color fgCol = Color.Black;
                string messageBody = "<font>" + heading + " </font><br><br>";
                if (grid.Rows[0].Cells[0].Value == null)
                {
                    notes = " No Records Listed ";
                    messageBody = messageBody + "<font>" + notes + "</font><br><br>";
                    return messageBody;
                }
                messageBody = messageBody + "<font>" + notes + "</font><br><br>";
                if (grid.RowCount == 0) return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style=\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style=\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";
                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                // depending upon report
                if (reportType == "Cal/Ver/PAT")
                {
                    messageBody += htmlTdStart + "Asset ID" + htmlTdEnd;
                    messageBody += htmlTdStart + "Description" + htmlTdEnd;
                    messageBody += htmlTdStart + "Task" + htmlTdEnd;
                    messageBody += htmlTdStart + "Due Date" + htmlTdEnd;
                    messageBody += htmlTdStart + "Notes" + htmlTdEnd;
                    messageBody += htmlHeaderRowEnd;
                    //Loop all the rows from grid vew and added to html td  
                    for (int i = 0; i <= grid.RowCount - 1; i++)
                    {
                        //fgCol = grid.Rows[i].DefaultCellStyle.ForeColor;
                        // htmlTdStart = "<td style=\"color:" + fgCol.Name + "\"border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                        messageBody = messageBody + htmlTrStart;
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd; //asset id
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd; //description  
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd; //testtype 
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[3].Value + htmlTdEnd; //duedate
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[4].Value + htmlTdEnd; //notes
                        messageBody = messageBody + htmlTrEnd;
                    }
                }
                if (reportType == "PMSchedule")
                {


                    messageBody += htmlTdStart + "Asset ID" + htmlTdEnd;
                    messageBody += htmlTdStart + "Description" + htmlTdEnd;
                    messageBody += htmlTdStart + "Task" + htmlTdEnd;
                    messageBody += htmlTdStart + "Due Date" + htmlTdEnd;
                    messageBody += htmlTdStart + "Down Time" + htmlTdEnd;
                    messageBody += htmlTdStart + "Technician" + htmlTdEnd;
                    messageBody += htmlTdStart + "Notes" + htmlTdEnd;
                    messageBody += htmlHeaderRowEnd;
                    //Loop all the rows from grid vew and added to html td  
                    for (int i = 0; i <= grid.RowCount - 1; i++)
                    {
                        //fgCol = grid.Rows[i].DefaultCellStyle.ForeColor;
                        // htmlTdStart = "<td style=\"color:" + fgCol.Name + "\"border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                        messageBody = messageBody + htmlTrStart;
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[0].Value + htmlTdEnd; //asset id
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[1].Value + htmlTdEnd; //description  
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[2].Value + htmlTdEnd; //testtype 
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[3].Value + htmlTdEnd; //duedate
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[4].Value + htmlTdEnd; //down time
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[5].Value + htmlTdEnd; //technician
                        messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[6].Value + htmlTdEnd; //notes
                        messageBody = messageBody + htmlTrEnd;
                    }

                }

                messageBody = messageBody + htmlTableEnd;
                messageBody = messageBody + "<br><br><font>Message From EPED Scheduler</font><br><br>";
                return messageBody; // return HTML Table as string from this function  
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.Message);
                return "";
            }
        }

        private static string ReplaceSpecialCharacters(string str)
        {
            // taken allowed: "\"",, ":", "/", "%", "&"
            string[] chars = new string[] { ",", ".", "!", "@", "#", "$", "^", "*", "'", ";", "_", "(", ")", "|", "[", "]" };
            //Iterate the number of times based on the String array length.
            for (int i = 0; i < chars.Length; i++)
            {
                if (str.Contains(chars[i]))
                {
                    str = str.Replace(chars[i], "");
                }
            }
            return str;

        }


        /// <summary>
        /// This email uses default email applcation loaded with some info before hand.
        /// </summary>
        /// <param name="EmailAddress"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <param name="AttachmentFile"></param>
        /// <returns></returns>
        public static bool OpenEmail(string EmailAddress, string Subject = "", string Body = "", string AttachmentFile = "")
        {
            // this one opens local mail system window but requires operator to click send
            bool bAns = true;
            string sParams;


            sParams = EmailAddress;
            //   Dim line
            if (sParams == "") { sParams = "mailto: ";}
            if (sParams.Substring(0, 7).ToLower() != "mailto:") { sParams = "mailto:" + sParams; }
            if (Subject != "") { sParams = sParams + "?subject=" + Subject; }
            
            if (Body != "")
            {

                if (Subject == "") { sParams=sParams + "?"; } else { sParams = sParams + "&"; }
                Body = ReplaceSpecialCharacters(Body);
               // Body = string.Format("<font face='calibri,arial,sans-serif'>{0}<font/>", Body.Replace("\r\n", "<br>"));
                sParams = sParams + "body=" + Body;
            }
            try
            {
                

                System.Diagnostics.Process.Start(sParams);
            }

            catch (Exception)
            {
                bAns = true;
            }

            return bAns;
        }



        /// <summary>
        /// this is the automatic background email using smtp.
        /// </summary>
        /// <param name="mailtoaddress"></param>
        /// <param name="subject"></param>
        /// <param name="htmlString"></param>
        /// <returns></returns>
        public static bool Email(string mailtoaddress, string subject, string htmlString)
        {
            string[] sendtoList;
            sendtoList = mailtoaddress.Split(';');
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(Globals.MailFromAddress);
                //message.Sender= new MailAddress(Globals.MailFromAddress);
                foreach (string person in sendtoList)
                {
                    if (person.Trim() != "")
                    {
                        message.To.Add(new MailAddress(person));
                    }
                }
                
                message.Sender = message.From;
                message.Subject = subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                //message.BodyEncoding = System.Text.Encoding.UTF8;
                //message.SubjectEncoding = System.Text.Encoding.UTF8;
                smtp.Port = Int16.Parse(Globals.MailPortAddress);
                //smtp.TargetName = "STARTTLS/smtp.office365.com";
                smtp.Host = Globals.MailSmtpServer; //for mail host  
                // if port 25 used then SSL is not required
                if (smtp.Port == 25) { smtp.EnableSsl = false; } else { smtp.EnableSsl = true; }
                smtp.UseDefaultCredentials = false;
                // increased due to long delay with ms azure increased from 10secs to 15 secs 24/07/2021.
                smtp.Timeout = 15000;
                smtp.Credentials = new NetworkCredential(Globals.MailLoginAddress, Globals.MailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                // settling time added GCS 27/03/2021
                System.Threading.Thread.Sleep(200);
                smtp.Send(message);
                smtp.Dispose();
                message.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Globals.retErrorMessage = ex.Message;
                // gcs test
                MessageBox.Show("Error in Utils.Email \n" + ex.Message);
                return false;
            }
            finally
            {
                
            }

        }


        public static bool ReportDue(string daytoreport, string periodforreporting)
        {
            DateTime duedate = DateTime.Now;
            DayOfWeek repdow;
            bool retval = false;

            switch (daytoreport)
            {
                case "Monday":
                    repdow = DayOfWeek.Monday;
                    break;
                case "Tuesday":
                    repdow = DayOfWeek.Tuesday;
                    break;
                case "Wednesday":
                    repdow = DayOfWeek.Wednesday;
                    break;
                case "Thursday":
                    repdow = DayOfWeek.Thursday;
                    break;
                case "Friday":
                    repdow = DayOfWeek.Friday;
                    break;
                case "Saturday":
                    repdow = DayOfWeek.Saturday;
                    break;
                case "Sunday":
                    repdow = DayOfWeek.Sunday;
                    break;

                default:
                    repdow = DayOfWeek.Monday;
                    break;
            }

            switch (periodforreporting)
            {
                case "Daily":
                    if ((duedate.DayOfWeek != DayOfWeek.Saturday) && (duedate.DayOfWeek != DayOfWeek.Sunday)) { retval = true; }
                    break;
                case "Weekly":
                    if (duedate.DayOfWeek == repdow) { retval = true; }
                    break;
                case "Monthly":
                    if ((duedate.DayOfWeek == repdow) && (duedate.Day <= 7)) { retval = true; }
                    break;
                case "Yearly":
                    if ((duedate.DayOfWeek == repdow) && (duedate.Day <= 7) && (duedate.Month == 1)) { retval = true; }
                    break;

            }

            return retval;
        }





        public static int GetColIndex(DataGridView dgv, string colname)
        {
            int retval = -1;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].DataPropertyName == colname)
                {
                    retval = i;
                    break;
                }
            }
            return retval;
        }



        public static bool WriteReportFile(DataGridView dgv, string title, string fpn, List<int> colsPrint, bool padData)
        {
            int iRow, iCol;
            string sData, colsHeader;
            try
            {
                System.IO.StreamWriter writer = System.IO.File.CreateText(fpn);
                sData = title;
                writer.WriteLine(sData);
                writer.WriteLine("");
                int[] colWidth = new int[dgv.Columns.Count];
                // work out width of each column for print offs with padding.
                for (iCol = 0; iCol < dgv.Columns.Count; iCol++)
                {
                    colWidth[iCol] = dgv.Columns[iCol].Width / 5;
                }
                colsHeader = Utils.dgvColumnsHeaderText(dgv, colsPrint, colWidth, padData);
                writer.WriteLine(colsHeader);
                writer.WriteLine("");
                // ensure dgv has addnewrow=false otherwise new row will cause count issue.
                for (iRow = 0; iRow < dgv.Rows.Count; iRow++)
                {
                    foreach (int Col in colsPrint)
                    {
                        sData = "";
                        if (dgv.Columns[Col].ValueType == typeof(DateTime))
                        {
                            if (!(Convert.IsDBNull(dgv.Rows[iRow].Cells[Col].Value)))
                            {
                                sData = Convert.ToDateTime(dgv.Rows[iRow].Cells[Col].Value.ToString()).ToString("dd/MM/yyyy").ToString();
                            }
                            else
                            {
                                sData = "No Date";
                            }
                        }
                        else
                        {
                            sData = dgv.Rows[iRow].Cells[Col].Value.ToString();
                            //if (sData == "1") sData = "\u2714";  // bold tick
                            //if (sData == "0") sData = " ";
                            // strip out any commas ( causes confusion in Excel CSV fies.
                            sData = sData.Replace(",", " ");
                        }

                        if (padData)
                        {
                            writer.Write(sData.PadRight(colWidth[Col]));
                        }
                        else
                        {
                            writer.Write(sData + ",");
                        }
                    }
                    writer.Write("\n");
                }

                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Creating text file \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        /// <summary>
        /// This function works out the first weekno for the frequency of the mainatenance
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="freq"></param>
        /// <returns></returns>
        public static int DetermineStartWeekNo(DateTime startDate, string freq)
        {
            int retval = Int16.Parse(Utils.GetWeekNo(startDate));
            DateTime dueDate = startDate;

            for (int i = 1; i <= 52; i++)
            {
                switch (freq)
                {
                    case "WEEKLY":
                        dueDate = dueDate.AddDays(7);
                        break;
                    case "FORTNIGHTLY":
                        dueDate = dueDate.AddDays(14);
                        break;
                    case "MONTHLY":
                        dueDate = dueDate.AddMonths(1);
                        break;
                    case "QUARTERLY":
                        dueDate = dueDate.AddMonths(3);
                        break;
                    case "6MONTHS":
                        dueDate = dueDate.AddMonths(6);
                        break;
                    case "YEARLY":
                        dueDate = dueDate.AddYears(1);
                        break;
                }

                if (dueDate.Month < startDate.Month)
                {
                    return Int16.Parse(Utils.GetWeekNo(dueDate));
                }
            }
            return retval;
        }

        public static DateTime DetermineStartDateForYear(DateTime startDate, string freq)
        {
            DateTime retval = startDate;
            DateTime dueDate = startDate;

            for (int i = 1; i <= 52; i++)
            {
                switch (freq)
                {
                    case "WEEKLY":
                        dueDate = dueDate.AddDays(7);
                        if (dueDate.Month < startDate.Month)
                        {
                        // this is for next year hence subtract a year to get current year
                            dueDate = dueDate.AddDays(-364);
                            return dueDate;
                        }
                        break;
                    case "FORTNIGHTLY":
                        dueDate = dueDate.AddDays(14);
                        if (dueDate.Month < startDate.Month)
                        {
                            // this is for next year hence subtract a year to get current year
                            dueDate = dueDate.AddDays(-364);
                            return dueDate;
                        }
                        break;
                    case "MONTHLY":
                        dueDate = dueDate.AddMonths(1);
                        if (dueDate.Month < startDate.Month)
                        {
                            // this is for next year hence subtract a year to get current year
                            dueDate = dueDate.AddMonths(-12);
                            return dueDate;
                        }
                        break;
                    case "QUARTERLY":
                        dueDate = dueDate.AddMonths(3);
                        if (dueDate.Month < startDate.Month)
                        {
                            // this is for next year hence subtract a year to get current year
                            dueDate = dueDate.AddMonths(-12);
                            return dueDate;
                        }

                        break;
                    case "6MONTHS":
                        dueDate = dueDate.AddMonths(6);
                        if (dueDate.Month < startDate.Month)
                        {
                            // this is for next year hence subtract a year to get current year
                            dueDate = dueDate.AddMonths(-12);
                            return dueDate;
                        }
                        break;
                    case "YEARLY":
                        dueDate = dueDate.AddYears(1);
                        if (dueDate.Month < startDate.Month)
                        {
                            // this is for next year hence subtract a year to get current year
                            dueDate = dueDate.AddYears(-1);
                            return dueDate;
                        }
                        break;
                }
            }
            return startDate;
        }





        /// <summary>
        /// This function works out the next due date from prevoius date
        /// </summary>
        /// <param name="thisDate"></param>
        /// <param name="freq"></param>
        /// <returns></returns>
        public static DateTime DetermineNextDate(DateTime thisDate, string freq)
        {

            DateTime dueDate = thisDate;
            switch (freq)
            {
                case "WEEKLY":
                    dueDate = dueDate.AddDays(7);
                    break;
                case "FORTNIGHTLY":
                    dueDate = dueDate.AddDays(14);
                    break;
                case "MONTHLY":
                    dueDate = dueDate.AddMonths(1);
                    break;
                case "QUARTERLY":
                    dueDate = dueDate.AddMonths(3);
                    break;
                case "6MONTHLY":
                    dueDate = dueDate.AddMonths(6);
                    break;
                case "YEARLY":
                    dueDate = dueDate.AddYears(1);
                    break;
            }
            if (thisDate.Year == dueDate.Year)
            {
                return dueDate;
            }
            else
            {
                if (Utils.GetWeekNo(dueDate) != "52")
                {
                    return thisDate;
                }
                else
                {
                    return dueDate;
                }

            }


        }



        // end
    }// end of class

}
