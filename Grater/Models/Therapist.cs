using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public class Therapist
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string TherapistName { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Mobile { get; set; }

        public virtual Skill Skill { get; set; }
        public int SkillId { get; set; }

        // public byte[] TherapistImage { get; set; }

        public string TherapistImagePath { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}