using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Models {
    public class TipoSocio {

        [Key]
        public int Id { get; set; }

        [Required]
        public int DuracaoEmMeses { get; set; }

        // Mensal -> sem desconto
        // 3 meses -> 10%
        // 6 meses -> 20%
        // 12 meses -> 30%

        [Required]
        public int taxaDesconto { get; set; }

    }
}
