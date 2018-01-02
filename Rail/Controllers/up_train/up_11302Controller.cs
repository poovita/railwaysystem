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
    public class up_11302Controller : Controller
    {
        private up_trainEntities2 db = new up_trainEntities2();

        // GET: up_11302
        public ActionResult Index()
        {
            return View(db.up_11302.ToList());
        }

        // GET: up_11302/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_11302 up_11302 = db.up_11302.Find(id);
            if (up_11302 == null)
            {
                return HttpNotFound();
            }
            return View(up_11302);
        }

        // GET: up_11302/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: up_11302/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_11302 up_11302)
        {
            if (ModelState.IsValid)
            {
                db.up_11302.Add(up_11302);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(up_11302);
        }

        // GET: up_11302/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_11302 up_11302 = db.up_11302.Find(id);
            if (up_11302 == null)
            {
                return HttpNotFound();
            }
            return View(up_11302);
        }

        // POST: up_11302/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_11302 up_11302)
        {
            if (ModelState.IsValid)
            {
                db.Entry(up_11302).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(up_11302);
        }

        // GET: up_11302/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_11302 up_11302 = db.up_11302.Find(id);
            if (up_11302 == null)
            {
                return HttpNotFound();
            }
            return View(up_11302);
        }

        // POST: up_11302/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            up_11302 up_11302 = db.up_11302.Find(id);
            db.up_11302.Remove(up_11302);
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
