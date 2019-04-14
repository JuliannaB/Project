using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public enum Ranking
    {
        Beginer = 0,
        Medium = 1,
        Advanced = 2,
        Expert = 3,
    };
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string UserName { get; set; }
        [Display(Name = "City")]
        public string UserCity { get; set; }
        [Display(Name = "Description")]
        public string UserDescription { get; set; }
        public Ranking Ranking { get; set; }
        public byte[] UserImage { get; set; }

    }
}