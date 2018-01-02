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
    public class vasai_roadController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: vasai_road
        public ActionResult Index()
        {
            return View(db.vasai_road.ToList());
        }

        // GET: vasai_road/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vasai_road vasai_road = db.vasai_road.Find(id);
            if (vasai_road == null)
            {
                return HttpNotFound();
            }
            return View(vasai_road);
        }

        // GET: vasai_road/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vasai_road/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] vasai_road vasai_road)
        {
            if (ModelState.IsValid)
            {
                db.vasai_road.Add(vasai_road);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vasai_road);
        }

        // GET: vasai_road/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vasai_road vasai_road = db.vasai_road.Find(id);
            if (vasai_road == null)
            {
                return HttpNotFound();
            }
            return View(vasai_road);
        }

        // POST: vasai_road/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] vasai_road vasai_road)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vasai_road).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vasai_road);
        }

        // GET: vasai_road/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vasai_road vasai_road = db.vasai_road.Find(id);
            if (vasai_road == null)
            {
                return HttpNotFound();
            }
            return View(vasai_road);
        }

        // POST: vasai_road/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vasai_road vasai_road = db.vasai_road.Find(id);
            db.vasai_road.Remove(vasai_road);
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
