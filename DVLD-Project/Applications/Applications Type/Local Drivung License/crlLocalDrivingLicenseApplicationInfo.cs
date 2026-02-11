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
using DVLD_Project.Class_Global;

namespace DVLD_Project
{
    public partial class crlLocalDrivingLicenseApplicationInfo : UserControl
    {
        private clsLocalDrivingLicenseApplications _LocalDriverL;

        private int _LocalDrivingLicenseAppID = -1;
        private int _LicenseID = -1;
        public int LocalDrivingLicenseAppID
        {
            get
            {
                return _LocalDrivingLicenseAppID;
            }
        }
        public crlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void _ResultDefult()
        {
            lblApplicationID.Text="[????]";
            lblStatus.Text = "[????]";
            lblAppliedForLicense.Text = "[????]";
            lblCreatedBy.Text = "[????]";
            lblFees.Text = "[????]";
            lblLDLAppID.Text= "[????]";
           lblPassedTest.Text="0";
            lblDate.Text = "[????]";
            lblStatueDate.Text = "[????]";
            lblType.Text = "[????]";
            lblApplicant.Text = "[????]";

        }

     
        public void LoadDateApplicationInfoByLocalDrivinLAppID(int LDLAppID)
        {
            _LocalDriverL = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(LDLAppID);
    
            if (_LocalDriverL == null)
            {
                _ResultDefult();
                MessageBox.Show("This Not Found Local Driver License Application ID ["+LDLAppID+"]!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _FillLocaldrivingLicemseAppInfo();


        }

        public void LoadDateApplicationInfoByApplicationID(int ApplicationID)
        {
            _LocalDriverL = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByApplactionID(ApplicationID);

            if (_LocalDriverL == null)
            {
                _ResultDefult();
                MessageBox.Show("This Not Found  Application ID [" + ApplicationID + "]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocaldrivingLicemseAppInfo();


        }
        private void _FillLocaldrivingLicemseAppInfo()
        {
            _LicenseID = _LocalDriverL.GetActiveLicenseID();
            linkLicenseInfo.Enabled = (_LicenseID != -1);

            lblLDLAppID.Text = _LocalDriverL.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = _LocalDriverL.LicenseClassInfo.LicenseName;
            lblPassedTest.Text = _LocalDriverL.GetPassedTestcount().ToString()+"/3";
            lblApplicationID.Text = _LocalDriverL.ApplicationID.ToString();
            lblStatus.Text = _LocalDriverL.TextStatus;
            lblFees.Text = _LocalDriverL.PaidFees.ToString();
            lblType.Text = clsApplicatonType.FindAppTypeID(_LocalDriverL.ApplicationTypeID).AppTypeTitle;
            lblApplicant.Text = clsPerson.Find(_LocalDriverL.ApplicantPersonID).FullName;
            lblDate.Text = clsFormat.DateToShort(_LocalDriverL.ApplicationDate);
            lblStatueDate.Text = clsFormat.DateToShort(_LocalDriverL.LastStatusDate);
            lblCreatedBy.Text = clsGlobel.CurrentUser.UserName;
        }

        private void linkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Person_Details frm=new Person_Details(_LocalDriverL.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void linkLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm =new frmLicenseInfo(_LocalDriverL.LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
        }
    }
}
