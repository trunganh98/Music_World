﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicWorld.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Controllers
{
    public class HomeController : Controller
    {
        private IMusicReposity repository;
        private readonly ILogger<HomeController> _logger;

        public HomeController( IMusicReposity repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Songs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
