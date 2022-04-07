using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_e_Sexo_de_6_Pessoas {
    class Program {
        static void Main(string[] args) {

            int sexo, i;
            double idade, soma_idades = 0, media_idades;
            double maiores = 0, menores = 0, mulheres_maiores = 0;
            double porc_maiores, porc_menores, porc_mulheres_maiores;

            Console.WriteLine("Idade e sexo de 6 pessoas ... Cálculos relativos");
            for(i = 1; i <= 6; i++) {

                Console.Write("Digite a idade da " + i + " ° pessoa - [0] - M | [1] - F : ");
                idade = double.Parse(Console.ReadLine());

                if(idade >= 18) {
                    maiores++;
                } else {
                    menores++;
                }

                soma_idades += idade;

                Console.Write("Digite o sexo da " + i + " ° pessoa - [0] - M | [1] - F :");
                sexo = int.Parse(Console.ReadLine());

                if(sexo == 1 && idade >= 18) {
                    mulheres_maiores++;
                }
            }

            media_idades = soma_idades / 6;
            porc_maiores = 100 * maiores / 6;
            porc_menores = 100 * menores / 6;
            porc_mulheres_maiores = 100 * mulheres_maiores / 6;

            Console.Clear();

            Console.WriteLine("A média das 6 idades lidas é: " + Math.Round(media_idades, 1));
            Console.WriteLine("A porcentagem de maiores de idade é: " + Math.Round(porc_maiores,2) + "%");
            Console.WriteLine("A porcentagem de menores de idade é: " + Math.Round(porc_menores, 2) + "%");
            Console.WriteLine("A porcentagem de mulheres maiores de idade é: " + Math.Round(porc_mulheres_maiores, 2) + "%");

            Console.ReadKey();

        }
    }
}
