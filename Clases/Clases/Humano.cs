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

        public void dormir()
        {
            Console.WriteLine(this.Nombre + " Esta durmiendo");
        }

        public void respirar()
        {
        }
    }
}
