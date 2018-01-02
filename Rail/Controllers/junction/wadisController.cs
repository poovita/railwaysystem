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
    public class wadisController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: wadis
        public ActionResult Index()
        {
            return View(db.wadis.ToList());
        }

        // GET: wadis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wadi wadi = db.wadis.Find(id);
            if (wadi == null)
            {
                return HttpNotFound();
            }
            return View(wadi);
        }

        // GET: wadis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: wadis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] wadi wadi)
        {
            if (ModelState.IsValid)
            {
                db.wadis.Add(wadi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wadi);
        }

        // GET: wadis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wadi wadi = db.wadis.Find(id);
            if (wadi == null)
            {
                return HttpNotFound();
            }
            return View(wadi);
        }

        // POST: wadis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] wadi wadi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wadi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wadi);
        }

        // GET: wadis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wadi wadi = db.wadis.Find(id);
            if (wadi == null)
            {
                return HttpNotFound();
            }
            return View(wadi);
        }

        // POST: wadis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            wadi wadi = db.wadis.Find(id);
            db.wadis.Remove(wadi);
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
