using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public Therapist Therapist { get; set; }  //FK to Therapist
        public int TherapistId { get; set; }     //FK to Therapist
    }
}