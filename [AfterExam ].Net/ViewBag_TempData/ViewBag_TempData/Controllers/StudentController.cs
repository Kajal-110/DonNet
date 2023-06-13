using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ViewBag_TempData.Models;

namespace ViewBag_TempData.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["Today"] = DateTime.Now.ToString();
            TempData.Keep("Today");
            ViewBag.Name = "Detail of One Student";
            try
            {
                Student student = new Student();
                student.Id = 1;
                student.Name = "Kajal";
                student.Address = "Jabalpur";
                student.PostalCode = 482004;
                return View(student);
            }
            catch(Exception e)
            {
                throw e;
            }
           

        }
        public ActionResult About()
        {
            try
            {
                ViewBag.Name1 = "Details of All the Student";

                List<Student> studentList = new List<Student>();

                studentList.Add(new Student
                {
                    Id = 1,
                    Name = "Kajal",
                    Address = "Bhopal",
                    PostalCode = 482008
                });
                studentList.Add(new Student
                {
                    Id = 2,
                    Name = "Pooja",
                    Address = "Jabalpur",
                    PostalCode = 482006
                });
                studentList.Add(new Student
                {
                    Id = 3,
                    Name = "Simran",
                    Address = "Pune",
                    PostalCode = 482009
                });


                return View(studentList);
            }
            catch(Exception e)
            {
                throw e;
            }

            
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}