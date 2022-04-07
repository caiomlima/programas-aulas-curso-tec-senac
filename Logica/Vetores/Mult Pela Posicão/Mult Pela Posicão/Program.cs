using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mult_Pela_Posicão {
    class Program {
        static void Main(string[] args) {

            int i;
            double[] vet = new double[10];
            Console.WriteLine("Vetor de 10 elementos e vetor de seus quadrados...");
            Console.WriteLine("Carregando o vetor....");
            for (i = 0; i < vet.Length; i++) {
                Console.WriteLine("Digite vet[" + i + "]:");
                vet[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Vetor original de 10 elementos: ");
            for (i = 0; i < vet.Length; i++) {
                Console.Write(vet[i] + "  ");
            }
            Console.WriteLine("\n\nVetor original de 10 elementos, elevados ao quadrado: ");
            for (i = 0; i < vet.Length; i++) {
                Console.Write(Math.Round(Math.Pow(vet[i], 2), 1) + "  ");
            }
            Console.WriteLine("\n\nVetor de elementos multiplicados pela sua posição:");
            for (i = 0; i < vet.Length; i++) {
                Console.Write(i * vet[i] + "  ");
            }
            Console.ReadKey();

        }
    }
}
