using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Operadores_Unarios
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroImagniario nI = new NumeroImagniario(5, 10);
            NumeroImagniario n2 = new NumeroImagniario(7, 20);

            nI++;

            Console.WriteLine(nI.ToString()); 
            Console.WriteLine("_________________");


            n2--;
            Console.WriteLine(n2.ToString());
            Console.WriteLine("_____________________");
                                  
            nI += n2;
            Console.WriteLine(nI.ToString());
            Console.WriteLine("______________________");

            nI -= n2;
            Console.WriteLine(nI.ToString());
            Console.WriteLine("______________________");




            NumeroImagniario nI1 = new NumeroImagniario(5, 10);
            NumeroImagniario nI2 = new NumeroImagniario(5, 10);
            NumeroImagniario nI3 = new NumeroImagniario(7, 20);

            if(nI1 == nI2)
            {
                Console.WriteLine("Son iguales");
            }else
            {
                Console.WriteLine("Son diferentes");
            }

            if(nI1 != nI3)
            {
                Console.WriteLine("Son diferentes");
            }else
            {
                Console.WriteLine("Son iguales");
            }



        }
    }
}
