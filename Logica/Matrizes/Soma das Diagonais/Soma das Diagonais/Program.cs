using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_das_Diagonais {
    class Program {
        static void Main(string[] args) {

            int i, j, cima = 0, baixo = 0, princ = 0;
            int[,] mat = new int[3, 3];

            Random rnd = new Random();

            Console.WriteLine("Soma das diagonais");

            for(i = 0; i < 3; i++) {
                for(j = 0; j < 3; j++) {
                    mat[i, j] = rnd.Next(1, 25);
                }
            }

            Console.WriteLine("Matriz Original\n");
            for (i = 0; i < 3; i++) {
                for (j = 0; j < 3; j++) {
                     Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (i = 0; i < 3; i++) {
                for (j = 0; j < 3; j++) {
                    if(i == j) {
                        princ += mat[i,j];
                    } else if (i > j) {
                        baixo += mat[i,j];
                    } else if (i < j) {
                        cima += mat[i,j];
                    }
                }
            }

            Console.WriteLine("Cálculo acima da diagonal da matriz é " + cima);
            Console.WriteLine("Cálculo abaixo da diagonal da matriz é " + baixo);
            Console.WriteLine("Cálculo da diagonal principal da matriz é " + princ);

            Console.ReadKey();

        }
    }
}
