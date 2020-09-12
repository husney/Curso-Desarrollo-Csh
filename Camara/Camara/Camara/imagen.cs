using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camara
{
    public partial class imagen : Form
    {
        public imagen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void imagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void imagen_Load(object sender, EventArgs e)
        {
            DataAccess.Conexion con = new DataAccess.Conexion();
            String query = "SELECT IMG FROM imagen ORDER BY ID DESC";
            SqlConnection c = con.getConexion();
            SqlCommand comand = new SqlCommand(query, c);

            SqlDataAdapter dp = new SqlDataAdapter(comand);
            DataSet datos = new DataSet("IMG");

            byte[] imagen = new byte[0];

            dp.Fill(datos, "IMG");

            DataRow linea = datos.Tables["IMG"].Rows[0];
            imagen = (byte[])linea["IMG"];
            MemoryStream ms = new MemoryStream(imagen);
            this.pictureBox1.Image = Image.FromStream(ms);


        }
    }
}
