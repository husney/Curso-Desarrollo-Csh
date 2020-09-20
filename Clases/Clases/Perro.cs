using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Perro : Animal
    {
        public Perro(string nombre)
        {
            this.nombre = nombre;
        }
        public override void caminar()
        {
            Console.WriteLine("El perro " + this.nombre + " esta caminando");
        }
    }
}
