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
    public partial class frmShowInternationalLicense : Form
    {
        private int _InternationalID = -1;
        public frmShowInternationalLicense(int InternationalID)
        {
            InitializeComponent();
            _InternationalID = InternationalID;
        }

        private void frmShowInternationalLicense_Load(object sender, EventArgs e)
        {
            ctrDriverInternationalLicenseInfo1.LoadInternationalInfo(_InternationalID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
