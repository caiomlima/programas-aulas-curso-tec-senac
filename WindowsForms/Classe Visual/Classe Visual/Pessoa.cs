using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa {
    public class Pessoa {

        private string nome;
        private int idade;

        public void setNome(string nome) {
            this.nome = nome;
        }

        public void setIdade(int idade) {
            this.idade = idade;
        }

        public string getNome() {
            return this.nome;
        }

        public int getIdade() {
            return this.idade;
        }

    }
}
