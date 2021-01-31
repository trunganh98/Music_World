using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicWorld.Models;
using MusicWorld.Models.ViewModel;
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

        public HomeController( IMusicReposity repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(
            new ProductListViewModel
            {
                Songs = repository.Songs,
                Events = repository.Events,
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(5),
                Artists = repository.Artists
                            
                
            });
                




        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult News()
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
