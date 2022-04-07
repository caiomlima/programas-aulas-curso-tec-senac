using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varios_Numeros_Multiplos_de_3 {
    class Program {
        static void Main(string[] args) {

            int num;
            double soma_multiplos_de_3 = 0, conta_multiplos_de_3 = 0, media;
            Console.WriteLine("Digite um nº inteiro positivo, ou 0 para terminar...");
            num = int.Parse(Console.ReadLine());
            if (num % 3 == 0) {
                soma_multiplos_de_3 += num;
                conta_multiplos_de_3++;
            }
            while (num > 0)//flag
            {
                Console.WriteLine("Digite um nº inteiro positivo, ou 0 para terminar...");
                num = int.Parse(Console.ReadLine());
                if (num % 3 == 0) {
                    soma_multiplos_de_3 += num;
                    conta_multiplos_de_3++;
                }
            }
            Console.Clear();
            if (conta_multiplos_de_3 > 0) {
                media = soma_multiplos_de_3 / conta_multiplos_de_3;
                Console.WriteLine("Foram digitados " + conta_multiplos_de_3 + " números múltiplos de 3");
                Console.WriteLine("Média dos múltiplos de 3 = " + media);
            } else { Console.WriteLine("Não foram digitados múltiplos de 3..."); }
            Console.ReadKey();

        }
    }
}
