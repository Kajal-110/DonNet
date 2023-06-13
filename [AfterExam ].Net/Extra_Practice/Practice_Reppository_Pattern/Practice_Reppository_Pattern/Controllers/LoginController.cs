using Practice_Reppository_Pattern.Models.Models;
using Practice_Reppository_Pattern.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_Reppository_Pattern.Controllers
{
    public class LoginController : Controller
    {
        LoginInterface ILogin;

        public LoginController(LoginInterface ILogin)
        {
             this.ILogin=ILogin;
        }
        // GET: Login
        public ActionResult Login()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult Login(LoginInformationModel loginInformation)
        {
            try
            {
                string result = ILogin.LoginUser(loginInformation);
                if (result != "Invalid Email" && result != "Invalid Password")
                {
                    Session["Username"] = loginInformation.UserName;
                        
                    Session["id"] = result;
                    return RedirectToAction("AddOrder", "Order");
                }
                ViewBag.error = result;
                return View();
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");

            }

        }

        public ActionResult Logout()
        {
            try
            {
                Session.Abandon();
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");

            }
        }
    }
}