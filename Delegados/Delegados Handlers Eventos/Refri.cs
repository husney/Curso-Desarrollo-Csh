using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_Handlers_Eventos
{
    public delegate void DKilos(int kilos);
    public delegate void DGrados(int grados);
    class Refri
    {
       

        private int kilos;
        private int grados;

        private DKilos handlerKilos;
        private DGrados handlerGrados;

        public int Kilos { get { return this.kilos; } }
        public int Grados { get { return this.grados; } }

        public Refri(int kilos, int grados)
        {
            this.kilos = kilos;
            this.grados = grados;
        }

        public void AgregarHandlerKilos(DKilos metodo)
        {
            this.handlerKilos = metodo;
        }

        public void EliminarHandlerKilos(DKilos metodo)
        {
            this.handlerKilos -= metodo;
        }

        public void AgregarHandlerGrados(DGrados metodo)
        {
            this.handlerGrados = metodo;
        }

        public void EliminarHandlerGrados(DGrados metodo)
        {
            this.handlerGrados -= metodo;
        }

        public void trabajar(int kilos)
        {
            this.kilos -= kilos;
            this.grados += 1;

            Console.WriteLine("Kilos: {0}", this.kilos);
            Console.WriteLine("Grados: {0}", this.grados);

            if(this.kilos < 10)
            {
                handlerKilos(this.kilos);
                //Se ejecutan todos los métodos
                //que estan en la lista interna de 
                //handlerKilos
            }

            if(this.grados > 0)
            {
                handlerGrados(this.grados);
                //Se ejecutan todos los métodos
                //que se encuentran en la lista interna
                //handlerGrados
            }
        }

    }
}
