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

namespace DVLD_Project
{
    public partial class ctrlScheduledTest : UserControl
    {
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
        private clsLocalDrivingLicenseApplications _LocalDrivingLApp;
        private int _AppointemntsTestsID = -1;
        private int _TestID = -1;
        private clsAppointemntsTests _AppointemntsTests;

        public clsTestType.enTestType TestType
        {
            get
            {
                return _TestType;
            }
            set
            {
                _TestType = value;
                switch (_TestType)
                {
                    case clsTestType.enTestType.VisionTest:
                        groRatakeTest.Text = "Vision Test";
                        picImageUser.Image = Properties.Resources.Vision_512;

                        break;
                    case clsTestType.enTestType.WriteTest:
                        groRatakeTest.Text = "Write Test";
                        picImageUser.Image = Properties.Resources.Written_Test_512;

                        break;
                    case clsTestType.enTestType.StreetTest:
                        groRatakeTest.Text = "Street Test";
                        picImageUser.Image = Properties.Resources.driving_test_512;

                        break;

                }

            }
        }

        public int AppointemntsTestsID
        {
            get
            {
                return _AppointemntsTestsID;
               
            }
        }

        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        public void LoadInfo(int TestAppointmentID)
        {
            _AppointemntsTestsID= TestAppointmentID;
            _AppointemntsTests = clsAppointemntsTests.Find(_AppointemntsTestsID);
            if (_AppointemntsTests == null)
            {
                MessageBox.Show("This Not Found AppointemntsTestsID [" + _AppointemntsTestsID + "]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _AppointemntsTestsID = -1;
                return;
            }

            _TestID = _AppointemntsTests.TestID;

            _LocalDrivingLApp = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(_AppointemntsTests.LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLApp == null)
            {
                MessageBox.Show("This Not Found LocalDrivingLicenseApplicationsID [" + _AppointemntsTests.LocalDrivingLicenseApplicationID + "]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDClass.Text = _LocalDrivingLApp.LicenseClassInfo.LicenseName;
            lblDLApID.Text = _AppointemntsTests.LocalDrivingLicenseApplicationID.ToString();
            lblName.Text = clsPerson.Find(_LocalDrivingLApp.ApplicantPersonID).FullName;
            lblFees.Text = _LocalDrivingLApp.PaidFees.ToString();
            lblTestID.Text =(_TestID==-1)? "Not Taken Yet":_AppointemntsTests.TestID.ToString();
            lblTrial.Text = _LocalDrivingLApp.TotalTrialsPerTest(_TestType).ToString();
            dateAppoinmentens.Value = _AppointemntsTests.AppointmentDate;
           
        }
        public ctrlScheduledTest()
        {
            InitializeComponent();
        }


    }
}
