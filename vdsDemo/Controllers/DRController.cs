using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vdsDemo.Models;

namespace vdsDemo.Controllers
{
    public class DRController : Controller
    {
        private Create_DRDBContext db = new Create_DRDBContext();

        //
        // GET: /DR/

        public ActionResult Index()
        {
            return View(db.DR.ToList());
        }

        //
        // GET: /DR/Details/5

        public ActionResult Details(int id = 0)
        {
            Create_DR create_dr = db.DR.Find(id);
            if (create_dr == null)
            {
                return HttpNotFound();
            }
            return View(create_dr);
        }

        //
        // GET: /DR/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DR/Create

        [HttpPost]
        public ActionResult Create(Create_DR create_dr)
        {
            if (ModelState.IsValid)
            {
                db.DR.Add(create_dr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(create_dr);
        }

        //
        // GET: /DR/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Create_DR create_dr = db.DR.Find(id);
            if (create_dr == null)
            {
                return HttpNotFound();
            }
            return View(create_dr);
        }

        //
        // POST: /DR/Edit/5

        [HttpPost]
        public ActionResult Edit(Create_DR create_dr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(create_dr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(create_dr);
        }

        //
        // GET: /DR/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Create_DR create_dr = db.DR.Find(id);
            if (create_dr == null)
            {
                return HttpNotFound();
            }
            return View(create_dr);
        }

        //
        // POST: /DR/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Create_DR create_dr = db.DR.Find(id);
            db.DR.Remove(create_dr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}