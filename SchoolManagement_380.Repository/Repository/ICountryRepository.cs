using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_380.Repository.Repository
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();

        bool AddCountry(CountryModel countryModel, int? id);
        CountryModel GetCountrybyId(int? id);
        void deleteId(int id);

    }
}
