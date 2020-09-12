using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_en_Form
{
    public partial class Form1 : Form
    {
        List<string> nombres;
        public Form1()
        {
            InitializeComponent();

            nombres = new List<string>();
          
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.nombres.Add(this.txtElemento.Text);
            listar();
        }

        private void listar()
        {
            this.lista.DataSource = null;
            this.lista.DataSource = nombres;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            int index = nombres.IndexOf(this.txtBuscar.Text);
            nombres.Remove(this.txtBuscar.Text);
            nombres.Insert(index, this.txtReemplazar.Text);
            listar();
        }
    }
}

