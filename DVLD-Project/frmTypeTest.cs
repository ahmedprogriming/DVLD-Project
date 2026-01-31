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
    public partial class frmAppointementsTypeTest : Form
    {
      private  clsLocalDrivingLicenseApplications _LocalDrivingLApp;
        private DataTable _AppointemntsTests;
        int _DrivingLAppID;
        public frmAppointementsTypeTest(int ID)
        {
            InitializeComponent();
            _DrivingLAppID = ID;
        }




        private void btnAddAppointements_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm=new frmScheduleTest();
            frm.ShowDialog();
            frmAppointementsTypeTest_Load(null,null);
        }

        private void tackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm=new frmTakeTest();
            frm.ShowDialog();
        }

        private void frmAppointementsTypeTest_Load(object sender, EventArgs e)
        {
           crlApplicationInfo1.LoadDateApplication(_DrivingLAppID);
            _AppointemntsTests = clsAppointemntsTests.GatAllAppointemnt(_DrivingLAppID);
            dgvAppointements.DataSource = _AppointemntsTests;

            labRecodCount.Text = dgvAppointements.Rows.Count.ToString();

            if (dgvAppointements.Rows.Count > 0)
            {
                dgvAppointements.Columns[0].HeaderText = "AppointmentID";
                dgvAppointements.Columns[0].Width = 90;

                dgvAppointements.Columns[1].HeaderText = "Appointment Date";
                dgvAppointements.Columns[1].Width = 100;

                dgvAppointements.Columns[2].HeaderText = "Paid Fess";
                dgvAppointements.Columns[2].Width = 100;

                dgvAppointements.Columns[3].HeaderText = "IsLocked";
                dgvAppointements.Columns[3].Width = 100;
                

            }

            dgvAppointements.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvAppointements.EnableHeadersVisualStyles = false;

            dgvAppointements.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}