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
    public class up_14805Controller : Controller
    {
        private up_trainEntities2 db = new up_trainEntities2();

        // GET: up_14805
        public ActionResult Index()
        {
            return View(db.up_14805.ToList());
        }

        // GET: up_14805/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_14805 up_14805 = db.up_14805.Find(id);
            if (up_14805 == null)
            {
                return HttpNotFound();
            }
            return View(up_14805);
        }

        // GET: up_14805/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: up_14805/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_14805 up_14805)
        {
            if (ModelState.IsValid)
            {
                db.up_14805.Add(up_14805);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(up_14805);
        }

        // GET: up_14805/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_14805 up_14805 = db.up_14805.Find(id);
            if (up_14805 == null)
            {
                return HttpNotFound();
            }
            return View(up_14805);
        }

        // POST: up_14805/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_14805 up_14805)
        {
            if (ModelState.IsValid)
            {
                db.Entry(up_14805).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(up_14805);
        }

        // GET: up_14805/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_14805 up_14805 = db.up_14805.Find(id);
            if (up_14805 == null)
            {
                return HttpNotFound();
            }
            return View(up_14805);
        }

        // POST: up_14805/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            up_14805 up_14805 = db.up_14805.Find(id);
            db.up_14805.Remove(up_14805);
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
