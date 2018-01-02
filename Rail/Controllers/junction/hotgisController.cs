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
    public class hotgisController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: hotgis
        public ActionResult Index()
        {
            return View(db.hotgis.ToList());
        }

        // GET: hotgis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hotgi hotgi = db.hotgis.Find(id);
            if (hotgi == null)
            {
                return HttpNotFound();
            }
            return View(hotgi);
        }

        // GET: hotgis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hotgis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] hotgi hotgi)
        {
            if (ModelState.IsValid)
            {
                db.hotgis.Add(hotgi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hotgi);
        }

        // GET: hotgis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hotgi hotgi = db.hotgis.Find(id);
            if (hotgi == null)
            {
                return HttpNotFound();
            }
            return View(hotgi);
        }

        // POST: hotgis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] hotgi hotgi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotgi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotgi);
        }

        // GET: hotgis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hotgi hotgi = db.hotgis.Find(id);
            if (hotgi == null)
            {
                return HttpNotFound();
            }
            return View(hotgi);
        }

        // POST: hotgis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hotgi hotgi = db.hotgis.Find(id);
            db.hotgis.Remove(hotgi);
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
