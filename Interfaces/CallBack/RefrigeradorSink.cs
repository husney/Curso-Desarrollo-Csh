using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack
{
    class RefrigeradorSink : IEventosRefri
    {

        private bool paro;
        public bool Paro { get { return this.paro; } }

        //Esta es la clase sink
        //En esta clase se colocan los handlers de los
        //Eventos definidos en la interface

        public void EReservasBajas(int kilos)
        {
            //Este es el Handler
            //El método que se va a invocar 
            //Cuando el evento suceda
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Reservas de alimentos");
            Console.WriteLine("Quedan {0} kilos", kilos);
        }

        public void EDescongelando(int grados)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Descongelandoce");
            Console.WriteLine("Grados: {0}", grados);
            if (grados > 0)
            {
                this.paro = true;
            }

        }
    }
}
