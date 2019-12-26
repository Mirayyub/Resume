using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.ViewModels
{
    public class HomePageVM
    {

        public List<Contact> Contacts { get; set; }
        public List<About> Abouts { get; set; }
    }
}