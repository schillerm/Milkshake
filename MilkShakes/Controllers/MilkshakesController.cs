using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MilkShakes.Models.Entities;

namespace MilkShakes.Controllers
{
    public class MilkshakesController : Controller
    {
        private MilkshakeDB db = new MilkshakeDB();

        // GET: Milkshakes
        public ActionResult Index()
        {
            return View(db.Milkshakes.ToList());
        }

        // GET: Milkshakes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Milkshake milkshake = db.Milkshakes.Find(id);
            if (milkshake == null)
            {
                return HttpNotFound();
            }
            return View(milkshake);
        }

        // GET: Milkshakes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Milkshakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MilkShakeID,Name")] Milkshake milkshake)
        {
            if (ModelState.IsValid)
            {
                db.Milkshakes.Add(milkshake);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(milkshake);
        }

        // GET: Milkshakes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Milkshake milkshake = db.Milkshakes.Find(id);
            if (milkshake == null)
            {
                return HttpNotFound();
            }
            return View(milkshake);
        }

        // POST: Milkshakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MilkShakeID,Name")] Milkshake milkshake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(milkshake).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(milkshake);
        }

        // GET: Milkshakes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Milkshake milkshake = db.Milkshakes.Find(id);
            if (milkshake == null)
            {
                return HttpNotFound();
            }
            return View(milkshake);
        }

        // POST: Milkshakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Milkshake milkshake = db.Milkshakes.Find(id);
            db.Milkshakes.Remove(milkshake);
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
