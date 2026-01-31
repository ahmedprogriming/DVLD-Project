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

            string qouy = "SELECT Users.UserID,Users.PersonID,CONCAT(People.FirstName, ' '," +
                "People.SecondName, ' ',People.ThirdName, ' ',People.LastName) AS FullName," +
                "Users.UserName,Users.Password,Users.IsActive FROM People INNER JOIN Users" +
                " ON People.PersonID = Users.PersonID;";
                


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

       

        public static bool GetUserByUserNameAndPassword(ref int UserID, ref int PersonID,
        string UserName, string PassWord, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from Users where UserName=@UserName and Password=@Password";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", PassWord);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];


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


        public static bool GetUserByUserID(int UserID , ref int PersonID,
     ref string UserName, ref string PassWord, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserName = (string)reader["UserName"];
                    PersonID = (int)reader["PersonID"];
                    PassWord = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


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
        public static bool GetUserByPersonID(ref int UserID,  int PersonID,
    ref string UserName, ref string PassWord, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = "Select * from Users where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(qury, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    UserName = (string)reader["UserName"];
                    UserID = (int)reader["UserID"];
                    PassWord = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


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
      string UserName, string PassWord, bool IsActive)
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
        string UserName, string Password, bool IsActive)
        {
            int RowsAfcted = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"UPDATE Users 
                 SET PersonID = @PersonID,
                     UserName = @UserName,
                     Password = @Password,
                     IsActive = @IsActive
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

        public static bool IsUserNameExites(string UserName)
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

        public static bool IsUserExitesPersonID(int Personid)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = "Select Found=1 from Users where PrsonID=@PrsonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PrsonID", Personid);

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

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int RowsAfcted = 0;

            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string query = @"UPDATE Users 
                 SET Password = @Password
                     
                 WHERE UserID = @UserID;";
                     
                     
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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
    }
}
