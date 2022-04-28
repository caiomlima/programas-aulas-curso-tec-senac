using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BO.Models {
    public class Aluno {

        public int Id { get; set; }

        [Required(ErrorMessage = "Nome deve ser informado"), StringLength(50), MinLength(5), Display(Name = "Nome do cliente deve ser informado")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sexo deve ser informado"), Display(Name = "O sexo deve ser informado")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "E-mail deve ser informado"), Display(Name = "E-mail deve ser informado")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A data de nascimento deve ser informada")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Nascimento { get; set; }

    }
}
