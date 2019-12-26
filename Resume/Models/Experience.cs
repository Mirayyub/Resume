using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Experience
    {
        public int Id { get; set; }

        public string ExperienceCO { get; set; }
        public string Position { get; set; }

        [Column(TypeName = "ntext")]
        public string ExperienceCOText { get; set; }

        public string ExperienceCODate { get; set; }

        public int AboutId { get; set; }

        public About About { get; set; }

    }
}