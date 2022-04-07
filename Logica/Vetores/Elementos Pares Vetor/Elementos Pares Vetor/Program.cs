using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Pares_Vetor {
    class Program {
        static void Main(string[] args) {

            int i, cont_pares = 0;
            int[] v = new int[10];

            Console.WriteLine("Vetor de 10 números inteiros - Pares");

            for(i = 0; i < v.Length; i++) {
                Console.Write("Digite o v[" + i + "]: ");
                v[i] = int.Parse(Console.ReadLine());
                if(v[i] % 2 == 0) {
                    cont_pares++;
                }
            }

            Console.Clear();

            // Impressão original
            Console.Write("Impressão do vetor original\n");
            for (i = 0; i < v.Length; i++) {
                Console.Write(v[i] + "\t");
            }
            if(cont_pares > 0) {
                Console.WriteLine("Elementos pares do vetor: \n");
                for(i = 0; i < v.Length; i++) {
                    if(v[i] % 2 == 0) {
                        Console.WriteLine(v[i]);
                    }
                }
            } else {
                Console.WriteLine("Não foram digitados números pares ...");
            }

            //for(i = 0; i < v.Length; i++) {
            //    if(v[i] % 2 == 0) {
            //        Console.WriteLine(v[i] + " é par");
            //    } else {
            //        Console.WriteLine(v[i]);
            //    }
            //}

            Console.ReadKey();

        }
    }
}
