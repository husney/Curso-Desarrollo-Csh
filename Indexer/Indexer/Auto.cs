using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Auto
    {
        private double costo;
        private double impuesto;
        private string modelo;
        
        public double Costo { get { return this.costo; } set { this.costo = value; } }
        public double Impuesto { get { return this.impuesto; } set { this.impuesto = value; } }
        public string Modelo { get { return this.modelo;  } set { this.modelo = value; } }  
        
        public Auto(string modelo, double costo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Automovil {0}", this.modelo);
            Console.WriteLine("Costo {0}", this.costo);
            Console.WriteLine("_____________");
        }
    }
}
