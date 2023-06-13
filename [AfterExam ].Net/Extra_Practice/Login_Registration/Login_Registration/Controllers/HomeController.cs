using Login_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Registration.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
           

            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail userDetail)
        {
            WebApplicationEntities db = new WebApplicationEntities();

            var user = db.UserDetails.Where(x => x.UserName == userDetail.UserName && x.Password == userDetail.Password).ToList();
            //var user = db.UserDetails.Where(x => x.UserName == userDetail.UserName && x.Password == userDetail.Password).Count();
            //var user = db.UserDetails.Where(x => x.UserName == userDetail.UserName && x.Password == userDetail.Password).FirstOrDefault();

            if(user != null)
            {
                return RedirectToAction("GetUserList");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Register()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult Register(UserDetail userdetail)
        {
            WebApplicationEntities db = new WebApplicationEntities();
            db.UserDetails.Add(userdetail);
            db.SaveChanges();
            return View();
        }

        public ActionResult GetUserList()
        {
            WebApplicationEntities db = new WebApplicationEntities();
            var userList = db.UserDetails.ToList();
            
            return View(userList);
        }

        public ActionResult UserProfile(int UserId)
        {
            WebApplicationEntities db = new WebApplicationEntities();
            var edituser=db.UserDetails.Find(UserId);

            edituser.IsintrestedinCSharp = (edituser.IsintrestedinCSharp == null) ? false : edituser.IsintrestedinCSharp;
            edituser.IsintrestedinJava = (edituser.IsintrestedinJava == null) ? false : edituser.IsintrestedinJava;
            edituser.IsintrestedinPython = (edituser.IsintrestedinPython == null) ? false : edituser.IsintrestedinPython;

            var cityList = db.Cities.ToList();

            // ViewBag.CityName = new SelectList(cityList,"CityId","CityName");
            edituser.CityList = new SelectList(cityList,"CityId","CityName");

            return View(edituser);
        }
        [HttpPost]
        public ActionResult UserProfile(UserDetail userDetail,string Csharp, string Java, string Python)
        {
            userDetail.IsintrestedinCSharp = (Csharp == "true") ? true : false;

            userDetail.IsintrestedinJava = (Csharp == "true") ? true : false;

            userDetail.IsintrestedinPython = (Csharp == "true") ? true : false;
            //if(Csharp=="true")
            //{
            //    userDetail.IsintrestedinCSharp = true;
            //}
            //else
            //{
            //    userDetail.IsintrestedinCSharp = false;
            //}
            //if (Java == "true")
            //{
            //    userDetail.IsintrestedinJava = true;
            //}
            //else
            //{
            //    userDetail.IsintrestedinJava = false;
            //}
            //if (Python == "true")
            //{
            //    userDetail.IsintrestedinPython = true;
            //}
            //else
            //{
            //    userDetail.IsintrestedinPython = false;
            //}
            WebApplicationEntities db = new WebApplicationEntities();
            db.Entry(userDetail).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("GetUserList");
        }
    }
}