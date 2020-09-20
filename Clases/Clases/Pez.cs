using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Pez : Animal
    {
        public Pez(string nombre)
        {
            this.nombre = nombre;
        }
        public override void caminar()
        {
            Console.WriteLine("El pez " + this.nombre + " esta nadando");
        }
    }
}
