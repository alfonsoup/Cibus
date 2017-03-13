using System.Collections.Generic;
using System.Data.Entity;


namespace CibusMVC.Models
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public List<Combo> Combos { get; set; }
        public string TipoCombo { get; set; }
    }
  
}