using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using primeiro_mvc.Models;

namespace primeiro_mvc.Controllers
{

    //[Route("[controller]/[action]")]
    public class HomeController : Controller {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("Lista")]
        public string Lista() {
            return "Action Lista";
        }

        //[Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        //[Route("Home/Secret")]
        //[HttpGet("Home/Secret")]
        public IActionResult Secret() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
