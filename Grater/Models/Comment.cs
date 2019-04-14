using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grater.Models
{
    public enum RatingEnum
    {
        great = 0,
        good = 1,
        average = 2,
        bad = 3,
        horrible = 4
    };
    public class Comment
    {

        public int Id { get; set; }

        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }

        public RatingEnum Rate { get; set; }
  //      public DateTime ReleaseDate { get; set; }
        public Therapist Therapist { get; set; }  //FK to Therapist
        public int TherapistId { get; set; }     //FK to Therapist
        public User User { get; set; }          //FK to User
        public int UserId { get; set; }        //FK to User, i hope




    }
}