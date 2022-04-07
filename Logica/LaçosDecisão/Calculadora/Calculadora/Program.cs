using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {

            int i;
            double n1, n2, result;
            string opc;


            start:
                Console.WriteLine("Calculadora de 2 números");

                Console.Write("\nDigite o primeiro número: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                n2 = double.Parse(Console.ReadLine());

            optmenu:
                Console.WriteLine("\n------------- M E N U   D E   O P Ç Õ E S --------------");
                Console.WriteLine("1 - Soma | 2 - Subtração | 3 - Divisão | 4 Multiplicação");
                Console.Write("\nDigite o número da operação que deseja fazer: ");
                i = int.Parse(Console.ReadLine());

            Console.Clear();

            switch(i) {
                case 1:
                    result = n1 + n2;
                    Console.WriteLine("O resultado da soma foi: " + result);
                    Console.WriteLine("\nDeseja realizar outra operação? ");
                    Console.WriteLine("\nS ou s para sim | Aperte enter duas vezes para sair");
                    Console.Write("Digite o que deseja fazer: ");
                    opc = Console.ReadLine();
                    if (opc == "S" || opc == "s") {
                        Console.Clear();
                        goto start;
                    } else {
                        break;
                    }
                case 2:
                    result = n1 - n2;
                    Console.WriteLine("O resultado da subtração foi: " + result);
                    Console.WriteLine("\nDeseja realizar outra operação? ");
                    Console.WriteLine("\nS ou s para sim | Aperte enter duas vezes para sair");
                    Console.Write("Digite o que deseja fazer: ");
                    opc = Console.ReadLine();
                    if (opc == "S" || opc == "s") {
                        Console.Clear();
                        goto start;
                    } else {
                        break;
                    }
                case 3:
                    result = n1 / n2;
                    Console.WriteLine("O resultado da divisão foi: " + result);
                    Console.WriteLine("\nDeseja realizar outra operação? ");
                    Console.WriteLine("\nS ou s para sim | Aperte enter duas vezes para sair");
                    Console.Write("Digite o que deseja fazer: ");
                    opc = Console.ReadLine();
                    if (opc == "S" || opc == "s") {
                        Console.Clear();
                        goto start;
                    } else {
                        break;
                    }
                case 4:
                    result = n1 * n2;
                    Console.WriteLine("O resultado da multiplicação foi: " + result);
                    Console.WriteLine("\nDeseja realizar outra operação? ");
                    Console.WriteLine("\nS ou s para sim | Aperte enter duas vezes para sair");
                    Console.Write("Digite o que deseja fazer: ");
                    opc = Console.ReadLine();
                    if (opc == "S" || opc == "s") {
                        Console.Clear();
                        goto start;
                    } else {
                        break;
                    }
                default:
                    Console.WriteLine("Operação inválida");
                    goto optmenu;   
                    break;
            }
            Console.ReadKey();
        }
    }
}
