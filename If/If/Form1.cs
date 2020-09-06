using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {



         string user = "user";
         string pass = "password";

            if (user.Equals(this.txtUser.Text))
            {
                MessageBox.Show("Usuario Correcto");

                if (pass.Equals(this.txtPassword.Text)){
                    MessageBox.Show("Contraseña Correcta");
                }else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }else
            {
                MessageBox.Show("Usuario Incorrecto");
            }

            var dia = 1;

            switch (dia)
            {
                case 1:
                    MessageBox.Show("Monday");
                    break;

                case 2:
                    MessageBox.Show("Tuesday");
                    break;

                case 3:
                    MessageBox.Show("Wednesday");
                    break;

                case 4:
                    MessageBox.Show("Thrusday");
                    break;

                case 5:
                    MessageBox.Show("Friday");
                    break;

                case 6:
                    MessageBox.Show("Saturday");
                    break;

                case 7:
                    MessageBox.Show("Sunday");
                    break;

                default:
                    MessageBox.Show("Dia no valido");
                    break;
            }


            //(condición) ? True : False ;

            String numero = (5 > 3) ? "Es mayor a 5" : "Es menor a 5";

            bool autenticado = true;

//            (autenticado) ? Console.WriteLine("Autenticado") : Console.WriteLine("No autenticado");

            Console.WriteLine((autenticado) ? "Autenticado" : "No autenticado");
        }
    }
}
