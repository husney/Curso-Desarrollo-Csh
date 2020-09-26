using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Matematicas : IOperacionesMatematicas
    {
        public void dividir(int n1, int n2)
        {
            Console.Write(n1 / n2);
        }
        public void multiplicar(int n1, int n2)
        {
            Console.Write(n1 * n2);
        }
        public void restar(int n1, int n2)
        {
            Console.Write(n1 - n2);
        }
        public void sumar(int n1, int n2)
        {
            Console.Write(n1 + n2);
        }

        private ArrayList rlist = new ArrayList();
        
    }
}
