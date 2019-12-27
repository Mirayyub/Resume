namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodelrightside : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RightSides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SideHead = c.String(),
                        SideText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RightSides");
        }
    }
}
