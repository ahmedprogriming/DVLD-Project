using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsLicense 
    {
        enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode = Mode.AddNew;
        public enum enIssueReason { FirstTime=1,Renew=2, DamagedReplacement=3, LostReplacement= 4};
        public int LicenseID {  get; set; }
        public int DriverID { get; set; }
      public int ApplicationID { get; set; }
        public clsDriver DriverInfo { get; set; }
        public int LicenseClass {  get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }
        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public enIssueReason IssueReason {  get; set; }

        public clsDetainLicense DetainedInfo { get; set; }

        public bool IsDetained
        {
            get
            {
              return clsDetainLicense.IsDetainLicense(this.LicenseID);
            }
        }
       public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }

        public clsLicense() 
        {
        this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.IsActive = false;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;
            this.PaidFees = 0;
            _mode = Mode.AddNew;

        }

        public clsLicense(int licenseID, int applicationID, int driverID
            , int licenseClass, DateTime issueDate, DateTime expirationDate
            , string notes, float paidFees, bool isActive, enIssueReason issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            DriverInfo=clsDriver.GetAllDriversByID(this.DriverID);
            LicenseClassInfo=clsLicenseClass.Find(this.LicenseClass);
            DetainedInfo=clsDetainLicense.FindByLicenseID(this.LicenseID);
            _mode = Mode.Update;
        }

        public static DataTable GetAllLicensePerson(int PersonID)
        {
            return clsLicenseData.GetAllLicensePerson(PersonID);
        }

        public static clsLicense GetAllLicenseByID(int LicenseID)
        {
            int ApplicationID = -1;
            
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            bool IsActive = false;
            byte IssueReason =1;
            int CreatedByUserID = -1;
            float PaidFees = 0;

            if(clsLicenseData.GetAllLicenseByID(LicenseID, ref ApplicationID, ref DriverID
                ,ref LicenseClass,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees
                ,ref IsActive,ref IssueReason,ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID
                    , LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees
                    , IsActive,(enIssueReason) IssueReason, CreatedByUserID);
            }
            else
            {
                return null;    
            }

        }
        private bool _AddNewLicense()
        {
            this.LicenseID=clsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass
                ,this.IssueDate,this.ExpirationDate,this.Notes,this.PaidFees
                ,this.IsActive,(int)this.IssueReason,CreatedByUserID);
            return (this.LicenseID!=-1);
        }

        private bool _UpdateLicese()
        {
            return clsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID
                , this.LicenseClass, this.IssueDate, this.ExpirationDate
                , this.Notes, this.PaidFees, this.IsActive, (int)this.IssueReason, CreatedByUserID);
        }
        public static bool IsExstesLicenseByPersonID(int PersonID,int LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        }
        public static int GetActiveLicenseIDByPersonID(int personID,int LicenseClassID)
        {
            return clsLicenseData.GetActiveLicenseIDByPersonID(personID, LicenseClassID);
        }

        public static DataTable GetLicenseDriver(int DriverID)
        {
            return clsLicense.GetLicenseDriver(DriverID);
        }

        public Boolean IsLicenseExpired()
        {
            return (this.ExpirationDate < DateTime.Now);
        }

        public bool DeactivateCurrentLicense()
        {
            return (clsLicenseData.DeactiveLicense(this.LicenseID));
        }

        public static string GetIssueReasonText(enIssueReason issueReason)
        {
            switch (issueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }
        public bool Save()
        {
         
            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewLicense())
                    {
                        _mode = Mode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:

                    return _UpdateLicese();
            }
            return false;
        }

        public clsLicense RenewLicense(string Nots, int CurrentUser)
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID=this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatue.Completed;
            application.ApplicationTypeID =clsApplicatonType.FindAppTypeID((int) clsApplication.enApplicationType.RenewDrivingLicenseService).AppTypeID;
            application.PaidFees = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.RenewDrivingLicenseService).AppTypeFees;
            application.CreatedByUserID = CurrentUser;

            if(!application.Save())
            {
                return null;
            }


                clsLicense _License = new clsLicense();

                _License.ApplicationID = this.ApplicationID;
                _License.DriverID = DriverID;
                _License.PaidFees = this.LicenseClassInfo.ClassFess;
                _License.LicenseClass = this.LicenseClassInfo.LicenseClassID;
                _License.IssueDate = DateTime.Now;

            int DefaultValidityLength = this.LicenseClassInfo.DefaultValidityLength;

                _License.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
                _License.Notes = Nots;
                _License.IsActive = true;
                _License.IssueReason = clsLicense.enIssueReason.Renew;
                _License.CreatedByUserID = CurrentUser;

            if (!_License.Save())
            {
                return null;
            }
             
            DeactivateCurrentLicense();

            return _License;
        }

        public clsLicense ReplaceLicense(enIssueReason IssueReason, int CurrentUser)
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatue.Completed;
            application.ApplicationTypeID = (IssueReason == enIssueReason.DamagedReplacement ?
                (int)clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense
                : (int)clsApplication.enApplicationType.ReplacementforaLostDrivingLicense);
                
            application.PaidFees = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense).AppTypeFees;
            application.CreatedByUserID = CurrentUser;

            if (!application.Save())
            {
                return null;
            }


            clsLicense _License = new clsLicense();

            _License.ApplicationID = this.ApplicationID;
            _License.DriverID = DriverID;
            _License.PaidFees = this.LicenseClassInfo.ClassFess;
            _License.LicenseClass = this.LicenseClassInfo.LicenseClassID;
            _License.IssueDate = DateTime.Now;

            int DefaultValidityLength = this.LicenseClassInfo.DefaultValidityLength;

            _License.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            _License.Notes = this.Notes;
            _License.IsActive = true;
            _License.IssueReason = IssueReason;
            _License.CreatedByUserID = CurrentUser;

            if (!_License.Save())
            {
                return null;
            }

            DeactivateCurrentLicense();

            return _License;
        }

        public int Detain(float FineFess,int CurrentUser)
        {
            clsDetainLicense detainLicense = new clsDetainLicense();

            detainLicense.LicenseID = this.LicenseID;
            detainLicense.DetainDate = DateTime.Now;
            detainLicense.FineFees =Convert.ToSingle( FineFess);
            detainLicense.CreatedByUserID = CurrentUser;

            if (!detainLicense.Save())
            {
             
                return -1;
            }

            return detainLicense.DetainID;
        }

        public bool RelesaedDetainLicense( int ReleaseByUser,ref int AppliactionID)
        {
            clsApplication application = new clsApplication();

            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatue.Completed;
            application.ApplicationTypeID = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).AppTypeID;
            application.PaidFees = clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense).AppTypeFees;
            application.CreatedByUserID = ReleaseByUser;

            if (!application.Save())
            {
                return false;
            }

            AppliactionID = application.ApplicationID;

            return this.DetainedInfo.ReleasedDetainLicense(ReleaseByUser,application.ApplicationID);
        }

    }
}
