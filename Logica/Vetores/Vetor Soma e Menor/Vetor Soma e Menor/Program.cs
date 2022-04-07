using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Soma_e_Menor {
    class Program {
        static void Main(string[] args) {

            int i, soma = 0, menor, maior, pos_menor = 0, pos_maior = 0;
            int[] num = new int[10];

            Console.WriteLine("A");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número inteiro: ");
                num[i] = int.Parse(Console.ReadLine());
                soma += num[i];
            }

            maior = num[0];
            menor = num[0];

            Console.Clear();

            // Vetor original
            Console.Write("Vetor orignal: ");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
                if(num[i] < menor) {
                    menor = num[i];
                    pos_menor = i;
                }
                if (num[i] > maior) {
                    maior = num[i];
                    pos_maior = i;
                }
            }

            // Soma de todos os elementos
            Console.WriteLine("Soma de todos os números do vetor: " + soma);
            Console.WriteLine("Maior Elemento do vetor: " + maior + " na posição " + pos_maior);
            Console.WriteLine("Menor Elemento do vetor: " + menor + " na posição " + pos_menor);
            Console.ReadKey();

        }
    }
}
