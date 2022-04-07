using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Localizacao_Maior_Valor {
    class Program {
        static void Main(string[] args) {

            int i, j, maior, menor, linha_maior = 0, coluna_maior = 0, linha_menor = 0, coluna_menor = 0;
            int[,] mat = new int[4, 4];

            Random rnd = new Random();

            Console.WriteLine("Matriz 4x4 com localização do maior e menor valor");

            for (i = 0; i < 4; i++) {
                for (j = 0; j < 4; j++) {
                    //Console.Write("Digite mat[" + i + "][" + j + "]: ");
                    //mat[i, j] = int.Parse(Console.ReadLine());
                    mat[i, j] = rnd.Next(1, 50);
                }
            }

            Console.Clear();

            maior = mat[0, 0];
            menor = mat[0, 0];
            for (i = 0; i < 4; i++) {
                for (j = 0; j < 4; j++) {
                    if (mat[i, j] > maior) {
                        linha_maior = i;
                        coluna_maior = j;
                        maior = mat[i, j];
                    }
                    if (mat[i, j] < menor) {
                        menor = mat[i, j];
                        linha_menor = i;
                        coluna_menor = j;
                    }
                }
            }

            Console.WriteLine("Matriz Original\n");
            for (i = 0; i < 4; i++) {
                for (j = 0; j < 4; j++) {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nO maior valor é: " + maior + ", que está na na linha " + linha_maior + " e na coluna " + coluna_maior);
            Console.WriteLine("\nO menor valor é: " + menor + ", que está na na linha " + linha_menor + " e na coluna " + coluna_menor);

            Console.ReadKey();

        }
    }
}
