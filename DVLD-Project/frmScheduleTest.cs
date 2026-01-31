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
    public partial class frmScheduleTest : Form
    {
       
        private clsTestType.enTestType _TestType =clsTestType.enTestType.VisionTest;
       
        enum enMode { Addnew=0,Update=1};
        private enMode _Mode=enMode.Addnew;
        private clsLocalDrivingLicenseApplications _LocalDrivingLApp;
        private clsAppointemntsTests _AppointemntsTests;
        private int _LocalDrivingID=-1;

        public frmScheduleTest()
        {
            InitializeComponent();
            _Mode = enMode.Addnew;

        }
        public frmScheduleTest(int ID)
        {
            InitializeComponent();
            _LocalDrivingID = ID;
            _Mode = enMode.Update;
       
        }

        private void _DataTest(clsTestType.enTestType enTestType)
        {
            switch(enTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    groScheduleTest.Text = "Vision Test";
                    picImageTest.Image = Properties.Resources.Vision_512;
                    lblFees.Text = clsTestType.FindTestTypeID((clsTestType.enTestType)enTestType).TestTypeFees.ToString();
                    break;
                case clsTestType.enTestType.WriteTest:
                    groScheduleTest.Text = "Write Test";
                    picImageTest.Image = Properties.Resources.Written_Test_512;
                    lblFees.Text = clsTestType.FindTestTypeID((clsTestType.enTestType)enTestType).TestTypeFees.ToString();
                    break;
                case clsTestType.enTestType.StreetTest:
                    groScheduleTest.Text = "Street Test";
                    picImageTest.Image = Properties.Resources.Street_Test_321;
                    lblFees.Text = clsTestType.FindTestTypeID((clsTestType.enTestType)enTestType).TestTypeFees.ToString();
                    break;

            }

            lblDLApID.Text = _LocalDrivingID.ToString();
            lblDClass.Text = _LocalDrivingLApp.clsLicenseClass.LicenseName;
            lblName.Text = _LocalDrivingLApp.FullName;
            lblTitel.Text = "0";

            crlRetakeTest1.GroEnbled = false;

        }
        private void _ResulteDefilt()
        {
            
            _LocalDrivingLApp=clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(_LocalDrivingID);
          
            if (_LocalDrivingLApp == null)
            {
                MessageBox.Show("This Not Found Local Driver License Application ID [" + _LocalDrivingID + "]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_LocalDrivingLApp.GetPassedTestcount()==0)
            {
                _TestType = clsTestType.enTestType.VisionTest;
                _DataTest(_TestType);
            }
            else if(_LocalDrivingLApp.GetPassedTestcount() == 1)
            {
                _TestType = clsTestType.enTestType.WriteTest;
                _DataTest(_TestType);
               
            }
            else
            {
                _TestType = clsTestType.enTestType.StreetTest;
                _DataTest(_TestType);
            }
                      
            
        }

        private void _LoadDate()
        {
            if (_AppointemntsTests.FindByID().IsLockedActive())
            {
                lblError.Text = "This is erady Appointment!";
                dateAppoinmentens.Enabled = false;
                btnSave.Enabled = false;
                _ResulteDefilt();
            }
            else
            {
                _ResulteDefilt();
            }
        }


        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            if(_Mode==enMode.Addnew)
            {
                _ResulteDefilt();
            }
            else
            {
                _LoadDate();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_AppointemntsTests.FindByID().IsLockedActive())
            {
                MessageBox.Show("Person Already have an appointment for this test,you cannot add new appointment!", "Not Allw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_LocalDrivingLApp.DosePassedTestType(_TestType))
            {
                MessageBox.Show("Person Already have passed this Test!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you sure of saved this appointment?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _AppointemntsTests.AppointmentDate = dateAppoinmentens.Value;
                _AppointemntsTests.CreatedByUserID=clsGlobel.CurrentUser.UserID;
               _AppointemntsTests.PaidFees=Convert.ToSingle(lblFees.Text);
                _AppointemntsTests.LocalDrivingLicenseApplicationID = _LocalDrivingID;
                _AppointemntsTests.TestTypeID =(int) _TestType;

                if(_AppointemntsTests.Save())
                {
                    MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
