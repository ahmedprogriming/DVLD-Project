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
using DVLD_Project.Class_Global;

namespace DVLD_Project
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
  
        private int _InternationalLicD=-1;
   
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicense frm= new frmShowInternationalLicense(_InternationalLicD);
            frm.ShowDialog();
        }

        private void linkShowLicenseHisTory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm= new frmShowPersonLicenseHistory(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {

          

            lblApplicationDate.Text =clsFormat.DateToShort( DateTime.Now);
         
            lblIssueDate.Text= clsFormat.DateToShort(DateTime.Now);
           lblExpritionDate.Text= clsFormat.DateToShort(DateTime.Now.AddYears(1));
            lblFees.Text=clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.NewInternationalLicense).AppTypeFees.ToString();
            lblCreatedUser.Text=clsGlobel.CurrentUser.UserName.ToString();
         
        }

        private void ctrlDriverLicenseWithFilter1_OnLicesneSelected_1(int obj)
        {
            int SelectLicenseID = obj;

            lblLocalLicenseID.Text = SelectLicenseID.ToString();


            linkShowLicenseHisTory.Enabled = (SelectLicenseID != -1);

            if (SelectLicenseID == -1)
            {
                return;
            }

            if (ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.LicenseClass != 3)
            {
                MessageBox.Show("Seleced License ID Shoudl be Class 3, select anothor one.", "Not alllow", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int ActiveInterationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DriverID);

            if (ActiveInterationalLicenseID != -1)
            {
                MessageBox.Show("Person already this License International [" + ActiveInterationalLicenseID + "] !", "Not alllow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linkShowLicenseInfo.Enabled = true;
                _InternationalLicD = ActiveInterationalLicenseID;
                btnIssue.Enabled = false;

                return;

            }

            btnIssue.Enabled = true;
        }



        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want Issue License ? ", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
        
              clsInternationalLicense InternationalLicense = new clsInternationalLicense();


            InternationalLicense.ApplicantPersonID =ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatue.Completed;
            InternationalLicense.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            InternationalLicense.PaidFees = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.NewInternationalLicense).AppTypeFees;
            InternationalLicense.CreatedByUserID=clsGlobel.CurrentUser.UserID;

            InternationalLicense.DriverID = ctrlDriverLicenseWithFilter1.SelectesLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseWithFilter1.LicenseID;
            InternationalLicense.IssueDate= DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            InternationalLicense.IsActive = true;
            InternationalLicense.CreatedByUserID=clsGlobel.CurrentUser.UserID;

            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License ID="+ InternationalLicense.InternationalLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
                {
                    MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   lblInternationalID.Text = InternationalLicense.InternationalLicenseID.ToString();
                   lblInternationalApplicationID.Text = InternationalLicense.ApplicationID.ToString();
                   _InternationalLicD = InternationalLicense.InternationalLicenseID;

                    btnIssue.Enabled = false;
                    ctrlDriverLicenseWithFilter1.FilterEnbled = false;
                    linkShowLicenseInfo.Enabled = true;

                }
           
        }

       
        private void frmNewInternationalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseWithFilter1.TextFoucs();
        }

      
    }
}
