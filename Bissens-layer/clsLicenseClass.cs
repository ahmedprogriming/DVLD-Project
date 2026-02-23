using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LicenseClassID {  get; set; }
        public string LicenseName { get; set; }

        public byte DefaultValidityLength { get; set; }
        public byte MimmAge { get; set; }
        public string LicenseDescription { get; set; }
        public float ClassFess { get; set; }

        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassFess = 0;
            this.LicenseName = "";
            this.LicenseDescription = "";
            this.DefaultValidityLength = 10;
            this.MimmAge = 18;

            Mode = enMode.AddNew;
        }

        public clsLicenseClass(int ID,string Classname, byte age, byte DefaultValidityLength,float Fees,string LicenseDescription)
        {
            this.LicenseClassID = ID;
            this.ClassFess = Fees;
            this.LicenseName = Classname;
            this.DefaultValidityLength = DefaultValidityLength;
            this.LicenseDescription= LicenseDescription;
            this.MimmAge = age;

            Mode = enMode.Update;
        }

        public static DataTable GettAllLicenseClass()
        {
            return clsLicenseClassData.GetAllLicenseClass();
        }

        public static clsLicenseClass Find(int ID)
        {
            string Classname = "";string LicenseDescription = "";
            byte age = 18;
            byte DefaultValidityLength = 10;

            float fess = 0;
            if (clsLicenseClassData.GetLicenseClassInfoByID(ID, ref Classname, ref LicenseDescription, ref age, ref DefaultValidityLength,  ref fess))
            {
                return new clsLicenseClass(ID, Classname, age, DefaultValidityLength, fess, LicenseDescription);
            }
            else
                return null;
            
        }

        public static clsLicenseClass FindByClassName(string ClassName)
        {
            int Id =-1;
            byte age = 18;
            string LicenseDescription = "";
            byte DefaultValidityLength = 10;
            float fess = 0;
            if (clsLicenseClassData.GetLicenseClassByClassName(ClassName, ref Id, ref age,ref DefaultValidityLength, ref fess, ref LicenseDescription))
            {
                return new clsLicenseClass(Id, ClassName, age, DefaultValidityLength, fess, LicenseDescription);
            }
            else
                return null;

        }
    }
}
