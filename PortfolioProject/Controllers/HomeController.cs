﻿using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult TestPartialView()
        {
            return View();
        }

    }
}
