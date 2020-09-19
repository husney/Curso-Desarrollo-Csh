using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paquete.Personajes
{
    class Personaje
    {
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string Raza { get; set; }

        public Personaje() { } //Constructor Vacío

        public Personaje(string nombre, string clase, string raza) //Constructor con parametros
        {
            this.Nombre = nombre;
            this.Clase = clase;
            this.Raza = raza;
        }

        public void poderes()
        {
            Console.WriteLine("Usar poderes");
        }
    }

    class programa
    {
        public static void Main(string[] args)
        {
            Humano estudiante1 = new Estudiante("Pepe", 1234, "Diseño");

            ((Estudiante)estudiante1).estudiar();


            Persona p = new Persona("pepe", 12345);

            p.saludar();

            Console.WriteLine("=========================");



            Estudiante est1 = new Estudiante();
            Estudiante est2 = new Estudiante();
            Estudiante est3 = new Estudiante();

            Console.WriteLine(Estudiante.cantidadEstudiantes);


            

            Console.ReadKey();

        }

        public static void mostrarPersona(Humano h)
        {
            h.dormir();
        }
    }

    
}


