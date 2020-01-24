﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Models;

namespace Portfolio.Controllers {

    //[Route("/{action=index}")]
    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            return View();
        }
        public IActionResult Setup() {
            return View();
        }
        public IActionResult Contact() {
            return View();
        }


    }
}
