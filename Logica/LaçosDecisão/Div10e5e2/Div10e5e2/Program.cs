using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div10e5e2 {
    class Program {
        static void Main(string[] args) {

            int i;

            Console.WriteLine("Números divísiveis por 10, 5 e 2, ou se não é divisível por nenhum deles ou todos eles");
            Console.Write("Digite um número: ");

            i = int.Parse(Console.ReadLine());

            if(i % 2 == 0) {
                Console.WriteLine(i + "é div. por 2");
            } else if(i % 5 == 0) {
                Console.WriteLine(i + "é div. por 5");
            } else if(i % 10 == 0) {
                Console.WriteLine(i + "é div. por 10");
            } else {
                Console.WriteLine(i + "não é div. por 10");
            }
            Console.ReadKey();

        }
    }
}
