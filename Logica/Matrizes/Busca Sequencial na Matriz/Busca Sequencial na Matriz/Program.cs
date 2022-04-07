using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busca_Sequencial_na_Matriz {
    class Program {
        static void Main(string[] args) {

            int i, j, x, linhax = -1, colunax = -1;
            int[,] mat = new int[5, 5];

            Random rnd = new Random();

            Console.WriteLine("Busca sequencial de um elemento aleatório entre 1 e 99 numa matriz de 5x5");

            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    mat[i, j] = rnd.Next(1, 99);
                }
            }

            Console.WriteLine("\nDigite um elemento x, a procurar na matriz: ");
            x = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Matriz 5x5 com número aleatórios entre 1 e 99");
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    Console.Write(mat[i, j] + "\t");
                    if(mat[i,j] == x) {
                        linhax = i;
                        colunax = j;
                    }
                }
                Console.WriteLine();
            }

            if(linhax != -1 && colunax != -1) {
                Console.WriteLine(x + " está na linha " + linhax + " e na coluna " + colunax);
            } else {
                Console.WriteLine(x + " não aparece na matriz");
            }

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
