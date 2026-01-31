using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess_Layer
{
    public class clsTestTypeData
    {
        public static DataTable GetAllTestType()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string qurey = "select * from TestTypes Order by TestTypeTitle;";


            SqlCommand command = new SqlCommand(qurey, connection);

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

        public static int AddNewTestType(string Title, string Description, float Fees)
        {
            int TestTypeID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"
INSERT INTO TestTypes
           (TestTypeTitle
           ,TestTypeDescription,TestTypeFees )
     VALUES
           (@TestTypeTitle
           ,@TestTypeDescription
            ,@TestTypeFees);
 SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@Description", Fees);
            command.Parameters.AddWithValue("@TestTypeFees", Fees);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    TestTypeID = autoID;
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
            return TestTypeID;
        }

        public static bool UpdateTestType(int ID, string Title,string Descr, float Fees)
        {
            int RowsAfcted = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            string query = @"UPDATE TestTypes 
                 SET TestTypeTitle = @TestTypeTitle,
                     TestTypeDescription = @TestTypeDescription,
                      TestTypeFees=@TestTypeFees
                 WHERE TestTypeID = @TestTypeID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", ID);
            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@TestTypeDescription", Descr);
            command.Parameters.AddWithValue("@TestTypeFees", Fees);

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

        public static bool GetAllByTestTypeID(int ID, ref string Title,ref string Description, ref float Fees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from TestTypes where TestTypeID=@TestTypeID";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@TestTypeID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    Title = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    Fees =Convert.ToSingle(reader["TestTypeFees"]);

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
    }
}
