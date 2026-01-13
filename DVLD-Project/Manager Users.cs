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
    public partial class Manager_Users : Form
    {
        public Manager_Users()
        {
            InitializeComponent();
        }

      
        private void Manager_Users_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewUser_Click_1(object sender, EventArgs e)
        {
            frmAddUpdateUser user = new frmAddUpdateUser();
            user.ShowDialog();
        }
    }
}
