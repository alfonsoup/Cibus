using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CibusMVC.Models
{
    [Table("Combo")]
    public class Combo
    {
        [Key]
        public int IdCombo { get; set; }
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string imgsrc { get; set; }

    }

}