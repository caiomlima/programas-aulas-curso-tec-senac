using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Par_ou_Impar {
    class Program {
        static void Main(string[] args) {

            int i;
            int[] v = new int[12];

            Console.WriteLine("Vetores de 12 posições - Par ou ímpar");

            for(i = 0; i < v.Length; i++) {
                Console.Write("Digite v[" + i + "]: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for(i = 0; i < v.Length; i++) {
                if(v[i] % 2 == 0) {
                    Console.WriteLine(v[i] + " é par");
                } else {
                    Console.WriteLine(v[i] + " é ímpar");
                }
            }

            Console.ReadKey();
        }
    }
}
