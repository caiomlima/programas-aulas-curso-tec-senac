using Microsoft.AspNetCore.Mvc;
using primeiro_mvc.Models;
using primeiro_mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_mvc.Controllers {
    public class ClienteController : Controller {
        public IActionResult Detalhe() {
            Cliente cliente = new Cliente { 
                ClienteId = 100, Nome = "Caio", Email = "caio@email.com"
            };

            var pedidos = new List<Pedido> {
                new Pedido { Nome = "Pedido 1" },
                new Pedido { Nome = "Pedido 2" },
                new Pedido { Nome = "Pedido 3" },
                new Pedido { Nome = "Pedido 4" },
                new Pedido { Nome = "Pedido 5" },
            };

            var viewModel = new ClientePedidoViewModel {
                Cliente = cliente,
                Pedido = pedidos
            };

            return View(viewModel);
        }
    }
}
