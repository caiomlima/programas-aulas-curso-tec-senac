using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_Multiplos {
    class Program {
        static void Main(string[] args) {

            int[] num = new int[7];
            int i, m2_cont = 0, m3_cont = 0, m23_cont = 0;

            Console.WriteLine("7 números e seus múltiplos");

            // Leitura dos números
            for(i = 0; i < num.Length; i++) {
                Console.Write("\nDigite o " + (i + 1) + "° número inteiro: ");
                num[i] = int.Parse(Console.ReadLine());
                if(num[i] % 2 == 0) { m2_cont++; }
                if (num[i] % 3 == 0) { m3_cont++; }
                if (num[i] % 2 == 0 && num[i] % 3 == 0) { m23_cont++; }
            }

            Console.Clear();

            // Vetor completo
            Console.Write("O vetor completo: " + "   ");
            for (i = 0; i < num.Length; i++) {
                Console.Write(num[i] + "\t");
            }

            // Apenas múltiplos de 2
            if(m2_cont > 0) {
                Console.Write("\n\nMúltiplos de 2: " + "   ");
                for (i = 0; i < num.Length; i++) {
                    if (num[i] % 2 == 0) {
                        Console.Write(num[i] + "\t");
                    }
                }
            } else {
                Console.WriteLine("\n\nNão há múltiplos de 2");
            }

            // Apenas múltiplos de 3
            if (m3_cont > 0) {
                Console.Write("\n\nMúltiplos de 3: " + "   ");
                for (i = 0; i < num.Length; i++) {
                    if (num[i] % 3 == 0) {
                        Console.Write(num[i] + "\t");
                    }
                }
            } else {
                Console.WriteLine("\n\nNão há múltiplos de 3");
            }

            // Apenas múltiplos de 2 e 3
            if (m23_cont > 0) {
                Console.Write("\n\nMúltiplos de 2 e 3: " + "   ");
                for (i = 0; i < num.Length; i++) {
                    if (num[i] % 2 == 0 && num[i] % 3 == 0) {
                        Console.Write(num[i] + "\t");
                    }
                }
            } else {
                Console.WriteLine("\n\nNão há múltiplos de 2 e 3");
            }

            Console.ReadKey();

        }
    }
}
