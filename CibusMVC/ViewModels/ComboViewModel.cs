using CibusMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.ViewModels
{
    public class ComboViewModel
    {
        public List<Combo> AllCombos { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}