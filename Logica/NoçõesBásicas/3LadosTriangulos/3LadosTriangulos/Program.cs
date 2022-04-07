using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LadosTriangulos {
    class Program {
        static void Main(string[] args) {

            double T, l1, l2, l3, area;

            Console.WriteLine("Calculo da área de um triângulo - Fórmula de Herão");
            Console.Write("Digite o valor do primeiro lado do triângulo: ");
            l1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo lado do triângulo: ");
            l2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro lado do triângulo: ");
            l3 = double.Parse(Console.ReadLine());

            T = (l1 + l2 + l3) / 2;
            area = Math.Sqrt(T * (T - l1) * (T - l2) * (T - l3));

            Console.WriteLine("A área do triângulo vale: " + Math.Round(area));
            Console.ReadKey();
        }
    }
}
