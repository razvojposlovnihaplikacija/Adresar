using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adresar.Models;

namespace Adresar.Controllers
{
    public class KontaktiController : Controller
    {
        private KontaktDBContext db = new KontaktDBContext();
        public ActionResult Index()
        {
            return View(db.Kontakti.ToList());
        }

        public  ActionResult About()
        {
            var model = new About();
            model.Ime = "Jan";
            model.Prezime = "Jerečić";
            model.JMBAG = "0036419637";
            model.Email = "jerecicjan@gmail.com";
            return View(model);

        }
        public ActionResult Details(int id = 0)
        {
            Kontakt kontakt = db.Kontakti.Find(id);
            if (kontakt == null)
            {
                return HttpNotFound();
            }
            return View(kontakt);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kontakt kontakt)
        {
            if (ModelState.IsValid)
            {
                db.Kontakti.Add(kontakt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kontakt);
        }

        public ActionResult Edit(int id = 0)
        {
            Kontakt kontakt = db.Kontakti.Find(id);
            if (kontakt == null)
            {
                return HttpNotFound();
            }
            return View(kontakt);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kontakt kontakt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kontakt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kontakt);
        }

        public ActionResult Delete(int id = 0)
        {
            Kontakt kontakt = db.Kontakti.Find(id);
            if (kontakt == null)
            {
                return HttpNotFound();
            }
            return View(kontakt);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kontakt kontakt = db.Kontakti.Find(id);
            db.Kontakti.Remove(kontakt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult SearchIndex(string kontaktGrad, string searchString)
        {
            var GradLst = new List<string>();

            var GradQry = from d in db.Kontakti
                           orderby d.Grad
                           select d.Grad;
            GradLst.AddRange(GradQry.Distinct());
            ViewBag.kontaktGrad = new SelectList(GradLst);

            var kontakti = from m in db.Kontakti
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                kontakti = kontakti.Where(s => s.Ime.Contains(searchString));
            }

            if (string.IsNullOrEmpty(kontaktGrad))
                return View(kontakti);
            else
            {
                return View(kontakti.Where(x => x.Grad == kontaktGrad));
            }

        }
    }
}