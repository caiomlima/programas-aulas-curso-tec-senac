using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Transposta {
    class Program {
        static void Main(string[] args) {

            int i, j;
            int[,] mat = new int[2, 3];

            Random rnd = new Random();

            Console.WriteLine("Soma das diagonais");

            for (i = 0; i < 2; i++) {
                for (j = 0; j < 3; j++) {
                    mat[i, j] = rnd.Next(1, 25);
                }
            }

            Console.WriteLine("Matriz Original\n");
            for (i = 0; i < 2; i++) {
                for (j = 0; j < 3; j++) {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz Transposta\n");
            for (j = 0; j < 3; j++) {
                for (i = 0; i < 2; i++) {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
