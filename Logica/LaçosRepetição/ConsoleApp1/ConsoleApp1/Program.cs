using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            int i = 2;

            Console.WriteLine("100 primeiros números pares");
            while(i <= 200) {
                
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
                i++;

                //Console.WriteLine(i);
                //i += 2;
            }
            Console.ReadKey();

        }
    }
}
