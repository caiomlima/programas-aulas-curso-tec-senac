using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestacao {
    class Program {
        static void Main(string[] args) {

            double salario, prestacao, prestacao_maxima;

            Console.WriteLine("Calculador de empréstimo");
            Console.Write("Digite o valor do salário bruto: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da prestação: ");
            prestacao = double.Parse(Console.ReadLine());

            prestacao_maxima = salario * 0.3;
            
            if (prestacao <= prestacao_maxima) {
                Console.WriteLine("Empréstimo aprovado !!");
            } else {
                Console.WriteLine("Empréstimo reprovado");
                Console.WriteLine("Prestação máxima admitida = R$" + Math.Round(prestacao_maxima, 2));
            }
            Console.ReadKey();

        }
    }
}
