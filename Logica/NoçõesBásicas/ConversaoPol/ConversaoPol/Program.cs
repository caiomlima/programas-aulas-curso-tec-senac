using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoPol {
    class Program {
        static void Main(string[] args) {

            double p, m;

            Console.WriteLine("Conversor de quantidade de chuvas de polegadas em milímetros");
            Console.WriteLine("Digite a quantidade de chuva em polegadas: ");

            p = double.Parse(Console.ReadLine());

            m = p * 25.4;

            Console.WriteLine("O valor de polegadas em mm é: " + m);
            Console.ReadKey();

        }
    }
}
