using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CibusMVC.Models;
using CibusMVC.DAL;

namespace CibusMVC.Controllers
{
    public class PedidoController : Controller
    {
        private IPedidoRepository pedidoRepository;
        private IDetallePedidoRepository detallePedidoRepository;
        public PedidoController( )
        {
            this.pedidoRepository = new PedidoRepository(new CibusDB2Entities());
            this.detallePedidoRepository = new DetallePedidoRepository(new CibusDB2Entities());
        }


      

        // GET: Pedido
        public ActionResult Index()
        {
            var detalle = from s in detallePedidoRepository.GetDetallePedidos() select s;
            return View(detalle);
        }

     //   public ActionResult AddPedido(int idComboRestaurante, )
       // {

        //}
         
        
    }
}