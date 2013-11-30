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
    public class TrainTypesController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /TrainTypes/

        public ActionResult Index()
        {
            return View(db.TrainTypes.ToList());
        }

        //
        // GET: /TrainTypes/Details/5

        public ActionResult Details(int id = 0)
        {
            TrainType traintype = db.TrainTypes.Find(id);
            if (traintype == null)
            {
                return HttpNotFound();
            }
            return View(traintype);
        }

        //
        // GET: /TrainTypes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TrainTypes/Create

        [HttpPost]
        public ActionResult Create(TrainType traintype)
        {
            if (ModelState.IsValid)
            {
                db.TrainTypes.Add(traintype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(traintype);
        }

        //
        // GET: /TrainTypes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TrainType traintype = db.TrainTypes.Find(id);
            if (traintype == null)
            {
                return HttpNotFound();
            }
            return View(traintype);
        }

        //
        // POST: /TrainTypes/Edit/5

        [HttpPost]
        public ActionResult Edit(TrainType traintype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traintype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(traintype);
        }

        //
        // GET: /TrainTypes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TrainType traintype = db.TrainTypes.Find(id);
            if (traintype == null)
            {
                return HttpNotFound();
            }
            return View(traintype);
        }

        //
        // POST: /TrainTypes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TrainType traintype = db.TrainTypes.Find(id);
            db.TrainTypes.Remove(traintype);
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