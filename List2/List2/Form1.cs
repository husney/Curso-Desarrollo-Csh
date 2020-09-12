using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List2
{
    public partial class Form1 : Form
    {
        private List<string> nombres;
        public Form1()
        {
            InitializeComponent();
            this.nombres = new List<string>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.nombres.Add(this.txtNuevo.Text);
            listar();
        }

        private void listar()
        {
            this.lista.DataSource = null;
            this.lista.DataSource = nombres;
            
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            

            int index = this.nombres.IndexOf(this.txtBuscar.Text);
            nombres.Remove(this.txtBuscar.Text);
            nombres.Insert(index, this.txtReemplazar.Text);
            listar();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void lista_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtBuscar.Text = nombres.ElementAt(this.lista.SelectedIndex);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            nombres.Remove(this.txtBuscar.Text);
            listar();
        }
    }
}
