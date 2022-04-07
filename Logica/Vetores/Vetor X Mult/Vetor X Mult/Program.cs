using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_X_Mult {
    class Program {
        static void Main(string[] args) {

            int i, x;
            int[] num = new int[8];

            Console.WriteLine("Vetor de 8 números escalar com valor x");

            for(i = 0; i < num.Length; i++) {
                Console.Write("\nDigite o " + (i + 1) + "° número: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite o valor do n° escalar x: ");
            x = int.Parse(Console.ReadLine());

            Console.Clear();

            // Vetor original
            Console.Write("Vetor original: " + "\t");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }

            // Vetor escalar x
            Console.Write("\n\nValor resultante com valor x de " + x + ": " + "\t");
            for (i = 0; i < num.Length; i++) {
                Console.Write(x * num[i] + "\t");
            }

            Console.ReadKey();

        }
    }
}
