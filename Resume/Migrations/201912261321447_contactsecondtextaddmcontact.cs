namespace Resume.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactsecondtextaddmcontact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactSecondText", c => c.String(storeType: "ntext"));
            AlterColumn("dbo.Educations", "EducationText", c => c.String(storeType: "ntext"));
            AlterColumn("dbo.Experiences", "ExperienceCOText", c => c.String(storeType: "ntext"));
            AlterColumn("dbo.Contacts", "ContactText", c => c.String(storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "ContactText", c => c.String());
            AlterColumn("dbo.Experiences", "ExperienceCOText", c => c.String());
            AlterColumn("dbo.Educations", "EducationText", c => c.String());
            DropColumn("dbo.Contacts", "ContactSecondText");
        }
    }
}
