using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadNumInteiro {
    class Program {
        static void Main(string[] args) {

            int n, i;

            Console.WriteLine("Tabuada de um número inteiro positivo");
            Console.Write("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Tabuada do " + n + ":");

            for(i = 0; i <= 10; i++) {
                Console.WriteLine(n + " x " + i + " = " + n * i);
            }
            Console.ReadKey();

        }
    }
}
