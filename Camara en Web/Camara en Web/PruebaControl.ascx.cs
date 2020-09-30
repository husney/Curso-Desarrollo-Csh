using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Camara_en_Web
{
    public partial class PruebaControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarFotoInstantanea(object sender, EventArgs e)
        {
            try
            {
                String base64 = this.imagenBase64.Value;
                String datosImagen = base64.Replace("data:image/png;base64,", String.Empty);
                byte[] capturaFoto = Convert.FromBase64String(datosImagen);


                //CrearControladorFoto();
                //PacienteImagenEntity foto = new PacienteImagenEntity();
                //foto.Imagen = capturaFoto;
                //foto.TipoImagen = TiposImagenes.Foto;
                //foto.Nombre = this.NombreTextBox1.Text;
                //foto.TipoMime = "image/png";
                //SessionPacientes.Paciente.Imagenes.Clear();
                //SessionPacientes.Paciente.Imagenes.Crear(foto);

                //FotoUploadFile.ImageControl = null;
                //this.FotoImage.ImageUrl = null;
                //this.FotoImage.ImageUrl = base64;

            }
            catch (Exception exc)
            {
                //MostrarMensaje(exc);
            }
        }
    }
}