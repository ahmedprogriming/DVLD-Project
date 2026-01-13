using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.IO;
using Bissens_layer;
using Business_Layer;
using DVLD_Project.Properties;
=======
>>>>>>> 195fc875fb00ab107451adaa6fc58dc626140ada

namespace DVLD_Project
{
    public partial class crlPersonInformation : UserControl
    {
<<<<<<< HEAD
        

       private clsPerson _person;

      private  int _PersonID=-1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersoninfo
        {
            get { return _person; }
        }
=======
>>>>>>> 195fc875fb00ab107451adaa6fc58dc626140ada
        public crlPersonInformation()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
    

        public void LoadPersonInfo(int PersonID)
        {
    
            _person =clsPerson.Find(PersonID);
            if (_person == null)
            {
                MessageBox.Show("No Found This PersonID "+PersonID.ToString(),"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _FillInformtion();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _person = clsPerson.Find(NationalNo);
            if (_person == null)
            {
                MessageBox.Show("No Found This PersonID " + PersonID.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillInformtion();
        }

        private void _FillInformtion()
        {

            
            linlbEditPerson.Enabled = true;
            _PersonID = _person.PersonID;
                lablPersonid.Text= _person.PersonID.ToString();
            lablAddress.Text = _person.Address;
            lablCountry.Text = clsCountry.Find(_person.NationalityCountryID).CountryName;
            lablDate.Text = _person.DateOfBirth.ToShortDateString();
            lablNationalNo.Text = _person.NationalNo;
            lablPhone.Text= _person.Phone;
            lablEmail.Text = _person.Email;
            lablGandor.Text = _person.Gendor == 0 ? "Mail" : "Fmail";
            lablName.Text = _person.FirstName+" "+_person.ThirdName+" "+_person.LastName;
            _LoadPersonImage();
        }

        private void ReastInfoPerson()
        {
            _PersonID = -1;
            lblAddress.Text = "[---]";
            lblCountry.Text = "[---]";
            lblDate.Text = "[---]";
            lblEmail.Text = "[---]";
            lblGandor.Text = "[---]";
            labname.Text = "[---]";
            lblNation.Text = "[---]";
            lblPhone.Text = "[---]";
            picImage.Image = Resources.Male_512;
        }
        private void _LoadPersonImage()
        {
            if (_person.Gendor == 0)
                picImage.Image = Resources.Male_512;
            else
                picImage.Image = Resources.Female_512;

            string Imagepath = _person.ImagePath;
            if(Imagepath!="")
                if(File.Exists(Imagepath))
                   picImage.ImageLocation= Imagepath;
            else
                    MessageBox.Show("No Found This Imagepath= "+Imagepath,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
        private void crlPersonInformition_Load(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
=======
        private void pictureBox8_Click(object sender, EventArgs e)
>>>>>>> 195fc875fb00ab107451adaa6fc58dc626140ada
        {

        }

<<<<<<< HEAD
        private void linlbEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_EditePerson add_EditePerson = new Add_EditePerson(_PersonID);
            add_EditePerson.ShowDialog();

            LoadPersonInfo(_PersonID);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    } }
=======
        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> 195fc875fb00ab107451adaa6fc58dc626140ada
