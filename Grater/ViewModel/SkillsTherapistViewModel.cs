using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grater.Models;
namespace Grater.ViewModel
{
    public class SkillsTherapistViewModel
    {
        public Therapist Therapist { get; set; }
        public List<Skill> Skills { get; set; }
    }
}