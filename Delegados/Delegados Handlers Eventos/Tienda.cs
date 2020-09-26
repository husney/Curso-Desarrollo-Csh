using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_Handlers_Eventos
{
    class Tienda
    {
        public static void MandaViveres(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mandando viveres, estoy en la tienda");
            Console.WriteLine("Serán {0} kilo", kilos);
        }
    }
}
