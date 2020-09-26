using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesC
{
    class TiendaAutos
    {
        private Auto[] autos;

        public Auto[] mostrarAutos()
        {
            return this.autos;
        }
        public void AgregarAutos()
        {
            autos = new Auto[5];

            autos[0] = new Auto(2000000, "F1","Ferrary", "2020");
            autos[1] = new Auto(3000000, "M1", "Mercedez", "2021");
            autos[2] = new Auto(4000000, "B1", "BMW", "2020");
            autos[3] = new Auto(5000000, "MTZ5", "Mazerati", "2020");
            autos[4] = new Auto(6000000, "Lamb1", "Lamborghini", "2021");

            asignarImpuesto();

        }

        private void asignarImpuesto()
        {
            foreach(Auto auto in autos)
            {
                auto.CalcularImpuesto();
            }
        }


        public IEnumerator GetEnumerator()
        {
            return autos.GetEnumerator();
        }
        
    }
}
