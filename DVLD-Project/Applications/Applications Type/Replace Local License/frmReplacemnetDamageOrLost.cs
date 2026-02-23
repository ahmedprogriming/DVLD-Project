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
using static Bissens_layer.clsLicense;

namespace DVLD_Project
{
    public partial class frmReplacemnetDamageOrLost : Form
    {
       

        private int _NewLicenseID = -1;

        private int _GetApllicationType()
        {
            if (rdDamagedLicense.Checked)
                return (int)clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplacementforaLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            if (rdDamagedLicense.Checked)
                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }
        public frmReplacemnetDamageOrLost()
        {
            InitializeComponent();
        }

        private void frmReplacemnetDamageOrLost_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseWithFilter1.TextFoucs();
        }

        private void frmReplacemnetDamageOrLost_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);          
          
            lblCreatedUser.Text = clsGlobel.CurrentUser.UserName.ToString();
            rdDamagedLicense.Checked= true;

        }

        private void ctrlDriverLicenseWithFilter1_OnLicesneSelected(int obj)
        {
            int SelectLicenseID=obj;

            if (SelectLicenseID == -1)
            {
                return;
            }

            linkShowLicenseHisTory.Enabled = (SelectLicenseID != -1);
            lblOldLicenseID.Text=SelectLicenseID.ToString();

            if (!ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.IsActive)
            {
                MessageBox.Show("Select License is not Active Choose Lisense other!"
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacemnetLicense.Enabled = false;

                return;
            }


            btnIssueReplacemnetLicense.Enabled = true;
        }

        private void btnIssueReplacemnetLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want Issue Replacemnet License ? ", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

        
                clsLicense RenewLicense = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.ReplaceLicense(_GetIssueReason(), clsGlobel.CurrentUser.UserID);


                if (RenewLicense == null)
                {
                    MessageBox.Show("License Was not Issued !", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _NewLicenseID = RenewLicense.LicenseID;

                MessageBox.Show("Replacemnet License Successfully whith License ID  =" + _NewLicenseID, "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblReplacemnetLicenseID.Text = _NewLicenseID.ToString();
                lblLicenseReApplicationID.Text = RenewLicense.ApplicationID.ToString();

                btnIssueReplacemnetLicense.Enabled = false;
                ctrlDriverLicenseWithFilter1.FilterEnbled = false;
                linkShowLicenseInfo.Enabled = true;

        
        }

     

        private void rdDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {

                lblTitel.Text = "Replacemnet For Damaged License";
                lblApplicationFees.Text=clsApplicatonType.FindAppTypeID(_GetApllicationType()).AppTypeFees.ToString();
         
        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void linkShowLicenseHisTory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void rdLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitel.Text = "Replacemnet For Lost License";
            lblApplicationFees.Text = clsApplicatonType.FindAppTypeID(_GetApllicationType()).AppTypeFees.ToString();
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
