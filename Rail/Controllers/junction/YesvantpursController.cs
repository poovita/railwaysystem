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
    public class YesvantpursController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: Yesvantpurs
        public ActionResult Index()
        {
            return View(db.Yesvantpurs.ToList());
        }

        // GET: Yesvantpurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yesvantpur yesvantpur = db.Yesvantpurs.Find(id);
            if (yesvantpur == null)
            {
                return HttpNotFound();
            }
            return View(yesvantpur);
        }

        // GET: Yesvantpurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yesvantpurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] Yesvantpur yesvantpur)
        {
            if (ModelState.IsValid)
            {
                db.Yesvantpurs.Add(yesvantpur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yesvantpur);
        }

        // GET: Yesvantpurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yesvantpur yesvantpur = db.Yesvantpurs.Find(id);
            if (yesvantpur == null)
            {
                return HttpNotFound();
            }
            return View(yesvantpur);
        }

        // POST: Yesvantpurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] Yesvantpur yesvantpur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yesvantpur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yesvantpur);
        }

        // GET: Yesvantpurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yesvantpur yesvantpur = db.Yesvantpurs.Find(id);
            if (yesvantpur == null)
            {
                return HttpNotFound();
            }
            return View(yesvantpur);
        }

        // POST: Yesvantpurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Yesvantpur yesvantpur = db.Yesvantpurs.Find(id);
            db.Yesvantpurs.Remove(yesvantpur);
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
