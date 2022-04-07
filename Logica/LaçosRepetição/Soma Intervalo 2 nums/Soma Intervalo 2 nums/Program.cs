using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Intervalo_2_nums {
    class Program {
        static void Main(string[] args) {


            int i, n1, n2, aux, soma = 0;
            Console.WriteLine("Soma resultante do intervalo de dois números distintos");
            Console.WriteLine("Digite o 1º número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2) //Precisamos garantir que n1 seja menor que n2
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            Console.WriteLine("Intervalo crescente de números entre " + n1 + " e " + n2 + ":");
            for (i = n1; i <= n2; i++) {
                Console.WriteLine(i);
                soma += i;
            }
            Console.WriteLine("A soma dos números entre" + n1 + " e " + n2 + " , vale: " + soma);
            Console.ReadKey();


        }
    }
}
