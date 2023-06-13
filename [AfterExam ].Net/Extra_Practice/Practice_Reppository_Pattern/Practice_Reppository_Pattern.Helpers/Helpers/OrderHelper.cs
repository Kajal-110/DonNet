using Practice_Reppository_Pattern.Models.Context;
using Practice_Reppository_Pattern.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Reppository_Pattern.Helpers.Helpers
{
    public static class OrderHelper
    {
        public static order ModelToDb(OrderModel orderModel, int CouponId)
        {
            try
            {
                order order1 = new order();
                order1.OrderId = orderModel.OrderId;
                order1.userId = orderModel.userId;
                if(CouponId == 0)
                {
                    order1.couponCode = null;
                }
                else
                {
                    order1.couponCode = CouponId;

                }
                order1.itemId = orderModel.itemId;
                order1.OrderDate = orderModel.OrderDate;
                order1.OrderTotalQuantity = orderModel.OrderTotalQuantity;
                order1.orderAmount = orderModel.orderAmount;
                order1.AfterGST = orderModel.AfterGST;
                order1.TotalPayable = orderModel.TotalPayable;
                return order1;


            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
