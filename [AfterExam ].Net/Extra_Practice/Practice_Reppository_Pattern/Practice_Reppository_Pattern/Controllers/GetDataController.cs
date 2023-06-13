using Practice_Reppository_Pattern.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_Reppository_Pattern.Controllers
{
    public class GetDataController : Controller
    {
        // GET: GetData

        Kajalpatel5_13_2023Entities _context = new Kajalpatel5_13_2023Entities();
        public JsonResult GetItemPrice( int id )
        {
            _context.Configuration.ProxyCreationEnabled = false;
            item Item = _context.item.Find(id);
            return Json(Item, JsonRequestBehavior.AllowGet);
              
        }

        public JsonResult GetCouponDiscount(string couponCode)
        {
            _context.Configuration.ProxyCreationEnabled = false;
            CouponCodeMaster coupons = _context.CouponCodeMaster.Where(x => x.CouponCode.Equals(couponCode)).FirstOrDefault();
            if (coupons != null)
            {
                return Json(coupons, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }
    }
}