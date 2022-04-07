using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervaloTempo {
    class Program {
        static void Main(string[] args) {

            int tempo, hr, min, seg;

            Console.WriteLine("Intervalo de segundos a horas, minutos, segundos");
            Console.Write("Digite a quantidade de tempo em segundos: ");
            tempo = int.Parse(Console.ReadLine());

            hr = tempo / 3600;
            min = (tempo % 3600) / 60;
            seg = (tempo % 3600) % 60;

            Console.WriteLine(tempo + " segundos equivalem a " + hr + " h, " + min + " min e " + seg + " seg.");
            Console.ReadKey();
        }
    }
}
