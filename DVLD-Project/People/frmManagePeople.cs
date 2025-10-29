using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DVLD_Project
{
    public partial class frmManagePeople : Form
    {
       private static DataTable _dtAllPeople = clsPerson.GetAllPerson();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false,
    "PersonID", "NationalNo", "FirstName", "LastName", "SecondName",
    "ThirdName", "Email", "Phone", "DateOfBirth", "Gendor",
     "CountryName");

        public frmManagePeople()
        {
            InitializeComponent();
        }
        private void txbFilter_TextChanged(object sender, EventArgs e)
        {
            string FlitringTxt = "";
            switch(cobFilter.Text)
            {
                case "PersonID":
                    FlitringTxt = "PersonID";
                    break;
                case "National No":
                    FlitringTxt = "NationalNo";
                    break;
                case "FirstName":
                    FlitringTxt = "FirstName";
                    break;
                case "scoendName":
                    FlitringTxt = "scoendName";
                    break;
                case "Thirdname":
                    FlitringTxt = "Thirdname";
                    break;
                case "LastName":
                    FlitringTxt = "LastName";
                    break;
                case "Gendor":
                    FlitringTxt = "Gendor";
                    break;
                default:
                    FlitringTxt = "None";
                    break;
            }

            if (txbFilter.Text == "" || FlitringTxt == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";

                labRecod.Text = dataGridView1.Rows.Count.ToString();
                return ;
            }

            if (FlitringTxt == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FlitringTxt, txbFilter.Text.Trim());

            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FlitringTxt, txbFilter.Text.Trim());

        }

        private void _RefreshAllpeople()
        {
            _dtAllPeople = clsPerson.GetAllPerson();

            _dtPeople = _dtAllPeople.DefaultView.ToTable(false,
      "PersonID", "NationalNo", "FirstName", "LastName", "SecondName",
      "ThirdName", "Email", "Phone", "DateOfBirth", "Gendor"
     , "CountryName");


            dataGridView1.DataSource = _dtPeople;
            cobFilter.SelectedIndex = 0;
            labRecod.Text=dataGridView1.Rows.Count.ToString() ;
        
        }


        private void ManagePeople_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _dtPeople;
            cobFilter.SelectedIndex = 0;
            labRecod.Text = dataGridView1.Rows.Count.ToString();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Person ID";
                dataGridView1.Columns[0].Width = 110;

                dataGridView1.Columns[1].HeaderText = "National No";
                dataGridView1.Columns[1].Width = 120;

                dataGridView1.Columns[2].HeaderText = "First Name";
                dataGridView1.Columns[2].Width = 120;

                dataGridView1.Columns[3].HeaderText = "Second Name";
                dataGridView1.Columns[3].Width = 120;

                dataGridView1.Columns[4].HeaderText = "Third Name";
                dataGridView1.Columns[4].Width = 120;

                dataGridView1.Columns[5].HeaderText = "Last Name";
                dataGridView1.Columns[5].Width = 120;

                dataGridView1.Columns[6].HeaderText = "Email";
                dataGridView1.Columns[6].Width = 170;

                dataGridView1.Columns[7].HeaderText = "Phone";
                dataGridView1.Columns[7].Width = 120;

                dataGridView1.Columns[8].HeaderText = "Date Of Birth";
                dataGridView1.Columns[8].Width = 140;

                dataGridView1.Columns[9].HeaderText = "Gendor";
                dataGridView1.Columns[9].Width = 120;


                dataGridView1.Columns[10].HeaderText = "CountryName";
                dataGridView1.Columns[10].Width = 120;

            }
        }

        private void cobFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Visible = (cobFilter.Text != "None");

            if(txbFilter.Visible)
            {
                txbFilter.Text = "";
                txbFilter.Focus();
            }
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cobFilter.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pbxclose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Add_EditePerson addNewperson = new Add_EditePerson();
            addNewperson.ShowDialog();
            _RefreshAllpeople();
        }
      


        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int PersonID=(int)dataGridView1.CurrentRow.Cells[0].Value;
            Person_Details PersoShow=new Person_Details(PersonID);
            PersoShow.ShowDialog();
        }

   

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EditePerson add =new Add_EditePerson();
            add.ShowDialog();
            _RefreshAllpeople();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_EditePerson editPerson = new Add_EditePerson((int)dataGridView1.CurrentRow.Cells[0].Value);
                editPerson.ShowDialog();
            _RefreshAllpeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you sure Delete this PersonID[" +dataGridView1.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
               
                    if(clsPerson.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("Person deleted successfully.");

                      _RefreshAllpeople();
                    }
                   else
                   {
                        MessageBox.Show("Person deleted not successfully.");
                   }


            }
         

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email really!");
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone really!");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new Person_Details((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
