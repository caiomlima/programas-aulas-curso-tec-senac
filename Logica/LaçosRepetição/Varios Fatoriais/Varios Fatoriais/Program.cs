using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varios_Fatoriais {
    class Program {
        static void Main(string[] args) {

            int i, num, fat = 1;

            Console.WriteLine("Fatorial de vários números");
            Console.Write("Digite um número maior ou igual a 1: ");
            num = int.Parse(Console.ReadLine());

            while(num >= 1) {

                for(i = 1; i < num; i++) {
                    fat *= 1;
                }

                Console.WriteLine(num + "! = " + fat);

                Console.Write("Digite um número maior ou igual a 1: ");
                num = int.Parse(Console.ReadLine());

            }

            Console.ReadKey();

        }
    }
}
