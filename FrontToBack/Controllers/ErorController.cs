﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class ErorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
