using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CibusMVC.DAL
{
    public class SizeRepository : ISizeRepository, IDisposable
    {
        private CibusDB2Entities context;

        public SizeRepository(CibusDB2Entities context)
        {
            this.context = context;
        }

        public IEnumerable<Size> GetSizes()
        {
            return context.Sizes.ToList();
        }

        public Size GetSizeByID(int id)
        {
            return context.Sizes.Find(id);
        }

        public void InsertSize(Size size)
        {
            context.Sizes.Add(size);
        }

        public void DeleteSize(int sizeID)
        {
            Size size = context.Sizes.Find(sizeID);
            context.Sizes.Remove(size);
        }

        public void UpdateSize(Size size)
        {
            context.Entry(size).State = EntityState.Modified;
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