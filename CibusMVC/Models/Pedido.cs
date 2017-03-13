using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdMesa { get; set; }
        public int IdCombo { get; set; }
        public int IdMesero { get; set; }
        public string Fecha { get; set; }
        public float PrecioTotal { get; set; }

    }
}