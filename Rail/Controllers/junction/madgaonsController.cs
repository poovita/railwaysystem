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
    public class madgaonsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: madgaons
        public ActionResult Index()
        {
            return View(db.madgaons.ToList());
        }

        // GET: madgaons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            madgaon madgaon = db.madgaons.Find(id);
            if (madgaon == null)
            {
                return HttpNotFound();
            }
            return View(madgaon);
        }

        // GET: madgaons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: madgaons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] madgaon madgaon)
        {
            if (ModelState.IsValid)
            {
                db.madgaons.Add(madgaon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(madgaon);
        }

        // GET: madgaons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            madgaon madgaon = db.madgaons.Find(id);
            if (madgaon == null)
            {
                return HttpNotFound();
            }
            return View(madgaon);
        }

        // POST: madgaons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] madgaon madgaon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(madgaon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(madgaon);
        }

        // GET: madgaons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            madgaon madgaon = db.madgaons.Find(id);
            if (madgaon == null)
            {
                return HttpNotFound();
            }
            return View(madgaon);
        }

        // POST: madgaons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            madgaon madgaon = db.madgaons.Find(id);
            db.madgaons.Remove(madgaon);
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
