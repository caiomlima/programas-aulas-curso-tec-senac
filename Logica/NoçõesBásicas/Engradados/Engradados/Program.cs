using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engradados {
    class Program {
        static void Main(string[] args) {

            int garrafas, engradados, sobra;

            Console.WriteLine("Engradados de cerveja (1 engradados = 24 garrafas)");
            Console.Write("Digite a quantidade de garrafas a embalar: ");
            garrafas = int.Parse(Console.ReadLine());

            engradados = garrafas / 24;
            sobra = garrafas % 24;

            Console.WriteLine("Serão nescessários " + engradados + " engradados de cerveja e sobrarão " + sobra + " garrafas sem embalar");
            Console.ReadKey();

        }
    }
}
