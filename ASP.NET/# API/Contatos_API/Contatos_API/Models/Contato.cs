using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos_API.Models {
    [Table("contatos")]
    public class Contato {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Contato"), StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Email do Contato"), StringLength(100), EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Telefone do Contato"), StringLength(50)]
        public string Telefone { get; set; }

    }
}
