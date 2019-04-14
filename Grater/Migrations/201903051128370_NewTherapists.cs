namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTherapists : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO THERAPISTS (TherapistName, City, Description, PhoneNumber, Email) VALUES ('Kornelia', 'Dublin', 'I love beeing beautician! Face treatments is my specialization', '0851829987','kornelia@gmail.com')");
            Sql("INSERT INTO THERAPISTS (TherapistName, City, Description, PhoneNumber, Email) VALUES ('Patricia', 'Dublin', 'Im best in nails!', '0487829987','patricia@gmail.com')");
            Sql("INSERT INTO THERAPISTS (TherapistName, City, Description, PhoneNumber, Email) VALUES ('Joanna', 'Dublin', 'You will love your eyebrows after you will visit me', '0851829946','joanna@gmail.com')");
            Sql("INSERT INTO THERAPISTS (TherapistName, City, Description, PhoneNumber, Email) VALUES ('Kate', 'Dublin', 'Best Nail Artist ever!', '0581829927','Kate@gmail.com')");

        }

        public override void Down()
        {
        }
    }
}
