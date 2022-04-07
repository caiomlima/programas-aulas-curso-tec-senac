using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentualAumento {
    class Program {
        static void Main(string[] args) {

            double preco_prod, aumento, novo_preco;

            Console.WriteLine("Calcular novos preços dos produtos");
            Console.Write("Digite o preço do produto: ");
            preco_prod = double.Parse(Console.ReadLine());

            // Percentual de aumento
            if(preco_prod <= 50) {
                aumento = 0.5 * preco_prod;
            } else if(preco_prod <= 100) {
                aumento = 0.10 * preco_prod;
            } else {
                aumento = 0.15 * preco_prod;
            }
            novo_preco = preco_prod + aumento;

            // Classificações
            Console.WriteLine("Novo preço = R$" + Math.Round(novo_preco, 2));
            if (novo_preco <= 80) {
                Console.WriteLine("Preço: Barato");
            } else if(novo_preco <= 120) {
                Console.WriteLine("Preço: Normal");
            } else if(novo_preco <= 200) {
                Console.WriteLine("Preço: Caro");
            } else {
                Console.WriteLine("Preço: Muito caro");
            }
            Console.ReadKey();

        }
    }
}
