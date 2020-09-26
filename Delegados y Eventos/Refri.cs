using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_y_Eventos
{
    class Refri
    {
        public delegate void DReservasBajas(int kilos);
        public delegate void DDescongelando(int grados);

        private int kilos;
        private int grados;

        public int Kilos { get { return this.kilos; } } 
        public int Grados { get { return this.grados; } }

        private DReservasBajas delReservas;
        private DDescongelando delDescongelando;

        public Refri(int kilos, int grados)
        {
            this.kilos = kilos;
            this.grados = grados;
        }

        public void AdicionaReservas(DReservasBajas metodo)
        {
            delReservas = metodo;
        }

        public void AdicionarDescongelado(DDescongelando metodo)
        {
            delDescongelando = metodo;
        }

        public void Trabajar(int consumo)
        {
            this.kilos -= consumo;

            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos , {1} grados", this.kilos, this.grados);

            if(this.kilos < 10)
            {
                delReservas(this.kilos);
            }

            if(this.grados > 0)
            {
                delDescongelando(this.grados);
            }
        }
    }
}
