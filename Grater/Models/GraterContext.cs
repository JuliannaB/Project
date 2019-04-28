using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public class GraterContext: DbContext
    {
        public GraterContext() : base("AzureContext")
        {

        }

        public DbSet<Therapist> Therapists { get; set; }
        public DbSet<User> Seekers { get; set; }   //proba, poniewaz przy user dziealy sie dziwne rzeczy
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Salon> Salons { get; set; }

    }
}