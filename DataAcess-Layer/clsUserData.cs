using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess_Layer
{
    public class clsUserData
    {
        public static DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);
            DataTable dataTable = new DataTable();

            string qouy = "Select UserID , PersonID , " +
                "UserName , Password , IsActive  from Users";


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

        public static bool GetUserByUserName(ref int UserID, ref int PersonID,
          string UserName, ref int PassWord, ref byte IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from Users where UserName=@UserName";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID =(int) reader["PersonID"];
                    PassWord =(int) reader["Password"];
                    IsActive =(byte) reader["IsActive"];
                
                  
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

        public static bool GetUserByUserID(int PersonID, ref int UserID,
     ref string UserName, ref int PassWord, ref byte IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserName = (string)reader["UseerName"];
                    UserID = (int)reader["UserID"];
                    PassWord = (int)reader["Password"];
                    IsActive = (byte)reader["IsActive"];


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

        public static int AddNewUser(int PersonID,
      string UserName, int PassWord, byte IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"
INSERT INTO Users
           (PersonID
           ,UserName
           ,PassWord
           ,IsActive)
     VALUES
           (@PersonID
           ,@UserName
           ,@PassWord
           ,@IsActive);
 SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", PassWord);
            command.Parameters.AddWithValue("@IsActive", IsActive);
          
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int autoID))
                {
                    UserID = autoID;
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
            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID,
        string UserName, int Password,byte IsActive)
        {
            int RowsAfcted = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"UPDATE Users 
                 SET PersonID = @PersonID,
                     UserName = @UserName,
                     Password = @Password,
                     IsActive = @IsActive,
                 WHERE UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
        
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

        public static bool DeleteUser(int UserID)
        {
            int rowAfected = 0;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"Delete Users where UserID=@UserID";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExites(int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select Found=1 from Users where UserID=@UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExites(string UserName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select Found=1 from Users where UserName=@UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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
