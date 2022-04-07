using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Programa_OOP {
    class Program {

        public static double cubo(double x) {
            return Math.Pow(x, 3);
        }

        static void Main(string[] args) {

            double num;

            Console.WriteLine("Cubo de um número usando OOP");
            Console.Write("Digite um número real: ");
            num = double.Parse(Console.ReadLine());

            Console.WriteLine("O cubo de " + num + " vale: " + cubo(num));
            Console.ReadKey();

        }


    }
}
