using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard_Theam.Controllers
{
    public class HameController : Controller
    {
        // GET: Hame
        public string Index()
        {
            return "Kajal";

           
        }
        public ActionResult Order()
        {
            ViewData["name"] = "this is from viewdata";
            ViewBag.name = "this is from viewbeg";
            TempData["name"]= "this is from tempdata";
            Session["name"]= "this is from session";
            return View();
        }
        [ActionName("store")]
        public ActionResult Product()
        {
            return View("Product");
        }
    }
}