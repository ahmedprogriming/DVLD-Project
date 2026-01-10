using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess_Layer
{
    public class clsCountryData
    {
        public static DataTable GetAllCountrys()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from Countries Order By CountryName;";

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

        public static bool UpdateCountris(int ID, string countrisname)
        {
            int Rowafcted = 0;


            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "UPDATE Countries Set CountryName=@CountryName WHERE CountryID = @CountryID;";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@CountryID", ID);
            command.Parameters.AddWithValue("@CountryName", countrisname);

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

        public static bool GetCountryByName(string countryname, ref  int ID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From Countries  Where CountryName=@CountryName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", countryname);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["CountryID"];

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

        public static bool GetCountryByID(int ID , ref string countryname)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select * From Countries  Where CountryID=@CountryID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    countryname = (String)reader["CountryName"];

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

