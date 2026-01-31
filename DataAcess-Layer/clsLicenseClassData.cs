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

        public static bool GetLicenseClassByID(int ID, ref string ClassName,ref int minmAge,ref float ClassFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From LicenseClasses  Where LicenseClassID=@LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ClassName = (String)reader["ClassName"];
                    minmAge = (int)reader["MinimumAllowedAge"];
                    ClassFees = Convert.ToSingle( reader["ClassFees"]);

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

        public static bool GetLicenseClassByClassName(string ClassName, ref int ID, ref int minmAge, ref float ClassFees)
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
                    minmAge = (int)reader["MinimumAllowedAge"];
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);

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

        public static bool UpdateLicenseClass(int ID,  string ClassName,  int minmAge,  float ClassFees)
        {
            int Rowafcted = 0;


            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"UPDATE LicenseClasses 
Set 
ClassName=@ClassName,MinimumAllowedAge,@MinimumAllowedAge,
ClassFees.@ClassFees WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LicenseClassID", ID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@MinimumAllowedAge", minmAge);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

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
