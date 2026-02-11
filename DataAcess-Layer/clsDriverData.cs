using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAcess_Layer
{
    public class clsDriverData
    {
        public static DataTable GetAllDriver()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "select * from Drivers_View";

            SqlCommand command = new SqlCommand(qury, connection);

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
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public static bool GetAllDriveByID(int DriverID,ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From Drivers  Where DriverID=@DriverID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

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

        public static bool GetAllDriveByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From Drivers  Where PersonID=@PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    DriverID = (int)reader["DriverID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

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
        public static int AddNewDriver(int PersonID,int CreatedByUserID,DateTime CreatedDate)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"INSERT INTO Drivers ( 
                            PersonID,CreatedByUserID,CreatedDate)
                             VALUES (@PersonID,@CreatedByUserID,@CreatedDate);
                             SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
         
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    DriverID = autoID;
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
            return DriverID;
        }

        public static bool UpdateDriver(int DriverID,int PersonID, int CreatedByUserID)
        {
            int Rowafcted = 0;


            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"UPDATE Drivers 
Set 
PersonID=@PersonID,CreatedByUserID=@CreatedByUserID
 WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
       

            try
            {
                connection.Open();

                Rowafcted = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return (Rowafcted > 0);

        }
    }
}
