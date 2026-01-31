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
using Business_Layer;

namespace DVLD_Project
{
    public partial class frmManageUsers : Form
    {
    private static   DataTable _Userall;
      

        public frmManageUsers()
        {
            InitializeComponent();
        }

     
        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterText = "";
        
            switch (cobFilterUser.Text)
            {
                case "Person ID":
                    FilterText = "PersonID";
                    break;
                case "User ID":
                    FilterText = "UserID";
                    break;
                case "User Name":
                    FilterText = "UserName";
                    break;
                case "Full Name":
                    FilterText = "FullName";
                    break;
                case "Is Active":
                    FilterText = "IsActive";
                    break;
            }
            if(txbFilter.Text==""||FilterText=="None")
            {
                _Userall.DefaultView.RowFilter = "";
               labRecodUser.Text=dgvUser.Rows.Count.ToString();
                return;
            }

         if(FilterText!= "UserName" || FilterText!= "FullName")
            
                _Userall.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterText, txbFilter.Text.Trim());
           
            else 
              _Userall.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterText, txbFilter.Text.Trim());

            labRecodUser.Text = dgvUser.Rows.Count.ToString();
        }

     
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
   
            _Userall = clsUser.GetAllUsers();
            dgvUser.DataSource = _Userall;
            cobFilterUser.SelectedIndex = 0;
            labRecodUser.Text = dgvUser.Rows.Count.ToString();

            if(dgvUser.Rows.Count>0)
            {
                dgvUser.Columns[0].HeaderText = "User ID";
                dgvUser.Columns[0].Width = 120;

                dgvUser.Columns[1].HeaderText = "Person ID";
                dgvUser.Columns[1].Width = 120;

                dgvUser.Columns[2].HeaderText = "Full Name";
                dgvUser.Columns[2].Width = 330;

                dgvUser.Columns[3].HeaderText = "User Name";
                dgvUser.Columns[3].Width = 150;

                dgvUser.Columns[4].HeaderText = "PassWord";
                dgvUser.Columns[4].Width = 100;

                dgvUser.Columns[5].HeaderText = "Is Active";
                dgvUser.Columns[5].Width = 100;

            }

            dgvUser.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dgvUser.EnableHeadersVisualStyles = false;

            dgvUser.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void cobFilterUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          if(cobFilterUser.Text=="Is Active")
            {
                cobIsActive.Visible = true;
                txbFilter.Visible = false;
            }
          else if(cobFilterUser.Text=="None")
            {
                txbFilter.Visible = false;
                cobIsActive.Visible = false;
            }
          else
            {
                txbFilter.Visible = true;
                cobIsActive.Visible = false;
                txbFilter.Text = "";
                txbFilter.Focus();
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);

        }

        private void tsChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUser.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void tsmShowDetiles_Click(object sender, EventArgs e)
        {int UserID=(int)dgvUser.CurrentRow.Cells[0].Value;
            frmUserInformtion frm = new frmUserInformtion(UserID);
            frm.ShowDialog();
        }

        private void tsAddNewUser_Click(object sender, EventArgs e)
        {
           frmAddUpdateUser frm=new frmAddUpdateUser();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUser.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you sure Deleted This UserID [ "+ (int)dgvUser.CurrentRow.Cells[0].Value+" ] ?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                if (clsUser.DeleteUser((int)dgvUser.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person deleted successfully.");

                    frmManageUsers_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Person deleted not successfully.");
                }
            }
        }

        private void tsmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email really!");
        }

        private void tsmPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone really!");
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmUserInformtion((int)dgvUser.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void cobIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cobIsActive.Text;

            switch(FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;

            }

            if(FilterValue=="All")
            {
                _Userall.DefaultView.RowFilter = "";
            }
            else
                _Userall.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue.Trim());

            labRecodUser.Text = dgvUser.Rows.Count.ToString();
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cobFilterUser.Text == "Person ID"|| cobFilterUser.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
