using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeranca {
    public class Funcionario : DadosPessoais {

        private double salario;
        private string funcao;

        public double getSalario() {
            return this.salario;
        }
        public string getFuncao() {
            return this.funcao;
        }

        public void setSalario(double salario) {
            this.salario = salario;
        }
        public void setFuncao(string funcao) {
            this.funcao = funcao;
        }

    }
}
