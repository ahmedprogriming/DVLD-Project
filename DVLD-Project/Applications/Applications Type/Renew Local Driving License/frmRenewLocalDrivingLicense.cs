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
    public partial class frmRenewLocalDrivingLicense : Form
    {
       private int _NewLicenseID = -1;
       
 
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicenseWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void frmRenewLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseWithFilter1.TextFoucs();
        }

        private void ctrlDriverLicenseWithFilter1_OnLicesneSelected(int obj)
        {
             int SelectLicenseID = obj;

            lblOldLicenseID.Text = SelectLicenseID.ToString();

            linkShowLicenseHisTory.Enabled = (SelectLicenseID != -1);
            if(SelectLicenseID == -1)
            {
                return;
            }

            int DefaultValidityLength = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.LicenseClassInfo.DefaultValidityLength;

            lblfeeslicense.Text = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.LicenseClassInfo.ClassFess.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblfeeslicense.Text)).ToString();   
            lblExpritionDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            txtNots.Text = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.Notes;
         
            if (!ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Select License is not yet expiared,it will expire on: \n" + clsFormat.DateToShort(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.ExpirationDate)
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;
          
                return ;
            }

            if (!ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.IsActive)
            {
                MessageBox.Show("Select License is not Active Choose Lisense other!" 
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;

                return;
            }

            btnRenewLicense.Enabled = true;
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);

            lblIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblApplicationFees.Text = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.RenewDrivingLicenseService).AppTypeFees.ToString();


            lblCreatedUser.Text = clsGlobel.CurrentUser.UserName.ToString();
        
        }


        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want Issue Renew License ? ", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            clsLicense RenewLicense = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.RenewLicense(txtNots.Text.Trim(), clsGlobel.CurrentUser.UserID);


            if (RenewLicense == null)
            {
                MessageBox.Show("License Was not Issued !", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _NewLicenseID = RenewLicense.LicenseID;

            MessageBox.Show("Renew License Successfully whith License ID  =" + _NewLicenseID, "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblRenewLicenseID.Text = _NewLicenseID.ToString();
            lblNewApplicationID.Text = RenewLicense.ApplicationID.ToString();

            btnRenewLicense.Enabled = false;
            ctrlDriverLicenseWithFilter1.FilterEnbled = false;
            linkShowLicenseInfo.Enabled = true;
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

    }
}
