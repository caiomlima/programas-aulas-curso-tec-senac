using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisores_de_varios_numeros {
    class Program {
        static void Main(string[] args) {

            int num, i;

            Console.WriteLine("Programa que lê varios números e mostra os seus divisores");
            Console.Write("Digite um número positivo, ou 0 para terminar: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisores de " + num + ":");

            while(num > 0) {

                for(i = 1; i <= num; i++) {
                    if(num % i == 0) {
                        Console.WriteLine(i);
                    }
                }

                Console.Write("Digite um número positivo, ou 0 para terminar: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Divisores de " + num + ":");

            }

            Console.ReadKey();

        }
    }
}
