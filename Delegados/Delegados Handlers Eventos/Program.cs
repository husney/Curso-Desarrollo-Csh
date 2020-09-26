using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_Handlers_Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
             Refri refrigerador = new Refri(70, -20);

            refrigerador.AgregarHandlerKilos(InformacionKilos);
            refrigerador.AgregarHandlerKilos(Tienda.MandaViveres);

            refrigerador.AgregarHandlerGrados(InformacionGrados);            

            Random rnd = new Random();

            while(refrigerador.Kilos > 0)
            {
                refrigerador.trabajar(rnd.Next(1,5));
            }

        }  

        public static void InformacionKilos(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Total Kilos{0}", kilos);
        }

        public static void InformacionGrados(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Togal Grados{0}", grados);
        }
    }
}
