using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Com_Regra_De_Negocio {
    class Program {
        static void Main(string[] args) {

            int i, j;
            int[,] mat = new int[10, 10];

            Console.WriteLine("Matriz com regras para ser gerada\n");

            for (i = 0; i < 10; i++) {
                for (j = 0; j < 10; j++) {
                    if(j < j) {
                        mat[i, j] = 2 * i + 7 * j - 2;
                    } else if(i == j) {
                        mat[i, j] = 3 * i * i - 1;
                    } else {
                        mat[i, j] = 4 * i * i * i - 5 * j * j + 1;
                    }
                }
            }

            Console.WriteLine("Matriz de 10x10 gerada: \n");
            for (i = 0; i < 10; i++) {
                for (j = 0; j < 10; j++) {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
