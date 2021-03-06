﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rail.Models;

namespace Rail.Controllers.up_train
{
    public class up_22498Controller : Controller
    {
        private up_trainEntities2 db = new up_trainEntities2();

        // GET: up_22498
        public ActionResult Index()
        {
            return View(db.up_22498.ToList());
        }

        // GET: up_22498/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_22498 up_22498 = db.up_22498.Find(id);
            if (up_22498 == null)
            {
                return HttpNotFound();
            }
            return View(up_22498);
        }

        // GET: up_22498/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: up_22498/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_22498 up_22498)
        {
            if (ModelState.IsValid)
            {
                db.up_22498.Add(up_22498);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(up_22498);
        }

        // GET: up_22498/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_22498 up_22498 = db.up_22498.Find(id);
            if (up_22498 == null)
            {
                return HttpNotFound();
            }
            return View(up_22498);
        }

        // POST: up_22498/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sr_no,Station_code,Arrival,Departure,Distance,Day")] up_22498 up_22498)
        {
            if (ModelState.IsValid)
            {
                db.Entry(up_22498).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(up_22498);
        }

        // GET: up_22498/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            up_22498 up_22498 = db.up_22498.Find(id);
            if (up_22498 == null)
            {
                return HttpNotFound();
            }
            return View(up_22498);
        }

        // POST: up_22498/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            up_22498 up_22498 = db.up_22498.Find(id);
            db.up_22498.Remove(up_22498);
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
