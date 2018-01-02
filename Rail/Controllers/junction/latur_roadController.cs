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
    public class latur_roadController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: latur_road
        public ActionResult Index()
        {
            return View(db.latur_road.ToList());
        }

        // GET: latur_road/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            latur_road latur_road = db.latur_road.Find(id);
            if (latur_road == null)
            {
                return HttpNotFound();
            }
            return View(latur_road);
        }

        // GET: latur_road/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: latur_road/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] latur_road latur_road)
        {
            if (ModelState.IsValid)
            {
                db.latur_road.Add(latur_road);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(latur_road);
        }

        // GET: latur_road/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            latur_road latur_road = db.latur_road.Find(id);
            if (latur_road == null)
            {
                return HttpNotFound();
            }
            return View(latur_road);
        }

        // POST: latur_road/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] latur_road latur_road)
        {
            if (ModelState.IsValid)
            {
                db.Entry(latur_road).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(latur_road);
        }

        // GET: latur_road/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            latur_road latur_road = db.latur_road.Find(id);
            if (latur_road == null)
            {
                return HttpNotFound();
            }
            return View(latur_road);
        }

        // POST: latur_road/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            latur_road latur_road = db.latur_road.Find(id);
            db.latur_road.Remove(latur_road);
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
