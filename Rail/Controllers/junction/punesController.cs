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
    public class punesController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: punes
        public ActionResult Index()
        {
            return View(db.punes.ToList());
        }

        // GET: punes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pune pune = db.punes.Find(id);
            if (pune == null)
            {
                return HttpNotFound();
            }
            return View(pune);
        }

        // GET: punes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: punes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] pune pune)
        {
            if (ModelState.IsValid)
            {
                db.punes.Add(pune);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pune);
        }

        // GET: punes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pune pune = db.punes.Find(id);
            if (pune == null)
            {
                return HttpNotFound();
            }
            return View(pune);
        }

        // POST: punes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] pune pune)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pune).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pune);
        }

        // GET: punes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pune pune = db.punes.Find(id);
            if (pune == null)
            {
                return HttpNotFound();
            }
            return View(pune);
        }

        // POST: punes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pune pune = db.punes.Find(id);
            db.punes.Remove(pune);
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
