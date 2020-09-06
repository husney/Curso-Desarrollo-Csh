using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arreglo = new int[10];

            Random r = new Random();

            Console.WriteLine(arreglo.GetLength(0));

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                arreglo[i] = r.Next(1, 1000);
            }

            Console.WriteLine("-----");
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }


            Console.WriteLine("-----");

            for (int i = 0; i < arreglo.Length; i++)
            {
                for(int j = 0; j <arreglo.Length -1; j++)
                {
                    if(arreglo[j] > arreglo[j + 1])
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }
            }


            Console.WriteLine("-----");

            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }


            Console.WriteLine("-----");

            Console.WriteLine("-----");


            int[,] matriz = new int[3, 3];

            matriz[0, 0] = 0;
            matriz[0, 1] = 01;
            matriz[0, 2] = 02;

            matriz[1, 0] = 10;
            matriz[1, 1] = 11;
            matriz[1, 2] = 12;

            matriz[2, 0] = 20;
            matriz[2, 1] = 21;
            matriz[2, 2] = 22;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine();
            }



            Console.WriteLine("-----");

            Console.WriteLine("-----");

            Console.WriteLine("-----");

            int[,] colDoble = new int[5, 10];


            for(int i = 0; i < colDoble.GetLength(0); i++)
            {
                for(int j = 0; j < colDoble.GetLength(1); j++)
                {
                    colDoble[i, j] = r.Next(100, 1000);
                }
            }

            for (int i = 0; i < colDoble.GetLength(0); i++)
            {
                for (int j = 0; j < colDoble.GetLength(1); j++)
                {
                    Console.Write(colDoble[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----");

            Console.WriteLine("-----");

            Console.WriteLine("Ordenamiento:");

           for(int i = 0; i < colDoble.GetLength(0); i++)
            {
                for(int j = 0; j < colDoble.GetLength(1); j++)
                {
                    for(int x = 0; x < colDoble.GetLength(0); x++)
                    {
                        for(int y = 0; y < colDoble.GetLength(1); y++)
                        {
                            if(colDoble[i,j] < colDoble[x, y])
                            {
                                int temp = colDoble[i, j];
                                colDoble[i, j] = colDoble[x, y];
                                colDoble[x,y] = temp;
                            }
                        }
                    }
                }
            }

            



            for (int i = 0; i < colDoble.GetLength(0); i++)
            {
                for(int j = 0; j < colDoble.GetLength(1); j++)
                {
                    Console.Write(colDoble[i, j] + "  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("-----");

            Console.WriteLine("-----");

            Console.WriteLine("-----");





            Console.ReadKey();




        }
    }
}
