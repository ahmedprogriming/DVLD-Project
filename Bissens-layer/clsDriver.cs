using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsDriver
    {
        public enum Mode { AddNew = 0, Update = 1 };
        public Mode _mode = Mode.AddNew;
        public int DriverID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver() 
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
                        _mode = Mode.AddNew;
        }

        public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            PersonInfo=clsPerson.Find(personID);
            _mode = Mode.Update;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDriver();
        }

        private bool _AddnewDriver()
        {
            this.DriverID=clsDriverData.AddNewDriver(this.PersonID,this.CreatedByUserID,this.CreatedDate);

            return (this.DriverID!=-1);
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID);
        }
        public static clsDriver GetAllDriversByID(int driverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverData.GetAllDriveByID(driverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(driverID, PersonID, CreatedByUserID, CreatedDate);
            }else
            {
                return null;
            }
        }

        public static clsDriver GetAllDriverByPersonID(int personID)
        {
            int driverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverData.GetAllDriveByPersonID(personID, ref driverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(driverID, personID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {

            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddnewDriver())
                    {
                        _mode = Mode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:

                    return _UpdateDriver();
            }
            return false;
        }

        public static DataTable GetLicense(int DriverID)
        {
            return clsLicenseData.GetDriverLicense(DriverID);
        }

        public static DataTable GetInternationalLicense(int DriverID)
        {
            return clsInternationalLicenseData.GetAllInternationalLicenseByDriverID(DriverID);
        }
    }
}
