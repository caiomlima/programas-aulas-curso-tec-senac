using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial {
    class Program {
        static void Main(string[] args) {

            int fat = 1, i, num;
            Console.WriteLine("Fatorial de um nº inteiro POSITIVO...");
            Console.WriteLine("Digite um nº inteiro positivo:");
            num = int.Parse(Console.ReadLine());
            if (num == 0) { Console.WriteLine("Por definição, 0! = 1"); } else if (num > 0) {
                for (i = 1; i <= num; i++) { fat *= i; }// fat = fat * i;
                Console.WriteLine(num + "! = " + fat);
            } else { Console.WriteLine("ERRO - Não existe fatorial de nº negativo..."); }
            Console.ReadKey();

        }
    }
}
