using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximo_Divisor_Comum {
    class Program {
        static void Main(string[] args) {

            int a, b, aux, resto;

            Console.WriteLine("Máximo Divisor Comum (MDC) entre dois números inteiros positivos");
            Console.WriteLine("Digite o primeiro número inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            b = int.Parse(Console.ReadLine());

            if(a < b) { // Não existirá divisão e o MDC dará sempre ZERO
                aux = a;
                a = b;
                b = aux;
            }

            resto = a % b;

            while(resto > 0) {
                a = b;
                b = resto;
                resto = a % b;
            }

            Console.WriteLine("O MDC vale: " + b);
            Console.ReadKey();

        }
    }
}
