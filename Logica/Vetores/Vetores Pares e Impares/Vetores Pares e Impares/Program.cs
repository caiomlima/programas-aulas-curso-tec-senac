using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Pares_e_Impares {
    class Program {
        static void Main(string[] args) {

            int i, cont_par = 0, cont_impar = 0;
            int[] num = new int[10];
            int[] par = new int[10];
            int[] impar = new int[10];

            Console.WriteLine("Vetores par e ímpar");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i+1) + "° número: ");
                num[i] = int.Parse(Console.ReadLine());
                if(num[i] % 2 == 0) {
                    cont_par++;
                } else {
                    cont_impar++;
                }
            }

            Console.Clear();

            Console.WriteLine("\n\nVetor original");
            for(i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }

            if(cont_par > 0) {
                Console.WriteLine("Há " + cont_par + " números pares no vetor, que são, respectivamente: ");
                for(i = 0; i < num.Length; i++) {
                    if(num[i] % 2 == 0)
                    Console.Write(num[i] + "\t");
                }
            } else {
                Console.Write("Não foram digitados números pares");
            }

            if (cont_impar > 0) {
                Console.WriteLine("Há " + cont_impar + " números ímpares no vetor, que são, respectivamente: ");
                for (i = 0; i < num.Length; i++) {
                    if (num[i] % 2 == 1)
                        Console.Write(num[i] + "\t");
                }
            } else {
                Console.Write("Não foram digitados números ímpares");
            }

            Console.ReadKey();

        }
    }
}
