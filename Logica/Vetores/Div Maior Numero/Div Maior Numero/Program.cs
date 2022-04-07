using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div_Maior_Numero {
    class Program {
        static void Main(string[] args) {

            int i;
            double maior, menor;
            double[] v = new double[15];
            double[] vmaior = new double[15];
            double[] vmenor = new double[15];
            Console.WriteLine("Vetor de 15 inteiros - divisão pelo maior e pelo menor nº");
            Console.WriteLine("Carregando o vetor original...");
            for (i = 0; i < v.Length; i++) {
                Console.WriteLine("Digite v[" + i + "]:");
                v[i] = double.Parse(Console.ReadLine());
            }
            maior = v[0]; menor = v[0];
            for (i = 0; i < v.Length; i++) {
                if (v[i] > maior) { maior = v[i]; }
                if (v[i] < menor) { menor = v[i]; }
            }
            Console.Clear();
            Console.WriteLine("Vetor Original:");
            for (i = 0; i < v.Length; i++) {
                Console.Write(v[i] + "  ");
                vmaior[i] = v[i] / maior;
                vmenor[i] = v[i] / menor;
            }
            Console.WriteLine("\n\nVetor Original dividido pelo menor = " + menor);
            for (i = 0; i < v.Length; i++) { Console.Write(Math.Round(vmenor[i], 2) + "  "); }
            Console.WriteLine("\n\nVetor Original dividido pelo maior = " + maior);
            for (i = 0; i < v.Length; i++) { Console.Write(Math.Round(vmaior[i], 2) + "  "); }
            Console.ReadKey();
        }
    }
}
