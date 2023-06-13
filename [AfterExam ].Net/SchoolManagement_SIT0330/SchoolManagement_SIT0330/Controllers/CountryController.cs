using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repository.Ropositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_SIT0330.Controllers
{
    public class CountryController : Controller
    {
        ICountry countryinterface;

        public CountryController(ICountry countryinterface )
        {
            this.countryinterface = countryinterface;
        }
        // GET: Country
        public ActionResult Details()
        {
            List<CountryModel> countryModels = new List<CountryModel>();
            countryModels = countryinterface.GetAllCountryList();
            return View(countryModels);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CountryModel countryModel)
        {
            string country = countryinterface.CreateCountry(countryModel);
            if(country == "Success")
            {
                return RedirectToAction("Details");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult Edit(int id)
        {
            CountryModel countryModel = countryinterface.EditUserModel(id);
            return View(countryModel);
        }
        [HttpPost]
        public ActionResult Edit(CountryModel countryModel)
        {
            if (ModelState.IsValid)
            {
                countryinterface.PostCountryData(countryModel);
                return RedirectToAction("Details");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            countryinterface.DeleteCountry(id);
            return RedirectToAction("Details");
        }
    }
}

