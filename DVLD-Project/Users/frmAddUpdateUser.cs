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
    public partial class frmAddUpdateUser : Form
    {
 
        enum enMode { Adduser=0, Updateuser=1 }
        private enMode _Mode;
        private int _UserID=-1;

        clsUser User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.Adduser;
        }

        public frmAddUpdateUser(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            _Mode = enMode.Updateuser;
        }

        private void _ResultDefult()
        {
            if(_Mode == enMode.Adduser)
            {
                lblTitel.Text = "Add New User";
                this.Text = "Add New User";
                User = new clsUser();
                tbLoginInfo.Enabled=false;
                crlCardInfoWithFalter1.FilterFocus();
            }
            else
            {
                lblTitel.Text = "Update User";
                this.Text = "Update User";
                tbLoginInfo.Enabled = true;
                btnSave.Enabled = true;

            }

            txtUserName.Text = "";
            txtPassWord.Text = "";
            txtConfirmPassword.Text = "";
            ckIsActive.Checked = true;
        }

        private void _LoadData()
        {
            User = clsUser.FindByUserID(_UserID);
 crlCardInfoWithFalter1.FiltrEnbled = false;
            if( User == null )
            {
                MessageBox.Show("No User with ID = " + _UserID, "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           lblUserID.Text = _UserID.ToString();
            crlCardInfoWithFalter1.LoadPersonInfo(User.PersonID);
           
            txtUserName.Text = User.UserName;
            txtPassWord.Text=User.Password;
            txtConfirmPassword.Text = User.Password;
            ckIsActive.Checked=(User.IsActive);
            
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are not valide, put the mous over the read icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User.UserName= txtUserName.Text.Trim();
            User.Password= txtPassWord.Text.Trim();
            User.IsActive=(ckIsActive.Checked);
            User.PersonID=crlCardInfoWithFalter1.PersonID;

            if(User.Save())
            {
                _Mode = enMode.Updateuser;
                lblTitel.Text = "Updata User";
                this.Text = "Update User";
                lblUserID.Text = User.UserID.ToString();

                MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }

            else
            {
                MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
           _ResultDefult();
            if (_Mode == enMode.Updateuser)
            {
                _LoadData();
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtUserName, null);
            }
            if(txtUserName.Text.Trim()!=User.UserName&&clsUser.IsUserNameExsites(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "this User Name is used for another User!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassWord.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassWord, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtPassWord, null);
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
            if(txtConfirmPassword.Text.Trim()!=txtPassWord.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Write Password the Correct!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtConfirmPassword, null);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {if (_Mode == enMode.Updateuser)
            {
                btnSave.Enabled = true;
                tbLoginInfo.Enabled=true;
                tbUser.SelectedTab = tbLoginInfo;
                return;
            }

            if (crlCardInfoWithFalter1.PersonID != -1)
            {
                if (clsUser.IsUserExsiteForePersonID(crlCardInfoWithFalter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    crlCardInfoWithFalter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tbLoginInfo.Enabled = true;
                    tbUser.SelectedTab = tbLoginInfo;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                crlCardInfoWithFalter1.FilterFocus();
            }
        }

   
    }
}
