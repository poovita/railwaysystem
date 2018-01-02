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
    public class kuruduvadisController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: kuruduvadis
        public ActionResult Index()
        {
            return View(db.kuruduvadis.ToList());
        }

        // GET: kuruduvadis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kuruduvadi kuruduvadi = db.kuruduvadis.Find(id);
            if (kuruduvadi == null)
            {
                return HttpNotFound();
            }
            return View(kuruduvadi);
        }

        // GET: kuruduvadis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: kuruduvadis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] kuruduvadi kuruduvadi)
        {
            if (ModelState.IsValid)
            {
                db.kuruduvadis.Add(kuruduvadi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kuruduvadi);
        }

        // GET: kuruduvadis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kuruduvadi kuruduvadi = db.kuruduvadis.Find(id);
            if (kuruduvadi == null)
            {
                return HttpNotFound();
            }
            return View(kuruduvadi);
        }

        // POST: kuruduvadis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] kuruduvadi kuruduvadi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kuruduvadi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kuruduvadi);
        }

        // GET: kuruduvadis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kuruduvadi kuruduvadi = db.kuruduvadis.Find(id);
            if (kuruduvadi == null)
            {
                return HttpNotFound();
            }
            return View(kuruduvadi);
        }

        // POST: kuruduvadis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kuruduvadi kuruduvadi = db.kuruduvadis.Find(id);
            db.kuruduvadis.Remove(kuruduvadi);
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
