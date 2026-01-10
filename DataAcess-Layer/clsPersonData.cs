using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace DataAcess_Layer
{
    public class PersonData
    {
        
    
        public static DataTable GetAllPerson()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string qouy =
      "SELECT People.PersonID, " +
      "People.NationalNo, " +
      "People.FirstName, " +
      "People.SecondName, " +
      "People.ThirdName, " +
      "People.LastName, " +
      "People.DateOfBirth, " +
      "People.Address, " +
      "People.Phone, " +
      "People.Email, " +
      "Countries.CountryName AS CountryName, " +
      "CASE " +
          "WHEN People.Gendor = 0 THEN 'Male' " +
          "WHEN People.Gendor = 1 THEN 'Female' " +
          "ELSE 'Unknown' " +
      "END As Gendor " +
      "FROM Countries " +
      "INNER JOIN People ON Countries.CountryID = People.NationalityCountryID";


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

        public static bool GetPersonByID(int personID, ref string NationalNo,
          ref string firstName, ref string lastName, ref string secondName,
         ref string thirdName, ref string email, ref string phone,
           ref DateTime dateOfBirth, ref byte gendor, ref string address,
           ref string imagePath, ref int nationalityCountryID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from People where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    thirdName = reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    email = reader["Email"].ToString();
                    phone = reader["Phone"].ToString();
                    address = reader["Address"].ToString();

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagePath = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        imagePath = "";
                    }

                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gendor = (byte)reader["Gendor"];
                    nationalityCountryID = (int)reader["NationalityCountryID"];


                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch(Exception ex) 
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

        public static bool GetPersonByNationalNo(string NationalNo, ref int personID ,
       ref string firstName, ref string lastName, ref string secondName,
      ref string thirdName, ref string email, ref string phone,
        ref DateTime dateOfBirth, ref byte gendor, ref string address,
        ref string imagePath, ref int nationalityCountryID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from People where NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    personID = (int)reader["ID"];
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    thirdName = reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    email = reader["Email"].ToString();
                    phone = reader["Phone"].ToString();
                    address = reader["Address"].ToString();

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagePath = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        imagePath = "";
                    }

                    dateOfBirth = (DateTime)reader["dateOfBirth"];
                    gendor = (byte)reader["gendor"];
                    nationalityCountryID = (int)reader["nationalityCountryID"];


                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static int AddNewPerson( string NationalNo,
           string FirstName,  string lastName,  string secondName,
          string thirdName,  string email,  string phone,
            DateTime dateOfBirth,  byte gendor,  string address,
            string imagePath,  int NationalityCountryID)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"
INSERT INTO People
           (NationalNo
           ,FirstName
           ,SecondName
           ,ThirdName
           ,LastName
           ,DateOfBirth
           ,Gendor
           ,Address
           ,Phone
           ,Email
           ,NationalityCountryID
           ,ImagePath)
     VALUES
           (@NationalNo
           ,@FirstName
           ,@SecondName
           ,@ThirdName
           ,@LastName
           ,@DateOfBirth
           ,@Gendor
           ,@Address
           ,@Phone
           ,@Email
           ,@NationalityCountryID
           ,@ImagePath);
 SELECT SCOPE_IDENTITY();";

            SqlCommand command =new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
    
            if (thirdName != null && thirdName != "")
                command.Parameters.AddWithValue("@ThirdName", thirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Gendor", gendor);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Address", address);
            if (email != null && email != "")
                command.Parameters.AddWithValue("@Email", email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (imagePath != null && imagePath != "")
                command.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    PersonID = autoID;
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
            return PersonID;
        }

        public static bool UpdatePerson(int ID,string NationalNo,
           string FirstName, string lastName, string secondName,
          string thirdName, string email, string phone,
            DateTime dateOfBirth, byte gendor, string address,
            string imagePath, int NationalityCountryID)
        {
            int RowsAfcted = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"UPDATE People 
                 SET NationalNo = @NationalNo,
                     FirstName = @FirstName,
                     SecondName = @SecondName,
                     ThirdName = @ThirdName,
                     LastName = @LastName,
                     DateOfBirth = @DateOfBirth,
                     Gendor = @Gendor,
                     Address = @Address,
                     Phone = @Phone,
                     Email = @Email,
                     NationalityCountryID = @NationalityCountryID,
                     ImagePath = @ImagePath
                 WHERE PersonID = @PersonID;";
            SqlCommand command=new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@Phone", phone);
            if (thirdName != null && thirdName != "")
                command.Parameters.AddWithValue("@ThirdName", thirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Gendor", gendor);
            command.Parameters.AddWithValue("@Address", address);
      
            if (email != null && email != "")
                command.Parameters.AddWithValue("@Email", email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (imagePath != null && imagePath != "")
                command.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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


            return (RowsAfcted>0);
        }

        public static bool DeletePerson(int ID)
        {
            int rowAfected = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"Delete People where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(qury,connection);
            command.Parameters.AddWithValue("@PersonID", ID);

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

        public static bool IsPesonExites(int PersonID)
        {
            bool IsFound=false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select Found=1 from People where PersonID=@PersonID";

            SqlCommand command= new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPesonExites(string NationalNo)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select Found=1 from People where NationalNo=@NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

    }
}
