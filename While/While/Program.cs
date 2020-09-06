using System;

namespace While
{
	class Program
	{
		static void Main(string[] args)
		{

			/*
			 * 
			 iterador

			while(condición){
				Haga...

				aumento o decremento del iterador
			}
			 
			 */

			int i = 0;

			while(i <= 10)
			{
				Console.WriteLine(i);
				i++;
			}


			Console.ReadKey();
		}
	}
}
