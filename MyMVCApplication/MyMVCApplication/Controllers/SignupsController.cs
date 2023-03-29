﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Entities;

namespace MyMVCApplication.Controllers
{
    public class SignupsController : Controller
    {
        private SubmitEntities db = new SubmitEntities();

        // GET: Signups
        public ActionResult Index()
        {
            return View(db.Signups.ToList());
        }

        // GET: Signups/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Signup signup = db.Signups.Find(id);
            if (signup == null)
            {
                return HttpNotFound();
            }
            return View(signup);
        }

        // GET: Signups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Signups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Userid,FirstName,LastName,EmailId,PhoneNumber,Password")] Signup signup)
        {
            if (ModelState.IsValid)
            {
                db.Signups.Add(signup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(signup);
        }

        // GET: Signups/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Signup signup = db.Signups.Find(id);
            if (signup == null)
            {
                return HttpNotFound();
            }
            return View(signup);
        }

        // POST: Signups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Userid,FirstName,LastName,EmailId,PhoneNumber,Password")] Signup signup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(signup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(signup);
        }

        // GET: Signups/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Signup signup = db.Signups.Find(id);
            if (signup == null)
            {
                return HttpNotFound();
            }
            return View(signup);
        }

        // POST: Signups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Signup signup = db.Signups.Find(id);
            db.Signups.Remove(signup);
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
