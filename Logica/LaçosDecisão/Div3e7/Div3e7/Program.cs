using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div3e7 {
    class Program {
        static void Main(string[] args) {

            int i;

            Console.WriteLine("Números divísiveis por 3 e 7");
            Console.Write("Digite um número: ");
            i = int.Parse(Console.ReadLine());

            if(i % 3 == 0 && i % 7 == 0) {
                Console.WriteLine("É divísivel por 3 e por 7, ao mesmo tempo");
                Console.ReadLine();
            } else {
                Console.WriteLine("Não é divísivel por 3 e por 7");
                Console.ReadLine();
            }

        }
    }
}
