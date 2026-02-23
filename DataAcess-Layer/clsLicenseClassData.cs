using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess_Layer
{
    public class clsLicenseClassData
    {
        public static DataTable GetAllLicenseClass()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "select * from LicenseClasses order by ClassName;";

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

        public static bool GetLicenseClassInfoByID(int LicenseClassID,
            ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge,
            ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetLicenseClassByClassName(string ClassName, ref int ID, ref byte minmAge,ref byte DefaultValidityLength, ref float ClassFees,ref string ClassDescription)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From LicenseClasses  Where ClassName=@ClassName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["LicenseClassID"];
                    minmAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);
                    ClassDescription = (string)reader["ClassDescription"];

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

        public static int AddNewLicenseClass(string ClassName, int minmAge, int DefaultValidityLength, float ClassFees,string ClassDescription)
        {
            int LicenseClassID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"INSERT INTO LicenseClasses ( 
                            ClassName,MinimumAllowedAge,ClassFees,DefaultValidityLength,ClassDescription)
                             VALUES (@ClassName,@MinimumAllowedAge,@ClassFees,@DefaultValidityLength,@ClassDescription);
                             SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@MinimumAllowedAge", minmAge);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    LicenseClassID = autoID;
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
            return LicenseClassID;
        }

        public static bool UpdateLicenseClass(int ID,  string ClassName,  int minmAge, int DefaultValidityLength, float ClassFees,string ClassDescription)
        {
            int Rowafcted = 0;


            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"UPDATE LicenseClasses 
Set 
ClassName=@ClassName,MinimumAllowedAge=@MinimumAllowedAge,
ClassFees=@ClassFees,DefaultValidityLength=@DefaultValidityLength,ClassDescription=@ClassDescription WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@MinimumAllowedAge", minmAge);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
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
