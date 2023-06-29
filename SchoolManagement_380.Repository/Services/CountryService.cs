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
    public class CountryService : ICountryRepository
    {
         Sandhya_380Entities6 _Dbcsc = new Sandhya_380Entities6();

        public bool AddCountry(CountryModel countryModel, int? id)
        {
            try
            {
                Country country = CountryHelper.createCountry(countryModel);
                if(country != null)
                {
                    if(id == 0)
                    {
                        _Dbcsc.Country.Add(country);
                        _Dbcsc.SaveChanges();
                        return true;
                    }
                    else
                    {
                        _Dbcsc.Entry(country).State = System.Data.Entity.EntityState.Modified;
                        _Dbcsc.SaveChanges();
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void deleteId(int id)
        {
            var delete = _Dbcsc.Country.Find(id);
            _Dbcsc.Country.Remove(delete);
            _Dbcsc.SaveChanges();
          
        }

        public IEnumerable<Country> GetCountries()
        {
            return _Dbcsc.Country.ToList();
        }

        public CountryModel GetCountrybyId(int? id)
        {
            Country country = _Dbcsc.Country.Where(x => x.CountryId == id).FirstOrDefault();
            CountryModel countryModel = CountryHelper.getCountry(country);
            return countryModel;
        }
    }
}
