using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string HeaderName { get; set; }

        public string ContactText { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }

        public List<UserLink> UserLinks { get; set; }

    }
}