using ASPN_ViewInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPN_ViewInjection.Services {
    public class EstadosService {

        public List<Estado> GetEstados() {
            return new List<Estado>() {
                new Estado("São Paulo", "SP"),
                new Estado("Rio de Janeiro", "JR"),
                new Estado("Minas Gerais", "MG"),
                new Estado("Paraná", "PR"),
            };
        }

    }
}
