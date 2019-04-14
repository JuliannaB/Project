using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Therapist Therapist { get; set; }     // Therapist FK
        public int TherapistId { get; set; }   // Therapist FK
        public Salon Salon { get; set; }    // Salon FK
        public int SalonId { get; set; }   // Salon FK .
    }
}