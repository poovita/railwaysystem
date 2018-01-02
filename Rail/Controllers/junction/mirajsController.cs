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
    public class mirajsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: mirajs
        public ActionResult Index()
        {
            return View(db.mirajs.ToList());
        }

        // GET: mirajs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            miraj miraj = db.mirajs.Find(id);
            if (miraj == null)
            {
                return HttpNotFound();
            }
            return View(miraj);
        }

        // GET: mirajs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mirajs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] miraj miraj)
        {
            if (ModelState.IsValid)
            {
                db.mirajs.Add(miraj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(miraj);
        }

        // GET: mirajs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            miraj miraj = db.mirajs.Find(id);
            if (miraj == null)
            {
                return HttpNotFound();
            }
            return View(miraj);
        }

        // POST: mirajs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] miraj miraj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(miraj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(miraj);
        }

        // GET: mirajs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            miraj miraj = db.mirajs.Find(id);
            if (miraj == null)
            {
                return HttpNotFound();
            }
            return View(miraj);
        }

        // POST: mirajs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            miraj miraj = db.mirajs.Find(id);
            db.mirajs.Remove(miraj);
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
