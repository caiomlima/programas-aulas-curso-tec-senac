using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsPrimos {
    class Program {
        static void Main(string[] args) {

            int n, contador = 0;

            Console.WriteLine("Confere se um número inteiro é primo ou não");
            Console.Write("Digite um número inteiro");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++) {
                if(n % i == 0) {
                    contador++;
                }   
            }
            if(contador == 2) {
                Console.WriteLine(n + " é primo");
            } else {
                Console.WriteLine(n + " não é primo");
            }

        }
    }
}
