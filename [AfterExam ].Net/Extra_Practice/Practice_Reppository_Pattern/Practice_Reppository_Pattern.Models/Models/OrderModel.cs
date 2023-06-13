using Practice_Reppository_Pattern.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Reppository_Pattern.Models.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> couponCode { get; set; }
        public Nullable<int> itemId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<int> OrderTotalQuantity { get; set; }
        public Nullable<decimal> orderAmount { get; set; }
        public Nullable<decimal> AfterGST { get; set; }
        public Nullable<decimal> TotalPayable { get; set; }
        public Nullable<int> SGST { get; set; }
        public Nullable<int> CGST { get; set; }
        public int orderItemQty { get; set; }
        public List<item> itemList { get; set; }
    }
}
