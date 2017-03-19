using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.DAL
{
    public interface IPedidoRepository : IDisposable
    {
        IEnumerable<Pedido> GetPedidos();
        Pedido GetPedidoByID(int pedidoId);
        void InsertPedido(Pedido pedido);
        void DeletePedido(int pedidoID);
        void UpdatePedido(Pedido pedido);
        void Save();
    }
}