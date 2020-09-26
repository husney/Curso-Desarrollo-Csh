using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack
{
    interface IEventosRefri
    {
        //Definición de los eventos del refri
        void EReservasBajas(int kilos);
        void EDescongelando(int grados);
    }
}
