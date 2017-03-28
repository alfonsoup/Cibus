﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CibusMVC.Models;
using CibusMVC.DAL;

namespace CibusMVC.Controllers
{
    public class RestaurantesController : Controller
    {


        
        private IRestauranteRepository restauranteRepository;
        public RestaurantesController()
        {
            this.restauranteRepository = new RestauranteRepository(new CibusDB2Entities());
        }

        public  RestaurantesController(IRestauranteRepository restauranteRepository)
        {
            this.restauranteRepository = restauranteRepository;
        }


        // GET: Restaurantes
        public ActionResult Index(String tipo)
        {

            IEnumerable<Restaurante> restaurantes;


            if (String.IsNullOrEmpty(tipo))
            {
                restaurantes = from s in restauranteRepository.GetRestaurantes() select s;
            }
            else {
                restaurantes = from s in restauranteRepository.GetRestaurantesByTipo(tipo) select s;

            }

           
            return View(restaurantes);
        }
        //protected override void Dispose(bool disposing)
        //{
        //    unitOfWork.Dispose();
        //    base.Dispose(disposing);
        //}

        //// GET: Restaurantes/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Restaurante restaurante = db.Restaurantes.Find(id);
        //    if (restaurante == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(restaurante);
        //}

        //// GET: Restaurantes/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Restaurantes/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "IdRestaurante,Nombre,IdMenu,Logo")] Restaurante restaurante)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Restaurantes.Add(restaurante);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(restaurante);
        //}

        //// GET: Restaurantes/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Restaurante restaurante = db.Restaurantes.Find(id);
        //    if (restaurante == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(restaurante);
        //}

        //// POST: Restaurantes/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "IdRestaurante,Nombre,IdMenu,Logo")] Restaurante restaurante)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(restaurante).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(restaurante);
        //}

        //// GET: Restaurantes/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Restaurante restaurante = db.Restaurantes.Find(id);
        //    if (restaurante == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(restaurante);
        //}

        //// POST: Restaurantes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Restaurante restaurante = db.Restaurantes.Find(id);
        //    db.Restaurantes.Remove(restaurante);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}


    }
}
