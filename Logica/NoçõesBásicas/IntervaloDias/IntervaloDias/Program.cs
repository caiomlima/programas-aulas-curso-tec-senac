using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervaloDias {
    class Program {
        static void Main(string[] args) {

            int t, dias, semanas, meses, anos;

            Console.WriteLine("Intervalo de tempo em dias para dias, semanas, meses, anos");
            Console.Write("Digite o número de dias: ");
            t = int.Parse(Console.ReadLine());

            anos = t / 365;
            meses = (t % 365) % 30;
            semanas = ((t % 365) % 30) / 7;
            dias = ((t % 365) % 30) % 7;

            Console.WriteLine("Deu aproximadamente " + anos + " anos, " + meses + " meses, " + semanas + " semanas e " + dias + " dias");
            Console.ReadKey();

        }
    }
}
