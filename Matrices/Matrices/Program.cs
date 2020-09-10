using System;

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
				for(int j = 0; j <numeros.GetLength(1); j++)
				{
					numeros[i, j] = r.Next(1, 500);
				}
			}


			for(int i = 0; i < numeros.GetLength(0); i++)
			{
				for(int j = 0; j <numeros.GetLength(1); j++)
				{
					Console.Write(numeros[i, j]);
				}
				Console.WriteLine();
			}
		}



		Console. 
	}
}
