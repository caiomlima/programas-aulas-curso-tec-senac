using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradosDe10Num {
    class Program {
        static void Main(string[] args) {

            double i, num;

            Console.WriteLine("Impressão do quadrados de 10 números reais");

            for(i = 1; i <= 10; i++) {
                Console.Write("Digite o " + i + "° número: 1");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine(num + "² = " + Math.Pow(num,2));
            }
            Console.ReadKey();

        }
    }
}
