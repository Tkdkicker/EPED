using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EPED
    {
    public partial class ShowPartsListFrm : Form
        {
        string SearchOnName = "SupplierPartNo";
        public ShowPartsListFrm()
            {
            InitializeComponent();
            }
        private void DisplayHeadings()
        {
            DateTime timenow = DateTime.Now;
            this.Text = Globals.AppName + " -Parts List Register - " + "Version (" + Globals.CurrVersion + ")   Week No: " + Utils.GetWeekNo(timenow) + " Time now " + timenow.ToString() + " " + " User " + Globals.DefUser;
        }

        private void PartsListFrm_Load(object sender, EventArgs e)
            {

            this.BackColor = Globals.defaultformsbgCol;
            cmbSiteName.Text = Properties.Settings.Default.DefaultSiteName;


            if (cmbSiteName.Text == "ALL")
            {
                tbl_partslistTableAdapter.Fill(this.eped_db1DataSet.tbl_partslist);
            }
            else
            {
                tbl_partslistTableAdapter.FillBySiteName(this.eped_db1DataSet.tbl_partslist, cmbSiteName.Text);
            }

            tbl_partslistDataGridView.DefaultCellStyle.Font= new Font("Calibra Light", 9);

            UpdateComboBoxes();

            if (Globals.AccessLevel > 2)
            {
                panel4.Enabled = false;
                tbl_partslistBindingNavigator.DeleteItem.Visible = false;
                tbl_partslistBindingNavigator.AddNewItem.Visible = false;
                tbl_partslistBindingNavigatorSaveItem.Visible = false;
            }

            UpdateGridViewRowColors();

            lastFittedDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            nextDueDateTimePicker.CustomFormat = "dd/MMM/yyyy";
        }


        private void tbl_partslistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            {
            this.Validate();
            this.tbl_partslistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);

            }

        private void UpdateComboBoxes()
            {
            List<string> valuelist = new List<string>();
            string dbCon = Properties.Settings.Default.eped_db1ConnectionString;
   
            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_partslist", "GroupAllocation");
            valuelist.Sort();
            groupAllocationComboBox.Items.Clear();
            groupAllocationComboBox.Items.AddRange(valuelist.ToArray());
            cmbGroupAllocation.Items.Clear();
            cmbGroupAllocation.Items.Add("CLEAR ALLOCATION");
            cmbGroupAllocation.Items.AddRange(valuelist.ToArray());
            cmbSetGroupAllocation.Items.Clear();
            cmbSetGroupAllocation.Items.Add("CLEAR ALLOCATION");
            cmbSetGroupAllocation.Items.AddRange(valuelist.ToArray());

            valuelist = DBUtils.FetchDistinctListOfValues(dbCon, "tbl_assetregister", "SiteName");
            valuelist.Sort();
            siteNameComboBox.Items.Clear();
            siteNameComboBox.Items.AddRange(valuelist.ToArray());
            cmbSiteName.Items.Clear();
            cmbSiteName.Items.Add("ALL");
            cmbSiteName.Items.AddRange(valuelist.ToArray());

        }




        private void Button3_Click(object sender, EventArgs e)
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

        private void Button6_Click(object sender, EventArgs e)
            {
            //'Set to Group Allocation:' combobox on the right
            cmbSetGroupAllocation.Text = InputValidation.UserValidationInput(cmbSetGroupAllocation.Text);

            //'Site Name:' combobox on the right
            siteNameComboBox.Text = InputValidation.UserValidationInput(siteNameComboBox.Text);

            //Group Allocation:' combobox on the right
            groupAllocationComboBox.Text = InputValidation.UserValidationInput(groupAllocationComboBox.Text);

            try
            {
                Properties.Settings.Default.Save();
                this.Validate();
                this.tbl_partslistBindingSource.EndEdit();
                this.tbl_partslistTableAdapter.Update(eped_db1DataSet.tbl_partslist);
                UpdateComboBoxes();
                MessageBox.Show("Update Successful");
                Globals.ChangesMade = false;
                }
            catch
                {
                MessageBox.Show("Update Failed");
                }
            }

        private void Button5_Click(object sender, EventArgs e)
            {
            Globals.ChangesMade = true;
            tbl_partslistBindingSource.AddNew();
            }

        private void ExportPartsData()
            {
            string filePathName;
            string filename = DateTime.Now.ToString("yyymmdd") + "_Parts_Report";
            List<int> colsPrint = new List<int>();

            if (Utils.InputBox("Data For Excel", "Type Name for Exported Data file", false, ref filename) == DialogResult.OK)
            {
                for (int i = 0; i < tbl_partslistDataGridView.ColumnCount; i++)
                    {
                    colsPrint.Add(i);
                    }
                // repalce any spaces with _ in file name it creates an exception unless encompassing within quotes.
                filename = filename.Replace(' ','_');

                filePathName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + filename + ".csv";
                string title = "Parts List Report generated on " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                if (Utils.WriteReportFile(tbl_partslistDataGridView, title, filePathName, colsPrint, false))
                    {
                    MessageBox.Show("Exported filename and location: \n" + filePathName);
                    }
                }
            }

        private void ImportPartsListFileData(string fpn)
            {
            string colsHeader="", gData;


            for (int i = 0; i < tbl_partslistDataGridView.Columns.Count; i++)
                {
                gData = tbl_partslistDataGridView.Columns[i].HeaderText;
                colsHeader = colsHeader + gData+","; 
                }

            string strLine;
            string[] strSplit;
            bool headerFound = false;

            try
                {
                System.IO.StreamReader reader = new System.IO.StreamReader(fpn);

                while (!reader.EndOfStream)
                    {
                    strLine = reader.ReadLine();
                    if((strLine+",")== colsHeader)
                        {
                        strLine = reader.ReadLine();
                        headerFound = true;
                        Globals.ChangesMade = true;
                        }
                    if (headerFound)
                        {

                        strSplit = strLine.Split(',');
                        if(strSplit[0] != "")
                            {
                            tbl_partslistBindingSource.AddNew();
                            // make a dynamic row by cloning current datarow, an issue if there is no data at start 
                            DataGridViewRow row = (DataGridViewRow)tbl_partslistDataGridView.RowTemplate.Clone();
                            // ammend the data to what we have then add the dynamic row to the datagridview.
                            Refresh();
                            for (int i = 0; i < strSplit.Count() ; i++)
                                {
                                tbl_partslistDataGridView.Rows[tbl_partslistDataGridView.Rows.Count-1].Cells[i].Value = strSplit[i];
                                }
                            Refresh();
                            }
                        }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            Globals.ChangesMade = true;
            //SearchOnFilter("");
            UpdateGridViewRowColors();




            }




        private void ImportPartsData()
            {
            string filePathName;
            string fileName;
            OpenFileDialog fd = new OpenFileDialog();

            filePathName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
            fileName = "";

            fd.Title = "Select File";
            fd.InitialDirectory = filePathName;
            fd.Filter = "csv files (*.csv)|*.csv";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
                {
                fileName = System.IO.Path.GetFileName(fd.FileName);
                }
                else return;
            ImportPartsListFileData(filePathName + fileName);
            }





        private void Button4_Click(object sender, EventArgs e)
            {
            // export data

            ExportPartsData();
            }

        private void btnImportData_Click(object sender, EventArgs e)
            {
            ImportPartsData();
            }


        private void SearchOnFilter(string searchFor)
            {

            Cursor.Current = Cursors.WaitCursor;

            string sqlQuery = "SELECT * FROM tbl_partslist;";
            if(cmbGroupAllocation.Text == "CANCEL ALLOCATIONS") { cmbGroupAllocation.Text = ""; }
            string groupAlloc = cmbGroupAllocation.Text;
            string siteName = cmbSiteName.Text;

            if ((groupAlloc == "") && (siteName != "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_partslist WHERE SiteName LIKE '" + siteName + "';"; }
            if ((groupAlloc != "") && (siteName != "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_partslist WHERE SiteName LIKE '" + siteName + "' AND GroupAllocation LIKE '%" + groupAlloc + "%';"; }
            if ((groupAlloc == "") && (siteName != "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_partslist WHERE SiteName LIKE '" + siteName + "' AND " + SearchOnName + " LIKE '%" + searchFor + "%';"; }
            if ((groupAlloc != "") && (siteName != "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_partslist WHERE SiteName LIKE '" + siteName + "' AND " + SearchOnName + " LIKE '%" + searchFor + "%' AND GroupAllocation LIKE '%" + groupAlloc + "%';"; }
            if ((groupAlloc == "") && (siteName == "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_partslist ;"; }
            if ((groupAlloc != "") && (siteName == "ALL") && (searchFor == "")) { sqlQuery = "SELECT * FROM tbl_partslist WHERE GroupAllocation LIKE '%" + groupAlloc + "%';"; }
            if ((groupAlloc == "") && (siteName == "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_partslist WHERE " + SearchOnName + " LIKE '%" + searchFor + "%';"; }
            if ((groupAlloc != "") && (siteName == "ALL") && (searchFor != "")) { sqlQuery = "SELECT * FROM tbl_partslist WHERE " + SearchOnName + " LIKE '%" + searchFor + "%' AND GroupAllocation = '%" + groupAlloc + "%';"; }

            try
            {
                tbl_partslistTableAdapter.Adapter.SelectCommand.CommandText = sqlQuery;
                tbl_partslistTableAdapter.ClearBeforeFill = true;
                tbl_partslistTableAdapter.Fill(eped_db1DataSet.tbl_partslist);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            Cursor.Current = Cursors.Default;
            }



        private void tbl_partslistDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.ColumnIndex >= 0)
                {
                Cursor.Current = Cursors.WaitCursor;
                btnSearchOn.Text = "SEARCH ON " + tbl_partslistDataGridView.Columns[e.ColumnIndex].HeaderText;
                SearchOnName = tbl_partslistDataGridView.Columns[e.ColumnIndex].DataPropertyName;
                Cursor.Current = Cursors.Default;
                }
            }




        private void txbSearchOn_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == 13)
                {
                SearchOnFilter(txbSearchOn.Text);
                }
            }

        private void tbl_partslistDataGridView_MouseClick(object sender, MouseEventArgs e)
            {
            if (e.Button == (MouseButtons.Right) & (tbl_partslistDataGridView.SelectedRows.Count > 0))
                {
                // display option to allocated selected to a group allocation type or to allocate as work order
                    DialogResult result = MessageBox.Show("Select Existing Group allocation \n or write anew one:", "Scheduled WORK", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                        {
                        cmbSetGroupAllocation.Visible = true;
                        cmbSetGroupAllocation.Focus();
                        }
                    else { cmbSetGroupAllocation.Visible = false; }
                
                }
            }

        private void UpdateGridViewRowColors()
        {

            int caIndex = tbl_partslistDataGridView.IndexByName("Critical");
            int ltIndex = tbl_partslistDataGridView.IndexByName("LeadTime");
            int isIndex = tbl_partslistDataGridView.IndexByName("InternalStockLevel");
            int msIndex = tbl_partslistDataGridView.IndexByName("MinStockLevel");
            int minStock, criticalAsset, leadTime, intStock;

            for (int i = 0; i < tbl_partslistDataGridView.RowCount; i++)
            {
                if (Convert.IsDBNull(tbl_partslistDataGridView.Rows[i].Cells[isIndex].Value))
                {
                    intStock = 0;
                }
                else
                {
                    intStock = Int16.Parse(tbl_partslistDataGridView.Rows[i].Cells[isIndex].Value.ToString());
                }

                if (Convert.IsDBNull(tbl_partslistDataGridView.Rows[i].Cells[ltIndex].Value))
                {
                    leadTime = 4;
                }
                else
                {
                    leadTime = Utils.ConvertToWeeks(tbl_partslistDataGridView.Rows[i].Cells[ltIndex].Value.ToString());
                }
              
                if (Convert.IsDBNull(tbl_partslistDataGridView.Rows[i].Cells[msIndex].Value))
                {
                    minStock = 1;
                }
                else
                {
                    minStock= Int16.Parse(tbl_partslistDataGridView.Rows[i].Cells[msIndex].Value.ToString());
                }

                if (Convert.IsDBNull(tbl_partslistDataGridView.Rows[i].Cells[caIndex].Value))
                {
                    criticalAsset = 0;
                }
                else
                {
                    criticalAsset = Int16.Parse(tbl_partslistDataGridView.Rows[i].Cells[caIndex].Value.ToString());
                }

                // color background base on valuse obtained above

                if (intStock > minStock)
                {
                    tbl_partslistDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    tbl_partslistDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                if (intStock <= minStock)
                {
                    tbl_partslistDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    tbl_partslistDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    if((criticalAsset == 1)||(intStock==0)) 
                    {
                        tbl_partslistDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        tbl_partslistDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }



            private void UpdateSetGroupAllocation()
            {
            int iGA = tbl_partslistDataGridView.IndexByName("GroupAllocation");
            string value = "";
            string typeAllocation = cmbSetGroupAllocation.Text;

            // if(typeAllocation=="") { typeAllocation= cmbSetGroupAllocation.Items[cmbGroupAllocation.SelectedIndex].ToString()}
            Globals.ChangesMade = true;
            foreach (DataGridViewRow item in tbl_partslistDataGridView.SelectedRows)
                {
                if (typeAllocation == "CLEAR ALLOCATION")
                    {
                    item.Cells[iGA].Value = "";
                    }
                else
                    {
                    value = item.Cells[iGA].Value.ToString();
                    if (!value.Contains(typeAllocation))
                        {
                        item.Cells[iGA].Value = (value + " " + typeAllocation).Trim();
                        }
                    else
                        {
                        item.Cells[iGA].Value = value;
                        }
                    }
                }
            cmbSetGroupAllocation.Text = "";
            cmbSetGroupAllocation.Visible = false;
            }



        private void cmbSetGroupAllocation_SelectionChangeCommitted(object sender, EventArgs e)
            {
            Refresh();
            if (cmbSetGroupAllocation.SelectedIndex != -1) { cmbSetGroupAllocation.Text = cmbSetGroupAllocation.Items[cmbSetGroupAllocation.SelectedIndex].ToString(); }
            UpdateSetGroupAllocation();
            }

        private void cmbSetGroupAllocation_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == 13)
                {
                UpdateSetGroupAllocation();
                }
            }

       


        private void cmbGroupAllocation_SelectionChangeCommitted(object sender, EventArgs e)
            {
            if (cmbGroupAllocation.SelectedIndex != -1) { cmbGroupAllocation.Text = cmbGroupAllocation.Items[cmbGroupAllocation.SelectedIndex].ToString(); }
            if (cmbGroupAllocation.Text == "CLEAR ALLOCATION")
            {
                cmbGroupAllocation.Text = "";
            }
            SearchOnFilter("");
            UpdateGridViewRowColors();
           // ShowByGroupAllocation();
            }

        private void btnSearchOn_Click(object sender, EventArgs e)
        {
            SearchOnFilter(txbSearchOn.Text);
            UpdateGridViewRowColors();
        }

        private void cmbSiteName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cmbSiteName.SelectedIndex > -1) { cmbSiteName.Text = cmbSiteName.Items[cmbSiteName.SelectedIndex].ToString(); }
           // Properties.Settings.Default.DefaultSiteName = cmbSiteName.Text;
            txbSearchOn.Text = "";
            SearchOnFilter("");
            UpdateGridViewRowColors();
            Cursor.Current = Cursors.Default;
        }

        private void tbl_partslistDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateGridViewRowColors();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayHeadings();
        }

        private void CheckDateDisplay()
        {
            // fetch current row form grid
            string retval = "";
            try
            {
                retval = ((DataRowView)tbl_partslistBindingSource.Current).Row["LastFitted"].ToString();
                if ((retval == "")||(retval == "01/01/0001 00:00:00")) { lastFittedDateTimePicker.CustomFormat = " "; }
                else { lastFittedDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }

                retval = ((DataRowView)tbl_partslistBindingSource.Current).Row["NextDue"].ToString();
                if ((retval == "")|| (retval == "01/01/0001 00:00:00")) { nextDueDateTimePicker.CustomFormat = " "; }
                else { nextDueDateTimePicker.CustomFormat = "dd/MMM/yyyy"; }
             
            }
            catch (Exception)
            {
            }

        }

        private void supplierPartNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDateDisplay();
        }

        private void PartsListFrm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // this is to force form to top level then allow to be hidden afterwards
            this.TopMost = true;
            this.TopMost = false;
        }

        private void lastFittedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            lastFittedDateTimePicker.CustomFormat = "dd/MMM/yyyy";
        }

        private void nextDueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            lastFittedDateTimePicker.CustomFormat = "dd/MMM/yyyy";
        }

        private void cmbSiteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shown by area combobox
            if (!string.IsNullOrEmpty(cmbSiteName.Text))
            {
                cmbSiteName.Text = cmbSiteName.Text.Substring(0, 1).ToUpper() + cmbSiteName.Text.Substring(1);

                if (!string.IsNullOrEmpty(cmbSiteName.Text) && !string.IsNullOrWhiteSpace(cmbSiteName.Text))
                {
                    cmbSiteName.Text = cmbSiteName.Text.Trim();
                }
            }

            if (string.IsNullOrWhiteSpace(cmbSiteName.Text))
            {
                cmbSiteName.Text = null;
            }
            //-----------------------------------------------------------------------------------------------------------------------
        }

        //'SEARCH ON [SupplierPartNumber]' button
        private void btnSearchOn_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearchOn.ForeColor = Globals.selectBtnfgCol;
            btnSearchOn.BackColor = Color.LightCoral;
        }

        //'SEARCH ON [SupplierPartNumber]' button
        private void btnSearchOn_MouseLeave(object sender, EventArgs e)
        {
            btnSearchOn.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnSearchOn.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'SHOW BY GROUP' button
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Globals.selectBtnfgCol;
            button1.BackColor = Color.LightCoral;
        }

        //'SHOW BY GROUP' button
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            button1.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'ADD NEW ITEM' button
        private void Button5_MouseMove(object sender, MouseEventArgs e)
        {
            Button5.ForeColor = Globals.selectBtnfgCol;
            Button5.BackColor = Color.LightCoral;
        }

        //'ADD NEW ITEM' button
        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            Button5.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            Button5.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'UPDATE DATABASE' button
        private void Button6_MouseMove(object sender, MouseEventArgs e)
        {
            Button6.ForeColor = Globals.selectBtnfgCol;
            Button6.BackColor = Color.LightCoral;
        }

        //'UPDATE DATABASE' button
        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            Button6.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            Button6.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'IMPORT DATA' button
        private void btnImportData_MouseMove(object sender, MouseEventArgs e)
        {
            btnImportData.ForeColor = Globals.selectBtnfgCol;
            btnImportData.BackColor = Color.LightCoral;
        }

        //'IMPORT DATA' button
        private void btnImportData_MouseLeave(object sender, EventArgs e)
        {
            btnImportData.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnImportData.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'EXPORT DATA' button
        private void btnExportData_MouseMove(object sender, MouseEventArgs e)
        {
            btnExportData.ForeColor = Globals.selectBtnfgCol;
            btnExportData.BackColor = Color.LightCoral;
        }

        //'EXPORT DATA' button
        private void btnExportData_MouseLeave(object sender, EventArgs e)
        {
            btnExportData.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            btnExportData.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }

        //'CLOSE' button
        private void Button3_MouseMove(object sender, MouseEventArgs e)
        {
            Button3.ForeColor = Globals.selectBtnfgCol;
            Button3.BackColor = Color.LightCoral;
        }

        //'CLOSE' button
        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            Button3.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            Button3.BackColor = Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
        }
    }
}
