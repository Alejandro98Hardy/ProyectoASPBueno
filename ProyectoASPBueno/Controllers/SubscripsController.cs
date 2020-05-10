using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoASPBueno.Data;    
using ProyectoASPBueno.Models;

namespace ProyectoASPBueno.Controllers
{
    public class SubscripsController : Controller
    {
        private BDContext db = new BDContext();

        // GET: Subscrips
        public ActionResult Index()
        {
            return View(db.Subscrips.ToList());
        }

        // GET: Subscrips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscrip subscrip = db.Subscrips.Find(id);
            if (subscrip == null)
            {
                return HttpNotFound();
            }
            return View(subscrip);
        }

        // GET: Subscrips/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subscrips/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nombre,compania,empleados")] Subscrip subscrip)
        {
            if (ModelState.IsValid)
            {
                db.Subscrips.Add(subscrip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subscrip);
        }

        // GET: Subscrips/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscrip subscrip = db.Subscrips.Find(id);
            if (subscrip == null)
            {
                return HttpNotFound();
            }
            return View(subscrip);
        }

        // POST: Subscrips/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nombre,compania,empleados")] Subscrip subscrip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subscrip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subscrip);
        }

        // GET: Subscrips/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscrip subscrip = db.Subscrips.Find(id);
            if (subscrip == null)
            {
                return HttpNotFound();
            }
            return View(subscrip);
        }

        // POST: Subscrips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subscrip subscrip = db.Subscrips.Find(id);
            db.Subscrips.Remove(subscrip);
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
