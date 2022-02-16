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
    public class UcenicisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ucenicis
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Ucenicis.ToList());
        }

        // GET: Ucenicis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenici ucenici = db.Ucenicis.Find(id);
            if (ucenici == null)
            {
                return HttpNotFound();
            }
            return View(ucenici);
        }

        // GET: Ucenicis/Create
        [Authorize(Roles = "Profesor")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ucenicis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "broj,name,prezime,makedonski,matematika,angliski,prirodninauki,muzicko,fizicko,likovno,izostanoci")] Ucenici ucenici)
        {
            if (ModelState.IsValid)
            {
                db.Ucenicis.Add(ucenici);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ucenici);
        }

        // GET: Ucenicis/Edit/5
        [Authorize(Roles = "Profesor")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenici ucenici = db.Ucenicis.Find(id);
            if (ucenici == null)
            {
                return HttpNotFound();
            }
            return View(ucenici);
        }

        // POST: Ucenicis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "broj,name,prezime,makedonski,matematika,angliski,prirodninauki,muzicko,fizicko,likovno,izostanoci")] Ucenici ucenici)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ucenici).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ucenici);
        }

        // GET: Ucenicis/Delete/5
        [Authorize(Roles = "Direktor")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenici ucenici = db.Ucenicis.Find(id);
            if (ucenici == null)
            {
                return HttpNotFound();
            }
            return View(ucenici);
        }

        // POST: Ucenicis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ucenici ucenici = db.Ucenicis.Find(id);
            db.Ucenicis.Remove(ucenici);
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
