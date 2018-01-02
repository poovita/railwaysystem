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
    public class up_11022Controller : Controller
    {
        private up_trainEntities2 db = new up_trainEntities2();

        // GET: up_11022
        public ActionResult Index()
        {
            return View(db.up_11022.ToList());
        }

        // GET: up_11022/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_11022 up_11022 = db.up_11022.Find(id);
            if (up_11022 == null)
            {
                return HttpNotFound();
            }
            return View(up_11022);
        }

        // GET: up_11022/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: up_11022/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_11022 up_11022)
        {
            if (ModelState.IsValid)
            {
                db.up_11022.Add(up_11022);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(up_11022);
        }

        // GET: up_11022/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_11022 up_11022 = db.up_11022.Find(id);
            if (up_11022 == null)
            {
                return HttpNotFound();
            }
            return View(up_11022);
        }

        // POST: up_11022/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_11022 up_11022)
        {
            if (ModelState.IsValid)
            {
                db.Entry(up_11022).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(up_11022);
        }

        // GET: up_11022/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_11022 up_11022 = db.up_11022.Find(id);
            if (up_11022 == null)
            {
                return HttpNotFound();
            }
            return View(up_11022);
        }

        // POST: up_11022/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            up_11022 up_11022 = db.up_11022.Find(id);
            db.up_11022.Remove(up_11022);
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
