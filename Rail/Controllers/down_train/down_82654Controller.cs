using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rail.Models;

namespace Rail.Controllers.down_train
{
    public class down_82654Controller : Controller
    {
        private down_trainEntities4 db = new down_trainEntities4();

        // GET: down_82654
        public ActionResult Index()
        {
            return View(db.down_82654.ToList());
        }

        // GET: down_82654/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_82654 down_82654 = db.down_82654.Find(id);
            if (down_82654 == null)
            {
                return HttpNotFound();
            }
            return View(down_82654);
        }

        // GET: down_82654/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: down_82654/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_82654 down_82654)
        {
            if (ModelState.IsValid)
            {
                db.down_82654.Add(down_82654);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(down_82654);
        }

        // GET: down_82654/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_82654 down_82654 = db.down_82654.Find(id);
            if (down_82654 == null)
            {
                return HttpNotFound();
            }
            return View(down_82654);
        }

        // POST: down_82654/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_82654 down_82654)
        {
            if (ModelState.IsValid)
            {
                db.Entry(down_82654).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(down_82654);
        }

        // GET: down_82654/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_82654 down_82654 = db.down_82654.Find(id);
            if (down_82654 == null)
            {
                return HttpNotFound();
            }
            return View(down_82654);
        }

        // POST: down_82654/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            down_82654 down_82654 = db.down_82654.Find(id);
            db.down_82654.Remove(down_82654);
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
