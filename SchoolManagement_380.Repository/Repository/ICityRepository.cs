using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Repository
{
    public interface ICityRepository
    {
        IEnumerable<Sp_state_country_city_Result> getCountryStateCittyList();

        bool AddCity(CityModel cityModel, int? id);

        CityModel GetCityId(int? id);

        void DeleteCityId(int id);
    }
}
