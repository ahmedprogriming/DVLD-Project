using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAcess_Layer;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;
using Bissens_layer;

namespace Business_Layer
{
    public class clsPerson
    {
        enum Mode { AddNew = 0, UpdateNew = 1 };
        private Mode _mode;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address;
        public string ImagePath { get; set; }
        public int NationalityCountryID { get; set; }

        public clsCountry CountryInfo;

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.ImagePath = "";
            this.NationalityCountryID = -1;
      

            _mode = Mode.AddNew;
        }

        public clsPerson(int personID, string NationalNo,
            string firstName, string lastName, string secondName,
            string thirdName, string email, string phone,
            DateTime dateOfBirth, byte gendor, string address,
            string imagePath, int nationalityCountryID)
        {
            this.PersonID = personID;
            this.NationalNo = NationalNo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.Email = email;
            this.Phone = phone;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.ImagePath = imagePath;
            this.NationalityCountryID = nationalityCountryID;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            _mode = Mode.UpdateNew;
        }

        static public DataTable GetAllPerson()
        {
            return PersonData.GetAllPerson();
        }

        static public clsPerson Find(int personID)
        {

            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string ImagePath = "";
            int NationalityCountryID = -1;

            if (PersonData.GetPersonByID(personID, ref NationalNo,
          ref FirstName, ref LastName, ref SecondName,
         ref ThirdName, ref Email, ref Phone,
           ref DateOfBirth, ref Gendor, ref Address,
           ref ImagePath, ref NationalityCountryID))
            {
                return new clsPerson(personID, NationalNo,
           FirstName, LastName, SecondName,
          ThirdName, Email, Phone,
            DateOfBirth, Gendor, Address,
            ImagePath, NationalityCountryID);
            }
            else
            {
                return null;
            }

        }

        static public clsPerson Find(string National)
        {

            int ID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string ImagePath = "";
            int NationalityCountryID = -1;

            if (PersonData.GetPersonByNationalNo(National, ref ID,
          ref FirstName, ref LastName, ref SecondName,
         ref ThirdName, ref Email, ref Phone,
           ref DateOfBirth, ref Gendor, ref Address,
           ref ImagePath, ref NationalityCountryID))
            {
                return new clsPerson(ID, National,
           FirstName, LastName, SecondName,
          ThirdName, Email, Phone,
            DateOfBirth, Gendor, Address,
            ImagePath, NationalityCountryID);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewPerson()
        {
            this.PersonID = PersonData.AddNewPerson(this.NationalNo,
           this.FirstName, this.LastName, this.SecondName,
          this.ThirdName, this.Email, this.Phone,
            this.DateOfBirth, this.Gendor, this.Address,
            this.ImagePath, this.NationalityCountryID);

            return (PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return PersonData.UpdatePerson(this.PersonID, this.NationalNo,
           this.FirstName, this.LastName, this.SecondName,
          this.ThirdName, this.Email, this.Phone,
            this.DateOfBirth, this.Gendor, this.Address,
            this.ImagePath, this.NationalityCountryID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewPerson())
                    {
                        _mode = Mode.UpdateNew;
                        return true;
                    } else
                    {
                        return false;
                    }

                case Mode.UpdateNew:
                    return _UpdatePerson();

            }
            return false;
        }

        static public bool DeletePerson(int ID) 
        { 
        
        return PersonData.DeletePerson(ID);
        }

        static public bool isPersonExsires(int ID)
        {
            return PersonData.IsPesonExites(ID);
        }

        static public bool isPersonExsires(string National)
        {
            return PersonData.IsPesonExites(National);
        }
    }
}
