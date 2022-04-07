using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Dif_e_Soma {
    class Program {
        static void Main(string[] args) {

            int i;
            int[] vA = new int[6];
            int[] vB = new int[6];
            int[] soma = new int[6];
            int[] dif = new int[6];

            Console.WriteLine("Dois vetores de 6 números");

            // Vetor A
            Console.WriteLine("Vetor A");
            for (i = 0; i < vA.Length; i++) {
                Console.Write("\nDigite o " + (i + 1) + "° número inteiro do Vetor A: ");
                vA[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            // Vetor B
            Console.WriteLine("Vetor A");
            for (i = 0; i < vB.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número inteiro do Vetor B: ");
                vB[i] = int.Parse(Console.ReadLine());
                soma[i] = vA[i] + vB[i];
                dif[i] = vA[i] - vB[i];
            }

            Console.Clear();

            // Impressão do Vetor A
            Console.Write("\n\nVetor A: ");
            for(i = 0; i < vA.Length; i++) {
                Console.Write(vA[i] + "\t");
            }

            // Impressão do Vetor B
            Console.Write("\n\nVetor B: ");
            for (i = 0; i < vB.Length; i++) {
                Console.Write(vB[i] + "\t");
            }

            // Vetor Soma
            Console.Write("\n\nVetor de soma | Os resultados são: ");
            for (i = 0; i < soma.Length; i++) {
                Console.Write(soma[i] + "\t");
            }

            // Vetor Soma
            Console.Write("\n\nVetor de diferença | Os resultados são: ");
            for (i = 0; i < dif.Length; i++) {
                Console.Write(dif[i] + "\t");
            }


            Console.ReadKey();
        }
    }
}
