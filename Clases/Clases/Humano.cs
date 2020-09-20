using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Humano
    {
        protected string Nombre { get; set; }
        protected int edad { get; set; }
        protected string genero { get; set; }

        public abstract void dormir(string lugar);

        public abstract void respirar();

        public void correr()
        {
            Console.WriteLine(this.Nombre + " Esta corriendo");
        }

    }
}


 