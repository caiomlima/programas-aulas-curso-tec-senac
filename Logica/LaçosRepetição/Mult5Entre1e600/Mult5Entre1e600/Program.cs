using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mult5Entre1e600 {
    class Program {
        static void Main(string[] args) {

            int num = 5;

            Console.WriteLine("");

            while(num <= 600) {
                Console.WriteLine(num);
                num += 5;
            }

            Console.ReadKey();

        }
    }
}
