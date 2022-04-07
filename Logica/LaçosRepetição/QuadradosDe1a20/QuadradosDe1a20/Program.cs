using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradosDe1a20 {
    class Program {
        static void Main(string[] args) {

            double i = 1;

            Console.WriteLine("Quadrados dos números de 1 a 20");

            while(i <= 20) {
                Console.WriteLine(i + "² = " + (i * i));
                i++;
            }
            Console.ReadKey();

        }
    }
}
