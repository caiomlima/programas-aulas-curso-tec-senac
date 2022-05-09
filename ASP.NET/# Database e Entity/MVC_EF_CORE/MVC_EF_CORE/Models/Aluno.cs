using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Models {
    public class Aluno {

        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Required, StringLength(50)]
        public string Sexo { get; set; }

        [Required, StringLength(150)]
        public string Email { get; set; }

        public DateTime Nascimento { get; set; }

        [Required, StringLength(150)]
        public string Foto { get; set; }

        [Required, StringLength(150)]
        public string Texto { get; set; }

        public TipoSocio TipoSocio { get; set; }

    }
}
