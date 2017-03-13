using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CibusMVC.Models
{
    [Table("Restaurante")]
    public class Restaurante
    {
        [Key]
        public int IdRestaurante { get; set; }
        public string Nombre { get; set; }
        public int IdMenu { get; set; }
        public string logosrc { get; set; }
        public string Tipo { get; set; }


    }
}