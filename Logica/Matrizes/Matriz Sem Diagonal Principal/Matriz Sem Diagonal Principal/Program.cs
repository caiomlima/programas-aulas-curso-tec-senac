using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Sem_Diagonal_Principal {
    class Program {
        static void Main(string[] args) {

            int i, j;
            int[,] mat = new int[5, 5];

            Console.WriteLine("Números da diagonal principal da matriz");

            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    Console.Write("Digite mat[" + i + "][" + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("Matriz original\n");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nMatriz sem os números da diagonal principal\n");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    if (i != j) {
                        Console.Write(mat[i, j] + "\t");
                    } else {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
