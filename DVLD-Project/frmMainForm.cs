using System;

using System.Windows.Forms;

using Business_Layer;
namespace DVLD_Project
{
    public partial class formMain : Form
    {
        frmFormLogin _frmLogin;
        public formMain(frmFormLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

      
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDriverscs frmListDriverscs = new frmListDriverscs();
            frmListDriverscs.Show();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople people = new frmManagePeople();
            people.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers user  = new frmManageUsers();
            user.ShowDialog();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmChangePassword frm=new frmChangePassword(clsGlobel.CurrentUser.UserID);
            frm.ShowDialog();

        }

        private void tmCurrentUser_Click(object sender, EventArgs e)
        {
            frmUserInformtion frm = new frmUserInformtion(clsGlobel.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void tmSignOut_Click(object sender, EventArgs e)
        {
           clsGlobel.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

   
        private void tsmManageApplicationType_Click(object sender, EventArgs e)
        {
            frmManageApplicationType frm=new frmManageApplicationType();
            frm.ShowDialog();
        }

        private void tsmManageTestType_Click(object sender, EventArgs e)
        {
            frmListTestType frm=new frmListTestType();
            frm.ShowDialog();
        }

        private void tsmmanageApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmLocaolLicenes_Click(object sender, EventArgs e)
        {
            frmNewLocalLicenesApplicatio frm=new frmNewLocalLicenesApplicatio();
            frm.ShowDialog();
        }

        private void tsmLocalDrivingLiceneApplicaton_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
            frm.ShowDialog();

        }
    }
}
