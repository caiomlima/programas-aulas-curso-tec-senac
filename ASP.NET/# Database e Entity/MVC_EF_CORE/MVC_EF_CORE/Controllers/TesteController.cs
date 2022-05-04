using Microsoft.AspNetCore.Mvc;
using MVC_EF_CORE.Data;
using MVC_EF_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Controllers {
    public class TesteController : Controller {

        private DatabaseContext _context;

        public TesteController(DatabaseContext context) {
            _context = context;
        }


        /*-------------------------------------------------- Index -------------------------------------------------- */
        public IActionResult Index() {
            var alunos = _context.Alunos.ToList();
            return View(alunos);
        }


        /*-------------------------------------------------- Post -------------------------------------------------- */
        [HttpGet]
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("Id, Nome, Sexo, Email, Nascimento")]Aluno aluno) {
            if(ModelState.IsValid) {
                _context.Add(aluno);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    }

}
