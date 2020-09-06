using System;

namespace ForEach
{
	class Program
	{
		static void Main(string[] args)
		{
			int []group = new int[5];

			foreach (int numero in group)
			{
				Console.WriteLine(numero);
			}


			/*
				foreach(tipoDato valor in array){
					Haga...
				}		
			 */


			Random r = new Random();
			for(int i = 0; i < group.Length; i++)
			{
				group[i] = r.Next(1, 150);
				
			}

			for(int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}

			int it = 0;

			Console.WriteLine("---------------");

			while (it < group.Length)
			{
				Console.WriteLine(group[it]);
				it++;
			}

			Console.WriteLine("------------------");

			int itDo = 0;

			do
			{
				Console.WriteLine(group[itDo]);
				itDo++;
			} while (itDo < group.Length);

			Console.WriteLine("----------------");

			for(int i = 0; i < group.Length; i++)
			{
				for(int j = 0; j < group.Length - 1; j++)
				{
					if(group[j] > group[j + 1])
					{
						int aux = group[j];
						group[j] = group[j + 1];
						group[j + 1] = aux;
					}
				}
			}

			Console.WriteLine("----------------");

			for (int i = 0; i <= 10; i++)
			{				
				if(i == 5)
				{
					continue;
				}

				Console.WriteLine(i);
			}



			Console.ReadKey();
		}
	}
}
