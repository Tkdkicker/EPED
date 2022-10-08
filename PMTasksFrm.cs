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
    public partial class PMTasksFrm : Form
    {
        public PMTasksFrm()
        {
            InitializeComponent();
        }

        private void tbl_pmtasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_pmtasksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);

        }

        private void PMTasksFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eped_db1DataSet.tbl_pmtasks' table. You can move, or remove it, as needed.
            this.tbl_pmtasksTableAdapter.Fill(this.eped_db1DataSet.tbl_pmtasks);
            this.BackColor = Globals.epedbgCol;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
