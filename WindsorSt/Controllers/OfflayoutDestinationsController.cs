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
    public class OfflayoutDestinationsController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /OfflayoutDestinations/

        public ActionResult Index()
        {
            return View(db.OffLayoutDestinations.ToList());
        }

        //
        // GET: /OfflayoutDestinations/Details/5

        public ActionResult Details(int id = 0)
        {
            OfflayoutDestination offlayoutdestination = db.OffLayoutDestinations.Find(id);
            if (offlayoutdestination == null)
            {
                return HttpNotFound();
            }
            return View(offlayoutdestination);
        }

        //
        // GET: /OfflayoutDestinations/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OfflayoutDestinations/Create

        [HttpPost]
        public ActionResult Create(OfflayoutDestination offlayoutdestination)
        {
            if (ModelState.IsValid)
            {
                db.OffLayoutDestinations.Add(offlayoutdestination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(offlayoutdestination);
        }

        //
        // GET: /OfflayoutDestinations/Edit/5

        public ActionResult Edit(int id = 0)
        {
            OfflayoutDestination offlayoutdestination = db.OffLayoutDestinations.Find(id);
            if (offlayoutdestination == null)
            {
                return HttpNotFound();
            }
            return View(offlayoutdestination);
        }

        //
        // POST: /OfflayoutDestinations/Edit/5

        [HttpPost]
        public ActionResult Edit(OfflayoutDestination offlayoutdestination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offlayoutdestination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(offlayoutdestination);
        }

        //
        // GET: /OfflayoutDestinations/Delete/5

        public ActionResult Delete(int id = 0)
        {
            OfflayoutDestination offlayoutdestination = db.OffLayoutDestinations.Find(id);
            if (offlayoutdestination == null)
            {
                return HttpNotFound();
            }
            return View(offlayoutdestination);
        }

        //
        // POST: /OfflayoutDestinations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            OfflayoutDestination offlayoutdestination = db.OffLayoutDestinations.Find(id);
            db.OffLayoutDestinations.Remove(offlayoutdestination);
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