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
    public class clsTest
    {
        enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public int TestID { get; set; }
        public int AppointementID { get; set; }
        public bool ResulteTest {  get; set; }
        public clsAppointemntsTests AppointemntsTestsInfo { get; set; }
        public string Notes { get; set; }
       
        public int CreatedUser {  get; set; }

        public clsTest()
        {
            this.CreatedUser = -1;
            this.ResulteTest = false;
            this.Notes = "";
            this.TestID = -1;
            this.AppointementID = -1;
            _mode= Mode.AddNew;
        }

        public clsTest(int testID, int appointementID, bool resulteTest, string notes, int createdUser)
        {
            TestID = testID;
            AppointementID = appointementID;
            ResulteTest = resulteTest;
            Notes = notes;
            _mode = Mode.Update;
            CreatedUser = clsUser.FindByUserID(createdUser).UserID;
            AppointemntsTestsInfo=clsAppointemntsTests.Find(appointementID);
        }

        public static DataTable GetTestAll()
        {
            return clsTestDate.GetTestAll();
        }

        public static clsTest Find(int testID)
        {
            int TestAppointmentID = -1;
            bool ResulteTest = false;

            string Notes = "";

            int CreatedUser = -1;
            if (clsTestDate.GetAllTestByID(testID, ref TestAppointmentID, ref ResulteTest, ref Notes, ref CreatedUser))
            {
                return new clsTest(testID, TestAppointmentID, ResulteTest, Notes, CreatedUser);
            }
            else
                return null;
        }
        public static clsTest FindLastTestPerPersonAndLicenseClass(int person,int LicenseClassID,clsTestType.enTestType testType)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool ResulteTest = false;

         string Notes = "";

            int CreatedUser = -1;
            if (clsTestDate.GetLastTestByPersonAndTestTypeAndLicenseClass(person, LicenseClassID, (int)testType, ref TestID, ref TestAppointmentID, ref ResulteTest, ref Notes, ref CreatedUser))
            {
                return new clsTest(TestID,TestAppointmentID, ResulteTest, Notes, CreatedUser);
            }
            else
                return null;
        }
        private bool _AddNewTest()
        {

            this.TestID = clsTestDate.AddNewTest(this.AppointementID,this.ResulteTest,this.Notes,this.CreatedUser);

            return (TestID != -1);
        }

        public static byte GetPassedTestcount(int LocalID)
        {
            return clsTestDate.GetPassedTestAll(LocalID);
        }
        
        public static byte GetFiledTestCount(int LocalID)
        {
            return clsTestDate.GetFiledAll(LocalID);
        }

        public static bool PassedTestAll(int LocalID)
        {
            return clsTestDate.GetPassedTestAll(LocalID)==3;
        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewTest())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:
                    return false;

            }
            return false;
        }
    }
}
