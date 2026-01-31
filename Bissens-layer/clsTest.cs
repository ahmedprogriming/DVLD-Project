using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsTest
    {
        public int TestID { get; set; }
        public int AppointementID { get; set; }
        public byte ResulteTest {  get; set; }

        public string Notes { get; set; }
       
        public int CreatedUser {  get; set; }

        public clsTest()
        {
            this.CreatedUser = -1;
            this.ResulteTest = 0;
            this.Notes = "";
            this.TestID = -1;
            this.AppointementID = -1;
        }

        public clsTest(int testID, int appointementID, byte resulteTest, string notes, int createdUser)
        {
            TestID = testID;
            AppointementID = appointementID;
            ResulteTest = resulteTest;
            Notes = notes;
            
            CreatedUser = clsUser.FindByUserID(createdUser).UserID;
        }

        public static DataTable GetTestAll()
        {
            return clsTestDate.GetTestAll();
        }

        public static byte GetPassedTestcount(int LocalID)
        {
            return clsTestDate.GetPassedTestAll(LocalID);
        }

        public static bool PassedTestAll(int LocalID)
        {
            return clsTestDate.GetPassedTestAll(LocalID)==3;
        }
    }
}
