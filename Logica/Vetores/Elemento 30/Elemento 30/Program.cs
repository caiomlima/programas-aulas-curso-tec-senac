using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemento_30 {
    class Program {
        static void Main(string[] args) {

            int[] num = new int[8];
            int i, cont_trinta = 0;

            Console.WriteLine("Identificador de números inteiros com valor 30");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número inteiro: ");
                num[i] = int.Parse(Console.ReadLine());
                if(num[i] == 30) {
                    cont_trinta++;
                }
            }

            Console.Clear();

            for(i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }

            //for(i = 0; i < num.Length; i++) {
            //    if(num[i] == 30) {
            //        Console.WriteLine("\nO índice " + (i+1) + " possui o número 30");
            //    } else {
            //        Console.WriteLine("\nO índice " + (i+1) + " não possui o número 30");
            //    }
            //}

            if(cont_trinta > 0) {
                Console.WriteLine("\nHá " + cont_trinta + " números trinta");
                for(i = 0; i < num.Length; i++) {
                    if(num[i] == 30) {
                        Console.Write(i + "\t");
                    }
                }
            } else {
                Console.WriteLine("\n\nNão há ocorrencias do número 30 no vetor");
            }

            Console.ReadKey();

        }
    }
}
