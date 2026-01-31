using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DataAcess_Layer
{
    public class clsLocalDrivingLicenseApplicationsData
    {
        public static bool GetLocalDrivingLincsnseAppByLoacalDrivingID(int LocalDrivingLicenseApplicationID, ref int ApplicationID,
          ref int LicenseClassID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From LocalDrivingLicenseApplications  Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

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

        public static bool GetLocalDrivingLincsnseAppByApplicationID(int ApplicationID, ref int LocalDrivingLicenseApplicationID,
       ref int LicenseClassID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From LocalDrivingLicenseApplications  Where ApplicationID=@ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

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
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select * from LocalDrivingLicenseApplications_View
                      order by ApplicationDate Desc";


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

        public static int AddNewLocalDrivingLicenseApplications(int AppID, int LicenseclassID)
        {
            int LDLAAppID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications ( 
                            ApplicationID,LicenseClassID)
                             VALUES (@ApplicationID,@LicenseClassID);
                             SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", AppID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseclassID);
          

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    LDLAAppID = autoID;
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
            return LDLAAppID;
        }

        public static bool UpdateNewLocalDrivingLicenseApplications(int LDLApppID, int ApplicationID, int LicenseClassID)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"


UPDATE LocalDrivingLicenseApplications
   SET ApplicationID = @ApplicationID
      ,LicenseClassID = @LicenseClassID
 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLApppID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            

            try
            {
                connection.Open();
               RowsAfcted=command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (RowsAfcted>0);
        }

        public static bool DeleteLocalDrivingLicenseApp(int LDLAppID)
        {
            int rowAfected = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"Delete LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);

            try
            {
                connection.Open();

                rowAfected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }

            return (rowAfected > 0);
        }

      
        public static bool DosePassedTestType(int LocalDrivingLicenseApp,int TestType)
        {
            bool Resulte = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"Select top 1 Tests.TestResult from LocalDrivingLicenseApplications inner join
TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=TestAppointments.LocalDrivingLicenseApplicationID
inner join Tests On TestAppointments.TestAppointmentID=Tests.TestAppointmentID
where 
(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID)
and (TestAppointments.TestTypeID=@TestTypeID) 
Order by TestAppointments.TestAppointmentID Desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApp);
            command.Parameters.AddWithValue("@TestTypeID", TestType);

            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null&& bool.TryParse(reader.ToString(),out bool returnResult))
                {
                    Resulte = returnResult;
                }
            }
            catch (Exception ex)
            {
                Resulte = false;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return Resulte;
        }

       public static bool DoseAttenTestType(int LocalDrivingLicenseApp, int TestType)
        {
            bool Resulte = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"Select top 1 Found=1 from LocalDrivingLicenseApplications inner join
TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=TestAppointments.LocalDrivingLicenseApplicationID
inner join Tests On TestAppointments.TestAppointmentID=Tests.TestAppointmentID
where 
(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID)
and (TestAppointments.TestTypeID=@TestTypeID) 
Order by TestAppointments.TestAppointmentID Desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApp);
            command.Parameters.AddWithValue("@TestTypeID", TestType);

            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null && bool.TryParse(reader.ToString(), out bool returnResult))
                {
                    Resulte = returnResult;
                }
            }
            catch (Exception ex)
            {
                Resulte = false;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return Resulte;
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApp, int TestType)
        {
            byte TotalTrials = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"Select TotalTrials=COUNT(TestID) from LocalDrivingLicenseApplications inner join
TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=TestAppointments.LocalDrivingLicenseApplicationID
inner join Tests On TestAppointments.TestAppointmentID=Tests.TestAppointmentID
where 
(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID)
and (TestAppointments.TestTypeID=@TestTypeID) 
Order by TestAppointments.TestAppointmentID Desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApp);
            command.Parameters.AddWithValue("@TestTypeID", TestType);

            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null && byte.TryParse(reader.ToString(), out byte returnResult))
                {
                    TotalTrials = returnResult;
                }
            }
            catch (Exception ex)
            {
                TotalTrials = 0;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return TotalTrials;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApp, int TestType)
        {
            bool Resulte = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"Select top 1 Found=1 from LocalDrivingLicenseApplications inner join
TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=TestAppointments.LocalDrivingLicenseApplicationID
inner join Tests On TestAppointments.TestAppointmentID=Tests.TestAppointmentID
where 
(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID)
and (TestAppointments.TestTypeID=@TestTypeID ) and IsLocked=0
Order by TestAppointments.TestAppointmentID Desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApp);
            command.Parameters.AddWithValue("@TestTypeID", TestType);

            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null && bool.TryParse(reader.ToString(), out bool returnResult))
                {
                    Resulte = returnResult;
                }
            }
            catch (Exception ex)
            {
                Resulte = false;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return Resulte;
        }

      
    }
}
