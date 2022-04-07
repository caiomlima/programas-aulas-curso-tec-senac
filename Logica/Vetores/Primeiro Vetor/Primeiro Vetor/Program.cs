using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Vetor {
    class Program {
        static void Main(string[] args) {

            int[] v = new int[10];
            int i;

            Console.WriteLine("Vetor de 10 posições");

            for(i = 0; i < v.Length; i++) {
                Console.Write("Digite v[" + i + "]:");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for(i = 0; i < v.Length; i++) {
                Console.Write(v[i] + "\t");
            }

            Console.ReadKey();

        }
    }
}
