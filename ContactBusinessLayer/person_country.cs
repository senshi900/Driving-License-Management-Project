using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public class person_country
    {
        public int countryid { get; set;}
        public string countryname { get; set;}


        public person_country(int id,string countryname)
        {
            this.countryid = id;
            this.countryname = countryname;

        }
        public person_country()
        {
            this.countryid = -1;
            this.countryname = "";
        }


        public static person_country getcountrybyid(int id)
        {
            string countyname = "";
            if (clsperson_countrys.GetCountryInfoByID(id, ref countyname))
            {
                return new person_country(id, countyname);
            }
            else
            {
                return null;
            }
           
        }
        public static DataTable getallcountrys()
        {
            return clsperson_countrys.GetAllCountries();
        }
       
    }


    
}
