using Grater.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Grater.ViewModel;

namespace Grater.Controllers
{
    [Authorize]
    public class TherapistController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public TherapistController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult New()   // sciagniety kawalek kody tyczacy sie V-M
        {
            var skills = _context.Skills.ToList();
            var viewModel = new SkillsTherapistViewModel
            {
                Therapist = new Therapist(),
                Skills = skills
            };

            return View("TherapistrForm", viewModel);  // jeszcze nie wiem czemu form
        }


        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            var therapists = from b in _context.Therapists
                        select b;

            switch (sortOrder)
            {
                default:
                    therapists = therapists.OrderBy(s => s.TherapistName);
                    break;
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                therapists = therapists.Where(b => b.TherapistName.Contains(searchString) || b.City.Contains(searchString) || b.PhoneNumber.Contains(searchString));
            }

            return View(therapists.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Therapist therapist = _context.Therapists.Find(id);
            if (therapist == null)
            {
                return HttpNotFound();
            }
            return View(therapist);
        }

        // GET: Beer/Create
        public ActionResult Create()
        {
            return View();
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TherapistName, PhoneNumber, City, Email, Description, TherapistImage")]Therapist therapist)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Therapists.Add(therapist);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(therapist);
        }

        // GET: Beer/Edit/5

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Therapist therapist = _context.Therapists.Find(id);
            if (therapist == null)
            {
                return HttpNotFound();
            }
            return View(therapist);
        }

        // POST: Beer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BeerID,Name,Style,Brand,Brewery,Container,Volume,ABV")] Therapist therapist)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(therapist).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(therapist);
        }

        // GET: Beer/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Therapist therapist = _context.Therapists.Find(id);
            if (therapist == null)
            {
                return HttpNotFound();
            }
            return View(therapist);
        }

        // POST: Beer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Therapist therapist = _context.Therapists.Find(id);
                _context.Therapists.Remove(therapist);
                _context.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}


