using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Helpers.Helpers
{
    public class CityHelper
    {
        public static City CreateCityHelper(CityModel cityModel)
        {
            City city = new City
            {
                CountryId = cityModel.CountryId,
                StateId = cityModel.StateId,
                Cityid = cityModel.Cityid,
                CityName = cityModel.CityName
            };
            return city;
        }

        public static CityModel GetCityHelper(City city)
        {
            CityModel cityModel = new CityModel()
            {
                CountryId = city.CountryId,
                StateId = city.StateId,
                Cityid = city.Cityid,
                CityName = city.CityName
            };
            return cityModel;
        }
    }
}
