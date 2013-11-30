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
    public class BlockController : Controller
    {
        private WindsorStDBContext db = new WindsorStDBContext();

        //
        // GET: /Block/

        public ActionResult Index()
        {
            return View(db.Blocks.ToList());
        }

        //
        // GET: /Block/Details/5

        public ActionResult Details(int id = 0)
        {
            Block block = db.Blocks.Find(id);
            if (block == null)
            {
                return HttpNotFound();
            }
            return View(block);
        }

        //
        // GET: /Block/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Block/Create

        [HttpPost]
        public ActionResult Create(Block block)
        {
            if (ModelState.IsValid)
            {
                db.Blocks.Add(block);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(block);
        }

        //
        // GET: /Block/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Block block = db.Blocks.Find(id);
            if (block == null)
            {
                return HttpNotFound();
            }
            return View(block);
        }

        //
        // POST: /Block/Edit/5

        [HttpPost]
        public ActionResult Edit(Block block)
        {
            if (ModelState.IsValid)
            {
                db.Entry(block).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(block);
        }

        //
        // GET: /Block/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Block block = db.Blocks.Find(id);
            if (block == null)
            {
                return HttpNotFound();
            }
            return View(block);
        }

        //
        // POST: /Block/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Block block = db.Blocks.Find(id);
            db.Blocks.Remove(block);
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