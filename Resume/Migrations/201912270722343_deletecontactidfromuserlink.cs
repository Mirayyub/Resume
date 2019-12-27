namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletecontactidfromuserlink : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserLinks", "ContactId", "dbo.Contacts");
            DropIndex("dbo.UserLinks", new[] { "ContactId" });
            DropColumn("dbo.UserLinks", "ContactId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserLinks", "ContactId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserLinks", "ContactId");
            AddForeignKey("dbo.UserLinks", "ContactId", "dbo.Contacts", "Id", cascadeDelete: true);
        }
    }
}
