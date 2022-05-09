using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EF_CORE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Controllers {
    public class AlunoTipoSocioController : Controller {

        private DatabaseContext _context;

        public AlunoTipoSocioController(DatabaseContext context) {
            _context = context;
        }

        public IActionResult Index() {
            var infoAluno = _context.Alunos.Include(x => x.TipoSocio);
            return View(infoAluno);
        }


    }
}
