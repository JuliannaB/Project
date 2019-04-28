using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string Skillcha { get; set; }

        [Required]
        public Therapist Therapist { get; set; }
        public int TherapistId { get; set; }
    }
}