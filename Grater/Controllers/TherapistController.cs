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

        /*      public ViewResult Radom()                       //Radom jest proba polaczeia skills i therapist. tmp. 
              {
                  var therapist = new Therapist() { TherapistName = "Jake" };
                  var skills = new List<Skill>
                  {


                      new Skill { SkillName = "Nails" },
                      new Skill { SkillName = "MakeUp" },
                      new Skill { SkillName = "Face" }
                  };
                  var ViewModel = new SkillsTherapistViewModel
                  {
                      Therapist = therapist,
                      Skills = skills
                  };
                  return View(ViewModel);
              }
              */
        //GET: Therapist/Index    Jest ok, przywrocic po usunieciu Radom
        public ViewResult Index(string sortOrder, string searchString)  // wylistowuje terapeutki, dodaje mozliwosc szukania
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
              


        //GET: Therapist/Details

        public ActionResult Details(int? id)    //Wchodzimy do view details, po klikieciu na imie. Dziala ok
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

        // GET: /Create
        public ActionResult Create()            // umozliwie nam wejscie do veiw create
        {
            return View();
        }

        // GET: Therapist/Edit/5    to zdaje sie zrobione przezemnie... tylko ze cos nie dziala. Nie wywala sie ale nie zapamietuje zmian

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

        //  POST: Therapist/Delete/5    cannot be fount,. Mysle ze to kwestia zlego routingu
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
            catch (DataException)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        /*  protected override void Dispose(bool disposing)     nie pamieam co to
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                base.Dispose(disposing);
            }
        }
        */

    }
}
















/*
public ActionResult New()   // sciagniety kawalek kody tyczacy sie V-M. Szkoda ze nie mam view new....
{
    var skills = _context.Skills.ToList();
    var viewModel = new SkillsTherapistViewModel
    {
        Therapist = new Therapist(),
        Skills = skills
    };

    return View("TherapistrForm", viewModel);  // jeszcze nie wiem czemu form
}




/*  Nie wywala sie ale znow, przy edit nowy dok, bez wypelnionych pol. Nic sie nie zapamietuje
public ActionResult Edit (int id)
{
var therapist = _context.Therapists.SingleOrDefault(c => c.Id == id);
if (therapist == null)
return HttpNotFound();
var ViewModel = new SkillsTherapistViewModel
{
Therapist = therapist,
Skills = _context.Skills.ToList()
};
return View();
}
*/



// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.




// POST: Therapist/Edit/5
// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//   [HttpPost]
//     [ValidateAntiForgeryToken]
/*    public ActionResult Edit([Bind(Include = "TherapistName, PhoneNumber, City, Email, Description, TherapistImage")] Therapist therapist)
{
    if (ModelState.IsValid)
    {
        _context.Entry(therapist).State = EntityState.Modified;
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(therapist);
}  */









/*
[HttpPost]     scigniete zdaje sie z poprzedniej apki
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
catch (DataException)
{
//Log the error (uncomment dex variable name and add a line here to write a log.
ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
}
return View(therapist);
*/





/*  Przy edit pokazuje nowy formulaz. Wywala sie blad SB przy probie zapamietania - moze wina ze nie na azure? Anyway, chyba sciagniete z poprz projektu
public ActionResult Edit([Bind(Include = "TherapistName, PhoneNumber, City, Email, Description, TherapistImage")] Therapist therapist)
{
if (ModelState.IsValid)
{
   _context.Entry(therapist).State = EntityState.Modified;
   _context.SaveChanges();
   return RedirectToAction("Index");
}
return View(therapist);  */





// GET: Therapist/Delete/5   bardzo obledzone. Myle ze t bylo skopiowane skads. 
/*public ActionResult Delete(int? id, bool? saveChangesError = false)
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
}  */
