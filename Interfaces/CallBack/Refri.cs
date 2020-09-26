using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack
{
    class Refri
    {
        private ArrayList listaSinks = new ArrayList();

        private int kilos = 0;
        private int grados = 0;

        public int Kilos { get { return this.kilos; } set { this.kilos = value; } }
        public int Grados { get { return this.grados; } set { this.grados = value; } }
        public Refri(int kilos, int grados)
        {
            this.kilos = kilos;
            this.grados = grados;
        }


        //Adicionamos un sink (Evento)
        public void AagregarSink(IEventosRefri pSink)
        {
            if(pSink != null)
            {
                listaSinks.Add(pSink);
            }
        }

        //Eliminar sink (Evento) 
        public void EliminarSink(IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
            {
                listaSinks.Remove(pSink);
            }
        }

        public void Trabajar(int consumo)
        {
            //Actualización de los kilos del refrigerador
            this.kilos -= consumo;
            //Actualización de los grados
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", this.kilos, this.grados);
            
            if(this.kilos < 10)
            {
                foreach(IEventosRefri handler in listaSinks)
                {
                    handler.EReservasBajas(this.kilos);
                    
                }
            }

            if(this.grados >= 0)
            {
                foreach(IEventosRefri handler in listaSinks)
                {
                    handler.EDescongelando(this.grados);
                }
            }
        }

    }
}
