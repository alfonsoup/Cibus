using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.DAL
{
    public interface  ISizeRepository : IDisposable
    {
        IEnumerable<Size> GetSizes();
        Size GetSizeByID(int sizeId);
        void InsertSize(Size pedido);
        void DeleteSize(int pedidoID);
        void UpdateSize(Size pedido);
        void Save();
    }
}