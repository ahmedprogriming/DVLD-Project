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
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
           
        }
        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                crlCardInfoWithFalter1.LoadPersonInfo(_PersonID);
                crlCardInfoWithFalter1.FiltrEnbled = false;
                crlDriverLicense1.LoadDriverByPersonID(_PersonID);
            }
            else
            {
                crlCardInfoWithFalter1.FiltrEnbled = true;
                crlCardInfoWithFalter1.FilterFocus();
            }
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crlCardInfoWithFalter1_OnPersonSelected(int obj)
        {
            _PersonID= obj;

            if(_PersonID==-1)
            {
                crlDriverLicense1.Clear();
            }
            else
            {
                crlDriverLicense1.LoadDriverByPersonID(_PersonID) ; 
            }
        }
    }
}
