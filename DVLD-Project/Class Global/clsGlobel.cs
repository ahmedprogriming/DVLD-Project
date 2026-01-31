using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Bissens_layer;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DVLD_Project
{
    public static class clsGlobel
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            try
            {
                string currentDirectory=System.IO.Directory.GetCurrentDirectory();

                string filepath = currentDirectory + "\\data.txt";

                if (username == "" && File.Exists(filepath))
                {
                    File.Delete(filepath);
                    return true;
                }

                string dataToSave = username + "#//#" + password;

                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    writer.WriteLine(dataToSave);
                    return true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;

            }
        }

        public static bool GetStoredCredential(ref string username, ref string password)
        {
            try
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                string filepath = currentDirectory + "\\data.txt";

                if(File.Exists(filepath))
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.Write(line);

                            string[] resulte = line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                            username = resulte[0];
                            password = resulte[1];
                           
                        }

                        return true;
                    }
                }else
                {
                    return false;
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;

            }
        }



    }
}
