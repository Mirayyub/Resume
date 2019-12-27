using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.ViewModels
{
    public class ProjectDetailVM
    {
        public Project Project { get; set; }

        public RightSide RightSide { get; set; }

        public List<Contact> Contacts { get; set; }

        public List<UserLink> UserLinks { get; set; }

        public ProjectType ProjectType { get; set; }

    }
}