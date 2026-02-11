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
using Business_Layer;
using static System.Net.Mime.MediaTypeNames;
using static Bissens_layer.clsTestType;

namespace DVLD_Project
{
    public partial class crlScheduleTest : UserControl
    {
        enum enMode { Addnew = 0, Update = 1 };
        private enMode _Mode = enMode.Addnew;

        private enum enCreationMode {FirstTimeSchedule=0,RetakeTestSchedule=1};
         private enCreationMode _CreationMode=enCreationMode.FirstTimeSchedule;

        private clsLocalDrivingLicenseApplications _LocalDrivingLApp;
        private int _LocalDrivingID = -1;
        private clsAppointemntsTests _AppointemntsTests;

        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;


        private int _TestAppointmentID=-1;
        public crlScheduleTest()
        {
            InitializeComponent();
        }

        public clsTestType.enTestType TestType
        {
            get { 
                return _TestType;
                }
            set { _TestType = value;
                switch (_TestType)
                {
                    case clsTestType.enTestType.VisionTest:
                        groScheduleTest.Text = "Vision Test";
                        picImageTest.Image = Properties.Resources.Vision_512;
              
                        break;
                    case clsTestType.enTestType.WriteTest:
                        groScheduleTest.Text = "Write Test";
                        picImageTest.Image = Properties.Resources.Written_Test_512;
                       
                        break;
                    case clsTestType.enTestType.StreetTest:
                        groScheduleTest.Text = "Street Test";
                        picImageTest.Image = Properties.Resources.driving_test_512;
                     
                        break;

                }

            }
        }

      
        public void LoadInfo(int LocalDrivingLicenseAppID,int TestAppointmentID=-1)
        {
            if (TestAppointmentID == -1)
           
                _Mode = enMode.Addnew;
     
            
            else
                _Mode = enMode.Update;

            _LocalDrivingID = LocalDrivingLicenseAppID;
            _TestAppointmentID = TestAppointmentID;

            _LocalDrivingLApp = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(_LocalDrivingID);
            if (_LocalDrivingLApp == null)
            {
                MessageBox.Show("This Not Found LocalDrivingLicenseApplicationsID [" + _LocalDrivingID + "]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled= false;
                return;
            }

            if (_LocalDrivingLApp.DoesAttendTestType(_TestType))
            {

                _CreationMode = enCreationMode.RetakeTestSchedule;
            }
            else
            {

                _CreationMode = enCreationMode.FirstTimeSchedule;
            }

            if(_CreationMode==enCreationMode.RetakeTestSchedule)
            {
                lblRAppFees.Text=clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.RetakeTest).AppTypeFees.ToString();
                lblTitel.Text = "Schedule Retake Test";
                groRetakeInfo.Enabled = true;
                lblRTestID.Text = "0";
            }
            else
            {
                lblRAppFees.Text = "0";
                lblTitel.Text = "Schedule Test";
                groRetakeInfo.Enabled = false;
                lblRTestID.Text = "N/A";

            }

            lblDLApID.Text = _LocalDrivingID.ToString();
            lblDClass.Text = _LocalDrivingLApp.LicenseClassInfo.LicenseName;
            lblName.Text = clsPerson.Find(_LocalDrivingLApp.ApplicantPersonID).FullName;
            lblTrial.Text = _LocalDrivingLApp.TotalTrialsPerTest(_TestType).ToString();

            if(_Mode==enMode.Addnew)
            {
                lblFees.Text = clsTestType.FindTestTypeID(_TestType).TestTypeFees.ToString();
                dateAppoinmentens.MinDate=DateTime.Now;
                lblRTestID.Text = "N/A";
                _AppointemntsTests = new clsAppointemntsTests();
            }
            else
            {
                if (!_LoadTestAppointments())
                    return;
            }

            lbltotalfees.Text= (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRAppFees.Text)).ToString();
            if (!_HandleActiveTestAppointmentConstrin())
                return;
            if (!_HandleAppointmentLockedConstrain())
                return;
            if(!_HandlePreviosPassedTestConstrain())
                return;
        }

