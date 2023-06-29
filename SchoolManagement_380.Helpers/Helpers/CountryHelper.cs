using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Helpers.Helpers
{
    public class CountryHelper
    {
        public static Country createCountry(CountryModel countryModel)
        {
            Country country = new Country
            {
                CountryName = countryModel.CountryName
            };
            return country;
        }

        public static CountryModel getCountry(Country country)
        {
            CountryModel countryData = new CountryModel
            {
                CountryName = country.CountryName
            };
            return countryData;
        }
    }
}
