using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public bool SkillNails { get; set; }
        public bool SkillFace { get; set; }
        public bool SkillMassage { get; set; }
        public bool SkillBody { get; set; }
        public bool SkillWax { get; set; }
        public bool SkillEyes { get; set; }

        [Required]
        public Therapist Therapist { get; set; }
        public int TherapistId { get; set; }
    }
}