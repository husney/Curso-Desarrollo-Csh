using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPolimorfismo
{
    class Suma : IOperacionesMatematicas
    {
        public void operacione(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
    }
}
