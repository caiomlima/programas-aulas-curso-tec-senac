using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemp {
    class Program {
        static void Main(string[] args) {

            double f, c;

            Console.WriteLine("Conversão de temperaturas Fahrenheit (F°) em Celcius (C°)");
            Console.Write("Digite a temperatura em F°: ");
            f = double.Parse(Console.ReadLine());

            c = (f - 32) * 5 / 9;

            Console.WriteLine("\nA temperatura é " + Math.Round(c, 1) + "C°");

            Console.ReadKey();

        }
    }
}
