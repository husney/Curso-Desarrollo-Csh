using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");

            

            Console.WriteLine("Ingrese el número 1");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((n1 + n2));

            Console.ReadKey();

        }
    }
}
