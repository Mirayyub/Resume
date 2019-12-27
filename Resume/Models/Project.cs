using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string HeadName { get; set; }
        [Column(TypeName = "ntext")]
        public string HeadText { get; set; }

        


        [Required, MaxLength(100)]
        public string Slug { get; set; }

        public DateTime PostedTime { get; set; }

        public string TextHeader1 { get; set; }
        [Column(TypeName = "ntext")]
        public string TextContent1 { get; set; }

        public string TextHeader2 { get; set; }
        [Column(TypeName = "ntext")]
        public string TextContent2 { get; set; }
        public string TextHeader3 { get; set; }
        [Column(TypeName = "ntext")]
        public string TextContent3 { get; set; }

        public string TextHeader4 { get; set; }
        [Column(TypeName = "ntext")]
        public string TextContent4 { get; set; }

        public string ResultHead { get; set; }
        [Column(TypeName = "ntext")]
        public string ResultText { get; set; }
        [Column(TypeName = "ntext")]
        public string ResultComment { get; set; }

        public string UrlApp { get; set; }


        [MaxLength(100)]
        public string Photo { get; set; }

        public int ProjectTypeId { get; set; }

        public ProjectType ProjectType { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }

    }
}