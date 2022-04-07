using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico {
    class Program {
        static void Main(string[] args) {

            int qtd, n200, n100, n50, n20, n10, n5, n2, n1;

            Console.WriteLine("Caixa eletrônico");
            Console.Write("Digite a quantidade de dinheiro que deseja sacar: ");
            qtd = int.Parse(Console.ReadLine());

            n200 = qtd / 200;
            n100 = (qtd % 200) / 100;
            n50 = ((qtd % 200) % 100) / 50;
            n20 = (((qtd % 200) % 100) % 50) / 20;
            n10 = ((((qtd % 200) % 100) % 50) % 20) / 10;
            n5 = (((((qtd % 200) % 100) % 50) % 20) % 10) / 5;
            n2 = ((((((qtd % 200) % 100) % 50) % 20) % 10) % 5) / 2;
            n1 = (((((((qtd % 200) % 100) % 50) % 20) % 10) % 5)) % 2;

            Console.WriteLine(n200 + " notas de R$200");
            Console.WriteLine(n100 + " notas de R$100");
            Console.WriteLine(n50 + " notas de R$50");
            Console.WriteLine(n20 + " notas de R$20");
            Console.WriteLine(n10 + " notas de R$10");
            Console.WriteLine(n5 + " notas de R$5");
            Console.WriteLine(n2 + " notas de R$2");
            Console.WriteLine(n1 + " notas de R$1");
            Console.ReadKey();

        }
    }
}
