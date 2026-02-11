using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;
using static Bissens_layer.clsApplication;

namespace Bissens_layer
{
    public class clsAppointemntsTests
    {
        enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode = Mode.AddNew;

     public int TestAppointmentID { get; set; }
          public clsTestType.enTestType TestTypeID { get; set; }
          public  int LocalDrivingLicenseApplicationID { get; set; }
          public  DateTime AppointmentDate { get; set; }
           public float PaidFees { get; set; }
         public int CreatedByUserID { get; set; }
        public int RetakeTestApplicationID { get; set; }
             public clsApplication RetakeTestAppInfo { get; set; }
      public  bool IsLocked { get; set; }
        public int TestID
        {
            get
            {
                return _GetTestID();
            }
        }


        public clsAppointemntsTests()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestType.enTestType.VisionTest;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            _mode = Mode.AddNew;
        }

        public clsAppointemntsTests(int testAppointmentID, clsTestType.enTestType testTypeID, int localDrivingLicenseApplicationID, 
            DateTime appointmentDate, float paidFees, int createdByUserID,bool isLocked,int retakeTestApplicationID)
        {
           
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            RetakeTestApplicationID= retakeTestApplicationID;
            IsLocked = isLocked;
            RetakeTestAppInfo = clsApplication.FindApplicationByID(RetakeTestApplicationID);
            _mode = Mode.Update;
        }

        public static DataTable GatAllAppointemnt()
        {
            return clsAppointemntsTestsData.GetAllAppointemntTest();
        }

        public static DataTable GetApplicationTestAppointmentPerTestType(int LocalDrivingLAppID, clsTestType.enTestType testTypeID)
        {
            return clsAppointemntsTestsData.GetApplicationTestAppointmentPerTestType(LocalDrivingLAppID, (int)testTypeID);
        }

        public  DataTable GetApplicationTestAppointmentPerTestType(clsTestType.enTestType testTypeID)
        {
            return clsAppointemntsTestsData.GetApplicationTestAppointmentPerTestType(this.LocalDrivingLicenseApplicationID, (int)testTypeID);
        }

        public static clsAppointemntsTests FindBylocalDrivingLicenseAppID(int LocalDrivingLAppID, clsTestType.enTestType testTypeID)
        {
            int testAppointmentID = -1;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
          
            int createdByUserID = -1;
            int RetakeTestApplicationID = -1;

            if (clsAppointemntsTestsData.GetAllAppointemntTestByLocalDrivingAppID(LocalDrivingLAppID,(int) testTypeID, ref testAppointmentID,ref appointmentDate,ref paidFees,ref isLocked,
                ref createdByUserID,ref RetakeTestApplicationID))
            {
                return new clsAppointemntsTests(testAppointmentID, testTypeID, LocalDrivingLAppID, appointmentDate, paidFees,
                createdByUserID, isLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }

            

        }

        public static clsAppointemntsTests Find(int testAppointmentID)
        {
            int LocalDrivingLAppID = -1;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
            int testTypeID = -1;
            int createdByUserID = -1;
            int RetakeTestApplicationID = -1;

            if (clsAppointemntsTestsData.GetAllAppointemntTestByTestAppointmentID(testAppointmentID, ref LocalDrivingLAppID, ref appointmentDate, ref paidFees, ref isLocked,
               ref testTypeID, ref createdByUserID, ref RetakeTestApplicationID))
            {
                return new clsAppointemntsTests(testAppointmentID,(clsTestType.enTestType) testTypeID, LocalDrivingLAppID, appointmentDate, paidFees,
                createdByUserID, isLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }

        }
        public static clsAppointemntsTests FindLastTestAppointmentID(int LocalDrivingLAppID, clsTestType.enTestType testTypeID)
        {
            int testAppointmentID = -1;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
         
            int createdByUserID = -1;
            int RetakeTestApplicationID = -1;

            if (clsAppointemntsTestsData.GetLastApoointmneTest(LocalDrivingLAppID,(int)  testTypeID,ref testAppointmentID, ref appointmentDate, ref paidFees, ref isLocked,
                ref createdByUserID, ref RetakeTestApplicationID))
            {
                return new clsAppointemntsTests(testAppointmentID, (clsTestType.enTestType)testTypeID, LocalDrivingLAppID, appointmentDate, paidFees,
                createdByUserID, isLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }

        }






        private bool _AddNewAppointemntsTest()
        {
            this.TestAppointmentID=clsAppointemntsTestsData.AddNewAppointemntTest((int)this.TestTypeID,this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,this.PaidFees,this.CreatedByUserID,this.IsLocked,this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateAppointmentsTest()
        {
            return clsAppointemntsTestsData.UpdateAppointemntTests(this.TestAppointmentID,(int) this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID);
        }

        public  bool IsLockedActive()
        {
            return clsAppointemntsTestsData.IsLockedActive(this.LocalDrivingLicenseApplicationID);
        }

        public bool Save()
        {

            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewAppointemntsTest())
                    {
                        _mode = Mode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:

                    return _UpdateAppointmentsTest();
            }
            return false;
        }

        private int _GetTestID()
        {
            return clsAppointemntsTestsData.GetTestID(TestAppointmentID);
        }
    }
}
