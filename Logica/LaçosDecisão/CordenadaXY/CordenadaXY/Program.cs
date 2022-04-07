using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordenadaXY {
    class Program {
        static void Main(string[] args) {

            double x, y;

            Console.WriteLine("Coordenadas de um ponto P (X e Y) - localização do quadrante");
            Console.Write("Digite a abcissa (X) do ponto: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite a ordeanda (Y) do ponto: ");
            y = double.Parse(Console.ReadLine());

            if(x > 0 && y > 0) {
                Console.WriteLine("Coodernada no primeiro quadrante");
            } else if(x < y && y > 0) {
                Console.WriteLine("Coodernada no segundoo quadrante");
            } else if(x < 0 && y < 0) {
                Console.WriteLine("Coodernada no terceiro quadrante");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("Coodernada no quarto quadrante");
            } else if (x == 0 && y == 0){
                Console.WriteLine("Ponto na origem");
            } else if(x == 0 && y != 0) {
                Console.WriteLine("Ponto no eixo y");
            } else if(x != 0 && y == 0) {
                Console.WriteLine("Ponto no eixo X");
            }

            Console.ReadKey();
        }
    }
}
