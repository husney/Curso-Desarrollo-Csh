using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    sealed class Estudiante : Persona
    {
        private string Curso { get; set; }
        public static int cantidadEstudiantes { get; set; }
        public Estudiante()
        { 
            cantidadEstudiantes++;
        }
        public Estudiante(string Nombre, int Documento, string Curso) : base(Nombre, Documento)
        {
            this.Curso = Curso;
        }

        



        public void estudiar()
        {
            Console.WriteLine(this.Nombre + " esta estudiando");
        }

        public new void saludar()
        {
            Console.WriteLine("Soy un ESTUDIANTE y voy a saludar (buenos días), este es un nuevo método");
        }

        ~Estudiante()
        {
            this.Nombre = "";
            this.Curso = ""; 
            //Liberando espacio...
        }

    }
}
