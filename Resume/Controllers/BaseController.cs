﻿using Resume.Data;
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
            
        }
    }
}