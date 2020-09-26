using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_y_Enumerator
{
    class Contenedor : IEnumerable
    {
        

        private int[] valores = new int[10];

        public Contenedor()
        {
            for(int i = 0; i < valores.Length; i++)
            {
                valores[i] = (i + 1) * i + 1 ;
            }
        }

        //Implementación de la Inteface IEnumerable
        public IEnumerator GetEnumerator()
        {
            return new ContenedorEnum(valores);
        }

         
    }

    class ContenedorEnum : IEnumerator
    {
        private int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] areglo)
        {
            this.arreglo = areglo;
        }
        public object Current
        {
            get
            {
                try
                {
                    return this.arreglo[posicion];
                }
                catch(Exception ex) //Manejo de error
                {
                    Console.WriteLine(ex.Message.ToString());
                    return null;
                }
            }
        }

        public bool MoveNext()
        {
            posicion++;
            return (posicion < this.arreglo.Length) ? true : false;

            //if (posicion < this.arreglo.Length)
            //{
            //    return true;
            //}else
            //{
            //    return false;
            //}
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
