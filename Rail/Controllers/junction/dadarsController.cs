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
    public class dadarsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: dadars
        public ActionResult Index()
        {
            return View(db.dadars.ToList());
        }

        // GET: dadars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dadar dadar = db.dadars.Find(id);
            if (dadar == null)
            {
                return HttpNotFound();
            }
            return View(dadar);
        }

        // GET: dadars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dadars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] dadar dadar)
        {
            if (ModelState.IsValid)
            {
                db.dadars.Add(dadar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dadar);
        }

        // GET: dadars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dadar dadar = db.dadars.Find(id);
            if (dadar == null)
            {
                return HttpNotFound();
            }
            return View(dadar);
        }

        // POST: dadars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] dadar dadar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dadar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dadar);
        }

        // GET: dadars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dadar dadar = db.dadars.Find(id);
            if (dadar == null)
            {
                return HttpNotFound();
            }
            return View(dadar);
        }

        // POST: dadars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dadar dadar = db.dadars.Find(id);
            db.dadars.Remove(dadar);
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
