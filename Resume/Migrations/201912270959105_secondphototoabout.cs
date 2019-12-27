namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondphototoabout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "SecondPhoto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "SecondPhoto");
        }
    }
}
