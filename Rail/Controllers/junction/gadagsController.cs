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
    public class gadagsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: gadags
        public ActionResult Index()
        {
            return View(db.gadags.ToList());
        }

        // GET: gadags/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gadag gadag = db.gadags.Find(id);
            if (gadag == null)
            {
                return HttpNotFound();
            }
            return View(gadag);
        }

        // GET: gadags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: gadags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] gadag gadag)
        {
            if (ModelState.IsValid)
            {
                db.gadags.Add(gadag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gadag);
        }

        // GET: gadags/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gadag gadag = db.gadags.Find(id);
            if (gadag == null)
            {
                return HttpNotFound();
            }
            return View(gadag);
        }

        // POST: gadags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] gadag gadag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gadag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gadag);
        }

        // GET: gadags/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gadag gadag = db.gadags.Find(id);
            if (gadag == null)
            {
                return HttpNotFound();
            }
            return View(gadag);
        }

        // POST: gadags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            gadag gadag = db.gadags.Find(id);
            db.gadags.Remove(gadag);
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
