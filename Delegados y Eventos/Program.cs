using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_y_Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Refri refrigerador = new Refri(70, -20);

            refrigerador.AdicionaReservas( new Refri.DReservasBajas(InformeKilos));
            refrigerador.AdicionarDescongelado(InformeGrados);

            Random rnd = new Random();

            while(refrigerador.Kilos >0)
            {
                refrigerador.Trabajar(rnd.Next(1,5));
            }
            
         }

        public static void InformeKilos(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reservas bajas, estoy en main");
            Console.WriteLine("Quedan {0} kilos", kilos);
        }

        public static void InformeGrados(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("El Refrigerador se esta descongelando, estoy en main");
            Console.WriteLine("Esta a {0} grados", grados);
        }
    }
}
