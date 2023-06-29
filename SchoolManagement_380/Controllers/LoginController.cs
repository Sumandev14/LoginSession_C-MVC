using SchoolManagement_380.Models.DbContext;
using SchoolManagement_380.Models.Models;
using SchoolManagement_380.Repository.Repository;
using SchoolManagement_380.SessionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SchoolManagement_380.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        private ILoginRepository _loginRepo;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepo = loginRepository;
        }
        public ActionResult CreateLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateLogin(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _loginRepo.CreateLogin(loginModel);

                    if(result != null)
                    {
                        Session["Email"] = loginModel.Email;
                        SessionHelper.SessionHelper.Email = loginModel.Email;
                        //Session["Login"] = result.StdId;
                        return RedirectToAction("Dashboard", "Home");
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "User not Exist!!!!";
                    }
                }
                return View(loginModel);
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("CreateLogin");
        }
    }
}