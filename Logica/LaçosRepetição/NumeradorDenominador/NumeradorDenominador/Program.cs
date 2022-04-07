using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeradorDenominador {
    class Program {
        static void Main(string[] args) {

            double i, n, num, soma = 0;

            Console.WriteLine("Numerador e denominador");
            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            n = num;

            for(i = 1; i <= num; i++) {
                soma += i / n;
                n--;
            }

            Console.WriteLine("A soma de " + num + " frações , vale: " + Math.Round(soma, 2));
            Console.ReadKey();

        }
    }
}
