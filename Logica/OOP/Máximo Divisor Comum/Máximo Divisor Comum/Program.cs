using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Máximo_Divisor_Comum {
    class Program {

        public static int MDC(int a, int b) {
            int aux, resto;

            if(a < b) {
                aux = a; 
                a = b;
                b = aux;
                resto = a % b;
                while(resto != 0) {
                    a = b;
                    b = resto;
                    resto = a & b;
                }
                return b;
            }
        }

        static void Main(string[] args) {

            int num1, num2;

            Console.WriteLine("Função - Máximo divisor comum (MDC)");
            Console.WriteLine("Digite um n° inteiro positivo");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um n° inteiro positivo");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O MDC vale: " + MDC(num1,num2)); 

        }
    }
}
