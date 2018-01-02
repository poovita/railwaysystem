using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rail.Models;

namespace Rail.Controllers.junction
{
    public class karjatsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: karjats
        public ActionResult Index()
        {
            return View(db.karjats.ToList());
        }

        // GET: karjats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            karjat karjat = db.karjats.Find(id);
            if (karjat == null)
            {
                return HttpNotFound();
            }
            return View(karjat);
        }

        // GET: karjats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: karjats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] karjat karjat)
        {
            if (ModelState.IsValid)
            {
                db.karjats.Add(karjat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(karjat);
        }

        // GET: karjats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            karjat karjat = db.karjats.Find(id);
            if (karjat == null)
            {
                return HttpNotFound();
            }
            return View(karjat);
        }

        // POST: karjats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] karjat karjat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(karjat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(karjat);
        }

        // GET: karjats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            karjat karjat = db.karjats.Find(id);
            if (karjat == null)
            {
                return HttpNotFound();
            }
            return View(karjat);
        }

        // POST: karjats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            karjat karjat = db.karjats.Find(id);
            db.karjats.Remove(karjat);
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
