using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Project
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid guid = Guid.NewGuid();
            // convert the GUID to a string
            return guid.ToString();
        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;

            FileInfo fi = new FileInfo(fileName);

            string ext = fi.Extension;
            return GenerateGUID() + ext;
        }
        public static bool CopyImageToProjectImagesFolder(ref string sourecFile)
        {
            string DestinationFolder = @"D:\DVLD-People-Images\";

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destiationFolder = DestinationFolder + ReplaceFileNameWithGUID(sourecFile);

            try
            {
                File.Copy(sourecFile, destiationFolder, true);
            }
            catch (IOException iox)
            {
                //MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourecFile = destiationFolder;
            return true;
        }
    }
}
