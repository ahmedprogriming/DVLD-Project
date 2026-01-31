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
    public partial class frmListTestType : Form
    {
        private DataTable _TestType;
        public frmListTestType()
        {
            InitializeComponent();
        }

        private void frmListTestType_Load(object sender, EventArgs e)
        {
            _TestType = clsTestType.GatAllTestType();
            dgvManageTestType.DataSource = _TestType;

            labRecodTestType.Text = dgvManageTestType.Rows.Count.ToString();

            if (dgvManageTestType.Rows.Count > 0)
            {
                dgvManageTestType.Columns[0].HeaderText = "ID";
                dgvManageTestType.Columns[0].Width = 100;

                dgvManageTestType.Columns[1].HeaderText = "Title";
                dgvManageTestType.Columns[1].Width = 120;

                dgvManageTestType.Columns[2].HeaderText = "Description";
                dgvManageTestType.Columns[2].Width = 224;

                dgvManageTestType.Columns[3].HeaderText = "Fees";
                dgvManageTestType.Columns[3].Width = 150;

            }

            dgvManageTestType.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvManageTestType.EnableHeadersVisualStyles = false;
            dgvManageTestType.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm =new frmEditTestType((clsTestType.enTestType)dgvManageTestType.CurrentRow.Cells[0].Value);
            frm.ShowDialog() ;
            frmListTestType_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
