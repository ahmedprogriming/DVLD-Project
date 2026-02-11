using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bissens_layer;
using Business_Layer;
using DVLD_Project.Class_Global;
using DVLD_Project.Properties;

namespace DVLD_Project
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID = -1;
        private clsLicense _License;
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get { return _LicenseID; }

        }

        public clsLicense SelecedtLicenseInfo
        {
            get { return _License; }
        }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;
            
            if(ImagePath != "")
                if(File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("This Person Not Found Images !", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.GetAllLicenseByID(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("This Not Found LicenseID [" + LicenseID + "]!", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;

            }

            lblClass.Text = _License.LicenseClassInfo.LicenseName;
            lblFullName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _LicenseID.ToString();
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Mali" : "Fmail";
            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lblExprintion.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblissueReason.Text = (_License.IssueReasonText);
            lblNotes.Text = _License.Notes == "" ? _License.Notes : "No Notes";
            lblDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);
            lblDriverID.Text = _License.DriverID.ToString();
            lblIsActive.Text = (_License.IsActive == true ? "Yes" : "No");
            lblIsDetained.Text = "No";
            _LoadPersonImage();
        }
    }
}
