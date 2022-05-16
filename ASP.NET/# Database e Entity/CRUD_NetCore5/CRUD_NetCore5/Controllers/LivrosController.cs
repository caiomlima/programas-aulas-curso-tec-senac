using CRUD_NetCore5.Data;
using CRUD_NetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NetCore5.Controllers {
    public class LivrosController : Controller {

        private readonly DatabaseContext _context;

        public LivrosController(DatabaseContext context) {
            _context = context;
        }

        /*-------------------------------------------------- Index / Get All --------------------------------------------------*/
        public IActionResult Index() {
            IEnumerable<Livro> listaLivros = _context.Livros;
            return View(listaLivros);
        }


        /*-------------------------------------------------- Create --------------------------------------------------*/
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Livro livro) {
            if(ModelState.IsValid) {
                _context.Livros.Add(livro);
                _context.SaveChanges();
                TempData["mensagem"] = "O livro foi criado com sucesso";
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }


        /*-------------------------------------------------- Update --------------------------------------------------*/
        [HttpGet]
        public IActionResult Edit(int? id) {
            if(id == null || id == 0) {
                return NotFound();
            }
            var livro = _context.Livros.Find(id);
            if(livro == null) {
                return NotFound();
            }
            return View(livro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Livro livro) {
            if (ModelState.IsValid) {
                _context.Livros.Update(livro);
                _context.SaveChanges();
                TempData["mensagem"] = "O livro foi alterado com sucesso";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }


        /*-------------------------------------------------- Delete --------------------------------------------------*/
        [HttpGet]
        public IActionResult Delete(int? id) {
            if (id == null || id == 0) {
                return NotFound();
            }
            var livro = _context.Livros.Find(id);
            if (livro == null) {
                return NotFound();
            }
            return View(livro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id) {
            var livro = _context.Livros.Find(id);
            if(ModelState.IsValid) {
                _context.Livros.Remove(livro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            if(id == null) {
                return NotFound();
            }
            return View(livro);
        }
    }
}
