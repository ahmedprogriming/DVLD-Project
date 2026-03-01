using Bissens_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmListDetainLicense : Form
    {
        private DataTable _dtDetainLicense;
        public frmListDetainLicense()
        {
            InitializeComponent();
        }

        private void frmListDetainLicense_Load(object sender, EventArgs e)
        {
            _dtDetainLicense = clsDetainLicense.GetAllDetainLicense();
            dgvListDetainLicense.DataSource = _dtDetainLicense;
            cobFilterDetain.SelectedIndex = 0;
            labRecodDetainLicense.Text = dgvListDetainLicense.Rows.Count.ToString();

            if (dgvListDetainLicense.Rows.Count > 0)
            {
                dgvListDetainLicense.Columns[0].HeaderText = "D.ID";
                dgvListDetainLicense.Columns[0].Width = 100;

                dgvListDetainLicense.Columns[1].HeaderText = "L.ID";
                dgvListDetainLicense.Columns[1].Width = 100;

                dgvListDetainLicense.Columns[2].HeaderText = "D.Date";
                dgvListDetainLicense.Columns[2].Width = 160;
                dgvListDetainLicense.Columns[3].HeaderText = "Is Released";
                dgvListDetainLicense.Columns[3].Width = 150;

                dgvListDetainLicense.Columns[4].HeaderText = "Fine Fees";
                dgvListDetainLicense.Columns[4].Width = 160;

                dgvListDetainLicense.Columns[5].HeaderText = "Release Date";
                dgvListDetainLicense.Columns[5].Width = 150;

                dgvListDetainLicense.Columns[6].HeaderText = "N.NO";
                dgvListDetainLicense.Columns[6].Width = 100;

                dgvListDetainLicense.Columns[7].HeaderText = "Full Name";
                dgvListDetainLicense.Columns[7].Width = 230;

                dgvListDetainLicense.Columns[8].HeaderText = "Release App.ID";
                dgvListDetainLicense.Columns[8].Width = 190;

   
            }

            dgvListDetainLicense.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvListDetainLicense.EnableHeadersVisualStyles = false;

            dgvListDetainLicense.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string FiterText = "";

            switch (cobFilterDetain.Text)
            {
                case "Detain ID":
                    FiterText = "DetainID";
                    break;
                case "Release Application ID":
                    FiterText = "ReleaseApplicationID";
               
                    break;
                case "National No.":
                    FiterText = "NationalNo";
                    break;
                case "Full Name":
                    FiterText = "FullName";
                    break;
                case "Is Released":
                    FiterText = "IsReleased";
                    break;

                    default:

                    FiterText = "None";
                    break;

            }
            if (txbFilter.Text.Trim() == "" || FiterText == "None")
            {
                _dtDetainLicense.DefaultView.RowFilter = "";
                labRecodDetainLicense.Text = dgvListDetainLicense.Rows.Count.ToString();
                return;
            }
            if(FiterText== "DetainID"|| FiterText == "ReleaseApplicationID")
            {
                _dtDetainLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FiterText, txbFilter.Text.Trim());
            }
            else
            {
                _dtDetainLicense.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FiterText, txbFilter.Text.Trim());
            }


                labRecodDetainLicense.Text = dgvListDetainLicense.Rows.Count.ToString();
        }

        private void cobIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsReleased";
            string FilterValue = cobIsReleaseed.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;

            }

            if (FilterValue == "All")
            {
                _dtDetainLicense.DefaultView.RowFilter = "";
            }
            else
                _dtDetainLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue.Trim());

            labRecodDetainLicense.Text = dgvListDetainLicense.Rows.Count.ToString();
        }

        private void cobFilterDetain_SelectedIndexChanged(object sender, EventArgs e)
        {

            txbFilter.Visible = (cobFilterDetain.Text != "None" && cobFilterDetain.Text != "Is Released");
            cobIsReleaseed.Visible = (cobFilterDetain.Text == "Is Released");

            if (txbFilter.Visible)
            {
                txbFilter.Focus();
                txbFilter.Text = "";
            }
        }

        private void btnReleasedDetain_Click(object sender, EventArgs e)
        {
            frmReleaseDetainLicense frm = new frmReleaseDetainLicense();
            frm.ShowDialog();
        }

        private void btnAddNewDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm =new frmDetainLicense();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowPersonDetiles_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvListDetainLicense.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.GetAllLicenseByID(LicenseID).DriverInfo.PersonID;

            frmPerson_Details frm = new frmPerson_Details(PersonID);
            frm.ShowDialog();
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvListDetainLicense.CurrentRow.Cells[1].Value;
            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void tsmpersonHistory_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvListDetainLicense.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.GetAllLicenseByID(LicenseID).DriverInfo.PersonID;
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvListDetainLicense.CurrentRow.Cells[1].Value;
            frmReleaseDetainLicense frm = new frmReleaseDetainLicense(LicenseID);
            frm.ShowDialog();
            frmListDetainLicense_Load(null, null);
        }

        private void MSDetainLicenseApp_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainedLicenseToolStripMenuItem.Enabled = !(bool)dgvListDetainLicense.CurrentRow.Cells[3].Value;
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {    //we allow number incase person id or user id is selected
            if (cobFilterDetain.Text== "Detain ID"||cobFilterDetain.Text== "Release Application ID")
            {
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
            }
        }
    }
}
