using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro {
    class Program {
        static void Main(string[] args) {

            double raio, area, vol, alt;

            Console.WriteLine("Área e volume do cilindro");
            Console.Write("Digite o raio do cilindro em m: ");
            raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do cilindro em m: ");
            alt = double.Parse(Console.ReadLine());

            area = 2 * Math.PI * raio * (alt + raio);
            vol = Math.PI * raio * Math.Pow(alt,2);

            Console.WriteLine("O volume do cilindro é de: " + Math.Round(vol) + " m³, e a área é: " + Math.Round(area) + " m²");
            Console.ReadKey();

        }
    }
}
