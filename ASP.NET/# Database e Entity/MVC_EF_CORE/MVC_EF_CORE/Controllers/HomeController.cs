using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_EF_CORE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Controllers {
    public class HomeController : Controller {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }


        /*-------------------------------------------------- Index -------------------------------------------------- */
        public IActionResult Index() {
            return View();
        }


        /*-------------------------------------------------- Privacy -------------------------------------------------- */
        public IActionResult Privacy() {
            return View();
        }


        /*-------------------------------------------------- Error Page -------------------------------------------------- */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
