using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAcess_Layer
{
    public class clsAppointemntsTestsData
    {
        public static DataTable GetAllAppointemntTestByID(int LocalDrivingLicenseAppID)
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments
where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseAppID);
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

        public static bool GetAllAppointment(int LocalDrivingLicenseAppID,ref int TestAppointmentID,ref DateTime AppointmentDate,
            ref float PaidFees,ref bool IsLocked ,ref int TestTypeID, ref int CreatedByUserID,ref int RetakeTestApplicationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"select * from TestAppointments
where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseAppID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees =Convert.ToSingle( reader["PaidFees"]);
                    IsLocked = (bool)reader["IsLocked"];
                    TestTypeID = (int)reader["TestTypeID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    }else
                    {
                        RetakeTestApplicationID = 0;
                    }

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

        public static bool IsLockedActive(int LocalDrivingLicenseAppID)
        {
            bool IsFound=false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"select Found=1 from TestAppointments
where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and IsLocked=1";

            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseAppID);

            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null && bool.TryParse(reader.ToString(), out bool returnResult))
                {
                    IsFound = returnResult;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return IsFound;

        }

        public static int AddNewAppointemntTest(int TestTypeID,int LocalDrivingLicenseApplicationID,DateTime AppointmentDate,
            float PaidFees,int CreatedByUserID, bool IsLocked,int RetakeTestApplicationID)
        {
            int AppointemntTestID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"INSERT INTO TestAppointments ( 
                            TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked)
                             VALUES (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserI,@IsLocked);
                             SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID != null && RetakeTestApplicationID != 0)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int autoID))
                    {
                        AppointemntTestID = autoID;
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
            return AppointemntTestID;
        }
         
        public static bool UpdateAppointemntTests(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
            float PaidFees, int CreatedByUserID, bool IsLocked,int RetakeTestApplicationID)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"
UPDATE TestAppointments
   SET TestTypeID = @TestTypeID
      ,LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
      'AppointmentDate=@AppointmentDate
     ,PaidFees=@PaidFees
     ,CreatedByUserID=@CreatedByUserID
     ,IsLocked=@IsLocked
     ,RetakeTestApplicationID=@RetakeTestApplicationID
 WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);


            try
            {
                connection.Open();
                RowsAfcted = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (RowsAfcted > 0);
        }
    }
}
