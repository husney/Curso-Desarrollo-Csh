using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_y_Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenedor datos = new Contenedor();

            foreach(int numero in datos)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
