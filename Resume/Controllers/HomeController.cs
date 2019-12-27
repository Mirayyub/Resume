using Resume.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomePageVM model = new HomePageVM
            {
                Contacts = _context.Contacts.OrderByDescending(c => c.Id).Take(1).ToList(),
                Abouts = _context.Abouts.OrderByDescending(o => o.Id).Take(1).ToList(),
                UserLinks = _context.UserLinks.ToList(),
                Projects = _context.Projects.ToList(),
                ProjectTypes = _context.ProjectTypes.ToList(),
            };
            return View(model);
        }

       
    }
}