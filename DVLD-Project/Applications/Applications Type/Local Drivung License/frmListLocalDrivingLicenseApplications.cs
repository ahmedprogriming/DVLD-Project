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
        private clsTestType.enTestType  _TestType=clsTestType.enTestType.VisionTest;
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
            labRecodLDLApp.Text = dgvLDLApplication.Rows.Count.ToString();

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
           
            if (MessageBox.Show("Are you sure do want to cancel this application? [" + dgvLDLApplication.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _clsLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID((int)dgvLDLApplication.CurrentRow.Cells[0].Value);

                if (_clsLocalDrivingLicenseApplications.Cancel())
                {
                    MessageBox.Show("Sucssefuly Canseled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLocalDrivingLicenseApplications_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Not Sucssefuly Canseled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



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
            _SechduleTest(clsTestType.enTestType.VisionTest);
        }

        private void tsmIssue_Click(object sender, EventArgs e)
        {
            frmIssuedDrivingLicense frm=new frmIssuedDrivingLicense((int)dgvLDLApplication.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmLocalDrivingLicenseApplications_Load(null, null);
        }

        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseID = (int)dgvLDLApplication.CurrentRow.Cells[0].Value;
            int LicenseID= clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(LocalDrivingLicenseID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("This Person has not LicenseID!","Filed",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }

           
        }

        private void tsmpersonHistory_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseID = (int)dgvLDLApplication.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplications clsLocalDriving=clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(LocalDrivingLicenseID);

            frmShowPersonLicenseHistory frm =new frmShowPersonLicenseHistory(clsLocalDriving.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void tsmWrittenTest_Click(object sender, EventArgs e)
        {
            _SechduleTest(clsTestType.enTestType.WriteTest);
        }

        private void tsmStreatTest_Click(object sender, EventArgs e)
        {
            _SechduleTest(clsTestType.enTestType.StreetTest);
        }

        private void dgvLDLApplication_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void tsmShowAppDetiles_Click(object sender, EventArgs e)
        {
            frmShowLocalDrivingLincenseApp frm = new frmShowLocalDrivingLincenseApp((int)dgvLDLApplication.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmLocalDrivingLicenseApplications_Load(null, null);
        }

        private void tsmEditApp_Click(object sender, EventArgs e)
        {
            frmNewLocalLicenesApplicatio frm = new frmNewLocalLicenesApplicatio((int)dgvLDLApplication.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmLocalDrivingLicenseApplications_Load(null, null);
        }

        private void tsDeleteApp_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete This Application [" + dgvLDLApplication.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

                _clsLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID((int)dgvLDLApplication.CurrentRow.Cells[0].Value);

                if (_clsLocalDrivingLicenseApplications.Deleted())
                {
                    MessageBox.Show("Sucssefuly Delted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLocalDrivingLicenseApplications_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Not Sucssefuly Delted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

           
        }

         private void _SechduleTest(clsTestType.enTestType testType)
        {
            int LocalDrivingLicenseID = (int)dgvLDLApplication.CurrentRow.Cells[0].Value;
            frmAppointementsTypeTest frm = new frmAppointementsTypeTest(LocalDrivingLicenseID, testType);
            frm.ShowDialog();
            frmLocalDrivingLicenseApplications_Load(null, null);
        }
        private void MSLocalDrivingApp_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseAppID = (int)dgvLDLApplication.CurrentRow.Cells[0].Value;
                 _clsLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(LocalDrivingLicenseAppID);
            int TootalPassedTest = (int)dgvLDLApplication.CurrentRow.Cells[5].Value;

            bool LicenseExsites = _clsLocalDrivingLicenseApplications.IsLicenseIssue();

            bool PassedVisionTest= _clsLocalDrivingLicenseApplications.DosePassedTestType(clsTestType.enTestType.VisionTest);
            bool PassedWritnTest = _clsLocalDrivingLicenseApplications.DosePassedTestType(clsTestType.enTestType.WriteTest);
            bool PassedStreetTest = _clsLocalDrivingLicenseApplications.DosePassedTestType(clsTestType.enTestType.StreetTest);

            tsmIssue.Enabled = (TootalPassedTest == 3&& !LicenseExsites);
            tsmShowLicense.Enabled = LicenseExsites;
            tsmEditApp.Enabled = !LicenseExsites && (_clsLocalDrivingLicenseApplications.ApplicationStatus== clsApplication.enApplicationStatue.New);
            tsSechduleTest.Enabled = !LicenseExsites;

            tsmCanselApp.Enabled = (_clsLocalDrivingLicenseApplications.ApplicationStatus == clsApplication.enApplicationStatue.New);
            tsDeleteApp.Enabled = (_clsLocalDrivingLicenseApplications.ApplicationStatus == clsApplication.enApplicationStatue.New);

            tsSechduleTest.Enabled=(!PassedVisionTest||!PassedWritnTest||!PassedStreetTest)&& (_clsLocalDrivingLicenseApplications.ApplicationStatus == clsApplication.enApplicationStatue.New);
            if(tsSechduleTest.Enabled)
            {
                tsmVisionTest.Enabled = !PassedVisionTest;
                tsmWrittenTest.Enabled = PassedVisionTest && !PassedWritnTest;
                tsmStreatTest.Enabled = PassedVisionTest && PassedWritnTest && !PassedStreetTest;
            }
        }

        private void tsSechduleTest_Click(object sender, EventArgs e)
        {

        }
    }
}
