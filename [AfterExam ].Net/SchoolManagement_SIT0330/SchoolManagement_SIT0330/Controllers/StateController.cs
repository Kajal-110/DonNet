using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repository.Ropositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_SIT0330.Controllers
{
    public class StateController : Controller
    {
        IState stateinterface;

        public StateController(IState stateinterface)
        {
            this.stateinterface = stateinterface;
        }
        // GET: State
        public ActionResult Details()
        {
            List<StateModel> stateModelsList = new List<StateModel>();
            stateModelsList = stateinterface.GetAllStateList();
            return View(stateModelsList);
        }

        public ActionResult Create()
        {
            ViewBag.CountryList = new SelectList(stateinterface.GetALLCountry(), "CountryId", "CountryName");

            return View();
        }
        [HttpPost]
        public ActionResult Create(StateModel stateModel)
        {
            ViewBag.CountryList = new SelectList(stateinterface.GetALLCountry(), "CountryId", "CountryName");
            string country = stateinterface.StateCreate(stateModel);
            if (ModelState.IsValid)
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