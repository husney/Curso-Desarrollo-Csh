using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;

namespace Camara
{
    public partial class Form1 : Form
    {
        private bool dispositivos = false;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice camara;
        private string path = @"D:\C#\Camara\Camara\";

        public Form1()
        {
            InitializeComponent();
            buscarDispositivos();
            

        }

        public void buscarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(misDispositivos.Count > 0)
            {
                dispositivos = true;
                for(int i = 0; i < misDispositivos.Count; i++)
                {
                    this.comboBox1.Items.Add(misDispositivos[i].Name.ToString());

                }
                comboBox1.Text= misDispositivos[0].Name.ToString();


            }
        }

        public void cerrarWebCam()
        {
            if(camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            int predeterminada = comboBox1.SelectedIndex;
            string video = misDispositivos[predeterminada].MonikerString;
            camara = new VideoCaptureDevice(video);
            camara.NewFrame += new NewFrameEventHandler(capturando);
            camara.Start();
            estadoBoton();


        }

        public void estadoBoton()
        {
            if (camara!= null && camara.IsRunning)
            {
                this.button1.Text = "Detener";
            }
            else
            {
                this.button1.Text = "Iniciar";
            }
        }

        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap captura = (Bitmap)eventArgs.Frame.Clone();
            this.imagen.Image = captura;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarWebCam();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (camara!= null && camara.IsRunning)
            {
                pictureBox1.Image = imagen.Image;
                pictureBox1.Image.Save(path + "imagen.jpg", ImageFormat.Jpeg);

                DataAccess.Conexion c = new DataAccess.Conexion();
                c.getConexion();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess.Conexion con = new DataAccess.Conexion();
            SqlConnection c = con.getConexion();

            String query = "INSERT INTO imagen(IMG) VALUES(@imagen)";
            try
            {
                // Image img = this.pictureBox1.Image;
                byte[] img = imagenToArray(this.pictureBox1.Image);
                SqlCommand comando = new SqlCommand(query, c);
                comando.Parameters.AddWithValue("@imagen", img );
                comando.ExecuteNonQuery();
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                MessageBox.Show(ex.ToString());
                
            }
        }

        public byte[] imagenToArray(System.Drawing.Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imagen img = new imagen();
            img.Visible = true;
        }
    }
}
