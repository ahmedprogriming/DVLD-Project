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
using DVLD_Project.Properties;
using System.IO;


namespace DVLD_Project
{
    public partial class frmAddEditePerson : Form
    {
        public delegate void DataBackEventHandelr(object sender, int PersonID);

        public DataBackEventHandelr DataBack;
        enum enMode { Addnew = 0, Updata = 1 };

        private int _PersonID=-1;
        enMode Mode;

        clsPerson _Person;
        public frmAddEditePerson()
        {
            InitializeComponent();
            Mode = enMode.Addnew;
          
        }

        public frmAddEditePerson(int PersonID)
        {
            InitializeComponent();
            Mode = enMode.Updata;
            _PersonID = PersonID;
        }
        private void _FillCountriesInComBox()
        {
            DataTable dt = clsCountry.AllCountrys();

            foreach (DataRow dr in dt.Rows)
            {
                cobCountry.Items.Add(dr["CountryName"]);
            }
        }
        private void _ReasultDefult()
        {
            _FillCountriesInComBox();
            if (Mode == enMode.Addnew)
            {
                lblTitel.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitel.Text = "Update Person";
            }

            if (rdFemale.Checked)
                picImage.Image = Resources.Male_512;
            else
                picImage.Image = Resources.Female_512;

            linlbRemove.Visible = (picImage.ImageLocation != null);
            //Small Age in Syste

            dateTime.MaxDate = DateTime.Now.AddYears(-18);
            dateTime.Value = dateTime.MaxDate;

            dateTime.MinDate = DateTime.Now.AddYears(-100);
            //Defult Country
            cobCountry.SelectedIndex = cobCountry.FindString("Yemen");

            txtFirstName.Text = "";
            txtLastname.Text = "";
            txtThiedname.Text = "";
            txtSecondName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            rdMail.Checked = true;
            txtNational.Text = "";


        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtLastname.Text = _Person.LastName;
            txtThiedname.Text = _Person.ThirdName;
            txtSecondName.Text = _Person.SecondName;
            txtAddress.Text = _Person.Address;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            dateTime.Value = _Person.DateOfBirth;
            txtNational.Text = _Person.NationalNo;
            cobCountry.SelectedIndex = cobCountry.FindString(_Person.CountryInfo.CountryName);

            if (_Person.Gendor == 0)
                rdMail.Checked = true;
            else
                rdFemale.Checked = true;

            if (_Person.ImagePath != "")
            {
                picImage.ImageLocation = _Person.ImagePath;
            }

            linlbRemove.Visible = (_Person.ImagePath != "");
        }
        private void Add_EditePerson_Load(object sender, EventArgs e)
        {
            _ReasultDefult();
            if (Mode == enMode.Updata)
            
                _LoadData();
            
        }

        private bool _HandelPersonImage()
        {
            if (_Person.ImagePath != picImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);

                    }
                    catch
                    {

                    }
                }
            }

            if (picImage.ImageLocation != null)
            {
                string SourceImageFile = picImage.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                {
                    picImage.ImageLocation = SourceImageFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are not valide, put the mous over the read icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandelPersonImage())
                return;
            int NationalityCountryID= clsCountry.Find(cobCountry.Text).ID;
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastname.Text.Trim();
            _Person.ThirdName = txtThiedname.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.NationalNo = txtNational.Text.Trim();
            _Person.DateOfBirth=dateTime.Value;
        

            if (rdMail.Checked)
                _Person.Gendor = 0;
            else
                _Person.Gendor = 1;

            _Person.NationalityCountryID = NationalityCountryID;
            if (picImage.ImageLocation != null)
                _Person.ImagePath = picImage.ImageLocation;
            else
                _Person.ImagePath = " ";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                Mode = enMode.Updata;
                lblTitel.Text = "Update Person";

                MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //delget
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
            {
                MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;
            if (!clsValiadion.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");

            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }

        }

        private void txtNational_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNational.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNational, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtNational, null);
            }

            if (txtNational.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExsires(txtNational.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNational, "National Number is used for another person!");
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(txtNational, null);
            }

        }



        private void rdMail_Click(object sender, EventArgs e)
        {
            if (picImage.ImageLocation == null)

                picImage.Image = Resources.Male_512;
        }

        private void rdFemale_Click(object sender, EventArgs e)
        {
            if (picImage.ImageLocation == null)

                picImage.Image = Resources.Female_512;
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
                linlbRemove.Visible = true;
            }
        }

        private void linlbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picImage.ImageLocation = null;

            if (rdMail.Checked)
                picImage.Image = Resources.Male_512;
            else
                picImage.Image = Resources.Female_512;

            linlbRemove.Visible = true;
        }

        private void cobCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

       
