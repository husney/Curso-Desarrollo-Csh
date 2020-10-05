using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_de_Comparación
{
    class NumeroImagniario : IComparable
    {
        private double entero;
        private double imaginario;

        public double Entero { get { return this.entero;  } set { this.entero = value; } }  
        public double Imaginario { get { return this.imaginario; } set { this.imaginario = value; } }

        public NumeroImagniario(double entero, double imaginario)
        {
            this.entero = entero;
            this.imaginario = imaginario;
        }

        public double Magnitud()
        {
            double m = Math.Sqrt((this.Entero * this.Entero) + (this.Imaginario * this.Imaginario));
            return m;
        }

        public int CompareTo(object obj)
        {
            try
            {
                if(obj is NumeroImagniario)
                {
                    NumeroImagniario temp = (NumeroImagniario)obj;
                    if (this.Magnitud() > temp.Magnitud())
                    {
                        return 1;
                    }else if(this.Magnitud() < temp.Magnitud())
                    {
                        return -1;
                    }else
                    {
                        return 0;
                    }
                }
                new Exception("Error", new InvalidOperationException());
                return 000;
            }catch(Exception ex)
            {  
                Console.WriteLine("Operación invalida");
                return 000;
            }
            
            
        }

        public static bool operator <(NumeroImagniario n1, NumeroImagniario n2)
        {
            if(n1.CompareTo(n2) < 0)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(NumeroImagniario n1, NumeroImagniario n2)
        {
            if(n1.CompareTo(n2) > 0)
            {
                return true;
            }return false;
        }

        public static bool operator >=(NumeroImagniario n1, NumeroImagniario n2)
        {
            if(n1.CompareTo(n2) == 1 || n1.CompareTo(n2) == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public static bool operator <=(NumeroImagniario n1, NumeroImagniario n2)
        {
            if(n1.CompareTo(n2) == -1 || n1.CompareTo(n2) == 0)
            {
                return true;
            }
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj is NumeroImagniario)
            {
                NumeroImagniario temp = (NumeroImagniario)obj;

                if (this.Entero == temp.Entero && this.Imaginario == temp.Imaginario)
                    return true;
                else
                    return false;
            }return false;
        }

        public static bool operator ==(NumeroImagniario n1, NumeroImagniario n2)
        {
            return n1.Equals(n2);
        }

        public static bool operator !=(NumeroImagniario n1, NumeroImagniario n2)
        {
            return !n1.Equals(n2);
        }

        public override string ToString()
        {
            if(imaginario < 0)
            {
                return string.Format("{0} {1}i", entero, imaginario);
            }else
            {
                return string.Format("{0} + {1}i", entero, imaginario);
            }
        }

        
        //Sobrecarga de operadores
        public static NumeroImagniario operator +(NumeroImagniario n1, NumeroImagniario n2)
        {
            double r = 0;
            double rImaginario = 0;

            r = n1.Entero + n2.Entero;
            rImaginario = n1.Imaginario + n2.Imaginario;

            NumeroImagniario temp = new NumeroImagniario(r, rImaginario);
            return temp;
        }


        public static NumeroImagniario operator *(NumeroImagniario n1, NumeroImagniario n2)
        {
            double rN = n1.Entero * n2.Entero;
            double rIM = n1.Imaginario * n2.Imaginario;

            NumeroImagniario temp = new NumeroImagniario(rN, rIM);
            return temp;

        }


        public static NumeroImagniario operator -(NumeroImagniario n1,  NumeroImagniario n2)
        {
            double rE = n1.Entero - n2.Entero;
            double rIM = n1.Imaginario - n2.Imaginario;

            NumeroImagniario temp = new NumeroImagniario(rE, rIM);
            return temp;

        }

        public static NumeroImagniario operator /(NumeroImagniario n1, NumeroImagniario n2)
        {
            try
            {
                double rE = n1.Entero / n2.Entero;
                double rIM = n1.Imaginario / n2.Imaginario;

                NumeroImagniario temp = new NumeroImagniario(rE, rIM);
                return temp;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No se puede diviidr por 0");
                return null;
            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error inseperado");
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
