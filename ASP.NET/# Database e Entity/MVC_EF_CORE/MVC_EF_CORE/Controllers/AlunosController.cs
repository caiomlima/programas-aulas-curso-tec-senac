using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_EF_CORE.Data;
using MVC_EF_CORE.Models;

namespace MVC_EF_CORE.Controllers
{
    public class AlunosController : Controller
    {
        private readonly DatabaseContext _context;

        public AlunosController(DatabaseContext context) {
            _context = context;
        }


        /*-------------------------------------------------- Index -------------------------------------------------- */
        public async Task<IActionResult> Index() {
            return View(await _context.Alunos.ToListAsync());
        }


        /*-------------------------------------------------- Details -------------------------------------------------- */
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var aluno = await _context.Alunos.FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null) {
                return NotFound();
            }

            return View(aluno);
        }


        /*-------------------------------------------------- Create -------------------------------------------------- */
        [HttpGet]
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sexo,Email,Nascimento")] Aluno aluno) {
            if (ModelState.IsValid) {
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }


        /*-------------------------------------------------- Edit -------------------------------------------------- */
        [HttpGet]
        public async Task<IActionResult> Edit(int? id){
            if (id == null){
                return NotFound();
            }

            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null){
                return NotFound();
            }
            return View(aluno);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sexo,Email,Nascimento")] Aluno aluno) {
            if (id != aluno.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!AlunoExists(aluno.Id)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }


        /*-------------------------------------------------- Delete -------------------------------------------------- */
        [HttpGet]
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var aluno = await _context.Alunos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null) {
                return NotFound();
            }

            return View(aluno);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool AlunoExists(int id) {
            return _context.Alunos.Any(e => e.Id == id);
        }
    }
}
