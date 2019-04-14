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
        // GET: User
       
        public ActionResult Index(UserSearchModel searchModel)
        {
            var logic = new UserSearchLogic();
            var model = logic.GetUsers(searchModel);
            return View(model);
        }

       

         private ApplicationDbContext _context = new ApplicationDbContext();
        public UserController()
           {
               _context = new ApplicationDbContext();
           }
           protected override void Dispose(bool disposing)
           {
               _context.Dispose();
           }
        /*   public ViewResult Index()
           {
               var user = _context.Seekers.ToList();   //  var user = _context.Users.Include(c => c.Comment).ToList() doesnt work :/

               return View(user);
           }  */

           public ActionResult Create()
           {
               return View();
           }

           public ActionResult Details(int id)
           {
               var user = _context.Seekers.SingleOrDefault(c => c.Id == id);

               if (user == null)
                   return HttpNotFound();

               return View(user);
           }
          
    }
}