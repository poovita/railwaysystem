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
    public class bangaloresController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: bangalores
        public ActionResult Index()
        {
            return View(db.bangalores.ToList());
        }

        // GET: bangalores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bangalore bangalore = db.bangalores.Find(id);
            if (bangalore == null)
            {
                return HttpNotFound();
            }
            return View(bangalore);
        }

        // GET: bangalores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: bangalores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] bangalore bangalore)
        {
            if (ModelState.IsValid)
            {
                db.bangalores.Add(bangalore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bangalore);
        }

        // GET: bangalores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bangalore bangalore = db.bangalores.Find(id);
            if (bangalore == null)
            {
                return HttpNotFound();
            }
            return View(bangalore);
        }

        // POST: bangalores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] bangalore bangalore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bangalore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bangalore);
        }

        // GET: bangalores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bangalore bangalore = db.bangalores.Find(id);
            if (bangalore == null)
            {
                return HttpNotFound();
            }
            return View(bangalore);
        }

        // POST: bangalores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bangalore bangalore = db.bangalores.Find(id);
            db.bangalores.Remove(bangalore);
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
