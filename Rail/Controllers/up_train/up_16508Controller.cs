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
    public class up_16508Controller : Controller
    {
        private up_trainEntities2 db = new up_trainEntities2();

        // GET: up_16508
        public ActionResult Index()
        {
            return View(db.up_16508.ToList());
        }

        // GET: up_16508/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_16508 up_16508 = db.up_16508.Find(id);
            if (up_16508 == null)
            {
                return HttpNotFound();
            }
            return View(up_16508);
        }

        // GET: up_16508/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: up_16508/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_16508 up_16508)
        {
            if (ModelState.IsValid)
            {
                db.up_16508.Add(up_16508);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(up_16508);
        }

        // GET: up_16508/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_16508 up_16508 = db.up_16508.Find(id);
            if (up_16508 == null)
            {
                return HttpNotFound();
            }
            return View(up_16508);
        }

        // POST: up_16508/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_16508 up_16508)
        {
            if (ModelState.IsValid)
            {
                db.Entry(up_16508).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(up_16508);
        }

        // GET: up_16508/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_16508 up_16508 = db.up_16508.Find(id);
            if (up_16508 == null)
            {
                return HttpNotFound();
            }
            return View(up_16508);
        }

        // POST: up_16508/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            up_16508 up_16508 = db.up_16508.Find(id);
            db.up_16508.Remove(up_16508);
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
