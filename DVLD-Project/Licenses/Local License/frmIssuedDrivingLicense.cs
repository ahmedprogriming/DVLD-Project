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
using static Bissens_layer.clsTestType;

namespace DVLD_Project
{
    public partial class frmIssuedDrivingLicense : Form
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLApp;
     
        int _DrivingLAppID = -1;
        public frmIssuedDrivingLicense(int drivingLAppID)
        {
            InitializeComponent();
            _DrivingLAppID = drivingLAppID;
        }

        private void frmIssuedDrivingLicense_Load(object sender, EventArgs e)
        {
            _LocalDrivingLApp = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(_DrivingLAppID);

            if (_LocalDrivingLApp == null)
            {
                MessageBox.Show("This Not Found Local Driver License Application ID [" + _DrivingLAppID + "]!", "Allow Not", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if(!_LocalDrivingLApp.PasedAllTest())
            {

                MessageBox.Show("Person Should Pass All Tests First.", "Allow Not", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            int LicenseID=_LocalDrivingLApp.GetActiveLicenseID();
            if (LicenseID != -1)
            {
                MessageBox.Show("This Person already has License This ID ["+LicenseID+"]", "Allow Not", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            crlApplicationInfo1.LoadDateApplicationInfoByLocalDrivinLAppID(_DrivingLAppID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
           int LicenseID=_LocalDrivingLApp.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(),clsGlobel.CurrentUser.UserID);

         
                if (LicenseID!=-1)
                {
                    MessageBox.Show(" License Issued Successfully whith License ID  =" + LicenseID + " ", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("License Was not Issued !", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

