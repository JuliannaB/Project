using Grater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using Grater.Controllers;


namespace Grater.Controllers
{
    public class UserController : Controller
    {
        private GraterContext _context = new GraterContext();
   /*     public UserController()
        {
            _context = new ApplicationDbContext();
        }
        */
        public ActionResult Details(int id)  //wchodzimy w detale
        {
            var user = _context.Seekers.SingleOrDefault(c => c.Id == id);

            if (user == null)
                return HttpNotFound();

            return View(user);
        }
        
        protected override void Dispose(bool disposing) //nie jestem pewna co to
        {
            _context.Dispose();
        }

        public ActionResult Create()  //wchodzimy do create ale to tyle
        {
            return View();
        }




        // GET: User                    Nie dziala to szukanie. To pewnie byla jakas proba z neta
        /*   public ActionResult Index(UserSearchModel searchModel)
           {
               var logic = new UserSearchLogic();
               var model = logic.GetUsers(searchModel);
               return View(model);
           }
           */



        /*   public ViewResult Index()
           {
               var user = _context.Seekers.ToList();   //  var user = _context.Users.Include(c => c.Comment).ToList() doesnt work :/

               return View(user);
           }  */





    }
}