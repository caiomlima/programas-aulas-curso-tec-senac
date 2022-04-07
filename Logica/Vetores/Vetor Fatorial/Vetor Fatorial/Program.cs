using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Fatorial {
    class Program {
        static void Main(string[] args) {

            int i, j, fat;
            int[] num = new int[5];

            Console.WriteLine("Vetor fatorial");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("\n\nVetor original");
            for(i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }

            Console.WriteLine("\n\nVetor fatorial");
            for(i = 0; i < num.Length; i++) {
                fat = 1;

                for(j = 1; j <= num[i]; j++) {
                    fat *= j;
                    // fat = fat * j;
                }
                Console.WriteLine(fat + "\t");

            }

            Console.ReadKey();

        }
    }
}
