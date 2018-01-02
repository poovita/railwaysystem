using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rail.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Rail.Controllers.train
{
    
    public class track_infoController : Controller
    {
        string constr1 = ConfigurationManager.ConnectionStrings["test1"].ConnectionString;
        private trainEntities db = new trainEntities();

        // GET: track_info
        public ActionResult Index()
        {
            return View(db.track_info.ToList());
        }

        // GET: track_info/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            track_info track_info = db.track_info.Find(id);
            if (track_info == null)
            {
                return HttpNotFound();
            }
            return View(track_info);
        }

        // GET: track_info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: track_info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "From_stn,To_stn,Track_route")] track_info track_info)
        {
            if (ModelState.IsValid)
            {
                db.track_info.Add(track_info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(track_info);
        }

        // GET: track_info/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            track_info track_info = db.track_info.Find(id);
            if (track_info == null)
            {
                return HttpNotFound();
            }
            return View(track_info);
        }

        // POST: track_info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "From_stn,To_stn,Track_route")] track_info track_info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(track_info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(track_info);
        }

        // GET: track_info/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            track_info track_info = db.track_info.Find(id);
            if (track_info == null)
            {
                return HttpNotFound();
            }
            return View(track_info);
        }

        // POST: track_info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            track_info track_info = db.track_info.Find(id);
            db.track_info.Remove(track_info);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult tf()
        {
            //return Json(new
            //{
            //    success = true,

            //    responcetext = "hi"
            //}, JsonRequestBehavior.AllowGet);
            return View();
            

        }
        [HttpPost]
        public JsonResult tff(string stn1, string stn2,string day_status,string star_t,string end_t)
        {
            List<arsikere> arrt = new List<arsikere>();
            string query1 = "update " + stn1 + " set affected=1;update " + stn2 + " set affected=1;";
            //SqlConnection connection1 = new SqlConnection(constr1);
            string query2 = "select * from " + stn1 + " where affected=1 and "+day_status+ "='Y' and (Depart between "+"'"+star_t+"'"+" and "+"'"+end_t + "'" + ") union select *  from " + stn2 +" where affected=1 and "+day_status+ "='Y' and (Depart between " + "'" + star_t + "'" + " and " + "'" + end_t + "'" + ");";
            DataTable dt = new DataTable();
            // List<DataRow> arrt;
            //string htmlStr = "";
            // connection1.Open();
            using (SqlConnection connection1 = new SqlConnection(constr1))
            {
                using (SqlCommand com = new SqlCommand(query2, connection1))
                {
                    connection1.Open();
                    var cmd1 = new SqlCommand(query1, connection1);
                    cmd1.ExecuteNonQuery();
                    using (SqlDataReader reader = com.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Models.arsikere item = new Models.arsikere()
                            {
                                Train_name = reader["Train_name"].ToString(),
                                Train_number =(int)reader["Train_number"],
                              
                            };
                            arrt.Add(item);


                        }


                        connection1.Close();
                    }
                }

            }
 

            return Json(arrt, JsonRequestBehavior.AllowGet);
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
