using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordenadas {
    class Program {
        static void Main(string[] args) {

            double xa, xb, ya, yb, d;

            Console.WriteLine("Distancia entre dois pontos A(xA e xB) e B(yA e yB)");
            Console.Write("Digite o valor da abcissa de A (xA): ");
            xa = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da ordenada de A (yA): ");
            ya = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da abcissa de B (xB): ");
            xb = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da ordenada de B (yB): ");
            yb = double.Parse(Console.ReadLine());

            d = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

            Console.WriteLine("A distancia entre A e B, é: " + Math.Round(d, 3));
            Console.ReadKey();
        }
    }
}
