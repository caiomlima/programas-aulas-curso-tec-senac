using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantidade_Negativos_e_Positivos {
    class Program {
        static void Main(string[] args) {

            int i, cont_negativo = 0, cont_pos = 0;
            double[] num = new double[10];
            double soma_pos = 0;

            Console.WriteLine("10 números reais");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número: ");
                num[i] = double.Parse(Console.ReadLine());
                if(num[i] > 0) {
                    soma_pos += num[i];
                    cont_pos++;
                } else if(num[i] < 0) {
                    cont_negativo++;
                }
            }

            Console.Clear();

            Console.WriteLine("Vetor de 10 elementos:\n");

            for (i = 0; i < num.Length; i++) {
                Console.WriteLine(num[i] + "\t");
            }
            if(cont_pos > 0) {
                Console.WriteLine("\nSoma dos positivos: " + soma_pos);
            } else {
                Console.WriteLine("\nNão foram digitados números positivos no vetor");
            }
            Console.WriteLine("\nForam digitados " + cont_negativo + " números negativos no vetor");

            Console.ReadKey();

        }
    }
}
