using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.Models
{
    public class Cart
    {
        
        public int RecordId { get; set; }
        public int IdCart { get; set; }
        public int IdMenu   { get; set; }
        public int Cantidad { get; set; }
        public System.DateTime FechaCreada { get; set; }
    public virtual Combo Combo { get; set; }    
       
    }
}