using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Bissens_layer;
using Business_Layer;


namespace DVLD_Project
{
    public partial class crlCardPerson : UserControl
    {
        public crlCardPerson()
        {
            InitializeComponent();
        }
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");
        string imagePath = null;
        private clsPerson FillDataPerson()
        {
            clsPerson Person = new clsPerson();

            Person.FirstName = txtFirstName.Text;
            Person.LastName = txtLastname.Text;
            Person.ThirdName = txtThiedname.Text;
            Person.SecondName = txtSecondName.Text;
            Person.Address = txtAddress.Text;
            Person.Email = txtEmail.Text;
            Person.Phone = txtPhone.Text;
            Person.DateOfBirth = dateTimePicker1.Value;
            Person.NationalNo = txtNational.Text;
            Person.NationalityCountryID = clsCountry.Find(cobCountry.Text).ID;

            if (rdMail.Checked)
                Person.Gendor = 0;
            else
                Person.Gendor = 1;

            if (picImage.ImageLocation != null)
                Person.ImagePath = picImage.ImageLocation.ToString();
            else
                Person.ImagePath = " ";

            linlbRemove.Visible = (Person.ImagePath != "");

            return Person;
        }

        private void _FillCountriesInComBox()
        {
            DataTable dt = clsCountry.AllCountrys();

            foreach (DataRow dr in dt.Rows)
            {
                cobCountry.Items.Add(dr["CountryName"]);
            }
        }

        bool IsValidtEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private void label3_Click(object sender, EventArgs e)
        {




        }

        private void linlbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string selectedFilePath = openFileDialog1.FileName;


                picImage.Load(selectedFilePath);

                string fileName = Path.GetFileName(openFileDialog1.FileName);
                string destPath = Path.Combine(imagesFolder, fileName);


                File.Copy(openFileDialog1.FileName, destPath, true);

                imagePath = destPath;

                picImage.Image = Image.FromFile(destPath);

            }
        }



        private void linlbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                if (picImage.Image != null)
                {
                    picImage.Image.Dispose();
                    picImage.Image = null;
                }

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    File.Delete(imagePath);
        }


                picImage.Image = Properties.Resources.Male_512;
                picImage.ImageLocation = null;

                linlbRemove.Visible = false;
                imagePath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPerson clsPerson = FillDataPerson();


            if (clsPerson.Save())
            {
                MessageBox.Show("Successfully Save ", "True", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Not Save", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.FindForm()?.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email is required!");
            }
            else if (!IsValidtEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Invalid email format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

        }

       

        

        private void txtNational_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNational.Text))
        {
                errorProvider1.SetError(txtNational, "NationalNo is required!");
                return;
            }

            clsPerson person = clsPerson.Find(txtNational.Text);

            if (person != null)
            {
                errorProvider1.SetError(txtNational, "NationalNo already exists!");
                //e.Cancel = true;
        }
            else
            {
                errorProvider1.SetError(txtNational, "");
            }
        }

        private void rdMail_CheckedChanged(object sender, EventArgs e)
        {
            if(rdMail.Checked )

                picImage.Image = Properties.Resources.Male_512;
        
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFemale.Checked)
            
                picImage.Image = Properties.Resources.Female_512;
            
        }

        private void crlCardPerson_Load(object sender, EventArgs e)
        {
            rdMail.Checked = true;
            _FillCountriesInComBox();
        }
        int PersonID;
       public void LoadInformtion(int ID)
        {
            PersonID = ID;
            _EditInfoPerson();
        }

        private void _EditInfoPerson()
        {
            clsPerson Person=clsPerson.Find(PersonID);
            if (Person != null)
            {
                txtFirstName.Text = Person.FirstName;
                txtLastname.Text = Person.LastName;
                txtThiedname.Text = Person.ThirdName;
                txtSecondName.Text = Person.SecondName;
                txtAddress.Text = Person.Address;
                txtEmail.Text = Person.Email;
                txtPhone.Text = Person.Phone;
                dateTimePicker1.Value = Person.DateOfBirth;
                txtNational.Text = Person.NationalNo;
                //cobCountry.SelectedIndex= cobCountry.FindString(_;

                rdMail.Checked = (Person.Gendor == 0);
                rdFemale.Checked = (Person.Gendor == 1);
                picImage.ImageLocation = Person.ImagePath;
            }
            else
            {
                MessageBox.Show("Erro","Select Row",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
