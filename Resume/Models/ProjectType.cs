using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class ProjectType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        public List<Project> Projects { get; set; }
    }
}