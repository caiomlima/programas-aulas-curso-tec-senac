using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varios_Numeros_Digitados {
    class Program {
        static void Main(string[] args) {

            int num;
            double media = 0, qtd = 0, soma = 0, maior, menor;
            double cont_pares = 0, soma_pares = 0, media_pares, cont_impares = 0;
            double porc_impares;

            Console.WriteLine("Esse programa faz varias coisas com os números digitados");
            Console.Write("Digite um número inteiro acima de 0 para começar: ");
            num = int.Parse(Console.ReadLine());
            qtd ++;
            soma += num;
            maior = num;
            menor = num;

            if(num % 2 == 0) {
                cont_pares++;
                soma_pares += num;
            } else {
                cont_impares++;
            }

            while(num > 0) {

                Console.Write("Digite um número inteiro acima de 0: ");
                num = int.Parse(Console.ReadLine());

                if(num % 2 == 0) {
                    cont_pares++;
                    soma_pares += num;
                } else {
                    cont_impares += num;
                }

                if(num > maior) {
                    maior = num;
                } else if (num < menor && num > 0) {
                    menor = num;
                }
                soma += num;
                qtd++;

            }

            Console.Clear();
            media = soma / qtd;
            media_pares = soma_pares / cont_pares;
            porc_impares = 100 * cont_impares / qtd;

            Console.WriteLine("Soma de todos os números: " + soma);
            Console.WriteLine("Quantidade de números: " + qtd);
            Console.WriteLine("Média dos números: " + Math.Round(media, 2));
            Console.WriteLine("Maior: " + maior + " e menor: " + menor);
            Console.WriteLine("A média dos números pares digitados: " + Math.Round(media_pares,2));
            Console.WriteLine("Porcentagem dos números ímpares digitados: " + Math.Round(porc_impares,2) + "%");

            Console.ReadKey();

        }
    }
}
