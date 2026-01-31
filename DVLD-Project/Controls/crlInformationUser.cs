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
    public partial class crlInformationUser : UserControl
    {
       
        private clsUser _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }
        public crlInformationUser()
        {
            InitializeComponent();
           
        }

        public void LoadInfoUsers(int UserID)
        {
            _UserID = UserID;
            _User=clsUser.FindByUserID(UserID);
            
            if(_User == null )
            {
                MessageBox.Show("No User with ID = " + _UserID, "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            labUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = (_User.IsActive == true ? "Yes" : "No");

            clrInformtionPople1.LoadPersonInfo(_User.PersonID);
        }

        private void clrInformtionPople1_Load(object sender, EventArgs e)
        {

        }
    }
}
