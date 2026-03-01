using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAcess_Layer
{
    public class clsDetainLicenseData
    {
        public static DataTable GetAllDetainLicense()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select * from DetainedLicenses_View order by IsReleased,DetainID";


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

        public static bool GetAllDetainLicenseByID(int DetainID,ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased
          , ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * from DetainedLicenses Where DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees =Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                  
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    else
                    {
                        ReleaseDate = DateTime.MaxValue;
                    }
                    if (reader["ReleasedByUserID"]!=DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    else
                    {
                        ReleasedByUserID = -1;
                    }
                    if(reader["ReleaseApplicationID"]!= DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    else
                    {
                        ReleaseApplicationID= -1;
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

        public static bool GetAllDetainLicenseByLicenseID(int LicenseID,ref int DetainID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased
         , ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select top 1 * from DetainedLicenses Where LicenseID=@LicenseID order by DetainID desc;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    else
                    {
                        ReleaseDate = DateTime.MaxValue;
                    }
                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    else
                    {
                        ReleasedByUserID = -1;
                    }
                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    else
                    {
                        ReleaseApplicationID = -1;
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
        public static int AddNewDetainLicense(int LicenseID,DateTime DetainDate,float FineFees,int CreatedByUserID)
        {
            int DetainID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
          
            string query = @"   INSERT INTO DetainedLicenses
                               (
                                LicenseID,
                                DetainDate,
                                FineFees,
                                CreatedByUserID,
                                IsReleased)
                         VALUES
                               (@LicenseID,
                                @DetainDate,
                                @FineFees,
                                @CreatedByUserID,
                                0);
                            SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
        
            

            try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int autoID))
                    {
                        DetainID = autoID;
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
            return DetainID;

        }

        public static bool UpdateDetainLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"


UPDATE DetainedLicenses
   SET LicenseID = @LicenseID
      ,DetainDate = @DetainDate
      ,FineFees=@FineFees
      ,CreatedByUserID=@CreatedByUserID
     
 WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
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

        public static bool ReleasedDetainLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"


UPDATE DetainedLicenses
   SET IsReleased = 1
      ,ReleasedByUserID = @ReleasedByUserID
      ,ReleaseApplicationID=@ReleaseApplicationID
      ,ReleaseDate=@ReleaseDate
     
 WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);

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

        public static bool IsDetainLicense(int LicenseID)
        {
            bool IsDetain = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"Select IsDetain= 1 from DetainedLicenses Where LicenseID=@LicenseID 
                   and IsReleased=0  ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result!=null)
                {
                    IsDetain = Convert.ToBoolean(result);
                  

                }
                else
                {
                    IsDetain = false;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            { connection.Close(); }
            return IsDetain;
        }

    }
}
