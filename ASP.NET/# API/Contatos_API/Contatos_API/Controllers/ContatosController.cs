using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Contatos_API.Data;
using Contatos_API.Models;

namespace Contatos_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ContatosController(DatabaseContext context) {
            _context = context;
        }


        /*-------------------------------------------------- GetAll --------------------------------------------------*/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contato>>> GetAll() {
            return await _context.Contatos.ToListAsync();
        }

        /*-------------------------------------------------- GetById --------------------------------------------------*/
        [HttpGet("{id}")]
        public async Task<ActionResult<Contato>> GetById(int id) {
            var contato = await _context.Contatos.FindAsync(id);
            if (contato == null) {
                return NotFound();
            }
            return contato;
        }


        /*-------------------------------------------------- Update --------------------------------------------------*/
        [HttpPut("{id}")]
        public async Task<IActionResult> EditContato(int id, Contato contato) {
            if (id != contato.Id) {
                return BadRequest();
            }
            _context.Entry(contato).State = EntityState.Modified;
            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!ContatoExists(id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return NoContent();
        }


        /*-------------------------------------------------- Post --------------------------------------------------*/
        [HttpPost]
        public async Task<ActionResult<Contato>> CreateContato(Contato contato) {
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetById", new { id = contato.Id }, contato);
        }


        /*-------------------------------------------------- Delete --------------------------------------------------*/
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContato(int id) {
            var contato = await _context.Contatos.FindAsync(id);
            if (contato == null) {
                return NotFound();
            }
            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool ContatoExists(int id) {
            return _context.Contatos.Any(e => e.Id == id);
        }
    }
}
