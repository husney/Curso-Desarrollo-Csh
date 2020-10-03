using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecrga_de_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroImagniario n1 = new NumeroImagniario(5, 10);
            NumeroImagniario n2 = new NumeroImagniario(9, 80);

            NumeroImagniario nI;

            nI = n1 + n2;
            Console.WriteLine(nI.ToString());
            Console.WriteLine("_________________");

            nI = n1 - n2;
            Console.WriteLine(nI.ToString());
            Console.WriteLine("________________");

            nI = n1 * n2;
            Console.WriteLine(nI.ToString());
            Console.WriteLine("___________");

            nI = n1 / n2;
            Console.WriteLine(nI.ToString());

            Console.WriteLine("___________");

        

        }
    }
}
