using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesC
{
    class Auto : Automovil
    {
        private double impuesto;
        private double total;
        private string modelo;
        private string marca;
        private string year;

        public Auto(double total, string modelo, string marca, string year)
        {
            this.total = total;
            this.modelo = modelo;
            this.marca = marca;
            this.year = year;
        }

        public double Impuesto { get { return this.impuesto; } set { this.impuesto = value; } }
        public double Total { get { return this.total;  } set { this.total = value; } }
        public string Modelo { get { return this.modelo; } set { this.modelo = value; } }
        public string Year { get { return this.year; } set { this.year = value; } }
        public void CalcularImpuesto()
        {
            impuesto = (total + 300000) * 0.15;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Modelo : " + this.modelo);
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Año : " + this.year);
            Console.WriteLine("Total : " + this.total);
            Console.WriteLine("Impuesto : " + this.impuesto);
            Console.WriteLine("----------------------------");
        }
    }
}
