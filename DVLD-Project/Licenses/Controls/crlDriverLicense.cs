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
    public partial class crlDriverLicense : UserControl
    {
        private int _DriverID = -1;
        private clsDriver _Driver;
        private DataTable _dtDriverLocalLicensePerson;
        private DataTable _dtDriverInternationalLicensePerson;

        public crlDriverLicense( )
        {
            InitializeComponent();
       
          
        }
        private void _LoadDriverInternationalLicense()
        {
            _dtDriverInternationalLicensePerson = clsDriver.GetInternationalLicense(_DriverID);
            dgvInternational.DataSource = _dtDriverInternationalLicensePerson;

            labRecodLDLApp.Text = dgvInternational.Rows.Count.ToString();

            if (dgvLocalDriverLicense.Rows.Count > 0)
            {
                dgvInternational.Columns[0].HeaderText = "Int.Lic ID";
                dgvInternational.Columns[0].Width = 100;

                dgvInternational.Columns[1].HeaderText = "Appl ID";
                dgvInternational.Columns[1].Width = 100;

                dgvInternational.Columns[2].HeaderText = "Dri ID";
                dgvInternational.Columns[2].Width = 100;

                dgvInternational.Columns[3].HeaderText = "L.Lic ID";
                dgvInternational.Columns[3].Width = 100;

                dgvInternational.Columns[4].HeaderText = "Issue Date";
                dgvInternational.Columns[4].Width = 150;

                dgvInternational.Columns[5].HeaderText = "Expirtion Date";
                dgvInternational.Columns[5].Width = 150;

                dgvInternational.Columns[6].HeaderText = "Is Active";
                dgvInternational.Columns[6].Width = 95;

            }

            dgvInternational.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvInternational.EnableHeadersVisualStyles = false;

            dgvInternational.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void _LoadDriverLocalLicense()
        {
            _dtDriverLocalLicensePerson=clsDriver.GetLicense(_DriverID);    
            dgvLocalDriverLicense.DataSource = _dtDriverLocalLicensePerson;

            labRecodLDLApp.Text = dgvLocalDriverLicense.Rows.Count.ToString();

            if (dgvLocalDriverLicense.Rows.Count > 0)
            {
                dgvLocalDriverLicense.Columns[0].HeaderText = "Lic.ID";
                dgvLocalDriverLicense.Columns[0].Width = 100;

                dgvLocalDriverLicense.Columns[1].HeaderText = "App.ID";
                dgvLocalDriverLicense.Columns[1].Width = 100;

                dgvLocalDriverLicense.Columns[2].HeaderText = "Class Name";
                dgvLocalDriverLicense.Columns[2].Width = 250;

                dgvLocalDriverLicense.Columns[3].HeaderText = "Issue Date";
                dgvLocalDriverLicense.Columns[3].Width = 150;

                dgvLocalDriverLicense.Columns[4].HeaderText = "Expiration Date";
                dgvLocalDriverLicense.Columns[4].Width = 150;

                dgvLocalDriverLicense.Columns[5].HeaderText = "Active License";
                dgvLocalDriverLicense.Columns[5].Width = 90;

            }

            dgvLocalDriverLicense.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvLocalDriverLicense.EnableHeadersVisualStyles = false;

            dgvLocalDriverLicense.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        public void LoadInfo(int DriverID)
        {
            _Driver=clsDriver.GetAllDriversByID(DriverID);

            if(_Driver==null)
            {
                MessageBox.Show("This Driver Id Not Found","Filed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _DriverID=DriverID;

            _LoadDriverLocalLicense();
           _LoadDriverInternationalLicense();
        }

        public void LoadDriverByPersonID(int PersonID)
        {
            _Driver = clsDriver.GetAllDriverByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show("This Person Id Not Found License Drivers", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _Driver.DriverID;

            _LoadDriverLocalLicense();
            _LoadDriverInternationalLicense();
        }

        public void Clear()
        {
            _dtDriverInternationalLicensePerson.Clear();
            _dtDriverLocalLicensePerson.Clear();
        }
        private void crlDriverLicense_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmShowLocalLicense_Click(object sender, EventArgs e)
        {
            int LiceseID = (int)dgvLocalDriverLicense.CurrentRow.Cells[0].Value;
            frmLicenseInfo frm = new frmLicenseInfo(LiceseID);
            frm.ShowDialog();
        }

        private void tsmShowInternationalLicense_Click(object sender, EventArgs e)
        {
            int InternationalLiceseID = (int)dgvInternational.CurrentRow.Cells[0].Value;
            frmLicenseInfo frm = new frmLicenseInfo(InternationalLiceseID);
            frm.ShowDialog();
        }
    }
}
