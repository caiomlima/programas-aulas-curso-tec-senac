using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradosDe1a20For {
    class Program {
        static void Main(string[] args) {

            double i;

            Console.WriteLine("Quadrados de 1 até 20");

            for(i = 1; i <= 20; i++ ) {
                Console.WriteLine(i + "² = " + Math.Pow(i,2));
            }

            Console.ReadKey();

        }
    }
}
