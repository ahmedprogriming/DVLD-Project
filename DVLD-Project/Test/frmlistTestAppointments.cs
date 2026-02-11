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
using static Bissens_layer.clsTestType;

namespace DVLD_Project
{
    public partial class frmAppointementsTypeTest : Form
    {
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
        private DataTable _AppointemntsTests;
        private int _DrivingLAppID;
        public frmAppointementsTypeTest(int LocalDrivingLicenseAppID, clsTestType.enTestType testType)
        {
            InitializeComponent();
            _DrivingLAppID = LocalDrivingLicenseAppID;
            _TestType = testType;
        }




        private void btnAddAppointements_Click(object sender, EventArgs e)
        {
           clsLocalDrivingLicenseApplications _LocalDrivingLApp=clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(_DrivingLAppID);

          
            if (clsLocalDrivingLicenseApplications.IsThereAnActiveScheduledTest(_DrivingLAppID, _TestType))
            {

                MessageBox.Show("Person Already have an appointment for this test,you cannot add new appointment!", "Not Allw", MessageBoxButtons.OK, MessageBoxIcon.Error);
             return;
            }
          
            clsTest LastTest=_LocalDrivingLApp.GetLastTestPerTestType(_TestType);
 
            if (LastTest==null)
            {
                
                frmScheduleTest frm1 = new frmScheduleTest(_DrivingLAppID, _TestType);
                frm1.ShowDialog();
                frmAppointementsTypeTest_Load(null, null);
                return;
            }
            if(LastTest.ResulteTest==true)
            {
                MessageBox.Show("Person Already pased this test befor, you can only retake filed test!", "Not Allw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            frmScheduleTest frm2 = new frmScheduleTest(LastTest.AppointemntsTestsInfo.LocalDrivingLicenseApplicationID, _TestType);
            frm2.ShowDialog();
            frmAppointementsTypeTest_Load(null, null);
        }

        
        private void _LoadTestTypeImageAndTitle(clsTestType.enTestType enTestType)
        {

            switch (enTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    lblTitel.Text = "Vision Test Appointements";
                    this.Text=lblTitel.Text;
                    picImageUser.Image = Properties.Resources.Vision_512;
                    
                    break;
                case clsTestType.enTestType.WriteTest:
                    lblTitel.Text = "Write Test Appointements";
                    this.Text = lblTitel.Text;
                    picImageUser.Image = Properties.Resources.Written_Test_512;
                 
                    break;
                case clsTestType.enTestType.StreetTest:
                    lblTitel.Text = "Street Test Appointements";
                    this.Text = lblTitel.Text;
                    picImageUser.Image = Properties.Resources.driving_test_512;
                   
                    break;

            }
        }

        private void frmAppointementsTypeTest_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle(_TestType);
           crlApplicationInfo1.LoadDateApplicationInfoByLocalDrivinLAppID(_DrivingLAppID);
            _AppointemntsTests = clsAppointemntsTests.GetApplicationTestAppointmentPerTestType(_DrivingLAppID,_TestType);
            dgvAppointements.DataSource = _AppointemntsTests;

            labRecodCount.Text = dgvAppointements.Rows.Count.ToString();

            if (dgvAppointements.Rows.Count > 0)
            {
                dgvAppointements.Columns[0].HeaderText = "AppointmentID";
                dgvAppointements.Columns[0].Width = 120;

                dgvAppointements.Columns[1].HeaderText = "Appointment Date";
                dgvAppointements.Columns[1].Width = 150;

                dgvAppointements.Columns[2].HeaderText = "Paid Fess";
                dgvAppointements.Columns[2].Width = 120;

                dgvAppointements.Columns[3].HeaderText = "IsLocked";
                dgvAppointements.Columns[3].Width = 100;
                

            }

            dgvAppointements.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvAppointements.EnableHeadersVisualStyles = false;

            dgvAppointements.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointemntsID = (int)dgvAppointements.CurrentRow.Cells[0].Value;
            frmScheduleTest frm = new frmScheduleTest(_DrivingLAppID, _TestType, AppointemntsID);
            frm.ShowDialog();
            frmAppointementsTypeTest_Load(null, null);
        }
        private void tackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointemntsID = (int)dgvAppointements.CurrentRow.Cells[0].Value;
            frmTakeTest frm = new frmTakeTest(AppointemntsID, _TestType);
            frm.ShowDialog();
            frmAppointementsTypeTest_Load(null, null);
        }
    }
}