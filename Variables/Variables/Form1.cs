using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Console.WriteLine(fecha.ToShortDateString().ToString());
			Console.WriteLine(fecha.Year.ToString());
			Console.WriteLine(fecha.Month.ToString());
			Console.WriteLine(fecha.Day.ToString());
			Console.WriteLine(fecha.DayOfWeek.ToString());
			Console.WriteLine(fecha.DayOfYear.ToString());
			Console.WriteLine(fecha.Hour.ToString());
			Console.WriteLine(fecha.Minute.ToString());
			Console.WriteLine();
			Console.WriteLine(fecha2.ToString());
		}

		//String = objeto
		String nombre = "Pepe";

		//string Tipo de dato
		string nombre2 = "Pepe2";

		//Numero entero positivo o nevativo
		int numero = 15;

		//Número entero positivo
		uint numero1 = 10;

		double numero2 = 10.5;

		float numero3 = 100.31f;

		//Número con gran cantidad
		decimal numero4 = 1321900909.5324m;

		//Número maximo 255
		byte numero5 = 255;

		bool acceso = true;

		//Boolean como objeto
		Boolean miembro = false;

		DateTime fecha = DateTime.Now;

		DateTime fecha2 = new DateTime(2020, 02, 10);
		





	}
}
	