using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    
    class TiendaAutos
    {
        private Auto[] autos;


        public TiendaAutos()
        {
            autos = new Auto[4];

            autos[0] = new Auto("BMW", 1000);
            autos[1] = new Auto("Mercedez", 2000);
            autos[2] = new Auto("RAM", 3000);
            autos[3] = new Auto("Merecedez", 4000);
        }

        public int CantidadAutos()
        {
            return autos.Length;
        }

        //Creación del Indexer
        public Auto this[int indice]
        {
            get { return autos[indice]; }
            set { autos[indice] = value; }
        }







    }//Fin Clase



    class Computador
    {
        private string marca;

        public string Marca { get { return this.marca; } set { this.marca = value; } }
        public Computador(string marca)
        {
            this.marca = marca;
        }

        public void mostrarComputador()
        {
            Console.WriteLine(this.marca);
        }
    }

    class TiendaComputadores
    {
        private List<Computador> computadores = new  List<Computador>();

        public TiendaComputadores()
        {
            computadores.Add(new Computador("Asus"));
            computadores.Add(new Computador("MSI"));
            computadores.Add(new Computador("Alien Were"));
            
        }

        public Computador this[int indice]
        {
            get { return computadores.ElementAt(indice); }
            
        }

      
    }
}
