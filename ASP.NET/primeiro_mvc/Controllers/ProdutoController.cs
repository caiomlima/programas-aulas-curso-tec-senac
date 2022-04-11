using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_mvc.Controllers {
    public class ProdutoController : Controller {

        public IActionResult Index(int? pagina, string ordem) {
            //return "Retorno de string para produtos";
            //var http = HttpContext.Request.IsHttps;
            //var caminho = HttpContext.Request.Path;
            //var status = HttpContext.Response.StatusCode;
            //var conexao = HttpContext.Connection.ToString();
            //return http + "\r\n" + caminho + "\r\n" + status + "\r\n" + conexao;

            if(!pagina.HasValue) {
                pagina = 1;
            }

            if(String.IsNullOrEmpty(ordem)) {
                ordem = "Nome";
            }

            return Content(String.Format("pagina={0}&ordem={1}",pagina,ordem));
        }

        public IActionResult Detalhe() {

            return View();

            //return RedirectToAction("Index", "Home", new { pagina = 1, ordem = "nome" });[

            //return Content("Arquivo PDF", "application/pdf");

            //return File("lib/5e74f5b3a974e.jpeg", "image/jpeg");

            //var pessoa = new { ID = 1, Nome = "Caio" };
            //return new ObjectResult(pessoa);

        }

        public IActionResult Edit(int codigo) {
            return Content("Valor do ID é igual a " + codigo);
        }

        //[Route("Produtos/Lancamentos/{ano:int}/{mes:range(1,12)}")]
        public IActionResult DataLancamento(int ano, int mes) {
            return Content(ano + "/" + mes);
        }

    }
}
