using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceICloneable
{
    class Auto : IAutomovil , ICloneable
    {
        private double impuesto;
        private double total;
        private string marca;

        public double Impuesto { get { return this.impuesto; } set { this.impuesto = value; } }
        public double Total { get { return this.total; } set { this.total = value; } }  
        public string Marca { get { return this.marca; } set { this.marca = value; } }

        public Auto(double total, string marca)
        {
            this.total = total;
            this.marca = marca;
            CalcularImpuesto(0.15);
        }
        public void CalcularImpuesto(double porcentaje)
        {
            this.impuesto = (total + 3000000) * porcentaje;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Marca: {0}",this.marca);
            Console.WriteLine("Valor: {0}",this.total);
            Console.WriteLine("Impuesto: {0} ", this.impuesto);
        }

        //Implementación de la interface ICloneable
        public object Clone()
        {
            Auto temp = new Auto(this.total, this.marca);
            temp.impuesto = this.impuesto;
            return temp;
            //Crea un objeto con los mismos atributos que el actual
            //y lo regresa 
        }
    }
}
