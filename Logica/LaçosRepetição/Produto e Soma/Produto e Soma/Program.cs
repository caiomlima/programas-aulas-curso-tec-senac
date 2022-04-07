using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto_e_Soma {
    class Program {
        static void Main(string[] args) {

            int num = 1, prod_impares = 1, soma_pares = 0;

            Console.WriteLine("Vários números - Pares e/ou ímpares");
            Console.WriteLine("Digite um n° inteiro positivo ou 0 para terminar");
            num = int.Parse(Console.ReadLine());

            if(num % 2 == 0) {
                soma_pares += num;
            } else {
                prod_impares *= num;
            }

            while(num > 0) {
                Console.WriteLine("Digite um n° inteiro positivo ou 0 para terminar");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) {
                    soma_pares += num;
                } else {
                    prod_impares *= num;
                }
            }

            Console.Clear();
            Console.WriteLine("Soma dos números Pares digitados = " + soma_pares);
            Console.WriteLine("Produtos dos números ímpares digitados = " + prod_impares);
            Console.ReadKey();

        }
    }
}
