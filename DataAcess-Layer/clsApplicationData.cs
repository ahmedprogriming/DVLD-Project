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
    public class clsApplicationData
    {
        public static bool GetAllAppByID(int appId,ref int ApplicantPersonID,ref DateTime ApplicationDate,
            ref int ApplicationTypeID,ref byte ApplicationStatus,ref DateTime LastStatusDate,ref float PaidFees,ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From Applications  Where ApplicationID=@ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", appId);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees =Convert.ToSingle( reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static DataTable GetAllApp()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select * from Applications";


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

        public static int AddNewApplication(int ApplicantPersonID,  DateTime ApplicationDate,
             int ApplicationTypeID,  byte ApplicationStatus,  DateTime LastStatusDate,  float PaidFees,  int CreatedByUserID)
        {
            int AppID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                      @ApplicationStatus,@LastStatusDate,
                                      @PaidFees,   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    AppID = autoID;
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
            return AppID;


        }

        public static bool UpdateApplication(int ApplicationID,int ApplicantPersonID, DateTime ApplicationDate,
             int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"
UPDATE Applications
   SET ApplicantPersonID = @ApplicantPersonID
      ,ApplicationDate = @ApplicationDate
      ,ApplicationTypeID = @ApplicationTypeID
      ,ApplicationStatus = @ApplicationStatus
      ,LastStatusDate = @LastStatusDate
      ,PaidFees = @PaidFees
      ,CreatedByUserID= @CreatedByUserID
 WHERE ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


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

        public static bool DeleteApplication(int ApplicationID)
        {
            int rowAfected = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"Delete Applications where ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool IsExsitsApllication(int ApplicationID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select Found=1 from Applications where ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return IsFound;
        }

        public static bool DosePersonIsActiveApplicetion(int PersonID, int ApplicationTypeID)
        {
            
                return (GetIsActiveApplicationID(PersonID, ApplicationTypeID) != -1);
            
        }
        
        public static int GetIsActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            int AppID = -1;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "select found = 1 from Applications where ApplicantPersonID =@ApplicantPersonID And ApplicationTypeID = @ApplicationTypeID And ApplicationStatus = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    AppID = autoID;
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
            return AppID;
        }

        public static int GetActiveApplicationIDForLiceseID(int PersonID,int ApplicationType,int LicenseID)
        {
            int ActiveLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"Select ActiveApplicationLicenseID=Applications.ApplicantPersonID from Applications inner Join
LocalDrivingLicenseApplications on Applications.ApplicationID=LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
where ApplicationTypeID=@ApplicationTypeID
and ApplicantPersonID=@ApplicantPersonID
and LocalDrivingLicenseApplications.LicenseClassID=@LicenseClassID
and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationType);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseID);
            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    ActiveLicenseID = autoID;
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
            return ActiveLicenseID;
        }

        public static bool UpdateStatus(int ApplicationID,short NewStatus)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"
UPDATE Applications
   SET 
      ApplicationStatus = @ApplicationStatus
      ,LastStatusDate = @LastStatusDate
     
 WHERE ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", NewStatus);
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
           


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
