using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NetCore5.Models {
    [Table("livros")]
    public class Livro {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("titulo")]
        [Required(ErrorMessage = "O Título é obrigatório")]
        [StringLength(50, ErrorMessage = "O {0} deve ter ao menos {2} e até {1} caracteres"), MinLength(3)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Column("descricao")]
        [Required(ErrorMessage = "A descrição é obrigatória"),]
        [StringLength(200, ErrorMessage = "A {0} deve ter ao menos {2} e até {1} caracteres"), MinLength(3)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("dataLancamento")]
        [Required(ErrorMessage = "A data de lançamento é obrigatória")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Column("autor")]
        [Required(ErrorMessage = "O nome do Autor é obrigatório")]
        [StringLength(50, ErrorMessage = "O {0} deve ter ao menos {2} e até {1} caracteres"), MinLength(3)]
        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Column("preco")]
        [Required(ErrorMessage = "O Preço é obrigatório")]
        [Display(Name = "Preço")]
        public int Preco { get; set; }

    }
}
