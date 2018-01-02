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
    public class vikarabadsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: vikarabads
        public ActionResult Index()
        {
            return View(db.vikarabads.ToList());
        }

        // GET: vikarabads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vikarabad vikarabad = db.vikarabads.Find(id);
            if (vikarabad == null)
            {
                return HttpNotFound();
            }
            return View(vikarabad);
        }

        // GET: vikarabads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vikarabads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] vikarabad vikarabad)
        {
            if (ModelState.IsValid)
            {
                db.vikarabads.Add(vikarabad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vikarabad);
        }

        // GET: vikarabads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vikarabad vikarabad = db.vikarabads.Find(id);
            if (vikarabad == null)
            {
                return HttpNotFound();
            }
            return View(vikarabad);
        }

        // POST: vikarabads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] vikarabad vikarabad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vikarabad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vikarabad);
        }

        // GET: vikarabads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vikarabad vikarabad = db.vikarabads.Find(id);
            if (vikarabad == null)
            {
                return HttpNotFound();
            }
            return View(vikarabad);
        }

        // POST: vikarabads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vikarabad vikarabad = db.vikarabads.Find(id);
            db.vikarabads.Remove(vikarabad);
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
