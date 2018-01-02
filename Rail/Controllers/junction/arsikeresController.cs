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
    public class arsikeresController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: arsikeres
        public ActionResult Index()
        {
            return View(db.arsikeres.ToList());
        }

        // GET: arsikeres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arsikere arsikere = db.arsikeres.Find(id);
            if (arsikere == null)
            {
                return HttpNotFound();
            }
            return View(arsikere);
        }

        // GET: arsikeres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: arsikeres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] arsikere arsikere)
        {
            if (ModelState.IsValid)
            {
                db.arsikeres.Add(arsikere);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arsikere);
        }

        // GET: arsikeres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arsikere arsikere = db.arsikeres.Find(id);
            if (arsikere == null)
            {
                return HttpNotFound();
            }
            return View(arsikere);
        }

        // POST: arsikeres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] arsikere arsikere)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arsikere).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arsikere);
        }

        // GET: arsikeres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arsikere arsikere = db.arsikeres.Find(id);
            if (arsikere == null)
            {
                return HttpNotFound();
            }
            return View(arsikere);
        }

        // POST: arsikeres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            arsikere arsikere = db.arsikeres.Find(id);
            db.arsikeres.Remove(arsikere);
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
