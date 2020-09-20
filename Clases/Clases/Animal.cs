using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public  class Animal
    {
        protected string nombre;

        public virtual void caminar()
        {
            Console.WriteLine("El animal esta caminando");
        }
    }


}
