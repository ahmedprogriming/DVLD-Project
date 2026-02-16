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
    public partial class ctrDriverInternationalLicenseInfo : UserControl
    {
        private int _InterationalID = -1;
        private clsInternationalLicense _InternationalLicense;

        public ctrDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public int InterationalID
        {
            get
            {
                return _InterationalID;
            }
        }

        public void LoadInternationalInfo(int InternationalID)
        {
            _InterationalID= InternationalID;

            _InternationalLicense=clsInternationalLicense.Find(_InterationalID);

            if (_InternationalLicense == null)
            {
                MessageBox.Show("This International License ID Not found !", "Filed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           // lblFullName.Text=clsPerson.Find(clsApplication.FindApplicationByID(_InternationalLicense.ApplicationID).ApplicantPersonID).FullName;
           lblFullName.Text=clsDriver.GetAllDriversByID(_InternationalLicense.DriverID).PersonInfo.FullName;
            lblInternationalID.Text=InternationalID.ToString();
            lblNationalNo.Text= clsDriver.GetAllDriversByID(_InternationalLicense.DriverID).PersonInfo.NationalNo;
            lblGendor.Text= clsDriver.GetAllDriversByID(_InternationalLicense.DriverID).PersonInfo.Gendor==1 ?"Mali":"Fmail";
            lblLicenseID.Text=_InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = clsFormat.DateToShort(_InternationalLicense.IssueDate);
            lblExprintion.Text = clsFormat.DateToShort(_InternationalLicense.ExpirationDate);
            lblApplicationID.Text=_InternationalLicense.ApplicationID.ToString();
            lblDriverID.Text=_InternationalLicense.DriverID.ToString();
            lblDateOfBirth.Text = clsFormat.DateToShort(clsDriver.GetAllDriversByID(_InternationalLicense.DriverID).PersonInfo.DateOfBirth);
            lblIsActive.Text = _InternationalLicense.IsActive == true ? "Yes" : "No";
            pbPersonImage.ImageLocation= clsDriver.GetAllDriversByID(_InternationalLicense.DriverID).PersonInfo.ImagePath;

        }
    }
}
