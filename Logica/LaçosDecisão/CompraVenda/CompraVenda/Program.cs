using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenda {
    class Program {
        static void Main(string[] args) {

            double valor_compra, valor_venda, lucro;

            Console.WriteLine("Valor de compra e Valor de Venda de um produto:");
            Console.WriteLine("Digite o valor de compra, do produto, em R$:");
            valor_compra = double.Parse(Console.ReadLine());

            if(valor_compra < 10) { 
                lucro = 0.70 * valor_compra; 
            } else if(valor_compra < 30) { 
                lucro = 0.50 * valor_compra; 
            } else if(valor_compra < 50) { 
                lucro = 0.40 * valor_compra; 
            } else { 
                lucro = 0.30 * valor_compra; 
            }
            valor_venda = valor_compra + lucro;

            Console.WriteLine("O lucro obtido na venda do produto é de R$ " + Math.Round(lucro, 2));
            Console.WriteLine("O valor de venda do produto é de R$ " + Math.Round(valor_venda, 2));
            Console.ReadKey();

        }
    }
}
