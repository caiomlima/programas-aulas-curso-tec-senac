using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equac2Grau {
    class Program {
        static void Main(string[] args) {

            double a, b, c, d, x1, x2;

            Console.WriteLine("Equação de segundo grau");
            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            d = (Math.Pow(b,2) - 4) * a * c;

            if (d > 0) {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("Há duas raízes: " + x1 + " e " + x2);
            } else if(d == 0) {
                x1 = -b / (2 * a);
                Console.WriteLine("Equação só tem uma raíz: " + x1);
            } else {
                Console.WriteLine("Não existe raiz real");
            }
        }
    }
}
