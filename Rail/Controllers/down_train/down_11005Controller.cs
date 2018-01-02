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
    public class down_11005Controller : Controller
    {
        private down_trainEntities4 db = new down_trainEntities4();

        // GET: down_11005
        public ActionResult Index()
        {
            return View(db.down_11005.ToList());
        }

        // GET: down_11005/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_11005 down_11005 = db.down_11005.Find(id);
            if (down_11005 == null)
            {
                return HttpNotFound();
            }
            return View(down_11005);
        }

        // GET: down_11005/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: down_11005/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_11005 down_11005)
        {
            if (ModelState.IsValid)
            {
                db.down_11005.Add(down_11005);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(down_11005);
        }

        // GET: down_11005/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_11005 down_11005 = db.down_11005.Find(id);
            if (down_11005 == null)
            {
                return HttpNotFound();
            }
            return View(down_11005);
        }

        // POST: down_11005/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_11005 down_11005)
        {
            if (ModelState.IsValid)
            {
                db.Entry(down_11005).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(down_11005);
        }

        // GET: down_11005/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_11005 down_11005 = db.down_11005.Find(id);
            if (down_11005 == null)
            {
                return HttpNotFound();
            }
            return View(down_11005);
        }

        // POST: down_11005/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            down_11005 down_11005 = db.down_11005.Find(id);
            db.down_11005.Remove(down_11005);
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
