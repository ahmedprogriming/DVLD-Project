using System;

using System.Windows.Forms;
using DVLD_Project;
using Business_Layer;
namespace DVLD_Project
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople people = new ManagePeople();
            people.ShowDialog();
        }
    }
}
