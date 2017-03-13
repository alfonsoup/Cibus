using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int IdCombo { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public virtual Order Order { get; set; }
        public virtual Combo Combo { get; set; }
    }
}