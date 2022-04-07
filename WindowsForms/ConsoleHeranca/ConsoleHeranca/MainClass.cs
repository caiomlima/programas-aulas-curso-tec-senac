using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeranca {
    class MainClass {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.WriteLine("Dados Cadastrais");
            Linha();
            Console.Write("\nNome: ");
            f.setNome(Console.ReadLine());

            Console.Write("\nEndereco: ");
            f.setEndereco(Console.ReadLine());

            Console.Write("\nCidade: ");
            f.setCidade(Console.ReadLine());

            Console.Write("\nTelefone: ");
            f.setTelefone(Console.ReadLine());

            Console.Write("\nFunção: ");
            f.setFuncao(Console.ReadLine());

            try {
                Console.Write("Salário: ");
                f.setSalario(double.Parse(Console.ReadLine()));

                Console.WriteLine("\nNome: " + f.getNome().ToUpper());
                Console.WriteLine("Endereço: " + f.getEndereco().ToUpper());
                Console.WriteLine("Cidade: " + f.getCidade().ToUpper());
                Console.WriteLine("Telefone: " + f.getFone());
                Console.WriteLine("Função: " + f.getFuncao().ToUpper());
                Console.WriteLine("Salário: " + f.getSalario().ToString());

            } catch(Exception error) {
                Console.Write(error.Message);
            } finally {
                Console.WriteLine("Pressione uma tecla para finalizar o programa");
                Console.ReadKey();
            }

        }

        public static void Linha() {
            for(int i = 0; i <= 100; i++) {
                Console.Write("-");
            }
        }
    }
}
