using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rail.Models;

namespace Rail.Controllers.up_train
{
    public class up_82653Controller : Controller
    {
        private up_trainEntities2 db = new up_trainEntities2();

        // GET: up_82653
        public ActionResult Index()
        {
            return View(db.up_82653.ToList());
        }

        // GET: up_82653/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_82653 up_82653 = db.up_82653.Find(id);
            if (up_82653 == null)
            {
                return HttpNotFound();
            }
            return View(up_82653);
        }

        // GET: up_82653/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: up_82653/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_82653 up_82653)
        {
            if (ModelState.IsValid)
            {
                db.up_82653.Add(up_82653);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(up_82653);
        }

        // GET: up_82653/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_82653 up_82653 = db.up_82653.Find(id);
            if (up_82653 == null)
            {
                return HttpNotFound();
            }
            return View(up_82653);
        }

        // POST: up_82653/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_82653 up_82653)
        {
            if (ModelState.IsValid)
            {
                db.Entry(up_82653).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(up_82653);
        }

        // GET: up_82653/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_82653 up_82653 = db.up_82653.Find(id);
            if (up_82653 == null)
            {
                return HttpNotFound();
            }
            return View(up_82653);
        }

        // POST: up_82653/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            up_82653 up_82653 = db.up_82653.Find(id);
            db.up_82653.Remove(up_82653);
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
