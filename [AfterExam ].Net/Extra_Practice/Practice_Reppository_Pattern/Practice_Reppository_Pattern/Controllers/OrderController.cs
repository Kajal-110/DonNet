using Practice_Reppository_Pattern.Helpers.Helpers;
using Practice_Reppository_Pattern.Models.Context;
using Practice_Reppository_Pattern.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_Reppository_Pattern.Controllers
{
    public class OrderController : Controller
    {
        Kajalpatel5_13_2023Entities _context = new Kajalpatel5_13_2023Entities();
        // GET: Order
        public ActionResult AddOrder()
        {
            try
            {
                OrderModel orderModel = new OrderModel();
                int Id;
                if (Session["Id"] == null)
                {
                    Id = _context.LoginInformation.Where(x => x.UserName.Equals("Kajal@gmail.com")).FirstOrDefault().Id;
                }
                else
                {
                    Id = Convert.ToInt32(Session["Id"]) + 0;
                }
                orderModel.userId = Id;
                orderModel.itemList = _context.item.ToList();
                return View(orderModel);
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
        [HttpPost]

        public ActionResult AddOrder(OrderModel order)
        {
            try
            {
                if (order.couponCode != null)
                {
                    int couponCode = _context.CouponCodeMaster.Where(x => x.CouponCode.Equals(order.couponCode)).FirstOrDefault().CouponId;
                    CouponCodeMaster decreaseCoupon = _context.CouponCodeMaster.Where(x => x.CouponId == couponCode).FirstOrDefault();
                    decreaseCoupon.CouponUsageLimit = decreaseCoupon.CouponUsageLimit - 1;
                    order orderDb = OrderHelper.ModelToDb(order, couponCode);
                    _context.order.Add(orderDb);
                    _context.SaveChanges();
                    TempData["success"] = "Order Added Successsfully";
                }
                else
                {
                    order orderDb = OrderHelper.ModelToDb(order, 0);
                    _context.order.Add(orderDb);
                    _context.SaveChanges();
                    TempData["success"] = "Order Added Successsfully";
                }
                return RedirectToAction("OrderList");
            }
            catch (Exception e)
            {
                ViewBag.error = e.Message;
                return View("Error");
            }
        }
        public ActionResult OrderList()
        {
            try
            {
                int userId;
                if (Session["id"] == null)
                {
                    userId = _context.LoginInformation.Where(x => x.UserName.Equals("Kajal@gmail.com")).FirstOrDefault().Id;
                }
                else
                {
                    userId = Convert.ToInt32(Session["id"]) + 0;
                }
                List<order> orderList = _context.order.Where(x => x.userId == userId).ToList();
                return View(orderList);
            }
            catch (Exception e)
            {

                ViewBag.error = e.Message;
                return View("Error");
            }
        }
    }
}