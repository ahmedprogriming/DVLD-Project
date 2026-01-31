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
    public partial class crlRetakeTest : UserControl
    {
        private clsLocalDrivingLicenseApplications _LocalDriverL;
        public crlRetakeTest()
        {
            InitializeComponent();
        }

        private bool _GroEnbled = false;

        public bool GroEnbled
        {
            get { return _GroEnbled; }
            set {
                _GroEnbled = value;
                groRetakeInfo.Enabled = _GroEnbled;
                    
                }
        }
        public void LoadDateApplication(int LDLAppID,clsTestType.enTestType Titel)
        {
            _LocalDriverL = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(LDLAppID);

            if (_LocalDriverL == null)
            {
                MessageBox.Show("This Not Found Local Driver License Application ID [" + LDLAppID + "]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRAppFees.Text = clsApplicatonType.FindAppTypeID(7).AppTypeFees.ToString();
            lblRTestID.Text = clsAppointemntsTests.FindByID(LDLAppID).RetakeTestApplicationID.ToString();
            lbltotalfees.Text = clsTestType.Find(Titel).TestTypeFees + Convert.ToSingle(lblRAppFees.Text).ToString();
           
        }
    }
}
