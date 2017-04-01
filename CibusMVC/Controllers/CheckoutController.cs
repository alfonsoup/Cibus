using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CibusMVC.Models;
using CibusMVC.DAL;

namespace CibusMVC.Controllers
{
    public class CheckoutController : Controller
    {
        CibusDB2Entities db = new CibusDB2Entities();
        // GET: Checkout/Confirmar
        public ActionResult Confirmar()
        {
            var pedido = new Pedido();
            pedido.IdCliente = HttpContext.Request.ServerVariables["REMOTE_ADDR"]; //HttpContext.Request.UserHostAddress;
            pedido.Fecha = DateTime.Now;

            db.Pedidos.Add(pedido);
            db.SaveChanges();

            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.CreateOrder(pedido);

            return RedirectToAction("Completado", new { id = pedido.IdPedido});

        }

        public ActionResult Completado(int id)
        {
            // Validate customer owns this order
            bool isValid = db.Pedidos.Any(
                o => o.IdPedido == id &&
                o.IdCliente == HttpContext.Request.ServerVariables["REMOTE_ADDR"]);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}