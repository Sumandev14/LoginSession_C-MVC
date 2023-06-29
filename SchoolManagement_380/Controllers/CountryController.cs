using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_380.Controllers
{
    public class CountryController : Controller
    {
        public ICountryRepository _countryRepo;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepo = countryRepository;
        }
        // GET: Country
        public ActionResult CountryList()
        {
            ViewBag.Country = _countryRepo.GetCountries();
            return View();
        }

        public ActionResult AddEdit(int? id)
        {
            try
            {
                if(id == null)
                {
                    return View();
                }
                else
                {
                    CountryModel countryModel = _countryRepo.GetCountrybyId(id);
                    return View(countryModel);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost]
        public ActionResult AddEdit(CountryModel countryModel, int? id)
        {
            try
            {
                if(id == null)
                {
                    _countryRepo.AddCountry(countryModel, 0);
                    return RedirectToAction("AddEdit");
                }
                else
                {
                    _countryRepo.AddCountry(countryModel, id);
                    return RedirectToAction("CountryList");
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public ActionResult GetCountryid(int? id)
        {
            CountryModel countryModel = _countryRepo.GetCountrybyId(id);
            return View(countryModel);
        }

        public ActionResult DeleteCountry(int id)
        {
            _countryRepo.deleteId(id);
            return RedirectToAction("CountryList");
        }
    }
}