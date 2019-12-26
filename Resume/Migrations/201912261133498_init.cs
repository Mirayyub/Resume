namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Head = c.String(),
                        AboutText = c.String(storeType: "ntext"),
                        AboutSecondText = c.String(storeType: "ntext"),
                        Photo = c.String(maxLength: 100),
                        ExperienceHead = c.String(),
                        ExperienceText = c.String(storeType: "ntext"),
                        EducationHead = c.String(),
                        EducationText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolOrUni = c.String(),
                        Department = c.String(),
                        EducationText = c.String(),
                        EducationDate = c.String(),
                        AboutId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abouts", t => t.AboutId, cascadeDelete: true)
                .Index(t => t.AboutId);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExperienceCO = c.String(),
                        Position = c.String(),
                        ExperienceCOText = c.String(),
                        ExperienceCODate = c.String(),
                        AboutId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abouts", t => t.AboutId, cascadeDelete: true)
                .Index(t => t.AboutId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeaderName = c.String(),
                        ContactText = c.String(),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Name = c.String(),
                        ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeadName = c.String(),
                        HeadText = c.String(storeType: "ntext"),
                        Slug = c.String(nullable: false, maxLength: 100),
                        PostedTime = c.DateTime(nullable: false),
                        TextHeader1 = c.String(),
                        TextContent1 = c.String(storeType: "ntext"),
                        TextHeader2 = c.String(),
                        TextContent2 = c.String(storeType: "ntext"),
                        TextHeader3 = c.String(),
                        TextContent3 = c.String(storeType: "ntext"),
                        TextHeader4 = c.String(),
                        TextContent4 = c.String(storeType: "ntext"),
                        ResultHead = c.String(),
                        ResultText = c.String(storeType: "ntext"),
                        ResultComment = c.String(storeType: "ntext"),
                        UrlApp = c.String(),
                        RightSideHead = c.String(),
                        RightSideText = c.String(storeType: "ntext"),
                        Photo = c.String(maxLength: 100),
                        ProjectTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectTypes", t => t.ProjectTypeId, cascadeDelete: true)
                .Index(t => t.ProjectTypeId);
            
            CreateTable(
                "dbo.ProjectTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logo = c.String(maxLength: 100),
                        HomeHead = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ProjectTypeId", "dbo.ProjectTypes");
            DropForeignKey("dbo.UserLinks", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Experiences", "AboutId", "dbo.Abouts");
            DropForeignKey("dbo.Educations", "AboutId", "dbo.Abouts");
            DropIndex("dbo.Projects", new[] { "ProjectTypeId" });
            DropIndex("dbo.UserLinks", new[] { "ContactId" });
            DropIndex("dbo.Experiences", new[] { "AboutId" });
            DropIndex("dbo.Educations", new[] { "AboutId" });
            DropTable("dbo.Settings");
            DropTable("dbo.ProjectTypes");
            DropTable("dbo.Projects");
            DropTable("dbo.UserLinks");
            DropTable("dbo.Contacts");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.Abouts");
        }
    }
}
