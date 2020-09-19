using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Persona : Humano
    {
        private int Documento;
        private int Nacionalidad;
        private int cantidadPersonas;

        public int CantidadPersonas { get { return this.cantidadPersonas; } set { this.cantidadPersonas = value; } }


        public Persona()
        {
            cantidadPersonas++;
        }

        public Persona(string Nombre, int Documento) : this()
        {
            this.Nombre = Nombre;
            this.Documento = Documento;
        }

        public void correr()
        {
            Console.WriteLine(this.Nombre + " esta corriendo");
        }

        public virtual void saludar()
        {
            Console.WriteLine("Soy una PERSONA y estoy saludando (Hola)");
        }
    }
}


