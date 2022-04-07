using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisores {
    class Program {

        static void divs(int num) {
            int i;
            for(i = 1; i <= num; i++) {
                if(num % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }

        static void primo(int num) {
            int i, cont = 0;
            for (i = 1; i <= num; i++) {
                if (num % i == 0) {
                    cont++;
                }
            }
            if(cont == 2) {
                Console.WriteLine("O número " + num + " é primo, pois tem extamente 2 divisores!");
            } else {
                Console.WriteLine("O número " + num + " não é primo");
            }
        }

        static void Main(string[] args) {

            int n;
            Console.WriteLine("Função - Divs");
            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisores de " + n + ":\n");
            divs(n);
            primo(n);

            Console.ReadKey();

        }
    }
}
