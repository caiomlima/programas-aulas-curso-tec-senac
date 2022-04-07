using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_de_Ricci {
    class Program {
        static void Main(string[] args) {

            int n, n1, n2, proximo, i;
            Console.WriteLine("Série de Ricci:  dois primeiros termos fixos");
            Console.WriteLine("Série de Ricci:  os demais gerados via Fibonacci");
            Console.WriteLine("Digite o 1º termos da Série de Ricci: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º termos da Série de Ricci: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nº de termos da Série, que deseja imprimir na tela: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nSérie de Ricci com " + n + " termos: \n");
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for (i = 1; i <= n; i++) {
                proximo = n1 + n2;
                n1 = n2;
                n2 = proximo;
                Console.WriteLine(n2);
            }
            Console.ReadKey();

        }
    }
}
