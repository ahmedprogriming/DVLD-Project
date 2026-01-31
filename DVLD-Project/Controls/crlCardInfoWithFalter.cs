using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD_Project
{
    public partial class crlCardInfoWithFalter : UserControl
    {
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handelr = OnPersonSelected;
            if(handelr != null)
            {
                handelr(PersonID);
            }

        }

        private bool _ShowAddPerson = true;

        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set { _ShowAddPerson = value; 
            btnAddNew.Visible=_ShowAddPerson;
            }

        }

        private bool _FiltrEnbled = true;

        public bool FiltrEnbled
        {
            get { return _FiltrEnbled; }

            set
            {
                _FiltrEnbled = value;
                gbFilter.Enabled = _FiltrEnbled;
            }
        }
        public crlCardInfoWithFalter()
        {
            InitializeComponent();
        }

        private int _PersonID = -1;

        public int PersonID
        {
            get { return clrInformtionPople1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return clrInformtionPople1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Text=PersonID.ToString();
            FindNow();
        }

      
        private void FindNow()
        {
            switch(cbFilter.Text)
            {
                case "Person ID":
                    clrInformtionPople1.LoadPersonInfo(int.Parse(txtFilter.Text));
                    break;
                case "National No":
                    clrInformtionPople1.LoadPersonInfo(txtFilter.Text);
                    break;

                    default: 
                    
                    break;

            }

            if (OnPersonSelected != null && FiltrEnbled)
                OnPersonSelected(clrInformtionPople1.PersonID);
        }
        private void crlCardInfoWithFalter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Focus();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fildes not valdat!");
                return;
            }

            FindNow();
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter, "This filed is requred!");
            }
           else
            {
                errorProvider1.SetError(txtFilter, null);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditePerson frm1= new frmAddEditePerson();
            frm1.DataBack += DataBackevent;
            frm1.ShowDialog();
        }

        private void DataBackevent(object sender, int PersonID)
        {
            cbFilter.SelectedIndex = 1;
            txtFilter.Text=PersonID.ToString();
            clrInformtionPople1.LoadPersonInfo(PersonID);
        }

        public void FilterFocus()
        {
            txtFilter.Focus();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                btnFind.PerformClick();
            }
            if(txtFilter.Text=="Person ID")
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }
    }
}
