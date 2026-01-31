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
    public partial class Formtest : Form
    {
        public Formtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageUsers frmAddUpdateUser = new frmManageUsers();
            frmAddUpdateUser.ShowDialog();
        }

        private void Formtest_Load(object sender, EventArgs e)
        {

        }
    }
}
