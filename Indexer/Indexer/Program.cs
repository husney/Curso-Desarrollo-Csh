using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {

            TiendaAutos tiendaAutos = new TiendaAutos();

            //tiendaAutos[3].MostrarInformacion();

            //Auto a1 = new Auto("Ferray", 5000);

            //tiendaAutos[3] = a1;

            //if (tiendaAutos[3] == null)
            //    Console.WriteLine("El objeto esta vacio");
            //else
            //    tiendaAutos[3].MostrarInformacion();

            //for(int i = 0; i < tiendaAutos.CantidadAutos(); i++)
            //{
            //    tiendaAutos[i].MostrarInformacion();
            //}

            TiendaComputadores tiendaComputadores = new TiendaComputadores();

            tiendaComputadores[1].mostrarComputador();

        }
    }
}
