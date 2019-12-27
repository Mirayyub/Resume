namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rightsidedeletefromprojectmodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "RightSideHead");
            DropColumn("dbo.Projects", "RightSideText");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "RightSideText", c => c.String(storeType: "ntext"));
            AddColumn("dbo.Projects", "RightSideHead", c => c.String());
        }
    }
}
