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
    public class hublisController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: hublis
        public ActionResult Index()
        {
            return View(db.hublis.ToList());
        }

        // GET: hublis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hubli hubli = db.hublis.Find(id);
            if (hubli == null)
            {
                return HttpNotFound();
            }
            return View(hubli);
        }

        // GET: hublis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hublis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] hubli hubli)
        {
            if (ModelState.IsValid)
            {
                db.hublis.Add(hubli);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hubli);
        }

        // GET: hublis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hubli hubli = db.hublis.Find(id);
            if (hubli == null)
            {
                return HttpNotFound();
            }
            return View(hubli);
        }

        // POST: hublis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] hubli hubli)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hubli).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hubli);
        }

        // GET: hublis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hubli hubli = db.hublis.Find(id);
            if (hubli == null)
            {
                return HttpNotFound();
            }
            return View(hubli);
        }

        // POST: hublis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hubli hubli = db.hublis.Find(id);
            db.hublis.Remove(hubli);
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
