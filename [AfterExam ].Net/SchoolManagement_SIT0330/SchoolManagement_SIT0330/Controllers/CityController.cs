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

    public class CityController : Controller
    {
        ICity cityinterface;
        IState stateinterface;
        
        public CityController(ICity cityinterface, IState stateinterface)
        {
            this.cityinterface = cityinterface;
            this.stateinterface = stateinterface;
        }

        // GET: City
        public ActionResult Details()
        {
            List<CityModel> cityModels = new List<CityModel>();
            cityModels = cityinterface.GetAllCityList();
            return View(cityModels);
        }

        public ActionResult GetStateList(int CountryId)
        {
            ViewBag.StateList = new SelectList(cityinterface.GetAllState(CountryId), "StateId", "StateName");
            return PartialView("DisplayState");

        }


        public ActionResult Create(State state)
        {
            ViewBag.CountryList = new SelectList(cityinterface.GetALLCountry(), "CountryId", "CountryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(CityModel cityModel)
        {
            ViewBag.CountryList = new SelectList(cityinterface.GetALLCountry(), "CountryId", "CountryName");
            //ViewBag.StateList = new SelectList(cityinterface.GetAllState(cityModel.StateId), "StateId", "StateName");

            string city = cityinterface.CreateCity(cityModel);
            if(city != null)
            {
                return RedirectToAction("Details");
            }
            else
            {
                return View();
            }
            
        }
    }
}