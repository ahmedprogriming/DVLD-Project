using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using DataAcess_Layer;
using static Bissens_layer.clsTestType;

namespace Bissens_layer
{
    public class clsLocalDrivingLicenseApplications : clsApplication
    {
        enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode = Mode.AddNew;


        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }
     
        public string FullName {

            get
            {
                return base.PersonInfo.FullName;
                //return clsPerson.Find(ApplicantPersonID).FullName;
            }
        }

        public clsLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = 0 - 1;
            this.LicenseClassID = -1;
            _mode = Mode.AddNew;
        }

        public clsLocalDrivingLicenseApplications(int lDLApppID, int ApplicationID, int LicenseClassID, int ApplicantPersonID, DateTime ApplicationDate,
             int ApplicationTypeID, enApplicationStatue ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = lDLApppID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            
            _mode = Mode.Update;
        }

        public static DataTable GetAllLocalDrivingLicenseApplicationsData()
        {
            return clsLocalDrivingLicenseApplicationsData.GetAllLocalDrivingLicenseApplications();
        }

        private bool _AddNewLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsData.AddNewLocalDrivingLicenseApplications(this.ApplicationID, this.LicenseClassID);
            return (LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplicationsData()
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateNewLocalDrivingLicenseApplications(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public static clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplicationsDataByID(int LocalDrivingLicenseApplicationsDataID)
        {
            int ApplactionID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationsData.GetLocalDrivingLincsnseAppByLoacalDrivingID(LocalDrivingLicenseApplicationsDataID, ref ApplactionID, ref LicenseClassID);

            if (IsFound)
            {
                clsApplication application = clsApplication.FindApplicationByID(ApplactionID);

                return new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationsDataID, application.ApplicationID, LicenseClassID,
              application.ApplicantPersonID, application.ApplicationDate, application.ApplicationTypeID, application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.CreatedByUserID);
            }
            else
                return null;

        }

        public static clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplicationsDataByApplactionID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationsDataID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationsData.GetLocalDrivingLincsnseAppByApplicationID(ApplicationID, ref LocalDrivingLicenseApplicationsDataID, ref LicenseClassID);

            if (IsFound)
            {
                clsApplication application = clsApplication.FindApplicationByID(ApplicationID);

                return new clsLocalDrivingLicenseApplications(LocalDrivingLicenseApplicationsDataID, application.ApplicationID, LicenseClassID,
              application.ApplicantPersonID, application.ApplicationDate, application.ApplicationTypeID, application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.CreatedByUserID);
            }
            else
                return null;

        }


        public bool Save()
        {
            base._mode = (clsApplication.Mode) _mode;
            if (!base.Save())
                return false;

            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplications())
                    {
                        _mode = Mode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:

                    return _UpdateLocalDrivingLicenseApplicationsData();
            }
            return false;
        }

        public static bool DosePassedTestType(int ID, clsTestType.enTestType testType)
        {
            return clsLocalDrivingLicenseApplicationsData.DosePassedTestType(ID, (int)testType);
        }
        public bool Deleted()
        {
            bool IsLocalDrivingLicenseApplicationsDeleted = false;
            bool IsbaseplicationDeleted = false;

            IsLocalDrivingLicenseApplicationsDeleted = clsLocalDrivingLicenseApplicationsData.DeleteLocalDrivingLicenseApp(this.LocalDrivingLicenseApplicationID);

            if (!IsLocalDrivingLicenseApplicationsDeleted)
                return false;
            IsbaseplicationDeleted = base.Delete();
            return IsbaseplicationDeleted;
        }

        public bool DosePassedTestType(clsTestType.enTestType testType)
        {
            return clsLocalDrivingLicenseApplicationsData.DosePassedTestType(this.LocalDrivingLicenseApplicationID, (int)testType);
        }

        public bool DoesPassPreviousTest(clsTestType.enTestType CurrentTestType)
        {
            switch (CurrentTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    return true;

                case clsTestType.enTestType.WriteTest:

                    return this.DosePassedTestType(clsTestType.enTestType.VisionTest);

                case clsTestType.enTestType.StreetTest:
                    return this.DosePassedTestType(clsTestType.enTestType.WriteTest);

                default:
                    return false;
            }
        }

        public bool DoesAttendTestType(clsTestType.enTestType attendTestType)
        {
            return clsLocalDrivingLicenseApplicationsData.DoseAttenTestType(this.LocalDrivingLicenseApplicationID, (int)attendTestType);
        }



        public static byte TotalTrialsPerTest(int LocalDrivingLicenseID, clsTestType.enTestType attendTestType)
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(LocalDrivingLicenseID, (int)attendTestType);
        }

        public byte TotalTrialsPerTest(clsTestType.enTestType attendTestType)
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)attendTestType);
        }

        public static bool AttendedTest(int LocalDrivingLicenseID, clsTestType.enTestType attendTestType)
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(LocalDrivingLicenseID, (int)attendTestType) > 0;
        }

        public bool AttendedTest(clsTestType.enTestType attendTestType)
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)attendTestType) > 0;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseID, clsTestType.enTestType attendTestType)
        {
            return clsLocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(LocalDrivingLicenseID, (int)attendTestType);
        }

        public bool IsThereAnActiveScheduledTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public clsTest GetLastTestPerTestType(clsTestType.enTestType attendTestType)
        {
            return clsTest.FindLastTestPerPersonAndLicenseClass(this.ApplicantPersonID,this.LicenseClassID,attendTestType);
        }

        public static byte GetPassedTestcount(int LocalID)
        {
           return clsTestDate.GetPassedTestAll(LocalID);
        }

        public  byte GetPassedTestcount()
        {
            return clsTest.GetPassedTestcount(this.LocalDrivingLicenseApplicationID);
        }

        public static bool PasedAllTest(int LocalID)
        {
           return clsTest.PassedTestAll(LocalID);
        }

        public  bool PasedAllTest()
        {
            return clsTest.PassedTestAll(this.LocalDrivingLicenseApplicationID);
        }

        public int IssueLicenseForTheFirtTime(string Nots,int CurrentUser)
        {
            int DriverID = -1;
            //we check if the driver already there for this person.
            clsDriver Driver = clsDriver.GetAllDriverByPersonID(this.ApplicantPersonID);
            if (Driver == null)
            {
                Driver = new clsDriver();
                Driver.CreatedByUserID = CurrentUser;
                Driver.PersonID = this.ApplicantPersonID;
                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }

            }
            else
            {
                DriverID = Driver.DriverID;
            }

            //now we diver is there, so we add new licesnse
                clsLicense _License = new clsLicense();

            _License.ApplicationID = this.ApplicationID;
            _License.DriverID= DriverID;
            _License.PaidFees = this.LicenseClassInfo.ClassFess;
            _License.LicenseClass = this.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            _License.Notes = Nots;
            _License.IsActive = true;
            _License.IssueReason = clsLicense.enIssueReason.FirstTime;
            _License.CreatedByUserID = CurrentUser;

            if (_License.Save())
            {
                this.SetComblet();
                return _License.LicenseID;
            }
            else
            {
                return -1;
            }
         

        }
        public bool IsLicenseIssue()
        {
            return (GetActiveLicenseID() != -1);
        }
        public int GetActiveLicenseID()
        {
            return clsLicense.GetActiveLicenseIDByPersonID(this.ApplicantPersonID,this.LicenseClassID);
        }

    }
}
