using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno {
    class Program {
        static void Main(string[] args) {

            double media;
            string nome;

            Console.WriteLine("Calculador de média");
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a nota da sua média: ");
            media = double.Parse(Console.ReadLine());

            if (media >= 9) {
                Console.WriteLine("O(A) aluno(a) " + nome + " é altamente recomendado");
            } else if (media >= 8) {
                Console.WriteLine("O(A) aluno(a) " + nome + " é fortemente recomendado");
            } else if(media >= 7) {
                Console.WriteLine("O(A) aluno(a) " + nome + " é recomendado");
            } else {
                Console.WriteLine("O(A) aluno(a) " + nome + " é não recomendado");
            }

        }
    }
}
