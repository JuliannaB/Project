using Grater.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using Grater.Controllers;
using System.Web.Mvc;

namespace Grater.Controllers
{
    public class UserSearchLogic
    {
        private GraterContext _context = new GraterContext();

       /* public UserSearchLogic()
        {
            Context = new ApplicationDbContext();
        }
          */
        public IQueryable<User> GetUsers(UserSearchModel searchModel)
        {
            var result = _context.Seekers.AsQueryable();
            if (searchModel != null)
            {
                if (searchModel.Id.HasValue)
                    result = result.Where(x => x.Id == searchModel.Id);
                if (!string.IsNullOrEmpty(searchModel.UserName))
                    result = result.Where(x => x.UserName.Contains(searchModel.UserName));
                if (!string.IsNullOrEmpty(searchModel.UserCity))
                    result = result.Where(x => x.UserCity.Contains(searchModel.UserCity));

            }
            return result;
        }
    }
}