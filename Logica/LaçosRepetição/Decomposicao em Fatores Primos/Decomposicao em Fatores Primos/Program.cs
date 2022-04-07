using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposicao_em_Fatores_Primos {
    class Program {
        static void Main(string[] args) {

            int num, fator = 2, multpl;

            Console.WriteLine("Decomposição de um número positivo, em fatores primos");
            Console.Write("Digite um número inteiro positivo: ");
            num = int.Parse(Console.ReadLine());

            while(num > 1) {

                multpl = 0;

                while (num % fator == 0) {
                    multpl++;
                    num = num / fator;
                }

                if(multpl != 0) {
                    Console.WriteLine("Fator: " + fator + " - Multiplicidade: " + multpl); ;
                }

                fator++;

            }

            Console.ReadKey();

        }
    }
}
