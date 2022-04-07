using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeDias {
    class Program {
        static void Main(string[] args) {

            int dias, meses, anos, idadeFinal;

            Console.WriteLine("Calculador de idade em dias");
            Console.Write("Digite a sua idade de anos: ");
            anos = int.Parse(Console.ReadLine());

            Console.Write("Digite a sua idade de meses: ");
            meses = int.Parse(Console.ReadLine());

            Console.Write("Digite a sua idade de dias: ");
            dias = int.Parse(Console.ReadLine());

            idadeFinal = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("Você possui " + idadeFinal + " dias de idade");
            Console.ReadKey();

        }
    }
}
