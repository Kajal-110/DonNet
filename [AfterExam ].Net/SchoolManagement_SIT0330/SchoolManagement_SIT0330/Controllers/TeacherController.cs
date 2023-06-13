using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repository.Ropositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_SIT0330.Controllers
{
    public class TeacherController : Controller
    {
        ITeacher teacherInterface;
        ICity cityinterface;

        public TeacherController(ITeacher teacherInterface, ICity cityinterface)
        {
            this.teacherInterface = teacherInterface;
            this.cityinterface = cityinterface;
        }
        // GET: Teacher
        public ActionResult Details()
        {
            List<TeacherModel> teacher = new List<TeacherModel>();
            teacher = teacherInterface.GetAllTeacherList();
            return View(teacher);
        }

        public ActionResult Create()
        {
            ViewBag.CountryList = new SelectList(teacherInterface.GetALLCountry(), "CountryId", "CountryName");

            return View();
        }


        public ActionResult GetStateList(int CountryId)
        {
            ViewBag.StateList = new SelectList(teacherInterface.GetAllState(CountryId), "StateId", "StateName");
            return PartialView("DisplayState");

        }

        public ActionResult GetCityList(int StateId)
        {
            ViewBag.CityList = new SelectList(teacherInterface.GetAllCity(StateId), "CityId", "CityName");
            return PartialView("DisplayCity");

        }
        [HttpPost]
        public ActionResult Create(TeacherModel teacherModel)
        {
            ViewBag.CountryList = new SelectList(teacherInterface.GetALLCountry(), "CountryId", "CountryName");

            string teacher = teacherInterface.CreateTeacher(teacherModel) ;
            if(teacher == "Success")
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View();
            }
        }


        






        public ActionResult Delete(int id)
        {
            teacherInterface.TeacherDelete(id);
            return RedirectToAction("Details");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.CountryList = new SelectList(teacherInterface.GetALLCountry(), "CountryId", "CountryName");

            TeacherModel teacherModel = teacherInterface.EditTeacherModel(id);
            return View(teacherModel);
        }
        [HttpPost]
        public ActionResult Edit(TeacherModel teacherModel)
        {
            try
            {

                ViewBag.CountryList = new SelectList(teacherInterface.GetALLCountry(), "CountryId", "CountryName");

                teacherInterface.PostTeacherData(teacherModel);
                return RedirectToAction("Details");
            }
            catch (Exception e)
            {

                throw e;
            }
           
           
        }

    }
}

