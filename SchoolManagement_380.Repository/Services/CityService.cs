using SchoolManagement_380.Helpers.Helpers;
using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Services
{
    public class CityService : ICityRepository
    {
        Sandhya_380Entities6 _Dbcsc = new Sandhya_380Entities6();

        public bool AddCity(CityModel cityModel, int? id)
        {
            City city = CityHelper.CreateCityHelper(cityModel);
            if(city != null)
            {
                if(id == 0)
                {
                    _Dbcsc.City.Add(city);
                    _Dbcsc.SaveChanges();
                    return true;
                }
                else
                {
                    _Dbcsc.Entry(city).State = System.Data.Entity.EntityState.Modified;
                    _Dbcsc.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void DeleteCityId(int id)
        {
            var deleteId = _Dbcsc.City.Find(id);
            _Dbcsc.City.Remove(deleteId);
            _Dbcsc.SaveChanges();
        }

        public CityModel GetCityId(int? id)
        {
            City city = _Dbcsc.City.Where(x => x.Cityid == id).FirstOrDefault();
            CityModel cityModel = CityHelper.GetCityHelper(city);
            return cityModel;
        }

        public IEnumerable<Sp_state_country_city_Result> getCountryStateCittyList()
        {
            IEnumerable<Sp_state_country_city_Result> CityList = _Dbcsc.Sp_state_country_city().ToList(); 
            return CityList;
        }
    }
}
