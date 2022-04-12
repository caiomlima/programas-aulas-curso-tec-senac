using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model_binding_mvc.Controllers {
    public class ClienteController : Controller {

        //[HttpGet] // Por padrão
        public IActionResult Index() {
            return View();
        }

        public IActionResult Detalhe() {
            return View();
        }

    }
}
