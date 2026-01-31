using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess_Layer
{
    public class clsTestDate
    {
        public static DataTable GetTestAll()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string query = @"select * from Tests";


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

    
        public static byte GetPassedTestAll(int LocalDrivingLicenseAppID)
        {
            byte PassedTestCount = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"select passTest= Count(TestTypeID) from Tests Inner Join  TestAppointments
on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestResult=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseAppID);


            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if (reader != null && byte.TryParse(reader.ToString(), out byte returnResult))
                {
                    PassedTestCount = returnResult;
                }
            }
            catch (Exception ex)
            {
                PassedTestCount = 0;
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }
            return PassedTestCount;

        }
    }
}
