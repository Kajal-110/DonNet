using Dashboard_Theam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard_Theam.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            Book b = new Book()
            {
                BookCode="ABCD110",
                BookName="xyz"
            };

            return View(b);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Display(Book bb)
        {
            //Book bb = new Book();
            //bb.BookCode = Request.Form["BookCode"];
            //bb.BookName = Request.Form["BookName"];
            return View("Index",bb);
        }
    }
}