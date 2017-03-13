using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CibusMVC.Models
{
    public class CibusDBContext : DbContext 
    {
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}