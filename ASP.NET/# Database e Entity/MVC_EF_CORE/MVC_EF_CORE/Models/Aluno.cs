using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Models {
    public class Aluno {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        [Required, MaxLength(50)]
        public string Sexo { get; set; }

        [Required, MaxLength(150)]
        public string Email { get; set; }

        public DateTime Nascimento { get; set; }

    }
}
