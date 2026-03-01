using Bissens_layer;
using DVLD_Project.Class_Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmReleaseDetainLicense : Form
    {
        private int _SelectedLicenseID = -1;

        public frmReleaseDetainLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainLicense(int licenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = licenseID;
            ctrlDriverLicenseWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrlDriverLicenseWithFilter1.FilterEnbled = false;
        }


        private void frmReleaseDetainLicense_Load(object sender, EventArgs e)
        {
           

        }

        private void ctrlDriverLicenseWithFilter1_OnLicesneSelected(int obj)
        {
             _SelectedLicenseID = obj;

          
            if (_SelectedLicenseID == -1)
            {
                return;
            }

            linkShowLicenseHisTory.Enabled = (_SelectedLicenseID != -1);
            lblLicenseID.Text = _SelectedLicenseID.ToString();

            if (!ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License already Released,choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnReleaseLicense.Enabled = false;
                return;
            }
            lblDetainID.Text = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DetainedInfo.DetainID.ToString();
            lblLicenseID.Text = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.LicenseID.ToString();
            lblDetainDate.Text =clsFormat.DateToShort(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DetainedInfo.DetainDate);
            lblCreatedUser.Text = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DetainedInfo.CreatedByUserID.ToString();
            lblApplicationFees.Text = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).AppTypeFees.ToString();
            lblFineFees.Text = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblFineFees.Text) + Convert.ToSingle(lblApplicationFees.Text)).ToString();

            btnReleaseLicense.Enabled = true;
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want Releaseed this License ? ", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int ApplicationID = -1;

            bool IsRelesaed = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.RelesaedDetainLicense( clsGlobel.CurrentUser.UserID,ref ApplicationID);


            if (!IsRelesaed)
            {
                MessageBox.Show("License Was not Releaseed !", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("Detained License Releaseed Successfully ", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblApplicationID.Text = ApplicationID.ToString();
            btnReleaseLicense.Enabled = false;
            ctrlDriverLicenseWithFilter1.FilterEnbled = false;
            linkShowLicenseInfo.Enabled = true;
        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(ctrlDriverLicenseWithFilter1.LicenseID);
            frm.ShowDialog();
        }

        private void linkShowLicenseHisTory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
