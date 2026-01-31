using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsApplication
    {
        public enum Mode { AddNew = 0, Update = 1 };
        public Mode _mode = Mode.AddNew;
     public   enum enApplicationType { NewLocalDrivinLicenseService = 1, RenewDrivingLicenseService = 2, ReplacementforaLostDrivingLicense = 3,
            ReplacementforaDamagedDrivingLicense = 5, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6,
            RetakeTest = 7
        };

        public enum enApplicationStatue { New = 1, Cancelled = 2, Completed = 3 };

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicatonType ApplicatonTypeInfo { get; set; }
        public enApplicationStatue ApplicationStatus { get; set; }
        public string TextStatus
        {
            get
            {
                switch (ApplicationStatus)
                {


                    case enApplicationStatue.New:
                        return "New";
                    case enApplicationStatue.Cancelled:
                        return "Cancelled";
                    case enApplicationStatue.Completed:
                        return "Completed";
                    default:
                        return "Unknow";


                }
            }
        }

        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID;
        public clsUser UserInfo { get; set; }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = clsApplication.enApplicationStatue.New;
            this.LastStatusDate = DateTime.Now;
            this.CreatedByUserID = -1;
            this.PaidFees = 0;
            _mode = Mode.AddNew;
        }

        public clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
             int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = (clsApplication.enApplicationStatue)ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.UserInfo = clsUser.FindByUserID(CreatedByUserID);
            this.ApplicatonTypeInfo = clsApplicatonType.FindAppTypeID(ApplicationTypeID);
            _mode = Mode.Update;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID != -1);
        }

        private bool _UpdateApllication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                  (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        public static clsApplication FindApplicationByID(int ApplicationID)
        { int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;

            if (clsApplicationData.GetAllAppByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID,
                ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                 ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            return null;
        }

        public bool Cancel()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, 2);
        }

        public bool SetComblet()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, 3);
        }

        public bool Delete()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewApplication())
                    {
                           _mode = Mode.Update;
                        return true;
                     
                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:

                    return _UpdateApllication();
            }
            return false;
        }

        public static bool IsExsitsApplication(int ApplcationID)
        {
            return clsApplicationData.IsExsitsApllication(ApplcationID);
        }

        public static bool DosePersonHaveActivApplication(int PersonID, int ApplicationID)
        {
            return clsApplicationData.DosePersonIsActiveApplicetion(PersonID, ApplicationID);
        }

        public bool DosePersonHaveActivApplication(int ApplicationTypeID)
        {
            return clsApplicationData.DosePersonIsActiveApplicetion(this.ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplication(int PersonID, clsApplication.enApplicationType applicationTypeID)
        {

            return clsApplicationData.GetIsActiveApplicationID(PersonID, (int)applicationTypeID);
        }

     

        public static int GetActiveApplicationByLicenseClassID(int PersonID, clsApplication.enApplicationType applicationTypeID, int LicenseID)
        {
            return clsApplicationData.GetActiveApplicationIDForLiceseID(PersonID, (int)applicationTypeID, LicenseID);
        }

        public int GetActiveApplication(clsApplication.enApplicationType applicationTypeID)
        {

            return GetActiveApplication(this.ApplicantPersonID, applicationTypeID);
        }


    }

}
