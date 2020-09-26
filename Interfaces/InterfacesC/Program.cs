using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesC
{
    class Program : IEnumerable, IEnumerator
    {
        public object Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
            //Regresa 
        }

        //public interface IEnumerator
        //{
        //    MoveNext() Revisa si hay un siguiente elemento si hay uno regresa True
        //    y se mueve hacia el siguiente elemento
        //    bool MoveNext();
        //    Current lee el elemento actual y regresa un object
        //    object current { get; }
        //    Reset regresa al inicio de la estructura
        //    void Reset;
        //}
        static void Main(string[] args)
        {
            TiendaAutos tienda = new TiendaAutos();

            tienda.AgregarAutos();
            
            foreach(Auto a in tienda)
            {
                a.MostrarInformacion();
            }





     }
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        
      
    
    }
}

