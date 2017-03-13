using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CibusMVC.Models;
using CibusMVC.ViewModels;

namespace CibusMVC.Controllers
{
    public class ComboesController : Controller
    {
        private CibusDBContext db = new CibusDBContext();

        // GET: Comboes
        public ActionResult Index(int id)
        {
            //var combos = db.Combos.Select(c => c.IdMenu == id);
            var combos =
            from s in db.Combos
            select s;
            combos = combos.Where(s => s.IdMenu.Equals(id));

            Restaurante restaurante = db.Restaurantes.Where(s  => s.IdMenu.Equals(id)).Single();
                
           // restaurante = restaurante.Where(s => s.IdRestaurante.Equals(id)).Single();
            ComboViewModel cvm = new ComboViewModel();
            cvm.AllCombos = combos.ToList();
            cvm.Restaurante = restaurante;
          
           
            return View(cvm);
        }

        // GET: Comboes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Combos.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // GET: Comboes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comboes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCombo,IdMenu,Nombre,Descripcion,Precio,RutaImagen")] Combo combo)
        {
            if (ModelState.IsValid)
            {
                db.Combos.Add(combo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(combo);
        }

        // GET: Comboes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Combos.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // POST: Comboes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCombo,IdMenu,Nombre,Descripcion,Precio,RutaImagen")] Combo combo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(combo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(combo);
        }

        // GET: Comboes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Combo combo = db.Combos.Find(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        // POST: Comboes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Combo combo = db.Combos.Find(id);
            db.Combos.Remove(combo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
