using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bissens_layer;

namespace DVLD_Project
{
    public partial class frmManageApplicationType : Form
    {
        private DataTable _AppType;
        public frmManageApplicationType()
        {
            InitializeComponent();
        }

       
        private void frmManageApplicationType_Load(object sender, EventArgs e)
        {
            _AppType=clsApplicatonType.GatAllAppType();
            dgvManageApplicationType.DataSource = _AppType;
       
            labRecodMangeApplicatioType.Text = dgvManageApplicationType.Rows.Count.ToString();

            if (dgvManageApplicationType.Rows.Count > 0)
            {
                dgvManageApplicationType.Columns[0].HeaderText = "ID";
                dgvManageApplicationType.Columns[0].Width = 100;

                dgvManageApplicationType.Columns[1].HeaderText = "Title";
                dgvManageApplicationType.Columns[1].Width = 424;

                dgvManageApplicationType.Columns[2].HeaderText = "Fees";
                dgvManageApplicationType.Columns[2].Width =100;

            }

            dgvManageApplicationType.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvManageApplicationType.EnableHeadersVisualStyles = false;

            dgvManageApplicationType.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)dgvManageApplicationType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageApplicationType_Load(null, null);  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
