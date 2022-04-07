using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangulosABC {
    class Program {
        static void Main(string[] args) {

            double a, b, c, area, p;

            Console.WriteLine("Verificação da existência de triângulos");
            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            if (a < (b + c) && b < (c + a) && c < (a + b)) {

                Console.WriteLine("Formam um triângulo");

                if (a == b && b == c) {
                    Console.WriteLine("Triângulo equilátero");
                } else if (a == b || b == c || c == a) {
                    Console.WriteLine("Triângulo isóceles");
                } else {
                    Console.WriteLine("Triângulo escaleno");
                }
                p = (a + b + c) / 2;
                area = (p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Área do triângulo = " + Math.Round(area, 2));

            } else {
            Console.WriteLine("Não forma um triângulo");
            }
            
            Console.ReadKey();

        }
    }
}
