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
    public partial class frmDetainLicense : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lblCreatedUser.Text = clsGlobel.CurrentUser.UserName;
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
        }

        private void ctrlDriverLicenseWithFilter1_OnLicesneSelected(int obj)
        {
             _SelectedLicenseID = obj;

            if (_SelectedLicenseID == -1)
            {
                return;
            }

            linkShowLicenseHisTory.Enabled=(_SelectedLicenseID != -1);
            lblLicenseID.Text= _SelectedLicenseID.ToString();

            if(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License already detained,choose another one.","Not allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);

                btnDetainLicense.Enabled = false;
                return;
            }

            txtFineFees.Focus();
            btnDetainLicense.Enabled= true;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want Detain License ? ", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            _DetainID = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.Detain(Convert.ToSingle(txtFineFees.Text), clsGlobel.CurrentUser.UserID);
          
            if (_DetainID==-1)
            {
                MessageBox.Show("License Was not Detain !", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            MessageBox.Show("License Detained Successfully whith Detain ID  =" + _DetainID, "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblDetainID.Text = _DetainID.ToString();
            btnDetainLicense.Enabled = false;
            ctrlDriverLicenseWithFilter1.FilterEnbled = false;
            txtFineFees.Enabled = false;
            linkShowLicenseInfo.Enabled = true;



        }

        private void frmDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseWithFilter1.TextFoucs();
        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm=new frmLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void linkShowLicenseHisTory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm=new frmShowPersonLicenseHistory(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtFineFees, null);
            }
        }
    }
}
