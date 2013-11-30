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
    public class LayoutLocationController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /LayoutLocation/

        public ActionResult Index()
        {
            return View(db.LayoutLocations.ToList());
        }

        //
        // GET: /LayoutLocation/Details/5

        public ActionResult Details(int id = 0)
        {
            LayoutLocation layoutlocation = db.LayoutLocations.Find(id);
            if (layoutlocation == null)
            {
                return HttpNotFound();
            }
            return View(layoutlocation);
        }

        //
        // GET: /LayoutLocation/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LayoutLocation/Create

        [HttpPost]
        public ActionResult Create(LayoutLocation layoutlocation)
        {
            if (ModelState.IsValid)
            {
                db.LayoutLocations.Add(layoutlocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(layoutlocation);
        }

        //
        // GET: /LayoutLocation/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LayoutLocation layoutlocation = db.LayoutLocations.Find(id);
            if (layoutlocation == null)
            {
                return HttpNotFound();
            }
            return View(layoutlocation);
        }

        //
        // POST: /LayoutLocation/Edit/5

        [HttpPost]
        public ActionResult Edit(LayoutLocation layoutlocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(layoutlocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(layoutlocation);
        }

        //
        // GET: /LayoutLocation/Delete/5

        public ActionResult Delete(int id = 0)
        {
            LayoutLocation layoutlocation = db.LayoutLocations.Find(id);
            if (layoutlocation == null)
            {
                return HttpNotFound();
            }
            return View(layoutlocation);
        }

        //
        // POST: /LayoutLocation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LayoutLocation layoutlocation = db.LayoutLocations.Find(id);
            db.LayoutLocations.Remove(layoutlocation);
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