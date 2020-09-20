using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Creacion_de_archivos_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ruta;
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string ruta = @"D:\C#\Creacion de archivos txt\text.txt";
            TextReader reader = new StreamReader(ruta);

            try
            {
                MessageBox.Show(reader.ReadToEnd());
                //ReadLine() lee una linea
                //ReadToEnd() Lee todo el archivo

            }catch (Exception ex) { }
            reader.Close();
                        
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //string ruta = @"D:\C#\Creacion de archivos txt\text.txt";
            try
            {
                TextWriter writer = new StreamWriter(this.ruta);

                writer.Write(this.richTextBox1.Text);
                writer.Close();
                MessageBox.Show("Guardado");
            }
            catch(Exception ex)
            {

            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.Title = "Buscar archivo"; //Titulo
                 //Filtros
                 //this.openFileDialog.Filter = "Documentos |*.doc";
                 //this.openFileDialog.Filter = "Imagenes png |*.png";
                this.openFileDialog.ShowDialog(); //Mostrar selector de archivos


                if (File.Exists(this.openFileDialog.FileName))
                {
                    //Ruta del archivo seleccionado
                    this.ruta = this.openFileDialog.FileName;
                    //Lector de archivos               ruta de archivo a leer
                    TextReader reader = new StreamReader(this.ruta);

                    //Asignación de texto al richtexbox
                    this.richTextBox1.Text = reader.ReadToEnd();
                    this.txtRuta.Text = this.ruta;
                    reader.Close();
                }
                }catch(Exception ex)
            {

            }

        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {   //Verificamos si guarda el archivo en la ruta seleccionada
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Obtenemos la ruta en donde se guardará el archivo
                    this.ruta = this.saveFileDialog1.FileName;
                    
                    //Objeto para escribir
                    TextWriter writer = new StreamWriter(ruta);

                    //Escribimos lo que esta en el texto
                    writer.Write(this.richTextBox1.Text);
                    //Limpiar memoria y guardar en tiempo real
                    writer.Flush();
                    //Guarda y cierra el objeto
                    writer.Close();
                }
            }catch(Exception ex)
            {

            }
        }
    }
}
