using SchoolManagement_380.Models.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_380.Controllers
{
    public class AcountryStateCityController : Controller
    {
        Sandhya_380Entities6 _Db = new Sandhya_380Entities6();
        // GET: AcountryStateCity
        public ActionResult Index()
        {
            List<Country> CountryList = _Db.Country.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "CountryId", "CountryName");
            return View();
        }

        public JsonResult GetState(int CountryId)
        {
            _Db.Configuration.ProxyCreationEnabled = false;
            List<States> StateList = _Db.States.Where(x => x.CountryId == CountryId).ToList();
            ViewBag.StateList = new SelectList(StateList, "StateId", "StateName");
            return Json(StateList, JsonRequestBehavior.AllowGet);

        }
 
        public JsonResult GetCity(int StateId)
        {
            _Db.Configuration.ProxyCreationEnabled = false;
            List<City> CityList = _Db.City.Where(x => x.StateId == StateId).ToList();
            return Json(CityList, JsonRequestBehavior.AllowGet);

        }
    }
}