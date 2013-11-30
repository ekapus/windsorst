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
    public class IndustriesController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /Industries/

        public ActionResult Index()
        {
            return View(db.Industries.ToList());
        }

        //
        // GET: /Industries/Details/5

        public ActionResult Details(int id = 0)
        {
            Industry industry = db.Industries.Find(id);
            if (industry == null)
            {
                return HttpNotFound();
            }
            return View(industry);
        }

        //
        // GET: /Industries/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Industries/Create

        [HttpPost]
        public ActionResult Create(Industry industry)
        {
            if (ModelState.IsValid)
            {
                db.Industries.Add(industry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(industry);
        }

        //
        // GET: /Industries/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Industry industry = db.Industries.Find(id);
            if (industry == null)
            {
                return HttpNotFound();
            }
            return View(industry);
        }

        //
        // POST: /Industries/Edit/5

        [HttpPost]
        public ActionResult Edit(Industry industry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(industry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(industry);
        }

        //
        // GET: /Industries/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Industry industry = db.Industries.Find(id);
            if (industry == null)
            {
                return HttpNotFound();
            }
            return View(industry);
        }

        //
        // POST: /Industries/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Industry industry = db.Industries.Find(id);
            db.Industries.Remove(industry);
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