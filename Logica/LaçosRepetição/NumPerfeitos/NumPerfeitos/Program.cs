using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumPerfeitos {
    class Program {
        static void Main(string[] args) {

            int n, i, soma = 0;

            Console.WriteLine("Verica se um número inteiro é perfeito ou não");
            Console.Write("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            for(i = 1; i < n; i++) {
                if(n % i == 0 ) {
                    soma += i;
                }
            }
            if(soma == n) {
                Console.WriteLine(n + " é perfeito");
            } else {
                Console.WriteLine(n + " não é perfeito");
            }

            Console.ReadKey();

        }
    }
}
