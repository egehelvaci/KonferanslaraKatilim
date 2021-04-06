using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KonferansProje.Models;

namespace KonferansProje.Controllers
{
    public class AdminPanelController : Controller
    {
        private DbEntities db = new DbEntities();

        // GET: AdminPanel
        public ActionResult Index()
        {
            return View(db.konferans_tbl.ToList());
        }

        // GET: AdminPanel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            konferans_tbl konferans_tbl = db.konferans_tbl.Find(id);
           // katilimci_tbl katilimci_Tbl = db.katilimci_tbl.Find(id2);
            if (konferans_tbl == null)
            {
                return HttpNotFound();
            }
            return View(konferans_tbl);
           // return View(katilimci_Tbl);
        }

        // GET: AdminPanel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,konferansAdi,içeriktext,zamani,konusmaciAdi")] konferans_tbl konferans_tbl)
        {
            if (ModelState.IsValid)
            {
                db.konferans_tbl.Add(konferans_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(konferans_tbl);
        }

        // GET: AdminPanel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            konferans_tbl konferans_tbl = db.konferans_tbl.Find(id);
            if (konferans_tbl == null)
            {
                return HttpNotFound();
            }
            return View(konferans_tbl);
        }

        // POST: AdminPanel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,konferansAdi,içeriktext,zamani,konusmaciAdi")] konferans_tbl konferans_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(konferans_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(konferans_tbl);
        }

        // GET: AdminPanel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            konferans_tbl konferans_tbl = db.konferans_tbl.Find(id);
            if (konferans_tbl == null)
            {
                return HttpNotFound();
            }
            return View(konferans_tbl);
        }

        // POST: AdminPanel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            konferans_tbl konferans_tbl = db.konferans_tbl.Find(id);
            db.konferans_tbl.Remove(konferans_tbl);
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
        [HttpGet]
        public ActionResult Participants(int? id)
        {
            return View(db.katilimci_tbl.ToList());
            //katilimci_tbl katilimci_Tbl = db.katilimci_tbl.Find(id);
            //return View(katilimci_Tbl);

        }
            
        
    }
}
