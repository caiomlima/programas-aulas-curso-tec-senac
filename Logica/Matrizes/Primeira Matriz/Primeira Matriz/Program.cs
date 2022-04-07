using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeira_Matriz {
    class Program {
        static void Main(string[] args) {

            int i, j;
            int[,] num = new int[5,5];

            Console.WriteLine("Matriz básica de 5x5 - leitura e impressão");

            for(i = 0; i < 5; i++) { // Linhas
                for(j = 0; j < 5; j++) { // Colunas
                    Console.Write("Digite MAT[" + i + "][" + j + "]: ");
                    num[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("Matriz de 5x5 na tela: \n");
            for (i = 0; i < 5; i++) {// Linhas
                for (j = 0; j < 5; j++) { // Colunas
                    Console.Write(num[i,j] + "\t"); // Preenche as colunas
                }
                Console.WriteLine(); // Pula uma linha
            }


            Console.ReadKey();

        }
    }
}
