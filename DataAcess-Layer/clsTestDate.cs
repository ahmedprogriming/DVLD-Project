using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAcess_Layer
{
    public class clsTestDate
    {
        public static DataTable GetTestAll()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select * from Tests";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static int AddNewTest(int TestAppointmentID,bool TestResult,string Notes,int CreatedByUserID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"
INSERT INTO Tests
           (TestAppointmentID
           ,TestResult,Notes,CreatedByUserID)
     VALUES
           (@TestAppointmentID
           ,@TestResult
            ,@Notes
,@CreatedByUserID)

UPDATE TestAppointments
SET IsLocked=1 Where TestAppointmentID=@TestAppointmentID
 SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if(Notes != null||Notes!="")
            command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    TestID = autoID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return TestID;
        }



        public static byte GetPassedTestAll(int LocalDrivingLicenseAppID)
        {
            byte PassedTestCount = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"select passTest= Count(TestTypeID) from Tests Inner Join  TestAppointments
on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestResult=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseAppID);


            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null && byte.TryParse(reader.ToString(), out byte returnResult))
                {
                    PassedTestCount = returnResult;
                }
            }
            catch (Exception ex)
            {
                PassedTestCount = 0;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return PassedTestCount;

        }

        public static byte GetFiledAll(int LocalDrivingLicenseAppID)
        {
            byte PassedTestCount = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"select filed= Count(TestResult) from Tests Inner Join  TestAppointments
on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestResult=0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseAppID);


            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null && byte.TryParse(reader.ToString(), out byte returnResult))
                {
                    PassedTestCount = returnResult;
                }
            }
            catch (Exception ex)
            {
                PassedTestCount = 0;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return PassedTestCount;

        }

        public static bool GetAllTestByID(int TestID, ref int TestAppointmentID, ref bool ResulteTest, ref string Notes, ref int CreatedUser)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"select * from Tests where TestID=TestID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
         

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                 
                    TestAppointmentID = (int)reader["TestAppointmentID"];

                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = reader["Notes"].ToString();
                    }
                    else
                    {
                        Notes = "";
                    }
                    CreatedUser = (int)reader["CreatedByUserID"];
                    ResulteTest = (bool)reader["TestResult"];


                }
                else
                {
                    IsFound = false;
                }
                reader.Close();


            }
            catch (Exception ex)
            {
            }
            finally
            { connection.Close(); }
            return IsFound;
        }
        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass(int Person, int LicenseClassID, int TestTypeID, ref int TestID
            , ref int TestAppointmentID, ref bool ResulteTest, ref string Notes, ref int CreatedUser)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"select top 1 Tests.TestID,Tests.TestAppointmentID,Tests.Notes,Tests.CreatedByUserID,Tests.TestResult
,Applications.ApplicantPersonID   from LocalDrivingLicenseApplications inner join Tests
inner join TestAppointments on TestAppointments.TestAppointmentID=Tests.TestAppointmentID on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=TestAppointments.LocalDrivingLicenseApplicationID
inner join Applications on Applications.ApplicationID=LocalDrivingLicenseApplications.ApplicationID
where Applications.ApplicantPersonID=@ApplicantPersonID
and LocalDrivingLicenseApplications.LicenseClassID=@LicenseClassID
and TestAppointments.TestTypeID=@TestTypeID
Order By Tests.TestAppointmentID Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", Person);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];

                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = reader["Notes"].ToString();
                    }
                    else
                    {
                        Notes = "";
                    }
                    CreatedUser = (int)reader["CreatedByUserID"];
                    ResulteTest = (bool)reader["TestResult"];
                   

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();


            }
            catch (Exception ex)
            {
            }
            finally
            { connection.Close(); }
            return IsFound;



        }

    }
}
