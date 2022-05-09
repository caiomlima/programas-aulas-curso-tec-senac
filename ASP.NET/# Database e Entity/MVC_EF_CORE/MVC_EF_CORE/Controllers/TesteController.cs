using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        /*-------------------------------------------------- Details -------------------------------------------------- */
        public IActionResult Details(int? id) {
            if(id == null) {
                return NotFound();
            }
            var aluno = _context.Alunos.SingleOrDefault(m => m.Id == id);
            if (aluno == null) {
                return NotFound();
            }
            return View(aluno);
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


        /*-------------------------------------------------- Edit -------------------------------------------------- */
        [HttpGet]
        public IActionResult Edit(int? id) {
            if(id == null) {
                return NotFound();
            }

            var aluno = _context.Alunos.SingleOrDefault(x => x.Id == id);

            return View(aluno);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind("Id, Nome, Sexo, Email, Nascimento")] Aluno aluno) {
            if(id == null) {
                return NotFound();
            }
            if (ModelState.IsValid) {
                try {
                    _context.Update(aluno);
                    _context.SaveChanges();
                } catch(DbUpdateConcurrencyException) {
                    if(!AlunoExists(aluno.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }


        /*-------------------------------------------------- Delete -------------------------------------------------- */
        [HttpGet]
        public IActionResult Delete(int? id) {
            if(id == null) {
                return NotFound();
            }
            var aluno = _context.Alunos.SingleOrDefault(x => x.Id == id);
            if(aluno == null) {
                return NotFound();
            }
            return View(aluno);
        }
        [HttpPost, ActionName("Delete"),ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id) {
            var aluno = _context.Alunos.SingleOrDefault(x => x.Id == id);
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        /*-------------------------------------------------- AlunoExists -------------------------------------------------- */
        private bool AlunoExists(int id) {
            return _context.Alunos.Any(x => x.Id == id);
        }

    }

}
