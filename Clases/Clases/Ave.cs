using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Ave : Animal
    {
        public Ave(string nombre)
        {
            this.nombre = nombre;
        }
        public override void caminar()
        {
            Console.WriteLine("El ave " + this.nombre + " esta volando");
        }
    }
}
