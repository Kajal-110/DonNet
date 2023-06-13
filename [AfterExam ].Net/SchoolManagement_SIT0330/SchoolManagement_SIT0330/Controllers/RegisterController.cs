using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repository.Ropositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_SIT0330.Controllers
{
    
    public class RegisterController : Controller
    {

        IUser us;
        // GET: Register

        public RegisterController(IUser us)
        {
            this.us = us;
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register( UserModel userModel)
        {
            string aa = us.Register(userModel);
           
            
                if (aa == "Success")
                {
                    return RedirectToAction("Login", "Register");
                }
                else
                {
                     return View();
                }
            
        }
        [LoginAction]
        public ActionResult Details(UserModel userModel)
        {
            var aa = us.GetAllUser();
            return View(aa);
        }


        public ActionResult GetUserById(int UserId)
        {

            UserModel UserDetail = us.GetUserByUserId(UserId);
            return View(UserDetail);
        }

        public ActionResult Edit(int id)
        {
            var edit = us.EditUserModel(id);
            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            if (ModelState.IsValid)
            {
                us.PostUserData(user);
                us.Save();

            return RedirectToAction("Details");
            }
            else
            {
                return View();
            }

            
            
        }

        public ActionResult Delete(int id)
        {

             us.DeleteUser(id);
           
            return RedirectToAction("Details");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel userModel)
        {
            try
            {
                User user=us.LoginUser(userModel);
                if(user != null)
                {

                    Session["Email"] = user.Email;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.errorMessage = "Login Failed";
                    return View();
                }
               
                
            }
            catch (Exception e)
            {

                throw e;
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

                throw e;
            }
        }

    }
}