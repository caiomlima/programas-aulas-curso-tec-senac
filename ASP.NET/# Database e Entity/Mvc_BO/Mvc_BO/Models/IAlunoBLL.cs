using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BO.Models {
    public interface IAlunoBLL {

        List<Aluno> GetAlunos();

        void IncluirAlunos(Aluno aluno);

        void AtualizarAlunos(Aluno aluno);

    }
}
