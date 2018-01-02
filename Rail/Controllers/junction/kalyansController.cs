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
    public class kalyansController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: kalyans
        public ActionResult Index()
        {
            return View(db.kalyans.ToList());
        }

        // GET: kalyans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kalyan kalyan = db.kalyans.Find(id);
            if (kalyan == null)
            {
                return HttpNotFound();
            }
            return View(kalyan);
        }

        // GET: kalyans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: kalyans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] kalyan kalyan)
        {
            if (ModelState.IsValid)
            {
                db.kalyans.Add(kalyan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kalyan);
        }

        // GET: kalyans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kalyan kalyan = db.kalyans.Find(id);
            if (kalyan == null)
            {
                return HttpNotFound();
            }
            return View(kalyan);
        }

        // POST: kalyans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] kalyan kalyan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kalyan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kalyan);
        }

        // GET: kalyans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kalyan kalyan = db.kalyans.Find(id);
            if (kalyan == null)
            {
                return HttpNotFound();
            }
            return View(kalyan);
        }

        // POST: kalyans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kalyan kalyan = db.kalyans.Find(id);
            db.kalyans.Remove(kalyan);
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
