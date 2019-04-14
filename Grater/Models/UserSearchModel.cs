using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public class UserSearchModel
    {
        public int ? Id { get; set; }
        public string UserName { get; set; }
        public string UserCity { get; set; }
        public Ranking Ranking { get; set; }


    }
}