using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordena3Num {
    class Program {
        static void Main(string[] args) {

            int num1, num2, num3;

            Console.WriteLine("Ordenador de números em ordem crescente");
            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if(num1 < num2 && num2 < num3) {
                Console.WriteLine("A ordem é: " + num1 + ", " + num2 + " e " + num3 + ", num1 num2 e num3");
            } else if(num1 < num3 && num3 < num2) {
                Console.WriteLine("A ordem é: " + num1 + ", " + num3 + " e " + num2 + ", num1 num3 e num2");
            } else if(num2 < num1 && num1 < num3) {
                Console.WriteLine("A ordem é: " + num2 + ", " + num1 + " e " + num3 + ", num2 num1 e num3");
            } else if(num2 < num3 && num3 < num1) {
                Console.WriteLine("A ordem é: " + num2 + ", " + num3 + " e " + num1 + ", num2 num3 e num1");
            } else if (num3 < num1 && num1 < num2) {
                Console.WriteLine("A ordem é: " + num3 + ", " + num1 + " e " + num2 + ", num3 num1 e num2");
            } else {
                Console.WriteLine("A ordem é: " + num3 + ", " + num2 + " e " + num1 + ", num3 num2 e num1");
            }

        }
    }
}
