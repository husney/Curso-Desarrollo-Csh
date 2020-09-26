using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    class Rectangulo : IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public double Ancho { get { return this.ancho; } set { this.ancho= value; } }
        public double Alto { get { return this.alto; } set { this.alto = value; } }
        public double Area { get { return this.area; } set { this.area = value; } }


        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
            calcularArea();
        }

        private void calcularArea()
        {
            this.area = this.ancho * this.alto;
        }

        public override string ToString()
        {
            return string.Format("{0} X {1} = {2}", this.alto, this.ancho, this.area);
        }
        
        
        //Implementación de IComparable
        public int CompareTo(object obj)
        { //Regla de comparación (area en este caso)
            Rectangulo r = (Rectangulo)obj;

            if(this.area > r.area)
            {
                return 1; //Si es mayor
            }else if(this.area < r.area)
            {
                return -1; //Si es menor
            }
            else
            {
                return 0;//Si son iguales 
            }
        }
    }
}
