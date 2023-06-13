using Food_Order.DBContext;
using Food_Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Food_Order.Controllers
{
    public class TeacherController : Controller
    {
         public static readonly KajalPatelEntities db = new KajalPatelEntities();
        // GET: Teacher

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {

            db.Teachers.Add(teacher);
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult Detail(int id )
        {
            try
            {
                List<DBContext.Teacher> teachers = new List<DBContext.Teacher>();

                List<Teacher_Validation> tv = new List<Teacher_Validation>();

                teachers = db.Teachers.ToList();

                if (teachers != null && teachers.Count > 0)
                {
                    tv = convertToTeacherValidation(teachers);
                }
            return View(tv);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

       private List<Teacher_Validation>  convertToTeacherValidation(List<Teacher> t)
        {
            try
            {
                List<Teacher_Validation> teacher = new List<Teacher_Validation>();
                foreach (var i in t) {
                    Teacher_Validation teacher_ = new Teacher_Validation();
                    teacher_.TeacherName = i.TeacherName;
                    teacher_.Email = i.Email;
                    teacher_.Address = i.Address;
                    teacher_.Gender = i.Gender;
                    teacher_.City = i.City;
                    teacher.Add(teacher_);
                }
                return teacher;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}