using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class UserLink
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Name { get; set; }

        public int ContactId { get; set; }

        public Contact Contact { get; set; }
    }
}