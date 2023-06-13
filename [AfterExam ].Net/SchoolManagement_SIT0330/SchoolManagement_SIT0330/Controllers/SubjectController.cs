using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repository.Ropositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_SIT0330.Controllers
{
    public class SubjectController : Controller
    {
        ISubject subjectInterface;

        public SubjectController(ISubject subjectInterface)
        {
            this.subjectInterface = subjectInterface;
        }
        // GET: Subject
        public ActionResult Details()
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();
            subjectModels = subjectInterface.GetAllSubjectList();
            return View(subjectModels);
        }
    }
}