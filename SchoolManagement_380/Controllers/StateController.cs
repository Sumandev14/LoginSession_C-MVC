using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_380.Controllers
{
    public class StateController : Controller
    {
        public IStateRepository _stateRepo;
        public ICountryRepository _countryRepo;

        public StateController(IStateRepository stateRepository, ICountryRepository countryRepository)
        {
            _stateRepo = stateRepository;
            _countryRepo = countryRepository;
        }
        // GET: State
        public ActionResult StateCountryList()
        {
            ViewBag.StateCountry = _stateRepo.getStateCountryList();
            ViewBag.CountryList = _countryRepo.GetCountries();
            return View();
        }

        public ActionResult AddStates(int? id)
        {
            try
            {
                if(id == 0 || id != null)
                {
                    ViewBag.CountryList = _countryRepo.GetCountries();
                    StateModel stateModel = _stateRepo.GetStateById(id);
                    return View(stateModel);
                }
                else
                {
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
        public ActionResult AddStates(StateModel stateModel, int? id)
        {
            if(stateModel.StateId == 0)
            {
                ViewBag.CountryList = _countryRepo.GetCountries();
                _stateRepo.AddState(stateModel, 0);
                return RedirectToAction("AddStates");
            }
            else
            {
                _stateRepo.AddState(stateModel, id);
                return RedirectToAction("StateCountryList");
            }
        }

        //delete state
        public ActionResult DeleteState(int id)
        {
            _stateRepo.deleteState(id);
            return RedirectToAction("StateCountryList");
        }

        public ActionResult GetDetailState(int? id)
        {
            _stateRepo.GetStateById(id);
            return View();
        }
    }
}