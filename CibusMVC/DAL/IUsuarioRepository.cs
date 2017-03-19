using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CibusMVC.DAL
{
    public interface IUsuarioRepository : IDisposable
    {
        IEnumerable<Usuario> GetUsuarios();
        Usuario GetUsuarioByID(int usuarioId);
        void InsertUsuario(Usuario usuario);
        void DeleteUsuario(int usuarioID);
        void UpdateUsuario(Usuario usuario);
        void Save();
    }
}