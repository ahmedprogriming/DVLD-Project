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
    public class clsInternationalLicenseData
    {
        public static DataTable GetAllInternationalLicense()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select InternationalLicenseID,ApplicationID
,DriverID,IssuedUsingLocalLicenseID,IssueDate
,ExpirationDate,IsActive from InternationalLicenses order by IsActive ,ExpirationDate desc";


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

     

        public static DataTable GetAllInternationalLicenseByDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select InternationalLicenseID,ApplicationID
,DriverID,IssuedUsingLocalLicenseID,IssueDate
,ExpirationDate,IsActive from InternationalLicenses Where DriverID=@DriverID order by ExpirationDate desc";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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
        public static bool GetAllInternationalLicenseByID(int InternationalLicenseID,ref int ApplicationID,ref int DriverID
            ,ref int IssuedUsingLocalLicenseID,ref DateTime IssueDate,ref DateTime ExpirationDate,ref bool IsActive,ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "select * from InternationalLicenses  Where InternationalLicenseID=@InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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


        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
           
            string query = @"
                select Top 1 InternationalLicenseID
from InternationalLicenses where DriverID=@DriverID
and GETDATE() between IssueDate and ExpirationDate
Order By ExpirationDate desc";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
        
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    InternationalLicenseID = autoID;
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
            return InternationalLicenseID;

        }

        public static int AddNewInterationalLicense(  int ApplicationID,  int DriverID
            ,  int IssuedUsingLocalLicenseID,  DateTime IssueDate,  DateTime ExpirationDate,  bool IsActive,  int CreatedByUserID)
        {
            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            //جعل الرخص السابقة غير نشطة لهذا السائق اذا وجدت معه
            string query = @"
                 Update InternationalLicenses 
                               set IsActive=0
                               where DriverID=@DriverID;

                             INSERT INTO InternationalLicenses
                               (
                                ApplicationID,
                                DriverID,
                                IssuedUsingLocalLicenseID,
                                IssueDate,
                                ExpirationDate,
                                IsActive,
                                CreatedByUserID)
                         VALUES
                               (@ApplicationID,
                                @DriverID,
                                @IssuedUsingLocalLicenseID,
                                @IssueDate,
                                @ExpirationDate,
                                @IsActive,
                                @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    InternationalLicenseID = autoID;
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
            return InternationalLicenseID;
        }

        public static bool UpdateInterationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID
            , int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"


UPDATE InternationalLicenses
   SET ApplicationID = @ApplicationID
      ,DriverID = @DriverID
      ,IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID
      ,IssueDate=@IssueDate
      ,ExpirationDate=@ExpirationDate
      ,IsActive=@IsActive
      ,CreatedByUserID=@CreatedByUserID
 WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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
    }
}
