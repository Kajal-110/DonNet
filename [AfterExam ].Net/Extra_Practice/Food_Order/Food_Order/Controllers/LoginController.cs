using Food_Order.DBContext;
using Food_Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Food_Order.Controllers
{
    public class LoginController : Controller
    {
        KajalPatelEntities db = new KajalPatelEntities();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLogin_Validation user)
        {

            try
            {
            var User = db.UserLogins.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
                if(User != null)
                {
                    Session["Email"] = user.Email;
                    
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.errorMessage = "Login Failed";  
                    return View();
                }
            } 
            catch( Exception e)
            {
                throw e;
            }
            
            
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login","Login");
        }
        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}