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
    public class LocomotiveStatusesController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /LocomotiveStatuses/

        public ActionResult Index()
        {
            return View(db.LocomotiveStatus.ToList());
        }

        //
        // GET: /LocomotiveStatuses/Details/5

        public ActionResult Details(int id = 0)
        {
            LocomotiveStatus locomotivestatus = db.LocomotiveStatus.Find(id);
            if (locomotivestatus == null)
            {
                return HttpNotFound();
            }
            return View(locomotivestatus);
        }

        //
        // GET: /LocomotiveStatuses/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LocomotiveStatuses/Create

        [HttpPost]
        public ActionResult Create(LocomotiveStatus locomotivestatus)
        {
            if (ModelState.IsValid)
            {
                db.LocomotiveStatus.Add(locomotivestatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(locomotivestatus);
        }

        //
        // GET: /LocomotiveStatuses/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LocomotiveStatus locomotivestatus = db.LocomotiveStatus.Find(id);
            if (locomotivestatus == null)
            {
                return HttpNotFound();
            }
            return View(locomotivestatus);
        }

        //
        // POST: /LocomotiveStatuses/Edit/5

        [HttpPost]
        public ActionResult Edit(LocomotiveStatus locomotivestatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locomotivestatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locomotivestatus);
        }

        //
        // GET: /LocomotiveStatuses/Delete/5

        public ActionResult Delete(int id = 0)
        {
            LocomotiveStatus locomotivestatus = db.LocomotiveStatus.Find(id);
            if (locomotivestatus == null)
            {
                return HttpNotFound();
            }
            return View(locomotivestatus);
        }

        //
        // POST: /LocomotiveStatuses/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LocomotiveStatus locomotivestatus = db.LocomotiveStatus.Find(id);
            db.LocomotiveStatus.Remove(locomotivestatus);
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