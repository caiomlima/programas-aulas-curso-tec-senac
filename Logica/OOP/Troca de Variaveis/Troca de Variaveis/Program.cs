using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troca_de_Variaveis {
    class Program {

        static void troca(int a, int b) {
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("Variáves trocadas: ");
            Console.WriteLine("1° Variável: " + a);
            Console.WriteLine("2° Variável: " + b);
        }

        static void Main(string[] args) {

            int x, y;

            Console.WriteLine("Troca de váriaveis - usando OOP");
            Console.Write("Digite o valor da primeira variável: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da segunda variável: ");
            y = int.Parse(Console.ReadLine());

            troca(x, y);

            Console.ReadKey();

        }
    }
}
