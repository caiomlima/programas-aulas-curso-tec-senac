using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc_BO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BO.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            AlunoBLL _aluno = new AlunoBLL();

            List<Aluno> alunos = _aluno.GetAlunos().ToList();

            return View("Lista", alunos);
        }

        public IActionResult Create(Aluno aluno) {
            AlunoBLL _aluno = new AlunoBLL();

            if (!ModelState.IsValid) {
                return View();
            }

            _aluno.IncluirAlunos(aluno);

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
