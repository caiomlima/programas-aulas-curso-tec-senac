using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Mvc_Filtros.Models {
    [Table("Autores")]
    public class Autor {

        [Required]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(50)]
        public string Twitter { get; set; }

    }
}
