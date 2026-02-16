using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsInternationalLicense:clsApplication
    {
        enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode = Mode.AddNew;

      public  int InternationalLicenseID { get; set; }

      public int DriverID { get; set; }
      public int IssuedUsingLocalLicenseID { get; set; }
      public DateTime IssueDate { get; set; }
       public DateTime ExpirationDate { get; set; }
      public bool IsActive { get; set; }
  

        public clsDriver DriverInfo { get; set; }

        public clsInternationalLicense()
        {
            this.ApplicationTypeID= (int)clsApplication.enApplicationType.NewInternationalLicense;

            this.IssuedUsingLocalLicenseID = -1;
            this.DriverID = -1;
            this.IssueDate=DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
           
            _mode = Mode.AddNew;
        }
        

        public clsInternationalLicense( int internationalLicenseID, int applicationID, int driverID, int issuedUsingLocalLicenseID
            , DateTime issueDate, DateTime expirationDate, bool isActive,
            int createdByUserID,int applicantPersonID
            ,DateTime ApplicationDate,enApplicationStatue ApplicationStatus
            ,DateTime LastStatusDate,float PaidFees)
        {
            base.ApplicationID = applicationID;
            base.ApplicantPersonID = applicantPersonID;
            base.ApplicationTypeID =(int)clsApplication.enApplicationType.NewInternationalLicense;
            base.ApplicationDate = ApplicationDate;
            base.LastStatusDate = LastStatusDate;
            base.ApplicationStatus=ApplicationStatus;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = createdByUserID;
          
           this.InternationalLicenseID = internationalLicenseID;
            this.DriverID = driverID;
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;
            this.DriverInfo = clsDriver.GetAllDriversByID(driverID);
            _mode = Mode.Update;
        }

        public static DataTable GetAllInternatuionalLicense()
        {
            return clsInternationalLicenseData.GetAllInternationalLicense();
        }

        public static DataTable GetAllIternationalLicenseIDByDriverID(int driverID)
        {
            return clsInternationalLicenseData.GetAllInternationalLicenseByDriverID(driverID);
        }
        private bool _AddNewInternational()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInterationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID
                , this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternational()
        {
            return clsInternationalLicenseData.UpdateInterationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID
                , this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1; int DriverID = -1; int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false; int CreatedByUserID = -1;

            if(clsInternationalLicenseData.GetAllInternationalLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID
                , ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsApplication application =clsApplication.FindApplicationByID(ApplicationID);

                return new clsInternationalLicense(InternationalLicenseID,application.ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate,ExpirationDate, IsActive
                    ,application.CreatedByUserID,application.ApplicantPersonID,application.ApplicationDate,
                    (enApplicationStatue)application.ApplicationStatus,application.LastStatusDate,application.PaidFees);
            }
            else
            {
                return null;    
            }
        }


        public bool Save()
        {
            base._mode = (clsApplication.Mode) _mode;
            if(!base.Save()) 
                return false;  

           
            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewInternational())
                    {
                        _mode = Mode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:

                    return _UpdateInternational();
            }
            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int driverID)
        {
            return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(driverID);
        }
    }
}
