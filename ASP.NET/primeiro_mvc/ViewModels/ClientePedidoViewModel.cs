using primeiro_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_mvc.ViewModels {
    public class ClientePedidoViewModel {
        
        public Cliente Cliente { get; set; }
        public List<Pedido> Pedido { get; set; }

    }
}
