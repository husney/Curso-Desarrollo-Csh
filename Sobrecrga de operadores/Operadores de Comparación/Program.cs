using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_de_Comparación
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroImagniario n1 = new NumeroImagniario(5, 10);
            NumeroImagniario n2 = new NumeroImagniario(7, 50);
            NumeroImagniario n3 = new NumeroImagniario(5, 10);

            if (n2 > n1)
                Console.WriteLine("N2 es mayor a N1");
                        
            if (n1 < n2)
                Console.WriteLine("N1 es menor a N2");

            if (n1 <= n2)
                Console.WriteLine("N1 es menor o igual a N2");

            if (n2 >= n1)
                Console.WriteLine("N2 es mayor o igual a N1");

            if (n1 >= n3)
                Console.WriteLine("N1 es mayor o igual a N3");

                        
         }
    }
}
