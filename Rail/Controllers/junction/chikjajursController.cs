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
    public class chikjajursController : Controller
    {
        private junctionEntities db = new junctionEntities();

        // GET: chikjajurs
        public ActionResult Index()
        {
            return View(db.chikjajurs.ToList());
        }

        // GET: chikjajurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chikjajur chikjajur = db.chikjajurs.Find(id);
            if (chikjajur == null)
            {
                return HttpNotFound();
            }
            return View(chikjajur);
        }

        // GET: chikjajurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: chikjajurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] chikjajur chikjajur)
        {
            if (ModelState.IsValid)
            {
                db.chikjajurs.Add(chikjajur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chikjajur);
        }

        // GET: chikjajurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chikjajur chikjajur = db.chikjajurs.Find(id);
            if (chikjajur == null)
            {
                return HttpNotFound();
            }
            return View(chikjajur);
        }

        // POST: chikjajurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Train_number,Train_name,Source_stn,Dest_stn,Arrival,Depart,halt,Su,Mo,Tu,We,Th,Fr,Sa,train_priority,platform")] chikjajur chikjajur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chikjajur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chikjajur);
        }

        // GET: chikjajurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chikjajur chikjajur = db.chikjajurs.Find(id);
            if (chikjajur == null)
            {
                return HttpNotFound();
            }
            return View(chikjajur);
        }

        // POST: chikjajurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            chikjajur chikjajur = db.chikjajurs.Find(id);
            db.chikjajurs.Remove(chikjajur);
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
