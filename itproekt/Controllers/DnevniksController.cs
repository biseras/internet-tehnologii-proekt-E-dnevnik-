using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using itproekt.Models;

namespace itproekt.Controllers
{
    public class DnevniksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dnevniks
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Dnevniks.ToList());
        }

        // GET: Dnevniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dnevnik dnevnik = db.Dnevniks.Find(id);
            if (dnevnik == null)
            {
                return HttpNotFound();
            }
            return View(dnevnik);
        }

        // GET: Dnevniks/Create
        [Authorize(Roles = "Profesor")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dnevniks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,datum,prvcas,vtorcas,tretcas,cetvrticas,petticas")] Dnevnik dnevnik)
        {
            if (ModelState.IsValid)
            {
                db.Dnevniks.Add(dnevnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dnevnik);
        }

        // GET: Dnevniks/Edit/5
        [Authorize(Roles = "Profesor")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dnevnik dnevnik = db.Dnevniks.Find(id);
            if (dnevnik == null)
            {
                return HttpNotFound();
            }
            return View(dnevnik);
        }

        // POST: Dnevniks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,datum,prvcas,vtorcas,tretcas,cetvrticas,petticas")] Dnevnik dnevnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dnevnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dnevnik);
        }

        // GET: Dnevniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dnevnik dnevnik = db.Dnevniks.Find(id);
            if (dnevnik == null)
            {
                return HttpNotFound();
            }
            return View(dnevnik);
        }

        // POST: Dnevniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dnevnik dnevnik = db.Dnevniks.Find(id);
            db.Dnevniks.Remove(dnevnik);
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
