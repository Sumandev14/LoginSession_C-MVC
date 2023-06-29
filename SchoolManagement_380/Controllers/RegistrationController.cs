using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SchoolManagement_380.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistrationRepository _registrationRepo;

        public RegistrationController(IRegistrationRepository registrationRepository)
        {
            _registrationRepo = registrationRepository;
        }
       
        public ActionResult GetRegistration()
        {
            ViewBag.GetAllList = _registrationRepo.GetAllData();
            return View();
        }
        public ActionResult CreateReg(int? id)
        {
            if(id == null)
            {
                return View();
            }
            else
            {
                RegModel regModel = _registrationRepo.getUserById(id);
                return View(regModel);
            }
        }

        [HttpPost]
        public ActionResult CreateReg(RegModel regModel, int? id)
        {
            try
            {

                //bool EmailExist = _registrationRepo.GetAllData()
                //    .Any(x => x.Email == regModel.Email);

                //if (EmailExist)
                //{
                //    ModelState.AddModelError("Email", "Email already exists");
                //    return View(regModel);
                //}

                if (id == null)
                {
                    _registrationRepo.Create(regModel, 0);
                    return RedirectToAction("CreateReg");
                }
                else
                {
                    _registrationRepo.Create(regModel, id);
                    return RedirectToAction("GetRegistration");
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public ActionResult DeleteReg(int id)
        {
            _registrationRepo.DeleteStudent(id);
            return RedirectToAction("GetRegistration");
        }

        public ActionResult singleUserDetails(int? id)
        {
            RegModel regModel = _registrationRepo.getUserById(id);
            return View(regModel);
        }

        
    }
}