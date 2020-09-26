using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack
{
    class Program
    {
        static void Main(string[] args)
        {
             Refri refri = new Refri(50, -20);

            Random rnd = new Random();

            RefrigeradorSink sink = new RefrigeradorSink();
            TiendaSink sink2 = new TiendaSink();

            refri.AagregarSink(sink);
            refri.AagregarSink(sink2);


            while (refri.Kilos > 0 && sink.Paro == false)
            {
                refri.Trabajar(rnd.Next(1, 5));
                
            }
        }
    }
}
