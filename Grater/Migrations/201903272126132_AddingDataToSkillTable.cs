namespace Grater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataToSkillTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Skills (SkillName, TherapistId) VALUES ('Nails', 4)");
            Sql("INSERT INTO Skills (SkillName, TherapistId) VALUES ('Massages', 2)");
            Sql("INSERT INTO Skills (SkillName, TherapistId) VALUES ('Acid', 3)");
         
        }

        public override void Down()
        {
        }
    }
}
