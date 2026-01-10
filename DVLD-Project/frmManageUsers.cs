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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void tsChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassWord frm = new frmChangePassWord();
            frm.ShowDialog();
        }

        private void tsmShowDetiles_Click(object sender, EventArgs e)
        {
            frmUserInformtion frm = new frmUserInformtion();
            frm.ShowDialog();
        }
    }
}
