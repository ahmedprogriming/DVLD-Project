using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsLicense
    {
        public static bool IsExstesLicenseByPersonID(int PersonID,int LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        }
        public static int GetActiveLicenseIDByPersonID(int personID,int LicenseClassID)
        {
            return clsLicenseData.GetActiveLicenseIDByPersonID(personID, LicenseClassID);
        }
    }
}
