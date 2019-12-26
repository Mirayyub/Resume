using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Logo { get; set; }

        public string HomeHead { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }

        


    }
}