        private bool _LoadTestAppointments()
        {
            _AppointemntsTests = clsAppointemntsTests.Find(_TestAppointmentID);
            if (_AppointemntsTests == null)
            {
                MessageBox.Show("This Not Found AppointemntsTestID [" + _TestAppointmentID + "]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }
            lblFees.Text = _AppointemntsTests.PaidFees.ToString();

            if (DateTime.Compare(DateTime.Now, _AppointemntsTests.AppointmentDate) < 0)
                dateAppoinmentens.MinDate = DateTime.Now;
            else
                dateAppoinmentens.MinDate = _AppointemntsTests.AppointmentDate;

            dateAppoinmentens.Value = _AppointemntsTests.AppointmentDate;

            if (_AppointemntsTests.RetakeTestApplicationID == -1)
            {
                lblRAppFees.Text = "0";

                lblRTestID.Text = "N/A";

            }
            else
            {
               lblRAppFees.Text = _AppointemntsTests.RetakeTestAppInfo.PaidFees.ToString();
                lblTitel.Text = "Schedule Retake Test";
                groRetakeInfo.Enabled = true;
                lblRTestID.Text = _AppointemntsTests.RetakeTestApplicationID.ToString();
            }
            return true;
        }
        private bool _HandleActiveTestAppointmentConstrin()
        {
            if (_Mode == enMode.Addnew && clsLocalDrivingLicenseApplications.IsThereAnActiveScheduledTest(_LocalDrivingID, _TestType))
            {
                lblUserMassage.Text = "Person Already have an active appointment for this test";
                dateAppoinmentens.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            return true;
        }

        private bool _HandleAppointmentLockedConstrain()
        {
            if(_AppointemntsTests.IsLocked)
            {
                lblUserMassage.Visible = true;
                lblUserMassage.Text = "Person already set for the test,appointment locked";
                dateAppoinmentens.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else
            {
                lblUserMassage.Visible = false;
                return true;
            }
        }

        private bool _HandlePreviosPassedTestConstrain()
        {
            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    lblUserMassage.Visible = false;

                    return true;

                case clsTestType.enTestType.WriteTest:
                    if (!_LocalDrivingLApp.DoesPassPreviousTest(clsTestType.enTestType.WriteTest))
                    {
                        lblUserMassage.Visible = true;
                        lblUserMassage.Text = "Cannot Schedule,Vision Test Shoudl be Passed first";
                        dateAppoinmentens.Enabled = false;
                        btnSave.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMassage.Visible = false;
                        dateAppoinmentens.Enabled = true;
                        btnSave.Enabled = true;

                    }


                    return true;
                case clsTestType.enTestType.StreetTest:
                    if (!_LocalDrivingLApp.DoesPassPreviousTest(clsTestType.enTestType.StreetTest))
                    {
                        lblUserMassage.Visible = true;
                        lblUserMassage.Text = "Cannot Schedule,Write Test Shoudl be Passed first";
                        dateAppoinmentens.Enabled = false;
                        btnSave.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMassage.Visible = false;
                        dateAppoinmentens.Enabled = true;
                        btnSave.Enabled = true;

                    }
                    return true;
            }

            return true;
            
        }

        private bool _HandleRetakeApplication()
        {
            if (_Mode == enMode.Addnew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                clsApplication app = new clsApplication();

                app.ApplicantPersonID = _LocalDrivingLApp.ApplicantPersonID;
                app.ApplicationDate = DateTime.Now;
                app.ApplicationStatus = clsApplication.enApplicationStatue.Completed;
                app.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                app.LastStatusDate = DateTime.Now;
                app.PaidFees = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.RetakeTest).AppTypeFees;
                app.CreatedByUserID = clsGlobel.CurrentUser.UserID;

                if (!app.Save())
                {
                    _AppointemntsTests.RetakeTestApplicationID = -1;
                    MessageBox.Show("Filed Creat Application!", "filed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
                _AppointemntsTests.RetakeTestApplicationID = app.ApplicationID;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _AppointemntsTests.AppointmentDate = dateAppoinmentens.Value;
            _AppointemntsTests.CreatedByUserID = clsGlobel.CurrentUser.UserID;
            _AppointemntsTests.PaidFees = Convert.ToSingle(lblFees.Text);
            _AppointemntsTests.LocalDrivingLicenseApplicationID = _LocalDrivingID;
            _AppointemntsTests.TestTypeID = _TestType;

            if (_AppointemntsTests.Save())
            {
                MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
               
            }
            else
            {
                MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
