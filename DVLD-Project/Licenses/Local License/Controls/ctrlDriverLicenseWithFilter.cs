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

namespace DVLD_Project
{
    public partial class ctrlDriverLicenseWithFilter : UserControl
    {
        public event Action<int> OnLicesneSelected;

        protected virtual void LicenseSelected(int licenseId)
        {
            Action<int> handelr = OnLicesneSelected;
            if (handelr != null)
            {
                handelr(licenseId);
            }
        }
        public ctrlDriverLicenseWithFilter()
        {
            InitializeComponent();
        }

        private int _LicenseID = -1;

        public int LicenseID
        {
            get
            {
                return ctrlDriverLicenseInfo1.LicenseID;
            }
        }

        private bool _FilterEnbled = true;

        public bool FilterEnbled
        {
            get
            {
                return _FilterEnbled;
            }
            set
            {
                _FilterEnbled = value;
                gbFilterLicense.Enabled = _FilterEnbled;
            }
        }

        public clsLicense SelectesLicenseInfo
        {
            get
            {
                return ctrlDriverLicenseInfo1.SelecedtLicenseInfo;
            }
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtFilterLicenseID.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadInfo(LicenseID);
            _LicenseID = ctrlDriverLicenseInfo1.LicenseID;
            if(OnLicesneSelected != null&&FilterEnbled)

                    LicenseSelected(_LicenseID);

        }

        public void TextFoucs()
        {
            txtFilterLicenseID.Focus();
        }

        private void txtFilterLicenseID_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFilterLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterLicenseID, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtFilterLicenseID, null);
            }
        }

        private void txtFilterLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if(e.KeyChar ==(char)13)
            {
                btnFindLicenseID.PerformClick();
            }
        }

        private void btnFindLicenseID_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are not valide, put the mous over the read icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilterLicenseID.Focus();
                return;
            }
            _LicenseID=int.Parse(txtFilterLicenseID.Text.Trim());
            ctrlDriverLicenseInfo1.LoadInfo(_LicenseID);
        }
    }
}
