using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDoMes {
    class Program {
        static void Main(string[] args) {

            string mes;

            Console.WriteLine("Número de dias do mês");
            Console.Write("Digite o nome do mês com a primeira letra maiúscula: ");
            mes = Console.ReadLine();

            switch(mes) {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    Console.WriteLine(mes + " tem 31 dias");
                    break;
                case "Fevereiro":
                    Console.WriteLine("Fevereiro tem 28 ou 29 dias");
                    break;
                default:
                    Console.WriteLine(mes + " tem 30 dias");
                    break;
            }
            Console.ReadKey();

        }
    }
}
