using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao1 {
    class Program {
        static void Main(string[] args) {

            int i = 1;

            Console.WriteLine("Números de 1 a 100 na tela:");

            while(i <= 100) {
                Console.WriteLine("Número " + i);
                i++;
            }

            Console.ReadKey();

        }
    }
}
