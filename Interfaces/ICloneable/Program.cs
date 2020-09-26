using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(1000000,"BMW");
            auto.CalcularImpuesto(0.20);


            //Esto no es clonación
            //Solo esta referenciando el auto2
            //Al mismo espacio de memoria que auto
            Auto auto2 = auto;


            //Clon del objeto
            Auto autoClon = (Auto)auto.Clone();

            autoClon.Total = 1500000;
            autoClon.Marca = "Mercedez";

            auto.MostrarInformacion();
            Console.WriteLine("-------------------------");
            autoClon.MostrarInformacion();

        }
    }
}
