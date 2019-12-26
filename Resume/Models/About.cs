using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class About
    {
        public int Id { get; set; }

        public string Head { get; set; }
        [Column(TypeName = "ntext")]
        public string AboutText { get; set; }
        [Column(TypeName = "ntext")]
        public string AboutSecondText { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        
        public string ExperienceHead { get; set; }
        [Column(TypeName = "ntext")]
        public string ExperienceText { get; set; }
        
        public string EducationHead { get; set; }
        
        public string EducationText { get; set; }

        public List<Experience> Experiences { get; set; }
        
        public List<Education> Educations { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }
    }
}