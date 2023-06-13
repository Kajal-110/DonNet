using Dashboard_Theam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard_Theam.Controllers
{
    public class Company_PersonController : Controller
    {
        xyzEntities abc = new xyzEntities();
        // GET: Company_Person
        public ActionResult Index()
        {
            var data = abc.Companies.ToList();
            return View(data);
        }
    }
}