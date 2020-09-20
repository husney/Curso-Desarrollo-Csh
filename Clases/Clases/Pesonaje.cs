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

            Animal perro = new Perro("Toby");
            perro.caminar();

            Animal pez = new Pez("Nemo");
            pez.caminar();

            Animal ave = new Ave("Condorito");
            ave.caminar();


            Console.ReadKey();
        }

        public static void mostrarPersona(Humano h)
        {
           
        }
    }

    
}


