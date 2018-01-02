using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rail.Models;

namespace Rail.Controllers.train
{
    public class track_priorityController : Controller
    {
        private trainEntities db = new trainEntities();

        // GET: track_priority
        public ActionResult Index()
        {
            return View(db.track_priority.ToList());
        }

        // GET: track_priority/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            track_priority track_priority = db.track_priority.Find(id);
            if (track_priority == null)
            {
                return HttpNotFound();
            }
            return View(track_priority);
        }

        // GET: track_priority/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: track_priority/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Priorities,track_status")] track_priority track_priority)
        {
            if (ModelState.IsValid)
            {
                db.track_priority.Add(track_priority);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(track_priority);
        }

        // GET: track_priority/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            track_priority track_priority = db.track_priority.Find(id);
            if (track_priority == null)
            {
                return HttpNotFound();
            }
            return View(track_priority);
        }

        // POST: track_priority/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Priorities,track_status")] track_priority track_priority)
        {
            if (ModelState.IsValid)
            {
                db.Entry(track_priority).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(track_priority);
        }

        // GET: track_priority/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            track_priority track_priority = db.track_priority.Find(id);
            if (track_priority == null)
            {
                return HttpNotFound();
            }
            return View(track_priority);
        }

        // POST: track_priority/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            track_priority track_priority = db.track_priority.Find(id);
            db.track_priority.Remove(track_priority);
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
