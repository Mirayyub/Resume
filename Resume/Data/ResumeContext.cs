using Resume.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resume.Data
{
    public class ResumeContext:DbContext
    {
        public ResumeContext() : base("ResumeContext")
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<UserLink> UserLinks { get; set; }

        public DbSet<RightSide> RightSides { get; set; }
    }
}