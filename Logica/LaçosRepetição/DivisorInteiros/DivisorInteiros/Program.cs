using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorInteiros
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, cont = 0;
            Console.WriteLine("Divisores de um número inteiro positivo");
            Console.Write("Digite um número inteiro positivo: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++) {
                if(n % i == 0) {
                    Console.WriteLine(i);
                    cont++;
                }
            }
            Console.WriteLine("Cont: " + cont);
            Console.ReadKey();

        }
    }
}
