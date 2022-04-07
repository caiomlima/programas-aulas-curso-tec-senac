using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posicoes_X_e_Y {
    class Program {
        static void Main(string[] args) {

            int i, x, y, soma = 0;
            int[] num = new int[8];

            Console.WriteLine("Vetor de 8 números que soma as opsições de X e Y");

            for(i = 0; i < num.Length; i++) {
                Console.Write("Digite o " + (i + 1) + "° número: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.Write("Digite o valor da posição de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o da posição de Y: ");
            y = int.Parse(Console.ReadLine());

            if(x >=0 && x < 8 && y >= 0 && y < 8) {
                soma = num[x] + num[y];
            } else {
                Console.WriteLine("Valores de X e Y devem estar entre 0 e 7");
                Console.Write("Digite o valor da posição de X: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("\n\nDigite o da posição de Y: ");
                y = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Vetor Completo: ");
            for(i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }
            Console.WriteLine("\n\nA soma dos elementos das posições " + x + " e " + y + " = " + soma);

            //i = x;
            //Console.Write("\n\nO número na posição de X " + x + " é: " + num[i]);

            //i = y;
            //Console.Write("\n\nO número na posição de Y " + y + " é: " + num[i]);

            Console.ReadKey();

        }
    }
}
