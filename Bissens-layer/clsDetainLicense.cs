using DataAcess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bissens_layer
{
    public class clsDetainLicense
    {
        public enum enMode { AddNew=1,Update=2};
        public enMode Mode=enMode.AddNew;
       public int DetainID { get; set; }
       public   int LicenseID { get; set; }
       public   DateTime DetainDate { get; set; }
       public   float FineFees { get; set; }
       public    int CreatedByUserID { get; set; }

        public clsUser CreatedByUserIDInfo { get; set; }
       public bool IsReleased {  get; set; }
      
      public   DateTime ReleaseDate { get; set; }
      public  int ReleasedByUserID { get; set; }

        public clsUser ReleasedByUserIDInfo { get; set; }
       public    int ReleaseApplicationID { get; set; }

       public clsDetainLicense() 
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.ReleaseDate = DateTime.Now;
            this.ReleaseApplicationID = -1;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleasedByUserID = -1;
            Mode = enMode.AddNew;
        }

        public clsDetainLicense(int detainID, int licenseID, DateTime detainDate, float fineFees, int createdByUserID, bool isReleased
           , DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            this.DetainID= detainID;
            this.LicenseID = licenseID;
            this.DetainDate= detainDate;
            this.FineFees= fineFees;
            this.CreatedByUserID = createdByUserID;
            this.IsReleased = isReleased;
            this.ReleaseDate= releaseDate;
            this.ReleaseApplicationID = releaseApplicationID;
            this.ReleasedByUserID = releasedByUserID;
            this.CreatedByUserIDInfo=clsUser.FindByUserID(this.CreatedByUserID);
            this.ReleasedByUserIDInfo=clsUser.FindByPersonID(this.ReleasedByUserID);
            Mode = enMode.Update;
        }

        public static DataTable GetAllDetainLicense()
        {
            return clsDetainLicenseData.GetAllDetainLicense();
        }

        public static clsDetainLicense Find(int DetainID)
        {
            int licenseID = -1;
           DateTime DetainDate = DateTime.Now;
            float fineFees = -1; int createdByUserID = -1; bool isReleased = false;
            DateTime releaseDate = DateTime.Now; int releasedByUserID = -1; int releaseApplicationID = -1;

            if(clsDetainLicenseData.GetAllDetainLicenseByID(DetainID,ref licenseID,ref DetainDate,ref fineFees,ref createdByUserID,
                ref isReleased,ref releaseDate,ref releasedByUserID,ref releaseApplicationID))
            {
                return new clsDetainLicense(DetainID,licenseID,DetainDate,fineFees,createdByUserID
                    ,isReleased,releaseDate,releasedByUserID,releaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static clsDetainLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            float fineFees = -1; int createdByUserID = -1; bool isReleased = false;
            DateTime releaseDate = DateTime.Now; int releasedByUserID = -1; int releaseApplicationID = -1;

            if (clsDetainLicenseData.GetAllDetainLicenseByLicenseID( LicenseID,ref DetainID, ref DetainDate, ref fineFees, ref createdByUserID,
                ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, fineFees, createdByUserID
                    , isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }
            else
            {
                return null;
            }
        }


        private bool _AddNewDetainLicense()
        {
            this.DetainID = clsDetainLicenseData.AddNewDetainLicense(this.LicenseID, this.DetainDate, this.FineFees
                , this.CreatedByUserID);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainLicense()
        {
            return clsDetainLicenseData.UpdateDetainLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees
                , this.CreatedByUserID);
        }

        public bool Save()
        {
            
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainLicense())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainLicense();
            }
            return false;
        }

        public static bool IsDetainLicense(int LicenseID)
        {
            return clsDetainLicenseData.IsDetainLicense(LicenseID);
        }

        public  bool ReleasedDetainLicense(int releasedByUserID,int releaseApplicationID)
        {
            return clsDetainLicenseData.ReleasedDetainLicense(this.DetainID, releasedByUserID, releaseApplicationID);
        }

    }
}
