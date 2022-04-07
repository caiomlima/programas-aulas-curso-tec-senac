using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDe1a200 {
    class Program {
        static void Main(string[] args) {

            int i, soma = 0, num;
            Console.WriteLine("Soma de números de 1 a 200");
            Console.Write("Digite um número inteiro positivo: ");
            num = int.Parse(Console.ReadLine());

            for(i = 1; i <= num; i++) {
                soma += i;
            }

            Console.WriteLine("A soma de 1 a 200, vale: " + soma);
            Console.ReadKey();

        }
    }
}
