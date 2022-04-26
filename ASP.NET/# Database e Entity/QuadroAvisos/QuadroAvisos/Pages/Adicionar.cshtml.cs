using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuadroAvisos.Data;

namespace QuadroAvisos.Pages
{
    public class AdicionarModel : PageModel
    {
        private readonly QuadroAvisos.Data.AvisoContext _context;

        public AdicionarModel(QuadroAvisos.Data.AvisoContext context) {
            _context = context;
        }

        [BindProperty]
        public Aviso Aviso { get; set; }

        public IActionResult OnGet() {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            //Aviso.Hora = DateTime.Now;
            _context.Avisos.Add(Aviso);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
