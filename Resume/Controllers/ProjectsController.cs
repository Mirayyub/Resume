using Resume.Models;
using Resume.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class ProjectsController : BaseController
    {
        // GET: Projects
        public ActionResult Details(string slug)
        {
            var snblg = _context.Projects.FirstOrDefault(p => p.Slug == slug);
            if (snblg == null)
            {
                return HttpNotFound();
            }

            if (slug == null)
            {
                return HttpNotFound();
            }

            Project project = _context.Projects.FirstOrDefault(p => p.Slug == slug);

            if (project == null)
            {
                return HttpNotFound();
            }

            ProjectDetailVM model = new ProjectDetailVM
            {
                Project = project,
                UserLinks = _context.UserLinks.ToList(),
                ProjectType =_context.ProjectTypes.FirstOrDefault(),
                RightSide = _context.RightSides.FirstOrDefault(),
            };


            return View(model);
        }
    }
}