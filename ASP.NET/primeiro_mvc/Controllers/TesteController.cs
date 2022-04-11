using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_mvc.Controllers {
    public class TesteController : Controller {
        public IActionResult Index() {
            ViewData["Saudacao"] = "Olá";
            ViewData["DataInicio"] = DateTime.Now;
            ViewData["Endereco"] = new Endereco() {
                Nome= "Caio", Rua = "Rua Tito, 54", Cidade ="São Paulo", Estado = "SP"
            };
            return View();
        }
    }
}
