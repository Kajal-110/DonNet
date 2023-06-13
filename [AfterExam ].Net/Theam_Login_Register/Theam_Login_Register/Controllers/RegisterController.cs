using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Theam_Login_Register.Models.Model;
using Theam_Login_Register.Repositories.Repositories;

namespace Theam_Login_Register.Controllers
{
    public class RegisterController : Controller
    {
        IUser iu;
        public RegisterController(IUser iu)
        {
            this.iu = iu;
        }

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModel userModel)
        {
            string aa = iu.Register(userModel);
            if (aa == "Success")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}