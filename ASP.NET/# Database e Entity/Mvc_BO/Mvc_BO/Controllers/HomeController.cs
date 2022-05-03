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

        private IAlunoBLL _alunoBLL;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAlunoBLL alunoBLL) {
            _logger = logger;
            this._alunoBLL = alunoBLL;
        }


        /*---------------------------------------- Index ---------------------------------------- */
        public IActionResult Index() {
            //AlunoBLL _aluno = new AlunoBLL();

            List<Aluno> alunos = _alunoBLL.GetAlunos().ToList();

            return View("Lista", alunos);
        }


        /*---------------------------------------- Details ---------------------------------------- */
        public IActionResult Details(int id) {
            Aluno aluno = _alunoBLL.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }


        /*---------------------------------------- Create ---------------------------------------- */
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aluno aluno) {
            if (!ModelState.IsValid) {
                ViewBag.Error = "Insira todos os campos para concluir o cadastro";
                return View();
            }
            //AlunoBLL _aluno = new AlunoBLL();
            _alunoBLL.IncluirAlunos(aluno);
            return RedirectToAction("Index");
        }


        /*---------------------------------------- Edit ---------------------------------------- */
        [HttpGet]
        public IActionResult Edit(int id) {
            //AlunoBLL _alunoBLL = new AlunoBLL();
            Aluno _aluno = _alunoBLL.GetAlunos().Single(x => x.Id == id);
            return View(_aluno);
        }
        [HttpPost]
        public IActionResult Edit([Bind(nameof(Aluno.Id), nameof(Aluno.Nome), nameof(Aluno.Sexo), nameof(Aluno.Email), nameof(Aluno.Nascimento))]Aluno aluno) {

            //aluno.Nome = _alunoBLL.GetAlunos().Single(x => x.Id == aluno.Id).Nome;

            if(ModelState.IsValid) {
                //AlunoBLL _alunoBLL = new AlunoBLL();
                _alunoBLL.AtualizarAlunos(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }


        /*---------------------------------------- Delete ---------------------------------------- */
        //[HttpGet]
        //public IActionResult Delete(int id) {
        //    Aluno _aluno = _alunoBLL.GetAlunos().Single(x => x.Id == id);
        //    return View(_aluno);
        //}
        [HttpPost] // JavaScript
        public IActionResult Delete(int id) {
            _alunoBLL.DeletarAlunos(id);
            return RedirectToAction("Index");
        }


        /*---------------------------------------- Procurar ---------------------------------------- */
        public IActionResult Procurar(string procurarPor, string criterio) {
            if(procurarPor == "Email") {
                Aluno aluno = _alunoBLL.GetAlunos().SingleOrDefault(x => x.Email == criterio);
                return View(aluno);
            } else {
                Aluno aluno = _alunoBLL.GetAlunos().SingleOrDefault(x => x.Nome == criterio);
                return View(aluno);
            }
        }


        /*---------------------------------------- Privacy ---------------------------------------- */
        public IActionResult Privacy() {
            return View();
        }


        /*---------------------------------------- Error ---------------------------------------- */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
