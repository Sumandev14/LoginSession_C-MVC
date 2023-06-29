using SchoolManagement_380.Helpers.Helpers;
using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_380.Controllers
{
    public class CityController : Controller
    {
        public ICityRepository _cityRepo;
        public IStateRepository _stateRepo;
        public ICountryRepository _countryRepo;
        public CityController(ICityRepository cityRepository, IStateRepository stateRepository, ICountryRepository countryRepository)
        {
            _cityRepo = cityRepository;
            _stateRepo = stateRepository;
            _countryRepo = countryRepository;
        }
        // GET: City
        public ActionResult CountryStateCityList()
        {
            ViewBag.CSCity = _cityRepo.getCountryStateCittyList();
            ViewBag.StateList = _stateRepo.getStateCountryList();
            ViewBag.CountryList = _countryRepo.GetCountries();
            return View();
        }

        public ActionResult AddCity(int? id)
        {
            try
            {
                if(id == 0 || id != null)
                {
                    ViewBag.StateList = _stateRepo.getStateCountryList();
                    ViewBag.CountryList = _countryRepo.GetCountries();
                    CityModel cityModel = _cityRepo.GetCityId(id);
                    return View(cityModel);
                }
                else
                {
                    ViewBag.StateList = _stateRepo.getStateCountryList();
                    ViewBag.CountryList = _countryRepo.GetCountries();
                    return View();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost]
        public ActionResult AddCity(CityModel cityModel, int? id)
        {
            try
            {
                if(cityModel.Cityid == 0)
                {
                    ViewBag.StateList = _stateRepo.getStateCountryList();
                    ViewBag.CountryList = _countryRepo.GetCountries();
                    _cityRepo.AddCity(cityModel, 0);
                    return RedirectToAction("AddCity");
                }
                else
                { 
                    _cityRepo.AddCity(cityModel, id);
                     return RedirectToAction("CountryStateCityList");    
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public ActionResult GetDetailById(int? id)
        {
            CityModel cityModel = _cityRepo.GetCityId(id);
            return View(cityModel);
        }
        public ActionResult DeleteCity(int id)
        {
            _cityRepo.DeleteCityId(id);
            return RedirectToAction("CountryStateCityList");
        }
    }
}