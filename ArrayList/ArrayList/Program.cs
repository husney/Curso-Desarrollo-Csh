using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> lista = new List<object>();

            List<string> listaCaracteres = new List<string>();

            List<int> listaNumeros = new List<int>();



             


            lista.Add("Hola");
            lista.Add(25234);
            lista.Add(20);

            foreach (Object valor in lista)
            {
                Console.WriteLine(valor);
            }
                      

            Console.ReadKey();
        }
    }
}
