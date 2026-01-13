using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAcess_Layer;
using System.Threading.Tasks;

namespace Business_Layer
{
     class clsBusinessLayerPersoncs
    {

       public int PersonID { get; set; }
     public  string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gandor { get; set; }
        public string Address;
        public string ImagePath { get; set; }
        public int NationalityCountryID { get; set; }

        public clsBusinessLayerPersoncs()
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
            this.Gandor = 0;
            this.Address = "";
            this.ImagePath = "";
            this.NationalityCountryID = -1;
        }

        public clsBusinessLayerPersoncs(int personID, string nationalNo,
            string firstName, string lastName, string secondName, 
            string thirdName, string email, string phone, 
            DateTime dateOfBirth, byte gandor, string address, 
            string imagePath, int nationalityCountryID)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.Email = email;
            this.Phone = phone;
            this.DateOfBirth = dateOfBirth;
            this.Gandor = gandor;
            this.Address = address;
            this.ImagePath = imagePath;
            this.NationalityCountryID = nationalityCountryID;
        }

        static public DataTable GetAllPerson()
        {
            return clsPerson.GetAllPerson();
        }

       
    }
}
