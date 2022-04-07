using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Binaria {
    class Program {
        static void Main(string[] args) {

            int i, j;
            int[,] mat = new int[5, 5];

            Console.WriteLine("Matriz Binária");

            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    //Console.Write("Digite mat[" + i + "][" + j + "]: ");
                    //mat[i, j] = int.Parse(Console.ReadLine());
                    
                    if(i == j) {
                        mat[i, j] = 0;
                    } else {
                        mat[i, j] = 1;
                    }
                }
            }

            Console.Clear();

            Console.WriteLine("Matriz\n");
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    Console.Write(mat[i,j]+ "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
