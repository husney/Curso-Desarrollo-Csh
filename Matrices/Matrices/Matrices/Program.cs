using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numeros = new int[5, 10];

            Random r = new Random();

            for(int i = 0; i < numeros.GetLength(0); i++)
            {
                for(int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = r.Next(1, 500);
                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write(numeros[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ordenando...");

            for(int i = 0; i < numeros.GetLength(0); i++)
            {
                for(int j = 0; j < numeros.GetLength(1); j++)
                {
                    for(int x = 0; x < numeros.GetLength(0); x++)
                    {
                        for(int y = 0; y < numeros.GetLength(1); y++)
                        {
                            if(numeros[i, j] < numeros[x, y])
                            {
                                int temp = numeros[i, j];
                                numeros[i, j] = numeros[x, y];
                                numeros[x, y] = temp;
                            }
                        }
                    }
                }
            }

            for(int i = 0; i < numeros.GetLength(0); i++)
            {
                for(int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write(numeros[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        
    }
}
