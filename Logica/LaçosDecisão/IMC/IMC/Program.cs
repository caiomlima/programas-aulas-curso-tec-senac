using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC {
    class Program {
        static void Main(string[] args) {

            double p, a, imc;

            Console.WriteLine("Calculador de IMC");
            Console.Write("Digite a sua altura: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o seu peso: ");
            p = double.Parse(Console.ReadLine());

            imc = p / Math.Pow(a, 2);

            if(imc < 20) {
                Console.WriteLine("Seu IMC é de " + imc + ", abaixo do peso");
                Console.ReadKey();
            } else if(imc >= 20 && imc < 25) {
                Console.WriteLine("Seu IMC é de " + imc + ", peso normal");
                Console.ReadKey();
            } else if(imc >= 25 && imc < 30) {
                Console.WriteLine("Seu IMC é de " + imc + ", sobre peso");
                Console.ReadKey();
            } else if(imc >= 30 && imc < 40) {
                Console.WriteLine("Seu IMC é de " + imc + ", obesidade");
                Console.ReadKey();
            } else if(imc >= 40) {
                Console.WriteLine("Seu IMC é de " + imc + ", obeso mórbido");
                Console.ReadKey();
            }

        }
    }
}
