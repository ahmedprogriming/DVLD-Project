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
    public partial class frmChangePassword : Form
    {
     private   clsUser _User;
       private int _UserID = -1;
        public frmChangePassword(int ID)
        {
            InitializeComponent();
            _UserID= ID;
        }

        private void _LoadData()
        {
            _User =clsUser.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
         
            crlInformationUser1.LoadInfoUsers(_UserID);
        }

        private void _ResultDefulteValues()
        {
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Text = "";
            txtNewPassword.Text="";
            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResultDefulteValues();
            _LoadData();
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are not valide, put the mous over the read icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password=txtNewPassword.Text;

            if(_User.Save())
            {
                MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ResultDefulteValues();
            }
            else
            {
                MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtCurrentPassword, null);
            }
            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel= true;
                errorProvider1.SetError(txtCurrentPassword, "This Error Passwrd!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel= true;
                errorProvider1.SetError(txtConfirmPassword, "This Password Not equle New Password!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
