using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_de_Fibonacci {
    class Program {
        static void Main(string[] args) {

            int n, ant = 0, atual = 1, prox, i;

            Console.WriteLine("Série de Fibonacci: 1 1 2 3 5 ....");
            Console.WriteLine("Digite o n° de termos da Série, que deseja imprimir na tela: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Série de Fibonacci com " + n + " termos: ");
            for(i = 1; i <= n; i++){
                Console.WriteLine(atual);
                prox = ant + atual;
                ant = atual;
                atual = prox;
            }

            Console.ReadKey();

        }
    }
}
