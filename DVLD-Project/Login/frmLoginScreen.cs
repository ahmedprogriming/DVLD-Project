using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bissens_layer;
using System.Net.NetworkInformation;


namespace DVLD_Project
{
    public partial class frmFormLogin : Form
    {
        private clsUser _User;
  
        public frmFormLogin()
        { 
            InitializeComponent();
      
            

        }
   

 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobel.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                ckRemember.Checked = true;

            }
            else
            {
                ckRemember.Checked= false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           _User =clsUser.FindByUserNameAndPassword(txtUserName.Text.Trim(),txtPassword.Text.Trim());
            if (_User != null)
            {
               if(ckRemember.Checked)
                {
                    clsGlobel.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
               else
                {
                    clsGlobel.RememberUsernameAndPassword("", "");
                }
                if (!_User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsGlobel.CurrentUser = _User;
                this.Hide();
                formMain frm = new formMain(this);    
                frm.ShowDialog();
                this.Close();
                
          
            }
          
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
