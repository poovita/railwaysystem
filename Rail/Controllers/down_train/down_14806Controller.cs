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
    public class down_14806Controller : Controller
    {
        private down_trainEntities4 db = new down_trainEntities4();

        // GET: down_14806
        public ActionResult Index()
        {
            return View(db.down_14806.ToList());
        }

        // GET: down_14806/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_14806 down_14806 = db.down_14806.Find(id);
            if (down_14806 == null)
            {
                return HttpNotFound();
            }
            return View(down_14806);
        }

        // GET: down_14806/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: down_14806/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_14806 down_14806)
        {
            if (ModelState.IsValid)
            {
                db.down_14806.Add(down_14806);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(down_14806);
        }

        // GET: down_14806/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_14806 down_14806 = db.down_14806.Find(id);
            if (down_14806 == null)
            {
                return HttpNotFound();
            }
            return View(down_14806);
        }

        // POST: down_14806/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_14806 down_14806)
        {
            if (ModelState.IsValid)
            {
                db.Entry(down_14806).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(down_14806);
        }

        // GET: down_14806/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_14806 down_14806 = db.down_14806.Find(id);
            if (down_14806 == null)
            {
                return HttpNotFound();
            }
            return View(down_14806);
        }

        // POST: down_14806/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            down_14806 down_14806 = db.down_14806.Find(id);
            db.down_14806.Remove(down_14806);
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
