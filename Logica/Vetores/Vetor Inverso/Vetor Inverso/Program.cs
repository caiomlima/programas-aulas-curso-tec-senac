using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Inverso {
    class Program {
        static void Main(string[] args) {

            int i;
            int[] num = new int[8];

            Console.WriteLine("Vetor ao contrário");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Vetor original: ");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }

            Console.WriteLine("\n\nVetor ao contrário: ");
            for (i = num.Length - 1; i >= 0; i--) {
                Console.Write(num[i] + "\t");
            }

            Console.ReadKey();

        }
    }
}
