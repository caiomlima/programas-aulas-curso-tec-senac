using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSalarial {
    class Program {
        static void Main(string[] args) {

            // 1,5% = 1,5 / 100
            double salario = 1000, novoSalario, aumento = 0.015;
            int i, anoAtual;

            Console.WriteLine("Calculador de aumento salarial anual");
            Console.Write("Digite o ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            novoSalario = salario + aumento * salario;

            for(i = 2016; i < anoAtual; i++) {
                aumento *= 2;
                novoSalario = salario + aumento * salario;
            }

            Console.WriteLine("O salário no ano de " + anoAtual + " é de R$" + Math.Round(novoSalario, 2));
            Console.ReadKey();

        }
    }
}
