using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Triangulares {
    class Program {
        static void Main(string[] args) {

            int num, t, aux = 1;
            Console.WriteLine("Números Triangulares - produto de 3 consecutivos...");
            Console.WriteLine("Digite o candidato a nº triangular:");
            num = int.Parse(Console.ReadLine());
            t = aux * (aux + 1) * (aux + 2);
            while (t < num) {
                aux++;
                t = aux * (aux + 1) * (aux + 2);
            }
            if (t == num) { Console.WriteLine(num + " é triangular..."); } else { Console.WriteLine(num + " não é triangular..."); }
            Console.ReadKey();  

        }
    }
}
