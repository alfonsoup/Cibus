using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CibusMVC.DAL
{
    public class RestauranteRepository :IRestauranteRepository, IDisposable
    {
        private CibusDB2Entities context;

        public RestauranteRepository(CibusDB2Entities context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurante> GetRestaurantes()
        {
           
            return context.Restaurantes.ToList();
        }

        public Restaurante GetRestauranteByID(int id)
        {
            return context.Restaurantes.Find(id);
        }

        public void InsertRestaurante(Restaurante restaurante)
        {
            context.Restaurantes.Add(restaurante);
        }

        public void DeleteRestaurante(int restauranteID)
        {
            Restaurante restaurante = context.Restaurantes.Find(restauranteID);
            context.Restaurantes.Remove(restaurante);
        }

        public void UpdateRestaurante(Restaurante restaurante)
        {
            context.Entry(restaurante).State = EntityState.Modified;
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