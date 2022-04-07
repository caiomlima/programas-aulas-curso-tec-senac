using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_A_B_Intercalados {
    class Program {
        static void Main(string[] args) {

            int i, j;
            int[] A = new int[4];
            int[] B = new int[4];
            int[] inter = new int[8];

            Console.WriteLine("Vetores A e B intercalados");

            for(i = 0; i < A.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número do vetor A: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for(i = 0; i < B.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número do vetor B: ");
                B[i] = int.Parse(Console.ReadLine());
                inter[2 * i] = A[i];
                inter[2 * i - 1] = B[i];
            }

            Console.Clear();

            for(i = 0, j = 0; j < 8; i++) {
                inter[j++] = A[i];
                inter[j++] = B[i];
            }

            Console.WriteLine("\n\nVetor A");
            for (i = 0; i < A.Length; i++) {
                Console.Write(A[i] + "\t");
            }
            Console.WriteLine("\n\nVetor B");
            for (i = 0; i < B.Length; i++) {
                Console.Write(B[i] + "\t");
            }


            Console.WriteLine("\n\nVetor intercalado");
            for(i = 0; i < inter.Length; i++) {
                Console.Write(inter[i] + "\t");
            }

            Console.ReadKey();

        }
    }
}
