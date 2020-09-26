using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack
{
    class TiendaSink : IEventosRefri
    {
        
        //Handler (Método)
        public void EReservasBajas(int kilos)
        {

            //Codigo que se ejecutará cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Viveres");
            Console.WriteLine("Serán {0} kilos", kilos);
        }

        public void EDescongelando(int grados)
        {
        }
    }
}
