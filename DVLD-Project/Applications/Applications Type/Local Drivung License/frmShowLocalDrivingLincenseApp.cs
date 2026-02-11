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
    public partial class frmShowLocalDrivingLincenseApp : Form
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLApp;
        private int _LocalDrivingAppID;
        public frmShowLocalDrivingLincenseApp(int localDrivingAppID)
        {
            InitializeComponent();
            _LocalDrivingAppID = localDrivingAppID;
        }

        private void frmShowLocalDrivingLincenseApp_Load(object sender, EventArgs e)
        {
            crlApplicationInfo1.LoadDateApplicationInfoByLocalDrivinLAppID(_LocalDrivingAppID);
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
