using DropDowmList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDowmList.Controllers
{
    public class CompanyController : Controller
    {
        xyzEntities xyz = new xyzEntities();
        // GET: Company
        public ActionResult Index()
        {
            List<Company> companyList = xyz.Companies.ToList();
            ViewBag.CompanyTbl = new SelectList(companyList, "companyId", "companyName");


           
            return View();
        }

        //public ActionResult country()
        //{
        //    List<Country> countryList = xyz.Countries.ToList();
        //    ViewBag.CountryTbl = new SelectList(countryList, "Id", "CountryName");
        //    return RedirectToAction("Index");

        //}
    }
}