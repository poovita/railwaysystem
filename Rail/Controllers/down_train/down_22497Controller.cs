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
    public class down_22497Controller : Controller
    {
        private down_trainEntities4 db = new down_trainEntities4();

        // GET: down_22497
        public ActionResult Index()
        {
            return View(db.down_22497.ToList());
        }

        // GET: down_22497/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_22497 down_22497 = db.down_22497.Find(id);
            if (down_22497 == null)
            {
                return HttpNotFound();
            }
            return View(down_22497);
        }

        // GET: down_22497/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: down_22497/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_22497 down_22497)
        {
            if (ModelState.IsValid)
            {
                db.down_22497.Add(down_22497);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(down_22497);
        }

        // GET: down_22497/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_22497 down_22497 = db.down_22497.Find(id);
            if (down_22497 == null)
            {
                return HttpNotFound();
            }
            return View(down_22497);
        }

        // POST: down_22497/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_22497 down_22497)
        {
            if (ModelState.IsValid)
            {
                db.Entry(down_22497).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(down_22497);
        }

        // GET: down_22497/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_22497 down_22497 = db.down_22497.Find(id);
            if (down_22497 == null)
            {
                return HttpNotFound();
            }
            return View(down_22497);
        }

        // POST: down_22497/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            down_22497 down_22497 = db.down_22497.Find(id);
            db.down_22497.Remove(down_22497);
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
