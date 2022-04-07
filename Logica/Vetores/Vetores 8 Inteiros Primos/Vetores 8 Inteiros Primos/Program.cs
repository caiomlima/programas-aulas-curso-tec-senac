using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_8_Inteiros_Primos {
    class Program {
        static void Main(string[] args) {

            int i, div = 0, cont;
            int[] num = new int[8];

            Console.WriteLine("8 números inteiro com seus primos e posições");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.Write("\nVetor original: ");
            for(i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }

            Console.WriteLine("\n\nVetor classificado em primos ou não");
            for(i = 0; i < num.Length; i++) {
                cont = 0;

                for (div = 1; div <= num.Length; div++) {
                    if (num[i] % div == 0) {
                        cont++;
                    }
                }

                if (cont == 2) {
                    Console.WriteLine(num[i] + " é primo, na posição " + i);
                } else {
                    Console.WriteLine(num[i] + " não é primo");
                }
            }

            Console.ReadKey();

        }
    }
}
