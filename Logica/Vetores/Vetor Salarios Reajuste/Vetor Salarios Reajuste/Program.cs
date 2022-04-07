using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Salarios_Reajuste {
    class Program {
        static void Main(string[] args) {

            int i;
            double[] s = new double[4];
            double[] reaj = new double[4];

            Console.WriteLine("Vetor de salários e reajuste");

            for(i = 0; i < s.Length; i++) {
                Console.Write("Digite o salário do funcionário " + i + ": ");
                s[i] = double.Parse(Console.ReadLine());
                reaj[i] = 1.12 * s[i];
            }

            Console.Clear();

            // Salários originais:
            for (i = 0; i < s.Length; i++) {
                Console.WriteLine("O salário do funcionário " + i + " originl é: R$" + s[i]);
            }

            Console.WriteLine("\n\nSalários reajustados em 12%: \n");
            for (i = 0; i < s.Length; i++) {
                Console.WriteLine("O salário do funcionário " + i + " com reajuste é: R$" + reaj[i]);
            }

            Console.ReadKey();

        }
    }
}
