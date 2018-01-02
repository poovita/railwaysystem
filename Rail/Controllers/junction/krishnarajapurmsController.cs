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
    public class krishnarajapurmsController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: krishnarajapurms
        public ActionResult Index()
        {
            return View(db.krishnarajapurms.ToList());
        }

        // GET: krishnarajapurms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            krishnarajapurm krishnarajapurm = db.krishnarajapurms.Find(id);
            if (krishnarajapurm == null)
            {
                return HttpNotFound();
            }
            return View(krishnarajapurm);
        }

        // GET: krishnarajapurms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: krishnarajapurms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] krishnarajapurm krishnarajapurm)
        {
            if (ModelState.IsValid)
            {
                db.krishnarajapurms.Add(krishnarajapurm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(krishnarajapurm);
        }

        // GET: krishnarajapurms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            krishnarajapurm krishnarajapurm = db.krishnarajapurms.Find(id);
            if (krishnarajapurm == null)
            {
                return HttpNotFound();
            }
            return View(krishnarajapurm);
        }

        // POST: krishnarajapurms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] krishnarajapurm krishnarajapurm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(krishnarajapurm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(krishnarajapurm);
        }

        // GET: krishnarajapurms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            krishnarajapurm krishnarajapurm = db.krishnarajapurms.Find(id);
            if (krishnarajapurm == null)
            {
                return HttpNotFound();
            }
            return View(krishnarajapurm);
        }

        // POST: krishnarajapurms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            krishnarajapurm krishnarajapurm = db.krishnarajapurms.Find(id);
            db.krishnarajapurms.Remove(krishnarajapurm);
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
