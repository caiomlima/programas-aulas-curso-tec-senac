using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantidade_de_Numeros_Primos {
    class Program {
        static void Main(string[] args) {

            int i, num, div, cont, cont_div, cont_primos = 0;
            Console.WriteLine("Dez números inteiros positivos - Quantos são primos ?");

            for(i = 1; i<= 10; i++) {
                Console.WriteLine("Digite o " + i + "° número positivo: ");
                num = int.Parse(Console.ReadLine());

                cont_div = 0;

                for(div = 1; div <= num; div++) {
                    if(num % div == 0) {
                        cont_div++;
                    }
                }

                if(cont_div == 2) {
                    cont_primos++;    
                }

            }

            Console.Clear();
            Console.WriteLine("Foram digitados " + cont_primos + " números primos");
            Console.ReadKey();

        }
    }
}
