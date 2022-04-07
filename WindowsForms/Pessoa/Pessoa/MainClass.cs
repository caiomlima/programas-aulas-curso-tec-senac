using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa {
    class MainClass {
        static void Main(string[] args) {

            Pessoa p = new Pessoa();
            Linha();

            Console.Write("\nDigite seu nome: ");

            p.setNome(Console.ReadLine());

            Linha();

            try {
                Console.Write("\nDigite sua idade: ");
                p.setIdade(int.Parse(Console.ReadLine()));
                Linha();
                Console.WriteLine("\nNome: " + p.getNome().ToUpper() + " e idade: " + p.getIdade() + " anos");
                Linha();
            } catch(Exception error) {
                Linha();
                Console.Write("\n" + error.Message + "\n");
            } finally {
                Console.WriteLine("\n\nPrecione uma tecla para finalizar o programa");
                Console.ReadKey();
            }
        }

        public static void Linha() {
            for(int i = 1; i < 60; i++) {
                Console.Write("-");
            }
        }
    }
}
