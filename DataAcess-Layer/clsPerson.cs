using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess_Layer
{
    public class clsPerson
    {
        public static DataTable GetAllPerson()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string qouy = "Select * from People";

            SqlCommand command = new SqlCommand(qouy, connection);

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

        //public static bool GetPersonByID();
    }
}
