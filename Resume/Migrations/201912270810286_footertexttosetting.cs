namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class footertexttosetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "FooterText", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "FooterText");
        }
    }
}
