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
        public int LicenseClassID {  get; set; }
        public string LicenseName { get; set; }
        public int MimmAge { get; set; }
        //public string LicenseDescription { get; set; }
        public float ClassFess { get; set; }

        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassFess = 0;
            this.LicenseName = "";
            this.MimmAge = -1;
        }

        public clsLicenseClass(int ID,string Classname,int age,float Fees)
        {
            this.LicenseClassID = ID;
            this.ClassFess = Fees;
            this.LicenseName = Classname;
            this.MimmAge = age;
        }

        public static DataTable GettAllLicenseClass()
        {
            return clsLicenseClassData.GetAllLicenseClass();
        }

        public static clsLicenseClass Find(int ID)
        {
            string Classname = "";
            int age = -1;
            float fess = -1;
            if (clsLicenseClassData.GetLicenseClassByID(ID, ref Classname, ref age, ref fess))
            {
                return new clsLicenseClass(ID, Classname, age, fess);
            }
            else
                return null;
            
        }

        public static clsLicenseClass Find(string ClassName)
        {
            int Id =-1;
            int age = -1;
            float fess = -1;
            if (clsLicenseClassData.GetLicenseClassByClassName(ClassName, ref Id, ref age, ref fess))
            {
                return new clsLicenseClass(Id, ClassName, age, fess);
            }
            else
                return null;

        }
    }
}
