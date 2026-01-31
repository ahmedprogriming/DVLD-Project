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
    public partial class frmEditTestType : Form
    {
        private clsTestType _TestType;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        public frmEditTestType(clsTestType.enTestType ID)
        {
            InitializeComponent();
            _TestTypeID = ID;
        }

        private void _LoadData()
        {
            _TestType = clsTestType.FindTestTypeID(_TestTypeID);
            if (_TestType == null)
            {
                MessageBox.Show("No Test Type with ID = " + _TestTypeID, "Test Type not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblidTestType.Text = _TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = _TestType.TestTypeFees.ToString();
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }

        private void frmEditTestType_Load(object sender, EventArgs e)
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

            _TestType.TestTypeTitle = txtTitle.Text.Trim();
            _TestType.TestTypeDescription = txtDescription.Text.Trim();
            _TestType.TestTypeFees=Convert.ToSingle(txtFees.Text.Trim());

            if (_TestType.Save())
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

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "This filed is Empty!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtDescription, null);
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
            if (!clsValiadion.IsNumber(txtFees.Text.Trim()))
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
