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
    public class LocomotivesController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /Locomotives/

        public ActionResult Index()
        {
            return View(db.Locomotives.ToList());
        }

        //
        // GET: /Locomotives/Details/5

        public ActionResult Details(int id = 0)
        {
            Locomotive locomotive = db.Locomotives.Find(id);
            if (locomotive == null)
            {
                return HttpNotFound();
            }
            return View(locomotive);
        }

        //
        // GET: /Locomotives/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Locomotives/Create

        [HttpPost]
        public ActionResult Create(Locomotive locomotive)
        {
            if (ModelState.IsValid)
            {
                db.Locomotives.Add(locomotive);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(locomotive);
        }

        //
        // GET: /Locomotives/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Locomotive locomotive = db.Locomotives.Find(id);
            if (locomotive == null)
            {
                return HttpNotFound();
            }
            return View(locomotive);
        }

        //
        // POST: /Locomotives/Edit/5

        [HttpPost]
        public ActionResult Edit(Locomotive locomotive)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locomotive).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locomotive);
        }

        //
        // GET: /Locomotives/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Locomotive locomotive = db.Locomotives.Find(id);
            if (locomotive == null)
            {
                return HttpNotFound();
            }
            return View(locomotive);
        }

        //
        // POST: /Locomotives/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Locomotive locomotive = db.Locomotives.Find(id);
            db.Locomotives.Remove(locomotive);
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