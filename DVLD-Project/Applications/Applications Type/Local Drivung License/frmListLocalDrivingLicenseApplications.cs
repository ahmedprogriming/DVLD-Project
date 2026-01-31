using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Bissens_layer;

namespace DVLD_Project
{
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        private DataTable _NewLoDLiApp;
        private clsLocalDrivingLicenseApplications _clsLocalDrivingLicenseApplications;
        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmNewLocalLicenesApplicatio frm =new frmNewLocalLicenesApplicatio();
            frm.ShowDialog();
            frmLocalDrivingLicenseApplications_Load(null, null);
        }
      
            
       
        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
          


            _NewLoDLiApp = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplicationsData();
            dgvLDLApplication.DataSource = _NewLoDLiApp;
            cobFilterLocal.SelectedIndex = 0;
            tsmIssue.Enabled = false;
            tsmShowLicense.Enabled=false;
            tsmWrittenTest.Enabled=false;
            tsmStreatTest.Enabled=false;
            dgvLDLApplication.Text = dgvLDLApplication.Rows.Count.ToString();

            if (dgvLDLApplication.Rows.Count > 0)
            {
                dgvLDLApplication.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLDLApplication.Columns[0].Width = 90;

                dgvLDLApplication.Columns[1].HeaderText = "Driving Class";
                dgvLDLApplication.Columns[1].Width = 250;

                dgvLDLApplication.Columns[2].HeaderText = "NationalNo.";
                dgvLDLApplication.Columns[2].Width = 120;

                dgvLDLApplication.Columns[3].HeaderText = "Full Name";
                dgvLDLApplication.Columns[3].Width = 330;

                dgvLDLApplication.Columns[4].HeaderText = "ApplicationDate";
                dgvLDLApplication.Columns[4].Width = 150;

                dgvLDLApplication.Columns[5].HeaderText = "Passed Test";
                dgvLDLApplication.Columns[5].Width = 90;

                dgvLDLApplication.Columns[6].HeaderText = "Status";
                dgvLDLApplication.Columns[6].Width = 100;

            }
          
            dgvLDLApplication.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvLDLApplication.EnableHeadersVisualStyles = false;
        
            dgvLDLApplication.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
          
       
          
        }
      
        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string FiterText = "";

            switch(cobFilterLocal.Text)
            {
                case "L.D.L.Application":
                    FiterText = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    FiterText = "NationalNo";
                    break;
                case "Full Name":
                    FiterText = "FullName";
                    break;
                case "Status":
                    FiterText = "Status";
                    break;
                    
            }
            if(txbFilter.Text==""||FiterText=="None")
            {
                _NewLoDLiApp.DefaultView.RowFilter = "";
                labRecodLDLApp.Text = dgvLDLApplication.Rows.Count.ToString();
                return;
            }
            if(FiterText== "LocalDrivingLicenseApplicationID")

                _NewLoDLiApp.DefaultView.RowFilter = string.Format("[{0}] = {1}", FiterText, txbFilter.Text.Trim());


            else
                _NewLoDLiApp.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FiterText, txbFilter.Text.Trim());

            labRecodLDLApp.Text = dgvLDLApplication.Rows.Count.ToString();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmCanselApp_Click(object sender, EventArgs e)
        {
            _clsLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID((int)dgvLDLApplication.CurrentRow.Cells[0].Value);

            tsmIssue.Enabled = false;
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvLDLApplication.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(_clsLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplicationsData())
                {
                    MessageBox.Show("Sucssefuly Delted!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Not Sucssefuly Delted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            frmLocalDrivingLicenseApplications_Load(null, null);
        }

        private void cobFilterLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Visible=(cobFilterLocal.Text != "None");
            if(txbFilter.Visible)
            {
                txbFilter.Text = "";
                txbFilter.Focus();  
            }
               
        }

        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppointementsTypeTest frm=new frmAppointementsTypeTest((int)dgvLDLApplication.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmIssue_Click(object sender, EventArgs e)
        {
            frmIssuedDrivingLicense frm=new frmIssuedDrivingLicense();
            frm.ShowDialog();
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm=new frmLicenseInfo();
            frm.ShowDialog();
        }

        private void tsmpersonHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm =new frmLicenseHistory();
            frm.ShowDialog();
        }

      
    }
}
