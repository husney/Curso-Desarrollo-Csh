using System;

namespace Do_While
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * iterador
			 * 
			 * do{
			 * 
			 * Haga...
			 * 
			 * aumeto o decremento del iterador
			 * 
			 * }while(condición);
			 * 
			 */

			int iterador = 0;

			do
			{
				Console.WriteLine(iterador);

				iterador++;
			} while (iterador <= 10);



			Console.ReadLine();


		}
	}
}
