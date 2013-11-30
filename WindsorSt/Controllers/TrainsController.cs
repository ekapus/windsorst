using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindsorSt.Models;

namespace WindsorSt.Controllers
{
    public class TrainsController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /Trains/

        public ActionResult Index()
        {
            return View(db.Trains.ToList());
        }

        //
        // GET: /Trains/Details/5

        public ActionResult Details(int id = 0)
        {
            Train train = db.Trains.Find(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        //
        // GET: /Trains/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Trains/Create

        [HttpPost]
        public ActionResult Create(Train train)
        {
            if (ModelState.IsValid)
            {
                db.Trains.Add(train);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(train);
        }

        //
        // GET: /Trains/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Train train = db.Trains.Find(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        //
        // POST: /Trains/Edit/5

        [HttpPost]
        public ActionResult Edit(Train train)
        {
            if (ModelState.IsValid)
            {
                db.Entry(train).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(train);
        }

        //
        // GET: /Trains/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Train train = db.Trains.Find(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        //
        // POST: /Trains/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Train train = db.Trains.Find(id);
            db.Trains.Remove(train);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}