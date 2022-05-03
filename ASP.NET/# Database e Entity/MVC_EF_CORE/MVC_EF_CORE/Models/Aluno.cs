using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Models {
    public class Aluno {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        public string Email { get; set; }

        public DateTime Nascimento { get; set; }

    }
}
