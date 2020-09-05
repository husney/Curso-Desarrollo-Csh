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
			Console.WriteLine(fecha.ToShortDateString().ToString());//Solo la fecha
			Console.WriteLine(fecha.Year.ToString());//Solo el año
			Console.WriteLine(fecha.Month.ToString());//Solo el mes
			Console.WriteLine(fecha.Day.ToString());//Solo el día
			Console.WriteLine(fecha.DayOfWeek.ToString());//Nombre del día de la semana
			Console.WriteLine(fecha.DayOfYear.ToString());//Numero del día en el año
			Console.WriteLine(fecha.Hour.ToString());//Hora
			Console.WriteLine(fecha.Minute.ToString());//Minuto
			Console.WriteLine();
			Console.WriteLine(fecha2.ToString());

            DateTime fechaN = new DateTime(2000, 01, 01);

            DateTime fechaNueva = Convert.ToDateTime(fechaN.ToString("dd/MM/yyyy"));

            Console.WriteLine("-----");
            Console.WriteLine(fechaNueva.ToShortDateString().ToString());

            Console.WriteLine();

            DateTime fechaZ = DateTime.Today.AddDays(-100);


            int buscarDias = DateTime.DaysInMonth(2020, 1);

            DateTime fechaPrueba = DateTime.Now;

            string formato = "MMM > ddd > yyyy > HH > mm ";

            Console.Write(fechaPrueba.ToString(formato));

            Console.WriteLine();                        
            
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
	