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
    public class down_16588Controller : Controller
    {
        private down_trainEntities4 db = new down_trainEntities4();

        // GET: down_16588
        public ActionResult Index()
        {
            return View(db.down_16588.ToList());
        }

        // GET: down_16588/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_16588 down_16588 = db.down_16588.Find(id);
            if (down_16588 == null)
            {
                return HttpNotFound();
            }
            return View(down_16588);
        }

        // GET: down_16588/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: down_16588/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_16588 down_16588)
        {
            if (ModelState.IsValid)
            {
                db.down_16588.Add(down_16588);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(down_16588);
        }

        // GET: down_16588/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_16588 down_16588 = db.down_16588.Find(id);
            if (down_16588 == null)
            {
                return HttpNotFound();
            }
            return View(down_16588);
        }

        // POST: down_16588/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] down_16588 down_16588)
        {
            if (ModelState.IsValid)
            {
                db.Entry(down_16588).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(down_16588);
        }

        // GET: down_16588/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            down_16588 down_16588 = db.down_16588.Find(id);
            if (down_16588 == null)
            {
                return HttpNotFound();
            }
            return View(down_16588);
        }

        // POST: down_16588/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            down_16588 down_16588 = db.down_16588.Find(id);
            db.down_16588.Remove(down_16588);
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
