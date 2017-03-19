using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CibusMVC.DAL
{
    public class UsuarioRepository : IUsuarioRepository, IDisposable
    {
        private CibusDB2Entities context;

        public UsuarioRepository(CibusDB2Entities context)
        {
            this.context = context;
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return context.Usuarios.ToList();
        }

        public Usuario GetUsuarioByID(int id)
        {
            return context.Usuarios.Find(id);
        }

        public void InsertUsuario(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
        }

        public void DeleteUsuario(int usuarioID)
        {
            Usuario usuario = context.Usuarios.Find(usuarioID);
            context.Usuarios.Remove(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            context.Entry(usuario).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}