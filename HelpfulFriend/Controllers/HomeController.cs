﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelpfulFriend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

      

        public IActionResult Joboffer()
        {
            ViewData["Jobs"] = "Find the job most suitable for you!";
            return View();
        }

        public IActionResult CreateJob()
        {
            ViewData["Title"] = "On this page, you can create a job";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Login()
        {
            ViewData["Login"] = "Login page";
            return View();
        }
    }
}