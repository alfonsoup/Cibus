using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public System.DateTime OrderDate;
        public List<OrderDetail> OrderDetails { get; set; }
    }
}