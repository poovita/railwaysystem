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
    public class panvelsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: panvels
        public ActionResult Index()
        {
            return View(db.panvels.ToList());
        }

        // GET: panvels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panvel panvel = db.panvels.Find(id);
            if (panvel == null)
            {
                return HttpNotFound();
            }
            return View(panvel);
        }

        // GET: panvels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: panvels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] panvel panvel)
        {
            if (ModelState.IsValid)
            {
                db.panvels.Add(panvel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(panvel);
        }

        // GET: panvels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panvel panvel = db.panvels.Find(id);
            if (panvel == null)
            {
                return HttpNotFound();
            }
            return View(panvel);
        }

        // POST: panvels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] panvel panvel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(panvel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(panvel);
        }

        // GET: panvels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panvel panvel = db.panvels.Find(id);
            if (panvel == null)
            {
                return HttpNotFound();
            }
            return View(panvel);
        }

        // POST: panvels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            panvel panvel = db.panvels.Find(id);
            db.panvels.Remove(panvel);
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
