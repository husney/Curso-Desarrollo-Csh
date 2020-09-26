using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo[] rectangulos = new Rectangulo[5];

            rectangulos[0] = new Rectangulo(14, 5);
            rectangulos[1] = new Rectangulo(8, 13);
            rectangulos[2] = new Rectangulo(10, 7);
            rectangulos[3] = new Rectangulo(7, 8);
            rectangulos[4] = new Rectangulo(8, 9);

            foreach(Rectangulo r in rectangulos)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("-----------------------");

            //Uso de Sort el cual necesita la implementación 
            //De IComparable para saber si un elmento
            //Es mayor o menor que otro
            Array.Sort(rectangulos);

            foreach(Rectangulo r in rectangulos)
            {
                Console.WriteLine(r);
            }
        }
    }
}
