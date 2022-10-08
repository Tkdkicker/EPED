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
    public partial class UpdatePMAssetDetailsFrm : Form
    {
        public UpdatePMAssetDetailsFrm()
        {
            InitializeComponent();
        }

        private void tbl_multipmscheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_multipmscheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);

        }

        private void tbl_multipmscheduleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_multipmscheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eped_db1DataSet);

        }

        private void UpdatePMAssetDetailsFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eped_db1DataSet.tbl_multipmschedule' table. You can move, or remove it, as needed.
            this.tbl_multipmscheduleTableAdapter.Fill(this.eped_db1DataSet.tbl_multipmschedule);

        }
    }
}
