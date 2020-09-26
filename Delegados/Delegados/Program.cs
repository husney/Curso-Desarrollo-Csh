using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        public delegate void miDelegado(string param);
        static void Main(string[] args)
        {
            miDelegado delegado = new miDelegado(Persona.Saludar);

            delegado("Buen día");

            delegado = Mascota.Correr;

            delegado("Ronnie");
        }
    }
}
