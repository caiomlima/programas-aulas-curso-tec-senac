using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos {
    class Program {
        static void Main(string[] args) {

            string p;
            int i;
            double[] prod = new double[5];

            Console.WriteLine("5 produtos e seus preços");

            for(i = 0; i < prod.Length; i++) {
                Console.Write("Digite o valor do primeiro produto: R$");
                prod[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();



        }
    }
}
