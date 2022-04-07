using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqQuad {
    class Program {
        static void Main(string[] args) {

            double a, b, c, delta;

            Console.WriteLine("Calculo do Descriminante Delta da equação ax² + bx + c = 0");
            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine("O valor do descriminante (Delta) é: " + delta);
            Console.ReadKey();

        }
    }
}
