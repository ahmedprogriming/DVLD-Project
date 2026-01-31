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
    public partial class frmUpdateApplicationType : Form
    {
        private clsApplicatonType _AppType;
        private int _AppTypeID = -1;
        public frmUpdateApplicationType(int ID)
        {
            InitializeComponent();
            _AppTypeID = ID;
        }

        private void _LoadData()
        {
            _AppType = clsApplicatonType.FindAppTypeID(_AppTypeID);
            if (_AppType == null)
            {
                MessageBox.Show("No Application Type with ID = " + _AppTypeID, "Application Type not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblidAppType.Text = _AppTypeID.ToString();
            txtTitle.Text = _AppType.AppTypeTitle;
            txtFees.Text = _AppType.AppTypeFees.ToString();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are not valide, put the mous over the read icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _AppType.AppTypeTitle = txtTitle.Text.Trim();
             
             _AppType.AppTypeFees=Convert.ToSingle(txtFees.Text);

            if(_AppType.Save())
            {
                MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "This filed is Empty!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtTitle, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This filed is Empty!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtFees, null);
            }
            if(!clsValiadion.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invaild Number!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtFees, null);
            }
        }
    }
}
