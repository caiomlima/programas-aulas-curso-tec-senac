using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_2_Matrizes {
    class Program {
        static void Main(string[] args) {

            int i, j;
            int[,] mat1 = new int[5, 5];
            int[,] mat2 = new int[5, 5];
            int[,] soma = new int[5, 5];
            int[,] dif = new int[5, 5];

            Random rnd = new Random(); // Nova instancia do Randomizador

            Console.WriteLine("Soma e dif de duas matrizes");

            Console.WriteLine("Matriz 1");
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    mat1[i, j] = rnd.Next(1,20); // Cria números de 1 a 20
                }
            }

            Console.WriteLine("Matriz 2");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    mat2[i, j] = rnd.Next(1, 20); // Cria números de 1 a 20
                }
            }

            Console.Clear();

            Console.WriteLine("Vetor 1 original");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    Console.Write(mat1[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Vetor 2 original");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    Console.Write(mat2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nVetor soma");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    soma[i, j] = mat1[i, j] + mat2[i, j];
                    Console.Write(soma[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nVetor dif");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    soma[i, j] = mat1[i, j] - mat2[i, j];
                    Console.Write(soma[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
