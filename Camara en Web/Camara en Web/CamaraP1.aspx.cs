using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Data;

namespace Camara_en_Web
{
    public partial class CamaraP1 : System.Web.UI.Page
    {
        private bool dispositivos;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice camara;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
              //  buscarDispositivos();
            }
            //this.Image1.ImageUrl = "https://vignette.wikia.nocookie.net/godofhighschool/images/c/c5/Jin_Mo-Ri.jpg/revision/latest?cb=20161226144904";


        }

        private void buscarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(misDispositivos.Count > 0)
            {
                dispositivos = true;
                for(int i = 0; i < misDispositivos.Count; i++)
                {
                    this.DropDownList1.Items.Add(misDispositivos[i].Name.ToString());
                }
                this.DropDownList1.Text = misDispositivos[0].ToString();
            }
        }

        private void cerrarCamara()
        {
            if(camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara = null;
            }
        }
        

        

        private void iniciarCamara(object sender, EventArgs e){
            cerrarCamara();
            int predeterminada = this.DropDownList1.SelectedIndex;
            string video = misDispositivos[predeterminada].ToString();
            camara = new VideoCaptureDevice(video);
            camara.NewFrame += new NewFrameEventHandler(captura);
            camara.Start();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cerrarCamara();
            Console.WriteLine(this.DropDownList1.Items);
                int predeterminada = this.DropDownList1.SelectedIndex;
                string video = misDispositivos[predeterminada].MonikerString;
                camara = new VideoCaptureDevice(video);
                camara.NewFrame += new NewFrameEventHandler(captura);
                camara.Start();
                //this.Image1.ImageUrl = null;
        }

        

        private void captura(Object sender, NewFrameEventArgs eventArgs)
        {
            //IDataSource img = (IDataSource)eventArgs.Frame.Clone();
            //GridView1.DataSource = img;
            //GridView1.DataBind();

            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            byte[] captura = toBytes(frame);

           using(MemoryStream ms = new MemoryStream(captura))
            {
                this.GridView1.DataSource= "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                
            }

            this.Label1.Text = "Capturando";


            //using (MemoryStream ms = new MemoryStream(captura))
            //{

            //    this.Image1.ImageUrl = "data:image/png;base64" + Convert.ToBase64String(captura);
            //    this.Image1.DataBind();
            //}




            //for(int x = 0; x < capturando.Width; x++)
            //{
            //    for(int y = 0; y < capturando.Height; y++)
            //    {
            //        Color pixelColor = capturando.GetPixel(x, y);
            //        Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
            //        capturando.SetPixel(x, y, newColor);
            //    }
            //}


        }

        private System.Drawing.Image byteArrayToImage(byte[] datos)
        {
            MemoryStream ms = new MemoryStream(datos);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;

        }

        private byte[] toBytes(System.Drawing.Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();

        }

        
    }
}