using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeranca {
    public class DadosPessoais {

        public string nome;
        public string endereco;
        public string cidade;
        public string fone;

        public string getNome() {
            return this.nome;
        }
        public string getEndereco() {
            return this.endereco;
        }
        public string getCidade() {
            return this.cidade;
        }
        public string getFone() {
            return this.fone;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }
        public void setEndereco(string endereco) {
            this.endereco = endereco;
        }
        public void setCidade(string cidade) {
            this.cidade = cidade;
        }
        public void setTelefone(string fone) {
            this.fone = fone;
        }
    }
}
