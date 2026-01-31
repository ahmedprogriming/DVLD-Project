using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAcess_Layer
{
    public class clsLicenseData
    {
        public static int GetActiveLicenseIDByPersonID(int PersonID,int LicenseClassID)
        {

            int LicenseID = -1;
            SqlConnection connection = new SqlConnection(clsCounection.CounectionString);

            string qury = @"select Licenses.LicenseID from Licenses inner join
Drivers on Drivers.DriverID=Licenses.DriverID

where 
Licenses.LicenseClass=@LicenseClass
and Drivers.PersonID=@PersonID
and IsActive=1";

            SqlCommand command = new SqlCommand(qury, connection);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
           

            try
            {
                connection.Open();

               object Rowafcted = command.ExecuteScalar();
                if (Rowafcted != null && int.TryParse(Rowafcted.ToString(), out int returResult))
                    {
                    LicenseID = returResult;
                }
                
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return LicenseID;
        }
    }
}
