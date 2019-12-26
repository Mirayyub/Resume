﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Education
    {
        public int Id { get; set; }

        public string SchoolOrUni { get; set; }

        public string Department { get; set; }

        public string EducationText { get; set; }

        public string EducationDate { get; set; }

        public int AboutId { get; set; }

        public About About { get; set; }
    }
}