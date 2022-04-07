using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos {
    class Program {

        static void verifica_triangulo(double a, double b, double c) {
            if(a < (b + c) && b < (c + a) && c < (a + b)) {
                Console.WriteLine(a + ", " + b + ", " + c + " formam um triangulo");
            } else {
                Console.WriteLine(a + ", " + b + ", " + c + " não formam um triangulo");
            }
        }

        static void Main(string[] args) {

            double x, y, z;

            Console.WriteLine("Função que verifica triangulos - OOP");
            Console.Write("Digite o valor do primeiro lado: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado: ");
            y = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado: ");
            z = double.Parse(Console.ReadLine());

            verifica_triangulo(x, y, x);

            Console.ReadKey();

        }
    }
}
