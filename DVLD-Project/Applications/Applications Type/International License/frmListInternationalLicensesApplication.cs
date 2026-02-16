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
    public partial class frmListInternationalLicensesApplication : Form
    {
        private DataTable _dtInternationalLicense;
        
        public frmListInternationalLicensesApplication()
        {
            InitializeComponent();
        }

        private void frmListInternationalLicensesApplication_Load(object sender, EventArgs e)
        {
            _dtInternationalLicense = clsInternationalLicense.GetAllInternatuionalLicense();
            dgvINLApplication.DataSource = _dtInternationalLicense;
            cobFilterinternational.SelectedIndex = 0;
            labRecodINLApp.Text = dgvINLApplication.Rows.Count.ToString();

            if (dgvINLApplication.Rows.Count > 0)
            {
                dgvINLApplication.Columns[0].HeaderText = "Int.License ID";
                dgvINLApplication.Columns[0].Width = 160;

                dgvINLApplication.Columns[1].HeaderText = "Application ID";
                dgvINLApplication.Columns[1].Width = 160;

                dgvINLApplication.Columns[2].HeaderText = "Driver ID";
                dgvINLApplication.Columns[2].Width = 160;

                dgvINLApplication.Columns[3].HeaderText = "L.License ID";
                dgvINLApplication.Columns[3].Width = 160;

                dgvINLApplication.Columns[4].HeaderText = "Issue Date";
                dgvINLApplication.Columns[4].Width = 150;

                dgvINLApplication.Columns[5].HeaderText = "Expirtion Date";
                dgvINLApplication.Columns[5].Width = 150;

                dgvINLApplication.Columns[6].HeaderText = "Is Active";
                dgvINLApplication.Columns[6].Width = 95;

            }

            dgvINLApplication.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvINLApplication.EnableHeadersVisualStyles = false;

            dgvINLApplication.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string FiterText = "";

            switch (cobFilterinternational.Text)
            {
                case "Int.License ID":
                    FiterText = "InternationalLicenseID";
                    break;
                case "Driver ID":
                    FiterText = "DriverID";
                    break;
                case "L.Licenes ID":
                    FiterText = "IssuedUsingLocalLicenseID";
                    break;
             

            }
            if (txbFilter.Text == "" || FiterText == "None")
            {
                _dtInternationalLicense.DefaultView.RowFilter = "";
                labRecodINLApp.Text = dgvINLApplication.Rows.Count.ToString();
                return;
            }
            else
            {
                _dtInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FiterText, txbFilter.Text.Trim());
            }


            labRecodINLApp.Text = dgvINLApplication.Rows.Count.ToString();
        }

        private void cobFilterinternational_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Visible = (cobFilterinternational.Text != "None"&& cobFilterinternational.Text != "IsActive");
            cobIsActive.Visible = (cobFilterinternational.Text == "IsActive");

            if (txbFilter.Visible)
            {
                txbFilter.Focus();
                txbFilter.Text = "";
            }
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm=new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
            //refrsh
            frmListInternationalLicensesApplication_Load(null,null);
        }

        private void tsmShowPersonDetiles_Click(object sender, EventArgs e)
        {
            int InternationlLicenseID = (int)dgvINLApplication.CurrentRow.Cells[0].Value;

            clsInternationalLicense internationalLicense = clsInternationalLicense.Find(InternationlLicenseID);
            if (internationalLicense == null)
            {
                MessageBox.Show("This Person has not Driver ID!","Filed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Person_Details frm = new Person_Details(internationalLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvINLApplication.CurrentRow.Cells[0].Value;

            frmShowInternationalLicense frm = new frmShowInternationalLicense(InternationalLicenseID);
            frm.ShowDialog();
        }

        private void tsmpersonHistory_Click(object sender, EventArgs e)
        {
            int InternationlLicenseID = (int)dgvINLApplication.CurrentRow.Cells[0].Value;

            clsInternationalLicense internationalLicense = clsInternationalLicense.Find(InternationlLicenseID);
            if (internationalLicense == null)
            {
                MessageBox.Show("This Person has not Driver ID!", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(internationalLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void MSInternationalLicenseApp_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvINLApplication_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picImageUser_Click(object sender, EventArgs e)
        {

        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }

        private void cobIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cobIsActive.Text;

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
                _dtInternationalLicense.DefaultView.RowFilter = "";
            }
            else
                _dtInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue.Trim());

            labRecodINLApp.Text = dgvINLApplication.Rows.Count.ToString();

        }
    }
}
