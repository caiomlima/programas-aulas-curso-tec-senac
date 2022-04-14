using Microsoft.AspNetCore.Mvc;
using model_binding_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model_binding_mvc.Controllers {
    public class ClienteController : Controller {

        [HttpGet] // Por padrão
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente) {
            if(cliente?.Id == 0 | cliente?.Nome == null | cliente?.Email == null) {
                ViewBag.Erro = "Dados do cliente inválido ou vazio";
                return View();
            }
            return View("Detalhe", cliente);
        }

        //public IActionResult Detalhe() {
        //    return View();
        //}

    }
}
