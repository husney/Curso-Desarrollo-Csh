using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Camara_en_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private bool dispositivos = false;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice camara;
        private string path = @"C:\";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                
            }

        }

        public void imagen64(object sender, EventArgs e)
        {
         
        }

        public void guardarFoto(object sender, EventArgs e)
        {

            using (DataAccess.Conexion con = new DataAccess.Conexion())
            {
                SqlConnection c = con.getConexion();
                string query = "INSERT INTO imagen (IMG) VALUES(@imagenWeb)";

                

                try
                {
                    String base64 = this.HiddenField1.Value;
                    //base64.Replace("\"", "");
                    String p1 = base64.Replace("data:image/png;base64,", String.Empty);

                    byte[] pr1 = Convert.FromBase64String(p1);
                    //byte[] imagenInBytes = Convert.FromBase64String(this.HiddenField1.Value.ToString());
                    //byte[] a = File.ReadAllBytes(@"C:\Users\Administrador\Downloads\CapturaImagen (54).png");
                    SqlCommand comando = new SqlCommand(query, c);
                    //comando.Parameters.AddWithValue("@imagen", FileUpload1.FileBytes);
                    comando.Parameters.AddWithValue("@imagenWeb", pr1);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            

        }

        public void mostrarUltimaImagen(object sender, EventArgs e)
        {
            using(DataAccess.Conexion con = new DataAccess.Conexion())
            {
                SqlConnection c = con.getConexion();
                string query = "SELECT imagen FROM imagen ORDER BY ID DESC";
                //string query = "SELECT IMG FROM imagen ORDER BY ID DESC";
                try
                {
                    SqlCommand comando = new SqlCommand(query, c);
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        this.dbImage.Src = lector["imagen"].ToString();
                        //this.dbImage.Src = lector["imagen"].ToString();
                    }



                }
                catch (Exception ex)
                {


                }
            }
        }

        

        public byte[] convertirBytes(System.Drawing.Image img)
        {
            return null;
        }

       
    }
}