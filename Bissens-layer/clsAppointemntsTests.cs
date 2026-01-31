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
          public  int TestTypeID { get; set; }
          public  int LocalDrivingLicenseApplicationID { get; set; }
          public  DateTime AppointmentDate { get; set; }
           public float PaidFees { get; set; }
         public int CreatedByUserID { get; set; }
        public int RetakeTestApplicationID { get; set; }
             public clsTestType TestTypeInfo { get; set; }
      public  bool IsLocked { get; set; }

        public clsAppointemntsTests()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            _mode = Mode.AddNew;
        }

        public clsAppointemntsTests(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, 
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
            TestTypeInfo = clsTestType.FindTestTypeID((clsTestType.enTestType) testTypeID);
            _mode = Mode.Update;
        }

        public static DataTable GatAllAppointemnt(int LocalDrivingLAppID)
        {
            return clsAppointemntsTestsData.GetAllAppointemntTestByID(LocalDrivingLAppID);
        }

        public static clsAppointemntsTests FindByID(int LocalDrivingLAppID)
        {
            int testAppointmentID = -1;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
            int testTypeID = -1;
            int createdByUserID = -1;
            int RetakeTestApplicationID = -1;

            if (clsAppointemntsTestsData.GetAllAppointment(LocalDrivingLAppID,ref testAppointmentID,ref appointmentDate,ref paidFees,ref isLocked,
               ref testTypeID,ref createdByUserID,ref RetakeTestApplicationID))
            {
                return new clsAppointemntsTests(testAppointmentID, testTypeID, LocalDrivingLAppID, appointmentDate, paidFees,
                createdByUserID, isLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }

            

        }

        public  clsAppointemntsTests FindByID()
        {
            int testAppointmentID = -1;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
            int testTypeID = -1;
            int createdByUserID = -1;
            int RetakeTestApplicationID = -1;

            if (clsAppointemntsTestsData.GetAllAppointment(this.LocalDrivingLicenseApplicationID, ref testAppointmentID, ref appointmentDate, ref paidFees, ref isLocked,
               ref testTypeID, ref createdByUserID, ref RetakeTestApplicationID))
            {
                return new clsAppointemntsTests(testAppointmentID, testTypeID,this.LocalDrivingLicenseApplicationID, appointmentDate, paidFees,
                createdByUserID, isLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }



        }

        private bool _AddNewAppointemntsTest()
        {
            this.TestAppointmentID=clsAppointemntsTestsData.AddNewAppointemntTest(this.TestTypeID,this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,this.PaidFees,this.CreatedByUserID,this.IsLocked,this.RetakeTestApplicationID);

            return (this.TestAppointmentID != 0);
        }

        private bool _UpdateAppointmentsTest()
        {
            return clsAppointemntsTestsData.UpdateAppointemntTests(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID,
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
    }
}
