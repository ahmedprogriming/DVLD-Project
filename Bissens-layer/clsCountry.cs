using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsCountry
    {
       public int ID { get; set; }
        public string CountryName { get; set; }

        clsCountry() 
        {
            ID = -1;
            CountryName = " ";
        }

        clsCountry(int ID ,string Name)
        {
            this.ID = ID;
            this.CountryName = Name;
        }

        public bool UpdateCountry()
        {
            return clsCountryData.UpdateCountris(this.ID, this.CountryName);
        }

        public static DataTable AllCountrys()
        {
           return clsCountryData.GetAllCountrys();
        }

        public static clsCountry Find(string CountyName)
        {
            int ID = -1;
            if(clsCountryData.GetCountryByName(CountyName,ref ID))
                return new clsCountry(ID,CountyName);
            else 
                return null;
        }

        public static clsCountry Find(int  ID)
        {
            string CountyName = " ";
            if (clsCountryData.GetCountryByID(ID, ref CountyName))
                return new clsCountry(ID, CountyName);
            else
                return null;
        }
    }
}
