using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante {
    class Program {
        static void Main(string[] args) {

            int prato, sobremesa, bebida, calorias = 0;

            pratosOpc:
                Console.WriteLine("Restaurante - Menu de opções");
                Console.WriteLine("--------------- Tipos de pratos ---------------");
                Console.WriteLine("1 - Vegetariano | 2 - Peixe | 3 - Frango | 4 - Carne");
                Console.Write("\nDigite o número do prato desejado: ");
                prato = int.Parse(Console.ReadLine());

            switch(prato) {
                case 1:
                    calorias += 180;
                    break;
                case 2:
                    calorias += 230;
                    break;
                case 3:
                    calorias += 250;
                    break;
                case 4:
                    calorias += 350;
                    break;
                default:
                    Console.Clear();
                    goto pratosOpc;
                    break;
            }
            Console.Clear();


            sobremesasOpc:
                Console.WriteLine("\n------------- Tipos de sobremesas -------------");
                Console.WriteLine("1 - Abaxaixi | 2 - Sorvete Diet | 3 - Mouse Diet | 4 - Mouse chocolate");
                Console.Write("\nDigite o número da sobremesa desejada: ");
                sobremesa = int.Parse(Console.ReadLine());

            switch (sobremesa) {
                case 1:
                    calorias += 75;
                    break;
                case 2:
                    calorias += 110;
                    break;
                case 3:
                    calorias += 170;
                    break;
                case 4:
                    calorias += 200;
                    break;
                default:
                    Console.Clear();
                    goto sobremesasOpc;
                    break;
            }
            Console.Clear();


            bebidasOpc:
                Console.WriteLine("\n-------------- Tipos de bebidas ---------------");
                Console.WriteLine("1 - Chá | 2 - Suco de laranja | 3 - Suco de melão | 4 - Refrigerante Diet");
                Console.Write("\nDigite o número da bebida desejada: ");
                bebida = int.Parse(Console.ReadLine());

            switch (bebida) {
                case 1:
                    calorias += 20;
                    break;
                case 2:
                    calorias += 70;
                    break;
                case 3:
                    calorias += 100;
                    break;
                case 4:
                    calorias += 65;
                    break;
                default:
                    Console.Clear();
                    goto bebidasOpc;
                    break;
            }
            Console.Clear();

            Console.WriteLine("O total de calorias do prato, bebida e sobremesa selecionados foi de: " + calorias);

            Console.ReadKey();

        }
    }
}
