﻿using System;
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
    public class guntkalsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: guntkals
        public ActionResult Index()
        {
            return View(db.guntkals.ToList());
        }

        // GET: guntkals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            guntkal guntkal = db.guntkals.Find(id);
            if (guntkal == null)
            {
                return HttpNotFound();
            }
            return View(guntkal);
        }

        // GET: guntkals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: guntkals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] guntkal guntkal)
        {
            if (ModelState.IsValid)
            {
                db.guntkals.Add(guntkal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guntkal);
        }

        // GET: guntkals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            guntkal guntkal = db.guntkals.Find(id);
            if (guntkal == null)
            {
                return HttpNotFound();
            }
            return View(guntkal);
        }

        // POST: guntkals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] guntkal guntkal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guntkal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guntkal);
        }

        // GET: guntkals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            guntkal guntkal = db.guntkals.Find(id);
            if (guntkal == null)
            {
                return HttpNotFound();
            }
            return View(guntkal);
        }

        // POST: guntkals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            guntkal guntkal = db.guntkals.Find(id);
            db.guntkals.Remove(guntkal);
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
