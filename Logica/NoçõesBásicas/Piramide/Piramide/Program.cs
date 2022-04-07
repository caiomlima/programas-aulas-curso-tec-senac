using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide {
    class Program {
        static void Main(string[] args) {

            double b, a, v;

            Console.WriteLine("Calculador de base e altura de uma pirâmide");
            Console.Write("Digite a base da pirâmide: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura da pirâmide: ");
            a = double.Parse(Console.ReadLine());

            v = (b * a) / 3;

            Console.WriteLine("O volume da pirâmide é: " + v);
            Console.ReadLine(); 

        }
    }
}
