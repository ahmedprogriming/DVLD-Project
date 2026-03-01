using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bissens_layer;

namespace DVLD_Project
{
    public partial class frmListDriverscs : Form
    {
        private DataTable Drivers;

        public frmListDriverscs()
        {
            InitializeComponent();
        }

        private void frmListDriverscs_Load(object sender, EventArgs e)
        {
            Drivers = clsDriver.GetAllDrivers();
            dgvManagerDrivers.DataSource = Drivers;
            cobFilterDrivers.SelectedIndex = 0;
            labRecodLDLApp.Text = dgvManagerDrivers.Rows.Count.ToString();

            if (dgvManagerDrivers.Rows.Count > 0)
            {
                dgvManagerDrivers.Columns[0].HeaderText = "Driver ID";
                dgvManagerDrivers.Columns[0].Width = 150;

                dgvManagerDrivers.Columns[1].HeaderText = "Person ID";
                dgvManagerDrivers.Columns[1].Width = 150;

                dgvManagerDrivers.Columns[2].HeaderText = "NationalNo.";
                dgvManagerDrivers.Columns[2].Width = 150;
                dgvManagerDrivers.Columns[3].HeaderText = "Full Name";
                dgvManagerDrivers.Columns[3].Width = 350;

                dgvManagerDrivers.Columns[4].HeaderText = "Date";
                dgvManagerDrivers.Columns[4].Width = 150;

                dgvManagerDrivers.Columns[5].HeaderText = "Active License";
                dgvManagerDrivers.Columns[5].Width = 90;

            }

            dgvManagerDrivers.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvManagerDrivers.EnableHeadersVisualStyles = false;

            dgvManagerDrivers.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);

        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string FiterText = "";

            switch (cobFilterDrivers.Text)
            {
                case "Driver ID":
                    FiterText = "DriverID";
                    break;
                case "National No.":
                    FiterText = "NationalNo";
                    break;
                case "Full Name":
                    FiterText = "FullName";
                    break;
                case "Person ID":
                    FiterText = "PersonID";
                    break;

            }
            if (txbFilter.Text == "" || FiterText == "None")
            {
                Drivers.DefaultView.RowFilter = "";
                labRecodLDLApp.Text = dgvManagerDrivers.Rows.Count.ToString();
                return;
            }
            if (FiterText == "DriverID"|| FiterText == "PersonID")

                Drivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FiterText, txbFilter.Text.Trim());


            else
                Drivers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FiterText, txbFilter.Text.Trim());

            labRecodLDLApp.Text = dgvManagerDrivers.Rows.Count.ToString();
        }

        private void cobFilterDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Visible = (cobFilterDrivers.Text != "None");
            if (txbFilter.Visible)
            {
                txbFilter.Text = "";
                txbFilter.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowPersonDetiles_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvManagerDrivers.CurrentRow.Cells[1].Value;
            frmPerson_Details frm = new frmPerson_Details(PersonID);
            frm.ShowDialog();

            frmListDriverscs_Load(null,null);
        }

        private void tsmpersonHistory_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvManagerDrivers.CurrentRow.Cells[1].Value;
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }
    }
}
