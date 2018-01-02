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
    public class bellariesController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: bellaries
        public ActionResult Index()
        {
            return View(db.bellaries.ToList());
        }

        // GET: bellaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bellary bellary = db.bellaries.Find(id);
            if (bellary == null)
            {
                return HttpNotFound();
            }
            return View(bellary);
        }

        // GET: bellaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: bellaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] bellary bellary)
        {
            if (ModelState.IsValid)
            {
                db.bellaries.Add(bellary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bellary);
        }

        // GET: bellaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bellary bellary = db.bellaries.Find(id);
            if (bellary == null)
            {
                return HttpNotFound();
            }
            return View(bellary);
        }

        // POST: bellaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] bellary bellary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bellary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bellary);
        }

        // GET: bellaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bellary bellary = db.bellaries.Find(id);
            if (bellary == null)
            {
                return HttpNotFound();
            }
            return View(bellary);
        }

        // POST: bellaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bellary bellary = db.bellaries.Find(id);
            db.bellaries.Remove(bellary);
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
