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
    public class londasController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: londas
        public ActionResult Index()
        {
            return View(db.londas.ToList());
        }

        // GET: londas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            londa londa = db.londas.Find(id);
            if (londa == null)
            {
                return HttpNotFound();
            }
            return View(londa);
        }

        // GET: londas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: londas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] londa londa)
        {
            if (ModelState.IsValid)
            {
                db.londas.Add(londa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(londa);
        }

        // GET: londas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            londa londa = db.londas.Find(id);
            if (londa == null)
            {
                return HttpNotFound();
            }
            return View(londa);
        }

        // POST: londas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] londa londa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(londa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(londa);
        }

        // GET: londas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            londa londa = db.londas.Find(id);
            if (londa == null)
            {
                return HttpNotFound();
            }
            return View(londa);
        }

        // POST: londas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            londa londa = db.londas.Find(id);
            db.londas.Remove(londa);
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
