using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rail.Models;

namespace Rail.Controllers.train
{
    public class Station_CodeController : Controller
    {
        private trainEntities db = new trainEntities();

        // GET: Station_Code
        public ActionResult Index()
        {
            return View(db.Station_Code.ToList());
        }

        // GET: Station_Code/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Station_Code station_Code = db.Station_Code.Find(id);
            if (station_Code == null)
            {
                return HttpNotFound();
            }
            return View(station_Code);
        }

        // GET: Station_Code/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Station_Code/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Station_Code1,Station_name,longitude,latitude")] Station_Code station_Code)
        {
            if (ModelState.IsValid)
            {
                db.Station_Code.Add(station_Code);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(station_Code);
        }

        // GET: Station_Code/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Station_Code station_Code = db.Station_Code.Find(id);
            if (station_Code == null)
            {
                return HttpNotFound();
            }
            return View(station_Code);
        }

        // POST: Station_Code/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Station_Code1,Station_name,longitude,latitude")] Station_Code station_Code)
        {
            if (ModelState.IsValid)
            {
                db.Entry(station_Code).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(station_Code);
        }

        // GET: Station_Code/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Station_Code station_Code = db.Station_Code.Find(id);
            if (station_Code == null)
            {
                return HttpNotFound();
            }
            return View(station_Code);
        }

        // POST: Station_Code/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Station_Code station_Code = db.Station_Code.Find(id);
            db.Station_Code.Remove(station_Code);
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
