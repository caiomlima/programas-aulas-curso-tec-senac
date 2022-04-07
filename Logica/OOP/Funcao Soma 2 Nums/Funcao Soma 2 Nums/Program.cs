using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao_Soma_2_Nums {
    class Program {

        public static int soma(int x, int y) {
            return x + y;
        }

        static void Main(string[] args) {

            int num1, num2;

            Console.WriteLine("Soma de dois números em OOP");
            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da soma é " + soma(num1, num2));

            Console.ReadKey();

        }
    }
}
