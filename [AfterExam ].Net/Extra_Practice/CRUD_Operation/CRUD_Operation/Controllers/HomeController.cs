using CRUD_Operation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Operation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student_Record student)
        {
            ViewBag.Message = "Your application description page.";

            CRUD_DBContext db = new CRUD_DBContext();
            db.Student_Record.Add(student);
            db.SaveChanges();

            return RedirectToAction("GetStudentList");
        }
         public ActionResult GetStudentList()
        {
            CRUD_DBContext db = new CRUD_DBContext();
             var StudentList= db.Student_Record.ToList();
            return View(StudentList);
        }
        public ActionResult Edit( int Id)
        {
            CRUD_DBContext db = new CRUD_DBContext();
            var Student = db.Student_Record.Find(Id);
            return View(Student);
        }
        [HttpPost]
        public ActionResult Edit(Student_Record student)
        {
            CRUD_DBContext db = new CRUD_DBContext();
            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("GetStudentList");
        }

         public ActionResult Delete(int Id)
         {
            CRUD_DBContext db = new CRUD_DBContext();
            var deleteStudent = db.Student_Record.Find(Id);
            db.Student_Record.Remove(deleteStudent);
            db.SaveChanges();
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("GetStudentList");
        }
        public ActionResult Details(int Id)
        {
            CRUD_DBContext db = new CRUD_DBContext();
            var Student = db.Student_Record.Find(Id);
            return View(Student);
            

        }
       

    }
}