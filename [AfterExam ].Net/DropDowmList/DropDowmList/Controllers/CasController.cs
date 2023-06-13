using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDowmList.Models;
namespace DropDowmList.Controllers
{
    public class CasController : Controller
    {
        // GET: Cas
        public ActionResult Index()
        {
            xyzEntities xyz = new xyzEntities();
            ViewBag.CountryList = new SelectList(GetCountryList(), "Id", "CountryName");
            return View();
        }
        public List<Country> GetCountryList()
        {
            xyzEntities xyz = new xyzEntities();
            List<Country> countries = xyz.Countries.ToList();
            return (countries);
        }
        public ActionResult GetStateList(int CountryId)
        {
            xyzEntities xyz = new xyzEntities();
            List<State> SList = xyz.States.Where(x=>x.CountryId == CountryId).ToList();
            ViewBag.StateList = new SelectList(SList, "Id", "StateName");
            return PartialView("DisplayState");
        }

        public ActionResult GetCityList(int Id)
        {
            xyzEntities xyz = new xyzEntities();
            List<City> CList = xyz.Cities.Where(x => x.StateId == Id).ToList();
            ViewBag.CityList = new SelectList(CList, "Id", "CityName");
            return PartialView("DisplayCity");
        }
    }
}