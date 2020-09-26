using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesC
{
    class Resta : IOperacionesMatematicas
    {
        public void operacion(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
    }
}
