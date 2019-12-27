using Resume.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ResumeContext _context;

        public BaseController()
        {
            _context = new ResumeContext();

            ViewBag.Setting = _context.Settings.OrderByDescending(s=>s.Id).FirstOrDefault();
            ViewBag.Contact = _context.Contacts.OrderByDescending(c => c.Id).FirstOrDefault();
            ViewBag.About = _context.Abouts.Include("Educations").Include("Experiences").OrderByDescending(a => a.Id).FirstOrDefault();
            ViewBag.UserLinks = _context.UserLinks.ToList();
            
        }
    }
}