
using Food_Order.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Food_Order.Controllers
{
    public class HomeController : Controller
    {
            KajalPatelEntities db = new KajalPatelEntities();

        public ActionResult Index()
        {

            if(Session["Email"] == null)
            {

                return RedirectToAction("Login", "Login");
            }
            var List = db.FoodLists.ToList();
            ViewBag.FoodList = new SelectList(List, "Id", "DishName");
            return View();
        }
        [HttpGet]
        public JsonResult getFoodPrice( int Id)
        {
            var price = db.FoodLists.Find(Id);
            return Json(price, JsonRequestBehavior.AllowGet);
        }

       
    }
}