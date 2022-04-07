using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_Valores_Vetor {
    class Program {
        static void Main(string[] args) {

            int i, x, cont_x = 0;
            int[] num = new int[8];

            Console.WriteLine("Busca de valores em um vetor");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número do vetor: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Vetor original");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t ");
                if(num[i] == x) {
                    cont_x++;
                }
            }

            if(cont_x > 0) {
                Console.WriteLine("\nO número " + x + " aparece nas posições");
                for (i = 0; i < num.Length; i++) {
                    if (num[i] == x) {
                        Console.Write(i + "\t");
                    }
                }
            } else {
                Console.WriteLine("\n\nNão foi encontrada nenhuma ocorrencia de " + x);
            }

            Console.ReadKey();

        }
    }
}
